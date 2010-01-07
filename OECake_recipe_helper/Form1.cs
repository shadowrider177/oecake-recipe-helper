    //This program is free software: you can redistribute it and/or modify
    //it under the terms of the GNU General Public License as published by
    //the Free Software Foundation, either version 3 of the License, or
    //(at your option) any later version.

    //This program is distributed in the hope that it will be useful,
    //but WITHOUT ANY WARRANTY; without even the implied warranty of
    //MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    //GNU General Public License for more details.

    //You should have received a copy of the GNU General Public License
    //along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using DotNetWikiBot;

namespace OECake_recipe_helper
{
    public partial class frmMain : Form
    {
        //Import and setup for key-posting to OE-Cake.
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

        [DllImport("User32.Dll", EntryPoint = "PostMessageA")]
        static extern bool PostMessage(IntPtr hWnd, uint msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        static extern byte VkKeyScan(char ch);

        const uint WM_KEYDOWN = 0x100;

        string version = "3b"; //Naked number = final, main release, {X}d = development, {X}b = beta, {X}l = legacy

        Site site = null;

        public frmMain()
        {
            InitializeComponent();
            lvwRecipes.Groups.Add("grpFilter", "Filter results");
            lvwRecipes.Groups.Add("grpMain", "Main");
        }

        private void cmdAnalyze_Click(object sender, EventArgs e)
        {
            //Dump version info if requested
            if (txtRecipe.Text == "#version") { MessageBox.Show("Version: " + version); return; }

            //PEBKAC check
            if (string.IsNullOrEmpty(txtRecipe.Text)) { MessageBox.Show("Please enter a recipe", "Error"); return; }

            //Fill the box
            filllistbox();


        }
        private void filllistbox()
        {
            //Push the big red 'RESET' button!
            txtCondensed.Text = "";
            txtTags.Text = "";
            lstMaterials.Items.Clear();
            lstProperties.Items.Clear();

            char[] contents = recipecontents(txtRecipe.Text);
            foreach (char c in contents)
            {
                switch (c) //Massive switch to write recipe contents to output box (there must be a more efficient way??)
                {
                    case 'q':
                        lstMaterials.Items.Add("Water [Q]");
                        break;
                    case 'w':
                        lstMaterials.Items.Add("Wall [W]");
                        break;
                    case 'r':
                        lstMaterials.Items.Add("Rigid [R]");
                        break;
                    case 'e':
                        lstMaterials.Items.Add("Elastic [E]");
                        break;
                    case 's':
                        lstMaterials.Items.Add("String [S]");
                        break;
                    case 'x':
                        lstMaterials.Items.Add("Rigid Axis [X]");
                        break;
                    case 'b':
                        lstMaterials.Items.Add("Brittle [B]");
                        break;
                    case 'p':
                        lstMaterials.Items.Add("Powder [P]");
                        break;
                    case 'v':
                        lstMaterials.Items.Add("Viscous [V]");
                        break;
                    case 't':
                        lstMaterials.Items.Add("Tensile [T]");
                        break;
                    case 'f':
                        lstMaterials.Items.Add("Fuel [F]");
                        break;
                    case '@':
                        lstMaterials.Items.Add("Fire [@]");
                        break;
                    case 'c':
                        lstMaterials.Items.Add("Cooler [C]");
                        break;
                    case 'h':
                        lstMaterials.Items.Add("Heater [H]");
                        break;
                    case 'd':
                        lstMaterials.Items.Add("Dense [D]");
                        break;
                    case 'l':
                        lstMaterials.Items.Add("Light [L]");
                        break;
                    case 'g':
                        lstMaterials.Items.Add("Gas [G]");
                        break;
                    case 'm':
                        lstMaterials.Items.Add("Mochi [M]");
                        break;
                    case 'k':
                        lstMaterials.Items.Add("Rice [K]");
                        break;
                    case 'j':
                        lstMaterials.Items.Add("Jet [J]");
                        break;
                    case 'i':
                        lstMaterials.Items.Add("Inflow [I]");
                        break;
                    case 'o':
                        lstMaterials.Items.Add("Outflow [O]");
                        break;
                    case 'u':
                        lstMaterials.Items.Add("User [U]");
                        break;
                    case 'y':
                        lstMaterials.Items.Add("Snow [Y]");
                        break;
                    case 'n':
                        lstMaterials.Items.Add("Null [N]");
                        break;
                    case 'a':
                        lstMaterials.Items.Add("Null [A]");
                        break;
                    default:
                        break;
                }

            }
            //Fill 'condensed form' textbox
            string cond = new string(contents);
            txtCondensed.Text = cond;

            //Fill 'other properties' listbox
            if (contents.Contains('c') && contents.Contains('h'))
            {
                lstProperties.Items.Add("Cool heat effect: material will condense steam, ignite fuel & melt elastic but won't evaporate water");
            }
            if (contents.Contains('p') && (contents.Contains('h') || contents.Contains('@')))
            {
                lstProperties.Items.Add("Material will 'explode' or dissipate instantly");
            }
            if (contents.Contains('p') && contents.Contains('e') && !contents.Contains('i'))
            {
                lstProperties.Items.Add("Material may have unpredictable reactions to gravity");
            }
            if (contents.Contains('n') && contents.Contains('a'))
            {
                lstProperties.Items.Add("Material will contain both null varieties ('a' does not cancel 'n' and vice versa)");
            }
            if (contents.Contains('i') && contents.Contains('m') && !(contents.Contains('p') && (contents.Contains('h') || contents.Contains('@'))))
            {
                lstProperties.Items.Add("Material will self-replicate in large quantities on impact.");
            }
            if (contents.Contains('r') && contents.Contains('t') && contents.Contains('f') && contents.Contains('h') && contents.Contains('g'))
            {
                lstProperties.Items.Add("Material will emit Baker-Bertrand particles");
            }
        }
        private static char[] recipecontents(string r)
        {
            /* This function is the meat of the analysis process. It determines the consituent elements of a recipe */
            char[] validcharacters = new char[] { 'q', 'w', 'r', 'e', 's', 'x', 'p', 'b', 'v', 't', 'f', '@', 'c', 'h', 'd', 'l', 'g', 'm', 'k', 'j', 'i', 'o', 'u', 'y', 'n', 'a' };
            System.Collections.ArrayList al = new System.Collections.ArrayList();
            foreach (char c in r.ToLower())
            {
                if (al.Contains(c))
                {
                    al.Remove(c);
                }
                else if (validcharacters.Contains(c))
                {
                    al.Add(c);
                }
            }
            return (char[])al.ToArray(typeof(char));
        }

        private void cmdSend_Click(object sender, EventArgs e)
        {
            /* This code is somewhat experimental. Do not blame me for any explosions, alien invasions
             * or other world-ending scenarios that happen as a result of running it.
             * OE-Cake must be running for this craziness to work. kthx.*/
            Process[] procs = Process.GetProcessesByName("OECake");
            const int VK_ESCAPE = 0x1B;
            foreach (Process proc in procs)
            {
                if (proc.MainWindowTitle.Contains("OE-CAKE!"))
                {
                    IntPtr hWnd = FindWindowEx(proc.MainWindowHandle, IntPtr.Zero, "AfxFrameOrView80", null);
                    string s = txtCondensed.Text;
                    PostMessage(hWnd, WM_KEYDOWN, VK_ESCAPE, 0);
                    for (int i = 0; i < s.Length; i++)
                    {
                        PostMessage(hWnd, WM_KEYDOWN, VkKeyScan(s[i]), 0);
                    }
                    PostMessage(hWnd, WM_KEYDOWN, VK_ESCAPE, 0);
                    break;
                }
            }
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            //Adds the current recipe to the listbox
            if (!string.IsNullOrEmpty(txtRecipe.Text) && !string.IsNullOrEmpty(txtCondensed.Text))
            {
                string[] items = new string[] { txtRecipe.Text, txtCondensed.Text, txtComment.Text, txtTags.Text };
                ListViewItem newrecipe = new ListViewItem(items,lvwRecipes.Groups[1]);
                lvwRecipes.Items.Add(newrecipe);
            }
        }

        private void cmdRemove_Click(object sender, EventArgs e)
        {
            //Removes the current selection from the listbox
            foreach (ListViewItem i in lvwRecipes.SelectedItems)
            {
                lvwRecipes.Items.Remove(i);
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            svfData.ShowDialog();
        }

        private void cmdWiki_Click(object sender, EventArgs e)
        {
            //Downloads the list of recipes from the wiki
            this.Cursor = Cursors.WaitCursor;
            site = new Site("http://oecake.wikia.com/", "", "");
            Page pgeRecipes = new Page(site, "Recipes");
            pgeRecipes.Load();
            string wikirecipes = pgeRecipes.text;
            MatchCollection recipes = Regex.Matches(wikirecipes, @"\{\{[\s]?Recipe[\s]?\|[\s]?([^|}]*?)[\s]?\|[\s]?([^|}]*?)[\s]?\}\}");
            ListViewItem fromwiki = null;
            string[] items; //Out of the loop to avoid recreating it each iteration.
            foreach (Match m in recipes)
            {
                items = new string[] { m.Groups[1].Value.Replace("[", "").Replace("]", "").ToLower(), new string(recipecontents(m.Groups[1].Value)), m.Groups[2].Value.Replace("[", "").Replace("]", ""), "" };
                fromwiki = new ListViewItem(items,lvwRecipes.Groups[1]);
                lvwRecipes.Items.Add(fromwiki);
            }
            this.Cursor = Cursors.Default;
        }

        private void lvwRecipes_ItemActivate(object sender, EventArgs e)
        {
            //Loads recipe info to boxes for editing on double-click
            txtRecipe.Text = lvwRecipes.SelectedItems[0].SubItems[0].Text;
            txtComment.Text = lvwRecipes.SelectedItems[0].SubItems[2].Text;
            txtTags.Text = lvwRecipes.SelectedItems[0].SubItems[3].Text;

            //No filling of condensed textbox as method below takes care of that.
            filllistbox();
        }

        private void cmdLoad_Click(object sender, EventArgs e)
        {
            opfData.ShowDialog();
        }

        private void opfData_FileOk(object sender, CancelEventArgs e)
        {
            //Reads data from selected file and shoves it in the listview
            StreamReader sr = new StreamReader(opfData.FileName);
            string read = sr.ReadLine();
            string[] linesplit;
            ListViewItem fromfile = null;
            string[] items;
            while (!string.IsNullOrEmpty(read))
            {
                linesplit = read.Split('|');
                items = new string[] { linesplit[1], linesplit[2], linesplit[3], linesplit[4] };
                fromfile = new ListViewItem(items, lvwRecipes.Groups[1]);
                lvwRecipes.Items.Add(fromfile);
                read = sr.ReadLine();
            }
            opfData.Dispose();
        }

        private void svfData_FileOk(object sender, CancelEventArgs e)
        {
            //Saves data to oeh file
            StreamWriter sw = new StreamWriter(svfData.FileName);
            foreach (ListViewItem i in lvwRecipes.Items)
            {
                sw.Write("|");
                foreach (ListViewItem.ListViewSubItem s in i.SubItems)
                {
                    sw.Write(s.Text + "|");
                }
                sw.Write(System.Environment.NewLine);
            }
            sw.Close();
            sw.Dispose();
            svfData.Dispose();
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            lvwRecipes.Items.Clear();
        }

        //FILTER CODE
        System.Collections.ArrayList al = new System.Collections.ArrayList();
        //START of large checkbox flipping code block
        private void chkBrittle_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBrittle.Checked == true)
            {
                al.Add("b");
            }
            else
            {
                al.Remove("b");
            }
        }

        private void chkCooler_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCooler.Checked == true)
            {
                al.Add("c");
            }
            else
            {
                al.Remove("c");
            }
        }

        private void chkDense_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDense.Checked == true)
            {
                al.Add("d");
            }
            else
            {
                al.Remove("d");
            }
        }

        private void chkElastic_CheckedChanged(object sender, EventArgs e)
        {
            if (chkElastic.Checked == true)
            {
                al.Add("e");
            }
            else
            {
                al.Remove("e");
            }
        }

        private void chkFire_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFire.Checked == true)
            {
                al.Add("@");
            }
            else
            {
                al.Remove("@");
            }
        }

        private void chkFuel_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFuel.Checked == true)
            {
                al.Add("f");
            }
            else
            {
                al.Remove("f");
            }
        }

        private void chkGas_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGas.Checked == true)
            {
                al.Add("g");
            }
            else
            {
                al.Remove("g");
            }
        }

        private void chkHeater_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHeater.Checked == true)
            {
                al.Add("h");
            }
            else
            {
                al.Remove("h");
            }
        }

        private void chkInflow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkInflow.Checked == true)
            {
                al.Add("i");
            }
            else
            {
                al.Remove("i");
            }
        }

        private void chkJet_CheckedChanged(object sender, EventArgs e)
        {
            if (chkJet.Checked == true)
            {
                al.Add("j");
            }
            else
            {
                al.Remove("j");
            }
        }

        private void chkLight_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLight.Checked == true)
            {
                al.Add("l");
            }
            else
            {
                al.Remove("l");
            }
        }

        private void chkMochi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMochi.Checked == true)
            {
                al.Add("m");
            }
            else
            {
                al.Remove("m");
            }
        }

        private void chkAnull_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAnull.Checked == true)
            {
                al.Add("a");
            }
            else
            {
                al.Remove("a");
            }
        }

        private void chkNnull_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNnull.Checked == true)
            {
                al.Add("n");
            }
            else
            {
                al.Remove("n");
            }
        }

        private void chkOutflow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOutflow.Checked == true)
            {
                al.Add("o");
            }
            else
            {
                al.Remove("o");
            }
        }

        private void chkPowder_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPowder.Checked == true)
            {
                al.Add("p");
            }
            else
            {
                al.Remove("p");
            }
        }

        private void chkRice_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRice.Checked == true)
            {
                al.Add("k");
            }
            else
            {
                al.Remove("k");
            }
        }

        private void chkRigid_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRigid.Checked == true)
            {
                al.Add("r");
            }
            else
            {
                al.Remove("r");
            }
        }

        private void chkAxis_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAxis.Checked == true)
            {
                al.Add("x");
            }
            else
            {
                al.Remove("x");
            }
        }

        private void chkSnow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSnow.Checked == true)
            {
                al.Add("y");
            }
            else
            {
                al.Remove("y");
            }
        }

        private void chkString_CheckedChanged(object sender, EventArgs e)
        {
            if (chkString.Checked == true)
            {
                al.Add("s");
            }
            else
            {
                al.Remove("s");
            }
        }

        private void chkTensile_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTensile.Checked == true)
            {
                al.Add("t");
            }
            else
            {
                al.Remove("t");
            }
        }

        private void chkUser_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUser.Checked == true)
            {
                al.Add("u");
            }
            else
            {
                al.Remove("u");
            }
        }

        private void chkViscous_CheckedChanged(object sender, EventArgs e)
        {
            if (chkViscous.Checked == true)
            {
                al.Add("v");
            }
            else
            {
                al.Remove("v");
            }
        }

        private void chkWall_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWall.Checked == true)
            {
                al.Add("w");
            }
            else
            {
                al.Remove("w");
            }
        }

        private void chkWater_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWater.Checked == true)
            {
                al.Add("q");
            }
            else
            {
                al.Remove("q");
            }
        }
        //END of large checkbox flipping code block

        private string[] materials()
        {
            //Returns list of materials that the user wants
            return (string[])al.ToArray(typeof(string));
        }

        private void cmdFilter_Click(object sender, EventArgs e) //filter group is 0, main group is 1
        {
            string[] filtermat = materials(); //Get materials

            //PEBKAC check
            if (filtermat.Length == 0 && string.IsNullOrEmpty(txtTagsFilter.Text)) { MessageBox.Show("Please enter filter criteria.", "Error"); return; }
            lvwRecipes.Groups[1].Items.AddRange(lvwRecipes.Groups[0].Items);

            lvwRecipes.Groups[0].Items.AddRange(filtereditems(filtermat, txtTagsFilter.Text.Split(',')));
        }

        private ListViewItem[] filtereditems(string[] filtermat, string[] filtertags)
        {
            //Returns array containing 'wanted' items
            System.Collections.ArrayList filter = new System.Collections.ArrayList(lvwRecipes.Groups[1].Items);
            foreach (ListViewItem l in lvwRecipes.Items)
            {
                foreach (string s in filtermat)
                {
                    if (!l.SubItems[1].Text.Contains(s))
                    {
                        filter.Remove(l);
                    }
                }

                foreach (string t in filtertags)
                {
                    if (!l.SubItems[3].Text.Contains(t))
                    {
                        filter.Remove(l);
                    }
                }
            }
            return (ListViewItem[])filter.ToArray(typeof(ListViewItem));
        }

        private void cmdClearFilter_Click(object sender, EventArgs e)
        {
            //Not really necessary, but included as a 'just in case'
            lvwRecipes.Groups[1].Items.AddRange(lvwRecipes.Groups[0].Items);
            lvwRecipes.Sort();
        }

        private void lvwRecipes_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            //Again, just in case it's needed
            if (e.Column == 0) { lvwRecipes.Sort(); }
        }

        private void cmdToWiki_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCondensed.Text))
            {
                frmToWiki wikiform = new frmToWiki(txtRecipe.Text, txtCondensed.Text, txtComment.Text);
                wikiform.Show();
            }
        }

    }
}

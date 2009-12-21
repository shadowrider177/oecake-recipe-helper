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

        int version = 1;

        Site site = null;

        public frmMain()
        {
            InitializeComponent();
        }

        private void cmdAnalyze_Click(object sender, EventArgs e)
        {

            //Is user stupid?
            if (string.IsNullOrEmpty(txtRecipe.Text)) { MessageBox.Show("Please enter a recipe", "Error"); return; }

            //Fill the box
            filllistbox();


        }
        private void filllistbox()
        {
            //Push the big red 'RESET' button!
            txtCondensed.Text = "";
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
            if (contents.Contains('p') && contents.Contains('h'))
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
            if (contents.Contains('r') && contents.Contains('t') && contents.Contains('f') && contents.Contains('h') && contents.Contains('g'))
            {
                lstProperties.Items.Add("Material will emit Baker-Bertrand particles");
            }
        }
        static char[] recipecontents(string r)
        {
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
            if (!string.IsNullOrEmpty(txtRecipe.Text) && !string.IsNullOrEmpty(txtCondensed.Text))
            {
                string[] items = new string[] { txtRecipe.Text, txtCondensed.Text, txtComment.Text };
                ListViewItem newrecipe = new ListViewItem(items);
                lvwRecipes.Items.Add(newrecipe);
            }
        }

        private void cmdRemove_Click(object sender, EventArgs e)
        {
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
            this.Cursor = Cursors.WaitCursor;
            site = new Site("http://oecake.wikia.com/", "", "");
            Page pgeRecipes = new Page(site, "Recipes");
            pgeRecipes.Load();
            string wikirecipes = pgeRecipes.text;
            MatchCollection recipes = Regex.Matches(wikirecipes, @"\{\{Recipe\|([^|}]*?)\|([^|}]*?)\}\}");
            ListViewItem fromwiki = null;
            string[] items;
            foreach (Match m in recipes)
            {
                items = new string[] { m.Groups[1].Value.Replace("[", "").Replace("]", "").ToLower(), new string(recipecontents(m.Groups[1].Value)), m.Groups[2].Value.Replace("[", "").Replace("]", "") };
                fromwiki = new ListViewItem(items);
                lvwRecipes.Items.Add(fromwiki);
            }
            lvwRecipes.Items.RemoveAt(0); //Remove example/test recipe from list
            this.Cursor = Cursors.Default;
        }

        private void lvwRecipes_ItemActivate(object sender, EventArgs e)
        {
            txtRecipe.Text = lvwRecipes.SelectedItems[0].SubItems[0].Text;
            txtComment.Text = lvwRecipes.SelectedItems[0].SubItems[2].Text;

            //No filling of condensed textbox as method below takes care of that.
            filllistbox();
        }

        private void cmdLoad_Click(object sender, EventArgs e)
        {
            opfData.ShowDialog();
        }

        private void opfData_FileOk(object sender, CancelEventArgs e)
        {
            StreamReader sr = new StreamReader(opfData.FileName);
            string read = sr.ReadLine();
            string[] linesplit;
            ListViewItem fromfile = null;
            string[] items;
            while (!string.IsNullOrEmpty(read))
            {
                linesplit = read.Split('|');
                items = new string[] { linesplit[1], linesplit[2], linesplit[3] };
                fromfile = new ListViewItem(items);
                lvwRecipes.Items.Add(fromfile);
                read = sr.ReadLine();
            }
            opfData.Dispose();
        }

        private void svfData_FileOk(object sender, CancelEventArgs e)
        {
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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DotNetWikiBot;

namespace OECake_recipe_helper
{
    public partial class frmToWiki : Form
    {
        string condensed, full, pagetext, recipeform;
        string newline = System.Environment.NewLine;

        public frmToWiki(string fullrecipe, string condensedrecipe, string comment)
        {
            InitializeComponent();
            //Initialisation code, take info passed from main form
            this.Text += fullrecipe;
            condensed = condensedrecipe;
            full = fullrecipe;
            txtWikiComment.Text = comment;
        }

        private void frmToWiki_Load(object sender, EventArgs e)
        {
        }

        private void cmdSend_Click(object sender, EventArgs e)
        {
            Site site = new Site("http://oecake.wikia.com/", "OECake Recipe Helper", "QmAz8{o)p87£*6^5tgGRvi");
            Page recipepage = new Page(site, "Recipes");
            recipepage.Load();
            pagetext = recipepage.text;

            if (rdoCondensed.Checked) { recipeform = condensed; } else { recipeform = full; }

            pagetext = Regex.Replace(pagetext, @"==[\s]?\[\[" + cmbSection.SelectedItem.ToString() + @".*?\![\s]?class[\s]?=[\s]?""unsortable""[\s]?\|[\s]?Material properties", @"$&" + newline + "{{Recipe|" + recipeform.ToUpperInvariant() + "|" + txtWikiComment.Text + "}}", RegexOptions.Singleline);
            recipepage.Save(pagetext, "Adding recipe '" + recipeform + "' to list in section: '" + cmbSection.SelectedItem.ToString() + "'", false);
            MessageBox.Show("Operation complete.", "Done");
        }
    }
}
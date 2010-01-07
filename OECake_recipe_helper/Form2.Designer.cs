namespace OECake_recipe_helper
{
    partial class frmToWiki
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rdoFull = new System.Windows.Forms.RadioButton();
            this.rdoCondensed = new System.Windows.Forms.RadioButton();
            this.grpRecipe = new System.Windows.Forms.GroupBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.txtWikiComment = new System.Windows.Forms.TextBox();
            this.lblSection = new System.Windows.Forms.Label();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.cmdSend = new System.Windows.Forms.Button();
            this.grpRecipe.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdoFull
            // 
            this.rdoFull.AutoSize = true;
            this.rdoFull.Location = new System.Drawing.Point(6, 19);
            this.rdoFull.Name = "rdoFull";
            this.rdoFull.Size = new System.Drawing.Size(73, 17);
            this.rdoFull.TabIndex = 0;
            this.rdoFull.TabStop = true;
            this.rdoFull.Text = "Full recipe";
            this.rdoFull.UseVisualStyleBackColor = true;
            // 
            // rdoCondensed
            // 
            this.rdoCondensed.AutoSize = true;
            this.rdoCondensed.Location = new System.Drawing.Point(6, 42);
            this.rdoCondensed.Name = "rdoCondensed";
            this.rdoCondensed.Size = new System.Drawing.Size(79, 17);
            this.rdoCondensed.TabIndex = 1;
            this.rdoCondensed.TabStop = true;
            this.rdoCondensed.Text = "Condensed";
            this.rdoCondensed.UseVisualStyleBackColor = true;
            // 
            // grpRecipe
            // 
            this.grpRecipe.Controls.Add(this.rdoFull);
            this.grpRecipe.Controls.Add(this.rdoCondensed);
            this.grpRecipe.Location = new System.Drawing.Point(12, 12);
            this.grpRecipe.Name = "grpRecipe";
            this.grpRecipe.Size = new System.Drawing.Size(89, 67);
            this.grpRecipe.TabIndex = 2;
            this.grpRecipe.TabStop = false;
            this.grpRecipe.Text = "Recipe form";
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(107, 21);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(54, 13);
            this.lblComment.TabIndex = 3;
            this.lblComment.Text = "Comment:";
            // 
            // txtWikiComment
            // 
            this.txtWikiComment.Location = new System.Drawing.Point(167, 18);
            this.txtWikiComment.Multiline = true;
            this.txtWikiComment.Name = "txtWikiComment";
            this.txtWikiComment.Size = new System.Drawing.Size(178, 53);
            this.txtWikiComment.TabIndex = 4;
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Location = new System.Drawing.Point(115, 80);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(46, 13);
            this.lblSection.TabIndex = 5;
            this.lblSection.Text = "Section:";
            // 
            // cmbSection
            // 
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.Items.AddRange(new object[] {
            "Brittle",
            "Cooler",
            "Dense",
            "Elastic",
            "Fire",
            "Fuel",
            "Gas",
            "Heater",
            "Inflow",
            "Jet",
            "Light",
            "Mochi",
            "Null",
            "Outflow",
            "Powder",
            "Rice",
            "Rigid",
            "Rigid Axis",
            "Snow",
            "String",
            "Tensile",
            "User",
            "Viscous",
            "Wall",
            "Water"});
            this.cmbSection.Location = new System.Drawing.Point(167, 77);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(121, 21);
            this.cmbSection.Sorted = true;
            this.cmbSection.TabIndex = 6;
            this.cmbSection.Text = "Please select...";
            // 
            // cmdSend
            // 
            this.cmdSend.Location = new System.Drawing.Point(12, 85);
            this.cmdSend.Name = "cmdSend";
            this.cmdSend.Size = new System.Drawing.Size(89, 23);
            this.cmdSend.TabIndex = 7;
            this.cmdSend.Text = "Send to wiki";
            this.cmdSend.UseVisualStyleBackColor = true;
            this.cmdSend.Click += new System.EventHandler(this.cmdSend_Click);
            // 
            // frmToWiki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 117);
            this.Controls.Add(this.cmdSend);
            this.Controls.Add(this.cmbSection);
            this.Controls.Add(this.lblSection);
            this.Controls.Add(this.txtWikiComment);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.grpRecipe);
            this.Name = "frmToWiki";
            this.Text = "Send to wiki: ";
            this.Load += new System.EventHandler(this.frmToWiki_Load);
            this.grpRecipe.ResumeLayout(false);
            this.grpRecipe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoFull;
        private System.Windows.Forms.RadioButton rdoCondensed;
        private System.Windows.Forms.GroupBox grpRecipe;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TextBox txtWikiComment;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.ComboBox cmbSection;
        private System.Windows.Forms.Button cmdSend;
    }
}
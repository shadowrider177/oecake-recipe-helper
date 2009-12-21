namespace OECake_recipe_helper
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.txtRecipe = new System.Windows.Forms.TextBox();
            this.cmdAnalyze = new System.Windows.Forms.Button();
            this.lstMaterials = new System.Windows.Forms.ListBox();
            this.lblCondensed = new System.Windows.Forms.Label();
            this.txtCondensed = new System.Windows.Forms.TextBox();
            this.lstProperties = new System.Windows.Forms.ListBox();
            this.cmdSend = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.lvwRecipes = new System.Windows.Forms.ListView();
            this.clmFullCode = new System.Windows.Forms.ColumnHeader();
            this.clmCondensed = new System.Windows.Forms.ColumnHeader();
            this.clmComments = new System.Windows.Forms.ColumnHeader();
            this.cmdRemove = new System.Windows.Forms.Button();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdWiki = new System.Windows.Forms.Button();
            this.cmdLoad = new System.Windows.Forms.Button();
            this.opfData = new System.Windows.Forms.OpenFileDialog();
            this.svfData = new System.Windows.Forms.SaveFileDialog();
            this.cmdClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRecipe
            // 
            this.txtRecipe.Location = new System.Drawing.Point(12, 12);
            this.txtRecipe.Name = "txtRecipe";
            this.txtRecipe.Size = new System.Drawing.Size(155, 20);
            this.txtRecipe.TabIndex = 0;
            // 
            // cmdAnalyze
            // 
            this.cmdAnalyze.Location = new System.Drawing.Point(173, 10);
            this.cmdAnalyze.Name = "cmdAnalyze";
            this.cmdAnalyze.Size = new System.Drawing.Size(96, 23);
            this.cmdAnalyze.TabIndex = 1;
            this.cmdAnalyze.Text = "Analyze!";
            this.cmdAnalyze.UseVisualStyleBackColor = true;
            this.cmdAnalyze.Click += new System.EventHandler(this.cmdAnalyze_Click);
            // 
            // lstMaterials
            // 
            this.lstMaterials.FormattingEnabled = true;
            this.lstMaterials.Location = new System.Drawing.Point(15, 43);
            this.lstMaterials.Name = "lstMaterials";
            this.lstMaterials.Size = new System.Drawing.Size(152, 134);
            this.lstMaterials.Sorted = true;
            this.lstMaterials.TabIndex = 2;
            // 
            // lblCondensed
            // 
            this.lblCondensed.AutoSize = true;
            this.lblCondensed.Location = new System.Drawing.Point(283, 15);
            this.lblCondensed.Name = "lblCondensed";
            this.lblCondensed.Size = new System.Drawing.Size(87, 13);
            this.lblCondensed.TabIndex = 3;
            this.lblCondensed.Text = "Condensed form:";
            // 
            // txtCondensed
            // 
            this.txtCondensed.Location = new System.Drawing.Point(376, 12);
            this.txtCondensed.Name = "txtCondensed";
            this.txtCondensed.ReadOnly = true;
            this.txtCondensed.Size = new System.Drawing.Size(147, 20);
            this.txtCondensed.TabIndex = 4;
            // 
            // lstProperties
            // 
            this.lstProperties.FormattingEnabled = true;
            this.lstProperties.Location = new System.Drawing.Point(173, 43);
            this.lstProperties.Name = "lstProperties";
            this.lstProperties.Size = new System.Drawing.Size(636, 134);
            this.lstProperties.TabIndex = 5;
            // 
            // cmdSend
            // 
            this.cmdSend.Location = new System.Drawing.Point(529, 10);
            this.cmdSend.Name = "cmdSend";
            this.cmdSend.Size = new System.Drawing.Size(96, 23);
            this.cmdSend.TabIndex = 6;
            this.cmdSend.Text = "Send to OECake";
            this.cmdSend.UseVisualStyleBackColor = true;
            this.cmdSend.Click += new System.EventHandler(this.cmdSend_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(12, 386);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(125, 23);
            this.cmdAdd.TabIndex = 8;
            this.cmdAdd.Text = "Add current recipe";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // lvwRecipes
            // 
            this.lvwRecipes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmFullCode,
            this.clmCondensed,
            this.clmComments});
            this.lvwRecipes.FullRowSelect = true;
            this.lvwRecipes.Location = new System.Drawing.Point(12, 209);
            this.lvwRecipes.Name = "lvwRecipes";
            this.lvwRecipes.Size = new System.Drawing.Size(797, 170);
            this.lvwRecipes.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvwRecipes.TabIndex = 9;
            this.lvwRecipes.UseCompatibleStateImageBehavior = false;
            this.lvwRecipes.View = System.Windows.Forms.View.Details;
            this.lvwRecipes.ItemActivate += new System.EventHandler(this.lvwRecipes_ItemActivate);
            // 
            // clmFullCode
            // 
            this.clmFullCode.Text = "Recipe";
            this.clmFullCode.Width = 95;
            // 
            // clmCondensed
            // 
            this.clmCondensed.Text = "Condensed";
            this.clmCondensed.Width = 80;
            // 
            // clmComments
            // 
            this.clmComments.Text = "Comments";
            this.clmComments.Width = 612;
            // 
            // cmdRemove
            // 
            this.cmdRemove.Location = new System.Drawing.Point(143, 386);
            this.cmdRemove.Name = "cmdRemove";
            this.cmdRemove.Size = new System.Drawing.Size(137, 23);
            this.cmdRemove.TabIndex = 10;
            this.cmdRemove.Text = "Remove current selection";
            this.cmdRemove.UseVisualStyleBackColor = true;
            this.cmdRemove.Click += new System.EventHandler(this.cmdRemove_Click);
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(72, 183);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(737, 20);
            this.txtComment.TabIndex = 11;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(12, 186);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(54, 13);
            this.lblComment.TabIndex = 12;
            this.lblComment.Text = "Comment:";
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(367, 386);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 13;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdWiki
            // 
            this.cmdWiki.Location = new System.Drawing.Point(530, 386);
            this.cmdWiki.Name = "cmdWiki";
            this.cmdWiki.Size = new System.Drawing.Size(74, 23);
            this.cmdWiki.TabIndex = 14;
            this.cmdWiki.Text = "DL from wiki";
            this.cmdWiki.UseVisualStyleBackColor = true;
            this.cmdWiki.Click += new System.EventHandler(this.cmdWiki_Click);
            // 
            // cmdLoad
            // 
            this.cmdLoad.Location = new System.Drawing.Point(448, 386);
            this.cmdLoad.Name = "cmdLoad";
            this.cmdLoad.Size = new System.Drawing.Size(75, 23);
            this.cmdLoad.TabIndex = 15;
            this.cmdLoad.Text = "Load";
            this.cmdLoad.UseVisualStyleBackColor = true;
            this.cmdLoad.Click += new System.EventHandler(this.cmdLoad_Click);
            // 
            // opfData
            // 
            this.opfData.Filter = "OE-Cake Recipe file|*.oeh";
            this.opfData.Title = "Choose data file";
            this.opfData.FileOk += new System.ComponentModel.CancelEventHandler(this.opfData_FileOk);
            // 
            // svfData
            // 
            this.svfData.DefaultExt = "oeh";
            this.svfData.Filter = "OE-Cake Recipe files|*.oeh";
            this.svfData.FileOk += new System.ComponentModel.CancelEventHandler(this.svfData_FileOk);
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(286, 386);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(75, 23);
            this.cmdClear.TabIndex = 17;
            this.cmdClear.Text = "Clear";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 421);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.cmdLoad);
            this.Controls.Add(this.cmdWiki);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.cmdRemove);
            this.Controls.Add(this.lvwRecipes);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.cmdSend);
            this.Controls.Add(this.lstProperties);
            this.Controls.Add(this.txtCondensed);
            this.Controls.Add(this.lblCondensed);
            this.Controls.Add(this.lstMaterials);
            this.Controls.Add(this.cmdAnalyze);
            this.Controls.Add(this.txtRecipe);
            this.Name = "frmMain";
            this.Text = "OE-Cake Recipe Helper v0.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRecipe;
        private System.Windows.Forms.Button cmdAnalyze;
        private System.Windows.Forms.ListBox lstMaterials;
        private System.Windows.Forms.Label lblCondensed;
        private System.Windows.Forms.TextBox txtCondensed;
        private System.Windows.Forms.ListBox lstProperties;
        private System.Windows.Forms.Button cmdSend;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.ListView lvwRecipes;
        private System.Windows.Forms.ColumnHeader clmFullCode;
        private System.Windows.Forms.ColumnHeader clmCondensed;
        private System.Windows.Forms.ColumnHeader clmComments;
        private System.Windows.Forms.Button cmdRemove;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdWiki;
        private System.Windows.Forms.Button cmdLoad;
        private System.Windows.Forms.OpenFileDialog opfData;
        private System.Windows.Forms.SaveFileDialog svfData;
        private System.Windows.Forms.Button cmdClear;
    }
}


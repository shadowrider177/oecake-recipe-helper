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
            this.clmFullCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCondensed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmComments = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTags = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmdRemove = new System.Windows.Forms.Button();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdWiki = new System.Windows.Forms.Button();
            this.cmdLoad = new System.Windows.Forms.Button();
            this.opfData = new System.Windows.Forms.OpenFileDialog();
            this.svfData = new System.Windows.Forms.SaveFileDialog();
            this.cmdClear = new System.Windows.Forms.Button();
            this.lblTags = new System.Windows.Forms.Label();
            this.txtTags = new System.Windows.Forms.TextBox();
            this.cmdFilter = new System.Windows.Forms.Button();
            this.grpMaterials = new System.Windows.Forms.GroupBox();
            this.chkInflow = new System.Windows.Forms.CheckBox();
            this.chkHeater = new System.Windows.Forms.CheckBox();
            this.chkGas = new System.Windows.Forms.CheckBox();
            this.chkFuel = new System.Windows.Forms.CheckBox();
            this.chkFire = new System.Windows.Forms.CheckBox();
            this.chkElastic = new System.Windows.Forms.CheckBox();
            this.chkDense = new System.Windows.Forms.CheckBox();
            this.chkCooler = new System.Windows.Forms.CheckBox();
            this.chkBrittle = new System.Windows.Forms.CheckBox();
            this.cmdClearFilter = new System.Windows.Forms.Button();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.chkJet = new System.Windows.Forms.CheckBox();
            this.chkLight = new System.Windows.Forms.CheckBox();
            this.chkMochi = new System.Windows.Forms.CheckBox();
            this.chkAnull = new System.Windows.Forms.CheckBox();
            this.chkNnull = new System.Windows.Forms.CheckBox();
            this.chkOutflow = new System.Windows.Forms.CheckBox();
            this.chkPowder = new System.Windows.Forms.CheckBox();
            this.chkRice = new System.Windows.Forms.CheckBox();
            this.chkRigid = new System.Windows.Forms.CheckBox();
            this.chkAxis = new System.Windows.Forms.CheckBox();
            this.chkSnow = new System.Windows.Forms.CheckBox();
            this.chkString = new System.Windows.Forms.CheckBox();
            this.chkTensile = new System.Windows.Forms.CheckBox();
            this.chkUser = new System.Windows.Forms.CheckBox();
            this.chkViscous = new System.Windows.Forms.CheckBox();
            this.chkWall = new System.Windows.Forms.CheckBox();
            this.chkWater = new System.Windows.Forms.CheckBox();
            this.lblFilterTags = new System.Windows.Forms.Label();
            this.txtTagsFilter = new System.Windows.Forms.TextBox();
            this.grpMaterials.SuspendLayout();
            this.grpFilter.SuspendLayout();
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
            this.cmdAdd.Location = new System.Drawing.Point(174, 386);
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
            this.clmComments,
            this.clmTags});
            this.lvwRecipes.FullRowSelect = true;
            this.lvwRecipes.Location = new System.Drawing.Point(12, 209);
            this.lvwRecipes.Name = "lvwRecipes";
            this.lvwRecipes.Size = new System.Drawing.Size(797, 170);
            this.lvwRecipes.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvwRecipes.TabIndex = 9;
            this.lvwRecipes.UseCompatibleStateImageBehavior = false;
            this.lvwRecipes.View = System.Windows.Forms.View.Details;
            this.lvwRecipes.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwRecipes_ColumnClick);
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
            this.clmComments.Width = 540;
            // 
            // clmTags
            // 
            this.clmTags.Text = "Tags";
            this.clmTags.Width = 80;
            // 
            // cmdRemove
            // 
            this.cmdRemove.Location = new System.Drawing.Point(305, 386);
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
            this.txtComment.Size = new System.Drawing.Size(481, 20);
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
            this.cmdSave.Location = new System.Drawing.Point(529, 386);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 13;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdWiki
            // 
            this.cmdWiki.Location = new System.Drawing.Point(692, 386);
            this.cmdWiki.Name = "cmdWiki";
            this.cmdWiki.Size = new System.Drawing.Size(74, 23);
            this.cmdWiki.TabIndex = 14;
            this.cmdWiki.Text = "DL from wiki";
            this.cmdWiki.UseVisualStyleBackColor = true;
            this.cmdWiki.Click += new System.EventHandler(this.cmdWiki_Click);
            // 
            // cmdLoad
            // 
            this.cmdLoad.Location = new System.Drawing.Point(610, 386);
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
            this.cmdClear.Location = new System.Drawing.Point(448, 386);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(75, 23);
            this.cmdClear.TabIndex = 17;
            this.cmdClear.Text = "Clear";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // lblTags
            // 
            this.lblTags.AutoSize = true;
            this.lblTags.Location = new System.Drawing.Point(559, 186);
            this.lblTags.Name = "lblTags";
            this.lblTags.Size = new System.Drawing.Size(34, 13);
            this.lblTags.TabIndex = 18;
            this.lblTags.Text = "Tags:";
            // 
            // txtTags
            // 
            this.txtTags.Location = new System.Drawing.Point(599, 183);
            this.txtTags.Name = "txtTags";
            this.txtTags.Size = new System.Drawing.Size(210, 20);
            this.txtTags.TabIndex = 19;
            // 
            // cmdFilter
            // 
            this.cmdFilter.Location = new System.Drawing.Point(12, 386);
            this.cmdFilter.Name = "cmdFilter";
            this.cmdFilter.Size = new System.Drawing.Size(75, 23);
            this.cmdFilter.TabIndex = 20;
            this.cmdFilter.Text = "Filter...";
            this.cmdFilter.UseVisualStyleBackColor = true;
            this.cmdFilter.Click += new System.EventHandler(this.cmdFilter_Click);
            // 
            // grpMaterials
            // 
            this.grpMaterials.Controls.Add(this.chkWater);
            this.grpMaterials.Controls.Add(this.chkWall);
            this.grpMaterials.Controls.Add(this.chkViscous);
            this.grpMaterials.Controls.Add(this.chkUser);
            this.grpMaterials.Controls.Add(this.chkTensile);
            this.grpMaterials.Controls.Add(this.chkString);
            this.grpMaterials.Controls.Add(this.chkSnow);
            this.grpMaterials.Controls.Add(this.chkAxis);
            this.grpMaterials.Controls.Add(this.chkRigid);
            this.grpMaterials.Controls.Add(this.chkRice);
            this.grpMaterials.Controls.Add(this.chkPowder);
            this.grpMaterials.Controls.Add(this.chkOutflow);
            this.grpMaterials.Controls.Add(this.chkNnull);
            this.grpMaterials.Controls.Add(this.chkAnull);
            this.grpMaterials.Controls.Add(this.chkMochi);
            this.grpMaterials.Controls.Add(this.chkLight);
            this.grpMaterials.Controls.Add(this.chkJet);
            this.grpMaterials.Controls.Add(this.chkInflow);
            this.grpMaterials.Controls.Add(this.chkHeater);
            this.grpMaterials.Controls.Add(this.chkGas);
            this.grpMaterials.Controls.Add(this.chkFuel);
            this.grpMaterials.Controls.Add(this.chkFire);
            this.grpMaterials.Controls.Add(this.chkElastic);
            this.grpMaterials.Controls.Add(this.chkDense);
            this.grpMaterials.Controls.Add(this.chkCooler);
            this.grpMaterials.Controls.Add(this.chkBrittle);
            this.grpMaterials.Location = new System.Drawing.Point(6, 19);
            this.grpMaterials.Name = "grpMaterials";
            this.grpMaterials.Size = new System.Drawing.Size(785, 66);
            this.grpMaterials.TabIndex = 21;
            this.grpMaterials.TabStop = false;
            this.grpMaterials.Text = "Materials";
            // 
            // chkInflow
            // 
            this.chkInflow.AutoSize = true;
            this.chkInflow.Location = new System.Drawing.Point(469, 19);
            this.chkInflow.Name = "chkInflow";
            this.chkInflow.Size = new System.Drawing.Size(54, 17);
            this.chkInflow.TabIndex = 8;
            this.chkInflow.Text = "Inflow";
            this.chkInflow.UseVisualStyleBackColor = true;
            this.chkInflow.CheckedChanged += new System.EventHandler(this.chkInflow_CheckedChanged);
            // 
            // chkHeater
            // 
            this.chkHeater.AutoSize = true;
            this.chkHeater.Location = new System.Drawing.Point(405, 19);
            this.chkHeater.Name = "chkHeater";
            this.chkHeater.Size = new System.Drawing.Size(58, 17);
            this.chkHeater.TabIndex = 7;
            this.chkHeater.Text = "Heater";
            this.chkHeater.UseVisualStyleBackColor = true;
            this.chkHeater.CheckedChanged += new System.EventHandler(this.chkHeater_CheckedChanged);
            // 
            // chkGas
            // 
            this.chkGas.AutoSize = true;
            this.chkGas.Location = new System.Drawing.Point(354, 19);
            this.chkGas.Name = "chkGas";
            this.chkGas.Size = new System.Drawing.Size(45, 17);
            this.chkGas.TabIndex = 6;
            this.chkGas.Text = "Gas";
            this.chkGas.UseVisualStyleBackColor = true;
            this.chkGas.CheckedChanged += new System.EventHandler(this.chkGas_CheckedChanged);
            // 
            // chkFuel
            // 
            this.chkFuel.AutoSize = true;
            this.chkFuel.Location = new System.Drawing.Point(302, 19);
            this.chkFuel.Name = "chkFuel";
            this.chkFuel.Size = new System.Drawing.Size(46, 17);
            this.chkFuel.TabIndex = 5;
            this.chkFuel.Text = "Fuel";
            this.chkFuel.UseVisualStyleBackColor = true;
            this.chkFuel.CheckedChanged += new System.EventHandler(this.chkFuel_CheckedChanged);
            // 
            // chkFire
            // 
            this.chkFire.AutoSize = true;
            this.chkFire.Location = new System.Drawing.Point(252, 19);
            this.chkFire.Name = "chkFire";
            this.chkFire.Size = new System.Drawing.Size(43, 17);
            this.chkFire.TabIndex = 4;
            this.chkFire.Text = "Fire";
            this.chkFire.UseVisualStyleBackColor = true;
            this.chkFire.CheckedChanged += new System.EventHandler(this.chkFire_CheckedChanged);
            // 
            // chkElastic
            // 
            this.chkElastic.AutoSize = true;
            this.chkElastic.Location = new System.Drawing.Point(189, 19);
            this.chkElastic.Name = "chkElastic";
            this.chkElastic.Size = new System.Drawing.Size(57, 17);
            this.chkElastic.TabIndex = 3;
            this.chkElastic.Text = "Elastic";
            this.chkElastic.UseVisualStyleBackColor = true;
            this.chkElastic.CheckedChanged += new System.EventHandler(this.chkElastic_CheckedChanged);
            // 
            // chkDense
            // 
            this.chkDense.AutoSize = true;
            this.chkDense.Location = new System.Drawing.Point(126, 19);
            this.chkDense.Name = "chkDense";
            this.chkDense.Size = new System.Drawing.Size(57, 17);
            this.chkDense.TabIndex = 2;
            this.chkDense.Text = "Dense";
            this.chkDense.UseVisualStyleBackColor = true;
            this.chkDense.CheckedChanged += new System.EventHandler(this.chkDense_CheckedChanged);
            // 
            // chkCooler
            // 
            this.chkCooler.AutoSize = true;
            this.chkCooler.Location = new System.Drawing.Point(64, 19);
            this.chkCooler.Name = "chkCooler";
            this.chkCooler.Size = new System.Drawing.Size(56, 17);
            this.chkCooler.TabIndex = 1;
            this.chkCooler.Text = "Cooler";
            this.chkCooler.UseVisualStyleBackColor = true;
            this.chkCooler.CheckedChanged += new System.EventHandler(this.chkCooler_CheckedChanged);
            // 
            // chkBrittle
            // 
            this.chkBrittle.AutoSize = true;
            this.chkBrittle.Location = new System.Drawing.Point(6, 19);
            this.chkBrittle.Name = "chkBrittle";
            this.chkBrittle.Size = new System.Drawing.Size(52, 17);
            this.chkBrittle.TabIndex = 0;
            this.chkBrittle.Text = "Brittle";
            this.chkBrittle.UseVisualStyleBackColor = true;
            this.chkBrittle.CheckedChanged += new System.EventHandler(this.chkBrittle_CheckedChanged);
            // 
            // cmdClearFilter
            // 
            this.cmdClearFilter.Location = new System.Drawing.Point(93, 386);
            this.cmdClearFilter.Name = "cmdClearFilter";
            this.cmdClearFilter.Size = new System.Drawing.Size(75, 23);
            this.cmdClearFilter.TabIndex = 22;
            this.cmdClearFilter.Text = "Reset";
            this.cmdClearFilter.UseVisualStyleBackColor = true;
            this.cmdClearFilter.Click += new System.EventHandler(this.cmdClearFilter_Click);
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.txtTagsFilter);
            this.grpFilter.Controls.Add(this.lblFilterTags);
            this.grpFilter.Controls.Add(this.grpMaterials);
            this.grpFilter.Location = new System.Drawing.Point(12, 415);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(797, 119);
            this.grpFilter.TabIndex = 23;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Filter by:";
            // 
            // chkJet
            // 
            this.chkJet.AutoSize = true;
            this.chkJet.Location = new System.Drawing.Point(529, 19);
            this.chkJet.Name = "chkJet";
            this.chkJet.Size = new System.Drawing.Size(40, 17);
            this.chkJet.TabIndex = 9;
            this.chkJet.Text = "Jet";
            this.chkJet.UseVisualStyleBackColor = true;
            this.chkJet.CheckedChanged += new System.EventHandler(this.chkJet_CheckedChanged);
            // 
            // chkLight
            // 
            this.chkLight.AutoSize = true;
            this.chkLight.Location = new System.Drawing.Point(575, 19);
            this.chkLight.Name = "chkLight";
            this.chkLight.Size = new System.Drawing.Size(49, 17);
            this.chkLight.TabIndex = 10;
            this.chkLight.Text = "Light";
            this.chkLight.UseVisualStyleBackColor = true;
            this.chkLight.CheckedChanged += new System.EventHandler(this.chkLight_CheckedChanged);
            // 
            // chkMochi
            // 
            this.chkMochi.AutoSize = true;
            this.chkMochi.Location = new System.Drawing.Point(630, 19);
            this.chkMochi.Name = "chkMochi";
            this.chkMochi.Size = new System.Drawing.Size(55, 17);
            this.chkMochi.TabIndex = 11;
            this.chkMochi.Text = "Mochi";
            this.chkMochi.UseVisualStyleBackColor = true;
            this.chkMochi.CheckedChanged += new System.EventHandler(this.chkMochi_CheckedChanged);
            // 
            // chkAnull
            // 
            this.chkAnull.AutoSize = true;
            this.chkAnull.Location = new System.Drawing.Point(691, 19);
            this.chkAnull.Name = "chkAnull";
            this.chkAnull.Size = new System.Drawing.Size(54, 17);
            this.chkAnull.TabIndex = 12;
            this.chkAnull.Text = "A-Null";
            this.chkAnull.UseVisualStyleBackColor = true;
            this.chkAnull.CheckedChanged += new System.EventHandler(this.chkAnull_CheckedChanged);
            // 
            // chkNnull
            // 
            this.chkNnull.AutoSize = true;
            this.chkNnull.Location = new System.Drawing.Point(6, 42);
            this.chkNnull.Name = "chkNnull";
            this.chkNnull.Size = new System.Drawing.Size(55, 17);
            this.chkNnull.TabIndex = 13;
            this.chkNnull.Text = "N-Null";
            this.chkNnull.UseVisualStyleBackColor = true;
            this.chkNnull.CheckedChanged += new System.EventHandler(this.chkNnull_CheckedChanged);
            // 
            // chkOutflow
            // 
            this.chkOutflow.AutoSize = true;
            this.chkOutflow.Location = new System.Drawing.Point(64, 42);
            this.chkOutflow.Name = "chkOutflow";
            this.chkOutflow.Size = new System.Drawing.Size(62, 17);
            this.chkOutflow.TabIndex = 14;
            this.chkOutflow.Text = "Outflow";
            this.chkOutflow.UseVisualStyleBackColor = true;
            this.chkOutflow.CheckedChanged += new System.EventHandler(this.chkOutflow_CheckedChanged);
            // 
            // chkPowder
            // 
            this.chkPowder.AutoSize = true;
            this.chkPowder.Location = new System.Drawing.Point(126, 42);
            this.chkPowder.Name = "chkPowder";
            this.chkPowder.Size = new System.Drawing.Size(62, 17);
            this.chkPowder.TabIndex = 15;
            this.chkPowder.Text = "Powder";
            this.chkPowder.UseVisualStyleBackColor = true;
            this.chkPowder.CheckedChanged += new System.EventHandler(this.chkPowder_CheckedChanged);
            // 
            // chkRice
            // 
            this.chkRice.AutoSize = true;
            this.chkRice.Location = new System.Drawing.Point(189, 42);
            this.chkRice.Name = "chkRice";
            this.chkRice.Size = new System.Drawing.Size(48, 17);
            this.chkRice.TabIndex = 16;
            this.chkRice.Text = "Rice";
            this.chkRice.UseVisualStyleBackColor = true;
            this.chkRice.CheckedChanged += new System.EventHandler(this.chkRice_CheckedChanged);
            // 
            // chkRigid
            // 
            this.chkRigid.AutoSize = true;
            this.chkRigid.Location = new System.Drawing.Point(252, 42);
            this.chkRigid.Name = "chkRigid";
            this.chkRigid.Size = new System.Drawing.Size(50, 17);
            this.chkRigid.TabIndex = 17;
            this.chkRigid.Text = "Rigid";
            this.chkRigid.UseVisualStyleBackColor = true;
            this.chkRigid.CheckedChanged += new System.EventHandler(this.chkRigid_CheckedChanged);
            // 
            // chkAxis
            // 
            this.chkAxis.AutoSize = true;
            this.chkAxis.Location = new System.Drawing.Point(302, 42);
            this.chkAxis.Name = "chkAxis";
            this.chkAxis.Size = new System.Drawing.Size(45, 17);
            this.chkAxis.TabIndex = 18;
            this.chkAxis.Text = "Axis";
            this.chkAxis.UseVisualStyleBackColor = true;
            this.chkAxis.CheckedChanged += new System.EventHandler(this.chkAxis_CheckedChanged);
            // 
            // chkSnow
            // 
            this.chkSnow.AutoSize = true;
            this.chkSnow.Location = new System.Drawing.Point(354, 42);
            this.chkSnow.Name = "chkSnow";
            this.chkSnow.Size = new System.Drawing.Size(53, 17);
            this.chkSnow.TabIndex = 19;
            this.chkSnow.Text = "Snow";
            this.chkSnow.UseVisualStyleBackColor = true;
            this.chkSnow.CheckedChanged += new System.EventHandler(this.chkSnow_CheckedChanged);
            // 
            // chkString
            // 
            this.chkString.AutoSize = true;
            this.chkString.Location = new System.Drawing.Point(405, 42);
            this.chkString.Name = "chkString";
            this.chkString.Size = new System.Drawing.Size(53, 17);
            this.chkString.TabIndex = 20;
            this.chkString.Text = "String";
            this.chkString.UseVisualStyleBackColor = true;
            this.chkString.CheckedChanged += new System.EventHandler(this.chkString_CheckedChanged);
            // 
            // chkTensile
            // 
            this.chkTensile.AutoSize = true;
            this.chkTensile.Location = new System.Drawing.Point(469, 42);
            this.chkTensile.Name = "chkTensile";
            this.chkTensile.Size = new System.Drawing.Size(60, 17);
            this.chkTensile.TabIndex = 21;
            this.chkTensile.Text = "Tensile";
            this.chkTensile.UseVisualStyleBackColor = true;
            this.chkTensile.CheckedChanged += new System.EventHandler(this.chkTensile_CheckedChanged);
            // 
            // chkUser
            // 
            this.chkUser.AutoSize = true;
            this.chkUser.Location = new System.Drawing.Point(529, 42);
            this.chkUser.Name = "chkUser";
            this.chkUser.Size = new System.Drawing.Size(48, 17);
            this.chkUser.TabIndex = 22;
            this.chkUser.Text = "User";
            this.chkUser.UseVisualStyleBackColor = true;
            this.chkUser.CheckedChanged += new System.EventHandler(this.chkUser_CheckedChanged);
            // 
            // chkViscous
            // 
            this.chkViscous.AutoSize = true;
            this.chkViscous.Location = new System.Drawing.Point(575, 42);
            this.chkViscous.Name = "chkViscous";
            this.chkViscous.Size = new System.Drawing.Size(63, 17);
            this.chkViscous.TabIndex = 23;
            this.chkViscous.Text = "Viscous";
            this.chkViscous.UseVisualStyleBackColor = true;
            this.chkViscous.CheckedChanged += new System.EventHandler(this.chkViscous_CheckedChanged);
            // 
            // chkWall
            // 
            this.chkWall.AutoSize = true;
            this.chkWall.Location = new System.Drawing.Point(635, 42);
            this.chkWall.Name = "chkWall";
            this.chkWall.Size = new System.Drawing.Size(47, 17);
            this.chkWall.TabIndex = 24;
            this.chkWall.Text = "Wall";
            this.chkWall.UseVisualStyleBackColor = true;
            this.chkWall.CheckedChanged += new System.EventHandler(this.chkWall_CheckedChanged);
            // 
            // chkWater
            // 
            this.chkWater.AutoSize = true;
            this.chkWater.Location = new System.Drawing.Point(691, 42);
            this.chkWater.Name = "chkWater";
            this.chkWater.Size = new System.Drawing.Size(55, 17);
            this.chkWater.TabIndex = 25;
            this.chkWater.Text = "Water";
            this.chkWater.UseVisualStyleBackColor = true;
            this.chkWater.CheckedChanged += new System.EventHandler(this.chkWater_CheckedChanged);
            // 
            // lblFilterTags
            // 
            this.lblFilterTags.AutoSize = true;
            this.lblFilterTags.Location = new System.Drawing.Point(6, 94);
            this.lblFilterTags.Name = "lblFilterTags";
            this.lblFilterTags.Size = new System.Drawing.Size(34, 13);
            this.lblFilterTags.TabIndex = 22;
            this.lblFilterTags.Text = "Tags:";
            // 
            // txtTagsFilter
            // 
            this.txtTagsFilter.Location = new System.Drawing.Point(46, 91);
            this.txtTagsFilter.Name = "txtTagsFilter";
            this.txtTagsFilter.Size = new System.Drawing.Size(241, 20);
            this.txtTagsFilter.TabIndex = 23;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 539);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.cmdClearFilter);
            this.Controls.Add(this.cmdFilter);
            this.Controls.Add(this.txtTags);
            this.Controls.Add(this.lblTags);
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
            this.Text = "OE-Cake Recipe Helper v0.2";
            this.grpMaterials.ResumeLayout(false);
            this.grpMaterials.PerformLayout();
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
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
        private System.Windows.Forms.ColumnHeader clmTags;
        private System.Windows.Forms.Label lblTags;
        private System.Windows.Forms.TextBox txtTags;
        private System.Windows.Forms.Button cmdFilter;
        private System.Windows.Forms.GroupBox grpMaterials;
        private System.Windows.Forms.CheckBox chkInflow;
        private System.Windows.Forms.CheckBox chkHeater;
        private System.Windows.Forms.CheckBox chkGas;
        private System.Windows.Forms.CheckBox chkFuel;
        private System.Windows.Forms.CheckBox chkFire;
        private System.Windows.Forms.CheckBox chkElastic;
        private System.Windows.Forms.CheckBox chkDense;
        private System.Windows.Forms.CheckBox chkCooler;
        private System.Windows.Forms.CheckBox chkBrittle;
        private System.Windows.Forms.Button cmdClearFilter;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.CheckBox chkWater;
        private System.Windows.Forms.CheckBox chkWall;
        private System.Windows.Forms.CheckBox chkViscous;
        private System.Windows.Forms.CheckBox chkUser;
        private System.Windows.Forms.CheckBox chkTensile;
        private System.Windows.Forms.CheckBox chkString;
        private System.Windows.Forms.CheckBox chkSnow;
        private System.Windows.Forms.CheckBox chkAxis;
        private System.Windows.Forms.CheckBox chkRigid;
        private System.Windows.Forms.CheckBox chkRice;
        private System.Windows.Forms.CheckBox chkPowder;
        private System.Windows.Forms.CheckBox chkOutflow;
        private System.Windows.Forms.CheckBox chkNnull;
        private System.Windows.Forms.CheckBox chkAnull;
        private System.Windows.Forms.CheckBox chkMochi;
        private System.Windows.Forms.CheckBox chkLight;
        private System.Windows.Forms.CheckBox chkJet;
        private System.Windows.Forms.TextBox txtTagsFilter;
        private System.Windows.Forms.Label lblFilterTags;
    }
}


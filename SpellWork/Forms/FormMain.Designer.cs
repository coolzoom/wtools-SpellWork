﻿namespace SpellWork.Forms
{
    sealed partial class FormMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this._dbConnect = new System.Windows.Forms.ToolStripStatusLabel();
            this._status = new System.Windows.Forms.ToolStripStatusLabel();
            this._ProcStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this._tsmFile = new System.Windows.Forms.ToolStripMenuItem();
            this._Connected = new System.Windows.Forms.ToolStripMenuItem();
            this._tsmSettings = new System.Windows.Forms.ToolStripMenuItem();
            this._tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this._tsmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this._tsmAbout = new System.Windows.Forms.ToolStripMenuItem();
            this._ilPro = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.splitContainer8 = new System.Windows.Forms.SplitContainer();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this._tpCompare = new System.Windows.Forms.TabPage();
            this._scCompareRoot = new System.Windows.Forms.SplitContainer();
            this._bCompareSearch1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this._tbCompareFilterSpell1 = new System.Windows.Forms.TextBox();
            this._rtbCompareSpell1 = new System.Windows.Forms.RichTextBox();
            this._bCompareSearch2 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this._rtbCompareSpell2 = new System.Windows.Forms.RichTextBox();
            this._tbCompareFilterSpell2 = new System.Windows.Forms.TextBox();
            this._tpSpellInfo = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this._rtSpellInfo = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._lvSpellList = new System.Windows.Forms.ListView();
            this.chSpellID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSpellName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMiscID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._gSpellFilter = new System.Windows.Forms.GroupBox();
            this._gbAdvansedSearch = new System.Windows.Forms.GroupBox();
            this._cbAdvancedFilter2CompareType = new System.Windows.Forms.ComboBox();
            this._cbAdvancedFilter1CompareType = new System.Windows.Forms.ComboBox();
            this._tbAdvancedFilter2Val = new System.Windows.Forms.TextBox();
            this._tbAdvancedFilter1Val = new System.Windows.Forms.TextBox();
            this._cbAdvancedFilter2 = new System.Windows.Forms.ComboBox();
            this._cbAdvancedFilter1 = new System.Windows.Forms.ComboBox();
            this._cbAdvancedEffectFilter2CompareType = new System.Windows.Forms.ComboBox();
            this._cbAdvancedEffectFilter1CompareType = new System.Windows.Forms.ComboBox();
            this._tbAdvancedEffectFilter2Val = new System.Windows.Forms.TextBox();
            this._tbAdvancedEffectFilter1Val = new System.Windows.Forms.TextBox();
            this._cbAdvancedEffectFilter2 = new System.Windows.Forms.ComboBox();
            this._cbAdvancedEffectFilter1 = new System.Windows.Forms.ComboBox();
            this._cbTarget2 = new System.Windows.Forms.ComboBox();
            this._cbTarget1 = new System.Windows.Forms.ComboBox();
            this._cbSpellEffect = new System.Windows.Forms.ComboBox();
            this._cbSpellAura = new System.Windows.Forms.ComboBox();
            this._cbSpellFamilyName = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._bSearch = new System.Windows.Forms.Button();
            this._tbSearchAttributes = new System.Windows.Forms.TextBox();
            this._tbSearchIcon = new System.Windows.Forms.TextBox();
            this._tbSearchId = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this._tpSpellProcInfo = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this._clbProcFlags = new System.Windows.Forms.CheckedListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this._clbProcFlagEx = new System.Windows.Forms.CheckedListBox();
            this._gSpellProcEvent = new System.Windows.Forms.GroupBox();
            this._clbSchools = new System.Windows.Forms.CheckedListBox();
            this._cbProcFitstSpellFamily = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this._tbPPM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._tbChance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._tbCooldown = new System.Windows.Forms.TextBox();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this._cbProcSpellFamilyTree = new System.Windows.Forms.ComboBox();
            this._tvFamilyTree = new System.Windows.Forms.TreeView();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this._rtbProcSpellInfo = new System.Windows.Forms.RichTextBox();
            this._lvProcSpellList = new System.Windows.Forms.ListView();
            this._chProcID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._chProcName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._bProcSearch = new System.Windows.Forms.Button();
            this._tbProcSeach = new System.Windows.Forms.TextBox();
            this._cbProcTarget2 = new System.Windows.Forms.ComboBox();
            this._cbProcTarget1 = new System.Windows.Forms.ComboBox();
            this._cbProcSpellEffect = new System.Windows.Forms.ComboBox();
            this._cbProcSpellAura = new System.Windows.Forms.ComboBox();
            this._cbProcSpellFamilyName = new System.Windows.Forms.ComboBox();
            this._lvProcAdditionalInfo = new System.Windows.Forms.ListView();
            this._chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._tpSqlData = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._cbBinaryCompare = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this._tbSqlManual = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this._bSqlProcEx = new System.Windows.Forms.Button();
            this._bSqlProc = new System.Windows.Forms.Button();
            this._bSqlSchool = new System.Windows.Forms.Button();
            this._tbSqlProcEx = new System.Windows.Forms.TextBox();
            this._tbSqlProc = new System.Windows.Forms.TextBox();
            this._tbSqlSchool = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this._cbSqlSpellFamily = new System.Windows.Forms.ComboBox();
            this._bSelect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this._lvDataList = new System.Windows.Forms.ListView();
            this.entry = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.spellname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.schoolmask = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.spellfamilyname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.spellfamilymask0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.spellfamilymask1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.spellfamilymask2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.procflag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.procEx = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ppmRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customchance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cooldown = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._rtbSqlLog = new System.Windows.Forms.RichTextBox();
            this._bSqlToBase = new System.Windows.Forms.Button();
            this._bSqlSave = new System.Windows.Forms.Button();
            this._cbProcFlag = new System.Windows.Forms.CheckBox();
            this._bWrite = new System.Windows.Forms.Button();
            this._bLevelScaling = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).BeginInit();
            this.splitContainer8.Panel1.SuspendLayout();
            this.splitContainer8.SuspendLayout();
            this._tpCompare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._scCompareRoot)).BeginInit();
            this._scCompareRoot.Panel1.SuspendLayout();
            this._scCompareRoot.Panel2.SuspendLayout();
            this._scCompareRoot.SuspendLayout();
            this._tpSpellInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this._gSpellFilter.SuspendLayout();
            this._gbAdvansedSearch.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this._tpSpellProcInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this._gSpellProcEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this._tpSqlData.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._dbConnect,
            this._status,
            this._ProcStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 704);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1163, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // _dbConnect
            // 
            this._dbConnect.Name = "_dbConnect";
            this._dbConnect.Size = new System.Drawing.Size(0, 16);
            // 
            // _status
            // 
            this._status.Name = "_status";
            this._status.Size = new System.Drawing.Size(0, 16);
            // 
            // _ProcStatus
            // 
            this._ProcStatus.Name = "_ProcStatus";
            this._ProcStatus.Size = new System.Drawing.Size(0, 16);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tsmFile,
            this._tsmHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1163, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // _tsmFile
            // 
            this._tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._Connected,
            this._tsmSettings,
            this._tsmExit});
            this._tsmFile.Name = "_tsmFile";
            this._tsmFile.Size = new System.Drawing.Size(48, 24);
            this._tsmFile.Text = "File";
            // 
            // _Connected
            // 
            this._Connected.Name = "_Connected";
            this._Connected.Size = new System.Drawing.Size(172, 26);
            this._Connected.Text = "Connected";
            this._Connected.Click += new System.EventHandler(this.ConnectedClick);
            // 
            // _tsmSettings
            // 
            this._tsmSettings.Name = "_tsmSettings";
            this._tsmSettings.Size = new System.Drawing.Size(172, 26);
            this._tsmSettings.Text = "Setting";
            this._tsmSettings.Click += new System.EventHandler(this.SettingsClick);
            // 
            // _tsmExit
            // 
            this._tsmExit.Name = "_tsmExit";
            this._tsmExit.Size = new System.Drawing.Size(172, 26);
            this._tsmExit.Text = "Exit";
            this._tsmExit.Click += new System.EventHandler(this.ExitClick);
            // 
            // _tsmHelp
            // 
            this._tsmHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tsmAbout});
            this._tsmHelp.Name = "_tsmHelp";
            this._tsmHelp.Size = new System.Drawing.Size(58, 24);
            this._tsmHelp.Text = "Help";
            // 
            // _tsmAbout
            // 
            this._tsmAbout.Name = "_tsmAbout";
            this._tsmAbout.Size = new System.Drawing.Size(146, 26);
            this._tsmAbout.Text = "About..";
            // 
            // _ilPro
            // 
            this._ilPro.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("_ilPro.ImageStream")));
            this._ilPro.TransparentColor = System.Drawing.Color.Transparent;
            this._ilPro.Images.SetKeyName(0, "info.ico");
            this._ilPro.Images.SetKeyName(1, "ok.ico");
            this._ilPro.Images.SetKeyName(2, "drop.ico");
            this._ilPro.Images.SetKeyName(3, "plus.ico");
            this._ilPro.Images.SetKeyName(4, "family.ico");
            this._ilPro.Images.SetKeyName(5, "munus.ico");
            // 
            // splitContainer7
            // 
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.Location = new System.Drawing.Point(0, 0);
            this.splitContainer7.Name = "splitContainer7";
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.splitContainer8);
            this.splitContainer7.Panel1.Controls.Add(this.richTextBox1);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.richTextBox2);
            this.splitContainer7.Size = new System.Drawing.Size(858, 429);
            this.splitContainer7.SplitterDistance = 424;
            this.splitContainer7.TabIndex = 0;
            // 
            // splitContainer8
            // 
            this.splitContainer8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer8.Location = new System.Drawing.Point(0, 0);
            this.splitContainer8.Name = "splitContainer8";
            // 
            // splitContainer8.Panel1
            // 
            this.splitContainer8.Panel1.Controls.Add(this.textBox2);
            this.splitContainer8.Size = new System.Drawing.Size(424, 429);
            this.splitContainer8.SplitterDistance = 209;
            this.splitContainer8.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(19, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(424, 429);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Location = new System.Drawing.Point(0, 0);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(430, 429);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            // 
            // _tpCompare
            // 
            this._tpCompare.Controls.Add(this._scCompareRoot);
            this._tpCompare.Location = new System.Drawing.Point(4, 25);
            this._tpCompare.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._tpCompare.Name = "_tpCompare";
            this._tpCompare.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._tpCompare.Size = new System.Drawing.Size(1155, 647);
            this._tpCompare.TabIndex = 4;
            this._tpCompare.Text = "Compare Spells";
            this._tpCompare.UseVisualStyleBackColor = true;
            // 
            // _scCompareRoot
            // 
            this._scCompareRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this._scCompareRoot.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this._scCompareRoot.Location = new System.Drawing.Point(4, 3);
            this._scCompareRoot.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._scCompareRoot.Name = "_scCompareRoot";
            // 
            // _scCompareRoot.Panel1
            // 
            this._scCompareRoot.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this._scCompareRoot.Panel1.Controls.Add(this._bCompareSearch1);
            this._scCompareRoot.Panel1.Controls.Add(this.label13);
            this._scCompareRoot.Panel1.Controls.Add(this._tbCompareFilterSpell1);
            this._scCompareRoot.Panel1.Controls.Add(this._rtbCompareSpell1);
            // 
            // _scCompareRoot.Panel2
            // 
            this._scCompareRoot.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this._scCompareRoot.Panel2.Controls.Add(this._bCompareSearch2);
            this._scCompareRoot.Panel2.Controls.Add(this.label14);
            this._scCompareRoot.Panel2.Controls.Add(this._rtbCompareSpell2);
            this._scCompareRoot.Panel2.Controls.Add(this._tbCompareFilterSpell2);
            this._scCompareRoot.Size = new System.Drawing.Size(1147, 641);
            this._scCompareRoot.SplitterDistance = 426;
            this._scCompareRoot.SplitterWidth = 5;
            this._scCompareRoot.TabIndex = 0;
            // 
            // _bCompareSearch1
            // 
            this._bCompareSearch1.Location = new System.Drawing.Point(317, 1);
            this._bCompareSearch1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._bCompareSearch1.Name = "_bCompareSearch1";
            this._bCompareSearch1.Size = new System.Drawing.Size(68, 27);
            this._bCompareSearch1.TabIndex = 3;
            this._bCompareSearch1.Text = "Search";
            this._bCompareSearch1.UseVisualStyleBackColor = true;
            this._bCompareSearch1.Click += new System.EventHandler(this.CompareSearch1Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 7);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 15);
            this.label13.TabIndex = 2;
            this.label13.Text = "ID or Name";
            // 
            // _tbCompareFilterSpell1
            // 
            this._tbCompareFilterSpell1.Location = new System.Drawing.Point(115, 3);
            this._tbCompareFilterSpell1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._tbCompareFilterSpell1.Name = "_tbCompareFilterSpell1";
            this._tbCompareFilterSpell1.Size = new System.Drawing.Size(193, 25);
            this._tbCompareFilterSpell1.TabIndex = 1;
            this._tbCompareFilterSpell1.TextChanged += new System.EventHandler(this.CompareFilterSpellTextChanged);
            // 
            // _rtbCompareSpell1
            // 
            this._rtbCompareSpell1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._rtbCompareSpell1.BackColor = System.Drawing.Color.Gainsboro;
            this._rtbCompareSpell1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this._rtbCompareSpell1.Location = new System.Drawing.Point(0, 33);
            this._rtbCompareSpell1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._rtbCompareSpell1.Name = "_rtbCompareSpell1";
            this._rtbCompareSpell1.Size = new System.Drawing.Size(421, 607);
            this._rtbCompareSpell1.TabIndex = 0;
            this._rtbCompareSpell1.Text = "";
            // 
            // _bCompareSearch2
            // 
            this._bCompareSearch2.Location = new System.Drawing.Point(324, 1);
            this._bCompareSearch2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._bCompareSearch2.Name = "_bCompareSearch2";
            this._bCompareSearch2.Size = new System.Drawing.Size(68, 27);
            this._bCompareSearch2.TabIndex = 3;
            this._bCompareSearch2.Text = "Search";
            this._bCompareSearch2.UseVisualStyleBackColor = true;
            this._bCompareSearch2.Click += new System.EventHandler(this.CompareSearch2Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 7);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 15);
            this.label14.TabIndex = 2;
            this.label14.Text = "ID or Name";
            // 
            // _rtbCompareSpell2
            // 
            this._rtbCompareSpell2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._rtbCompareSpell2.BackColor = System.Drawing.Color.Gainsboro;
            this._rtbCompareSpell2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this._rtbCompareSpell2.Location = new System.Drawing.Point(4, 33);
            this._rtbCompareSpell2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._rtbCompareSpell2.Name = "_rtbCompareSpell2";
            this._rtbCompareSpell2.Size = new System.Drawing.Size(710, 607);
            this._rtbCompareSpell2.TabIndex = 0;
            this._rtbCompareSpell2.Text = "";
            // 
            // _tbCompareFilterSpell2
            // 
            this._tbCompareFilterSpell2.Location = new System.Drawing.Point(121, 3);
            this._tbCompareFilterSpell2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._tbCompareFilterSpell2.Name = "_tbCompareFilterSpell2";
            this._tbCompareFilterSpell2.Size = new System.Drawing.Size(193, 25);
            this._tbCompareFilterSpell2.TabIndex = 1;
            this._tbCompareFilterSpell2.TextChanged += new System.EventHandler(this.CompareFilterSpellTextChanged);
            // 
            // _tpSpellInfo
            // 
            this._tpSpellInfo.Controls.Add(this.splitContainer1);
            this._tpSpellInfo.Location = new System.Drawing.Point(4, 25);
            this._tpSpellInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._tpSpellInfo.Name = "_tpSpellInfo";
            this._tpSpellInfo.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._tpSpellInfo.Size = new System.Drawing.Size(1155, 647);
            this._tpSpellInfo.TabIndex = 0;
            this._tpSpellInfo.Text = "Spell Info";
            this._tpSpellInfo.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(4, 3);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._rtSpellInfo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1144, 639);
            this.splitContainer1.SplitterDistance = 745;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // _rtSpellInfo
            // 
            this._rtSpellInfo.BackColor = System.Drawing.Color.Gainsboro;
            this._rtSpellInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this._rtSpellInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._rtSpellInfo.Location = new System.Drawing.Point(0, 0);
            this._rtSpellInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._rtSpellInfo.Name = "_rtSpellInfo";
            this._rtSpellInfo.ReadOnly = true;
            this._rtSpellInfo.Size = new System.Drawing.Size(745, 639);
            this._rtSpellInfo.TabIndex = 0;
            this._rtSpellInfo.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._lvSpellList);
            this.groupBox1.Controls.Add(this._gSpellFilter);
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(394, 639);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // _lvSpellList
            // 
            this._lvSpellList.AllowColumnReorder = true;
            this._lvSpellList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lvSpellList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSpellID,
            this.chSpellName,
            this.chMiscID});
            this._lvSpellList.FullRowSelect = true;
            this._lvSpellList.GridLines = true;
            this._lvSpellList.HideSelection = false;
            this._lvSpellList.Location = new System.Drawing.Point(8, 405);
            this._lvSpellList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._lvSpellList.MultiSelect = false;
            this._lvSpellList.Name = "_lvSpellList";
            this._lvSpellList.Size = new System.Drawing.Size(385, 226);
            this._lvSpellList.TabIndex = 7;
            this._lvSpellList.UseCompatibleStateImageBehavior = false;
            this._lvSpellList.View = System.Windows.Forms.View.Details;
            this._lvSpellList.VirtualMode = true;
            this._lvSpellList.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.LvSpellListRetrieveVirtualItem);
            this._lvSpellList.SelectedIndexChanged += new System.EventHandler(this.LvSpellListSelectedIndexChanged);
            // 
            // chSpellID
            // 
            this.chSpellID.Text = "ID";
            this.chSpellID.Width = 48;
            // 
            // chSpellName
            // 
            this.chSpellName.Text = "Name";
            this.chSpellName.Width = 250;
            // 
            // chMiscID
            // 
            this.chMiscID.Text = "MiscID";
            this.chMiscID.Width = 64;
            // 
            // _gSpellFilter
            // 
            this._gSpellFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._gSpellFilter.BackColor = System.Drawing.Color.LightGray;
            this._gSpellFilter.Controls.Add(this._gbAdvansedSearch);
            this._gSpellFilter.Controls.Add(this._cbTarget2);
            this._gSpellFilter.Controls.Add(this._cbTarget1);
            this._gSpellFilter.Controls.Add(this._cbSpellEffect);
            this._gSpellFilter.Controls.Add(this._cbSpellAura);
            this._gSpellFilter.Controls.Add(this._cbSpellFamilyName);
            this._gSpellFilter.Location = new System.Drawing.Point(3, 93);
            this._gSpellFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._gSpellFilter.Name = "_gSpellFilter";
            this._gSpellFilter.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._gSpellFilter.Size = new System.Drawing.Size(392, 305);
            this._gSpellFilter.TabIndex = 8;
            this._gSpellFilter.TabStop = false;
            this._gSpellFilter.Text = "Spell Filter";
            // 
            // _gbAdvansedSearch
            // 
            this._gbAdvansedSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._gbAdvansedSearch.Controls.Add(this._cbAdvancedFilter2CompareType);
            this._gbAdvansedSearch.Controls.Add(this._cbAdvancedFilter1CompareType);
            this._gbAdvansedSearch.Controls.Add(this._tbAdvancedFilter2Val);
            this._gbAdvansedSearch.Controls.Add(this._tbAdvancedFilter1Val);
            this._gbAdvansedSearch.Controls.Add(this._cbAdvancedFilter2);
            this._gbAdvansedSearch.Controls.Add(this._cbAdvancedFilter1);
            this._gbAdvansedSearch.Controls.Add(this._cbAdvancedEffectFilter2CompareType);
            this._gbAdvansedSearch.Controls.Add(this._cbAdvancedEffectFilter1CompareType);
            this._gbAdvansedSearch.Controls.Add(this._tbAdvancedEffectFilter2Val);
            this._gbAdvansedSearch.Controls.Add(this._tbAdvancedEffectFilter1Val);
            this._gbAdvansedSearch.Controls.Add(this._cbAdvancedEffectFilter2);
            this._gbAdvansedSearch.Controls.Add(this._cbAdvancedEffectFilter1);
            this._gbAdvansedSearch.Location = new System.Drawing.Point(4, 156);
            this._gbAdvansedSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._gbAdvansedSearch.Name = "_gbAdvansedSearch";
            this._gbAdvansedSearch.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._gbAdvansedSearch.Size = new System.Drawing.Size(380, 142);
            this._gbAdvansedSearch.TabIndex = 6;
            this._gbAdvansedSearch.TabStop = false;
            this._gbAdvansedSearch.Text = "Advanced Filter";
            // 
            // _cbAdvancedFilter2CompareType
            // 
            this._cbAdvancedFilter2CompareType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cbAdvancedFilter2CompareType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbAdvancedFilter2CompareType.DropDownWidth = 160;
            this._cbAdvancedFilter2CompareType.FormattingEnabled = true;
            this._cbAdvancedFilter2CompareType.Location = new System.Drawing.Point(149, 47);
            this._cbAdvancedFilter2CompareType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._cbAdvancedFilter2CompareType.Name = "_cbAdvancedFilter2CompareType";
            this._cbAdvancedFilter2CompareType.Size = new System.Drawing.Size(100, 23);
            this._cbAdvancedFilter2CompareType.TabIndex = 3;
            // 
            // _cbAdvancedFilter1CompareType
            // 
            this._cbAdvancedFilter1CompareType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cbAdvancedFilter1CompareType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbAdvancedFilter1CompareType.DropDownWidth = 160;
            this._cbAdvancedFilter1CompareType.FormattingEnabled = true;
            this._cbAdvancedFilter1CompareType.Location = new System.Drawing.Point(149, 17);
            this._cbAdvancedFilter1CompareType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._cbAdvancedFilter1CompareType.Name = "_cbAdvancedFilter1CompareType";
            this._cbAdvancedFilter1CompareType.Size = new System.Drawing.Size(100, 23);
            this._cbAdvancedFilter1CompareType.TabIndex = 2;
            // 
            // _tbAdvancedFilter2Val
            // 
            this._tbAdvancedFilter2Val.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._tbAdvancedFilter2Val.Location = new System.Drawing.Point(258, 50);
            this._tbAdvancedFilter2Val.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._tbAdvancedFilter2Val.Name = "_tbAdvancedFilter2Val";
            this._tbAdvancedFilter2Val.Size = new System.Drawing.Size(112, 25);
            this._tbAdvancedFilter2Val.TabIndex = 1;
            this._tbAdvancedFilter2Val.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbAdvansedFilterValKeyDown);
            // 
            // _tbAdvancedFilter1Val
            // 
            this._tbAdvancedFilter1Val.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._tbAdvancedFilter1Val.Location = new System.Drawing.Point(258, 17);
            this._tbAdvancedFilter1Val.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._tbAdvancedFilter1Val.Name = "_tbAdvancedFilter1Val";
            this._tbAdvancedFilter1Val.Size = new System.Drawing.Size(112, 25);
            this._tbAdvancedFilter1Val.TabIndex = 1;
            this._tbAdvancedFilter1Val.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbAdvansedFilterValKeyDown);
            // 
            // _cbAdvancedFilter2
            // 
            this._cbAdvancedFilter2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cbAdvancedFilter2.DropDownHeight = 500;
            this._cbAdvancedFilter2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbAdvancedFilter2.FormattingEnabled = true;
            this._cbAdvancedFilter2.IntegralHeight = false;
            this._cbAdvancedFilter2.Location = new System.Drawing.Point(1, 48);
            this._cbAdvancedFilter2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._cbAdvancedFilter2.Name = "_cbAdvancedFilter2";
            this._cbAdvancedFilter2.Size = new System.Drawing.Size(138, 23);
            this._cbAdvancedFilter2.TabIndex = 0;
            // 
            // _cbAdvancedFilter1
            // 
            this._cbAdvancedFilter1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cbAdvancedFilter1.DropDownHeight = 500;
            this._cbAdvancedFilter1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbAdvancedFilter1.FormattingEnabled = true;
            this._cbAdvancedFilter1.IntegralHeight = false;
            this._cbAdvancedFilter1.Location = new System.Drawing.Point(1, 17);
            this._cbAdvancedFilter1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._cbAdvancedFilter1.Name = "_cbAdvancedFilter1";
            this._cbAdvancedFilter1.Size = new System.Drawing.Size(138, 23);
            this._cbAdvancedFilter1.TabIndex = 0;
            // 
            // _cbAdvancedEffectFilter2CompareType
            // 
            this._cbAdvancedEffectFilter2CompareType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cbAdvancedEffectFilter2CompareType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbAdvancedEffectFilter2CompareType.DropDownWidth = 160;
            this._cbAdvancedEffectFilter2CompareType.FormattingEnabled = true;
            this._cbAdvancedEffectFilter2CompareType.Location = new System.Drawing.Point(148, 110);
            this._cbAdvancedEffectFilter2CompareType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._cbAdvancedEffectFilter2CompareType.Name = "_cbAdvancedEffectFilter2CompareType";
            this._cbAdvancedEffectFilter2CompareType.Size = new System.Drawing.Size(100, 23);
            this._cbAdvancedEffectFilter2CompareType.TabIndex = 3;
            // 
            // _cbAdvancedEffectFilter1CompareType
            // 
            this._cbAdvancedEffectFilter1CompareType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cbAdvancedEffectFilter1CompareType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbAdvancedEffectFilter1CompareType.DropDownWidth = 160;
            this._cbAdvancedEffectFilter1CompareType.FormattingEnabled = true;
            this._cbAdvancedEffectFilter1CompareType.Location = new System.Drawing.Point(149, 78);
            this._cbAdvancedEffectFilter1CompareType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._cbAdvancedEffectFilter1CompareType.Name = "_cbAdvancedEffectFilter1CompareType";
            this._cbAdvancedEffectFilter1CompareType.Size = new System.Drawing.Size(100, 23);
            this._cbAdvancedEffectFilter1CompareType.TabIndex = 2;
            // 
            // _tbAdvancedEffectFilter2Val
            // 
            this._tbAdvancedEffectFilter2Val.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._tbAdvancedEffectFilter2Val.Location = new System.Drawing.Point(258, 111);
            this._tbAdvancedEffectFilter2Val.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._tbAdvancedEffectFilter2Val.Name = "_tbAdvancedEffectFilter2Val";
            this._tbAdvancedEffectFilter2Val.Size = new System.Drawing.Size(112, 25);
            this._tbAdvancedEffectFilter2Val.TabIndex = 1;
            this._tbAdvancedEffectFilter2Val.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbAdvansedFilterValKeyDown);
            // 
            // _tbAdvancedEffectFilter1Val
            // 
            this._tbAdvancedEffectFilter1Val.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._tbAdvancedEffectFilter1Val.Location = new System.Drawing.Point(258, 78);
            this._tbAdvancedEffectFilter1Val.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._tbAdvancedEffectFilter1Val.Name = "_tbAdvancedEffectFilter1Val";
            this._tbAdvancedEffectFilter1Val.Size = new System.Drawing.Size(112, 25);
            this._tbAdvancedEffectFilter1Val.TabIndex = 1;
            this._tbAdvancedEffectFilter1Val.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbAdvansedFilterValKeyDown);
            // 
            // _cbAdvancedEffectFilter2
            // 
            this._cbAdvancedEffectFilter2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cbAdvancedEffectFilter2.DropDownHeight = 500;
            this._cbAdvancedEffectFilter2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbAdvancedEffectFilter2.FormattingEnabled = true;
            this._cbAdvancedEffectFilter2.IntegralHeight = false;
            this._cbAdvancedEffectFilter2.Location = new System.Drawing.Point(-130, 110);
            this._cbAdvancedEffectFilter2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._cbAdvancedEffectFilter2.Name = "_cbAdvancedEffectFilter2";
            this._cbAdvancedEffectFilter2.Size = new System.Drawing.Size(269, 23);
            this._cbAdvancedEffectFilter2.TabIndex = 0;
            // 
            // _cbAdvancedEffectFilter1
            // 
            this._cbAdvancedEffectFilter1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cbAdvancedEffectFilter1.DropDownHeight = 500;
            this._cbAdvancedEffectFilter1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbAdvancedEffectFilter1.FormattingEnabled = true;
            this._cbAdvancedEffectFilter1.IntegralHeight = false;
            this._cbAdvancedEffectFilter1.Location = new System.Drawing.Point(-130, 78);
            this._cbAdvancedEffectFilter1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._cbAdvancedEffectFilter1.Name = "_cbAdvancedEffectFilter1";
            this._cbAdvancedEffectFilter1.Size = new System.Drawing.Size(269, 23);
            this._cbAdvancedEffectFilter1.TabIndex = 0;
            // 
            // _cbTarget2
            // 
            this._cbTarget2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cbTarget2.DropDownHeight = 500;
            this._cbTarget2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbTarget2.DropDownWidth = 302;
            this._cbTarget2.FormattingEnabled = true;
            this._cbTarget2.IntegralHeight = false;
            this._cbTarget2.Location = new System.Drawing.Point(5, 128);
            this._cbTarget2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._cbTarget2.Name = "_cbTarget2";
            this._cbTarget2.Size = new System.Drawing.Size(381, 23);
            this._cbTarget2.TabIndex = 5;
            this._cbTarget2.SelectedIndexChanged += new System.EventHandler(this.CbSpellFamilyNamesSelectedIndexChanged);
            // 
            // _cbTarget1
            // 
            this._cbTarget1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cbTarget1.DropDownHeight = 500;
            this._cbTarget1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbTarget1.DropDownWidth = 302;
            this._cbTarget1.FormattingEnabled = true;
            this._cbTarget1.IntegralHeight = false;
            this._cbTarget1.Location = new System.Drawing.Point(5, 100);
            this._cbTarget1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._cbTarget1.Name = "_cbTarget1";
            this._cbTarget1.Size = new System.Drawing.Size(381, 23);
            this._cbTarget1.TabIndex = 5;
            this._cbTarget1.SelectedIndexChanged += new System.EventHandler(this.CbSpellFamilyNamesSelectedIndexChanged);
            // 
            // _cbSpellEffect
            // 
            this._cbSpellEffect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cbSpellEffect.DropDownHeight = 500;
            this._cbSpellEffect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbSpellEffect.DropDownWidth = 302;
            this._cbSpellEffect.FormattingEnabled = true;
            this._cbSpellEffect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._cbSpellEffect.IntegralHeight = false;
            this._cbSpellEffect.Location = new System.Drawing.Point(5, 72);
            this._cbSpellEffect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._cbSpellEffect.Name = "_cbSpellEffect";
            this._cbSpellEffect.Size = new System.Drawing.Size(381, 23);
            this._cbSpellEffect.TabIndex = 4;
            this._cbSpellEffect.SelectedIndexChanged += new System.EventHandler(this.CbSpellFamilyNamesSelectedIndexChanged);
            // 
            // _cbSpellAura
            // 
            this._cbSpellAura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cbSpellAura.DropDownHeight = 500;
            this._cbSpellAura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbSpellAura.DropDownWidth = 302;
            this._cbSpellAura.FormattingEnabled = true;
            this._cbSpellAura.IntegralHeight = false;
            this._cbSpellAura.Location = new System.Drawing.Point(5, 44);
            this._cbSpellAura.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._cbSpellAura.Name = "_cbSpellAura";
            this._cbSpellAura.Size = new System.Drawing.Size(381, 23);
            this._cbSpellAura.TabIndex = 3;
            this._cbSpellAura.SelectedIndexChanged += new System.EventHandler(this.CbSpellFamilyNamesSelectedIndexChanged);
            // 
            // _cbSpellFamilyName
            // 
            this._cbSpellFamilyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cbSpellFamilyName.DropDownHeight = 500;
            this._cbSpellFamilyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbSpellFamilyName.DropDownWidth = 302;
            this._cbSpellFamilyName.FormattingEnabled = true;
            this._cbSpellFamilyName.IntegralHeight = false;
            this._cbSpellFamilyName.ItemHeight = 15;
            this._cbSpellFamilyName.Location = new System.Drawing.Point(5, 16);
            this._cbSpellFamilyName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._cbSpellFamilyName.Name = "_cbSpellFamilyName";
            this._cbSpellFamilyName.Size = new System.Drawing.Size(381, 23);
            this._cbSpellFamilyName.TabIndex = 2;
            this._cbSpellFamilyName.SelectedIndexChanged += new System.EventHandler(this.CbSpellFamilyNamesSelectedIndexChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.BackColor = System.Drawing.Color.LightGray;
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this._bSearch);
            this.groupBox7.Controls.Add(this._tbSearchAttributes);
            this.groupBox7.Controls.Add(this._tbSearchIcon);
            this.groupBox7.Controls.Add(this._tbSearchId);
            this.groupBox7.Location = new System.Drawing.Point(0, 2);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox7.Size = new System.Drawing.Size(394, 103);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Spell Search";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 69);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Attributes&&X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "IconFileDataID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "ID or Name:";
            // 
            // _bSearch
            // 
            this._bSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._bSearch.Location = new System.Drawing.Point(326, 13);
            this._bSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._bSearch.Name = "_bSearch";
            this._bSearch.Size = new System.Drawing.Size(67, 27);
            this._bSearch.TabIndex = 1;
            this._bSearch.Text = "Search";
            this._bSearch.UseVisualStyleBackColor = true;
            this._bSearch.Click += new System.EventHandler(this.BSearchClick);
            // 
            // _tbSearchAttributes
            // 
            this._tbSearchAttributes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tbSearchAttributes.Location = new System.Drawing.Point(124, 66);
            this._tbSearchAttributes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._tbSearchAttributes.Name = "_tbSearchAttributes";
            this._tbSearchAttributes.Size = new System.Drawing.Size(194, 25);
            this._tbSearchAttributes.TabIndex = 0;
            this._tbSearchAttributes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbSearchIdKeyDown);
            // 
            // _tbSearchIcon
            // 
            this._tbSearchIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tbSearchIcon.Location = new System.Drawing.Point(124, 40);
            this._tbSearchIcon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._tbSearchIcon.Name = "_tbSearchIcon";
            this._tbSearchIcon.Size = new System.Drawing.Size(194, 25);
            this._tbSearchIcon.TabIndex = 0;
            this._tbSearchIcon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbSearchIdKeyDown);
            // 
            // _tbSearchId
            // 
            this._tbSearchId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tbSearchId.Location = new System.Drawing.Point(124, 15);
            this._tbSearchId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._tbSearchId.Name = "_tbSearchId";
            this._tbSearchId.Size = new System.Drawing.Size(194, 25);
            this._tbSearchId.TabIndex = 0;
            this._tbSearchId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbSearchIdKeyDown);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this._tpSpellInfo);
            this.tabControl1.Controls.Add(this._tpSpellProcInfo);
            this.tabControl1.Controls.Add(this._tpCompare);
            this.tabControl1.Controls.Add(this._tpSqlData);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1163, 676);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1SelectedIndexChanged);
            // 
            // _tpSpellProcInfo
            // 
            this._tpSpellProcInfo.Controls.Add(this.splitContainer2);
            this._tpSpellProcInfo.Location = new System.Drawing.Point(4, 25);
            this._tpSpellProcInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._tpSpellProcInfo.Name = "_tpSpellProcInfo";
            this._tpSpellProcInfo.Size = new System.Drawing.Size(1155, 647);
            this._tpSpellProcInfo.TabIndex = 2;
            this._tpSpellProcInfo.Text = "Spell Proc Event";
            this._tpSpellProcInfo.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer2.Panel2.Controls.Add(this._lvProcAdditionalInfo);
            this.splitContainer2.Size = new System.Drawing.Size(1155, 647);
            this.splitContainer2.SplitterDistance = 568;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.BackColor = System.Drawing.Color.White;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer3.Panel1.Controls.Add(this.groupBox5);
            this.splitContainer3.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer3.Panel1.Controls.Add(this._gSpellProcEvent);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Size = new System.Drawing.Size(1155, 568);
            this.splitContainer3.SplitterDistance = 241;
            this.splitContainer3.SplitterWidth = 5;
            this.splitContainer3.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox5.Controls.Add(this._clbProcFlags);
            this.groupBox5.Location = new System.Drawing.Point(4, 148);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Size = new System.Drawing.Size(1147, 133);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Spell Proc Flags";
            // 
            // _clbProcFlags
            // 
            this._clbProcFlags.CheckOnClick = true;
            this._clbProcFlags.ColumnWidth = 170;
            this._clbProcFlags.Dock = System.Windows.Forms.DockStyle.Fill;
            this._clbProcFlags.FormattingEnabled = true;
            this._clbProcFlags.Location = new System.Drawing.Point(4, 21);
            this._clbProcFlags.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._clbProcFlags.MultiColumn = true;
            this._clbProcFlags.Name = "_clbProcFlags";
            this._clbProcFlags.Size = new System.Drawing.Size(1139, 109);
            this._clbProcFlags.TabIndex = 0;
            this._clbProcFlags.SelectedIndexChanged += new System.EventHandler(this.ClbSchoolsSelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox4.Controls.Add(this._clbProcFlagEx);
            this.groupBox4.Location = new System.Drawing.Point(4, 69);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(1147, 87);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Spell Proc Ex";
            // 
            // _clbProcFlagEx
            // 
            this._clbProcFlagEx.CheckOnClick = true;
            this._clbProcFlagEx.ColumnWidth = 120;
            this._clbProcFlagEx.Dock = System.Windows.Forms.DockStyle.Fill;
            this._clbProcFlagEx.FormattingEnabled = true;
            this._clbProcFlagEx.Location = new System.Drawing.Point(4, 21);
            this._clbProcFlagEx.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._clbProcFlagEx.MultiColumn = true;
            this._clbProcFlagEx.Name = "_clbProcFlagEx";
            this._clbProcFlagEx.Size = new System.Drawing.Size(1139, 63);
            this._clbProcFlagEx.TabIndex = 3;
            this._clbProcFlagEx.SelectedIndexChanged += new System.EventHandler(this.ClbSchoolsSelectedIndexChanged);
            // 
            // _gSpellProcEvent
            // 
            this._gSpellProcEvent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._gSpellProcEvent.BackColor = System.Drawing.Color.WhiteSmoke;
            this._gSpellProcEvent.Controls.Add(this._clbSchools);
            this._gSpellProcEvent.Controls.Add(this._cbProcFitstSpellFamily);
            this._gSpellProcEvent.Controls.Add(this.label1);
            this._gSpellProcEvent.Controls.Add(this._tbPPM);
            this._gSpellProcEvent.Controls.Add(this.label2);
            this._gSpellProcEvent.Controls.Add(this._tbChance);
            this._gSpellProcEvent.Controls.Add(this.label3);
            this._gSpellProcEvent.Controls.Add(this._tbCooldown);
            this._gSpellProcEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._gSpellProcEvent.Location = new System.Drawing.Point(5, 0);
            this._gSpellProcEvent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._gSpellProcEvent.Name = "_gSpellProcEvent";
            this._gSpellProcEvent.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._gSpellProcEvent.Size = new System.Drawing.Size(1146, 73);
            this._gSpellProcEvent.TabIndex = 8;
            this._gSpellProcEvent.TabStop = false;
            this._gSpellProcEvent.Text = "Spell Proc Event";
            // 
            // _clbSchools
            // 
            this._clbSchools.CheckOnClick = true;
            this._clbSchools.ColumnWidth = 100;
            this._clbSchools.Dock = System.Windows.Forms.DockStyle.Right;
            this._clbSchools.FormattingEnabled = true;
            this._clbSchools.Location = new System.Drawing.Point(526, 21);
            this._clbSchools.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._clbSchools.MultiColumn = true;
            this._clbSchools.Name = "_clbSchools";
            this._clbSchools.Size = new System.Drawing.Size(616, 49);
            this._clbSchools.TabIndex = 5;
            this._clbSchools.SelectedIndexChanged += new System.EventHandler(this.ClbSchoolsSelectedIndexChanged);
            // 
            // _cbProcFitstSpellFamily
            // 
            this._cbProcFitstSpellFamily.DropDownHeight = 500;
            this._cbProcFitstSpellFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbProcFitstSpellFamily.FormattingEnabled = true;
            this._cbProcFitstSpellFamily.IntegralHeight = false;
            this._cbProcFitstSpellFamily.Location = new System.Drawing.Point(4, 16);
            this._cbProcFitstSpellFamily.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._cbProcFitstSpellFamily.Name = "_cbProcFitstSpellFamily";
            this._cbProcFitstSpellFamily.Size = new System.Drawing.Size(455, 23);
            this._cbProcFitstSpellFamily.TabIndex = 4;
            this._cbProcFitstSpellFamily.SelectedIndexChanged += new System.EventHandler(this.ClbSchoolsSelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "PPM";
            // 
            // _tbPPM
            // 
            this._tbPPM.Location = new System.Drawing.Point(52, 44);
            this._tbPPM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._tbPPM.MaxLength = 10;
            this._tbPPM.Name = "_tbPPM";
            this._tbPPM.Size = new System.Drawing.Size(79, 25);
            this._tbPPM.TabIndex = 7;
            this._tbPPM.TextChanged += new System.EventHandler(this.TbCooldownTextChanged);
            this._tbPPM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Chance";
            // 
            // _tbChance
            // 
            this._tbChance.Location = new System.Drawing.Point(207, 44);
            this._tbChance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._tbChance.MaxLength = 10;
            this._tbChance.Name = "_tbChance";
            this._tbChance.Size = new System.Drawing.Size(79, 25);
            this._tbChance.TabIndex = 7;
            this._tbChance.TextChanged += new System.EventHandler(this.TbCooldownTextChanged);
            this._tbChance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cooldown";
            // 
            // _tbCooldown
            // 
            this._tbCooldown.Location = new System.Drawing.Point(380, 44);
            this._tbCooldown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._tbCooldown.MaxLength = 10;
            this._tbCooldown.Name = "_tbCooldown";
            this._tbCooldown.Size = new System.Drawing.Size(79, 25);
            this._tbCooldown.TabIndex = 7;
            this._tbCooldown.TextChanged += new System.EventHandler(this.TbCooldownTextChanged);
            this._tbCooldown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // splitContainer4
            // 
            this.splitContainer4.BackColor = System.Drawing.Color.White;
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer4.Panel1.Controls.Add(this._cbProcSpellFamilyTree);
            this.splitContainer4.Panel1.Controls.Add(this._tvFamilyTree);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainer4.Size = new System.Drawing.Size(1155, 322);
            this.splitContainer4.SplitterDistance = 346;
            this.splitContainer4.SplitterWidth = 5;
            this.splitContainer4.TabIndex = 0;
            // 
            // _cbProcSpellFamilyTree
            // 
            this._cbProcSpellFamilyTree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cbProcSpellFamilyTree.DropDownHeight = 500;
            this._cbProcSpellFamilyTree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbProcSpellFamilyTree.FormattingEnabled = true;
            this._cbProcSpellFamilyTree.IntegralHeight = false;
            this._cbProcSpellFamilyTree.Location = new System.Drawing.Point(1, 2);
            this._cbProcSpellFamilyTree.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._cbProcSpellFamilyTree.Name = "_cbProcSpellFamilyTree";
            this._cbProcSpellFamilyTree.Size = new System.Drawing.Size(342, 23);
            this._cbProcSpellFamilyTree.TabIndex = 1;
            this._cbProcSpellFamilyTree.SelectedIndexChanged += new System.EventHandler(this.TvFamilyTreeSelectedIndexChanged);
            // 
            // _tvFamilyTree
            // 
            this._tvFamilyTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tvFamilyTree.CheckBoxes = true;
            this._tvFamilyTree.ImageIndex = 0;
            this._tvFamilyTree.ImageList = this._ilPro;
            this._tvFamilyTree.Location = new System.Drawing.Point(1, 27);
            this._tvFamilyTree.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._tvFamilyTree.Name = "_tvFamilyTree";
            this._tvFamilyTree.SelectedImageIndex = 0;
            this._tvFamilyTree.ShowNodeToolTips = true;
            this._tvFamilyTree.Size = new System.Drawing.Size(342, 292);
            this._tvFamilyTree.TabIndex = 0;
            this._tvFamilyTree.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.FamilyTreeAfterCheck);
            this._tvFamilyTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TvFamilyTreeAfterSelect);
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this._rtbProcSpellInfo);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer5.Panel2.Controls.Add(this._lvProcSpellList);
            this.splitContainer5.Panel2.Controls.Add(this._bProcSearch);
            this.splitContainer5.Panel2.Controls.Add(this._tbProcSeach);
            this.splitContainer5.Panel2.Controls.Add(this._cbProcTarget2);
            this.splitContainer5.Panel2.Controls.Add(this._cbProcTarget1);
            this.splitContainer5.Panel2.Controls.Add(this._cbProcSpellEffect);
            this.splitContainer5.Panel2.Controls.Add(this._cbProcSpellAura);
            this.splitContainer5.Panel2.Controls.Add(this._cbProcSpellFamilyName);
            this.splitContainer5.Size = new System.Drawing.Size(804, 322);
            this.splitContainer5.SplitterDistance = 533;
            this.splitContainer5.SplitterWidth = 5;
            this.splitContainer5.TabIndex = 0;
            // 
            // _rtbProcSpellInfo
            // 
            this._rtbProcSpellInfo.BackColor = System.Drawing.SystemColors.MenuBar;
            this._rtbProcSpellInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this._rtbProcSpellInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this._rtbProcSpellInfo.Location = new System.Drawing.Point(0, 0);
            this._rtbProcSpellInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._rtbProcSpellInfo.Name = "_rtbProcSpellInfo";
            this._rtbProcSpellInfo.Size = new System.Drawing.Size(533, 322);
            this._rtbProcSpellInfo.TabIndex = 0;
            this._rtbProcSpellInfo.Text = "";
            // 
            // _lvProcSpellList
            // 
            this._lvProcSpellList.AllowColumnReorder = true;
            this._lvProcSpellList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lvProcSpellList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._chProcID,
            this._chProcName});
            this._lvProcSpellList.FullRowSelect = true;
            this._lvProcSpellList.GridLines = true;
            this._lvProcSpellList.HideSelection = false;
            this._lvProcSpellList.Location = new System.Drawing.Point(3, 135);
            this._lvProcSpellList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._lvProcSpellList.MultiSelect = false;
            this._lvProcSpellList.Name = "_lvProcSpellList";
            this._lvProcSpellList.ShowItemToolTips = true;
            this._lvProcSpellList.Size = new System.Drawing.Size(258, 182);
            this._lvProcSpellList.TabIndex = 0;
            this._lvProcSpellList.UseCompatibleStateImageBehavior = false;
            this._lvProcSpellList.View = System.Windows.Forms.View.Details;
            this._lvProcSpellList.VirtualMode = true;
            this._lvProcSpellList.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.LvProcSpellListRetrieveVirtualItem);
            this._lvProcSpellList.SelectedIndexChanged += new System.EventHandler(this.LvProcSpellListSelectedIndexChanged);
            // 
            // _chProcID
            // 
            this._chProcID.Text = "ID";
            this._chProcID.Width = 45;
            // 
            // _chProcName
            // 
            this._chProcName.Text = "Name";
            this._chProcName.Width = 210;
            // 
            // _bProcSearch
            // 
            this._bProcSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._bProcSearch.Location = new System.Drawing.Point(186, 2);
            this._bProcSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._bProcSearch.Name = "_bProcSearch";
            this._bProcSearch.Size = new System.Drawing.Size(72, 23);
            this._bProcSearch.TabIndex = 5;
            this._bProcSearch.Text = "Search";
            this._bProcSearch.UseVisualStyleBackColor = true;
            this._bProcSearch.Click += new System.EventHandler(this.BProcSearchClick);
            // 
            // _tbProcSeach
            // 
            this._tbProcSeach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tbProcSeach.Location = new System.Drawing.Point(4, 3);
            this._tbProcSeach.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._tbProcSeach.Name = "_tbProcSeach";
            this._tbProcSeach.Size = new System.Drawing.Size(172, 25);
            this._tbProcSeach.TabIndex = 4;
            this._tbProcSeach.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbSearchKeyDown);
            // 
            // _cbProcTarget2
            // 
            this._cbProcTarget2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cbProcTarget2.DropDownHeight = 500;
            this._cbProcTarget2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbProcTarget2.FormattingEnabled = true;
            this._cbProcTarget2.IntegralHeight = false;
            this._cbProcTarget2.Location = new System.Drawing.Point(103, 104);
            this._cbProcTarget2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._cbProcTarget2.Name = "_cbProcTarget2";
            this._cbProcTarget2.Size = new System.Drawing.Size(157, 23);
            this._cbProcTarget2.TabIndex = 3;
            this._cbProcTarget2.SelectedIndexChanged += new System.EventHandler(this.CbProcSpellFamilyNameSelectedIndexChanged);
            // 
            // _cbProcTarget1
            // 
            this._cbProcTarget1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cbProcTarget1.DropDownHeight = 500;
            this._cbProcTarget1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbProcTarget1.FormattingEnabled = true;
            this._cbProcTarget1.IntegralHeight = false;
            this._cbProcTarget1.Location = new System.Drawing.Point(4, 104);
            this._cbProcTarget1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._cbProcTarget1.Name = "_cbProcTarget1";
            this._cbProcTarget1.Size = new System.Drawing.Size(86, 23);
            this._cbProcTarget1.TabIndex = 3;
            this._cbProcTarget1.SelectedIndexChanged += new System.EventHandler(this.CbProcSpellFamilyNameSelectedIndexChanged);
            // 
            // _cbProcSpellEffect
            // 
            this._cbProcSpellEffect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cbProcSpellEffect.DropDownHeight = 500;
            this._cbProcSpellEffect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbProcSpellEffect.FormattingEnabled = true;
            this._cbProcSpellEffect.IntegralHeight = false;
            this._cbProcSpellEffect.Location = new System.Drawing.Point(4, 78);
            this._cbProcSpellEffect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._cbProcSpellEffect.Name = "_cbProcSpellEffect";
            this._cbProcSpellEffect.Size = new System.Drawing.Size(256, 23);
            this._cbProcSpellEffect.TabIndex = 3;
            this._cbProcSpellEffect.SelectedIndexChanged += new System.EventHandler(this.CbProcSpellFamilyNameSelectedIndexChanged);
            // 
            // _cbProcSpellAura
            // 
            this._cbProcSpellAura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cbProcSpellAura.DropDownHeight = 500;
            this._cbProcSpellAura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbProcSpellAura.FormattingEnabled = true;
            this._cbProcSpellAura.IntegralHeight = false;
            this._cbProcSpellAura.Location = new System.Drawing.Point(4, 53);
            this._cbProcSpellAura.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._cbProcSpellAura.Name = "_cbProcSpellAura";
            this._cbProcSpellAura.Size = new System.Drawing.Size(256, 23);
            this._cbProcSpellAura.TabIndex = 2;
            this._cbProcSpellAura.SelectedIndexChanged += new System.EventHandler(this.CbProcSpellFamilyNameSelectedIndexChanged);
            // 
            // _cbProcSpellFamilyName
            // 
            this._cbProcSpellFamilyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cbProcSpellFamilyName.DropDownHeight = 500;
            this._cbProcSpellFamilyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbProcSpellFamilyName.FormattingEnabled = true;
            this._cbProcSpellFamilyName.IntegralHeight = false;
            this._cbProcSpellFamilyName.Location = new System.Drawing.Point(4, 28);
            this._cbProcSpellFamilyName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._cbProcSpellFamilyName.Name = "_cbProcSpellFamilyName";
            this._cbProcSpellFamilyName.Size = new System.Drawing.Size(256, 23);
            this._cbProcSpellFamilyName.TabIndex = 1;
            this._cbProcSpellFamilyName.SelectedIndexChanged += new System.EventHandler(this.CbProcSpellFamilyNameSelectedIndexChanged);
            // 
            // _lvProcAdditionalInfo
            // 
            this._lvProcAdditionalInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._chID,
            this._chName});
            this._lvProcAdditionalInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lvProcAdditionalInfo.FullRowSelect = true;
            this._lvProcAdditionalInfo.GridLines = true;
            this._lvProcAdditionalInfo.HideSelection = false;
            this._lvProcAdditionalInfo.Location = new System.Drawing.Point(0, 0);
            this._lvProcAdditionalInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._lvProcAdditionalInfo.Name = "_lvProcAdditionalInfo";
            this._lvProcAdditionalInfo.Size = new System.Drawing.Size(1155, 74);
            this._lvProcAdditionalInfo.SmallImageList = this._ilPro;
            this._lvProcAdditionalInfo.TabIndex = 0;
            this._lvProcAdditionalInfo.UseCompatibleStateImageBehavior = false;
            this._lvProcAdditionalInfo.View = System.Windows.Forms.View.Details;
            this._lvProcAdditionalInfo.SelectedIndexChanged += new System.EventHandler(this.LvProcAdditionalInfoSelectedIndexChanged);
            // 
            // _chID
            // 
            this._chID.Text = "Entry";
            this._chID.Width = 100;
            // 
            // _chName
            // 
            this._chName.Text = "Name";
            this._chName.Width = 685;
            // 
            // _tpSqlData
            // 
            this._tpSqlData.Controls.Add(this.groupBox3);
            this._tpSqlData.Controls.Add(this.groupBox2);
            this._tpSqlData.Location = new System.Drawing.Point(4, 25);
            this._tpSqlData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._tpSqlData.Name = "_tpSqlData";
            this._tpSqlData.Size = new System.Drawing.Size(1155, 647);
            this._tpSqlData.TabIndex = 3;
            this._tpSqlData.Text = "Sql Data";
            this._tpSqlData.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Controls.Add(this._cbBinaryCompare);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this._tbSqlManual);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this._bSqlProcEx);
            this.groupBox3.Controls.Add(this._bSqlProc);
            this.groupBox3.Controls.Add(this._bSqlSchool);
            this.groupBox3.Controls.Add(this._tbSqlProcEx);
            this.groupBox3.Controls.Add(this._tbSqlProc);
            this.groupBox3.Controls.Add(this._tbSqlSchool);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this._cbSqlSpellFamily);
            this.groupBox3.Controls.Add(this._bSelect);
            this.groupBox3.Location = new System.Drawing.Point(8, 3);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(1140, 98);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // _cbBinaryCompare
            // 
            this._cbBinaryCompare.AutoSize = true;
            this._cbBinaryCompare.Location = new System.Drawing.Point(1003, 63);
            this._cbBinaryCompare.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._cbBinaryCompare.Name = "_cbBinaryCompare";
            this._cbBinaryCompare.Size = new System.Drawing.Size(141, 19);
            this._cbBinaryCompare.TabIndex = 8;
            this._cbBinaryCompare.Text = "Binary Compare";
            this._cbBinaryCompare.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 65);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "Manual:";
            // 
            // _tbSqlManual
            // 
            this._tbSqlManual.Location = new System.Drawing.Point(108, 61);
            this._tbSqlManual.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._tbSqlManual.Name = "_tbSqlManual";
            this._tbSqlManual.Size = new System.Drawing.Size(361, 25);
            this._tbSqlManual.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 23);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Family Name:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(761, 65);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 15);
            this.label12.TabIndex = 5;
            this.label12.Text = "Proc Ex:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(501, 65);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 15);
            this.label11.TabIndex = 5;
            this.label11.Text = "Proc:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(761, 23);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 15);
            this.label10.TabIndex = 5;
            this.label10.Text = "School:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(501, 23);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Spell ID:";
            // 
            // _bSqlProcEx
            // 
            this._bSqlProcEx.Location = new System.Drawing.Point(957, 59);
            this._bSqlProcEx.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._bSqlProcEx.Name = "_bSqlProcEx";
            this._bSqlProcEx.Size = new System.Drawing.Size(37, 27);
            this._bSqlProcEx.TabIndex = 4;
            this._bSqlProcEx.Text = "...";
            this._bSqlProcEx.UseVisualStyleBackColor = true;
            this._bSqlProcEx.Click += new System.EventHandler(this.CalcProcFlagsClick);
            // 
            // _bSqlProc
            // 
            this._bSqlProc.Location = new System.Drawing.Point(713, 59);
            this._bSqlProc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._bSqlProc.Name = "_bSqlProc";
            this._bSqlProc.Size = new System.Drawing.Size(37, 27);
            this._bSqlProc.TabIndex = 4;
            this._bSqlProc.Text = "...";
            this._bSqlProc.UseVisualStyleBackColor = true;
            this._bSqlProc.Click += new System.EventHandler(this.CalcProcFlagsClick);
            // 
            // _bSqlSchool
            // 
            this._bSqlSchool.Location = new System.Drawing.Point(957, 17);
            this._bSqlSchool.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._bSqlSchool.Name = "_bSqlSchool";
            this._bSqlSchool.Size = new System.Drawing.Size(37, 27);
            this._bSqlSchool.TabIndex = 4;
            this._bSqlSchool.Text = "...";
            this._bSqlSchool.UseVisualStyleBackColor = true;
            this._bSqlSchool.Click += new System.EventHandler(this.CalcProcFlagsClick);
            // 
            // _tbSqlProcEx
            // 
            this._tbSqlProcEx.Location = new System.Drawing.Point(827, 61);
            this._tbSqlProcEx.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._tbSqlProcEx.Name = "_tbSqlProcEx";
            this._tbSqlProcEx.Size = new System.Drawing.Size(121, 25);
            this._tbSqlProcEx.TabIndex = 3;
            // 
            // _tbSqlProc
            // 
            this._tbSqlProc.Location = new System.Drawing.Point(572, 61);
            this._tbSqlProc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._tbSqlProc.Name = "_tbSqlProc";
            this._tbSqlProc.Size = new System.Drawing.Size(132, 25);
            this._tbSqlProc.TabIndex = 3;
            // 
            // _tbSqlSchool
            // 
            this._tbSqlSchool.Location = new System.Drawing.Point(827, 20);
            this._tbSqlSchool.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._tbSqlSchool.Name = "_tbSqlSchool";
            this._tbSqlSchool.Size = new System.Drawing.Size(121, 25);
            this._tbSqlSchool.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(572, 20);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 25);
            this.textBox1.TabIndex = 2;
            // 
            // _cbSqlSpellFamily
            // 
            this._cbSqlSpellFamily.DropDownHeight = 500;
            this._cbSqlSpellFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbSqlSpellFamily.FormattingEnabled = true;
            this._cbSqlSpellFamily.IntegralHeight = false;
            this._cbSqlSpellFamily.Location = new System.Drawing.Point(108, 20);
            this._cbSqlSpellFamily.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._cbSqlSpellFamily.Name = "_cbSqlSpellFamily";
            this._cbSqlSpellFamily.Size = new System.Drawing.Size(361, 23);
            this._cbSqlSpellFamily.TabIndex = 1;
            // 
            // _bSelect
            // 
            this._bSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._bSelect.Location = new System.Drawing.Point(1907, 12);
            this._bSelect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._bSelect.Name = "_bSelect";
            this._bSelect.Size = new System.Drawing.Size(100, 27);
            this._bSelect.TabIndex = 0;
            this._bSelect.Text = "Select";
            this._bSelect.UseVisualStyleBackColor = true;
            this._bSelect.Click += new System.EventHandler(this.SelectClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.splitContainer6);
            this.groupBox2.Location = new System.Drawing.Point(0, 108);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(1152, 537);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.Location = new System.Drawing.Point(4, 21);
            this.splitContainer6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this._lvDataList);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer6.Panel2.Controls.Add(this._rtbSqlLog);
            this.splitContainer6.Panel2.Controls.Add(this._bSqlToBase);
            this.splitContainer6.Panel2.Controls.Add(this._bSqlSave);
            this.splitContainer6.Size = new System.Drawing.Size(1144, 513);
            this.splitContainer6.SplitterDistance = 264;
            this.splitContainer6.SplitterWidth = 5;
            this.splitContainer6.TabIndex = 0;
            // 
            // _lvDataList
            // 
            this._lvDataList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.entry,
            this.spellname,
            this.schoolmask,
            this.spellfamilyname,
            this.spellfamilymask0,
            this.spellfamilymask1,
            this.spellfamilymask2,
            this.procflag,
            this.procEx,
            this.ppmRate,
            this.customchance,
            this.cooldown});
            this._lvDataList.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lvDataList.FullRowSelect = true;
            this._lvDataList.GridLines = true;
            this._lvDataList.HideSelection = false;
            this._lvDataList.Location = new System.Drawing.Point(0, 0);
            this._lvDataList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._lvDataList.MultiSelect = false;
            this._lvDataList.Name = "_lvDataList";
            this._lvDataList.Size = new System.Drawing.Size(1144, 264);
            this._lvDataList.TabIndex = 0;
            this._lvDataList.UseCompatibleStateImageBehavior = false;
            this._lvDataList.View = System.Windows.Forms.View.Details;
            this._lvDataList.VirtualMode = true;
            this._lvDataList.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.LvSqlDataRetrieveVirtualItem);
            this._lvDataList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SqlDataListKeyDown);
            this._lvDataList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SqlDataListMouseDoubleClick);
            // 
            // entry
            // 
            this.entry.Text = "Entry";
            this.entry.Width = 56;
            // 
            // spellname
            // 
            this.spellname.Text = "Spell Name";
            this.spellname.Width = 300;
            // 
            // schoolmask
            // 
            this.schoolmask.Text = "School Mask";
            this.schoolmask.Width = 78;
            // 
            // spellfamilyname
            // 
            this.spellfamilyname.Text = "Spell Family Name";
            this.spellfamilyname.Width = 103;
            // 
            // spellfamilymask0
            // 
            this.spellfamilymask0.Text = "Spell Family Mask 0";
            this.spellfamilymask0.Width = 110;
            // 
            // spellfamilymask1
            // 
            this.spellfamilymask1.Text = "Spell Family Mask 1";
            this.spellfamilymask1.Width = 110;
            // 
            // spellfamilymask2
            // 
            this.spellfamilymask2.Text = "Spell Family Mask 2";
            this.spellfamilymask2.Width = 110;
            // 
            // procflag
            // 
            this.procflag.Text = "Proc Flags";
            this.procflag.Width = 80;
            // 
            // procEx
            // 
            this.procEx.Text = "Proc Ex";
            this.procEx.Width = 80;
            // 
            // ppmRate
            // 
            this.ppmRate.Text = "PPM Rate";
            this.ppmRate.Width = 67;
            // 
            // customchance
            // 
            this.customchance.Text = "Custom Chance";
            this.customchance.Width = 93;
            // 
            // cooldown
            // 
            this.cooldown.Text = "Colldown";
            // 
            // _rtbSqlLog
            // 
            this._rtbSqlLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._rtbSqlLog.Location = new System.Drawing.Point(0, 37);
            this._rtbSqlLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._rtbSqlLog.Name = "_rtbSqlLog";
            this._rtbSqlLog.Size = new System.Drawing.Size(1143, 210);
            this._rtbSqlLog.TabIndex = 3;
            this._rtbSqlLog.Text = "";
            // 
            // _bSqlToBase
            // 
            this._bSqlToBase.Location = new System.Drawing.Point(112, 3);
            this._bSqlToBase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._bSqlToBase.Name = "_bSqlToBase";
            this._bSqlToBase.Size = new System.Drawing.Size(100, 27);
            this._bSqlToBase.TabIndex = 2;
            this._bSqlToBase.Text = "To DB";
            this._bSqlToBase.UseVisualStyleBackColor = true;
            this._bSqlToBase.Click += new System.EventHandler(this.SqlToBaseClick);
            // 
            // _bSqlSave
            // 
            this._bSqlSave.Location = new System.Drawing.Point(4, 3);
            this._bSqlSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._bSqlSave.Name = "_bSqlSave";
            this._bSqlSave.Size = new System.Drawing.Size(100, 27);
            this._bSqlSave.TabIndex = 1;
            this._bSqlSave.Text = "Save";
            this._bSqlSave.UseVisualStyleBackColor = true;
            this._bSqlSave.Click += new System.EventHandler(this.SqlSaveClick);
            // 
            // _cbProcFlag
            // 
            this._cbProcFlag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cbProcFlag.Appearance = System.Windows.Forms.Appearance.Button;
            this._cbProcFlag.AutoSize = true;
            this._cbProcFlag.Location = new System.Drawing.Point(989, 1);
            this._cbProcFlag.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._cbProcFlag.Name = "_cbProcFlag";
            this._cbProcFlag.Size = new System.Drawing.Size(81, 25);
            this._cbProcFlag.TabIndex = 2;
            this._cbProcFlag.Text = "ProcFlag";
            this._cbProcFlag.UseVisualStyleBackColor = true;
            this._cbProcFlag.Visible = false;
            this._cbProcFlag.CheckedChanged += new System.EventHandler(this.CbProcFlagCheckedChanged);
            // 
            // _bWrite
            // 
            this._bWrite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._bWrite.Location = new System.Drawing.Point(915, 1);
            this._bWrite.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._bWrite.Name = "_bWrite";
            this._bWrite.Size = new System.Drawing.Size(68, 27);
            this._bWrite.TabIndex = 3;
            this._bWrite.Text = "Write";
            this._bWrite.UseVisualStyleBackColor = true;
            this._bWrite.Visible = false;
            this._bWrite.Click += new System.EventHandler(this.WriteClick);
            // 
            // _bLevelScaling
            // 
            this._bLevelScaling.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._bLevelScaling.Location = new System.Drawing.Point(1077, 1);
            this._bLevelScaling.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._bLevelScaling.Name = "_bLevelScaling";
            this._bLevelScaling.Size = new System.Drawing.Size(80, 27);
            this._bLevelScaling.TabIndex = 4;
            this._bLevelScaling.Text = "Scaling";
            this._bLevelScaling.UseVisualStyleBackColor = true;
            this._bLevelScaling.Click += new System.EventHandler(this.LevelScalingClick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 726);
            this.Controls.Add(this._bLevelScaling);
            this.Controls.Add(this._bWrite);
            this.Controls.Add(this._cbProcFlag);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(1167, 668);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.Resize += new System.EventHandler(this.FormMainResize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            this.splitContainer8.Panel1.ResumeLayout(false);
            this.splitContainer8.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).EndInit();
            this.splitContainer8.ResumeLayout(false);
            this._tpCompare.ResumeLayout(false);
            this._scCompareRoot.Panel1.ResumeLayout(false);
            this._scCompareRoot.Panel1.PerformLayout();
            this._scCompareRoot.Panel2.ResumeLayout(false);
            this._scCompareRoot.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._scCompareRoot)).EndInit();
            this._scCompareRoot.ResumeLayout(false);
            this._tpSpellInfo.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this._gSpellFilter.ResumeLayout(false);
            this._gbAdvansedSearch.ResumeLayout(false);
            this._gbAdvansedSearch.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this._tpSpellProcInfo.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this._gSpellProcEvent.ResumeLayout(false);
            this._gSpellProcEvent.PerformLayout();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            this.splitContainer5.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this._tpSqlData.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripStatusLabel _status;
        private System.Windows.Forms.ToolStripStatusLabel _ProcStatus;
        private System.Windows.Forms.ToolStripStatusLabel _dbConnect;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.SplitContainer splitContainer8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ImageList _ilPro;
        private System.Windows.Forms.TabPage _tpCompare;
        private System.Windows.Forms.SplitContainer _scCompareRoot;
        private System.Windows.Forms.Button _bCompareSearch1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox _tbCompareFilterSpell1;
        private System.Windows.Forms.RichTextBox _rtbCompareSpell1;
        private System.Windows.Forms.Button _bCompareSearch2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox _rtbCompareSpell2;
        private System.Windows.Forms.TextBox _tbCompareFilterSpell2;
        private System.Windows.Forms.TabPage _tpSpellInfo;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox _rtSpellInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView _lvSpellList;
        private System.Windows.Forms.ColumnHeader chSpellID;
        private System.Windows.Forms.ColumnHeader chSpellName;
        private System.Windows.Forms.ColumnHeader chMiscID;
        private System.Windows.Forms.GroupBox _gSpellFilter;
        private System.Windows.Forms.GroupBox _gbAdvansedSearch;
        private System.Windows.Forms.ComboBox _cbAdvancedFilter2CompareType;
        private System.Windows.Forms.ComboBox _cbAdvancedFilter1CompareType;
        private System.Windows.Forms.TextBox _tbAdvancedFilter2Val;
        private System.Windows.Forms.TextBox _tbAdvancedFilter1Val;
        private System.Windows.Forms.ComboBox _cbAdvancedFilter2;
        private System.Windows.Forms.ComboBox _cbAdvancedFilter1;
        private System.Windows.Forms.ComboBox _cbAdvancedEffectFilter2CompareType;
        private System.Windows.Forms.ComboBox _cbAdvancedEffectFilter1CompareType;
        private System.Windows.Forms.ComboBox _cbAdvancedEffectFilter2;
        private System.Windows.Forms.ComboBox _cbAdvancedEffectFilter1;
        private System.Windows.Forms.TextBox _tbAdvancedEffectFilter1Val;
        private System.Windows.Forms.TextBox _tbAdvancedEffectFilter2Val;
        private System.Windows.Forms.ComboBox _cbTarget2;
        private System.Windows.Forms.ComboBox _cbTarget1;
        private System.Windows.Forms.ComboBox _cbSpellEffect;
        private System.Windows.Forms.ComboBox _cbSpellAura;
        private System.Windows.Forms.ComboBox _cbSpellFamilyName;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button _bSearch;
        private System.Windows.Forms.TextBox _tbSearchAttributes;
        private System.Windows.Forms.TextBox _tbSearchIcon;
        private System.Windows.Forms.TextBox _tbSearchId;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripMenuItem _tsmHelp;
        private System.Windows.Forms.ToolStripMenuItem _tsmAbout;
        private System.Windows.Forms.TabPage _tpSpellProcInfo;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabPage _tpSqlData;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView _lvProcAdditionalInfo;
        private System.Windows.Forms.ColumnHeader _chID;
        private System.Windows.Forms.ColumnHeader _chName;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.ComboBox _cbProcSpellFamilyName;
        private System.Windows.Forms.ComboBox _cbProcSpellAura;
        private System.Windows.Forms.ComboBox _cbProcSpellEffect;
        private System.Windows.Forms.ComboBox _cbProcTarget1;
        private System.Windows.Forms.ComboBox _cbProcTarget2;
        private System.Windows.Forms.TextBox _tbProcSeach;
        private System.Windows.Forms.Button _bProcSearch;
        private System.Windows.Forms.ListView _lvProcSpellList;
        private System.Windows.Forms.ColumnHeader _chProcID;
        private System.Windows.Forms.ColumnHeader _chProcName;
        private System.Windows.Forms.TreeView _tvFamilyTree;
        private System.Windows.Forms.ComboBox _cbProcSpellFamilyTree;
        private System.Windows.Forms.GroupBox _gSpellProcEvent;
        private System.Windows.Forms.TextBox _tbCooldown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _tbChance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _tbPPM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _cbProcFitstSpellFamily;
        private System.Windows.Forms.CheckedListBox _clbSchools;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckedListBox _clbProcFlagEx;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckedListBox _clbProcFlags;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.Button _bSqlSave;
        private System.Windows.Forms.Button _bSqlToBase;
        private System.Windows.Forms.RichTextBox _rtbSqlLog;
        private System.Windows.Forms.ListView _lvDataList;
        private System.Windows.Forms.ColumnHeader entry;
        private System.Windows.Forms.ColumnHeader spellname;
        private System.Windows.Forms.ColumnHeader schoolmask;
        private System.Windows.Forms.ColumnHeader spellfamilyname;
        private System.Windows.Forms.ColumnHeader spellfamilymask0;
        private System.Windows.Forms.ColumnHeader spellfamilymask1;
        private System.Windows.Forms.ColumnHeader spellfamilymask2;
        private System.Windows.Forms.ColumnHeader procflag;
        private System.Windows.Forms.ColumnHeader procEx;
        private System.Windows.Forms.ColumnHeader ppmRate;
        private System.Windows.Forms.ColumnHeader customchance;
        private System.Windows.Forms.ColumnHeader cooldown;
        private System.Windows.Forms.Button _bSelect;
        private System.Windows.Forms.ComboBox _cbSqlSpellFamily;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox _tbSqlSchool;
        private System.Windows.Forms.TextBox _tbSqlProc;
        private System.Windows.Forms.TextBox _tbSqlProcEx;
        private System.Windows.Forms.Button _bSqlSchool;
        private System.Windows.Forms.Button _bSqlProc;
        private System.Windows.Forms.Button _bSqlProcEx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox _tbSqlManual;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox _cbBinaryCompare;
        private System.Windows.Forms.CheckBox _cbProcFlag;
        private System.Windows.Forms.Button _bWrite;
        private System.Windows.Forms.ToolStripMenuItem _tsmFile;
        private System.Windows.Forms.ToolStripMenuItem _Connected;
        private System.Windows.Forms.ToolStripMenuItem _tsmSettings;
        private System.Windows.Forms.ToolStripMenuItem _tsmExit;
        private System.Windows.Forms.Button _bLevelScaling;
        private System.Windows.Forms.RichTextBox _rtbProcSpellInfo;
    }
}
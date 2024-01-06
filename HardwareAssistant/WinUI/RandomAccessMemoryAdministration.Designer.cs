namespace HardwareAssistant.WinUI
{
    partial class RandomAccessMemoryAdministration
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandomAccessMemoryAdministration));
            this.btnReloadData = new System.Windows.Forms.Button();
            this.lvRandomAccessMemory = new System.Windows.Forms.ListView();
            this.lcComponentCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lcComponentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lcManufacturer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lcCompatibility = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lcSeries = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lcCapacity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lcFrequency = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lcLatency = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lcVoltage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lcTiming = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbRAM = new System.Windows.Forms.GroupBox();
            this.lblMemoryType = new System.Windows.Forms.Label();
            this.tbLatency = new System.Windows.Forms.TextBox();
            this.cboCompatibility = new System.Windows.Forms.ComboBox();
            this.lbLatency = new System.Windows.Forms.Label();
            this.tbCapacity = new System.Windows.Forms.TextBox();
            this.lbCapacity = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.lbSeries = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbManufacturer = new System.Windows.Forms.TextBox();
            this.lbManufacturer = new System.Windows.Forms.Label();
            this.tbComponentName = new System.Windows.Forms.TextBox();
            this.lbComponentName = new System.Windows.Forms.Label();
            this.tbTiming = new System.Windows.Forms.TextBox();
            this.lbTiming = new System.Windows.Forms.Label();
            this.tbVoltage = new System.Windows.Forms.TextBox();
            this.lbVoltage = new System.Windows.Forms.Label();
            this.tbFrequency = new System.Windows.Forms.TextBox();
            this.lbFrequency = new System.Windows.Forms.Label();
            this.tbSeries = new System.Windows.Forms.TextBox();
            this.tbComponentCode = new System.Windows.Forms.TextBox();
            this.lbComponentCode = new System.Windows.Forms.Label();
            this.cmsRAM = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiModificaRAM = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStergeRAM = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.epGeneral = new System.Windows.Forms.ErrorProvider(this.components);
            this.tsRAM = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.gbRAM.SuspendLayout();
            this.cmsRAM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epGeneral)).BeginInit();
            this.tsRAM.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReloadData
            // 
            this.btnReloadData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReloadData.Location = new System.Drawing.Point(1217, 4);
            this.btnReloadData.Margin = new System.Windows.Forms.Padding(4);
            this.btnReloadData.Name = "btnReloadData";
            this.btnReloadData.Size = new System.Drawing.Size(111, 28);
            this.btnReloadData.TabIndex = 0;
            this.btnReloadData.Text = "Reincarca";
            this.btnReloadData.UseVisualStyleBackColor = true;
            this.btnReloadData.Click += new System.EventHandler(this.btnReloadData_Click);
            // 
            // lvRandomAccessMemory
            // 
            this.lvRandomAccessMemory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvRandomAccessMemory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lcComponentCode,
            this.lcComponentName,
            this.lcManufacturer,
            this.lcCompatibility,
            this.lcSeries,
            this.lcCapacity,
            this.lcFrequency,
            this.lcLatency,
            this.lcVoltage,
            this.lcTiming});
            this.lvRandomAccessMemory.FullRowSelect = true;
            this.lvRandomAccessMemory.HideSelection = false;
            this.lvRandomAccessMemory.Location = new System.Drawing.Point(307, 38);
            this.lvRandomAccessMemory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvRandomAccessMemory.MultiSelect = false;
            this.lvRandomAccessMemory.Name = "lvRandomAccessMemory";
            this.lvRandomAccessMemory.Size = new System.Drawing.Size(1020, 536);
            this.lvRandomAccessMemory.TabIndex = 1;
            this.lvRandomAccessMemory.UseCompatibleStateImageBehavior = false;
            this.lvRandomAccessMemory.View = System.Windows.Forms.View.Details;
            this.lvRandomAccessMemory.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvRandomAccessMemory_ItemSelectionChanged);
            this.lvRandomAccessMemory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvRandomAccessMemory_KeyDown);
            this.lvRandomAccessMemory.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvRandomAccessMemory_MouseClick);
            this.lvRandomAccessMemory.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvRandomAccessMemory_MouseDoubleClick);
            // 
            // lcComponentCode
            // 
            this.lcComponentCode.Text = "Codul";
            this.lcComponentCode.Width = 174;
            // 
            // lcComponentName
            // 
            this.lcComponentName.Text = "Denumire";
            this.lcComponentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lcComponentName.Width = 315;
            // 
            // lcManufacturer
            // 
            this.lcManufacturer.Text = "Producator";
            this.lcManufacturer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lcManufacturer.Width = 125;
            // 
            // lcCompatibility
            // 
            this.lcCompatibility.Text = "Tip memorie";
            this.lcCompatibility.Width = 100;
            // 
            // lcSeries
            // 
            this.lcSeries.Text = "Serie";
            this.lcSeries.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lcSeries.Width = 96;
            // 
            // lcCapacity
            // 
            this.lcCapacity.Text = "Capacitate";
            this.lcCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lcCapacity.Width = 108;
            // 
            // lcFrequency
            // 
            this.lcFrequency.Text = "Frecventa";
            this.lcFrequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lcFrequency.Width = 100;
            // 
            // lcLatency
            // 
            this.lcLatency.Text = "Latenta";
            this.lcLatency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lcLatency.Width = 91;
            // 
            // lcVoltage
            // 
            this.lcVoltage.Text = "Tensiune alimentare";
            this.lcVoltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lcVoltage.Width = 166;
            // 
            // lcTiming
            // 
            this.lcTiming.Text = "Timing";
            this.lcTiming.Width = 100;
            // 
            // gbRAM
            // 
            this.gbRAM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbRAM.Controls.Add(this.lblMemoryType);
            this.gbRAM.Controls.Add(this.tbLatency);
            this.gbRAM.Controls.Add(this.cboCompatibility);
            this.gbRAM.Controls.Add(this.lbLatency);
            this.gbRAM.Controls.Add(this.tbCapacity);
            this.gbRAM.Controls.Add(this.lbCapacity);
            this.gbRAM.Controls.Add(this.btnClean);
            this.gbRAM.Controls.Add(this.lbSeries);
            this.gbRAM.Controls.Add(this.btnAdd);
            this.gbRAM.Controls.Add(this.tbManufacturer);
            this.gbRAM.Controls.Add(this.lbManufacturer);
            this.gbRAM.Controls.Add(this.tbComponentName);
            this.gbRAM.Controls.Add(this.lbComponentName);
            this.gbRAM.Controls.Add(this.tbTiming);
            this.gbRAM.Controls.Add(this.lbTiming);
            this.gbRAM.Controls.Add(this.tbVoltage);
            this.gbRAM.Controls.Add(this.lbVoltage);
            this.gbRAM.Controls.Add(this.tbFrequency);
            this.gbRAM.Controls.Add(this.lbFrequency);
            this.gbRAM.Controls.Add(this.tbSeries);
            this.gbRAM.Controls.Add(this.tbComponentCode);
            this.gbRAM.Controls.Add(this.lbComponentCode);
            this.gbRAM.Location = new System.Drawing.Point(13, 29);
            this.gbRAM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbRAM.Name = "gbRAM";
            this.gbRAM.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbRAM.Size = new System.Drawing.Size(288, 620);
            this.gbRAM.TabIndex = 2;
            this.gbRAM.TabStop = false;
            this.gbRAM.Text = "Adauga o memorie RAM";
            // 
            // lblMemoryType
            // 
            this.lblMemoryType.AutoSize = true;
            this.lblMemoryType.Location = new System.Drawing.Point(2, 172);
            this.lblMemoryType.Name = "lblMemoryType";
            this.lblMemoryType.Size = new System.Drawing.Size(86, 17);
            this.lblMemoryType.TabIndex = 15;
            this.lblMemoryType.Text = "Tip memorie";
            // 
            // tbLatency
            // 
            this.tbLatency.Location = new System.Drawing.Point(6, 410);
            this.tbLatency.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLatency.Name = "tbLatency";
            this.tbLatency.Size = new System.Drawing.Size(257, 22);
            this.tbLatency.TabIndex = 18;
            // 
            // cboCompatibility
            // 
            this.cboCompatibility.FormattingEnabled = true;
            this.cboCompatibility.Location = new System.Drawing.Point(6, 192);
            this.cboCompatibility.Margin = new System.Windows.Forms.Padding(4);
            this.cboCompatibility.Name = "cboCompatibility";
            this.cboCompatibility.Size = new System.Drawing.Size(257, 24);
            this.cboCompatibility.TabIndex = 8;
            // 
            // lbLatency
            // 
            this.lbLatency.AutoSize = true;
            this.lbLatency.Location = new System.Drawing.Point(10, 390);
            this.lbLatency.Name = "lbLatency";
            this.lbLatency.Size = new System.Drawing.Size(56, 17);
            this.lbLatency.TabIndex = 17;
            this.lbLatency.Text = "Latenta";
            // 
            // tbCapacity
            // 
            this.tbCapacity.Location = new System.Drawing.Point(6, 302);
            this.tbCapacity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCapacity.Name = "tbCapacity";
            this.tbCapacity.Size = new System.Drawing.Size(257, 22);
            this.tbCapacity.TabIndex = 16;
            // 
            // lbCapacity
            // 
            this.lbCapacity.AutoSize = true;
            this.lbCapacity.Location = new System.Drawing.Point(6, 277);
            this.lbCapacity.Name = "lbCapacity";
            this.lbCapacity.Size = new System.Drawing.Size(75, 17);
            this.lbCapacity.TabIndex = 15;
            this.lbCapacity.Text = "Capacitate";
            // 
            // btnClean
            // 
            this.btnClean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClean.Location = new System.Drawing.Point(140, 542);
            this.btnClean.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(123, 50);
            this.btnClean.TabIndex = 4;
            this.btnClean.Text = "Curata formular";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // lbSeries
            // 
            this.lbSeries.AutoSize = true;
            this.lbSeries.Location = new System.Drawing.Point(6, 224);
            this.lbSeries.Name = "lbSeries";
            this.lbSeries.Size = new System.Drawing.Size(41, 17);
            this.lbSeries.TabIndex = 14;
            this.lbSeries.Text = "Serie";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Location = new System.Drawing.Point(5, 542);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 50);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Adauga RAM";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbManufacturer
            // 
            this.tbManufacturer.Location = new System.Drawing.Point(6, 141);
            this.tbManufacturer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbManufacturer.Name = "tbManufacturer";
            this.tbManufacturer.Size = new System.Drawing.Size(257, 22);
            this.tbManufacturer.TabIndex = 13;
            // 
            // lbManufacturer
            // 
            this.lbManufacturer.AutoSize = true;
            this.lbManufacturer.Location = new System.Drawing.Point(6, 122);
            this.lbManufacturer.Name = "lbManufacturer";
            this.lbManufacturer.Size = new System.Drawing.Size(78, 17);
            this.lbManufacturer.TabIndex = 12;
            this.lbManufacturer.Text = "Producator";
            // 
            // tbComponentName
            // 
            this.tbComponentName.Location = new System.Drawing.Point(6, 92);
            this.tbComponentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbComponentName.Name = "tbComponentName";
            this.tbComponentName.Size = new System.Drawing.Size(257, 22);
            this.tbComponentName.TabIndex = 11;
            this.tbComponentName.Validating += new System.ComponentModel.CancelEventHandler(this.tbComponentName_Validating);
            this.tbComponentName.Validated += new System.EventHandler(this.tbComponentName_Validated);
            // 
            // lbComponentName
            // 
            this.lbComponentName.AutoSize = true;
            this.lbComponentName.Location = new System.Drawing.Point(6, 72);
            this.lbComponentName.Name = "lbComponentName";
            this.lbComponentName.Size = new System.Drawing.Size(69, 17);
            this.lbComponentName.TabIndex = 10;
            this.lbComponentName.Text = "Denumire";
            // 
            // tbTiming
            // 
            this.tbTiming.Location = new System.Drawing.Point(6, 503);
            this.tbTiming.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTiming.Name = "tbTiming";
            this.tbTiming.Size = new System.Drawing.Size(257, 22);
            this.tbTiming.TabIndex = 9;
            // 
            // lbTiming
            // 
            this.lbTiming.AutoSize = true;
            this.lbTiming.Location = new System.Drawing.Point(10, 483);
            this.lbTiming.Name = "lbTiming";
            this.lbTiming.Size = new System.Drawing.Size(50, 17);
            this.lbTiming.TabIndex = 8;
            this.lbTiming.Text = "Timing";
            // 
            // tbVoltage
            // 
            this.tbVoltage.Location = new System.Drawing.Point(6, 456);
            this.tbVoltage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbVoltage.Name = "tbVoltage";
            this.tbVoltage.Size = new System.Drawing.Size(257, 22);
            this.tbVoltage.TabIndex = 7;
            // 
            // lbVoltage
            // 
            this.lbVoltage.AutoSize = true;
            this.lbVoltage.Location = new System.Drawing.Point(10, 437);
            this.lbVoltage.Name = "lbVoltage";
            this.lbVoltage.Size = new System.Drawing.Size(157, 17);
            this.lbVoltage.TabIndex = 6;
            this.lbVoltage.Text = "Tensiune de alimentare";
            // 
            // tbFrequency
            // 
            this.tbFrequency.Location = new System.Drawing.Point(6, 356);
            this.tbFrequency.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFrequency.Name = "tbFrequency";
            this.tbFrequency.Size = new System.Drawing.Size(257, 22);
            this.tbFrequency.TabIndex = 5;
            // 
            // lbFrequency
            // 
            this.lbFrequency.AutoSize = true;
            this.lbFrequency.Location = new System.Drawing.Point(10, 333);
            this.lbFrequency.Name = "lbFrequency";
            this.lbFrequency.Size = new System.Drawing.Size(71, 17);
            this.lbFrequency.TabIndex = 4;
            this.lbFrequency.Text = "Frecventa";
            // 
            // tbSeries
            // 
            this.tbSeries.Location = new System.Drawing.Point(6, 245);
            this.tbSeries.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSeries.Name = "tbSeries";
            this.tbSeries.Size = new System.Drawing.Size(257, 22);
            this.tbSeries.TabIndex = 3;
            // 
            // tbComponentCode
            // 
            this.tbComponentCode.Location = new System.Drawing.Point(6, 46);
            this.tbComponentCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbComponentCode.Name = "tbComponentCode";
            this.tbComponentCode.Size = new System.Drawing.Size(257, 22);
            this.tbComponentCode.TabIndex = 1;
            this.tbComponentCode.Validating += new System.ComponentModel.CancelEventHandler(this.tbComponentCode_Validating);
            this.tbComponentCode.Validated += new System.EventHandler(this.tbComponentCode_Validated);
            // 
            // lbComponentCode
            // 
            this.lbComponentCode.AutoSize = true;
            this.lbComponentCode.Location = new System.Drawing.Point(6, 27);
            this.lbComponentCode.Name = "lbComponentCode";
            this.lbComponentCode.Size = new System.Drawing.Size(44, 17);
            this.lbComponentCode.TabIndex = 0;
            this.lbComponentCode.Text = "Codul";
            // 
            // cmsRAM
            // 
            this.cmsRAM.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsRAM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiModificaRAM,
            this.tsmiStergeRAM});
            this.cmsRAM.Name = "contextMenuStrip1";
            this.cmsRAM.Size = new System.Drawing.Size(174, 52);
            // 
            // tsmiModificaRAM
            // 
            this.tsmiModificaRAM.Name = "tsmiModificaRAM";
            this.tsmiModificaRAM.Size = new System.Drawing.Size(173, 24);
            this.tsmiModificaRAM.Text = "Modifica RAM";
            this.tsmiModificaRAM.Click += new System.EventHandler(this.tsmiModificaRAM_Click);
            // 
            // tsmiStergeRAM
            // 
            this.tsmiStergeRAM.Name = "tsmiStergeRAM";
            this.tsmiStergeRAM.Size = new System.Drawing.Size(173, 24);
            this.tsmiStergeRAM.Text = "Sterge RAM";
            this.tsmiStergeRAM.Click += new System.EventHandler(this.tsmiStergeRAM_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(1079, 580);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 50);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Sterge RAM";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModify.Enabled = false;
            this.btnModify.Location = new System.Drawing.Point(951, 580);
            this.btnModify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(123, 50);
            this.btnModify.TabIndex = 5;
            this.btnModify.Text = "Modifica RAM";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(1207, 580);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 50);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Salveaza";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // epGeneral
            // 
            this.epGeneral.ContainerControl = this;
            // 
            // tsRAM
            // 
            this.tsRAM.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsRAM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripSeparator2});
            this.tsRAM.Location = new System.Drawing.Point(0, 0);
            this.tsRAM.Name = "tsRAM";
            this.tsRAM.Size = new System.Drawing.Size(1332, 27);
            this.tsRAM.TabIndex = 8;
            this.tsRAM.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // RandomAccessMemoryAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tsRAM);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.gbRAM);
            this.Controls.Add(this.lvRandomAccessMemory);
            this.Controls.Add(this.btnReloadData);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RandomAccessMemoryAdministration";
            this.Size = new System.Drawing.Size(1332, 633);
            this.gbRAM.ResumeLayout(false);
            this.gbRAM.PerformLayout();
            this.cmsRAM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epGeneral)).EndInit();
            this.tsRAM.ResumeLayout(false);
            this.tsRAM.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReloadData;
        private System.Windows.Forms.ListView lvRandomAccessMemory;
        private System.Windows.Forms.ColumnHeader lcCapacity;
        private System.Windows.Forms.ColumnHeader lcFrequency;
        private System.Windows.Forms.ColumnHeader lcLatency;
        private System.Windows.Forms.ColumnHeader lcVoltage;
        private System.Windows.Forms.ColumnHeader lcTiming;
        private System.Windows.Forms.GroupBox gbRAM;
        private System.Windows.Forms.TextBox tbComponentCode;
        private System.Windows.Forms.Label lbComponentCode;
        private System.Windows.Forms.ContextMenuStrip cmsRAM;
        private System.Windows.Forms.TextBox tbSeries;
        private System.Windows.Forms.TextBox tbFrequency;
        private System.Windows.Forms.Label lbFrequency;
        private System.Windows.Forms.TextBox tbTiming;
        private System.Windows.Forms.Label lbTiming;
        private System.Windows.Forms.TextBox tbVoltage;
        private System.Windows.Forms.Label lbVoltage;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.ColumnHeader lcComponentCode;
        private System.Windows.Forms.ColumnHeader lcComponentName;
        private System.Windows.Forms.ColumnHeader lcManufacturer;
        private System.Windows.Forms.ColumnHeader lcSeries;
        private System.Windows.Forms.Label lbSeries;
        private System.Windows.Forms.TextBox tbManufacturer;
        private System.Windows.Forms.Label lbManufacturer;
        private System.Windows.Forms.TextBox tbComponentName;
        private System.Windows.Forms.Label lbComponentName;
        private System.Windows.Forms.TextBox tbCapacity;
        private System.Windows.Forms.Label lbCapacity;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.TextBox tbLatency;
        private System.Windows.Forms.Label lbLatency;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cboCompatibility;
        private System.Windows.Forms.Label lblMemoryType;
        private System.Windows.Forms.ErrorProvider epGeneral;
        private System.Windows.Forms.ColumnHeader lcCompatibility;
        private System.Windows.Forms.ToolStripMenuItem tsmiModificaRAM;
        private System.Windows.Forms.ToolStripMenuItem tsmiStergeRAM;
        private System.Windows.Forms.ToolStrip tsRAM;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
    }
}

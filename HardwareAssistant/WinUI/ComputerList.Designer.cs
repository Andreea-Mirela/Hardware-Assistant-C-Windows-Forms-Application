namespace HardwareAssistant.WinUI
{
    partial class ComputerList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComputerList));
            this.lvProcessor = new System.Windows.Forms.ListView();
            this.lcComputerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ComputerCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lcPlatform = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lcSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lcWeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SsComputer = new System.Windows.Forms.StatusStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ExportaInFisierText = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDrag = new System.Windows.Forms.Button();
            this.btnClipboardComputer = new System.Windows.Forms.Button();
            this.btnUserControl = new System.Windows.Forms.Button();
            this.SsComputer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvProcessor
            // 
            this.lvProcessor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvProcessor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lcComputerName,
            this.ComputerCode,
            this.lcPlatform,
            this.lcSize,
            this.lcWeight});
            this.lvProcessor.FullRowSelect = true;
            this.lvProcessor.HideSelection = false;
            this.lvProcessor.Location = new System.Drawing.Point(31, 25);
            this.lvProcessor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvProcessor.MultiSelect = false;
            this.lvProcessor.Name = "lvProcessor";
            this.lvProcessor.Size = new System.Drawing.Size(1014, 265);
            this.lvProcessor.TabIndex = 11;
            this.lvProcessor.UseCompatibleStateImageBehavior = false;
            this.lvProcessor.View = System.Windows.Forms.View.Details;
            // 
            // lcComputerName
            // 
            this.lcComputerName.Text = "Denumire";
            this.lcComputerName.Width = 317;
            // 
            // ComputerCode
            // 
            this.ComputerCode.DisplayIndex = 4;
            this.ComputerCode.Text = "Codul ";
            // 
            // lcPlatform
            // 
            this.lcPlatform.DisplayIndex = 1;
            this.lcPlatform.Text = "Platforma";
            this.lcPlatform.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lcPlatform.Width = 315;
            // 
            // lcSize
            // 
            this.lcSize.DisplayIndex = 2;
            this.lcSize.Text = "Dimensiune";
            // 
            // lcWeight
            // 
            this.lcWeight.DisplayIndex = 3;
            this.lcWeight.Text = "Greutate";
            // 
            // SsComputer
            // 
            this.SsComputer.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.SsComputer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.SsComputer.Location = new System.Drawing.Point(0, 491);
            this.SsComputer.Name = "SsComputer";
            this.SsComputer.Size = new System.Drawing.Size(1080, 26);
            this.SsComputer.TabIndex = 12;
            this.SsComputer.Text = "statusStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExportaInFisierText});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 24);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // ExportaInFisierText
            // 
            this.ExportaInFisierText.Name = "ExportaInFisierText";
            this.ExportaInFisierText.Size = new System.Drawing.Size(216, 26);
            this.ExportaInFisierText.Text = "Exporta in fisier text";
            this.ExportaInFisierText.Click += new System.EventHandler(this.ExportaInFisierText_Click);
            // 
            // btnDrag
            // 
            this.btnDrag.Location = new System.Drawing.Point(285, 423);
            this.btnDrag.Name = "btnDrag";
            this.btnDrag.Size = new System.Drawing.Size(115, 64);
            this.btnDrag.TabIndex = 16;
            this.btnDrag.Text = "DragDrop";
            this.btnDrag.UseVisualStyleBackColor = true;
            this.btnDrag.Click += new System.EventHandler(this.btnDrag_Click);
            // 
            // btnClipboardComputer
            // 
            this.btnClipboardComputer.Location = new System.Drawing.Point(167, 423);
            this.btnClipboardComputer.Name = "btnClipboardComputer";
            this.btnClipboardComputer.Size = new System.Drawing.Size(112, 64);
            this.btnClipboardComputer.TabIndex = 17;
            this.btnClipboardComputer.Text = "Clipboard";
            this.btnClipboardComputer.UseVisualStyleBackColor = true;
            this.btnClipboardComputer.Click += new System.EventHandler(this.btnClipboardComputer_Click);
            // 
            // btnUserControl
            // 
            this.btnUserControl.Location = new System.Drawing.Point(31, 423);
            this.btnUserControl.Name = "btnUserControl";
            this.btnUserControl.Size = new System.Drawing.Size(130, 64);
            this.btnUserControl.TabIndex = 18;
            this.btnUserControl.Text = "Grafic+\r\nUserControl";
            this.btnUserControl.UseVisualStyleBackColor = true;
            this.btnUserControl.Click += new System.EventHandler(this.btnUserControl_Click);
            // 
            // ComputerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUserControl);
            this.Controls.Add(this.btnClipboardComputer);
            this.Controls.Add(this.btnDrag);
            this.Controls.Add(this.SsComputer);
            this.Controls.Add(this.lvProcessor);
            this.Name = "ComputerList";
            this.Size = new System.Drawing.Size(1080, 517);
            this.SsComputer.ResumeLayout(false);
            this.SsComputer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvProcessor;
        private System.Windows.Forms.ColumnHeader lcComputerName;
        private System.Windows.Forms.ColumnHeader lcPlatform;
        private System.Windows.Forms.ColumnHeader lcSize;
        private System.Windows.Forms.ColumnHeader lcWeight;
        private System.Windows.Forms.ColumnHeader ComputerCode;
        private System.Windows.Forms.StatusStrip SsComputer;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem ExportaInFisierText;
        private System.Windows.Forms.Button btnDrag;
        private System.Windows.Forms.Button btnClipboardComputer;
        private System.Windows.Forms.Button btnUserControl;
    }
}

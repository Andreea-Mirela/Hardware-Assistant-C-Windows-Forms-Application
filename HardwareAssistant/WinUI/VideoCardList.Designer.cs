namespace HardwareAssistant.WinUI
{
    partial class VideoCardList
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
            this.lvProcessor = new System.Windows.Forms.ListView();
            this.lcComponentCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lcComponentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lcManufacturer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lcSeries = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lcChipsetManufacturer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lcGraphicProcessor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lcClock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lcMemoryType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lcTechnology = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lcMemorySize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lcMemoryBus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lcMemoryFrequency = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvProcessor
            // 
            this.lvProcessor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvProcessor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lcComponentCode,
            this.lcComponentName,
            this.lcManufacturer,
            this.lcSeries,
            this.lcChipsetManufacturer,
            this.lcTechnology,
            this.lcGraphicProcessor,
            this.lcClock,
            this.lcMemoryType,
            this.lcMemorySize,
            this.lcMemoryBus,
            this.lcMemoryFrequency});
            this.lvProcessor.FullRowSelect = true;
            this.lvProcessor.HideSelection = false;
            this.lvProcessor.Location = new System.Drawing.Point(3, 2);
            this.lvProcessor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvProcessor.MultiSelect = false;
            this.lvProcessor.Name = "lvProcessor";
            this.lvProcessor.Size = new System.Drawing.Size(933, 392);
            this.lvProcessor.TabIndex = 11;
            this.lvProcessor.UseCompatibleStateImageBehavior = false;
            this.lvProcessor.View = System.Windows.Forms.View.Details;
            // 
            // lcComponentCode
            // 
            this.lcComponentCode.Text = "Codul";
            this.lcComponentCode.Width = 317;
            // 
            // lcComponentName
            // 
            this.lcComponentName.Text = "Denumire";
            this.lcComponentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lcComponentName.Width = 315;
            // 
            // lcManufacturer
            // 
            this.lcManufacturer.DisplayIndex = 8;
            this.lcManufacturer.Text = "Producator";
            // 
            // lcSeries
            // 
            this.lcSeries.DisplayIndex = 9;
            this.lcSeries.Text = "Seria";
            // 
            // lcChipsetManufacturer
            // 
            this.lcChipsetManufacturer.DisplayIndex = 10;
            this.lcChipsetManufacturer.Text = "Producator chipset";
            // 
            // lcGraphicProcessor
            // 
            this.lcGraphicProcessor.DisplayIndex = 2;
            this.lcGraphicProcessor.Text = "Procesor grafic";
            this.lcGraphicProcessor.Width = 100;
            // 
            // lcClock
            // 
            this.lcClock.DisplayIndex = 5;
            this.lcClock.Text = "Clock";
            this.lcClock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lcClock.Width = 100;
            // 
            // lcMemoryType
            // 
            this.lcMemoryType.DisplayIndex = 3;
            this.lcMemoryType.Text = "Tip memorie";
            this.lcMemoryType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lcMemoryType.Width = 96;
            // 
            // lcTechnology
            // 
            this.lcTechnology.DisplayIndex = 4;
            this.lcTechnology.Text = "Tehnologie ";
            this.lcTechnology.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lcTechnology.Width = 108;
            // 
            // lcMemorySize
            // 
            this.lcMemorySize.DisplayIndex = 6;
            this.lcMemorySize.Text = "Dimensiune memorie";
            this.lcMemorySize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lcMemorySize.Width = 91;
            // 
            // lcMemoryBus
            // 
            this.lcMemoryBus.DisplayIndex = 7;
            this.lcMemoryBus.Text = "BUS memorie";
            this.lcMemoryBus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lcMemoryBus.Width = 166;
            // 
            // lcMemoryFrequency
            // 
            this.lcMemoryFrequency.Text = "Frecventa memorie efectiva";
            // 
            // VideoCardList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvProcessor);
            this.Name = "VideoCardList";
            this.Size = new System.Drawing.Size(1020, 422);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvProcessor;
        private System.Windows.Forms.ColumnHeader lcComponentCode;
        private System.Windows.Forms.ColumnHeader lcComponentName;
        private System.Windows.Forms.ColumnHeader lcManufacturer;
        private System.Windows.Forms.ColumnHeader lcSeries;
        private System.Windows.Forms.ColumnHeader lcChipsetManufacturer;
        private System.Windows.Forms.ColumnHeader lcGraphicProcessor;
        private System.Windows.Forms.ColumnHeader lcClock;
        private System.Windows.Forms.ColumnHeader lcMemoryType;
        private System.Windows.Forms.ColumnHeader lcTechnology;
        private System.Windows.Forms.ColumnHeader lcMemorySize;
        private System.Windows.Forms.ColumnHeader lcMemoryBus;
        private System.Windows.Forms.ColumnHeader lcMemoryFrequency;
    }
}

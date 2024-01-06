namespace HardwareAssistant.WinUI
{
    partial class ProcessorList
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
            this.lcCoreName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lcCoresNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lcThreadsNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lcFrequency = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lcTurboFrequency = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lcTechnology = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lcTotalDissipatedPower = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lcIntegratedGraphicsCard = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.lcCoreName,
            this.lcCoresNumber,
            this.lcThreadsNumber,
            this.lcFrequency,
            this.lcTurboFrequency,
            this.lcTechnology,
            this.lcTotalDissipatedPower,
            this.lcIntegratedGraphicsCard});
            this.lvProcessor.FullRowSelect = true;
            this.lvProcessor.HideSelection = false;
            this.lvProcessor.Location = new System.Drawing.Point(31, 57);
            this.lvProcessor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvProcessor.MultiSelect = false;
            this.lvProcessor.Name = "lvProcessor";
            this.lvProcessor.Size = new System.Drawing.Size(1070, 396);
            this.lvProcessor.TabIndex = 10;
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
            this.lcManufacturer.DisplayIndex = 9;
            this.lcManufacturer.Text = "Producator";
            // 
            // lcSeries
            // 
            this.lcSeries.DisplayIndex = 10;
            this.lcSeries.Text = "Seria";
            // 
            // lcCoreName
            // 
            this.lcCoreName.DisplayIndex = 11;
            this.lcCoreName.Text = "Nucleu";
            // 
            // lcCoresNumber
            // 
            this.lcCoresNumber.DisplayIndex = 2;
            this.lcCoresNumber.Text = "Numar nuclee";
            this.lcCoresNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lcCoresNumber.Width = 125;
            // 
            // lcThreadsNumber
            // 
            this.lcThreadsNumber.DisplayIndex = 3;
            this.lcThreadsNumber.Text = "Numar threaduri";
            this.lcThreadsNumber.Width = 100;
            // 
            // lcFrequency
            // 
            this.lcFrequency.DisplayIndex = 6;
            this.lcFrequency.Text = "Frecventa";
            this.lcFrequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lcFrequency.Width = 100;
            // 
            // lcTurboFrequency
            // 
            this.lcTurboFrequency.DisplayIndex = 4;
            this.lcTurboFrequency.Text = "Frecventa turbo";
            this.lcTurboFrequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lcTurboFrequency.Width = 96;
            // 
            // lcTechnology
            // 
            this.lcTechnology.DisplayIndex = 5;
            this.lcTechnology.Text = "Tehnologie de fabricatie";
            this.lcTechnology.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lcTechnology.Width = 108;
            // 
            // lcTotalDissipatedPower
            // 
            this.lcTotalDissipatedPower.DisplayIndex = 7;
            this.lcTotalDissipatedPower.Text = "Putere totala disipata";
            this.lcTotalDissipatedPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lcTotalDissipatedPower.Width = 91;
            // 
            // lcIntegratedGraphicsCard
            // 
            this.lcIntegratedGraphicsCard.DisplayIndex = 8;
            this.lcIntegratedGraphicsCard.Text = "Placa video integrata";
            this.lcIntegratedGraphicsCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lcIntegratedGraphicsCard.Width = 166;
            // 
            // ProcessorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvProcessor);
            this.Name = "ProcessorList";
            this.Size = new System.Drawing.Size(1142, 522);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvProcessor;
        private System.Windows.Forms.ColumnHeader lcComponentName;
        private System.Windows.Forms.ColumnHeader lcComponentCode;
        private System.Windows.Forms.ColumnHeader lcCoresNumber;
        private System.Windows.Forms.ColumnHeader lcThreadsNumber;
        private System.Windows.Forms.ColumnHeader lcFrequency;
        private System.Windows.Forms.ColumnHeader lcTurboFrequency;
        private System.Windows.Forms.ColumnHeader lcTechnology;
        private System.Windows.Forms.ColumnHeader lcTotalDissipatedPower;
        private System.Windows.Forms.ColumnHeader lcIntegratedGraphicsCard;
        private System.Windows.Forms.ColumnHeader lcManufacturer;
        private System.Windows.Forms.ColumnHeader lcSeries;
        private System.Windows.Forms.ColumnHeader lcCoreName;
    }
}

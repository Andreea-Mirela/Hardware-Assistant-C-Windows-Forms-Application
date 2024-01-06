namespace HardwareAssistant.WinUI
{
    partial class HardDiskList
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
            this.lcInterface = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lcCapacity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lcBuffer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lcSpeed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lcFormFactor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.lcInterface,
            this.lcCapacity,
            this.lcBuffer,
            this.lcSpeed,
            this.lcFormFactor});
            this.lvProcessor.FullRowSelect = true;
            this.lvProcessor.HideSelection = false;
            this.lvProcessor.Location = new System.Drawing.Point(21, 41);
            this.lvProcessor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvProcessor.MultiSelect = false;
            this.lvProcessor.Name = "lvProcessor";
            this.lvProcessor.Size = new System.Drawing.Size(941, 387);
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
            this.lcManufacturer.DisplayIndex = 6;
            this.lcManufacturer.Text = "Producator";
            // 
            // lcSeries
            // 
            this.lcSeries.DisplayIndex = 7;
            this.lcSeries.Text = "Seria";
            // 
            // lcInterface
            // 
            this.lcInterface.DisplayIndex = 8;
            this.lcInterface.Text = "Interfata";
            // 
            // lcCapacity
            // 
            this.lcCapacity.DisplayIndex = 2;
            this.lcCapacity.Text = "Capacitate";
            this.lcCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lcCapacity.Width = 125;
            // 
            // lcBuffer
            // 
            this.lcBuffer.DisplayIndex = 3;
            this.lcBuffer.Text = "Buffer";
            this.lcBuffer.Width = 100;
            // 
            // lcSpeed
            // 
            this.lcSpeed.DisplayIndex = 5;
            this.lcSpeed.Text = "Viteza";
            this.lcSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lcSpeed.Width = 100;
            // 
            // lcFormFactor
            // 
            this.lcFormFactor.DisplayIndex = 4;
            this.lcFormFactor.Text = "Form factor";
            this.lcFormFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lcFormFactor.Width = 96;
            // 
            // HardDiskList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvProcessor);
            this.Name = "HardDiskList";
            this.Size = new System.Drawing.Size(982, 493);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvProcessor;
        private System.Windows.Forms.ColumnHeader lcComponentCode;
        private System.Windows.Forms.ColumnHeader lcComponentName;
        private System.Windows.Forms.ColumnHeader lcManufacturer;
        private System.Windows.Forms.ColumnHeader lcSeries;
        private System.Windows.Forms.ColumnHeader lcInterface;
        private System.Windows.Forms.ColumnHeader lcCapacity;
        private System.Windows.Forms.ColumnHeader lcBuffer;
        private System.Windows.Forms.ColumnHeader lcSpeed;
        private System.Windows.Forms.ColumnHeader lcFormFactor;
    }
}

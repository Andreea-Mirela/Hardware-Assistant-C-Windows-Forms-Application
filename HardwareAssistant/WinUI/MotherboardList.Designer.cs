namespace HardwareAssistant.WinUI
{
    partial class MotherboardList
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
            this.lcChipsetModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lcSupportedProcessors = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvRAID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lcAudioCard = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lcAudioChipset = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lcNetworkCard = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lcNetworkChipset = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lcStoragePortsNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.lcChipsetModel,
            this.lcSupportedProcessors,
            this.lvRAID,
            this.lcAudioCard,
            this.lcAudioChipset,
            this.lcNetworkCard,
            this.lcNetworkChipset,
            this.lcStoragePortsNumber});
            this.lvProcessor.FullRowSelect = true;
            this.lvProcessor.HideSelection = false;
            this.lvProcessor.Location = new System.Drawing.Point(34, 38);
            this.lvProcessor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvProcessor.MultiSelect = false;
            this.lvProcessor.Name = "lvProcessor";
            this.lvProcessor.Size = new System.Drawing.Size(966, 432);
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
            this.lcManufacturer.DisplayIndex = 3;
            this.lcManufacturer.Text = "Producator";
            // 
            // lcSeries
            // 
            this.lcSeries.DisplayIndex = 4;
            this.lcSeries.Text = "Seria";
            // 
            // lcChipsetManufacturer
            // 
            this.lcChipsetManufacturer.DisplayIndex = 5;
            this.lcChipsetManufacturer.Text = "Producator chipset";
            // 
            // lcChipsetModel
            // 
            this.lcChipsetModel.DisplayIndex = 2;
            this.lcChipsetModel.Text = "Model chipset";
            this.lcChipsetModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lcChipsetModel.Width = 125;
            // 
            // lcSupportedProcessors
            // 
            this.lcSupportedProcessors.Text = "Procesoare suportate";
            // 
            // lvRAID
            // 
            this.lvRAID.Text = "RAID";
            // 
            // lcAudioCard
            // 
            this.lcAudioCard.Text = "Placa de sunet";
            // 
            // lcAudioChipset
            // 
            this.lcAudioChipset.Text = "Chipset audio";
            // 
            // lcNetworkCard
            // 
            this.lcNetworkCard.Text = "Placa retea";
            // 
            // lcNetworkChipset
            // 
            this.lcNetworkChipset.Text = "Chipset retea";
            // 
            // lcStoragePortsNumber
            // 
            this.lcStoragePortsNumber.Text = "Numar sloturi";
            // 
            // MotherboardList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvProcessor);
            this.Name = "MotherboardList";
            this.Size = new System.Drawing.Size(1055, 489);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvProcessor;
        private System.Windows.Forms.ColumnHeader lcComponentCode;
        private System.Windows.Forms.ColumnHeader lcComponentName;
        private System.Windows.Forms.ColumnHeader lcManufacturer;
        private System.Windows.Forms.ColumnHeader lcSeries;
        private System.Windows.Forms.ColumnHeader lcChipsetManufacturer;
        private System.Windows.Forms.ColumnHeader lcChipsetModel;
        private System.Windows.Forms.ColumnHeader lcSupportedProcessors;
        private System.Windows.Forms.ColumnHeader lvRAID;
        private System.Windows.Forms.ColumnHeader lcAudioCard;
        private System.Windows.Forms.ColumnHeader lcAudioChipset;
        private System.Windows.Forms.ColumnHeader lcNetworkCard;
        private System.Windows.Forms.ColumnHeader lcNetworkChipset;
        private System.Windows.Forms.ColumnHeader lcStoragePortsNumber;
    }
}

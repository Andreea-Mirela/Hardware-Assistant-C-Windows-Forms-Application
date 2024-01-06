namespace HardwareAssistant
{
    partial class HardwareAssistant
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
            this.components = new System.ComponentModel.Container();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.tsmiApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiApplicationConfiguration = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiApplicationExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAdministration = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiComponentsAdministration = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProcessors = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRandomAccessMemories = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStorageMemories = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHardDisks = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSolidStateDrives = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVideoCards = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMotherboards = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiComputesAdministration = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConsulting = new System.Windows.Forms.ToolStripMenuItem();
            this.componenteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlGeneral = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiApplication,
            this.tsmiAdministration,
            this.tsmiConsulting});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStripMain.Size = new System.Drawing.Size(1287, 28);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // tsmiApplication
            // 
            this.tsmiApplication.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiApplicationConfiguration,
            this.tsmiApplicationExit});
            this.tsmiApplication.Name = "tsmiApplication";
            this.tsmiApplication.Size = new System.Drawing.Size(80, 24);
            this.tsmiApplication.Text = "Aplicatie";
            // 
            // tsmiApplicationConfiguration
            // 
            this.tsmiApplicationConfiguration.Name = "tsmiApplicationConfiguration";
            this.tsmiApplicationConfiguration.Size = new System.Drawing.Size(131, 26);
            this.tsmiApplicationConfiguration.Text = "Despre";
            this.tsmiApplicationConfiguration.Click += new System.EventHandler(this.tsmiApplicationConfiguration_Click);
            // 
            // tsmiApplicationExit
            // 
            this.tsmiApplicationExit.Name = "tsmiApplicationExit";
            this.tsmiApplicationExit.Size = new System.Drawing.Size(131, 26);
            this.tsmiApplicationExit.Text = "Exit";
            this.tsmiApplicationExit.Click += new System.EventHandler(this.tsmiApplicationExit_Click);
            // 
            // tsmiAdministration
            // 
            this.tsmiAdministration.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiComponentsAdministration,
            this.tsmiComputesAdministration});
            this.tsmiAdministration.Name = "tsmiAdministration";
            this.tsmiAdministration.Size = new System.Drawing.Size(106, 24);
            this.tsmiAdministration.Text = "Administrare";
            // 
            // tsmiComponentsAdministration
            // 
            this.tsmiComponentsAdministration.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiProcessors,
            this.tsmiRandomAccessMemories,
            this.tsmiStorageMemories,
            this.tsmiVideoCards,
            this.tsmiMotherboards});
            this.tsmiComponentsAdministration.Name = "tsmiComponentsAdministration";
            this.tsmiComponentsAdministration.Size = new System.Drawing.Size(170, 26);
            this.tsmiComponentsAdministration.Text = "Componente";
            // 
            // tsmiProcessors
            // 
            this.tsmiProcessors.Name = "tsmiProcessors";
            this.tsmiProcessors.Size = new System.Drawing.Size(192, 26);
            this.tsmiProcessors.Text = "Procesoare";
            this.tsmiProcessors.Click += new System.EventHandler(this.tsmiProcessors_Click);
            // 
            // tsmiRandomAccessMemories
            // 
            this.tsmiRandomAccessMemories.Name = "tsmiRandomAccessMemories";
            this.tsmiRandomAccessMemories.Size = new System.Drawing.Size(192, 26);
            this.tsmiRandomAccessMemories.Text = "Memorii RAM";
            this.tsmiRandomAccessMemories.Click += new System.EventHandler(this.tsmiRandomAccessMemories_Click);
            // 
            // tsmiStorageMemories
            // 
            this.tsmiStorageMemories.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHardDisks,
            this.tsmiSolidStateDrives});
            this.tsmiStorageMemories.Name = "tsmiStorageMemories";
            this.tsmiStorageMemories.Size = new System.Drawing.Size(192, 26);
            this.tsmiStorageMemories.Text = "Memorii stocare";
            // 
            // tsmiHardDisks
            // 
            this.tsmiHardDisks.Name = "tsmiHardDisks";
            this.tsmiHardDisks.Size = new System.Drawing.Size(236, 26);
            this.tsmiHardDisks.Text = "Hard Disk (HDD)";
            this.tsmiHardDisks.Click += new System.EventHandler(this.tsmiHardDisks_Click);
            // 
            // tsmiSolidStateDrives
            // 
            this.tsmiSolidStateDrives.Name = "tsmiSolidStateDrives";
            this.tsmiSolidStateDrives.Size = new System.Drawing.Size(236, 26);
            this.tsmiSolidStateDrives.Text = "Solid State Drive (SSD)";
            this.tsmiSolidStateDrives.Click += new System.EventHandler(this.tsmiSolidStateDrives_Click);
            // 
            // tsmiVideoCards
            // 
            this.tsmiVideoCards.Name = "tsmiVideoCards";
            this.tsmiVideoCards.Size = new System.Drawing.Size(192, 26);
            this.tsmiVideoCards.Text = "Placi video";
            this.tsmiVideoCards.Click += new System.EventHandler(this.tsmiVideoCards_Click);
            // 
            // tsmiMotherboards
            // 
            this.tsmiMotherboards.Name = "tsmiMotherboards";
            this.tsmiMotherboards.Size = new System.Drawing.Size(192, 26);
            this.tsmiMotherboards.Text = "Placi de baza";
            this.tsmiMotherboards.Click += new System.EventHandler(this.tsmiMotherboards_Click);
            // 
            // tsmiComputesAdministration
            // 
            this.tsmiComputesAdministration.Name = "tsmiComputesAdministration";
            this.tsmiComputesAdministration.Size = new System.Drawing.Size(170, 26);
            this.tsmiComputesAdministration.Text = "Calculatoare";
            this.tsmiComputesAdministration.Click += new System.EventHandler(this.tsmiComputesAdministration_Click);
            // 
            // tsmiConsulting
            // 
            this.tsmiConsulting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.componenteToolStripMenuItem1});
            this.tsmiConsulting.Name = "tsmiConsulting";
            this.tsmiConsulting.Size = new System.Drawing.Size(99, 24);
            this.tsmiConsulting.Text = "Consultanta";
            // 
            // componenteToolStripMenuItem1
            // 
            this.componenteToolStripMenuItem1.Name = "componenteToolStripMenuItem1";
            this.componenteToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.componenteToolStripMenuItem1.Text = "Componente";
            this.componenteToolStripMenuItem1.Click += new System.EventHandler(this.componenteToolStripMenuItem1_Click);
            // 
            // pnlGeneral
            // 
            this.pnlGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGeneral.Location = new System.Drawing.Point(0, 28);
            this.pnlGeneral.Margin = new System.Windows.Forms.Padding(4);
            this.pnlGeneral.Name = "pnlGeneral";
            this.pnlGeneral.Size = new System.Drawing.Size(1287, 637);
            this.pnlGeneral.TabIndex = 2;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // HardwareAssistant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 665);
            this.Controls.Add(this.pnlGeneral);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HardwareAssistant";
            this.Text = "Hardware assistant";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdministration;
        private System.Windows.Forms.ToolStripMenuItem tsmiComponentsAdministration;
        private System.Windows.Forms.ToolStripMenuItem tsmiProcessors;
        private System.Windows.Forms.ToolStripMenuItem tsmiRandomAccessMemories;
        private System.Windows.Forms.ToolStripMenuItem tsmiStorageMemories;
        private System.Windows.Forms.ToolStripMenuItem tsmiHardDisks;
        private System.Windows.Forms.ToolStripMenuItem tsmiSolidStateDrives;
        private System.Windows.Forms.ToolStripMenuItem tsmiVideoCards;
        private System.Windows.Forms.ToolStripMenuItem tsmiMotherboards;
        private System.Windows.Forms.ToolStripMenuItem tsmiComputesAdministration;
        private System.Windows.Forms.ToolStripMenuItem tsmiConsulting;
        private System.Windows.Forms.ToolStripMenuItem componenteToolStripMenuItem1;
        private System.Windows.Forms.Panel pnlGeneral;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripMenuItem tsmiApplication;
        private System.Windows.Forms.ToolStripMenuItem tsmiApplicationConfiguration;
        private System.Windows.Forms.ToolStripMenuItem tsmiApplicationExit;
    }
}


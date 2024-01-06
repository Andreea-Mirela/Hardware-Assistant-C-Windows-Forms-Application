namespace HardwareAssistant.WinUI
{
    partial class AboutApplicationControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutApplicationControl));
            this.lblAboutApplication = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAboutApplication
            // 
            this.lblAboutApplication.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAboutApplication.AutoSize = true;
            this.lblAboutApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAboutApplication.Location = new System.Drawing.Point(28, 15);
            this.lblAboutApplication.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAboutApplication.Name = "lblAboutApplication";
            this.lblAboutApplication.Size = new System.Drawing.Size(545, 180);
            this.lblAboutApplication.TabIndex = 1;
            this.lblAboutApplication.Text = resources.GetString("lblAboutApplication.Text");
            // 
            // AboutApplicationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblAboutApplication);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AboutApplicationControl";
            this.Size = new System.Drawing.Size(791, 385);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAboutApplication;
    }
}

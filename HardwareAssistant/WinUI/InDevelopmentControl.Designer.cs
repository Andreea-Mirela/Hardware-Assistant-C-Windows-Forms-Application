namespace HardwareAssistant.WinUI
{
    partial class InDevelopmentControl
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
            this.lblInDevelopmentMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInDevelopmentMessage
            // 
            this.lblInDevelopmentMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInDevelopmentMessage.AutoSize = true;
            this.lblInDevelopmentMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInDevelopmentMessage.Location = new System.Drawing.Point(97, 90);
            this.lblInDevelopmentMessage.Name = "lblInDevelopmentMessage";
            this.lblInDevelopmentMessage.Size = new System.Drawing.Size(177, 25);
            this.lblInDevelopmentMessage.TabIndex = 0;
            this.lblInDevelopmentMessage.Text = "In development...";
            // 
            // InDevelopmentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblInDevelopmentMessage);
            this.Name = "InDevelopmentControl";
            this.Size = new System.Drawing.Size(378, 217);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInDevelopmentMessage;
    }
}

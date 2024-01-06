namespace HardwareAssistant.WinUI
{
    partial class ClipboardComputer
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
            this.sursa = new System.Windows.Forms.PictureBox();
            this.destinatie = new System.Windows.Forms.PictureBox();
            this.btnSwitch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sursa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinatie)).BeginInit();
            this.SuspendLayout();
            // 
            // sursa
            // 
            this.sursa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sursa.Location = new System.Drawing.Point(38, 83);
            this.sursa.Name = "sursa";
            this.sursa.Size = new System.Drawing.Size(279, 278);
            this.sursa.TabIndex = 0;
            this.sursa.TabStop = false;
            // 
            // destinatie
            // 
            this.destinatie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.destinatie.Location = new System.Drawing.Point(424, 83);
            this.destinatie.Name = "destinatie";
            this.destinatie.Size = new System.Drawing.Size(279, 278);
            this.destinatie.TabIndex = 1;
            this.destinatie.TabStop = false;
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(323, 176);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(95, 57);
            this.btnSwitch.TabIndex = 2;
            this.btnSwitch.Text = "Schimba";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // ClipboardComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.destinatie);
            this.Controls.Add(this.sursa);
            this.Name = "ClipboardComputer";
            this.Text = "ClipboardComputer";
            ((System.ComponentModel.ISupportInitialize)(this.sursa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinatie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox sursa;
        private System.Windows.Forms.PictureBox destinatie;
        private System.Windows.Forms.Button btnSwitch;
    }
}
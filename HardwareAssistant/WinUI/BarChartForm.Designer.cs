namespace HardwareAssistant.WinUI
{
    partial class BarChartForm
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
            this.lbTop = new System.Windows.Forms.Label();
            this.barChart1 = new BarChartLibrary.BarChart();
            this.SuspendLayout();
            // 
            // lbTop
            // 
            this.lbTop.AutoSize = true;
            this.lbTop.Location = new System.Drawing.Point(131, 9);
            this.lbTop.Name = "lbTop";
            this.lbTop.Size = new System.Drawing.Size(241, 17);
            this.lbTop.TabIndex = 1;
            this.lbTop.Text = "Topul producătorilor de calculatoare:";
            // 
            // barChart1
            // 
            this.barChart1.Location = new System.Drawing.Point(134, 54);
            this.barChart1.Name = "barChart1";
            this.barChart1.Size = new System.Drawing.Size(544, 327);
            this.barChart1.TabIndex = 0;
            // 
            // BarChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 450);
            this.Controls.Add(this.lbTop);
            this.Controls.Add(this.barChart1);
            this.Name = "BarChartForm";
            this.Text = "BarChartForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BarChartLibrary.BarChart barChart1;
        private System.Windows.Forms.Label lbTop;
    }
}
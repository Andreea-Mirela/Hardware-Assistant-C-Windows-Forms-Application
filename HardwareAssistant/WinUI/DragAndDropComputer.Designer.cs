namespace HardwareAssistant.WinUI
{
    partial class DragAndDropComputer
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
            this.tvComputer = new System.Windows.Forms.TreeView();
            this.lbComputer = new System.Windows.Forms.Label();
            this.pnlComputer = new System.Windows.Forms.Panel();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.pnlComputer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvComputer
            // 
            this.tvComputer.Location = new System.Drawing.Point(332, 47);
            this.tvComputer.Name = "tvComputer";
            this.tvComputer.Size = new System.Drawing.Size(315, 255);
            this.tvComputer.TabIndex = 18;
            // 
            // lbComputer
            // 
            this.lbComputer.AutoSize = true;
            this.lbComputer.Location = new System.Drawing.Point(31, 107);
            this.lbComputer.Name = "lbComputer";
            this.lbComputer.Size = new System.Drawing.Size(232, 17);
            this.lbComputer.TabIndex = 17;
            this.lbComputer.Text = "Drop a file to populate the tree view";
            // 
            // pnlComputer
            // 
            this.pnlComputer.AllowDrop = true;
            this.pnlComputer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlComputer.Controls.Add(this.treeView2);
            this.pnlComputer.Location = new System.Drawing.Point(34, 127);
            this.pnlComputer.Name = "pnlComputer";
            this.pnlComputer.Size = new System.Drawing.Size(223, 133);
            this.pnlComputer.TabIndex = 16;
            this.pnlComputer.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlComputer_DragDrop);
            this.pnlComputer.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlComputer_DragEnter);
            // 
            // treeView2
            // 
            this.treeView2.Location = new System.Drawing.Point(237, 92);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(121, 97);
            this.treeView2.TabIndex = 0;
            // 
            // DragAndDropComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tvComputer);
            this.Controls.Add(this.lbComputer);
            this.Controls.Add(this.pnlComputer);
            this.Name = "DragAndDropComputer";
            this.Text = "DragAndDropComputer";
            this.pnlComputer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvComputer;
        private System.Windows.Forms.Label lbComputer;
        private System.Windows.Forms.Panel pnlComputer;
        private System.Windows.Forms.TreeView treeView2;
    }
}
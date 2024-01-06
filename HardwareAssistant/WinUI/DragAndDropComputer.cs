using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardwareAssistant.WinUI
{
    public partial class DragAndDropComputer : Form
    {
        public DragAndDropComputer()
        {
            InitializeComponent();
        }

        private void pnlComputer_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pnlComputer_DragDrop(object sender, DragEventArgs e)
        {
            string[] filePaths = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            foreach (String path in filePaths)
            {
                string[] content = File.ReadAllLines(path);

                TreeNode root = new TreeNode("Calculatoare");
                tvComputer.Nodes.Add(root);

                foreach (String line in content)
                {
                    string[] tokens = line.Split('\t');

                    TreeNode child = new TreeNode(tokens[0]);
                    root.Nodes.Add(child);
                    TreeNode _1grandchild = new TreeNode(tokens[1]);
                    TreeNode _2grandchild = new TreeNode(tokens[2]);
                    TreeNode _3grandchild = new TreeNode(tokens[3]);

                    child.Nodes.Add(_1grandchild);
                    child.Nodes.Add(_2grandchild);
                    child.Nodes.Add(_3grandchild);
                }
                tvComputer.ExpandAll();
            }
        }

        
    }
}

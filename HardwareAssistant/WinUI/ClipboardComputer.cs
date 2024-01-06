using System;
using System.Windows.Forms;

namespace HardwareAssistant.WinUI
{
    public partial class ClipboardComputer : Form
    {
        bool imaginePeSursa = true;
        public ClipboardComputer()
        {
            InitializeComponent();
            sursa.ImageLocation = "Resources\\picture1.jpg";
        }
        

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            if (imaginePeSursa)
            {
                imaginePeSursa = false;

                Clipboard.SetImage(sursa.Image);

                destinatie.Image = Clipboard.GetImage();
                sursa.Image = null;
            }
            else
            {
                imaginePeSursa = true;

                Clipboard.SetImage(destinatie.Image);

                sursa.Image = Clipboard.GetImage();
                destinatie.Image = null;
            }
        }
    }
}

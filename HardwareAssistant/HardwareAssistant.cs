using HardwareAssistant.WinUI;
using System.Windows.Forms;

namespace HardwareAssistant
{
    public partial class HardwareAssistant : Form
    {
        public HardwareAssistant()
        {
            InitializeComponent();
            DisplayAboutApplicationControl();
        }
        
        private void tsmiRandomAccessMemories_Click(object sender, System.EventArgs e)
        {
            pnlGeneral.Controls.Clear();
            RandomAccessMemoryAdministration randomAccessMemoryAdministrationControl = new RandomAccessMemoryAdministration();
            pnlGeneral.Controls.Add(randomAccessMemoryAdministrationControl);
            randomAccessMemoryAdministrationControl.Dock = DockStyle.Fill;
        }

        private void tsmiProcessors_Click(object sender, System.EventArgs e)
        {
            pnlGeneral.Controls.Clear();
            ProcessorList randomProcessorListControl = new ProcessorList();
            pnlGeneral.Controls.Add(randomProcessorListControl);
            randomProcessorListControl.Dock = DockStyle.Fill;
        }

        private void tsmiVideoCards_Click(object sender, System.EventArgs e)
        {
            pnlGeneral.Controls.Clear();
            VideoCardList randomVideoCardControl = new VideoCardList();
            pnlGeneral.Controls.Add(randomVideoCardControl);
            randomVideoCardControl.Dock = DockStyle.Fill;
        }

        // sa se afiseje controlul si pt celelalte intrari in menuiu ce sunt neimplementate
        private void DisplayInDevelopmentControl()
        {
            pnlGeneral.Controls.Clear();
            InDevelopmentControl randomAccessMemoryAdministrationControl = new InDevelopmentControl();
            pnlGeneral.Controls.Add(randomAccessMemoryAdministrationControl);
            randomAccessMemoryAdministrationControl.Dock = DockStyle.Fill;
        }

        private void tsmiApplicationExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void tsmiAbout_Click(object sender, System.EventArgs e)
        {
            DisplayAboutApplicationControl();
        }

        private void DisplayAboutApplicationControl()
        {
            pnlGeneral.Controls.Clear();
            AboutApplicationControl aboutApplicationControl = new AboutApplicationControl();
            pnlGeneral.Controls.Add(aboutApplicationControl);
            aboutApplicationControl.Dock = DockStyle.Fill;
        }

        private void tsmiApplicationConfiguration_Click(object sender, System.EventArgs e)
        {
         
            DisplayAboutApplicationControl();
        }

        private void tsmiHardDisks_Click(object sender, System.EventArgs e)
        {
            pnlGeneral.Controls.Clear();
            HardDiskList randomHardDiskControl = new HardDiskList();
            pnlGeneral.Controls.Add(randomHardDiskControl);
            randomHardDiskControl.Dock = DockStyle.Fill;
        }

        private void tsmiSolidStateDrives_Click(object sender, System.EventArgs e)
        {
            pnlGeneral.Controls.Clear();
            SolidStateDriveList randomSolidStateDriveControl = new SolidStateDriveList();
            pnlGeneral.Controls.Add(randomSolidStateDriveControl);
            randomSolidStateDriveControl.Dock = DockStyle.Fill;
        }

        private void tsmiMotherboards_Click(object sender, System.EventArgs e)
        {
            pnlGeneral.Controls.Clear();
            MotherboardList randomMotherboardListControl = new MotherboardList();
            pnlGeneral.Controls.Add(randomMotherboardListControl);
            randomMotherboardListControl.Dock = DockStyle.Fill;
        }

        private void tsmiComputesAdministration_Click(object sender, System.EventArgs e)
        {
            pnlGeneral.Controls.Clear();
            ComputerList randomComputerListListControl = new ComputerList();
            pnlGeneral.Controls.Add(randomComputerListListControl);
            randomComputerListListControl.Dock = DockStyle.Fill;
        }

        private void componenteToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            DisplayInDevelopmentControl();
        }
    }
}

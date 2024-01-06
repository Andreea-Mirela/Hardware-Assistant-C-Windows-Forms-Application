using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HardwareAssistant.Entities;
using HardwareAssistant.DataAccess;
using System.IO;

namespace HardwareAssistant.WinUI
{
    public partial class ComputerList : UserControl
    {
        #region Fields
        List<Computer> ComputerCollection = new List<Computer>();
        #endregion
        public ComputerList()
        {
            InitializeComponent();
            LoadMemoriesAndFillListView();
        }
        #region Properties
        private IDataAccess _dataAccess
        {
            get
            {//se obtine acces la date printr o instanta de clasa 
                return DataAccessManager.GetDataAccess();
            }
        }
        #endregion

        #region Methods
        private void LoadMemoriesAndFillListView()
        {
            ComputerCollection = _dataAccess.GetComputers().ToList();
            FillListView();
        }

        private void FillListView()
        {
            lvProcessor.Items.Clear();
            foreach (Computer each in ComputerCollection)
            {
                ListViewItem item = new ListViewItem(new String[] { each.ComputerCode, each.ComputerName ,
                     each.Platform ,each.Size ,each.Weight });
                lvProcessor.Items.Add(item);
            }
        }



        #endregion

        #region StatusStrip+ExportInFisierText
        private void ExportaInFisierText_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Title = "Salveaza in fisier text";
            sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd.FilterIndex = 1;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                sw.WriteLine("Cod Denumire");
                foreach (Computer each in ComputerCollection)
                {
                    sw.WriteLine(each.ComputerCode + " " + each.ComputerName);
                }
                sw.Close();
            }
        }



        #endregion

        private void btnDrag_Click(object sender, EventArgs e)
        {
            DragAndDropComputer drg = new DragAndDropComputer();
            drg.Show();
        }

        private void btnClipboardComputer_Click(object sender, EventArgs e)
        {
            ClipboardComputer drg = new ClipboardComputer();
            drg.Show();
        }

        private void btnUserControl_Click(object sender, EventArgs e)
        {
            BarChartForm form = new BarChartForm();
            form.ShowDialog();
        }
    }
}

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

namespace HardwareAssistant.WinUI
{
    public partial class HardDiskList : UserControl
    {
        #region Fields
        List<HardDisk> HardDiskCollection = new List<HardDisk>();
        #endregion
        public HardDiskList()
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
            HardDiskCollection = _dataAccess.GetHardDisks().ToList();
            FillListView();
        }

        private void FillListView()
        {
            lvProcessor.Items.Clear();
            foreach (HardDisk each in HardDiskCollection)
            {
                ListViewItem item = new ListViewItem(new String[] { each.ComponentCode, each.ComponentName,
                     each.Manufacturer,each.Series,each.Interface,each.Capacity, each.Buffer,each.Speed,each.FormFactor });
                lvProcessor.Items.Add(item);
            }
        }


        #endregion
    }
}

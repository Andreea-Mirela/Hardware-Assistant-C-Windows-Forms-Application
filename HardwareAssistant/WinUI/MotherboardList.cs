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
    public partial class MotherboardList : UserControl
    {
        #region Fields
        List<Motherboard> MotherboardCollection = new List<Motherboard>();
        #endregion
        public MotherboardList()
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
            MotherboardCollection = _dataAccess.GetMotherboards().ToList();
            FillListView();
        }

        private void FillListView()
        {
            lvProcessor.Items.Clear();
            foreach (Motherboard each in MotherboardCollection)
            {
                ListViewItem item = new ListViewItem(new String[] { each.ComponentCode, each.ComponentName,
                     each.Manufacturer,each.Series,each.ChipsetManufacturer,each.ChipsetModel,each.SupportedProcessors,each.RAID,each.AudioCard,each.AudioChipset,each.NetworkCard,each.NetworkChipset,each.StoragePortsNumber.ToString() });
                lvProcessor.Items.Add(item);
            }
        }


        #endregion
    }
}

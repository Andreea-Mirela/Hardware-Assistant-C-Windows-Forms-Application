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
    public partial class SolidStateDriveList : UserControl
    {
        #region Fields
        List<SolidStateDrive> SolidStateDriveCollection = new List<SolidStateDrive>();
        #endregion
        public SolidStateDriveList()
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
            SolidStateDriveCollection = _dataAccess.GetSolidStateDrives().ToList();
            FillListView();
        }

        private void FillListView()
        {
            lvProcessor.Items.Clear();
            foreach (SolidStateDrive each in SolidStateDriveCollection)
            {
                ListViewItem item = new ListViewItem(new String[] { each.ComponentCode, each.ComponentName,
                     each.Manufacturer,each.Series,each.Interface,each.Capacity, each.Controller,each.FormFactor,each.ReadSpeed,each.WriteSpeed });
                lvProcessor.Items.Add(item);
            }
        }


        #endregion
    }
}

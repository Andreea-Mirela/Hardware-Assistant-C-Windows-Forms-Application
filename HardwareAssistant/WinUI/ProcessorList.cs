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
using HardwareAssistant.Constants;

namespace HardwareAssistant.WinUI
{
    public partial class ProcessorList : UserControl
    {
        #region Fields
        List<Processor> ProcessorCollection = new List<Processor>();
        #endregion
        public ProcessorList()
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
            ProcessorCollection = _dataAccess.GetProcessors().ToList();
            FillListView();
        }
        
         private void FillListView()
         {
             lvProcessor.Items.Clear();
             foreach (Processor each in ProcessorCollection)
             {
                 ListViewItem item = new ListViewItem(new String[] { each.ComponentCode, each.ComponentName,
                     each.Manufacturer,each.Series,each.CoreName,each.CoresNumber.ToString(), each.ThreadsNumber.ToString(),each.Frequency,each.TurboFrequency,each.Technology,each.TotalDissipatedPower,each.IntegratedGraphicsCard });
                 lvProcessor.Items.Add(item);
             }
         }
        
        
        #endregion
    }
}

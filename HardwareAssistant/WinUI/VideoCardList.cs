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
    public partial class VideoCardList : UserControl
    {
        #region Fields
        List<VideoCard> VideoCardCollection = new List<VideoCard>();
        #endregion
        public VideoCardList()
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
            VideoCardCollection = _dataAccess.GetVideoCards().ToList();
            FillListView();
        }

        private void FillListView()
        {
            lvProcessor.Items.Clear();
            foreach (VideoCard each in VideoCardCollection)
            {
                ListViewItem item = new ListViewItem(new String[] { each.ComponentCode, each.ComponentName,
                     each.Manufacturer,each.Series,each.ChipsetManufacturer,each.Technology, each.GraphicProcessor,each.Clock ,each.MemoryType ,each.Technology,each.MemorySize, each.MemoryBus, each.MemoryFrequency });
                lvProcessor.Items.Add(item);
            }
        }


        #endregion
    }
}

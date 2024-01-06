using HardwareAssistant.Constants;
using HardwareAssistant.DataAccess;
using HardwareAssistant.Entities;
using System;
using System.Windows.Forms;

namespace HardwareAssistant.WinUI
{
    public partial class RandomAccessMemoryEditForm : Form
    {
        #region Properties
        private IDataAccess _dataAccess
        {
            get
            {
                return DataAccessManager.GetDataAccess();
            }
        }
        #endregion

        RandomAccessMemory _selectedRandomAccessMemory;
        public RandomAccessMemoryEditForm(RandomAccessMemory modifiedRAM)
        {
            InitializeComponent();
            FillCombos();
            _selectedRandomAccessMemory = modifiedRAM;
        }

        private void FillCombos()
        {
            ComponentCompatibility[] componentCompatibilities = _dataAccess.GetComponentCompatibilities(Enums.ComponentType.RAM);
            cboCompatibility.DataSource = componentCompatibilities;
            cboCompatibility.ValueMember = "ComponentCompatibilityId";
            cboCompatibility.DisplayMember = "ComponentCompatibilityName";
        }

        private void RandomAccessMemoryEditForm_Load(object sender, EventArgs e)
        {
            tbComponentCode.Text = _selectedRandomAccessMemory.ComponentCode;
            tbComponentName.Text = _selectedRandomAccessMemory.ComponentName;
            tbManufacturer.Text = _selectedRandomAccessMemory.Manufacturer;
            cboCompatibility.SelectedValue = _selectedRandomAccessMemory.CompatibilityTypeId;
            tbSeries.Text = _selectedRandomAccessMemory.Series;
            tbCapacity.Text = _selectedRandomAccessMemory.Capacity;
            tbFrequency.Text = _selectedRandomAccessMemory.Frequency;
            tbLatency.Text = _selectedRandomAccessMemory.Latency;
            tbVoltage.Text = _selectedRandomAccessMemory.Voltage;
            tbTiming.Text = _selectedRandomAccessMemory.Timing;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            _selectedRandomAccessMemory.ComponentCode = tbComponentCode.Text;
            _selectedRandomAccessMemory.ComponentName = tbComponentName.Text;
            _selectedRandomAccessMemory.Manufacturer = tbManufacturer.Text;
            _selectedRandomAccessMemory.CompatibilityTypeId = Convert.ToInt32(cboCompatibility.SelectedValue);
            _selectedRandomAccessMemory.Compatibility = (ComponentCompatibility)cboCompatibility.SelectedItem;
            _selectedRandomAccessMemory.Series = tbSeries.Text;
            _selectedRandomAccessMemory.Capacity = tbCapacity.Text;
            _selectedRandomAccessMemory.Frequency = tbFrequency.Text;
            _selectedRandomAccessMemory.Latency = tbLatency.Text;
            _selectedRandomAccessMemory.Voltage = tbVoltage.Text;
            _selectedRandomAccessMemory.Timing = tbTiming.Text;
            this.Close();
        }

       
    }
}

using HardwareAssistant.Constants;
using HardwareAssistant.DataAccess;
using HardwareAssistant.Entities;
using HardwareAssistant.Exceptions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace HardwareAssistant.WinUI
{
    public partial class RandomAccessMemoryAdministration : UserControl
    {
        #region Fields
        List<RandomAccessMemory> RAMCollection = new List<RandomAccessMemory>();
        #endregion

        #region Constructor
        public RandomAccessMemoryAdministration()
        {
            InitializeComponent();
            LoadMemoriesAndFillListView();
            FillCombos();
        }
        #endregion

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
            RAMCollection = _dataAccess.GetRandomAccessMemories().ToList();
            FillListView();
        }
        private void FillListView()
        {
            lvRandomAccessMemory.Items.Clear();
            foreach (RandomAccessMemory each in RAMCollection)
            {
                ListViewItem item = new ListViewItem(new String[] { each.ComponentCode, each.ComponentName,
                    each.Manufacturer, each.Compatibility.ComponentCompatibilityName, each.Series, each.Capacity, each.Frequency, each.Latency, each.Voltage, each.Timing });
                lvRandomAccessMemory.Items.Add(item);
            }
        }

        private void ClearFields()
        {
            tbComponentCode.Clear();
            tbComponentName.Clear();
            tbManufacturer.Clear();
            tbSeries.Clear();
            tbCapacity.Clear();
            tbFrequency.Clear();
            tbVoltage.Clear();
            tbTiming.Clear();
            tbLatency.Clear();
        }

        private void FillCombos()
        {
            ComponentCompatibility[] componentCompatibilities = _dataAccess.GetComponentCompatibilities(Enums.ComponentType.RAM);
            cboCompatibility.DataSource = componentCompatibilities;
            cboCompatibility.ValueMember = "ComponentCompatibilityId";
            cboCompatibility.DisplayMember = "ComponentCompatibilityName";
        }
        #endregion

        #region Events
        private void btnClean_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvRandomAccessMemory.SelectedItems.Count != 0)
            {
                if (MessageBox.Show("Doresti sa stergi inregistrarea?", "Sterge inregistrarea",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    RAMCollection.RemoveAt(lvRandomAccessMemory.SelectedIndices[0]);
                    FillListView();
                }
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (lvRandomAccessMemory.SelectedItems.Count != 0)
            {
                RandomAccessMemory ram = RAMCollection.ElementAt(lvRandomAccessMemory.SelectedIndices[0]);//SA II PUN ALT NUME LUI ram

                RandomAccessMemoryEditForm editare = new RandomAccessMemoryEditForm(ram);
                editare.ShowDialog();

                FillListView();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            String componentCode = tbComponentCode.Text;
            if (String.IsNullOrEmpty(componentCode) || string.IsNullOrWhiteSpace(componentCode))
            {
                isValid = false;
            }
            String componentName = tbComponentName.Text;
            if (String.IsNullOrEmpty(componentName) || string.IsNullOrWhiteSpace(componentName))
            {
                isValid = false;
            }
            String manufacturer = tbManufacturer.Text;
            if (String.IsNullOrEmpty(manufacturer) || string.IsNullOrWhiteSpace(manufacturer))
            {
                isValid = false;
            }
            String series = tbSeries.Text;
            if (String.IsNullOrEmpty(series) || string.IsNullOrWhiteSpace(series))
            {
                isValid = false;
            }
            String capacity = tbCapacity.Text;
            if (String.IsNullOrEmpty(capacity) || string.IsNullOrWhiteSpace(capacity))
            {
                isValid = false;
            }
            String frequency = tbFrequency.Text;
            if (String.IsNullOrEmpty(frequency) || string.IsNullOrWhiteSpace(frequency))
            {
                isValid = false;
            }
            String latency = tbLatency.Text;
            if (String.IsNullOrEmpty(latency) || string.IsNullOrWhiteSpace(latency))
            {
                isValid = false;
            }
            String voltage = tbVoltage.Text;
            if (String.IsNullOrEmpty(voltage) || string.IsNullOrWhiteSpace(voltage))
            {
                isValid = false;
            }
            String timing = tbTiming.Text;
            if (String.IsNullOrEmpty(timing) || string.IsNullOrWhiteSpace(timing))
            {
                isValid = false;
            }
            //fac verificari pt toate
            if (isValid)
            {
                // creare instanta noua
                try
                {
                    RandomAccessMemory newRAM = new RandomAccessMemory()
                    {
                        ComponentTypeId = _dataAccess.GetComponentTypeId(Enums.ComponentType.RAM),
                        CompatibilityTypeId = Convert.ToInt32(cboCompatibility.SelectedValue),
                        ComponentCode = componentCode,
                        ComponentName = componentName,
                        Manufacturer = manufacturer,
                        Series = series,
                        Capacity = capacity,
                        Frequency= frequency,
                        Latency= latency,
                        Voltage= voltage,
                        Timing= timing
                    };

                    // adaugarea in lista
                    RAMCollection.Add(newRAM);

                    FillListView();

                    // curatam formular definire
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }  
            }
            else
            {
                // nu inseram in lista 
                // si instiintam utilizatorul ca formularul are erori

                MessageBox.Show("Formularul contine erori!", "Eroare",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        
        private void btnReloadData_Click(object sender, EventArgs e)
        {
            LoadMemoriesAndFillListView();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _dataAccess.SaveRandomAccessMemories(RAMCollection.ToArray());
                MessageBox.Show($"Datele au fost salvate cu success!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DataAccessException daex)
            {
                MessageBox.Show(daex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A aparut o eroare neasteptata la salvare! Detalii: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lvRandomAccessMemory_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var enableButtons = lvRandomAccessMemory.SelectedItems.Count != 0;

            btnDelete.Enabled = enableButtons;
            btnModify.Enabled = enableButtons;
        }

        #region Validation events
        private void tbComponentCode_Validated(object sender, EventArgs e)
        {
            epGeneral.Clear();
        }

        private void tbComponentCode_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //verifica sa fie unic in lista
            bool alreadyExists = RAMCollection.Any(r => r.ComponentCode == tbComponentCode.Text);
            if (alreadyExists)
            {
                epGeneral.SetError((Control)sender, $"Codul '{tbComponentCode.Text}' este deja folosit!");
                e.Cancel = true;
            }
        }

        private void tbComponentName_Validated(object sender, EventArgs e)
        {
            epGeneral.Clear();
        }

        private void tbComponentName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int textLengthLimit = 10;
            if (tbComponentName.Text.Length < textLengthLimit)
            {
                epGeneral.SetError((Control)sender, $"Lungimea denumirii trebuie sa fie de minim {textLengthLimit} caractere!");
                e.Cancel = true;
            }
        }
        #endregion
        #region ContextMenuStrip
        private void tsmiModificaRAM_Click(object sender, EventArgs e)
        {
            btnModify_Click(sender, e);
        }

        private void tsmiStergeRAM_Click(object sender, EventArgs e)
        {
            btnDelete_Click(sender, e);
        }

        private void lvRandomAccessMemory_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cmsRAM.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void lvRandomAccessMemory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left &&
                lvRandomAccessMemory.FocusedItem.Bounds.Contains(e.Location.X, e.Location.Y))
            {
                btnModify_Click(sender, e);
            }
        }
        #endregion
        #region AltShortcuts 
        private void lvRandomAccessMemory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D && e.Control)
            {
                btnDelete_Click(sender, e);
            }
            if (e.KeyCode == Keys.M && e.Control)
            {
                btnModify_Click(sender, e);
            }
        }
        #endregion

        #endregion

        #region ToolStrip+Printing
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            pageSetupDialog.Document = printDocument;
            pageSetupDialog.PageSettings = printDocument.DefaultPageSettings;

            if (pageSetupDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.DefaultPageSettings = pageSetupDialog.PageSettings;

                printPreviewDialog.Document = printDocument;
                printPreviewDialog.ShowDialog();
            }
        }
        #endregion

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Consolas", 20);
            Brush brush = Brushes.DarkGray;
            Pen pen = new Pen(brush);

            PageSettings settings = printDocument.DefaultPageSettings;
            var totalDrawableW = settings.PaperSize.Width - settings.Margins.Left - settings.Margins.Right;
            var totalDrawableH = settings.PaperSize.Height - settings.Margins.Top - settings.Margins.Bottom;

            if (settings.Landscape)
            {
                var temp = totalDrawableW;
                totalDrawableW = totalDrawableH;
                totalDrawableH = temp;
            }

            int cellWidth = totalDrawableW / 2;
            int cellHeight = 40;

            int x = settings.Margins.Left;
            int y = 100;

            graphics.DrawString("Lista capacitati RAM", font, brush, totalDrawableW / 3, y);

            y += 100;

            // desenare format cap de tabel
            graphics.DrawRectangle(pen, x, y, cellWidth, cellHeight);
            graphics.DrawRectangle(pen, x + cellWidth, y, cellWidth, cellHeight);

            // desenare continut cap de tabel
            graphics.DrawString("Cod", font, brush, x, y);
            graphics.DrawString("Capacitate", font, brush, x + cellWidth, y);

            y += cellHeight;

            foreach (RandomAccessMemory f in RAMCollection)
            {
                // desenare format cap de tabel
                graphics.DrawRectangle(pen, x, y, cellWidth, cellHeight);
                graphics.DrawRectangle(pen, x + cellWidth, y, cellWidth, cellHeight);

                // desenare continut cap de tabel
                graphics.DrawString(f.ComponentCode, font, brush, x, y);
                graphics.DrawString(f.Capacity, font, brush, x + cellWidth, y);

                y += cellHeight;
            }
        }
    }
}

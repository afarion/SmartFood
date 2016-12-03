using SmartFood.Core;
using SmartFood.Core.Constants;
using SmartFood.Core.Serialisation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SmartFood.Forms
{
    public partial class ConsumbleCategorieForm : Form
    {
        public static ConsumbleCategorieForm instance;
        private static bool updateFlag = false;
        int selectedRow = 0;
        int selectColumn = 0;
        public ConsumbleCategorieForm()
        {
            InitializeComponent();
            DownloadConsumbleTypes();
            instance = this;
            dataGridViewConsumbleCategories.Columns.Add(UIConstans.NEW_COLUMN_ID, GeneralConstants.ID);
            dataGridViewConsumbleCategories.Columns.Add(UIConstans.NEW_COLUMN_NAME, GeneralConstants.NAME);
            var column = new DataGridViewComboBoxColumn();
            column.DataSource = new List<string>() { GeneralConstants.YES, GeneralConstants.NO };
            column.HeaderText = GeneralConstants.VISIBILITY;
            dataGridViewConsumbleCategories.Columns.Add(column);

            column = new DataGridViewComboBoxColumn();
            column.DataSource = ConsumblesTypesCore.ConsumbleTypes.ToList();
            column.HeaderText = GeneralConstants.TYPE;
            dataGridViewConsumbleCategories.Columns.Add(column);

            dataGridViewConsumbleCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewConsumbleCategories.AllowUserToAddRows = false;
            dataGridViewConsumbleCategories.Columns[0].ReadOnly = true;
            dataGridViewConsumbleCategories.RowHeadersVisible = false;
            dataGridViewConsumbleCategories.EditMode = DataGridViewEditMode.EditOnEnter;
            selectedRow = 0;
            selectColumn = 0;

            comboBoxConsumbleTypes.Items.AddRange(ConsumblesTypesCore.ConsumbleTypes.ToList().ToArray());
            try
            {
                comboBoxConsumbleTypes.SelectedIndex = 0;
            }            
            catch { }

            DownloadConsumbleCategories();
        }

        private void ConsumbleCategorieForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminForm.instance.Enabled = true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddConsumbleCategorieForm modalForm = new AddConsumbleCategorieForm(comboBoxConsumbleTypes.SelectedIndex);
            modalForm.StartPosition = FormStartPosition.CenterScreen;
            this.Enabled = false;
            modalForm.Show();
        }

        public void DownloadConsumbleTypes()
        {
             ConsumblesTypesCore.GetConsumbleTypes();
        }

        public void DownloadConsumbleCategories()
        {
            bool isOk = false;
            long typeID = -1;
            try
            {
                typeID = ConsumblesTypesCore.ConsumbleTypes.GetID(comboBoxConsumbleTypes.SelectedItem.ToString());
                isOk = true;
            }
            catch
            {
                ErrorsViewWrapper.ShowError(ErrorTexts.ENTER_TYPE_BEFORE);
            }
            if (isOk)
            {
                new Thread(() =>
                {
                    ConsumbleCategorieCore.GetConsumbleCategorie(typeID.ToString());
                    UpdateDataGridView(typeID);
                }).Start();
            }
        }

        private void UpdateDataGridView(long typeId)
        {
            try
            {
                this.Invoke((MethodInvoker)delegate
                {
                    dataGridViewConsumbleCategories.Rows.Clear();
                    foreach (ConsumbleCategorie categorie in ConsumbleCategorieCore.consumbleCategories.items)
                    {
                        int i = 0;
                        DataGridViewRow row = new DataGridViewRow();
                        dataGridViewConsumbleCategories.Rows.Add(categorie.id, categorie.name, Convert.ToBoolean(categorie.visible) ? GeneralConstants.YES : GeneralConstants.NO, ConsumblesTypesCore.ConsumbleTypes.GetName(typeId));
                        dataGridViewConsumbleCategories.CellValueChanged += DataGridViewConsumbleCategories_CellValueChanged;
                        updateFlag = true;
                    }
                    if (dataGridViewConsumbleCategories.Rows.Count > 0)
                    {
                        try
                        {
                            dataGridViewConsumbleCategories.CurrentCell = dataGridViewConsumbleCategories.Rows[selectedRow].Cells[selectColumn];
                        }
                        catch
                        {
                            dataGridViewConsumbleCategories.CurrentCell = dataGridViewConsumbleCategories.Rows[0].Cells[0];
                        }
                    }
                });
            }
            catch { }
        }

        private void DataGridViewConsumbleCategories_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (updateFlag)
            {
                DataGridViewCellCollection collection = dataGridViewConsumbleCategories.Rows[e.RowIndex].Cells;
                ConsumbleCategorieCore.EditConsumbleCategorie(collection[0].Value.ToString(), collection[1].Value.ToString(), collection[2].Value.ToString() == GeneralConstants.YES ? "1" : "0", ConsumblesTypesCore.ConsumbleTypes.GetID(collection[3].Value.ToString()));
                dataGridViewConsumbleCategories.CellValueChanged -= DataGridViewConsumbleCategories_CellValueChanged;
                updateFlag = false;
                selectColumn = e.ColumnIndex;
                selectedRow = e.RowIndex;
                DownloadConsumbleCategories();
            }
        }

        private void comboBoxConsumbleTypes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DownloadConsumbleCategories();
        }
    }
}

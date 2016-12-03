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
    public partial class ConsumbleTypeForm : Form
    {
        public static ConsumbleTypeForm instance;
        private static bool updateFlag = false;
        int selectedRow = 0;
        int selectColumn = 0;
        public ConsumbleTypeForm()
        {
            InitializeComponent();
            instance = this;
            dataGridViewConsumbleTypes.Columns.Add(UIConstans.NEW_COLUMN_ID, GeneralConstants.ID);
            dataGridViewConsumbleTypes.Columns.Add(UIConstans.NEW_COLUMN_NAME, GeneralConstants.NAME);
            var column = new DataGridViewComboBoxColumn();
            column.DataSource = new List<string>() { GeneralConstants.YES, GeneralConstants.NO };
            column.HeaderText = GeneralConstants.VISIBILITY;
            dataGridViewConsumbleTypes.Columns.Add(column);
            dataGridViewConsumbleTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewConsumbleTypes.AllowUserToAddRows = false;
            dataGridViewConsumbleTypes.Columns[0].ReadOnly = true;
            dataGridViewConsumbleTypes.RowHeadersVisible = false;
            dataGridViewConsumbleTypes.EditMode = DataGridViewEditMode.EditOnEnter;
            selectedRow = 0;
            selectColumn = 0;
            DownloadConsumbleTypes();
        }

        private void ConsumbleTypeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminForm.instance.Enabled = true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddConsumbleTypeForm modalForm = new AddConsumbleTypeForm();
            modalForm.StartPosition = FormStartPosition.CenterScreen;
            this.Enabled = false;
            modalForm.Show();
        }

        public void DownloadConsumbleTypes()
        {
            new Thread(() =>
            {
                ConsumblesTypesCore.GetConsumbleTypes();
                UpdateDataGridView();
            }).Start();
        }

        private void UpdateDataGridView()
        {
            try
            {
                this.Invoke((MethodInvoker)delegate
                {
                    dataGridViewConsumbleTypes.Rows.Clear();
                    foreach (ConsumbleType type in ConsumblesTypesCore.consumbleTypes.items)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        dataGridViewConsumbleTypes.Rows.Add(type.id, type.name, Convert.ToBoolean(type.visible) ? GeneralConstants.YES : GeneralConstants.NO);
                        dataGridViewConsumbleTypes.CellValueChanged += DataGridViewConsumbleTypes_CellValueChanged;
                        updateFlag = true;
                    }
                    dataGridViewConsumbleTypes.CurrentCell = dataGridViewConsumbleTypes.Rows[selectedRow].Cells[selectColumn];
                });
            }
            catch{ }
        }

        private void DataGridViewConsumbleTypes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (updateFlag)
            {
                DataGridViewCellCollection collection = dataGridViewConsumbleTypes.Rows[e.RowIndex].Cells;
                ConsumblesTypesCore.EditConsumbleType(collection[0].Value.ToString(), collection[1].Value.ToString(), collection[2].Value.ToString() == GeneralConstants.YES ? "1" : "0");
                dataGridViewConsumbleTypes.CellValueChanged -= DataGridViewConsumbleTypes_CellValueChanged;
                updateFlag = false;
                selectColumn = e.ColumnIndex;
                selectedRow = e.RowIndex;
                DownloadConsumbleTypes();
            }       
        }
    }
}

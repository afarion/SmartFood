using SmartFood.Core;
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
            dataGridViewConsumbleCategories.Columns.Add("newColumnID", "ID");
            dataGridViewConsumbleCategories.Columns.Add("newColumnName", "Имя");
            var column = new DataGridViewComboBoxColumn();
            column.DataSource = new List<string>() { "Да", "Нет" };
            column.HeaderText = "Видимость";
            dataGridViewConsumbleCategories.Columns.Add(column);

            column = new DataGridViewComboBoxColumn();
            column.DataSource = ConsumblesTypesCore.consumbleTypes.ToList();
            column.HeaderText = "Тип";
            dataGridViewConsumbleCategories.Columns.Add(column);

            dataGridViewConsumbleCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewConsumbleCategories.AllowUserToAddRows = false;
            dataGridViewConsumbleCategories.Columns[0].ReadOnly = true;
            dataGridViewConsumbleCategories.RowHeadersVisible = false;
            dataGridViewConsumbleCategories.EditMode = DataGridViewEditMode.EditOnEnter;
            selectedRow = 0;
            selectColumn = 0;

            comboBoxConsumbleTypes.Items.AddRange(ConsumblesTypesCore.consumbleTypes.ToList().ToArray());
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
                typeID = ConsumblesTypesCore.consumbleTypes.GetID(comboBoxConsumbleTypes.SelectedItem.ToString());
                isOk = true;
            }
            catch
            {
                ErrorsViewWrapper.ShowError("Добавьте вначале тип");
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
                        dataGridViewConsumbleCategories.Rows.Add(categorie.id, categorie.name, Convert.ToBoolean(categorie.visible) ? "Да" : "Нет", ConsumblesTypesCore.consumbleTypes.GetName(typeId));
                        dataGridViewConsumbleCategories.CellValueChanged += DataGridViewConsumbleCategories_CellValueChanged;
                        updateFlag = true;
                    }
                    if(dataGridViewConsumbleCategories.Rows.Count >0)
                        dataGridViewConsumbleCategories.CurrentCell = dataGridViewConsumbleCategories.Rows[selectedRow].Cells[selectColumn];
                });
            }
            catch { }
        }

        private void DataGridViewConsumbleCategories_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (updateFlag)
            {
                DataGridViewCellCollection collection = dataGridViewConsumbleCategories.Rows[e.RowIndex].Cells;
                ConsumbleCategorieCore.EditConsumbleCategorie(collection[0].Value.ToString(), collection[1].Value.ToString(), collection[2].Value.ToString() == "Да" ? "1" : "0", ConsumblesTypesCore.consumbleTypes.GetID(collection[3].Value.ToString()));
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

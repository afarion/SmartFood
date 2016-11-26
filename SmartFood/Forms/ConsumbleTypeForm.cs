using SmartFood.Core;
using SmartFood.Core.Serialisation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartFood.Forms
{
    public partial class ConsumbleTypeForm : Form
    {
        public static ConsumbleTypeForm instance;

        public ConsumbleTypeForm()
        {
            InitializeComponent();
            instance = this;
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

        private void DownloadConsumbleTypes()
        {
            ConsumblesTypesCore.GetConsumbleTypes();
            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            dataGridViewConsumbleTypes.Columns.Add("newColumnID", "ID");
            dataGridViewConsumbleTypes.Columns.Add("newColumnName", "Имя");
            dataGridViewConsumbleTypes.Columns.Add("newColumnVisiable", "Видимость");

            foreach(ConsumbleType type in ConsumblesTypesCore.consumbleTypes.items)
            {
                dataGridViewConsumbleTypes.Rows.Add(type.id, type.name, Convert.ToBoolean(type.visible));
            }
        }

    }
}

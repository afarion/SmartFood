using SmartFood.Core;
using SmartFood.Core.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static SmartFood.Core.Constants.GeneralConstants;

namespace SmartFood.Forms
{
    public partial class GoodDetailsForm : Form
    {
        public static GoodDetailsForm instance;
        public GoodDetailsForm()
        {
            InitializeComponent();
            comboBoxCategory.DataSource = GoodsCategoriesCore.GoodsCategories.items.ToList();
            comboBoxCategory.SelectedIndex = 0;

            dataGridViewConsumbles.Columns.Add(UIConstans.NEW_COLUMN_ID, GeneralConstants.ID);
            dataGridViewConsumbles.Columns.Add(UIConstans.NEW_COLUMN_NAME, GeneralConstants.NAME);
            dataGridViewConsumbles.Columns.Add(UIConstans.NEW_COLUMN_CATEGORY, GeneralConstants.CATEGORY);
            dataGridViewConsumbles.Columns.Add(UIConstans.NEW_COLUMN_PRICE, GeneralConstants.PRICE);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            AdminForm.instance.Enabled = true;
            this.Close();
        }

        private void GoodDetailsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminForm.instance.Enabled = true;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
        }

        private void buttonAddConsumble_Click(object sender, EventArgs e)
        {
            NewGoodsConsumble modalForm = new NewGoodsConsumble();
            modalForm.StartPosition = FormStartPosition.CenterScreen;
            this.Enabled = false;
            modalForm.Show();
        }
    }
}

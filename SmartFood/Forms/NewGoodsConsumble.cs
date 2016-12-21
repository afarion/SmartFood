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
    public partial class NewGoodsConsumble : Form
    {
        public NewGoodsConsumble()
        {
            InitializeComponent();
            comboBoxType.DataSource = ConsumblesTypesCore.ConsumbleTypes.ToList();
            comboBoxType.SelectedIndex = 0;
            comboBoxType.SelectedIndexChanged += ComboBoxType_SelectedIndexChanged;

            comboBoxCategory.SelectedIndexChanged += ComboBoxCategory_SelectedIndexChanged;
            ComboBoxType_SelectedIndexChanged(this, null);
            ComboBoxCategory_SelectedIndexChanged(this, null);
        }

        private void ComboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Consumbles consumbles = ConsumblesCore.GetConsumbles(ConsumbleCategorieCore.consumbleCategories.GetID(comboBoxCategory.SelectedItem.ToString()));
                comboBoxConsumbles.DataSource = consumbles.ToList();
                comboBoxCategory.SelectedIndex = 0;
            }
            catch
            {
                comboBoxCategory.Text = "";
                comboBoxConsumbles.Text = "";
            }
        }

        private void ComboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConsumbleCategorieCore.GetConsumbleCategorie(ConsumblesTypesCore.ConsumbleTypes.GetID(comboBoxType.SelectedItem.ToString()).ToString());
            try
            {
                comboBoxCategory.DataSource = ConsumbleCategorieCore.consumbleCategories.ToList();
                comboBoxCategory.SelectedIndex = 0;
            }
            catch
            {
                comboBoxConsumbles.Text = "";
            }
        }

        private void NewGoodsConsumble_FormClosed(object sender, FormClosedEventArgs e)
        {
            GoodDetailsForm.instance.Enabled = true;
        }
    }
}

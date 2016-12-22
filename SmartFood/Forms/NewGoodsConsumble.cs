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
                comboBoxConsumbles.SelectedIndex = 0;
                buttonOk.Enabled = true;
            }
            catch
            {
                comboBoxConsumbles.Text = "";
                buttonOk.Enabled = false;
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
                comboBoxConsumbles.DataSource = null;
                comboBoxCategory.Text = "";
                buttonOk.Enabled = false;
            }
        }

        private void NewGoodsConsumble_FormClosed(object sender, FormClosedEventArgs e)
        {
            GoodDetailsForm.instance.Enabled = true;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            bool isOk = false;
            double weight =0;
            try
            {
                weight = Convert.ToDouble(textBoxWeight.Text);
                isOk = true;
            }
            catch
            {
                ErrorsViewWrapper.ShowError(ErrorTexts.INCORRECT_WEIGHT);
            }

            if (isOk)
            {
                GoodDetailsForm.instance.AddConsumbleToGrid(comboBoxConsumbles.SelectedItem.ToString(), weight);
                this.Close();
            }
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

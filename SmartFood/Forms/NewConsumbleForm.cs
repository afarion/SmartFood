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

namespace SmartFood.Forms
{
    public partial class NewConsumbleForm : Form
    {
        public NewConsumbleForm()
        {
            InitializeComponent();
            foreach(string type in ConsumblesTypesCore.ConsumbleTypes.ToList())
                comboBoxType.Items.Add(type);
            comboBoxType.SelectedIndex = 0;

            foreach(string measure in MeasuresCore.Measures.ToList())
                comboBoxMeasuring.Items.Add(measure);
            comboBoxMeasuring.SelectedIndex = 0;

            comboBoxType_SelectionChangeCommitted(this, null);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            AdminForm.instance.Enabled = true;
            this.Close();
        }

        private void NewConsumbleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminForm.instance.Enabled = true;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxName.Text) && !string.IsNullOrEmpty(textBoxPrice.Text))
            {
                double price = 0;
                int waste=0;
                bool correctWaste = false;
                try
                {
                   price  = Convert.ToDouble(textBoxPrice.Text);
                }
                catch
                {
                    ErrorsViewWrapper.ShowError(ErrorTexts.INCORRECT_PRICE);
                }
                try
                {
                    waste = Convert.ToInt32(textBoxWaste.Text);
                    if (waste < 100 && waste>=0)
                        correctWaste = true;
                    else
                        ErrorsViewWrapper.ShowError(ErrorTexts.INCORRECT_WASTE);
                }
                catch
                {
                    ErrorsViewWrapper.ShowError(ErrorTexts.INCORRECT_WASTE);
                }
                if (price > 0 && correctWaste)
                {
                    ConsumblesCore.AddConsumble(textBoxName.Text,
                                                ConsumblesTypesCore.ConsumbleTypes.GetID(comboBoxType.SelectedItem.ToString()),
                                                ConsumbleCategorieCore.consumbleCategories.GetID(comboBoxCategory.SelectedItem.ToString()),
                                                MeasuresCore.Measures.GetID(comboBoxMeasuring.SelectedItem.ToString()),
                                                0,
                                                price,
                                                waste);                    
                    AdminForm.instance.UpdateDataGridViewConsumbles();
                    this.Close();
                }
            }
            else if (string.IsNullOrEmpty(textBoxName.Text) && string.IsNullOrEmpty(textBoxPrice.Text))
                ErrorsViewWrapper.ShowError(ErrorTexts.ENTER_NAME_AND_PRICE);
            else if (string.IsNullOrEmpty(textBoxName.Text))
                ErrorsViewWrapper.ShowError(ErrorTexts.ENTER_NAME);
            else if (string.IsNullOrEmpty(textBoxPrice.Text))
                ErrorsViewWrapper.ShowError(ErrorTexts.ENTER_PRICE);
        }

        private void comboBoxType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxCategory.Items != null)
                comboBoxCategory.Items.Clear();
            ConsumbleCategorieCore.GetConsumbleCategorie(ConsumblesTypesCore.ConsumbleTypes.GetID(comboBoxType.SelectedItem.ToString()).ToString());
            if (ConsumbleCategorieCore.consumbleCategories.items.Count > 0)
            {
                foreach (string category in ConsumbleCategorieCore.consumbleCategories.ToList())
                    comboBoxCategory.Items.Add(category);
                comboBoxCategory.SelectedIndex = 0;
            }
            else
            {
                comboBoxCategory.Text = "";
                comboBoxCategory.Enabled = false;
            }
            this.Refresh();
        }
    }
}

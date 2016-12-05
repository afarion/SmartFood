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
    public partial class AddConsumbleCategorieForm : Form
    {
        public AddConsumbleCategorieForm(int selectedComboIndex)
        {
            InitializeComponent();
            comboBoxType.Items.AddRange(ConsumblesTypesCore.ConsumbleTypes.ToList().ToArray());
            try
            {
                comboBoxType.SelectedIndex = selectedComboIndex;
            }
            catch { }
        }

        private void AddConsumbleCategorieForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ConsumbleCategorieForm.instance.Enabled = true;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            ConsumbleCategorieForm.instance.Enabled = true;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
                ErrorsViewWrapper.ShowError(ErrorTexts.ENTER_NAME);
            else
            {
                ConsumbleCategorieCore.AddConsumbleCategorie(textBoxName.Text, ConsumblesTypesCore.ConsumbleTypes.GetID(comboBoxType.SelectedItem.ToString()));
                ConsumbleCategorieForm.instance.DownloadConsumbleCategories();
                this.Close();
            }
        }
    }
}

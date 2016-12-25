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
    public partial class ConsumbleWriteOffForm : Form
    {
        public ConsumbleWriteOffForm()
        {
            InitializeComponent();
            comboBoxType.DataSource = ConsumblesTypesCore.ConsumbleTypes.ToList();
            comboBoxType.SelectedIndex = 0;
            comboBoxType.SelectedIndexChanged += ComboBoxType_SelectedIndexChanged;

            comboBoxCategory.SelectedIndexChanged += ComboBoxCategory_SelectedIndexChanged;
            ComboBoxType_SelectedIndexChanged(this, null);
            ComboBoxCategory_SelectedIndexChanged(this, null);

            foreach (var employee in EmployeesCore.Emplyees.items)
            {
                if (employee.id_type == 2 || employee.id_type == 4)
                    comboBoxCook.Items.Add(EmployeesCore.Emplyees.GetEmployeeFullName(employee.id));
            }
            comboBoxCook.SelectedIndex = 0;
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            AdminForm.instance.Enabled = true;
            this.Close();
        }

        private void ConsumbleWriteOffForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminForm.instance.Enabled = true;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCount.Text) && string.IsNullOrEmpty(richTextBoxComment.Text))
                ErrorsViewWrapper.ShowError(ErrorTexts.ENTER_COUNT_AND_COMMENT);
            else if (string.IsNullOrEmpty(textBoxCount.Text))
                ErrorsViewWrapper.ShowError(ErrorTexts.ENTER_COUNT);
            else if (string.IsNullOrEmpty(richTextBoxComment.Text))
                ErrorsViewWrapper.ShowError(ErrorTexts.ENTER_COMMENT);
            else
            {
                bool isOK = true;
                double count = 0;

                try
                {
                    count = Convert.ToDouble(textBoxCount.Text);
                }
                catch
                {
                    isOK = false;
                    ErrorsViewWrapper.ShowError(ErrorTexts.INCORRECT_COUNT);
                }
                if (isOK)
                {
                    WriteOffCore.AddWriteOff(ConsumblesCore.Consumbles.GetID(comboBoxConsumbles.SelectedItem.ToString()),
                        EmployeesCore.Emplyees.GetID(comboBoxCook.SelectedItem.ToString()),
                        count,
                        richTextBoxComment.Text);
                    WriteOffCore.GetWriteOff();
                    ConsumblesCore.GetConsumbles();
                    AdminForm.instance.UpdateDataGridViewWriteOff();
                    AdminForm.instance.UpdateDataGridViewConsumbles();
                    this.Close();
                }
            }
        }
    }
}

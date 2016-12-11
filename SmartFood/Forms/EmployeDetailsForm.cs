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
    public partial class EmployeDetailsForm : Form
    {
        public EmployeDetailsForm()
        {
            InitializeComponent();
            foreach (var item in EmployeesTypesCore.EmployeesTypes.ToList())
                comboBoxPosition.Items.Add(item);
            comboBoxPosition.SelectedIndex = 0;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            AdminForm.instance.Enabled = true;
            this.Close();
        }

        private void EmployeDetailsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminForm.instance.Enabled = true;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFirstName.Text) || string.IsNullOrEmpty(textBoxSourname.Text))
                ErrorsViewWrapper.ShowError(ErrorTexts.ENTER_FULL_NAME);
            else
            {
                EmployeesCore.AddEmplyee(textBoxFirstName.Text,
                    textBoxSourname.Text,
                    EmployeesTypesCore.EmployeesTypes.GetID(comboBoxPosition.SelectedItem.ToString()).ToString(),
                    textBoxPhone1.Text,
                    textBoxPhone2.Text,
                    textBoxEmeil.Text,
                    textBoxAdress.Text,
                    textBoxSkype.Text,
                    dateTimePicker1.Value.ToString("yyyy-MM-dd"),
                    textBoxComment.Text);
                AdminForm.instance.UpdateDataGridViewEmployees();
                this.Close();
            }
        }
    }
}

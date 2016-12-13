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
    public partial class AcountDetails : Form
    {
        public AcountDetails()
        {
            InitializeComponent();
            comboBoxEmploye.DataSource = EmployeesCore.Emplyees.ToList();
            comboBoxEmploye.SelectedIndex = 0;
            comboBoxRole.DataSource = EmployeesTypesCore.EmployeesTypes.ToList();
            comboBoxRole.SelectedIndex = 0;

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            AdminForm.instance.Enabled = true;
            this.Close();
        }

        private void AcountDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminForm.instance.Enabled = true;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxLogin.Text) || string.IsNullOrEmpty(textBoxPassword.Text))
                ErrorsViewWrapper.ShowError(ErrorTexts.ENTER_LOGIN_AND_PASSWORD);
            else
            {
                AcountsCore.AddAcount(textBoxLogin.Text,
                    AcountTypesCore.GetAcountType(comboBoxRole.SelectedValue.ToString()),
                    EmployeesCore.Emplyees.GetID(comboBoxEmploye.SelectedValue.ToString()),
                    textBoxPassword.Text);
                AdminForm.instance.UpdateDataGridViewAcounts();
                this.Close();
            }
        }
    }
}

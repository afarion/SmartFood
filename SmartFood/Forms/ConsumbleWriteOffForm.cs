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
    public partial class ConsumbleWriteOffForm : Form
    {
        public ConsumbleWriteOffForm()
        {
            InitializeComponent();
            comboBoxName.DataSource = ConsumblesCore.Consumbles.ToList();
            comboBoxName.SelectedIndex = 0;
            foreach (var employee in EmployeesCore.Emplyees.items)
            {
                if (employee.id_type == 2 || employee.id_type == 4)
                    comboBoxCook.Items.Add(EmployeesCore.Emplyees.GetEmployeeFullName(employee.id));
            }
            comboBoxCook.SelectedIndex = 0;
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
                    WriteOffCore.AddWriteOff(ConsumblesCore.Consumbles.GetID(comboBoxName.SelectedItem.ToString()),
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

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
    public partial class ConsumbleArrivalForm : Form
    {
        public ConsumbleArrivalForm()
        {
            InitializeComponent();
            comboBoxName.DataSource = ConsumblesCore.Consumbles.ToList();
            comboBoxName.SelectedIndex = 0;
            comboBoxSupplier.DataSource = SuppliersCore.Suppliers.ToList();
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

        private void ConsumbleArrivalForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminForm.instance.Enabled = true;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCount.Text) && string.IsNullOrEmpty(textBoxPrice.Text))
                ErrorsViewWrapper.ShowError(ErrorTexts.ENTER_PRICE_AND_COUNT);
            else if (string.IsNullOrEmpty(textBoxCount.Text))
                ErrorsViewWrapper.ShowError(ErrorTexts.ENTER_COUNT);
            else if (string.IsNullOrEmpty(textBoxPrice.Text))
                ErrorsViewWrapper.ShowError(ErrorTexts.ENTER_PRICE);
            else
            { 
                bool isOK = true;
                double price=0, count = 0;
                try
                {
                    price = Convert.ToDouble(textBoxPrice.Text);
                }
                catch
                {
                    isOK = false;
                    ErrorsViewWrapper.ShowError(ErrorTexts.INCORRECT_PRICE);
                }

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
                    ArrivalCore.AddArrival(ConsumblesCore.Consumbles.GetID(comboBoxName.SelectedItem.ToString()),
                        SuppliersCore.Suppliers.GetID(comboBoxSupplier.SelectedItem.ToString()),
                        EmployeesCore.Emplyees.GetID(comboBoxCook.SelectedItem.ToString()),
                        count,
                        price);
                    ArrivalCore.GetArrivals();
                    ConsumblesCore.GetConsumbles();
                    AdminForm.instance.UpdateDataGridViewArrival();
                    AdminForm.instance.UpdateDataGridViewConsumbles();
                    this.Close();
                }
            }
        }
    }
}

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
    public partial class SupplierDetailsForm : Form
    {
        public SupplierDetailsForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            AdminForm.instance.Enabled = true;
            this.Close();
        }

        private void SupplierDetailsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminForm.instance.Enabled = true;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxCompanyName.Text))
                ErrorsViewWrapper.ShowError(ErrorTexts.ENTER_NAME);
            else
            {
                SuppliersCore.AddSuplier(textBoxCompanyName.Text, textBoxPhone1.Text, textBoxEmeil.Text, textBoxSkype.Text, textBoxNotes.Text);
                SuppliersCore.GetSuppliers();
                AdminForm.instance.UpdateDataGridViewSuppliers();
                this.Close();
            }
        }
    }
}

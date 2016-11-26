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
    public partial class ClientDetailsForm : Form
    {
        public static ClientDetailsForm instance = null;

        public ClientDetailsForm()
        {
            InitializeComponent();
            instance = this;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            AdminForm.instance.Enabled = true;
            this.Close();
        }

        private void buttonAddDiscount_Click(object sender, EventArgs e)
        {
            AddDiscountForm modalForm = new AddDiscountForm();
            modalForm.StartPosition = FormStartPosition.CenterScreen;
            this.Enabled = false;
            modalForm.Show();
        }

        private void ClientDetailsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminForm.instance.Enabled = true;
        }
    }
}

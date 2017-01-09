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
    public partial class OrderForm : Form
    {
        public static OrderForm instance;
        public OrderForm()
        {
            InitializeComponent();
            instance = this;
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }



        private void buttonCancel_Click(object sender, EventArgs e)
        {
            CashierForm.instance.Enabled = true;
            this.Close();
        }

        private void OrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CashierForm.instance.Enabled = true;
        }

        private void buttonClientDetails_Click(object sender, EventArgs e)
        {
            CustomerDetailsForm modalForm = new CustomerDetailsForm();
            modalForm.StartPosition = FormStartPosition.CenterScreen;
            this.Enabled = false;
            modalForm.Show();
        }
    }
}

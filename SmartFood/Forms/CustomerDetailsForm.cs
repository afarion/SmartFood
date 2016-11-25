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
    public partial class CustomerDetailsForm : Form
    {
        public CustomerDetailsForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            OrderForm.instance.Enabled = true;
            this.Close();
        }

        private void CustomerDetailsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            OrderForm.instance.Enabled = true;
        }
    }
}

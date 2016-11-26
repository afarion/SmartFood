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
    public partial class AddDiscountForm : Form
    {
        public AddDiscountForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ClientDetailsForm.instance.Enabled = true;
            this.Close();
        }

        private void AddDiscountForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClientDetailsForm.instance.Enabled = true;
        }
    }
}

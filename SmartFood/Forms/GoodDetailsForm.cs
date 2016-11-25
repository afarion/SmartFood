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
    public partial class GoodDetailsForm : Form
    {
        public GoodDetailsForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            AdminForm.instance.Enabled = true;
            this.Close();
        }

        private void GoodDetailsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminForm.instance.Enabled = true;
        }
    }
}

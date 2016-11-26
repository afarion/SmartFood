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
    public partial class AddConsumbleTypeForm : Form
    {
        public AddConsumbleTypeForm()
        {
            InitializeComponent();
        }

        private void AddConsumbleTypeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ConsumbleTypeForm.instance.Enabled = true;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            ConsumbleTypeForm.instance.Enabled = true;
        }
    }
}

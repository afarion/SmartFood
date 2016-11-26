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
    public partial class AddConsumbleCategorieForm : Form
    {
        public AddConsumbleCategorieForm()
        {
            InitializeComponent();
        }

        private void AddConsumbleCategorieForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ConsumbleCategorieForm.instance.Enabled = true;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            ConsumbleCategorieForm.instance.Enabled = true;
        }
    }
}

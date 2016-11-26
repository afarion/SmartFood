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
    public partial class ConsumbleCategorieForm : Form
    {
        public static ConsumbleCategorieForm instance;
        public ConsumbleCategorieForm()
        {
            InitializeComponent();
            instance = this;
        }

        private void ConsumbleCategorieForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminForm.instance.Enabled = true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddConsumbleCategorieForm modalForm = new AddConsumbleCategorieForm();
            modalForm.StartPosition = FormStartPosition.CenterScreen;
            this.Enabled = false;
            modalForm.Show();
        }
    }
}

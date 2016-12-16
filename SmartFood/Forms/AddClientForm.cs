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
    public partial class AddClientForm : Form
    {
        public AddClientForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            AdminForm.instance.Enabled = true;
            this.Close();
        }

        private void AddClientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminForm.instance.Enabled = true;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text) && string.IsNullOrEmpty(textBoxPhone.Text))
                ErrorsViewWrapper.ShowError(ErrorTexts.ENTER_NAME_AND_PHONE);
            else if(string.IsNullOrEmpty(textBoxName.Text))
                ErrorsViewWrapper.ShowError(ErrorTexts.ENTER_NAME);
            else if (string.IsNullOrEmpty(textBoxPhone.Text))
                ErrorsViewWrapper.ShowError(ErrorTexts.ENTER_PHONE);
            else
            {
                ClientsCore.AddClient(textBoxName.Text, textBoxPhone.Text, string.IsNullOrEmpty(textBoxEmeil.Text)?"": textBoxEmeil.Text, string.IsNullOrEmpty(textBoxComment.Text) ? "" : textBoxComment.Text);
                ClientsCore.GetClients();
                AdminForm.instance.UpdateDataGridViewClients();
                this.Close();
            }
        }
    }
}

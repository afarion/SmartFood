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
    public partial class AddClientsAddress : Form
    {
        private int clientID;
        public AddClientsAddress(int clientID)
        {
            this.clientID = clientID;
            InitializeComponent();
        }

        private void AddClientsAddress_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClientDetailsForm.instance.Enabled = true;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxAddress.Text))
                ErrorsViewWrapper.ShowError(ErrorTexts.ENTER_ADDRESS);
            else
            {
                ClientAddressesCore.AddClientAddress(clientID, textBoxAddress.Text);
                ClientsCore.GetClients();
                ClientDetailsForm.instance.UpdateAddressesGrid();
                this.Close();
            }
        }
    }
}

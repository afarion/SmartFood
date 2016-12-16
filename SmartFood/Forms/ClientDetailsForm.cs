using SmartFood.Core;
using SmartFood.Core.Constants;
using SmartFood.Core.Serialisation;
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
        private int clientID;
        private int selectedAddressID;
        private Client client;

        public ClientDetailsForm(int clientID)
        {
            this.clientID = clientID;
            InitializeComponent();
            instance = this;

            comboBoxVisible.Items.Add(GeneralConstants.YES);
            comboBoxVisible.Items.Add(GeneralConstants.NO);

            dataGridViewAddreses.Columns.Add(UIConstans.NEW_COLUMN_ID, GeneralConstants.ID);
            dataGridViewAddreses.Columns.Add(UIConstans.NEW_COLUMN_ADRESS, GeneralConstants.ADDRESSES);
            dataGridViewAddreses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewAddreses.AllowUserToAddRows = false;
            dataGridViewAddreses.ReadOnly = true;
            dataGridViewAddreses.RowHeadersVisible = false;
            dataGridViewAddreses.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridViewAddreses.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewAddreses.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewAddreses.CellClick += DataGridViewAddreses_CellClick;
            dataGridViewAddreses.CellContentDoubleClick += DataGridViewAddreses_CellClick;

            client = ClientsCore.Clients.GetClint(clientID);
            textBoxPhone.Text = client.phone;
            textBoxName.Text = client.name;
            textBoxEmeil.Text = client.email;
            textBoxStaticDiscunt.Text = client.discount_fixed.ToString();
            textBoxDiscountReasone.Text = client.discount_reason;
            textBoxTotalSumm.Text = client.total_balance.ToString();
            textBoxDinamicDiscount.Text = client.discount_stored.ToString();
            textBoxOther.Text = client.comment;
            comboBoxVisible.SelectedItem = Convert.ToBoolean(client.visible) ? GeneralConstants.YES : GeneralConstants.NO;

            foreach(ClientAddress address in client.addresses.items)
                dataGridViewAddreses.Rows.Add(address.id, address.address);

        }

        private void DataGridViewAddreses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedAddressID = Convert.ToInt32(dataGridViewAddreses[0, e.RowIndex].Value);
                dataGridViewAddreses.Rows[e.RowIndex].Selected = true;
            }
        }

        public void UpdateAddressesGrid()
        {
            Client client = ClientsCore.Clients.GetClint(clientID);
            dataGridViewAddreses.Rows.Clear();
            foreach (ClientAddress address in client.addresses.items)
                dataGridViewAddreses.Rows.Add(address.id, address.address);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            AdminForm.instance.Enabled = true;
            this.Close();
        }

        private void buttonAddDiscount_Click(object sender, EventArgs e)
        {
            AddDiscountForm modalForm = new AddDiscountForm(client);
            modalForm.StartPosition = FormStartPosition.CenterScreen;
            this.Enabled = false;
            modalForm.Show();
        }

        private void ClientDetailsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminForm.instance.Enabled = true;
        }

        private void buttonAddAddress_Click(object sender, EventArgs e)
        {
            AddClientsAddress modalForm = new AddClientsAddress(clientID);
            modalForm.StartPosition = FormStartPosition.CenterScreen;
            this.Enabled = false;
            modalForm.Show();
        }

        private void buttonDeleteAddress_Click(object sender, EventArgs e)
        {
            bool dialogResult = ErrorsViewWrapper.ShowDialog(ErrorTexts.WARNING_DELETE_ADDRESS);
            if (dialogResult)
            {
                ClientAddressesCore.RemoveClientAddress(selectedAddressID);
                ClientsCore.GetClients();
                UpdateAddressesGrid();
            }
        }

        public void UpdateDiscount()
        {
            client = ClientsCore.Clients.GetClint(clientID);
            textBoxStaticDiscunt.Text = client.discount_fixed.ToString();
            textBoxDiscountReasone.Text = client.discount_reason;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            ClientsCore.EditClient(clientID,
                textBoxName.Text,
                textBoxPhone.Text,
                textBoxEmeil.Text,
                Convert.ToInt32(textBoxStaticDiscunt.Text),
                textBoxOther.Text,
                textBoxDiscountReasone.Text,
                comboBoxVisible.SelectedItem.ToString() == GeneralConstants.YES ? 1 : 0);
            ClientsCore.GetClients();
            AdminForm.instance.UpdateDataGridViewClients();
            this.Close();
        }
    }
}

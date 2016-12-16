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
    public partial class AddDiscountForm : Form
    {
        private Client client;
        public AddDiscountForm(Client client)
        {
            this.client = client;
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

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxDiscount.Text) && string.IsNullOrEmpty(richTextBoxReasone.Text))
                ErrorsViewWrapper.ShowError(ErrorTexts.ENTER_DISCOUNT_AND_REASONE);
            else if (string.IsNullOrEmpty(textBoxDiscount.Text))
                ErrorsViewWrapper.ShowError(ErrorTexts.ENTER_DISCOUNT);
            else if (string.IsNullOrEmpty(richTextBoxReasone.Text))
                ErrorsViewWrapper.ShowError(ErrorTexts.ENTER_DISCOUNT_REASONE);
            else
            {
                bool isOk = true;
                int discount = 0;
                try
                {
                    discount = Convert.ToInt32(textBoxDiscount.Text);
                    if (discount < 0 || discount >= 100)
                        isOk = false;
                }
                catch
                {
                    isOk = false;
                }
                if (!isOk)
                    ErrorsViewWrapper.ShowError(ErrorTexts.INCORRECT_DISCOUNT);
                else
                {
                    ClientsCore.EditClient(client.id, client.name, client.phone, client.email, discount, client.comment, richTextBoxReasone.Text, client.visible);
                    ClientsCore.GetClients();
                    ClientDetailsForm.instance.UpdateDiscount();
                    this.Close();
                }
            }
        }
    }
}

using SmartFood.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartFood
{
    public partial class LoginForm : Form
    {
        public static Form instance = null;

        public LoginForm()
        {
            InitializeComponent();
            instance = this;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string user = string.Empty;
            try
            {
                user = LoginComboBox.SelectedItem.ToString();
            }
            catch
            {
            }

            switch (user)
            {
                case "Касса":
                    if(PasswordTextBox.Text == Settings.cashierPassword)
                    {
                        this.Visible = false;
                        CashierForm form = new Forms.CashierForm();
                        form.ShowDialog();
                    }
                    else
                    {
                        PasswordTextBox.Text = string.Empty;
                        MessageBox.Show("Неправильный пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Админ":
                    if (PasswordTextBox.Text == Settings.adminPassword)
                    {
                        this.Visible = false;
                        AdminForm form = new Forms.AdminForm();
                        form.Show();
                    }
                    else
                    {
                        PasswordTextBox.Text = string.Empty;
                        MessageBox.Show("Неправильный пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Кухня":
                    if (PasswordTextBox.Text == Settings.kitchenPassword)
                    {
                        this.Visible = false;
                        KitchenForm form = new Forms.KitchenForm();
                        form.Show();
                    }
                    else
                    {
                        PasswordTextBox.Text = string.Empty;
                        MessageBox.Show("Неправильный пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "":
                    MessageBox.Show("Пожалуйста выберите пользователя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }        
        }
    }
}

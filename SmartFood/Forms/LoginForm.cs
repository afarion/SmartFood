using SmartFood.Core;
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

        public LoginForm()
        {
            InitializeComponent();

            comboBoxRole.Items.Add(new ComboBoxItem(1, "Администратор"));
            comboBoxRole.Items.Add(new ComboBoxItem(2, "Оператор"));
            comboBoxRole.Items.Add(new ComboBoxItem(3, "Повар"));
            comboBoxRole.SelectedIndex = 0;
            CoreBase.Init();
            //LoginCore.LogIn();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            long role = (comboBoxRole.SelectedItem as ComboBoxItem).ID;
            bool loginSet = false;
            bool passwordSet = false;
            if (!string.IsNullOrEmpty(textBoxLogin.Text))
                loginSet = true;
            if (!string.IsNullOrEmpty(textBoxPassword.Text))
                passwordSet = true;
            if (loginSet && passwordSet)
            {
                string login = textBoxLogin.Text;
                string password = textBoxPassword.Text;
                LoginCore.LogIn(role, login, password);
                if (CoreBase.isAuthorised)
                {
                    this.Visible = false;
                    Form form;
                    switch (role)
                    {
                        case 1:
                            form = new Forms.AdminForm();
                            form.Show();
                            break;
                        case 2:
                            form = new Forms.CashierForm();
                            form.ShowDialog();
                            break;
                        case 3:
                            form = new Forms.KitchenForm();
                            form.Show();
                            break;
                        default:
                            MessageBox.Show("Произошла непредвиденая ошибка. Приложение будет закрыто", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Application.Exit();
                            break;
                    }
                }
            }
            else if (!loginSet && !passwordSet)
                ErrorsViewWrapper.ShowError("Введите логин и пароль");
            else if(loginSet && !passwordSet)
                ErrorsViewWrapper.ShowError("Введите пароль");
            else
                ErrorsViewWrapper.ShowError("Введите логин");
        }
    }
}

using SmartFood.Core;
using SmartFood.Core.Constants;
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

            comboBoxRole.Items.Add(new ComboBoxItem(1, GeneralConstants.ADMINISTRATOR));
            comboBoxRole.Items.Add(new ComboBoxItem(2, GeneralConstants.OPERATOR));
            comboBoxRole.Items.Add(new ComboBoxItem(3, GeneralConstants.COOK));
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
                            ErrorsViewWrapper.ShowError(ErrorTexts.UNEXPEXTED_ERROR);
                            Application.Exit();
                            break;
                    }
                }
            }
            else if (!loginSet && !passwordSet)
                ErrorsViewWrapper.ShowError(ErrorTexts.ENTER_LOGIN_AND_PASSWORD);
            else if(loginSet && !passwordSet)
                ErrorsViewWrapper.ShowError(ErrorTexts.ENTER_PASSWORD);
            else
                ErrorsViewWrapper.ShowError(ErrorTexts.ENTER_LOGIN);
        }
    }
}

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

            comboBoxRole.Items.Add(new ComboBoxItem(Convert.ToInt64(EAcountType.Admin), AcountTypesCore.Types[EAcountType.Admin]));
            comboBoxRole.Items.Add(new ComboBoxItem(Convert.ToInt64(EAcountType.Operator), AcountTypesCore.Types[EAcountType.Operator]));
            comboBoxRole.Items.Add(new ComboBoxItem(Convert.ToInt64(EAcountType.Cook), AcountTypesCore.Types[EAcountType.Cook]));
            comboBoxRole.SelectedIndex = 0;
            this.KeyPreview = true;
            this.KeyDown += LoginForm_KeyDown;
            CoreBase.Init();
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                LoginButton_Click(this, null);
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

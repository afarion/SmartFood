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
    public partial class CashierForm : Form
    {
        public static CashierForm instance;
        public CashierForm()
        {
            InitializeComponent();
            instance = this;
        }

        private void CashierForm_Shown(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            Point tmpPoint = new Point();

            tmpPoint.X = this.Location.X + 10;
            tmpPoint.Y = this.Location.Y + 10;
            CreateOrderButton.Location = tmpPoint;

            tmpPoint.X = this.Size.Width - SearchGroupBox.Size.Width - 10;
            tmpPoint.Y = this.Location.Y + 10;
            SearchGroupBox.Location = tmpPoint;

            tmpPoint.X = this.Location.X + 10;
            tmpPoint.Y = SearchGroupBox.Size.Height + SearchGroupBox.Location.Y;
            int tmpWidth = this.Size.Width - 20;
            int tmpHeight = this.Size.Height - SearchGroupBox.Location.Y - SearchGroupBox.Size.Height - 50;
            OrdersGridView.SetBounds(tmpPoint.X, tmpPoint.Y, tmpWidth, tmpHeight);
            this.Refresh();
        }

        private void CashierForm_Move(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
        }

        private void CashierForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            OrderForm modalForm = new OrderForm();
            modalForm.StartPosition = FormStartPosition.CenterScreen;
            this.Enabled = false;
            modalForm.Show();
        }
    }
}

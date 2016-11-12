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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Shown(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            Point tmpPoint = new Point();

            tmpPoint.X = this.Location.X + 10;
            tmpPoint.Y = this.Location.Y + 10;
            int tmpWidth = this.Size.Width - 30;
            int tmpHeight = this.Size.Height - 50;
            tabControl.SetBounds(tmpPoint.X, tmpPoint.Y, tmpWidth, tmpHeight);

            #region redrawing tabPageConsumables
            tmpPoint.X = tabPageConsumables.Width - buttonDelete.Width - 10;
            tmpPoint.Y = tabPageConsumables.Height- buttonDelete.Height - 10;
            buttonDelete.Location = tmpPoint;

            tmpPoint.X = buttonDelete.Location.X - buttonAddConsumble.Width - 10;
            buttonAddConsumble.Location = tmpPoint;

            tmpWidth = tabPageConsumables.Width - 30;
            tmpHeight = buttonDelete.Location.Y - buttonDelete.Height - 20;
            tmpPoint.X = tabPageConsumables.Left + 10;
            tmpPoint.Y = tabPageConsumables.Top + 10;
            dataGridViewConsumbles.SetBounds(tmpPoint.X, tmpPoint.Y, tmpWidth, tmpHeight);
            #endregion

            #region redrawing tabPageArrivalAndWriteOff
            tmpPoint.X = tabPageConsumables.Width - buttonArrivial.Width - 10;
            tmpPoint.Y = tabPageConsumables.Height - buttonArrivial.Height - 10;
            buttonArrivial.Location = tmpPoint;

            tmpPoint.X = buttonArrivial.Location.X - buttonWriteOff.Width - 10;
            buttonWriteOff.Location = tmpPoint;

            tmpWidth = tabPageConsumables.Width - 30;
            tmpHeight = buttonArrivial.Location.Y - buttonArrivial.Height - 20;
            tmpPoint.X = tabPageConsumables.Left + 10;
            tmpPoint.Y = tabPageConsumables.Top + 10;
            dataGridViewArrival.SetBounds(tmpPoint.X, tmpPoint.Y, tmpWidth, tmpHeight);
            #endregion


            this.Refresh();
        }

        private void AdminForm_Move(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void groupBoxCurrentReport_Enter(object sender, EventArgs e)
        {

        }

        private void labelSummForToday_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelDiffForToday_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

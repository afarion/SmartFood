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
using System.Threading;
using System.Windows.Forms;

namespace SmartFood.Forms
{
    public partial class AdminForm : Form
    {
        public static AdminForm instance;
        private static bool updateFlag = false;

        public AdminForm()
        {
            InitializeComponent();
            tabPageReports.Enter += new System.EventHandler(this.TabPageReports_Enter);
            tabPageArrivalAndWriteOff.Enter += new System.EventHandler(this.TabPageArrivalAndWriteOff_Enter);
            tabPageConsumables.Enter += new System.EventHandler(this.TabPageConsumables_Enter);
            tabPageGoods.Enter += new System.EventHandler(this.TabPageGoods_Enter);
            tabPageAcounts.Enter += new System.EventHandler(this.TabPageAcounts_Enter);
            tabPageClients.Enter += new System.EventHandler(this.TabPageClients_Enter);
            tabPageEmployees.Enter += new System.EventHandler(this.TabPageEmployees_Enter);
            tabPageSuppliers.Enter += new System.EventHandler(this.TabPageSuppliers_Enter);
            instance = this;


            dataGridViewConsumbles.Columns.Add(UIConstans.NEW_COLUMN_ID, GeneralConstants.ID);
            dataGridViewConsumbles.Columns.Add(UIConstans.NEW_COLUMN_NAME, GeneralConstants.NAME);
            dataGridViewConsumbles.Columns.Add(UIConstans.NEW_COLUMN_PRICE, GeneralConstants.PRICE);
            dataGridViewConsumbles.Columns.Add(UIConstans.NEW_COLUMN_AMOUNT, GeneralConstants.AMOUNT);

            var column = new DataGridViewComboBoxColumn();
            column.HeaderText = GeneralConstants.MEASURING;
            dataGridViewConsumbles.Columns.Add(column);

            column = new DataGridViewComboBoxColumn();
            column.HeaderText = GeneralConstants.TYPE;
            dataGridViewConsumbles.Columns.Add(column);

            column = new DataGridViewComboBoxColumn();            
            column.HeaderText = GeneralConstants.CATEGORY;
            dataGridViewConsumbles.Columns.Add(column);

            column = new DataGridViewComboBoxColumn();
            column.HeaderText = GeneralConstants.VISIBILITY;
            dataGridViewConsumbles.Columns.Add(column);

            dataGridViewConsumbles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewConsumbles.AllowUserToAddRows = false;
            dataGridViewConsumbles.Columns[0].ReadOnly = true;
            dataGridViewConsumbles.Columns[2].ReadOnly = true;
            dataGridViewConsumbles.RowHeadersVisible = false;
            dataGridViewConsumbles.EditMode = DataGridViewEditMode.EditOnEnter;
        }

        private void AdminForm_Shown(object sender, EventArgs e)
        {
            Point tmpPoint = new Point();
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            tmpPoint.X = this.Location.X + 10;
            tmpPoint.Y = this.Location.Y + 10;
            int tmpWidth = this.Size.Width - 30;
            int tmpHeight = this.Size.Height - 50;
            tabControl.SetBounds(tmpPoint.X, tmpPoint.Y, tmpWidth, tmpHeight);
            TabPageConsumables_Enter(this, null);
            this.Refresh();
            UpdateDataGridViewConsumbles();
        }

        private void TabPageSuppliers_Enter(object sender, EventArgs e)
        {
            Point tmpPoint = new Point();

            tmpPoint.X = tabPageConsumables.Width - buttonAddSupplier.Width - 10;
            tmpPoint.Y = tabPageConsumables.Height - buttonAddSupplier.Height - 10;
            buttonAddSupplier.Location = tmpPoint;

            tmpPoint.X = buttonAddSupplier.Location.X - buttoDeleteSupplier.Width - 10;
            buttoDeleteSupplier.Location = tmpPoint;

            tmpPoint.X = buttoDeleteSupplier.Location.X - buttonEditSupplier.Width - 10;
            buttonEditSupplier.Location = tmpPoint;

            int tmpWidth = tabPageConsumables.Width - 24;
            int tmpHeight = buttonEditSupplier.Location.Y - buttonEditSupplier.Height - 20;
            tmpPoint.X = tabPageConsumables.Left + 10;
            tmpPoint.Y = tabPageConsumables.Top + 10;
            dataGridViewSuppliers.SetBounds(tmpPoint.X, tmpPoint.Y, tmpWidth, tmpHeight);
            this.Refresh();
        }

        private void TabPageEmployees_Enter(object sender, EventArgs e)
        {
            Point tmpPoint = new Point();

            tmpPoint.X = tabPageConsumables.Width - buttonAddEmploye.Width - 10;
            tmpPoint.Y = tabPageConsumables.Height - buttonAddEmploye.Height - 10;
            buttonAddEmploye.Location = tmpPoint;

            tmpPoint.X = buttonAddEmploye.Location.X - buttonDeleteEmploye.Width - 10;
            buttonDeleteEmploye.Location = tmpPoint;

            tmpPoint.X = buttonDeleteEmploye.Location.X - buttonEditEmploye.Width - 10;
            buttonEditEmploye.Location = tmpPoint;

            int tmpWidth = tabPageConsumables.Width - 24;
            int tmpHeight = buttonDeleteEmploye.Location.Y - buttonDeleteEmploye.Height - 20;
            tmpPoint.X = tabPageConsumables.Left + 10;
            tmpPoint.Y = tabPageConsumables.Top + 10;
            dataGridViewEmployees.SetBounds(tmpPoint.X, tmpPoint.Y, tmpWidth, tmpHeight);
            this.Refresh();
        }

        private void TabPageClients_Enter(object sender, EventArgs e)
        {
            Point tmpPoint = new Point();

            tmpPoint.X = tabPageConsumables.Width - buttonAddClient.Width - 10;
            tmpPoint.Y = tabPageConsumables.Height - buttonAddClient.Height - 10;
            buttonAddClient.Location = tmpPoint;

            tmpPoint.X = buttonAddClient.Location.X - buttonEditClient.Width - 10;
            buttonEditClient.Location = tmpPoint;

            int tmpWidth = tabPageConsumables.Width - 24;
            int tmpHeight = buttonAddClient.Location.Y - buttonAddClient.Height - 20;
            tmpPoint.X = tabPageConsumables.Left + 10;
            tmpPoint.Y = tabPageConsumables.Top + 10;
            dataGridViewClients.SetBounds(tmpPoint.X, tmpPoint.Y, tmpWidth, tmpHeight);
            this.Refresh();
        }

        private void TabPageGoods_Enter(object sender, EventArgs e)
        {
            Point tmpPoint = new Point();

            tmpPoint.X = tabPageConsumables.Width - buttonAddGood.Width - 10;
            tmpPoint.Y = tabPageConsumables.Height - buttonAddGood.Height - 10;
            buttonAddGood.Location = tmpPoint;

            tmpPoint.X = buttonAddGood.Location.X - buttonDeleteGood.Width - 10;
            buttonDeleteGood.Location = tmpPoint;

            tmpPoint.X = buttonDeleteGood.Location.X - buttonEditGood.Width - 10;
            buttonEditGood.Location = tmpPoint;

            int tmpWidth = tabPageConsumables.Width - 24;
            int tmpHeight = buttonDeleteGood.Location.Y - buttonDeleteGood.Height - 20;
            tmpPoint.X = tabPageConsumables.Left + 10;
            tmpPoint.Y = tabPageConsumables.Top + 10;
            dataGridViewGoods.SetBounds(tmpPoint.X, tmpPoint.Y, tmpWidth, tmpHeight);
            this.Refresh();
        }

        private void TabPageAcounts_Enter(object sender, EventArgs e)
        {
            Point tmpPoint = new Point();

            tmpPoint.X = tabPageConsumables.Width - buttonAddAcount.Width - 10;
            tmpPoint.Y = tabPageConsumables.Height - buttonAddAcount.Height - 10;
            buttonAddAcount.Location = tmpPoint;

            tmpPoint.X = buttonAddAcount.Location.X - buttonDeleteAcount.Width - 10;
            buttonDeleteAcount.Location = tmpPoint;

            tmpPoint.X = buttonDeleteAcount.Location.X - buttonEditAcount.Width - 10;
            buttonEditAcount.Location = tmpPoint;

            int tmpWidth = tabPageConsumables.Width - 24;
            int tmpHeight = buttonDeleteAcount.Location.Y - buttonDeleteAcount.Height - 20;
            tmpPoint.X = tabPageConsumables.Left + 10;
            tmpPoint.Y = tabPageConsumables.Top + 10;
            dataGridViewAcount.SetBounds(tmpPoint.X, tmpPoint.Y, tmpWidth, tmpHeight);
            this.Refresh();
        }

        private void TabPageReports_Enter(object sender, EventArgs e)
        {
            Point tmpPoint = new Point();

            tmpPoint.X = tabPageConsumables.Width - groupBoxReport.Width - 10;
            tmpPoint.Y = tabPageConsumables.Top + 10;
            groupBoxReport.Location = tmpPoint;
            groupBoxReport.Height = tabPageConsumables.Height - 50;
            tmpPoint.X = groupBoxReport.Width - buttonPrint.Width - 10;
            tmpPoint.Y = groupBoxReport.Height - buttonPrint.Height - 10;
            buttonPrint.Location = tmpPoint;

            tmpPoint.X = buttonPrint.Location.X - buttonSave.Width - 10;
            buttonSave.Location = tmpPoint;
            comboBoxType.Width = monthCalendarFrom.Width;

            int tmpHeight = tabPageConsumables.Height - 50;
            tmpPoint.X = tabPageConsumables.Left + 10;
            tmpPoint.Y = tabPageConsumables.Top + 10;
            groupBoxCurrentReport.Location = tmpPoint;
            groupBoxCurrentReport.Height = tmpHeight;


            tmpPoint.X = groupBoxCurrentReport.Location.X + groupBoxCurrentReport.Width + 10;
            tmpPoint.Y = tabPageConsumables.Top + 10;
            int tmpWidth = groupBoxReport.Location.X - tmpPoint.X - 10;
            groupBoxCostPrice.Location = tmpPoint;
            groupBoxCostPrice.Width = tmpWidth;
            groupBoxCostPrice.Height = tmpHeight;

            tmpPoint.X = 10;
            tmpPoint.Y = groupBoxCurrentReport.Height - buttonClear.Height - 10;
            buttonClear.Location = tmpPoint;

            tmpPoint.X = buttonClear.Location.X + buttonClear.Width + 10;
            buttonAddAllConsumbles.Location = tmpPoint;

            tmpPoint.X = groupBoxCostPrice.Width - buttonSelectConsumble.Width - 10;
            buttonSelectConsumble.Location = tmpPoint;

            tmpPoint.X = buttonAddAllConsumbles.Location.X + buttonAddAllConsumbles.Width + 10;
            tmpWidth = buttonSelectConsumble.Location.X - tmpPoint.X - 10;
            comboBoxSelectConsumble.Location = tmpPoint;
            comboBoxSelectConsumble.Width = tmpWidth;

            tmpWidth = groupBoxCostPrice.Width - 20;
            tmpHeight = buttonAddAllConsumbles.Location.Y - 30;
            tmpPoint.X = 10;
            tmpPoint.Y = 20;
            dataGridViewCostPrice.SetBounds(tmpPoint.X, tmpPoint.Y, tmpWidth, tmpHeight);
            this.Refresh();
        }

        private void TabPageConsumables_Enter(object sender, EventArgs e)
        {
            Point tmpPoint = new Point();

            tmpPoint.X = tabPageConsumables.Width - buttonAddConsumble.Width - 10;
            tmpPoint.Y = tabPageConsumables.Height - buttonAddConsumble.Height - 10;
            buttonAddConsumble.Location = tmpPoint;

            tmpPoint.X = buttonAddConsumble.Location.X - buttonDelete.Width - 10;
            buttonDelete.Location = tmpPoint;

            int tmpWidth = tabPageConsumables.Width - 24;
            int tmpHeight = buttonDelete.Location.Y - buttonDelete.Height - 20;
            tmpPoint.X = tabPageConsumables.Left + 10;
            tmpPoint.Y = tabPageConsumables.Top + 10;
            dataGridViewConsumbles.SetBounds(tmpPoint.X, tmpPoint.Y, tmpWidth, tmpHeight);

            tmpPoint.Y = tabPageConsumables.Height - buttonAddConsumble.Height - 10;
            buttonConsumbleTypes.Size = buttonAddConsumble.Size;
            buttonConsumbleTypes.Location = tmpPoint;

            tmpPoint.X = buttonConsumbleTypes.Location.X + buttonConsumbleTypes.Width + 10;
            buttonConsumbleCategories.Size = buttonAddConsumble.Size;
            buttonConsumbleCategories.Location = tmpPoint;

            this.Refresh();
        }

        private void UpdateDataGridViewConsumbles()
        {
            new Thread(() =>
            {
                try
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        dataGridViewConsumbles.Rows.Clear();
                        
                        foreach (Consumble consumble in ConsumblesCore.Consumbles.items)
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.Cells.Add(new DataGridViewTextBoxCell()
                            {
                                Value = consumble.id
                            });
                            row.Cells.Add(new DataGridViewTextBoxCell()
                            {
                                Value = consumble.name
                            });
                            row.Cells.Add(new DataGridViewTextBoxCell()
                            {
                                Value = consumble.price
                            });
                            row.Cells.Add(new DataGridViewTextBoxCell()
                            {
                                Value = consumble.amount
                            });

                            DataGridViewComboBoxCell cell = new DataGridViewComboBoxCell();
                            foreach (var measure in MeasuresCore.Measures.items)
                                cell.Items.Add(measure.name);
                            cell.Value = MeasuresCore.Measures.GetName(consumble.id_unit);
                            row.Cells.Add(cell);

                            cell = new DataGridViewComboBoxCell();
                            foreach (var type in ConsumblesTypesCore.ConsumbleTypes.items)
                                cell.Items.Add(type.name);
                            cell.Value = ConsumblesTypesCore.ConsumbleTypes.GetName(consumble.id_type);
                            row.Cells.Add(cell);

                            cell = new DataGridViewComboBoxCell();
                            try
                            {
                                ConsumbleCategorieCore.consumbleCategories.items.Clear();
                            }
                            catch { }
                            ConsumbleCategorieCore.GetConsumbleCategorie(consumble.id_type.ToString());
                            foreach (var consumbleCategorie in ConsumbleCategorieCore.consumbleCategories.items)
                                cell.Items.Add(consumbleCategorie.name);
                            cell.Value = ConsumbleCategorieCore.consumbleCategories.GetName(consumble.id_category);
                            row.Cells.Add(cell);

                            cell = new DataGridViewComboBoxCell();
                            cell.Items.Add(GeneralConstants.YES);
                            cell.Items.Add(GeneralConstants.NO);
                            cell.Value = Convert.ToBoolean(consumble.visible) ? GeneralConstants.YES : GeneralConstants.NO;
                            row.Cells.Add(cell);

                            dataGridViewConsumbles.Rows.Add(row);
                            updateFlag = true;

                            dataGridViewConsumbles.CellValueChanged += DataGridViewConsumbles_CellValueChanged;
                            this.Refresh();
                        }
                    });
                }
                catch { }
            }).Start();
        }

        private void DataGridViewConsumbles_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //if (updateFlag)
            //{
            //    DataGridViewCellCollection collection = dataGridViewConsumbles.Rows[e.RowIndex].Cells;
            //    ConsumbleCategorieCore.EditConsumbleCategorie(collection[0].Value.ToString(), collection[1].Value.ToString(), collection[2].Value.ToString() == GeneralConstants.YES ? "1" : "0", ConsumblesTypesCore.consumbleTypes.GetID(collection[3].Value.ToString()));
            //    dataGridViewConsumbleCategories.CellValueChanged -= DataGridViewConsumbleCategories_CellValueChanged;
            //    updateFlag = false;
            //    selectColumn = e.ColumnIndex;
            //    selectedRow = e.RowIndex;
            //    DownloadConsumbleCategories();
            //}
        }

        private void TabPageArrivalAndWriteOff_Enter(object sender, EventArgs e)
        {
            Point tmpPoint = new Point();

            tmpPoint.X = tabPageConsumables.Width - buttonArrivial.Width - 10;
            tmpPoint.Y = tabPageConsumables.Height - buttonArrivial.Height - 10;
            buttonArrivial.Location = tmpPoint;

            tmpPoint.X = buttonArrivial.Location.X - buttonWriteOff.Width - 10;
            buttonWriteOff.Location = tmpPoint;

            int tmpWidth = tabPageConsumables.Width / 2 - 20;
            int tmpHeight = buttonArrivial.Location.Y - buttonArrivial.Height - 20;
            tmpPoint.X = tabPageConsumables.Left + 10;
            tmpPoint.Y = tabPageConsumables.Top + 10;

            dataGridViewArrival.SetBounds(tmpPoint.X, tmpPoint.Y, tmpWidth, tmpHeight);
            tmpPoint.X = tabPageConsumables.Width / 2 + 10;
            dataGridViewWriteOff.SetBounds(tmpPoint.X, tmpPoint.Y, tmpWidth, tmpHeight);
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

        private void buttonEditAcount_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddConsumble_Click(object sender, EventArgs e)
        {
            NewConsumbleForm modalForm = new NewConsumbleForm();
            modalForm.StartPosition = FormStartPosition.CenterScreen;
            this.Enabled = false;
            modalForm.Show();
        }

        private void buttonArrivial_Click(object sender, EventArgs e)
        {
            ConsumbleArrivalForm modalForm = new ConsumbleArrivalForm();
            modalForm.StartPosition = FormStartPosition.CenterScreen;
            this.Enabled = false;
            modalForm.Show();
        }

        private void buttonWriteOff_Click(object sender, EventArgs e)
        {
            ConsumbleWriteOffForm modalForm = new ConsumbleWriteOffForm();
            modalForm.StartPosition = FormStartPosition.CenterScreen;
            this.Enabled = false;
            modalForm.Show();
        }

        private void buttonEditGood_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddGood_Click(object sender, EventArgs e)
        {
            GoodDetailsForm modalForm = new GoodDetailsForm();
            modalForm.StartPosition = FormStartPosition.CenterScreen;
            this.Enabled = false;
            modalForm.Show();
        }

        private void buttonAddAcount_Click(object sender, EventArgs e)
        {
            AcountDetails modalForm = new AcountDetails();
            modalForm.StartPosition = FormStartPosition.CenterScreen;
            this.Enabled = false;
            modalForm.Show();
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            ClientDetailsForm modalForm = new ClientDetailsForm();
            modalForm.StartPosition = FormStartPosition.CenterScreen;
            this.Enabled = false;
            modalForm.Show();
        }

        private void buttonAddEmploye_Click(object sender, EventArgs e)
        {
            EmployeDetailsForm modalForm = new EmployeDetailsForm();
            modalForm.StartPosition = FormStartPosition.CenterScreen;
            this.Enabled = false;
            modalForm.Show();
        }

        private void buttonAddSupplier_Click(object sender, EventArgs e)
        {
            SupplierDetailsForm modalForm = new SupplierDetailsForm();
            modalForm.StartPosition = FormStartPosition.CenterScreen;
            this.Enabled = false;
            modalForm.Show();
        }

        private void buttonConsumbleCategories_Click(object sender, EventArgs e)
        {
            ConsumbleCategorieForm modalForm = new ConsumbleCategorieForm();
            modalForm.StartPosition = FormStartPosition.CenterScreen;
            this.Enabled = false;
            modalForm.Show();
        }

        private void buttonConsumbleTypes_Click(object sender, EventArgs e)
        {
            ConsumbleTypeForm modalForm = new ConsumbleTypeForm();
            modalForm.StartPosition = FormStartPosition.CenterScreen;
            this.Enabled = false;
            modalForm.Show();
        }
    }
}

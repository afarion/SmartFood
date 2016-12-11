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

            #region dataGridViewConsumbles
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

            dataGridViewConsumbles.Columns.Add(UIConstans.NEW_COLUMN_WASTE, GeneralConstants.WASTE);

            column = new DataGridViewComboBoxColumn();
            column.HeaderText = GeneralConstants.VISIBILITY;
            dataGridViewConsumbles.Columns.Add(column);

            dataGridViewConsumbles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewConsumbles.AllowUserToAddRows = false;
            dataGridViewConsumbles.Columns[0].ReadOnly = true;
            dataGridViewConsumbles.Columns[2].ReadOnly = true;
            dataGridViewConsumbles.Columns[3].ReadOnly = true;
            dataGridViewConsumbles.RowHeadersVisible = false;
            dataGridViewConsumbles.EditMode = DataGridViewEditMode.EditOnEnter;
            #endregion

            #region dataGridViewSuppliers
            dataGridViewSuppliers.Columns.Add(UIConstans.NEW_COLUMN_ID, GeneralConstants.ID);
            dataGridViewSuppliers.Columns.Add(UIConstans.NEW_COLUMN_NAME, GeneralConstants.NAME);
            dataGridViewSuppliers.Columns.Add(UIConstans.NEW_COLUMN_PHONE, GeneralConstants.PHONE);
            dataGridViewSuppliers.Columns.Add(UIConstans.NEW_COLUMN_EMEIL, GeneralConstants.EMEIL);
            dataGridViewSuppliers.Columns.Add(UIConstans.NEW_COLUMN_SKYPE, GeneralConstants.SKYPE);
            dataGridViewSuppliers.Columns.Add(UIConstans.NEW_COLUMN_NOTES, GeneralConstants.NOTES);

            column = new DataGridViewComboBoxColumn();
            column.DataSource = new List<string>() { GeneralConstants.YES, GeneralConstants.NO };
            column.HeaderText = GeneralConstants.VISIBILITY;
            dataGridViewSuppliers.Columns.Add(column);

            dataGridViewSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSuppliers.AllowUserToAddRows = false;
            dataGridViewSuppliers.Columns[0].ReadOnly = true;
            dataGridViewSuppliers.RowHeadersVisible = false;
            dataGridViewSuppliers.EditMode = DataGridViewEditMode.EditOnEnter;
            #endregion

            #region dataGridViewEmployees
            dataGridViewEmployees.Columns.Add(UIConstans.NEW_COLUMN_ID, GeneralConstants.ID);
            dataGridViewEmployees.Columns.Add(UIConstans.NEW_COLUMN_FIRST_NAME, GeneralConstants.FIRST_NAME);
            dataGridViewEmployees.Columns.Add(UIConstans.NEW_COLUMN_LAST_NAME, GeneralConstants.LAST_NAME);

            column = new DataGridViewComboBoxColumn();
            column.DataSource = EmployeesTypesCore.EmployeesTypes.ToList();
            column.HeaderText = GeneralConstants.ID_TYPE;
            dataGridViewEmployees.Columns.Add(column);

            dataGridViewEmployees.Columns.Add(UIConstans.NEW_COLUMN_PHONE, GeneralConstants.PHONE);
            dataGridViewEmployees.Columns.Add(UIConstans.NEW_COLUMN_PHONE_EX, GeneralConstants.PHONE_EX);
            dataGridViewEmployees.Columns.Add(UIConstans.NEW_COLUMN_SKYPE, GeneralConstants.SKYPE);
            dataGridViewEmployees.Columns.Add(UIConstans.NEW_COLUMN_ADRESS, GeneralConstants.ADRESS);
            dataGridViewEmployees.Columns.Add(UIConstans.NEW_COLUMN_EMEIL, GeneralConstants.EMEIL);
            dataGridViewEmployees.Columns.Add(UIConstans.NEW_COLUMN_BIRTHDAY, GeneralConstants.BIRTHDAY);
            dataGridViewEmployees.Columns.Add(UIConstans.NEW_COLUMN_COMMENT, GeneralConstants.COMMENT);

            column = new DataGridViewComboBoxColumn();
            column.DataSource = new List<string>() { GeneralConstants.YES, GeneralConstants.NO };
            column.HeaderText = GeneralConstants.VISIBILITY;
            dataGridViewEmployees.Columns.Add(column);

            dataGridViewEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEmployees.AllowUserToAddRows = false;
            dataGridViewEmployees.Columns[0].ReadOnly = true;
            dataGridViewEmployees.RowHeadersVisible = false;
            dataGridViewEmployees.EditMode = DataGridViewEditMode.EditOnEnter;
            #endregion
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

            int tmpWidth = tabPageConsumables.Width - 24;
            int tmpHeight = buttonAddSupplier.Location.Y - buttonAddSupplier.Height - 20;
            tmpPoint.X = tabPageConsumables.Left + 10;
            tmpPoint.Y = tabPageConsumables.Top + 10;
            dataGridViewSuppliers.SetBounds(tmpPoint.X, tmpPoint.Y, tmpWidth, tmpHeight);
            UpdateDataGridViewSuppliers();
            this.Refresh();
        }

        public void UpdateDataGridViewSuppliers()
        {
            new Thread(() =>
            {
                try
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        dataGridViewSuppliers.Rows.Clear();
                        foreach (Supplier supplier in SuppliersCore.Suppliers.items)
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            dataGridViewSuppliers.Rows.Add(supplier.id, supplier.name, supplier.phone, supplier.email, supplier.skype, supplier.notes, Convert.ToBoolean(supplier.visible) ? GeneralConstants.YES : GeneralConstants.NO);
                            dataGridViewSuppliers.CellValueChanged += DataGridViewSuppliers_CellValueChanged; ;
                            updateFlag = true;
                        }
                    });
                }
                catch { }
            }).Start();
        }

        private void DataGridViewSuppliers_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (updateFlag)
            {
                DataGridViewCellCollection collection = dataGridViewSuppliers.Rows[e.RowIndex].Cells;
                ConsumbleCategorieCore.GetConsumbleCategorie(ConsumblesTypesCore.ConsumbleTypes.GetID(collection[5].Value.ToString()).ToString());
                SuppliersCore.EditSuplier(collection[0].Value.ToString(),
                    collection[1].Value.ToString(),
                    collection[2].Value.ToString(),
                    collection[3].Value.ToString(),
                    collection[4].Value.ToString(),
                    collection[5].Value.ToString(),
                    collection[6].Value.ToString() == GeneralConstants.YES ? "1" : "0");
                dataGridViewSuppliers.CellValueChanged -= DataGridViewSuppliers_CellValueChanged;
                updateFlag = false;
                dataGridViewConsumbles.Rows.Clear();
                SuppliersCore.GetSuppliers();
                UpdateDataGridViewConsumbles();
            }
        }

        private void TabPageEmployees_Enter(object sender, EventArgs e)
        {
            Point tmpPoint = new Point();

            tmpPoint.X = tabPageConsumables.Width - buttonAddEmploye.Width - 10;
            tmpPoint.Y = tabPageConsumables.Height - buttonAddEmploye.Height - 10;
            buttonAddEmploye.Location = tmpPoint;

            int tmpWidth = tabPageConsumables.Width - 24;
            int tmpHeight = buttonAddEmploye.Location.Y - buttonAddEmploye.Height - 20;
            tmpPoint.X = tabPageConsumables.Left + 10;
            tmpPoint.Y = tabPageConsumables.Top + 10;
            dataGridViewEmployees.SetBounds(tmpPoint.X, tmpPoint.Y, tmpWidth, tmpHeight);
            UpdateDataGridViewEmployees();
            this.Refresh();
        }

        public void UpdateDataGridViewEmployees()
        {
            new Thread(() =>
            {
                try
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        dataGridViewEmployees.Rows.Clear();
                        EmployeesCore.GetEmplyees();
                        foreach (Employee employee in EmployeesCore.Emplyees.items)
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            dataGridViewEmployees.Rows.Add(employee.id, employee.first_name, employee.last_name, EmployeesTypesCore.EmployeesTypes.GetName(employee.id_type), employee.phone, employee.phone_ex, employee.skype, employee.address, employee.email, employee.birthday, employee.comment, Convert.ToBoolean(employee.visible) ? GeneralConstants.YES : GeneralConstants.NO);
                            dataGridViewEmployees.CellValueChanged += DataGridViewEmployees_CellValueChanged;
                            updateFlag = true;
                        }
                    });
                }
                catch { }
            }).Start();
        }

        private void DataGridViewEmployees_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (updateFlag)
            {
                DataGridViewCellCollection collection = dataGridViewEmployees.Rows[e.RowIndex].Cells;
                EmployeesCore.EditEmplyee(collection[0].Value.ToString(),
                    collection[1].Value.ToString(),
                    collection[2].Value.ToString(),
                    EmployeesTypesCore.EmployeesTypes.GetID(collection[3].Value.ToString()).ToString(),
                    collection[4].Value.ToString(),
                    collection[5].Value.ToString(),
                    collection[6].Value.ToString(),
                    collection[7].Value.ToString(),
                    collection[8].Value.ToString(),
                    collection[9].Value.ToString(),
                    collection[10].Value.ToString(),
                    collection[11].Value.ToString() == GeneralConstants.YES ? "1" : "0");
                dataGridViewEmployees.CellValueChanged -= DataGridViewSuppliers_CellValueChanged;
                updateFlag = false;
                dataGridViewEmployees.Rows.Clear();
                EmployeesCore.GetEmplyees();
                UpdateDataGridViewEmployees();
            }
        }

        private void TabPageClients_Enter(object sender, EventArgs e)
        {
            Point tmpPoint = new Point();

            tmpPoint.X = tabPageConsumables.Width - buttonAddClient.Width - 10;
            tmpPoint.Y = tabPageConsumables.Height - buttonAddClient.Height - 10;
            buttonAddClient.Location = tmpPoint;

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

            int tmpWidth = tabPageConsumables.Width - 24;
            int tmpHeight = buttonAddGood.Location.Y - buttonAddGood.Height - 20;
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

            int tmpWidth = tabPageConsumables.Width - 24;
            int tmpHeight = buttonAddConsumble.Location.Y - buttonAddConsumble.Height - 20;
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

        public void UpdateDataGridViewConsumbles()
        {
            new Thread(() =>
            {
                try
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        dataGridViewConsumbles.Rows.Clear();
                        ConsumblesCore.GetConsumbles();
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
                            {
                                if(type.visible!=0)
                                    cell.Items.Add(type.name);
                            }
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

                            row.Cells.Add(new DataGridViewTextBoxCell()
                            {
                                Value = consumble.waste_pct
                            });

                            cell = new DataGridViewComboBoxCell();
                            cell.Items.Add(GeneralConstants.YES);
                            cell.Items.Add(GeneralConstants.NO);
                            cell.Value = Convert.ToBoolean(consumble.visible) ? GeneralConstants.YES : GeneralConstants.NO;
                            row.Cells.Add(cell);

                            dataGridViewConsumbles.Rows.Add(row);
                            updateFlag = true;

                            dataGridViewConsumbles.CellValueChanged += DataGridViewConsumbles_CellValueChanged;
                            //this.Refresh();
                        }
                    });
                }
                catch { }
            }).Start();
        }

        private void DataGridViewConsumbles_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (updateFlag)
            {
                DataGridViewCellCollection collection = dataGridViewConsumbles.Rows[e.RowIndex].Cells;
                int waste = 0;
                bool correctWaste = false;
                try
                {
                    waste = Convert.ToInt32(collection[7].Value);
                    if (waste < 100 && waste >= 0)
                        correctWaste = true;
                    else
                        ErrorsViewWrapper.ShowError(ErrorTexts.INCORRECT_WASTE);
                }
                catch
                {
                    ErrorsViewWrapper.ShowError(ErrorTexts.INCORRECT_WASTE);
                }
                if (correctWaste)
                {
                    ConsumbleCategorieCore.GetConsumbleCategorie(ConsumblesTypesCore.ConsumbleTypes.GetID(collection[5].Value.ToString()).ToString());
                    ConsumblesCore.EditConsumble(collection[0].Value.ToString(),
                        collection[1].Value.ToString(),
                        collection[8].Value.ToString() == GeneralConstants.YES ? "1" : "0",
                        ConsumblesTypesCore.ConsumbleTypes.GetID(collection[5].Value.ToString()),
                        ConsumbleCategorieCore.consumbleCategories.GetID(collection[6].Value.ToString()),
                        MeasuresCore.Measures.GetID(collection[4].Value.ToString()),
                        Convert.ToInt32(collection[7].Value));
                    int selectColumn = e.ColumnIndex;
                    int selectedRow = e.RowIndex;
                    ConsumblesCore.GetConsumbles();
                    try
                    {
                        dataGridViewConsumbles.CurrentCell = dataGridViewConsumbles.Rows[selectedRow].Cells[selectColumn];
                    }
                    catch { }
                }
                dataGridViewConsumbles.CellValueChanged -= DataGridViewConsumbles_CellValueChanged;
                updateFlag = false;
                dataGridViewConsumbles.Rows.Clear();
                UpdateDataGridViewConsumbles();
            }
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

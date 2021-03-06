﻿using DGVPrinterHelper;
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
using static SmartFood.Core.Constants.GeneralConstants;
using System.Drawing.Printing;

namespace SmartFood.Forms
{
    public partial class AdminForm : Form
    {
        public static AdminForm instance;
        private static bool updateFlag = false;
        private int goodRowSelected = 0;
        
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
            dataGridViewConsumbles.Columns.Add(UIConstans.NEW_COLUMN_NAME, GeneralConstants.TITLE);
            dataGridViewConsumbles.Columns.Add(UIConstans.NEW_COLUMN_PRICE, GeneralConstants.PRICE);
            dataGridViewConsumbles.Columns.Add(UIConstans.NEW_COLUMN_AMOUNT, GeneralConstants.AMOUNT);

            var column = new DataGridViewComboBoxColumn();
            column.HeaderText = GeneralConstants.MEASURING;
            column.Name = UIConstans.NEW_COLUMN_MEASURING;
            dataGridViewConsumbles.Columns.Add(column);

            column = new DataGridViewComboBoxColumn();
            column.HeaderText = GeneralConstants.TYPE;
            column.Name = UIConstans.NEW_COLUMN_TYPE;
            dataGridViewConsumbles.Columns.Add(column);

            column = new DataGridViewComboBoxColumn();            
            column.HeaderText = GeneralConstants.CATEGORY;
            column.Name = UIConstans.NEW_COLUMN_CATEGORY;
            dataGridViewConsumbles.Columns.Add(column);

            dataGridViewConsumbles.Columns.Add(UIConstans.NEW_COLUMN_WASTE, GeneralConstants.WASTE);

            column = new DataGridViewComboBoxColumn();
            column.HeaderText = GeneralConstants.VISIBILITY;
            column.Name = UIConstans.NEW_COLUMN_VISIBILITY;
            dataGridViewConsumbles.Columns.Add(column);

            dataGridViewConsumbles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewConsumbles.AllowUserToAddRows = false;
            dataGridViewConsumbles.Columns[0].ReadOnly = true;
            dataGridViewConsumbles.Columns[2].ReadOnly = true;
            dataGridViewConsumbles.Columns[3].ReadOnly = true;
            dataGridViewConsumbles.RowHeadersVisible = false;
            dataGridViewConsumbles.EditMode = DataGridViewEditMode.EditOnEnter;
            checkBoxPrint.Checked = true;
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

            #region dataGridViewAcount
            dataGridViewAcount.Columns.Add(UIConstans.NEW_COLUMN_ID, GeneralConstants.ID);
            dataGridViewAcount.Columns.Add(UIConstans.NEW_COLUMN_LOGIN, GeneralConstants.LOGIN);
            dataGridViewAcount.Columns.Add(UIConstans.NEW_COLUMN_PASSWORD, GeneralConstants.PASSWORD);

            column = new DataGridViewComboBoxColumn();
            column.DataSource = EmployeesCore.Emplyees.ToList();
            column.HeaderText = GeneralConstants.EMPLOYEE;
            dataGridViewAcount.Columns.Add(column);

            column = new DataGridViewComboBoxColumn();
            column.DataSource = AcountTypesCore.ToList();
            column.HeaderText = GeneralConstants.ACOUNT_TYPE;
            dataGridViewAcount.Columns.Add(column);

            column = new DataGridViewComboBoxColumn();
            column.DataSource = new List<string>() { GeneralConstants.YES, GeneralConstants.NO };
            column.HeaderText = GeneralConstants.VISIBILITY;
            dataGridViewAcount.Columns.Add(column);

            dataGridViewAcount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAcount.AllowUserToAddRows = false;
            dataGridViewAcount.Columns[0].ReadOnly = true;
            dataGridViewAcount.RowHeadersVisible = false;
            dataGridViewAcount.EditMode = DataGridViewEditMode.EditOnEnter;
            #endregion

            #region dataGridViewClients
            dataGridViewClients.Columns.Add(UIConstans.NEW_COLUMN_ID, GeneralConstants.ID);
            dataGridViewClients.Columns.Add(UIConstans.NEW_COLUMN_NAME, GeneralConstants.NAME);
            dataGridViewClients.Columns.Add(UIConstans.NEW_COLUMN_PHONE, GeneralConstants.PHONE);
            dataGridViewClients.Columns.Add(UIConstans.NEW_COLUMN_EMEIL, GeneralConstants.EMEIL);
            dataGridViewClients.Columns.Add(UIConstans.NEW_COLUMN_DISCOUNT_FLEX, GeneralConstants.DISCOUNT_FLEX);
            dataGridViewClients.Columns.Add(UIConstans.NEW_COLUMN_TOTAL_BALANCE, GeneralConstants.TOTAL_BALANCE);
            dataGridViewClients.Columns.Add(UIConstans.NEW_COLUMN_DISCOUNT_FIXED, GeneralConstants.DISCOUNT_FIXED);
            dataGridViewClients.Columns.Add(UIConstans.NEW_COLUMN_DISCOUNT_REASONE, GeneralConstants.DISCOUNT_REASONE);
            dataGridViewClients.Columns.Add(UIConstans.NEW_COLUMN_COMMENT, GeneralConstants.COMMENT);

            column = new DataGridViewComboBoxColumn();
            column.DataSource = new List<string>() { GeneralConstants.YES, GeneralConstants.NO };
            column.HeaderText = GeneralConstants.VISIBILITY;
            dataGridViewClients.Columns.Add(column);

            dataGridViewClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewClients.AllowUserToAddRows = false;
            dataGridViewClients.RowHeadersVisible = false;
            dataGridViewClients.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridViewClients.ReadOnly = true;
            #endregion

            #region dataGridViewArrivals
            dataGridViewArrival.Columns.Add(UIConstans.NEW_COLUMN_ID, GeneralConstants.ID);
            dataGridViewArrival.Columns.Add(UIConstans.NEW_COLUMN_CONSUMBLE, GeneralConstants.CONSUMBLE);
            dataGridViewArrival.Columns.Add(UIConstans.NEW_COLUMN_SUPPLIER, GeneralConstants.SUPPLIER);
            dataGridViewArrival.Columns.Add(UIConstans.NEW_COLUMN_EMPLOYEE, GeneralConstants.EMPLOYEE);
            dataGridViewArrival.Columns.Add(UIConstans.NEW_COLUMN_AMOUNT, GeneralConstants.AMOUNT);
            dataGridViewArrival.Columns.Add(UIConstans.NEW_COLUMN_PRICE, GeneralConstants.PRICE);
            dataGridViewArrival.Columns.Add(UIConstans.NEW_COLUMN_DATE, GeneralConstants.DATE);

            dataGridViewArrival.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewArrival.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewArrival.AllowUserToAddRows = false;
            dataGridViewArrival.RowHeadersVisible = false;
            dataGridViewArrival.ReadOnly = true;
            #endregion

            #region dataGridViewWriteOffs
            dataGridViewWriteOff.Columns.Add(UIConstans.NEW_COLUMN_ID, GeneralConstants.ID);
            dataGridViewWriteOff.Columns.Add(UIConstans.NEW_COLUMN_CONSUMBLE, GeneralConstants.CONSUMBLE);
            dataGridViewWriteOff.Columns.Add(UIConstans.NEW_COLUMN_EMPLOYEE, GeneralConstants.EMPLOYEE);
            dataGridViewWriteOff.Columns.Add(UIConstans.NEW_COLUMN_AMOUNT, GeneralConstants.AMOUNT);
            dataGridViewWriteOff.Columns.Add(UIConstans.NEW_COLUMN_COMMENT, GeneralConstants.COMMENT);
            dataGridViewWriteOff.Columns.Add(UIConstans.NEW_COLUMN_DATE, GeneralConstants.DATE);

            dataGridViewWriteOff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewWriteOff.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewWriteOff.AllowUserToAddRows = false;
            dataGridViewWriteOff.RowHeadersVisible = false;
            dataGridViewWriteOff.ReadOnly = true;
            #endregion

            #region dataGridViewGoods
            dataGridViewGoods.Columns.Add(UIConstans.NEW_COLUMN_ID, GeneralConstants.ID);
            dataGridViewGoods.Columns.Add(UIConstans.NEW_COLUMN_NAME, GeneralConstants.TITLE);
            dataGridViewGoods.Columns.Add(UIConstans.NEW_COLUMN_CATEGORY, GeneralConstants.CATEGORY);
            dataGridViewGoods.Columns.Add(UIConstans.NEW_COLUMN_PRICE, GeneralConstants.PRICE);
            dataGridViewGoods.Columns.Add(UIConstans.NEW_COLUMN_WEIGHT, GeneralConstants.WEIGHT);

            column = new DataGridViewComboBoxColumn();
            column.DataSource = new List<string>() { GeneralConstants.YES, GeneralConstants.NO };
            column.HeaderText = GeneralConstants.VISIBILITY;
            dataGridViewGoods.Columns.Add(column);

            dataGridViewGoods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewGoods.AllowUserToAddRows = false;
            dataGridViewGoods.RowHeadersVisible = false;
            dataGridViewGoods.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridViewGoods.ReadOnly = true;

            #endregion

            #region dataGridCostPrice
            dataGridViewCostPrice.Columns.Add(UIConstans.NEW_COLUMN_ID, GeneralConstants.ID);
            dataGridViewCostPrice.Columns.Add(UIConstans.NEW_COLUMN_NAME, GeneralConstants.TITLE);
            dataGridViewCostPrice.Columns.Add(UIConstans.NEW_COLUMN_COST_PRICE, GeneralConstants.COST_PRICE);

            dataGridViewCostPrice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCostPrice.AllowUserToAddRows = false;
            dataGridViewCostPrice.RowHeadersVisible = false;
            dataGridViewCostPrice.ReadOnly = true;

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

        public void AddSupplierToDataGrid(int id)
        {
            new Thread(() =>
            {
                try
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        Supplier supplier = SuppliersCore.Suppliers.GetSupplier(id);
                        dataGridViewSuppliers.Rows.Add(supplier.id, supplier.name, supplier.phone, supplier.email, supplier.skype, supplier.notes, Convert.ToBoolean(supplier.visible) ? GeneralConstants.YES : GeneralConstants.NO);
                        dataGridViewSuppliers.CellValueChanged += DataGridViewSuppliers_CellValueChanged; ;
                        updateFlag = true;
                    });
                }
                catch { }
            }).Start();
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

        public void AddEmployeeToDataGrid(int id)
        {
            new Thread(() =>
            {
                try
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        EmployeesCore.GetEmplyees();
                        Employee employee = EmployeesCore.Emplyees.GetEmployee(id);
                        DataGridViewRow row = new DataGridViewRow();
                        dataGridViewEmployees.Rows.Add(employee.id, employee.first_name, employee.last_name, EmployeesTypesCore.EmployeesTypes.GetName(employee.id_type), employee.phone, employee.phone_ex, employee.skype, employee.address, employee.email, employee.birthday, employee.comment, Convert.ToBoolean(employee.visible) ? GeneralConstants.YES : GeneralConstants.NO);
                        dataGridViewEmployees.CellValueChanged += DataGridViewEmployees_CellValueChanged;
                        updateFlag = true;
                    });
                }
                catch { }
            }).Start();
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
            UpdateDataGridViewClients();
            dataGridViewClients.CellDoubleClick += DataGridViewClients_CellDoubleClick;
            this.Refresh();
        }

        private void DataGridViewClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ClientDetailsForm modalForm = new ClientDetailsForm(Convert.ToInt32(dataGridViewClients[0, e.RowIndex].Value));
                modalForm.StartPosition = FormStartPosition.CenterScreen;
                this.Enabled = false;
                modalForm.Show();
            }
        }

        public void AddClientToGrid(int id)
        {
            new Thread(() =>
            {
                try
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        Client client = ClientsCore.Clients.GetClint(id);

                        DataGridViewRow row = new DataGridViewRow();
                        row.Cells.Add(new DataGridViewTextBoxCell()
                        {
                            Value = client.id
                        });
                        row.Cells.Add(new DataGridViewTextBoxCell()
                        {
                            Value = client.name
                        });
                        row.Cells.Add(new DataGridViewTextBoxCell()
                        {
                            Value = client.phone
                        });
                        row.Cells.Add(new DataGridViewTextBoxCell()
                        {
                            Value = client.email
                        });
                        row.Cells.Add(new DataGridViewTextBoxCell()
                        {
                            Value = client.discount_stored
                        });
                        row.Cells.Add(new DataGridViewTextBoxCell()
                        {
                            Value = client.total_balance
                        });
                        row.Cells.Add(new DataGridViewTextBoxCell()
                        {
                            Value = client.discount_fixed
                        });
                        row.Cells.Add(new DataGridViewTextBoxCell()
                        {
                            Value = client.discount_reason
                        });
                        row.Cells.Add(new DataGridViewTextBoxCell()
                        {
                            Value = client.comment
                        });

                        DataGridViewComboBoxCell cell = new DataGridViewComboBoxCell();
                        cell.Items.Add(GeneralConstants.YES);
                        cell.Items.Add(GeneralConstants.NO);
                        cell.Value = Convert.ToBoolean(client.visible) ? GeneralConstants.YES : GeneralConstants.NO;
                        row.Cells.Add(cell);
                        row.ReadOnly = true;

                        dataGridViewClients.Rows.Add(row);
                        updateFlag = true;

                        dataGridViewClients.CellValueChanged += DataGridViewClients_CellValueChanged;
                    });
                }
                catch { }
            }).Start();
        }

        public void UpdateDataGridViewClients()
        {
            new Thread(() =>
            {
                try
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        dataGridViewClients.Rows.Clear();
                        foreach (Client client in ClientsCore.Clients.items)
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.Cells.Add(new DataGridViewTextBoxCell()
                            {
                                Value = client.id
                            });
                            row.Cells.Add(new DataGridViewTextBoxCell()
                            {
                                Value = client.name
                            });
                            row.Cells.Add(new DataGridViewTextBoxCell()
                            {
                                Value = client.phone
                            });
                            row.Cells.Add(new DataGridViewTextBoxCell()
                            {
                                Value = client.email
                            });
                            row.Cells.Add(new DataGridViewTextBoxCell()
                            {
                                Value = client.discount_stored
                            });
                            row.Cells.Add(new DataGridViewTextBoxCell()
                            {
                                Value = client.total_balance
                            });
                            row.Cells.Add(new DataGridViewTextBoxCell()
                            {
                                Value = client.discount_fixed
                            });
                            row.Cells.Add(new DataGridViewTextBoxCell()
                            {
                                Value = client.discount_reason
                            });
                            row.Cells.Add(new DataGridViewTextBoxCell()
                            {
                                Value = client.comment
                            });

                            DataGridViewComboBoxCell cell = new DataGridViewComboBoxCell();
                            cell.Items.Add(GeneralConstants.YES);
                            cell.Items.Add(GeneralConstants.NO);
                            cell.Value = Convert.ToBoolean(client.visible) ? GeneralConstants.YES : GeneralConstants.NO;
                            row.Cells.Add(cell);
                            row.ReadOnly = true;

                            dataGridViewClients.Rows.Add(row);
                            updateFlag = true;

                            dataGridViewClients.CellValueChanged += DataGridViewClients_CellValueChanged; ;
                        }
                    });
                }
                catch { }
            }).Start();
        }

        private void DataGridViewClients_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void TabPageGoods_Enter(object sender, EventArgs e)
        {
            Point tmpPoint = new Point();

            tmpPoint.X = tabPageConsumables.Width - buttonAddGood.Width - 10;
            tmpPoint.Y = tabPageConsumables.Height - buttonAddGood.Height - 10;
            buttonAddGood.Location = tmpPoint;

            tmpPoint.X = buttonAddGood.Location.X - buttonCopyGood.Width - 10;
            buttonCopyGood.Location = tmpPoint;

            int tmpWidth = tabPageConsumables.Width - 24;
            int tmpHeight = buttonAddGood.Location.Y - buttonAddGood.Height - 20;
            tmpPoint.X = tabPageConsumables.Left + 10;
            tmpPoint.Y = tabPageConsumables.Top + 10;
            dataGridViewGoods.SetBounds(tmpPoint.X, tmpPoint.Y, tmpWidth, tmpHeight);
            dataGridViewGoods.CellDoubleClick += DataGridViewGoods_CellDoubleClick;
            dataGridViewGoods.CellClick += DataGridViewGoods_CellClick;
            UpdateDataGridViewGoods();
            goodRowSelected = 0;
            this.Refresh();
        }

        private void DataGridViewGoods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
                goodRowSelected = e.RowIndex;
        }

        private void DataGridViewGoods_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && this.Enabled)
            {
                GoodDetailsForm modalForm = new GoodDetailsForm(Convert.ToInt32(dataGridViewGoods[0, e.RowIndex].Value), false);
                modalForm.StartPosition = FormStartPosition.CenterScreen;
                this.Enabled = false;
                modalForm.Show();
            }
        }

        public void AddGoodToGrid(Good good)
        {
            new Thread(() =>
            {
                try
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        dataGridViewGoods.Rows.Add(good.id,
                            good.name,
                            GoodsCategoriesCore.GoodsCategories.GetName(good.id_category),
                            good.price,
                            good.weight,
                            Convert.ToBoolean(good.visible) ? GeneralConstants.YES : GeneralConstants.NO);
                        dataGridViewGoods.CellValueChanged += DataGridViewGoods_CellValueChanged;
                        updateFlag = true;

                    });
                }
                catch { }
            }).Start();
        }

        public void UpdateDataGridViewGoods()
        {
            new Thread(() =>
            {
                try
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        dataGridViewGoods.Rows.Clear();
                        foreach (Good good in GoodsCore.Goods.items)
                        {
                            dataGridViewGoods.Rows.Add(good.id, 
                                good.name, 
                                GoodsCategoriesCore.GoodsCategories.GetName(good.id_category),
                                good.price,
                                good.weight,
                                Convert.ToBoolean(good.visible) ? GeneralConstants.YES : GeneralConstants.NO);
                            dataGridViewGoods.CellValueChanged += DataGridViewGoods_CellValueChanged;
                            updateFlag = true;
                        }
                    });
                }
                catch { }
            }).Start();
        }

        private void DataGridViewGoods_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void TabPageAcounts_Enter(object sender, EventArgs e)
        {
            Point tmpPoint = new Point();

            tmpPoint.X = tabPageConsumables.Width - buttonAddAcount.Width - 10;
            tmpPoint.Y = tabPageConsumables.Height - buttonAddAcount.Height - 10;
            buttonAddAcount.Location = tmpPoint;

            int tmpWidth = tabPageConsumables.Width - 24;
            int tmpHeight = buttonAddAcount.Location.Y - buttonAddAcount.Height - 20;
            tmpPoint.X = tabPageConsumables.Left + 10;
            tmpPoint.Y = tabPageConsumables.Top + 10;
            dataGridViewAcount.SetBounds(tmpPoint.X, tmpPoint.Y, tmpWidth, tmpHeight);
            UpdateDataGridViewAcounts();
            this.Refresh();
        }

        public void AddAccountToGrid(int id)
        {
            new Thread(() =>
            {
                try
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        AcountsCore.GetAcounts();
                        Account account = AcountsCore.Acounts.GetAccount(id);
                        DataGridViewRow row = new DataGridViewRow();
                        dataGridViewAcount.Rows.Add(account.id, account.login, GeneralConstants.PASSWORD_MASC, EmployeesCore.Emplyees.GetEmployeeFullName(account.id_employee), AcountTypesCore.GetAcountType(account.id_type), Convert.ToBoolean(account.visible) ? GeneralConstants.YES : GeneralConstants.NO);
                        dataGridViewAcount.CellValueChanged += DataGridViewAcount_CellValueChanged;
                        updateFlag = true;
                    });
                }
                catch { }
            }).Start();
        }

        public void UpdateDataGridViewAcounts()
        {
            new Thread(() =>
            {
                try
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        dataGridViewAcount.Rows.Clear();
                        AcountsCore.GetAcounts();
                        foreach (Account account in AcountsCore.Acounts.items)
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            dataGridViewAcount.Rows.Add(account.id, account.login, GeneralConstants.PASSWORD_MASC, EmployeesCore.Emplyees.GetEmployeeFullName(account.id_employee), AcountTypesCore.GetAcountType(account.id_type), Convert.ToBoolean(account.visible) ? GeneralConstants.YES : GeneralConstants.NO);
                            dataGridViewAcount.CellValueChanged += DataGridViewAcount_CellValueChanged;
                            updateFlag = true;
                        }
                    });
                }
                catch { }
            }).Start();
        }

        private void DataGridViewAcount_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (updateFlag)
            {
                DataGridViewCellCollection collection = dataGridViewAcount.Rows[e.RowIndex].Cells;
                AcountsCore.EditAcount(collection[0].Value.ToString(),
                    collection[1].Value.ToString(),
                    AcountTypesCore.GetAcountType(collection[4].Value.ToString()),
                    EmployeesCore.Emplyees.GetID(collection[3].Value.ToString()),
                    collection[2].Value.ToString(),
                    collection[5].Value.ToString() == GeneralConstants.YES ? "1" : "0");

                dataGridViewAcount.CellValueChanged -= DataGridViewAcount_CellValueChanged;
                updateFlag = false;
                dataGridViewAcount.Rows.Clear();
                AcountsCore.GetAcounts();
                UpdateDataGridViewAcounts();
            }
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
            comboBoxSelectGood.Location = tmpPoint;
            comboBoxSelectGood.Width = tmpWidth;

            tmpWidth = groupBoxCostPrice.Width - 20;
            tmpHeight = buttonAddAllConsumbles.Location.Y - 30;
            tmpPoint.X = 10;
            tmpPoint.Y = 20;
            dataGridViewCostPrice.SetBounds(tmpPoint.X, tmpPoint.Y, tmpWidth, tmpHeight);

            comboBoxSelectGood.DataSource = GoodsCore.Goods.ToList();
            if(GoodsCore.Goods.count > 0)
                comboBoxSelectGood.SelectedIndex = 0;
            this.Refresh();
        }

        private void TabPageConsumables_Enter(object sender, EventArgs e)
        {
            Point tmpPoint = new Point();

            tmpPoint.X = tabPageConsumables.Width - buttonAddConsumble.Width - 10;
            tmpPoint.Y = tabPageConsumables.Height - buttonAddConsumble.Height - 10;
            buttonAddConsumble.Location = tmpPoint;

            tmpPoint.X = buttonAddConsumble.Location.X - buttonPrintConsumbles.Width - 10;
            buttonPrintConsumbles.Location = tmpPoint;

            tmpPoint.X = buttonPrintConsumbles.Location.X - checkBoxPrint.Width - 10;
            checkBoxPrint.Location = tmpPoint;

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

        public void AddConsumbleToGrid(string ConsumbleName)
        {
            new Thread(() =>
            {
                try
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        ConsumblesCore.GetConsumbles();
                        Consumble consumble = ConsumblesCore.Consumbles.GetConsumble(ConsumbleName);

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
                            if (type.visible != 0)
                            {
                                bool hasCategories = true;
                                try
                                {
                                    ConsumbleCategorieCore.GetConsumbleCategorie(type.id.ToString());
                                    if (ConsumbleCategorieCore.consumbleCategories.items.Count == 0)
                                        hasCategories = false;
                                }
                                catch { hasCategories = false; }
                                if (hasCategories)
                                    cell.Items.Add(type.name);
                            }
                        }
                        cell.Value = ConsumblesTypesCore.ConsumbleTypes.GetName(consumble.id_type);
                        row.Cells.Add(cell);

                        cell = new DataGridViewComboBoxCell();

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
                    });
                }
                catch { }
            }).Start();
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
                                if (type.visible != 0)
                                {
                                    bool hasCategories = true;
                                    try
                                    {
                                        ConsumbleCategorieCore.GetConsumbleCategorie(type.id.ToString());
                                        if (ConsumbleCategorieCore.consumbleCategories.items.Count == 0)
                                        {
                                            hasCategories = false;
                                        }
                                        else
                                        {
                                            bool haveVisible = false;
                                            foreach (ConsumbleCategorie categorie in ConsumbleCategorieCore.consumbleCategories.items)
                                            {
                                                if (categorie.visible == 1)
                                                {
                                                    haveVisible = true;
                                                    break;
                                                }
                                                hasCategories = haveVisible;
                                            }
                                        }
                                    }catch { hasCategories = false; }
                                    if(hasCategories)
                                        cell.Items.Add(type.name);
                                }
                            }
                            cell.Value = ConsumblesTypesCore.ConsumbleTypes.GetName(consumble.id_type);
                            row.Cells.Add(cell);

                            cell = new DataGridViewComboBoxCell();
        
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
                new Thread(() =>
                {
                    try
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            updateFlag = false;
                            DataGridViewCellCollection collection = dataGridViewConsumbles.Rows[e.RowIndex].Cells;
                            int waste = 0;
                            bool correctWaste = false;
                            try
                            {
                                waste = Convert.ToInt32(collection[7].Value);
                                if (waste < 100)
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
                                ConsumblesCore.EditConsumble(collection[0].Value.ToString(),
                                collection[1].Value.ToString(),
                                collection[8].Value.ToString() == GeneralConstants.YES ? "1" : "0",
                                ConsumblesTypesCore.ConsumbleTypes.GetID(collection[5].Value.ToString()),
                                ConsumbleCategorieCore.consumbleCategories.GetID(collection[6].Value.ToString()),
                                MeasuresCore.Measures.GetID(collection[4].Value.ToString()),
                                Convert.ToInt32(collection[7].Value));
                                int selectColumn = e.ColumnIndex;
                                int selectedRow = e.RowIndex;
                                if (e.ColumnIndex == 5)
                                {
                                    ConsumbleCategorieCore.GetConsumbleCategorie(ConsumblesTypesCore.ConsumbleTypes.GetID(collection[5].Value.ToString()).ToString());
                                    DataGridViewComboBoxCell cell = ((DataGridViewComboBoxCell)dataGridViewConsumbles[e.ColumnIndex + 1, e.RowIndex]);

                                    cell.DataSource = ConsumbleCategorieCore.consumbleCategories.ToList();
                                    cell.Value = ConsumbleCategorieCore.consumbleCategories.items[0].name;
                                }
                                try
                                {
                                    dataGridViewConsumbles.CurrentCell = dataGridViewConsumbles.Rows[selectedRow].Cells[selectColumn];
                                }
                                catch { }
                            }
                            updateFlag = true;
                        });
                    }
                    catch { }
                }).Start();
            }
        }

        private void TabPageArrivalAndWriteOff_Enter(object sender, EventArgs e)
        {
            Point tmpPoint = new Point();

            tmpPoint.X = tabPageConsumables.Width / 2 - 10 - buttonArrivial.Width;
            tmpPoint.Y = tabPageConsumables.Height - buttonArrivial.Height - 10;
            buttonArrivial.Location = tmpPoint;

            tmpPoint.X = tabPageConsumables.Width - buttonArrivial.Width - 10;
            buttonWriteOff.Location = tmpPoint;

            int tmpWidth = tabPageConsumables.Width / 2 - 20;
            int tmpHeight = buttonArrivial.Location.Y - buttonArrivial.Height - 20;
            tmpPoint.X = tabPageConsumables.Left + 10;
            tmpPoint.Y = tabPageConsumables.Top + 10;

            dataGridViewArrival.SetBounds(tmpPoint.X, tmpPoint.Y, tmpWidth, tmpHeight);
            tmpPoint.X = tabPageConsumables.Width / 2 + 10;
            dataGridViewWriteOff.SetBounds(tmpPoint.X, tmpPoint.Y, tmpWidth, tmpHeight);
            UpdateDataGridViewArrival();
            UpdateDataGridViewWriteOff();
            this.Refresh();
        }

        public void AddArrivalToGrid(int id)
        {
            new Thread(() =>
            {
                try
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        Arrival arrival = ArrivalCore.Arrivals.GetArrival(id);
                        DataGridViewRow row = new DataGridViewRow();
                        dataGridViewArrival.Rows.Add(arrival.id,
                            ConsumblesCore.Consumbles.GetName(arrival.id_item),
                            SuppliersCore.Suppliers.GetName(arrival.id_provider),
                            EmployeesCore.Emplyees.GetEmployeeFullName(arrival.id_employee),
                            string.Format("{0} {1}", arrival.amount, ConsumblesCore.Consumbles.GetMeasure(arrival.id_item)),
                            arrival.price,
                            arrival.date_create);

                    });
                }
                catch { }
            }).Start();
        }

        public void UpdateDataGridViewArrival()
        {
            new Thread(() =>
            {
                try
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        dataGridViewArrival.Rows.Clear();
                        foreach (Arrival arrival in ArrivalCore.Arrivals.items)
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            dataGridViewArrival.Rows.Add(arrival.id,
                                ConsumblesCore.Consumbles.GetName(arrival.id_item),
                                SuppliersCore.Suppliers.GetName(arrival.id_provider),
                                EmployeesCore.Emplyees.GetEmployeeFullName(arrival.id_employee),
                                string.Format("{0} {1}",arrival.amount, ConsumblesCore.Consumbles.GetMeasure(arrival.id_item)),
                                arrival.price,
                                arrival.date_create);
                        }
                    });
                }
                catch { }
            }).Start();
        }

        public void AddWriteOffToForm(int id)
        {
            new Thread(() =>
            {
                try
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        WriteOff writeoff = WriteOffCore.WriteOffs.GetWriteOff(id);
                        DataGridViewRow row = new DataGridViewRow();
                        dataGridViewWriteOff.Rows.Add(writeoff.id,
                            ConsumblesCore.Consumbles.GetName(writeoff.id_item),
                            EmployeesCore.Emplyees.GetEmployeeFullName(writeoff.id_employee),
                            string.Format("{0} {1}", writeoff.amount, ConsumblesCore.Consumbles.GetMeasure(writeoff.id_item)),
                            writeoff.comment,
                            writeoff.date_create);

                    });
                }
                catch { }
            }).Start();
        }

        public void UpdateDataGridViewWriteOff()
        {
            new Thread(() =>
            {
                try
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        dataGridViewWriteOff.Rows.Clear();
                        foreach (WriteOff writeoff in WriteOffCore.WriteOffs.items)
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            dataGridViewWriteOff.Rows.Add(writeoff.id,
                                ConsumblesCore.Consumbles.GetName(writeoff.id_item),
                                EmployeesCore.Emplyees.GetEmployeeFullName(writeoff.id_employee),
                                string.Format("{0} {1}", writeoff.amount, ConsumblesCore.Consumbles.GetMeasure(writeoff.id_item)),
                                writeoff.comment,
                                writeoff.date_create);
                        }
                    });
                }
                catch { }
            }).Start();
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
            AddClientForm modalForm = new AddClientForm();
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

        private void buttonCopyGood_Click(object sender, EventArgs e)
        {
            GoodDetailsForm modalForm = new GoodDetailsForm(Convert.ToInt32(dataGridViewGoods[0, goodRowSelected].Value), true);
            modalForm.StartPosition = FormStartPosition.CenterScreen;
            this.Enabled = false;
            modalForm.Show();
        }

        private void buttonPrintConsumbles_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();

            printer.Title = "Остатки";

            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit |

                                          StringFormatFlags.NoClip;

            printer.PageNumbers = true;

            printer.PageNumberInHeader = false;

            printer.PorportionalColumns = true;

            printer.HeaderCellAlignment = StringAlignment.Near;

            printer.Footer = "IT-Food";

            printer.FooterSpacing = 15;

            printer.RowHeight = DGVPrinter.RowHeightSetting.CellHeight;

            printer.PrintDataGridView(CreateDGVPrint());
        }

        private DataGridView CreateDGVPrint()
        {
            DataGridView tmpDGV = new DataGridView();
            tmpDGV.Columns.Add(UIConstans.NEW_COLUMN_NAME, GeneralConstants.TITLE);
            tmpDGV.Columns.Add(UIConstans.NEW_COLUMN_ACTUAL_AMOUNT, GeneralConstants.ACTUAL_AMOUNT);
            if (checkBoxPrint.Checked)
                tmpDGV.Columns.Add(UIConstans.NEW_COLUMN_AMOUNT, GeneralConstants.AMOUNT);

            tmpDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            

            for (int i = 0; i < dataGridViewConsumbles.Rows.Count; i++)
            {
                DataGridViewCellCollection collection = dataGridViewConsumbles.Rows[i].Cells;
                if(Convert.ToDouble(collection[3].Value)>0)
                {
                    if (checkBoxPrint.Checked)
                        tmpDGV.Rows.Add(collection[1].Value,"", string.Format("{0} {1}",collection[3].Value.ToString(),collection[4].Value.ToString()));
                    else
                        tmpDGV.Rows.Add(collection[1].Value,"");
                }
            }
            return tmpDGV;

        }

        private void buttonSelectConsumble_Click(object sender, EventArgs e)
        {
            double costPrice = 0;
            Good good = GoodsCore.Goods.GetGood(comboBoxSelectGood.SelectedItem.ToString());
            good.consumbles = GoodConsumlesCore.GetGoodConsumles(good.id);

            for(int i=0;i<good.consumbles.items.Count;i++)
            {
                Consumble consumble = ConsumblesCore.Consumbles.GetConsumble(good.consumbles.items[i].id_item);
                costPrice += consumble.price * good.consumbles.items[i].weight;
            }

            dataGridViewCostPrice.Rows.Add(good.id, good.name, costPrice);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            dataGridViewCostPrice.Rows.Clear();
        }

        private void buttonAddAllConsumbles_Click(object sender, EventArgs e)
        {
            dataGridViewCostPrice.Rows.Clear();

            foreach(Good good in GoodsCore.Goods.items)
            {
                double costPrice = 0;
                good.consumbles = GoodConsumlesCore.GetGoodConsumles(good.id);

                for (int i = 0; i < good.consumbles.items.Count; i++)
                {
                    Consumble consumble = ConsumblesCore.Consumbles.GetConsumble(good.consumbles.items[i].id_item);
                    costPrice += consumble.price * good.consumbles.items[i].weight;
                }

                dataGridViewCostPrice.Rows.Add(good.id, good.name, costPrice);
            }
        }
    }
}

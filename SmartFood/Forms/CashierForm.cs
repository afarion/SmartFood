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
            dataGridViewOrders.SetBounds(tmpPoint.X, tmpPoint.Y, tmpWidth, tmpHeight);

            dataGridViewOrders.Columns.Add(UIConstans.NEW_COLUMN_ID, GeneralConstants.ID);
            dataGridViewOrders.Columns.Add(UIConstans.NEW_COLUMN_PHONE, GeneralConstants.PHONE);

            var column = new DataGridViewComboBoxColumn();
            column.HeaderText = GeneralConstants.COURIER;
            column.Name = UIConstans.NEW_COLUMN_COURIER;
            dataGridViewOrders.Columns.Add(column);

            column = new DataGridViewComboBoxColumn();
            column.HeaderText = GeneralConstants.STATUS;
            column.Name = UIConstans.NEW_COLUMN_STATUS;
            dataGridViewOrders.Columns.Add(column);

            dataGridViewOrders.Columns.Add(UIConstans.NEW_COLUMN_SUMM, GeneralConstants.SUMM);
            dataGridViewOrders.Columns.Add(UIConstans.NEW_COLUMN_SUMM_WITH_DISCOUNT, GeneralConstants.SUMM_WITH_DISCOUNT);
            dataGridViewOrders.Columns.Add(UIConstans.NEW_COLUMN_DISCOUNT, GeneralConstants.DISCOUNT);
            dataGridViewOrders.Columns.Add(UIConstans.NEW_COLUMN_DATE_ORDER_CREATION, GeneralConstants.DATE_ORDER_CREATION);
            dataGridViewOrders.Columns.Add(UIConstans.NEW_COLUMN_DATE_ORDER_DELIVERING, GeneralConstants.DATE_ORDER_DELIVERING);

            dataGridViewOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOrders.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewOrders.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewOrders.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewOrders.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewOrders.Columns[0].ReadOnly = true;
            dataGridViewOrders.Columns[1].ReadOnly = true;
            dataGridViewOrders.Columns[4].ReadOnly = true;
            dataGridViewOrders.Columns[5].ReadOnly = true;
            dataGridViewOrders.Columns[6].ReadOnly = true;
            dataGridViewOrders.Columns[7].ReadOnly = true;
            dataGridViewOrders.Columns[8].ReadOnly = true;
            dataGridViewOrders.AllowUserToAddRows = false;
            dataGridViewOrders.RowHeadersVisible = false;
            this.Refresh();
            UpdateOrderInGrid();
        }

        private void UpdateOrderInGrid()
        {
            new Thread(() =>
            {
                try
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        dataGridViewOrders.Rows.Clear();
                        foreach (Order order in OrderCore.Orders.items)
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.Cells.Add(new DataGridViewTextBoxCell()
                            {
                                Value = order.id
                            });
                            row.Cells.Add(new DataGridViewTextBoxCell()
                            {
                                Value = ClientsCore.Clients.GetClint(order.id_user).phone
                            });

                            DataGridViewComboBoxCell cell = new DataGridViewComboBoxCell();
                            cell.DataSource = EmployeesCore.Emplyees.GetCouriers();
                            cell.Value = EmployeesCore.Emplyees.GetEmployeeFullName(order.id_courier);
                            row.Cells.Add(cell);

                            cell = new DataGridViewComboBoxCell();
                            cell.Items.Add(OrderStatusesCore.OrderStatuses.GetName(order.id_status));
                            if (order.id_status>=4)
                            {
                                cell.ReadOnly = true;
                            }
                            else if(order.id_status == 1)
                            {
                                cell.Items.Add(OrderStatusesCore.OrderStatuses.GetName(2));
                                cell.Items.Add(OrderStatusesCore.OrderStatuses.GetName(5));
                                cell.ReadOnly = false;
                            }
                            else if (order.id_status == 2)
                            {
                                cell.Items.Add(OrderStatusesCore.OrderStatuses.GetName(3));
                                cell.Items.Add(OrderStatusesCore.OrderStatuses.GetName(6));
                                cell.ReadOnly = false;
                            }
                            else if (order.id_status == 3)
                            {
                                cell.Items.Add(OrderStatusesCore.OrderStatuses.GetName(4));
                                cell.Items.Add(OrderStatusesCore.OrderStatuses.GetName(6));
                                cell.ReadOnly = false;
                            }
                            cell.Value = OrderStatusesCore.OrderStatuses.GetName(order.id_status);
                            row.Cells.Add(cell);

                            row.Cells.Add(new DataGridViewTextBoxCell()
                            {
                                Value = order.price
                            });

                            row.Cells.Add(new DataGridViewTextBoxCell()
                            {
                                Value = order.result_price
                            });
                            row.Cells.Add(new DataGridViewTextBoxCell()
                            {
                                Value = order.discount
                            });
                            row.Cells.Add(new DataGridViewTextBoxCell()
                            {
                                Value = order.date_create.ToString("yyyy'/'MM'/'dd HH':'mm")
                            });

                            if (order.deliver_on_time > order.date_create)
                            {
                                row.Cells.Add(new DataGridViewTextBoxCell()
                                {
                                    Value = order.deliver_on_time.ToString("yyyy'/'MM'/'dd HH':'mm")
                                });
                            }
                            else
                            {
                                row.Cells.Add(new DataGridViewTextBoxCell()
                                {
                                    Value = string.Empty
                                });
                            }

                            dataGridViewOrders.Rows.Add(row);
                        }
                    });
                }
                catch { }
            }).Start();
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

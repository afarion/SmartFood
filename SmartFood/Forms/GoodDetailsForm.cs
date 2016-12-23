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
using System.Windows.Forms;
using static SmartFood.Core.Constants.GeneralConstants;

namespace SmartFood.Forms
{
    public partial class GoodDetailsForm : Form
    {
        public static GoodDetailsForm instance;
        private static int rowIndex;
        bool isCopy = false;
        bool isEdit = false;
        private int goodID = -1;
        public GoodDetailsForm()
        {
            InitializeComponent();
            GoodDetailsInit();
        }

        public GoodDetailsForm(int goodID, bool Copy)
        {
            isEdit = !Copy;
            this.goodID = goodID;
            InitializeComponent();
            GoodDetailsInit();

            Good good = GoodsCore.Goods.GetGood(goodID);
            good.consumbles = GoodConsumlesCore.GetGoodConsumles(goodID);
            if(isEdit)
                textBoxName.Text = good.name;
            textBoxPrice.Text = good.price.ToString();
            textBoxWeight.Text = good.weight.ToString();
            comboBoxCategory.SelectedItem = GoodsCategoriesCore.GoodsCategories.GetName(good.id_category);
            comboBoxVisble.SelectedItem = good.visible == 1 ? GeneralConstants.YES : GeneralConstants.NO;

            foreach (var consumble in good.consumbles.items)
            {
                if(isEdit)
                    dataGridViewConsumbles.Rows.Add(consumble.id, ConsumblesCore.Consumbles.GetName(consumble.id_item), consumble.weight, Convert.ToBoolean(consumble.visible) ? GeneralConstants.YES : GeneralConstants.NO);
                else
                    dataGridViewConsumbles.Rows.Add("", ConsumblesCore.Consumbles.GetName(consumble.id_item), consumble.weight, Convert.ToBoolean(consumble.visible) ? GeneralConstants.YES : GeneralConstants.NO);
            }
        }

        public void GoodDetailsInit()
        {
            instance = this;
            comboBoxCategory.DataSource = GoodsCategoriesCore.GoodsCategories.ToList();
            comboBoxCategory.SelectedIndex = 0;

            dataGridViewConsumbles.Columns.Add(UIConstans.NEW_COLUMN_ID, GeneralConstants.ID);
            dataGridViewConsumbles.Columns.Add(UIConstans.NEW_COLUMN_NAME, GeneralConstants.NAME);
            dataGridViewConsumbles.Columns.Add(UIConstans.NEW_COLUMN_WEIGHT, GeneralConstants.WEIGHT);
            var column = new DataGridViewComboBoxColumn();
            column.DataSource = new List<string>() { GeneralConstants.YES, GeneralConstants.NO };
            column.HeaderText = GeneralConstants.VISIBILITY;
            dataGridViewConsumbles.Columns.Add(column);

            dataGridViewConsumbles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewConsumbles.AllowUserToAddRows = false;
            dataGridViewConsumbles.RowHeadersVisible = false;
            dataGridViewConsumbles.Columns[0].ReadOnly = true;
            dataGridViewConsumbles.Columns[1].ReadOnly = true;
            dataGridViewConsumbles.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridViewConsumbles.CellClick += DataGridViewConsumbles_CellClick;
            comboBoxVisble.DataSource = new List<string>() { GeneralConstants.YES, GeneralConstants.NO };
            comboBoxVisble.SelectedIndex = 0;
        }

        private void DataGridViewConsumbles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowIndex = e.RowIndex;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            AdminForm.instance.Enabled = true;
            this.Close();
        }

        private void GoodDetailsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminForm.instance.Enabled = true;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            bool isOK = true;
            double weight = 0;
            double price = 0;

            if(string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(textBoxPrice.Text) || string.IsNullOrEmpty(textBoxWeight.Text))
            {
                isOK = false;
                ErrorsViewWrapper.ShowError(ErrorTexts.ENTER_ALL_FIELDS);
            }
            if (isOK)
            {
                try
                {
                    weight = Convert.ToDouble(textBoxWeight.Text);
                }
                catch
                {
                    isOK = false;
                    ErrorsViewWrapper.ShowError(ErrorTexts.INCORRECT_WEIGHT);
                }
            }
            if (isOK)
            {
                try
                {
                    price = Convert.ToDouble(textBoxPrice.Text);
                }
                catch
                {
                    isOK = false;
                    ErrorsViewWrapper.ShowError(ErrorTexts.INCORRECT_PRICE);
                }
            }
            if(isOK)
            {
                if (isEdit)
                {
                    GoodsCore.EditGood(goodID, textBoxName.Text, GoodsCategoriesCore.GoodsCategories.GetID(comboBoxCategory.SelectedItem.ToString()), weight, price, comboBoxVisble.SelectedItem.ToString() == GeneralConstants.YES ? 1 : 0);
                }
                else
                {
                    Good good = GoodsCore.AddGood(textBoxName.Text,
                         GoodsCategoriesCore.GoodsCategories.GetID(comboBoxCategory.SelectedValue.ToString()),
                         Convert.ToDouble(textBoxWeight.Text),
                         Convert.ToDouble(textBoxPrice.Text), 
                         comboBoxVisble.SelectedItem.ToString() == GeneralConstants.YES ? 1 : 0);

                    for (int i = 0; i < dataGridViewConsumbles.Rows.Count; i++)
                    {
                        DataGridViewCellCollection collection = dataGridViewConsumbles.Rows[i].Cells;
                        GoodConsumlesCore.AddGoodConsumle(good.id,
                            ConsumblesCore.Consumbles.GetID(collection[1].Value.ToString()),
                            Convert.ToDouble(collection[2].Value));
                    }
                }

                GoodsCore.GetGoods();
                AdminForm.instance.UpdateDataGridViewGoods();
                this.Close();
            }
        }

        private void buttonAddConsumble_Click(object sender, EventArgs e)
        {
            NewGoodsConsumble modalForm = new NewGoodsConsumble();
            modalForm.StartPosition = FormStartPosition.CenterScreen;
            this.Enabled = false;
            modalForm.Show();
        }

        public void AddConsumbleToGrid(string consumbleName, double weight)
        {
            bool exists = false;
            for(int i =0; i<dataGridViewConsumbles.Rows.Count;i++)
            {
                DataGridViewCellCollection collection = dataGridViewConsumbles.Rows[i].Cells;
                if(collection[1].Value.ToString() == consumbleName)
                {
                    double prviousWeight = Convert.ToDouble(collection[2].Value);
                    double newWeight = prviousWeight + weight;
                    dataGridViewConsumbles[2, i].Value = newWeight;
                    exists = true;
                    break;
                }
            }
            if(!exists)
                dataGridViewConsumbles.Rows.Add("", consumbleName, weight,GeneralConstants.YES);
        }

        private void buttonDeleteConsumble_Click(object sender, EventArgs e)
        {
            if (isEdit)
                GoodConsumlesCore.RemoveGoodConsumle(Convert.ToInt32(dataGridViewConsumbles[0, rowIndex]));
            dataGridViewConsumbles.Rows.RemoveAt(rowIndex);
        }
    }
}

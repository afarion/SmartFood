namespace SmartFood.Forms
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.groupBoxClient = new System.Windows.Forms.GroupBox();
            this.buttonClientDetails = new System.Windows.Forms.Button();
            this.comboBoxAdress = new System.Windows.Forms.ComboBox();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.labelOther = new System.Windows.Forms.Label();
            this.textBoxOther = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAdress = new System.Windows.Forms.Label();
            this.groupBoxOrder = new System.Windows.Forms.GroupBox();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelSummWithDiscount = new System.Windows.Forms.Label();
            this.textBoxSummWithDiscount = new System.Windows.Forms.TextBox();
            this.labelSumm = new System.Windows.Forms.Label();
            this.textBoxSumm = new System.Windows.Forms.TextBox();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.groupBoxClient.SuspendLayout();
            this.groupBoxOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxClient
            // 
            this.groupBoxClient.Controls.Add(this.buttonClientDetails);
            this.groupBoxClient.Controls.Add(this.comboBoxAdress);
            this.groupBoxClient.Controls.Add(this.textBoxDiscount);
            this.groupBoxClient.Controls.Add(this.labelDiscount);
            this.groupBoxClient.Controls.Add(this.labelOther);
            this.groupBoxClient.Controls.Add(this.textBoxOther);
            this.groupBoxClient.Controls.Add(this.labelPhone);
            this.groupBoxClient.Controls.Add(this.textBoxPhone);
            this.groupBoxClient.Controls.Add(this.textBoxName);
            this.groupBoxClient.Controls.Add(this.labelName);
            this.groupBoxClient.Controls.Add(this.labelAdress);
            this.groupBoxClient.Location = new System.Drawing.Point(3, 12);
            this.groupBoxClient.Name = "groupBoxClient";
            this.groupBoxClient.Size = new System.Drawing.Size(657, 155);
            this.groupBoxClient.TabIndex = 12;
            this.groupBoxClient.TabStop = false;
            this.groupBoxClient.Text = "Клиентская информация";
            // 
            // buttonClientDetails
            // 
            this.buttonClientDetails.Location = new System.Drawing.Point(540, 117);
            this.buttonClientDetails.Name = "buttonClientDetails";
            this.buttonClientDetails.Size = new System.Drawing.Size(107, 23);
            this.buttonClientDetails.TabIndex = 17;
            this.buttonClientDetails.Text = "Детали";
            this.buttonClientDetails.UseVisualStyleBackColor = true;
            this.buttonClientDetails.Click += new System.EventHandler(this.buttonClientDetails_Click);
            // 
            // comboBoxAdress
            // 
            this.comboBoxAdress.FormattingEnabled = true;
            this.comboBoxAdress.Location = new System.Drawing.Point(10, 81);
            this.comboBoxAdress.Name = "comboBoxAdress";
            this.comboBoxAdress.Size = new System.Drawing.Size(638, 21);
            this.comboBoxAdress.TabIndex = 16;
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.Location = new System.Drawing.Point(448, 41);
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.ReadOnly = true;
            this.textBoxDiscount.Size = new System.Drawing.Size(200, 20);
            this.textBoxDiscount.TabIndex = 15;
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Location = new System.Drawing.Point(445, 25);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(44, 13);
            this.labelDiscount.TabIndex = 14;
            this.labelDiscount.Text = "Скидка";
            // 
            // labelOther
            // 
            this.labelOther.AutoSize = true;
            this.labelOther.Location = new System.Drawing.Point(6, 103);
            this.labelOther.Name = "labelOther";
            this.labelOther.Size = new System.Drawing.Size(44, 13);
            this.labelOther.TabIndex = 13;
            this.labelOther.Text = "Прочее";
            // 
            // textBoxOther
            // 
            this.textBoxOther.Location = new System.Drawing.Point(9, 119);
            this.textBoxOther.Name = "textBoxOther";
            this.textBoxOther.Size = new System.Drawing.Size(525, 20);
            this.textBoxOther.TabIndex = 12;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(6, 25);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(52, 13);
            this.labelPhone.TabIndex = 3;
            this.labelPhone.Text = "Телефон";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(9, 41);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(200, 20);
            this.textBoxPhone.TabIndex = 0;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(229, 41);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(226, 25);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Имя";
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Location = new System.Drawing.Point(6, 64);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(38, 13);
            this.labelAdress.TabIndex = 5;
            this.labelAdress.Text = "Адрес";
            // 
            // groupBoxOrder
            // 
            this.groupBoxOrder.Controls.Add(this.buttonPrint);
            this.groupBoxOrder.Controls.Add(this.buttonCancel);
            this.groupBoxOrder.Controls.Add(this.buttonOK);
            this.groupBoxOrder.Controls.Add(this.labelSummWithDiscount);
            this.groupBoxOrder.Controls.Add(this.textBoxSummWithDiscount);
            this.groupBoxOrder.Controls.Add(this.labelSumm);
            this.groupBoxOrder.Controls.Add(this.textBoxSumm);
            this.groupBoxOrder.Controls.Add(this.dataGridViewOrder);
            this.groupBoxOrder.Location = new System.Drawing.Point(3, 173);
            this.groupBoxOrder.Name = "groupBoxOrder";
            this.groupBoxOrder.Size = new System.Drawing.Size(657, 407);
            this.groupBoxOrder.TabIndex = 13;
            this.groupBoxOrder.TabStop = false;
            this.groupBoxOrder.Text = "Заказ";
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(414, 368);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(75, 33);
            this.buttonPrint.TabIndex = 21;
            this.buttonPrint.Text = "Пачать";
            this.buttonPrint.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(495, 368);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 33);
            this.buttonCancel.TabIndex = 20;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(576, 368);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 33);
            this.buttonOK.TabIndex = 19;
            this.buttonOK.Text = "Изменить";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // labelSummWithDiscount
            // 
            this.labelSummWithDiscount.AutoSize = true;
            this.labelSummWithDiscount.Location = new System.Drawing.Point(112, 365);
            this.labelSummWithDiscount.Name = "labelSummWithDiscount";
            this.labelSummWithDiscount.Size = new System.Drawing.Size(101, 13);
            this.labelSummWithDiscount.TabIndex = 18;
            this.labelSummWithDiscount.Text = "Сумма со скидкой";
            // 
            // textBoxSummWithDiscount
            // 
            this.textBoxSummWithDiscount.Location = new System.Drawing.Point(115, 381);
            this.textBoxSummWithDiscount.Name = "textBoxSummWithDiscount";
            this.textBoxSummWithDiscount.ReadOnly = true;
            this.textBoxSummWithDiscount.Size = new System.Drawing.Size(100, 20);
            this.textBoxSummWithDiscount.TabIndex = 17;
            // 
            // labelSumm
            // 
            this.labelSumm.AutoSize = true;
            this.labelSumm.Location = new System.Drawing.Point(6, 365);
            this.labelSumm.Name = "labelSumm";
            this.labelSumm.Size = new System.Drawing.Size(41, 13);
            this.labelSumm.TabIndex = 16;
            this.labelSumm.Text = "Сумма";
            // 
            // textBoxSumm
            // 
            this.textBoxSumm.Location = new System.Drawing.Point(9, 381);
            this.textBoxSumm.Name = "textBoxSumm";
            this.textBoxSumm.ReadOnly = true;
            this.textBoxSumm.Size = new System.Drawing.Size(100, 20);
            this.textBoxSumm.TabIndex = 1;
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Location = new System.Drawing.Point(9, 20);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.Size = new System.Drawing.Size(632, 342);
            this.dataGridViewOrder.TabIndex = 0;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 588);
            this.Controls.Add(this.groupBoxOrder);
            this.Controls.Add(this.groupBoxClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderForm";
            this.Text = "Заказ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrderForm_FormClosed);
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.groupBoxClient.ResumeLayout(false);
            this.groupBoxClient.PerformLayout();
            this.groupBoxOrder.ResumeLayout(false);
            this.groupBoxOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxClient;
        private System.Windows.Forms.Button buttonClientDetails;
        private System.Windows.Forms.ComboBox comboBoxAdress;
        private System.Windows.Forms.TextBox textBoxDiscount;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.Label labelOther;
        private System.Windows.Forms.TextBox textBoxOther;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.GroupBox groupBoxOrder;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelSummWithDiscount;
        private System.Windows.Forms.TextBox textBoxSummWithDiscount;
        private System.Windows.Forms.Label labelSumm;
        private System.Windows.Forms.TextBox textBoxSumm;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
    }
}
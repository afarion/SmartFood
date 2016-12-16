namespace SmartFood.Forms
{
    partial class ClientDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientDetailsForm));
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelComment = new System.Windows.Forms.Label();
            this.textBoxOther = new System.Windows.Forms.TextBox();
            this.labelStaticDiscount = new System.Windows.Forms.Label();
            this.labelDinamicDiscount = new System.Windows.Forms.Label();
            this.textBoxStaticDiscunt = new System.Windows.Forms.TextBox();
            this.textBoxDinamicDiscount = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAddDiscount = new System.Windows.Forms.Button();
            this.textBoxEmeil = new System.Windows.Forms.TextBox();
            this.labelEmeil = new System.Windows.Forms.Label();
            this.textBoxTotalSumm = new System.Windows.Forms.TextBox();
            this.labelTotalSumm = new System.Windows.Forms.Label();
            this.textBoxDiscountReasone = new System.Windows.Forms.TextBox();
            this.labelDiscountReasone = new System.Windows.Forms.Label();
            this.comboBoxVisible = new System.Windows.Forms.ComboBox();
            this.labelVisible = new System.Windows.Forms.Label();
            this.dataGridViewAddreses = new System.Windows.Forms.DataGridView();
            this.buttonAddAddress = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddreses)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(12, 9);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(52, 13);
            this.labelPhone.TabIndex = 0;
            this.labelPhone.Text = "Телефон";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(160, 4);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(265, 20);
            this.textBoxPhone.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(13, 33);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Имя";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(160, 28);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(265, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(13, 180);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(69, 13);
            this.labelComment.TabIndex = 6;
            this.labelComment.Text = "Коментарий";
            // 
            // textBoxOther
            // 
            this.textBoxOther.Location = new System.Drawing.Point(160, 176);
            this.textBoxOther.Name = "textBoxOther";
            this.textBoxOther.Size = new System.Drawing.Size(265, 20);
            this.textBoxOther.TabIndex = 7;
            // 
            // labelStaticDiscount
            // 
            this.labelStaticDiscount.AutoSize = true;
            this.labelStaticDiscount.Location = new System.Drawing.Point(13, 82);
            this.labelStaticDiscount.Name = "labelStaticDiscount";
            this.labelStaticDiscount.Size = new System.Drawing.Size(129, 13);
            this.labelStaticDiscount.TabIndex = 8;
            this.labelStaticDiscount.Text = "Фиксированная скидка";
            // 
            // labelDinamicDiscount
            // 
            this.labelDinamicDiscount.AutoSize = true;
            this.labelDinamicDiscount.Location = new System.Drawing.Point(13, 155);
            this.labelDinamicDiscount.Name = "labelDinamicDiscount";
            this.labelDinamicDiscount.Size = new System.Drawing.Size(114, 13);
            this.labelDinamicDiscount.TabIndex = 9;
            this.labelDinamicDiscount.Text = "Накопленная скидка";
            // 
            // textBoxStaticDiscunt
            // 
            this.textBoxStaticDiscunt.Location = new System.Drawing.Point(160, 77);
            this.textBoxStaticDiscunt.Name = "textBoxStaticDiscunt";
            this.textBoxStaticDiscunt.ReadOnly = true;
            this.textBoxStaticDiscunt.Size = new System.Drawing.Size(265, 20);
            this.textBoxStaticDiscunt.TabIndex = 10;
            // 
            // textBoxDinamicDiscount
            // 
            this.textBoxDinamicDiscount.Location = new System.Drawing.Point(160, 150);
            this.textBoxDinamicDiscount.Name = "textBoxDinamicDiscount";
            this.textBoxDinamicDiscount.ReadOnly = true;
            this.textBoxDinamicDiscount.Size = new System.Drawing.Size(265, 20);
            this.textBoxDinamicDiscount.TabIndex = 11;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(361, 383);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(64, 39);
            this.buttonOk.TabIndex = 12;
            this.buttonOk.Text = "ОК";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(291, 383);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(64, 39);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAddDiscount
            // 
            this.buttonAddDiscount.Location = new System.Drawing.Point(198, 383);
            this.buttonAddDiscount.Name = "buttonAddDiscount";
            this.buttonAddDiscount.Size = new System.Drawing.Size(87, 39);
            this.buttonAddDiscount.TabIndex = 14;
            this.buttonAddDiscount.Text = "Добавить скидку";
            this.buttonAddDiscount.UseVisualStyleBackColor = true;
            this.buttonAddDiscount.Click += new System.EventHandler(this.buttonAddDiscount_Click);
            // 
            // textBoxEmeil
            // 
            this.textBoxEmeil.Location = new System.Drawing.Point(160, 53);
            this.textBoxEmeil.Name = "textBoxEmeil";
            this.textBoxEmeil.Size = new System.Drawing.Size(265, 20);
            this.textBoxEmeil.TabIndex = 15;
            // 
            // labelEmeil
            // 
            this.labelEmeil.AutoSize = true;
            this.labelEmeil.Location = new System.Drawing.Point(13, 58);
            this.labelEmeil.Name = "labelEmeil";
            this.labelEmeil.Size = new System.Drawing.Size(32, 13);
            this.labelEmeil.TabIndex = 16;
            this.labelEmeil.Text = "Emeil";
            // 
            // textBoxTotalSumm
            // 
            this.textBoxTotalSumm.Location = new System.Drawing.Point(160, 126);
            this.textBoxTotalSumm.Name = "textBoxTotalSumm";
            this.textBoxTotalSumm.ReadOnly = true;
            this.textBoxTotalSumm.Size = new System.Drawing.Size(265, 20);
            this.textBoxTotalSumm.TabIndex = 17;
            // 
            // labelTotalSumm
            // 
            this.labelTotalSumm.AutoSize = true;
            this.labelTotalSumm.Location = new System.Drawing.Point(13, 131);
            this.labelTotalSumm.Name = "labelTotalSumm";
            this.labelTotalSumm.Size = new System.Drawing.Size(86, 13);
            this.labelTotalSumm.TabIndex = 18;
            this.labelTotalSumm.Text = "Сумма заказов";
            // 
            // textBoxDiscountReasone
            // 
            this.textBoxDiscountReasone.Location = new System.Drawing.Point(160, 102);
            this.textBoxDiscountReasone.Name = "textBoxDiscountReasone";
            this.textBoxDiscountReasone.ReadOnly = true;
            this.textBoxDiscountReasone.Size = new System.Drawing.Size(265, 20);
            this.textBoxDiscountReasone.TabIndex = 19;
            // 
            // labelDiscountReasone
            // 
            this.labelDiscountReasone.AutoSize = true;
            this.labelDiscountReasone.Location = new System.Drawing.Point(13, 106);
            this.labelDiscountReasone.Name = "labelDiscountReasone";
            this.labelDiscountReasone.Size = new System.Drawing.Size(89, 13);
            this.labelDiscountReasone.TabIndex = 20;
            this.labelDiscountReasone.Text = "Причина скидки";
            // 
            // comboBoxVisible
            // 
            this.comboBoxVisible.FormattingEnabled = true;
            this.comboBoxVisible.Location = new System.Drawing.Point(160, 200);
            this.comboBoxVisible.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxVisible.Name = "comboBoxVisible";
            this.comboBoxVisible.Size = new System.Drawing.Size(265, 21);
            this.comboBoxVisible.TabIndex = 21;
            // 
            // labelVisible
            // 
            this.labelVisible.AutoSize = true;
            this.labelVisible.Location = new System.Drawing.Point(13, 206);
            this.labelVisible.Name = "labelVisible";
            this.labelVisible.Size = new System.Drawing.Size(63, 13);
            this.labelVisible.TabIndex = 22;
            this.labelVisible.Text = "Видимость";
            // 
            // dataGridViewAddreses
            // 
            this.dataGridViewAddreses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddreses.Location = new System.Drawing.Point(14, 224);
            this.dataGridViewAddreses.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewAddreses.Name = "dataGridViewAddreses";
            this.dataGridViewAddreses.RowTemplate.Height = 24;
            this.dataGridViewAddreses.Size = new System.Drawing.Size(410, 153);
            this.dataGridViewAddreses.TabIndex = 23;
            // 
            // buttonAddAddress
            // 
            this.buttonAddAddress.Location = new System.Drawing.Point(107, 383);
            this.buttonAddAddress.Name = "buttonAddAddress";
            this.buttonAddAddress.Size = new System.Drawing.Size(87, 39);
            this.buttonAddAddress.TabIndex = 24;
            this.buttonAddAddress.Text = "Добавить Адресс";
            this.buttonAddAddress.UseVisualStyleBackColor = true;
            this.buttonAddAddress.Click += new System.EventHandler(this.buttonAddAddress_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 39);
            this.button1.TabIndex = 25;
            this.button1.Text = "Удалить Адресс";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonDeleteAddress_Click);
            // 
            // ClientDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 426);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAddAddress);
            this.Controls.Add(this.dataGridViewAddreses);
            this.Controls.Add(this.labelVisible);
            this.Controls.Add(this.comboBoxVisible);
            this.Controls.Add(this.labelDiscountReasone);
            this.Controls.Add(this.textBoxDiscountReasone);
            this.Controls.Add(this.labelTotalSumm);
            this.Controls.Add(this.textBoxTotalSumm);
            this.Controls.Add(this.labelEmeil);
            this.Controls.Add(this.textBoxEmeil);
            this.Controls.Add(this.buttonAddDiscount);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxDinamicDiscount);
            this.Controls.Add(this.textBoxStaticDiscunt);
            this.Controls.Add(this.labelDinamicDiscount);
            this.Controls.Add(this.labelStaticDiscount);
            this.Controls.Add(this.textBoxOther);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelPhone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientDetailsForm";
            this.Text = "Информация о клиенте";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClientDetailsForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddreses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.TextBox textBoxOther;
        private System.Windows.Forms.Label labelStaticDiscount;
        private System.Windows.Forms.Label labelDinamicDiscount;
        private System.Windows.Forms.TextBox textBoxStaticDiscunt;
        private System.Windows.Forms.TextBox textBoxDinamicDiscount;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAddDiscount;
        private System.Windows.Forms.TextBox textBoxEmeil;
        private System.Windows.Forms.Label labelEmeil;
        private System.Windows.Forms.TextBox textBoxTotalSumm;
        private System.Windows.Forms.Label labelTotalSumm;
        private System.Windows.Forms.TextBox textBoxDiscountReasone;
        private System.Windows.Forms.Label labelDiscountReasone;
        private System.Windows.Forms.ComboBox comboBoxVisible;
        private System.Windows.Forms.Label labelVisible;
        private System.Windows.Forms.DataGridView dataGridViewAddreses;
        private System.Windows.Forms.Button buttonAddAddress;
        private System.Windows.Forms.Button button1;
    }
}
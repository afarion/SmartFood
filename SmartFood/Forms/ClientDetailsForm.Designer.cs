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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddreses)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(16, 11);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(68, 16);
            this.labelPhone.TabIndex = 0;
            this.labelPhone.Text = "Телефон";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(214, 5);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(352, 22);
            this.textBoxPhone.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(17, 41);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(34, 16);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Имя";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(214, 35);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(352, 22);
            this.textBoxName.TabIndex = 3;
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(17, 222);
            this.labelComment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(88, 16);
            this.labelComment.TabIndex = 6;
            this.labelComment.Text = "Коментарий";
            // 
            // textBoxOther
            // 
            this.textBoxOther.Location = new System.Drawing.Point(214, 216);
            this.textBoxOther.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxOther.Name = "textBoxOther";
            this.textBoxOther.Size = new System.Drawing.Size(352, 22);
            this.textBoxOther.TabIndex = 7;
            // 
            // labelStaticDiscount
            // 
            this.labelStaticDiscount.AutoSize = true;
            this.labelStaticDiscount.Location = new System.Drawing.Point(17, 101);
            this.labelStaticDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStaticDiscount.Name = "labelStaticDiscount";
            this.labelStaticDiscount.Size = new System.Drawing.Size(160, 16);
            this.labelStaticDiscount.TabIndex = 8;
            this.labelStaticDiscount.Text = "Фиксированная скидка";
            // 
            // labelDinamicDiscount
            // 
            this.labelDinamicDiscount.AutoSize = true;
            this.labelDinamicDiscount.Location = new System.Drawing.Point(17, 191);
            this.labelDinamicDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDinamicDiscount.Name = "labelDinamicDiscount";
            this.labelDinamicDiscount.Size = new System.Drawing.Size(144, 16);
            this.labelDinamicDiscount.TabIndex = 9;
            this.labelDinamicDiscount.Text = "Накопленная скидка";
            // 
            // textBoxStaticDiscunt
            // 
            this.textBoxStaticDiscunt.Location = new System.Drawing.Point(214, 95);
            this.textBoxStaticDiscunt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxStaticDiscunt.Name = "textBoxStaticDiscunt";
            this.textBoxStaticDiscunt.ReadOnly = true;
            this.textBoxStaticDiscunt.Size = new System.Drawing.Size(352, 22);
            this.textBoxStaticDiscunt.TabIndex = 10;
            // 
            // textBoxDinamicDiscount
            // 
            this.textBoxDinamicDiscount.Location = new System.Drawing.Point(214, 185);
            this.textBoxDinamicDiscount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDinamicDiscount.Name = "textBoxDinamicDiscount";
            this.textBoxDinamicDiscount.ReadOnly = true;
            this.textBoxDinamicDiscount.Size = new System.Drawing.Size(352, 22);
            this.textBoxDinamicDiscount.TabIndex = 11;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(481, 471);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(85, 28);
            this.buttonOk.TabIndex = 12;
            this.buttonOk.Text = "ОК";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(388, 471);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(85, 28);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAddDiscount
            // 
            this.buttonAddDiscount.Location = new System.Drawing.Point(191, 471);
            this.buttonAddDiscount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddDiscount.Name = "buttonAddDiscount";
            this.buttonAddDiscount.Size = new System.Drawing.Size(179, 28);
            this.buttonAddDiscount.TabIndex = 14;
            this.buttonAddDiscount.Text = "Добавить скидку";
            this.buttonAddDiscount.UseVisualStyleBackColor = true;
            this.buttonAddDiscount.Click += new System.EventHandler(this.buttonAddDiscount_Click);
            // 
            // textBoxEmeil
            // 
            this.textBoxEmeil.Location = new System.Drawing.Point(214, 65);
            this.textBoxEmeil.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmeil.Name = "textBoxEmeil";
            this.textBoxEmeil.Size = new System.Drawing.Size(352, 22);
            this.textBoxEmeil.TabIndex = 15;
            // 
            // labelEmeil
            // 
            this.labelEmeil.AutoSize = true;
            this.labelEmeil.Location = new System.Drawing.Point(17, 71);
            this.labelEmeil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmeil.Name = "labelEmeil";
            this.labelEmeil.Size = new System.Drawing.Size(42, 16);
            this.labelEmeil.TabIndex = 16;
            this.labelEmeil.Text = "Emeil";
            // 
            // textBoxTotalSumm
            // 
            this.textBoxTotalSumm.Location = new System.Drawing.Point(214, 155);
            this.textBoxTotalSumm.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTotalSumm.Name = "textBoxTotalSumm";
            this.textBoxTotalSumm.ReadOnly = true;
            this.textBoxTotalSumm.Size = new System.Drawing.Size(352, 22);
            this.textBoxTotalSumm.TabIndex = 17;
            // 
            // labelTotalSumm
            // 
            this.labelTotalSumm.AutoSize = true;
            this.labelTotalSumm.Location = new System.Drawing.Point(17, 161);
            this.labelTotalSumm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalSumm.Name = "labelTotalSumm";
            this.labelTotalSumm.Size = new System.Drawing.Size(109, 16);
            this.labelTotalSumm.TabIndex = 18;
            this.labelTotalSumm.Text = "Сумма заказов";
            // 
            // textBoxDiscountReasone
            // 
            this.textBoxDiscountReasone.Location = new System.Drawing.Point(214, 125);
            this.textBoxDiscountReasone.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDiscountReasone.Name = "textBoxDiscountReasone";
            this.textBoxDiscountReasone.ReadOnly = true;
            this.textBoxDiscountReasone.Size = new System.Drawing.Size(352, 22);
            this.textBoxDiscountReasone.TabIndex = 19;
            // 
            // labelDiscountReasone
            // 
            this.labelDiscountReasone.AutoSize = true;
            this.labelDiscountReasone.Location = new System.Drawing.Point(17, 131);
            this.labelDiscountReasone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDiscountReasone.Name = "labelDiscountReasone";
            this.labelDiscountReasone.Size = new System.Drawing.Size(114, 16);
            this.labelDiscountReasone.TabIndex = 20;
            this.labelDiscountReasone.Text = "Причина скидки";
            // 
            // comboBoxVisible
            // 
            this.comboBoxVisible.FormattingEnabled = true;
            this.comboBoxVisible.Location = new System.Drawing.Point(214, 246);
            this.comboBoxVisible.Name = "comboBoxVisible";
            this.comboBoxVisible.Size = new System.Drawing.Size(352, 24);
            this.comboBoxVisible.TabIndex = 21;
            // 
            // labelVisible
            // 
            this.labelVisible.AutoSize = true;
            this.labelVisible.Location = new System.Drawing.Point(17, 254);
            this.labelVisible.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVisible.Name = "labelVisible";
            this.labelVisible.Size = new System.Drawing.Size(79, 16);
            this.labelVisible.TabIndex = 22;
            this.labelVisible.Text = "Видимость";
            // 
            // dataGridViewAddreses
            // 
            this.dataGridViewAddreses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddreses.Location = new System.Drawing.Point(19, 276);
            this.dataGridViewAddreses.Name = "dataGridViewAddreses";
            this.dataGridViewAddreses.RowTemplate.Height = 24;
            this.dataGridViewAddreses.Size = new System.Drawing.Size(547, 188);
            this.dataGridViewAddreses.TabIndex = 23;
            // 
            // buttonAddAddress
            // 
            this.buttonAddAddress.Location = new System.Drawing.Point(20, 471);
            this.buttonAddAddress.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddAddress.Name = "buttonAddAddress";
            this.buttonAddAddress.Size = new System.Drawing.Size(163, 28);
            this.buttonAddAddress.TabIndex = 24;
            this.buttonAddAddress.Text = "Добавить Адресс";
            this.buttonAddAddress.UseVisualStyleBackColor = true;
            // 
            // ClientDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 512);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    }
}
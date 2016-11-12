namespace SmartFood.Forms
{
    partial class CustomerDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDetailsForm));
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.textBoxOther = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxCurrentDiscount = new System.Windows.Forms.TextBox();
            this.textBoxSummToNextDiscount = new System.Windows.Forms.TextBox();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.textBoxSumm = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSumm = new System.Windows.Forms.Label();
            this.labelAdress = new System.Windows.Forms.Label();
            this.labelOther = new System.Windows.Forms.Label();
            this.labelCurrentDiscount = new System.Windows.Forms.Label();
            this.labelSummToNextDiscount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(580, 553);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "Ок";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(13, 28);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(141, 20);
            this.textBoxPhone.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(176, 28);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(273, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(13, 67);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(432, 20);
            this.textBoxAdress.TabIndex = 3;
            // 
            // textBoxOther
            // 
            this.textBoxOther.Location = new System.Drawing.Point(16, 106);
            this.textBoxOther.Name = "textBoxOther";
            this.textBoxOther.Size = new System.Drawing.Size(433, 20);
            this.textBoxOther.TabIndex = 4;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(499, 553);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // textBoxCurrentDiscount
            // 
            this.textBoxCurrentDiscount.Location = new System.Drawing.Point(466, 67);
            this.textBoxCurrentDiscount.Name = "textBoxCurrentDiscount";
            this.textBoxCurrentDiscount.ReadOnly = true;
            this.textBoxCurrentDiscount.Size = new System.Drawing.Size(189, 20);
            this.textBoxCurrentDiscount.TabIndex = 6;
            // 
            // textBoxSummToNextDiscount
            // 
            this.textBoxSummToNextDiscount.Location = new System.Drawing.Point(466, 106);
            this.textBoxSummToNextDiscount.Name = "textBoxSummToNextDiscount";
            this.textBoxSummToNextDiscount.ReadOnly = true;
            this.textBoxSummToNextDiscount.Size = new System.Drawing.Size(189, 20);
            this.textBoxSummToNextDiscount.TabIndex = 7;
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(13, 141);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.Size = new System.Drawing.Size(642, 393);
            this.dataGridViewOrders.TabIndex = 8;
            // 
            // textBoxSumm
            // 
            this.textBoxSumm.Location = new System.Drawing.Point(466, 28);
            this.textBoxSumm.Name = "textBoxSumm";
            this.textBoxSumm.ReadOnly = true;
            this.textBoxSumm.Size = new System.Drawing.Size(189, 20);
            this.textBoxSumm.TabIndex = 9;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(10, 9);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(52, 13);
            this.labelPhone.TabIndex = 10;
            this.labelPhone.Text = "Телефон";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(173, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 11;
            this.labelName.Text = "Имя";
            // 
            // labelSumm
            // 
            this.labelSumm.AutoSize = true;
            this.labelSumm.Location = new System.Drawing.Point(463, 9);
            this.labelSumm.Name = "labelSumm";
            this.labelSumm.Size = new System.Drawing.Size(79, 13);
            this.labelSumm.TabIndex = 12;
            this.labelSumm.Text = "Общая Сумма";
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Location = new System.Drawing.Point(10, 51);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(38, 13);
            this.labelAdress.TabIndex = 13;
            this.labelAdress.Text = "Адрес";
            // 
            // labelOther
            // 
            this.labelOther.AutoSize = true;
            this.labelOther.Location = new System.Drawing.Point(13, 90);
            this.labelOther.Name = "labelOther";
            this.labelOther.Size = new System.Drawing.Size(44, 13);
            this.labelOther.TabIndex = 14;
            this.labelOther.Text = "Прочее";
            // 
            // labelCurrentDiscount
            // 
            this.labelCurrentDiscount.AutoSize = true;
            this.labelCurrentDiscount.Location = new System.Drawing.Point(463, 51);
            this.labelCurrentDiscount.Name = "labelCurrentDiscount";
            this.labelCurrentDiscount.Size = new System.Drawing.Size(91, 13);
            this.labelCurrentDiscount.TabIndex = 15;
            this.labelCurrentDiscount.Text = "Текущая скидка";
            // 
            // labelSummToNextDiscount
            // 
            this.labelSummToNextDiscount.AutoSize = true;
            this.labelSummToNextDiscount.Location = new System.Drawing.Point(463, 90);
            this.labelSummToNextDiscount.Name = "labelSummToNextDiscount";
            this.labelSummToNextDiscount.Size = new System.Drawing.Size(156, 13);
            this.labelSummToNextDiscount.TabIndex = 16;
            this.labelSummToNextDiscount.Text = "Сумма до следующей скидки";
            // 
            // CustomerDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 588);
            this.Controls.Add(this.labelSummToNextDiscount);
            this.Controls.Add(this.labelCurrentDiscount);
            this.Controls.Add(this.labelOther);
            this.Controls.Add(this.labelAdress);
            this.Controls.Add(this.labelSumm);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.textBoxSumm);
            this.Controls.Add(this.dataGridViewOrders);
            this.Controls.Add(this.textBoxSummToNextDiscount);
            this.Controls.Add(this.textBoxCurrentDiscount);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxOther);
            this.Controls.Add(this.textBoxAdress);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerDetailsForm";
            this.Text = "Информация о клиенте";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.TextBox textBoxOther;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxCurrentDiscount;
        private System.Windows.Forms.TextBox textBoxSummToNextDiscount;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.TextBox textBoxSumm;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSumm;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.Label labelOther;
        private System.Windows.Forms.Label labelCurrentDiscount;
        private System.Windows.Forms.Label labelSummToNextDiscount;
    }
}
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
            this.labelAdress = new System.Windows.Forms.Label();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.labelOther = new System.Windows.Forms.Label();
            this.textBoxOther = new System.Windows.Forms.TextBox();
            this.labelStaticDiscount = new System.Windows.Forms.Label();
            this.labelDinamicDiscount = new System.Windows.Forms.Label();
            this.textBoxStaticDiscunt = new System.Windows.Forms.TextBox();
            this.textBoxDinamicDiscount = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAddDiscount = new System.Windows.Forms.Button();
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
            this.textBoxPhone.Location = new System.Drawing.Point(15, 26);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(265, 20);
            this.textBoxPhone.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 49);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Имя";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(15, 65);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(265, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Location = new System.Drawing.Point(12, 88);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(38, 13);
            this.labelAdress.TabIndex = 4;
            this.labelAdress.Text = "Адрес";
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(15, 104);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(265, 20);
            this.textBoxAdress.TabIndex = 5;
            // 
            // labelOther
            // 
            this.labelOther.AutoSize = true;
            this.labelOther.Location = new System.Drawing.Point(12, 127);
            this.labelOther.Name = "labelOther";
            this.labelOther.Size = new System.Drawing.Size(44, 13);
            this.labelOther.TabIndex = 6;
            this.labelOther.Text = "Прочее";
            // 
            // textBoxOther
            // 
            this.textBoxOther.Location = new System.Drawing.Point(15, 143);
            this.textBoxOther.Name = "textBoxOther";
            this.textBoxOther.Size = new System.Drawing.Size(265, 20);
            this.textBoxOther.TabIndex = 7;
            // 
            // labelStaticDiscount
            // 
            this.labelStaticDiscount.AutoSize = true;
            this.labelStaticDiscount.Location = new System.Drawing.Point(12, 166);
            this.labelStaticDiscount.Name = "labelStaticDiscount";
            this.labelStaticDiscount.Size = new System.Drawing.Size(110, 13);
            this.labelStaticDiscount.TabIndex = 8;
            this.labelStaticDiscount.Text = "Статическая скидка";
            // 
            // labelDinamicDiscount
            // 
            this.labelDinamicDiscount.AutoSize = true;
            this.labelDinamicDiscount.Location = new System.Drawing.Point(158, 166);
            this.labelDinamicDiscount.Name = "labelDinamicDiscount";
            this.labelDinamicDiscount.Size = new System.Drawing.Size(122, 13);
            this.labelDinamicDiscount.TabIndex = 9;
            this.labelDinamicDiscount.Text = "Динамическая скидка";
            // 
            // textBoxStaticDiscunt
            // 
            this.textBoxStaticDiscunt.Location = new System.Drawing.Point(15, 183);
            this.textBoxStaticDiscunt.Name = "textBoxStaticDiscunt";
            this.textBoxStaticDiscunt.ReadOnly = true;
            this.textBoxStaticDiscunt.Size = new System.Drawing.Size(107, 20);
            this.textBoxStaticDiscunt.TabIndex = 10;
            // 
            // textBoxDinamicDiscount
            // 
            this.textBoxDinamicDiscount.Location = new System.Drawing.Point(173, 183);
            this.textBoxDinamicDiscount.Name = "textBoxDinamicDiscount";
            this.textBoxDinamicDiscount.ReadOnly = true;
            this.textBoxDinamicDiscount.Size = new System.Drawing.Size(107, 20);
            this.textBoxDinamicDiscount.TabIndex = 11;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(216, 209);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(64, 23);
            this.buttonOk.TabIndex = 12;
            this.buttonOk.Text = "ОК";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(146, 209);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(64, 23);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAddDiscount
            // 
            this.buttonAddDiscount.Location = new System.Drawing.Point(15, 209);
            this.buttonAddDiscount.Name = "buttonAddDiscount";
            this.buttonAddDiscount.Size = new System.Drawing.Size(125, 23);
            this.buttonAddDiscount.TabIndex = 14;
            this.buttonAddDiscount.Text = "Добавить скидку";
            this.buttonAddDiscount.UseVisualStyleBackColor = true;
            this.buttonAddDiscount.Click += new System.EventHandler(this.buttonAddDiscount_Click);
            // 
            // ClientDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 244);
            this.Controls.Add(this.buttonAddDiscount);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxDinamicDiscount);
            this.Controls.Add(this.textBoxStaticDiscunt);
            this.Controls.Add(this.labelDinamicDiscount);
            this.Controls.Add(this.labelStaticDiscount);
            this.Controls.Add(this.textBoxOther);
            this.Controls.Add(this.labelOther);
            this.Controls.Add(this.textBoxAdress);
            this.Controls.Add(this.labelAdress);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelPhone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientDetailsForm";
            this.Text = "ClientDetailsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClientDetailsForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.Label labelOther;
        private System.Windows.Forms.TextBox textBoxOther;
        private System.Windows.Forms.Label labelStaticDiscount;
        private System.Windows.Forms.Label labelDinamicDiscount;
        private System.Windows.Forms.TextBox textBoxStaticDiscunt;
        private System.Windows.Forms.TextBox textBoxDinamicDiscount;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAddDiscount;
    }
}
namespace SmartFood.Forms
{
    partial class ConsumbleArrivalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsumbleArrivalForm));
            this.comboBoxConsumbles = new System.Windows.Forms.ComboBox();
            this.comboBoxSupplier = new System.Windows.Forms.ComboBox();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelSupplier = new System.Windows.Forms.Label();
            this.labelCook = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxCook = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxConsumbles
            // 
            this.comboBoxConsumbles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConsumbles.FormattingEnabled = true;
            this.comboBoxConsumbles.Location = new System.Drawing.Point(129, 62);
            this.comboBoxConsumbles.Name = "comboBoxConsumbles";
            this.comboBoxConsumbles.Size = new System.Drawing.Size(165, 21);
            this.comboBoxConsumbles.TabIndex = 2;
            // 
            // comboBoxSupplier
            // 
            this.comboBoxSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSupplier.FormattingEnabled = true;
            this.comboBoxSupplier.Location = new System.Drawing.Point(129, 141);
            this.comboBoxSupplier.Name = "comboBoxSupplier";
            this.comboBoxSupplier.Size = new System.Drawing.Size(165, 21);
            this.comboBoxSupplier.TabIndex = 5;
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(129, 89);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(165, 20);
            this.textBoxCount.TabIndex = 3;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(129, 115);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(165, 20);
            this.textBoxPrice.TabIndex = 4;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(3, 65);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(83, 13);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Наименование";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(3, 92);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(90, 13);
            this.labelCount.TabIndex = 7;
            this.labelCount.Text = "Количество/Вес";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(3, 118);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(33, 13);
            this.labelPrice.TabIndex = 8;
            this.labelPrice.Text = "Цена";
            // 
            // labelSupplier
            // 
            this.labelSupplier.AutoSize = true;
            this.labelSupplier.Location = new System.Drawing.Point(3, 144);
            this.labelSupplier.Name = "labelSupplier";
            this.labelSupplier.Size = new System.Drawing.Size(65, 13);
            this.labelSupplier.TabIndex = 9;
            this.labelSupplier.Text = "Поставщик";
            // 
            // labelCook
            // 
            this.labelCook.AutoSize = true;
            this.labelCook.Location = new System.Drawing.Point(3, 171);
            this.labelCook.Name = "labelCook";
            this.labelCook.Size = new System.Drawing.Size(97, 13);
            this.labelCook.TabIndex = 11;
            this.labelCook.Text = "Повар Приемщик";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(219, 195);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 7;
            this.buttonOk.Text = "Ок";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(138, 195);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // comboBoxCook
            // 
            this.comboBoxCook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCook.FormattingEnabled = true;
            this.comboBoxCook.Location = new System.Drawing.Point(129, 168);
            this.comboBoxCook.Name = "comboBoxCook";
            this.comboBoxCook.Size = new System.Drawing.Size(165, 21);
            this.comboBoxCook.TabIndex = 6;
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(129, 11);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(165, 21);
            this.comboBoxType.TabIndex = 0;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(3, 14);
            this.labelType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(88, 13);
            this.labelType.TabIndex = 15;
            this.labelType.Text = "Тип расходника";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(129, 36);
            this.comboBoxCategory.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(165, 21);
            this.comboBoxCategory.TabIndex = 1;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(3, 39);
            this.labelCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(122, 13);
            this.labelCategory.TabIndex = 17;
            this.labelCategory.Text = "Категория расходника";
            // 
            // ConsumbleArrivalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 223);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.comboBoxCook);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelCook);
            this.Controls.Add(this.labelSupplier);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.comboBoxSupplier);
            this.Controls.Add(this.comboBoxConsumbles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsumbleArrivalForm";
            this.Text = "Приход расходника";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConsumbleArrivalForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxConsumbles;
        private System.Windows.Forms.ComboBox comboBoxSupplier;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelSupplier;
        private System.Windows.Forms.Label labelCook;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxCook;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label labelCategory;
    }
}
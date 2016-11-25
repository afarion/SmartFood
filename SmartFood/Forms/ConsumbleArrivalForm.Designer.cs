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
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.comboBoxSupplier = new System.Windows.Forms.ComboBox();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelSupplier = new System.Windows.Forms.Label();
            this.textBoxCook = new System.Windows.Forms.TextBox();
            this.labelCook = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxName
            // 
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(115, 12);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(165, 21);
            this.comboBoxName.TabIndex = 2;
            // 
            // comboBoxSupplier
            // 
            this.comboBoxSupplier.FormattingEnabled = true;
            this.comboBoxSupplier.Location = new System.Drawing.Point(115, 91);
            this.comboBoxSupplier.Name = "comboBoxSupplier";
            this.comboBoxSupplier.Size = new System.Drawing.Size(165, 21);
            this.comboBoxSupplier.TabIndex = 3;
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(115, 39);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(165, 20);
            this.textBoxCount.TabIndex = 4;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(115, 65);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(165, 20);
            this.textBoxPrice.TabIndex = 5;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 15);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(83, 13);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Наименование";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(12, 42);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(90, 13);
            this.labelCount.TabIndex = 7;
            this.labelCount.Text = "Количество/Вес";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(12, 68);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(33, 13);
            this.labelPrice.TabIndex = 8;
            this.labelPrice.Text = "Цена";
            // 
            // labelSupplier
            // 
            this.labelSupplier.AutoSize = true;
            this.labelSupplier.Location = new System.Drawing.Point(12, 94);
            this.labelSupplier.Name = "labelSupplier";
            this.labelSupplier.Size = new System.Drawing.Size(65, 13);
            this.labelSupplier.TabIndex = 9;
            this.labelSupplier.Text = "Поставщик";
            // 
            // textBoxCook
            // 
            this.textBoxCook.Location = new System.Drawing.Point(115, 118);
            this.textBoxCook.Name = "textBoxCook";
            this.textBoxCook.Size = new System.Drawing.Size(165, 20);
            this.textBoxCook.TabIndex = 10;
            // 
            // labelCook
            // 
            this.labelCook.AutoSize = true;
            this.labelCook.Location = new System.Drawing.Point(12, 121);
            this.labelCook.Name = "labelCook";
            this.labelCook.Size = new System.Drawing.Size(97, 13);
            this.labelCook.TabIndex = 11;
            this.labelCook.Text = "Повар Приемщик";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(214, 157);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 12;
            this.buttonOk.Text = "Ок";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(133, 157);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // ConsumbleArrivalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 183);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelCook);
            this.Controls.Add(this.textBoxCook);
            this.Controls.Add(this.labelSupplier);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.comboBoxSupplier);
            this.Controls.Add(this.comboBoxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsumbleArrivalForm";
            this.Text = "ConsumbleArrivalForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConsumbleArrivalForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.ComboBox comboBoxSupplier;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelSupplier;
        private System.Windows.Forms.TextBox textBoxCook;
        private System.Windows.Forms.Label labelCook;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}
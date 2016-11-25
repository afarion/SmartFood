namespace SmartFood.Forms
{
    partial class NewConsumbleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewConsumbleForm));
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxMeasurement = new System.Windows.Forms.TextBox();
            this.labelMeasurement = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(137, 9);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(165, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(137, 35);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(165, 21);
            this.comboBoxType.TabIndex = 1;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(137, 88);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(165, 20);
            this.textBoxPrice.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(13, 12);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(83, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Наименование";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(13, 38);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(26, 13);
            this.labelType.TabIndex = 4;
            this.labelType.Text = "Тип";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(13, 91);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(33, 13);
            this.labelPrice.TabIndex = 5;
            this.labelPrice.Text = "Цена";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(227, 114);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 6;
            this.buttonOk.Text = "Ок";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(137, 114);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxMeasurement
            // 
            this.textBoxMeasurement.Location = new System.Drawing.Point(137, 62);
            this.textBoxMeasurement.Name = "textBoxMeasurement";
            this.textBoxMeasurement.Size = new System.Drawing.Size(165, 20);
            this.textBoxMeasurement.TabIndex = 8;
            // 
            // labelMeasurement
            // 
            this.labelMeasurement.AutoSize = true;
            this.labelMeasurement.Location = new System.Drawing.Point(12, 65);
            this.labelMeasurement.Name = "labelMeasurement";
            this.labelMeasurement.Size = new System.Drawing.Size(109, 13);
            this.labelMeasurement.TabIndex = 9;
            this.labelMeasurement.Text = "Единица измерения";
            // 
            // NewConsumbleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 145);
            this.Controls.Add(this.labelMeasurement);
            this.Controls.Add(this.textBoxMeasurement);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.textBoxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewConsumbleForm";
            this.Text = "NewConsumbleForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewConsumbleForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxMeasurement;
        private System.Windows.Forms.Label labelMeasurement;
    }
}
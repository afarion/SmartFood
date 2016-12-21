namespace SmartFood.Forms
{
    partial class NewGoodsConsumble
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewGoodsConsumble));
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.comboBoxConsumbles = new System.Windows.Forms.ComboBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.labelType = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelConsumble = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(189, 42);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(315, 24);
            this.comboBoxCategory.TabIndex = 2;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(189, 12);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(315, 24);
            this.comboBoxType.TabIndex = 1;
            // 
            // comboBoxConsumbles
            // 
            this.comboBoxConsumbles.FormattingEnabled = true;
            this.comboBoxConsumbles.Location = new System.Drawing.Point(189, 72);
            this.comboBoxConsumbles.Name = "comboBoxConsumbles";
            this.comboBoxConsumbles.Size = new System.Drawing.Size(315, 24);
            this.comboBoxConsumbles.TabIndex = 3;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(189, 103);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(315, 22);
            this.textBoxWeight.TabIndex = 4;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(13, 13);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(112, 16);
            this.labelType.TabIndex = 6;
            this.labelType.Text = "Тип расходника";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(13, 45);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(155, 16);
            this.labelCategory.TabIndex = 7;
            this.labelCategory.Text = "Категория расходника";
            // 
            // labelConsumble
            // 
            this.labelConsumble.AutoSize = true;
            this.labelConsumble.Location = new System.Drawing.Point(13, 80);
            this.labelConsumble.Name = "labelConsumble";
            this.labelConsumble.Size = new System.Drawing.Size(77, 16);
            this.labelConsumble.TabIndex = 8;
            this.labelConsumble.Text = "Расходник";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(13, 109);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(111, 16);
            this.labelWeight.TabIndex = 9;
            this.labelWeight.Text = "Вес расходника";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(404, 131);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(100, 28);
            this.buttonOk.TabIndex = 5;
            this.buttonOk.Text = "Ок";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(298, 131);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 28);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // NewGoodsConsumble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 174);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelConsumble);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.comboBoxConsumbles);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.comboBoxCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewGoodsConsumble";
            this.Text = "Новый Ингридиент";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewGoodsConsumble_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ComboBox comboBoxConsumbles;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelConsumble;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}
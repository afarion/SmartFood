namespace SmartFood.Forms
{
    partial class GoodDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoodDetailsForm));
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAddConsumble = new System.Windows.Forms.Button();
            this.dataGridViewConsumbles = new System.Windows.Forms.DataGridView();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsumbles)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(16, 30);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(315, 22);
            this.textBoxName.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 10);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(107, 16);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Наименование";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(232, 416);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(100, 28);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "ОК";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(124, 416);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 28);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAddConsumble
            // 
            this.buttonAddConsumble.Location = new System.Drawing.Point(16, 416);
            this.buttonAddConsumble.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddConsumble.Name = "buttonAddConsumble";
            this.buttonAddConsumble.Size = new System.Drawing.Size(100, 28);
            this.buttonAddConsumble.TabIndex = 4;
            this.buttonAddConsumble.Text = "Ингридиент";
            this.buttonAddConsumble.UseVisualStyleBackColor = true;
            // 
            // dataGridViewConsumbles
            // 
            this.dataGridViewConsumbles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsumbles.Location = new System.Drawing.Point(16, 107);
            this.dataGridViewConsumbles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewConsumbles.Name = "dataGridViewConsumbles";
            this.dataGridViewConsumbles.Size = new System.Drawing.Size(316, 302);
            this.dataGridViewConsumbles.TabIndex = 5;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(16, 58);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(41, 16);
            this.labelPrice.TabIndex = 6;
            this.labelPrice.Text = "Цена";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(16, 78);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(315, 22);
            this.textBoxPrice.TabIndex = 7;
            // 
            // GoodDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 459);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.dataGridViewConsumbles);
            this.Controls.Add(this.buttonAddConsumble);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GoodDetailsForm";
            this.Text = "Товар";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GoodDetailsForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsumbles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAddConsumble;
        private System.Windows.Forms.DataGridView dataGridViewConsumbles;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxPrice;
    }
}
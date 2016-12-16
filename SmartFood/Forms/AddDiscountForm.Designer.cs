namespace SmartFood.Forms
{
    partial class AddDiscountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDiscountForm));
            this.labelDiscount = new System.Windows.Forms.Label();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            this.labelReasone = new System.Windows.Forms.Label();
            this.richTextBoxReasone = new System.Windows.Forms.RichTextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Location = new System.Drawing.Point(16, 20);
            this.labelDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(55, 16);
            this.labelDiscount.TabIndex = 0;
            this.labelDiscount.Text = "Скидка";
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.Location = new System.Drawing.Point(111, 16);
            this.textBoxDiscount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.Size = new System.Drawing.Size(248, 22);
            this.textBoxDiscount.TabIndex = 1;
            // 
            // labelReasone
            // 
            this.labelReasone.AutoSize = true;
            this.labelReasone.Location = new System.Drawing.Point(16, 44);
            this.labelReasone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelReasone.Name = "labelReasone";
            this.labelReasone.Size = new System.Drawing.Size(114, 16);
            this.labelReasone.TabIndex = 2;
            this.labelReasone.Text = "Причина скидки";
            // 
            // richTextBoxReasone
            // 
            this.richTextBoxReasone.Location = new System.Drawing.Point(20, 64);
            this.richTextBoxReasone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBoxReasone.Name = "richTextBoxReasone";
            this.richTextBoxReasone.Size = new System.Drawing.Size(339, 128);
            this.richTextBoxReasone.TabIndex = 3;
            this.richTextBoxReasone.Text = "";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(259, 202);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(100, 28);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "ОК";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(151, 202);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 28);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // AddDiscountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 235);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.richTextBoxReasone);
            this.Controls.Add(this.labelReasone);
            this.Controls.Add(this.textBoxDiscount);
            this.Controls.Add(this.labelDiscount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddDiscountForm";
            this.Text = "Скидка";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddDiscountForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.TextBox textBoxDiscount;
        private System.Windows.Forms.Label labelReasone;
        private System.Windows.Forms.RichTextBox richTextBoxReasone;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}
namespace SmartFood.Forms
{
    partial class ConsumbleWriteOffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsumbleWriteOffForm));
            this.comboBoxConsumbles = new System.Windows.Forms.ComboBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelCook = new System.Windows.Forms.Label();
            this.richTextBoxComment = new System.Windows.Forms.RichTextBox();
            this.labelReasone = new System.Windows.Forms.Label();
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
            this.comboBoxConsumbles.Location = new System.Drawing.Point(127, 62);
            this.comboBoxConsumbles.Name = "comboBoxConsumbles";
            this.comboBoxConsumbles.Size = new System.Drawing.Size(165, 21);
            this.comboBoxConsumbles.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(1, 65);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(83, 13);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Наименование";
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(127, 89);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(165, 20);
            this.textBoxCount.TabIndex = 8;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(1, 92);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(90, 13);
            this.labelCount.TabIndex = 9;
            this.labelCount.Text = "Количество/Вес";
            // 
            // labelCook
            // 
            this.labelCook.AutoSize = true;
            this.labelCook.Location = new System.Drawing.Point(1, 118);
            this.labelCook.Name = "labelCook";
            this.labelCook.Size = new System.Drawing.Size(97, 13);
            this.labelCook.TabIndex = 12;
            this.labelCook.Text = "Повар Приемщик";
            // 
            // richTextBoxComment
            // 
            this.richTextBoxComment.Location = new System.Drawing.Point(4, 142);
            this.richTextBoxComment.Name = "richTextBoxComment";
            this.richTextBoxComment.Size = new System.Drawing.Size(288, 54);
            this.richTextBoxComment.TabIndex = 13;
            this.richTextBoxComment.Text = "";
            // 
            // labelReasone
            // 
            this.labelReasone.AutoSize = true;
            this.labelReasone.Location = new System.Drawing.Point(1, 202);
            this.labelReasone.Name = "labelReasone";
            this.labelReasone.Size = new System.Drawing.Size(50, 13);
            this.labelReasone.TabIndex = 14;
            this.labelReasone.Text = "Причина";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(217, 202);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 15;
            this.buttonOk.Text = "Ок";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(136, 202);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // comboBoxCook
            // 
            this.comboBoxCook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCook.FormattingEnabled = true;
            this.comboBoxCook.Location = new System.Drawing.Point(127, 115);
            this.comboBoxCook.Name = "comboBoxCook";
            this.comboBoxCook.Size = new System.Drawing.Size(165, 21);
            this.comboBoxCook.TabIndex = 17;
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(127, 11);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(165, 21);
            this.comboBoxType.TabIndex = 18;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(1, 14);
            this.labelType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(88, 13);
            this.labelType.TabIndex = 19;
            this.labelType.Text = "Тип расходника";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(127, 36);
            this.comboBoxCategory.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(165, 21);
            this.comboBoxCategory.TabIndex = 20;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(1, 39);
            this.labelCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(122, 13);
            this.labelCategory.TabIndex = 21;
            this.labelCategory.Text = "Категория расходника";
            // 
            // ConsumbleWriteOffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 234);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.comboBoxCook);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelReasone);
            this.Controls.Add(this.richTextBoxComment);
            this.Controls.Add(this.labelCook);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.comboBoxConsumbles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsumbleWriteOffForm";
            this.Text = "Списание расходника";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConsumbleWriteOffForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxConsumbles;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelCook;
        private System.Windows.Forms.RichTextBox richTextBoxComment;
        private System.Windows.Forms.Label labelReasone;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxCook;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label labelCategory;
    }
}
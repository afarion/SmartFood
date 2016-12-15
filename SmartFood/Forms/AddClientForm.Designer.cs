namespace SmartFood.Forms
{
    partial class AddClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddClientForm));
            this.buttonOk = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelEmeil = new System.Windows.Forms.Label();
            this.textBoxEmeil = new System.Windows.Forms.TextBox();
            this.labelComment = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(268, 196);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(100, 28);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "Ок";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(162, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(13, 9);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(34, 16);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Имя";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(16, 29);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(352, 22);
            this.textBoxName.TabIndex = 4;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(13, 55);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(68, 16);
            this.labelPhone.TabIndex = 5;
            this.labelPhone.Text = "Телефон";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(16, 75);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(352, 22);
            this.textBoxPhone.TabIndex = 6;
            // 
            // labelEmeil
            // 
            this.labelEmeil.AutoSize = true;
            this.labelEmeil.Location = new System.Drawing.Point(13, 101);
            this.labelEmeil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmeil.Name = "labelEmeil";
            this.labelEmeil.Size = new System.Drawing.Size(42, 16);
            this.labelEmeil.TabIndex = 7;
            this.labelEmeil.Text = "Emeil";
            // 
            // textBoxEmeil
            // 
            this.textBoxEmeil.Location = new System.Drawing.Point(16, 121);
            this.textBoxEmeil.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmeil.Name = "textBoxEmeil";
            this.textBoxEmeil.Size = new System.Drawing.Size(352, 22);
            this.textBoxEmeil.TabIndex = 8;
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(13, 147);
            this.labelComment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(88, 16);
            this.labelComment.TabIndex = 9;
            this.labelComment.Text = "Коментарий";
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(16, 167);
            this.textBoxComment.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(352, 22);
            this.textBoxComment.TabIndex = 10;
            // 
            // AddClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 241);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.textBoxEmeil);
            this.Controls.Add(this.labelEmeil);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddClientForm";
            this.Text = "Новый Клиент";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelEmeil;
        private System.Windows.Forms.TextBox textBoxEmeil;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.TextBox textBoxComment;
    }
}
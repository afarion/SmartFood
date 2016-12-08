namespace SmartFood.Forms
{
    partial class SupplierDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierDetailsForm));
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.textBoxCompanyName = new System.Windows.Forms.TextBox();
            this.textBoxPhone1 = new System.Windows.Forms.TextBox();
            this.textBoxEmeil = new System.Windows.Forms.TextBox();
            this.textBoxSkype = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmeil = new System.Windows.Forms.Label();
            this.labelSkype = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.labelNotes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Location = new System.Drawing.Point(12, 20);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(58, 13);
            this.labelCompanyName.TabIndex = 0;
            this.labelCompanyName.Text = "Компания";
            // 
            // textBoxCompanyName
            // 
            this.textBoxCompanyName.Location = new System.Drawing.Point(117, 13);
            this.textBoxCompanyName.Name = "textBoxCompanyName";
            this.textBoxCompanyName.Size = new System.Drawing.Size(226, 20);
            this.textBoxCompanyName.TabIndex = 1;
            // 
            // textBoxPhone1
            // 
            this.textBoxPhone1.Location = new System.Drawing.Point(117, 39);
            this.textBoxPhone1.Name = "textBoxPhone1";
            this.textBoxPhone1.Size = new System.Drawing.Size(226, 20);
            this.textBoxPhone1.TabIndex = 4;
            // 
            // textBoxEmeil
            // 
            this.textBoxEmeil.Location = new System.Drawing.Point(117, 65);
            this.textBoxEmeil.Name = "textBoxEmeil";
            this.textBoxEmeil.Size = new System.Drawing.Size(226, 20);
            this.textBoxEmeil.TabIndex = 6;
            // 
            // textBoxSkype
            // 
            this.textBoxSkype.Location = new System.Drawing.Point(117, 91);
            this.textBoxSkype.Name = "textBoxSkype";
            this.textBoxSkype.Size = new System.Drawing.Size(226, 20);
            this.textBoxSkype.TabIndex = 7;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(12, 46);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(52, 13);
            this.labelPhone.TabIndex = 9;
            this.labelPhone.Text = "Телефон";
            // 
            // labelEmeil
            // 
            this.labelEmeil.AutoSize = true;
            this.labelEmeil.Location = new System.Drawing.Point(13, 72);
            this.labelEmeil.Name = "labelEmeil";
            this.labelEmeil.Size = new System.Drawing.Size(37, 13);
            this.labelEmeil.TabIndex = 11;
            this.labelEmeil.Text = "Почта";
            // 
            // labelSkype
            // 
            this.labelSkype.AutoSize = true;
            this.labelSkype.Location = new System.Drawing.Point(12, 98);
            this.labelSkype.Name = "labelSkype";
            this.labelSkype.Size = new System.Drawing.Size(37, 13);
            this.labelSkype.TabIndex = 12;
            this.labelSkype.Text = "Skype";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(269, 143);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 14;
            this.buttonOk.Text = "ОК";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(188, 143);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(118, 117);
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(226, 20);
            this.textBoxNotes.TabIndex = 16;
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Location = new System.Drawing.Point(12, 124);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(51, 13);
            this.labelNotes.TabIndex = 17;
            this.labelNotes.Text = "Заметки";
            // 
            // SupplierDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 174);
            this.Controls.Add(this.labelNotes);
            this.Controls.Add(this.textBoxNotes);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelSkype);
            this.Controls.Add(this.labelEmeil);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.textBoxSkype);
            this.Controls.Add(this.textBoxEmeil);
            this.Controls.Add(this.textBoxPhone1);
            this.Controls.Add(this.textBoxCompanyName);
            this.Controls.Add(this.labelCompanyName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SupplierDetailsForm";
            this.Text = "SupplierDetailsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SupplierDetailsForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.TextBox textBoxCompanyName;
        private System.Windows.Forms.TextBox textBoxPhone1;
        private System.Windows.Forms.TextBox textBoxEmeil;
        private System.Windows.Forms.TextBox textBoxSkype;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelEmeil;
        private System.Windows.Forms.Label labelSkype;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.Label labelNotes;
    }
}
namespace SmartFood.Forms
{
    partial class ConsumbleCategorieForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsumbleCategorieForm));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridViewConsumbleCategories = new System.Windows.Forms.DataGridView();
            this.comboBoxConsumbleTypes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsumbleCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(373, 478);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(112, 35);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(255, 478);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(112, 35);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // dataGridViewConsumbleCategories
            // 
            this.dataGridViewConsumbleCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsumbleCategories.Location = new System.Drawing.Point(13, 47);
            this.dataGridViewConsumbleCategories.Name = "dataGridViewConsumbleCategories";
            this.dataGridViewConsumbleCategories.RowTemplate.Height = 28;
            this.dataGridViewConsumbleCategories.Size = new System.Drawing.Size(468, 427);
            this.dataGridViewConsumbleCategories.TabIndex = 3;
            // 
            // comboBoxConsumbleTypes
            // 
            this.comboBoxConsumbleTypes.FormattingEnabled = true;
            this.comboBoxConsumbleTypes.Location = new System.Drawing.Point(13, 13);
            this.comboBoxConsumbleTypes.Name = "comboBoxConsumbleTypes";
            this.comboBoxConsumbleTypes.Size = new System.Drawing.Size(468, 28);
            this.comboBoxConsumbleTypes.TabIndex = 4;
            // 
            // ConsumbleCategorieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 525);
            this.Controls.Add(this.comboBoxConsumbleTypes);
            this.Controls.Add(this.dataGridViewConsumbleCategories);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsumbleCategorieForm";
            this.Text = "Категории расходников";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConsumbleCategorieForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsumbleCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataGridViewConsumbleCategories;
        private System.Windows.Forms.ComboBox comboBoxConsumbleTypes;
    }
}
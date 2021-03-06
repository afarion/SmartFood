﻿namespace SmartFood.Forms
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
            this.dataGridViewConsumbleCategories = new System.Windows.Forms.DataGridView();
            this.comboBoxConsumbleTypes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsumbleCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(249, 310);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewConsumbleCategories
            // 
            this.dataGridViewConsumbleCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsumbleCategories.Location = new System.Drawing.Point(9, 31);
            this.dataGridViewConsumbleCategories.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewConsumbleCategories.Name = "dataGridViewConsumbleCategories";
            this.dataGridViewConsumbleCategories.RowTemplate.Height = 28;
            this.dataGridViewConsumbleCategories.Size = new System.Drawing.Size(312, 278);
            this.dataGridViewConsumbleCategories.TabIndex = 3;
            // 
            // comboBoxConsumbleTypes
            // 
            this.comboBoxConsumbleTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConsumbleTypes.FormattingEnabled = true;
            this.comboBoxConsumbleTypes.Location = new System.Drawing.Point(9, 8);
            this.comboBoxConsumbleTypes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxConsumbleTypes.Name = "comboBoxConsumbleTypes";
            this.comboBoxConsumbleTypes.Size = new System.Drawing.Size(313, 21);
            this.comboBoxConsumbleTypes.TabIndex = 1;
            this.comboBoxConsumbleTypes.SelectionChangeCommitted += new System.EventHandler(this.comboBoxConsumbleTypes_SelectionChangeCommitted);
            // 
            // ConsumbleCategorieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 341);
            this.Controls.Add(this.comboBoxConsumbleTypes);
            this.Controls.Add(this.dataGridViewConsumbleCategories);
            this.Controls.Add(this.buttonAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsumbleCategorieForm";
            this.Text = "Категории расходников";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConsumbleCategorieForm_FormClosed);
            this.Load += new System.EventHandler(this.ConsumbleCategorieForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsumbleCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewConsumbleCategories;
        private System.Windows.Forms.ComboBox comboBoxConsumbleTypes;
    }
}
namespace SmartFood.Forms
{
    partial class ConsumbleTypeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsumbleTypeForm));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewConsumbleTypes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsumbleTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(327, 384);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 28);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewConsumbleTypes
            // 
            this.dataGridViewConsumbleTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsumbleTypes.Location = new System.Drawing.Point(12, 10);
            this.dataGridViewConsumbleTypes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewConsumbleTypes.Name = "dataGridViewConsumbleTypes";
            this.dataGridViewConsumbleTypes.RowTemplate.Height = 28;
            this.dataGridViewConsumbleTypes.Size = new System.Drawing.Size(415, 369);
            this.dataGridViewConsumbleTypes.TabIndex = 2;
            // 
            // ConsumbleTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 420);
            this.Controls.Add(this.dataGridViewConsumbleTypes);
            this.Controls.Add(this.buttonAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsumbleTypeForm";
            this.Text = "Типы расходников";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConsumbleTypeForm_FormClosed);
            this.Load += new System.EventHandler(this.ConsumbleTypeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsumbleTypes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewConsumbleTypes;
    }
}
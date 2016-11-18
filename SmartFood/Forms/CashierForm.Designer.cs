namespace SmartFood.Forms
{
    partial class CashierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierForm));
            this.OrdersGridView = new System.Windows.Forms.DataGridView();
            this.CreateOrderButton = new System.Windows.Forms.Button();
            this.buttonSearchOrder = new System.Windows.Forms.Button();
            this.SearchOrderTextBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.OpenOrderButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SearchGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).BeginInit();
            this.SearchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrdersGridView
            // 
            this.OrdersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGridView.Location = new System.Drawing.Point(12, 94);
            this.OrdersGridView.Name = "OrdersGridView";
            this.OrdersGridView.Size = new System.Drawing.Size(1428, 527);
            this.OrdersGridView.TabIndex = 0;
            // 
            // CreateOrderButton
            // 
            this.CreateOrderButton.Location = new System.Drawing.Point(12, 12);
            this.CreateOrderButton.Name = "CreateOrderButton";
            this.CreateOrderButton.Size = new System.Drawing.Size(109, 23);
            this.CreateOrderButton.TabIndex = 1;
            this.CreateOrderButton.Text = "Новый заказ";
            this.CreateOrderButton.UseVisualStyleBackColor = true;
            // 
            // buttonSearchOrder
            // 
            this.buttonSearchOrder.Location = new System.Drawing.Point(6, 38);
            this.buttonSearchOrder.Name = "buttonSearchOrder";
            this.buttonSearchOrder.Size = new System.Drawing.Size(109, 23);
            this.buttonSearchOrder.TabIndex = 2;
            this.buttonSearchOrder.Text = "Найти заказ";
            this.buttonSearchOrder.UseVisualStyleBackColor = true;
            // 
            // SearchOrderTextBox
            // 
            this.SearchOrderTextBox.Location = new System.Drawing.Point(105, 12);
            this.SearchOrderTextBox.Name = "SearchOrderTextBox";
            this.SearchOrderTextBox.Size = new System.Drawing.Size(243, 20);
            this.SearchOrderTextBox.TabIndex = 3;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(6, 14);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(93, 13);
            this.label.TabIndex = 4;
            this.label.Text = "Номер телефона";
            // 
            // OpenOrderButton
            // 
            this.OpenOrderButton.Location = new System.Drawing.Point(124, 38);
            this.OpenOrderButton.Name = "OpenOrderButton";
            this.OpenOrderButton.Size = new System.Drawing.Size(109, 23);
            this.OpenOrderButton.TabIndex = 5;
            this.OpenOrderButton.Text = "Открыть заказ";
            this.OpenOrderButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(239, 38);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(109, 23);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "Очистить поиск";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.Controls.Add(this.SearchOrderTextBox);
            this.SearchGroupBox.Controls.Add(this.ClearButton);
            this.SearchGroupBox.Controls.Add(this.label);
            this.SearchGroupBox.Controls.Add(this.OpenOrderButton);
            this.SearchGroupBox.Controls.Add(this.buttonSearchOrder);
            this.SearchGroupBox.Location = new System.Drawing.Point(970, 3);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Size = new System.Drawing.Size(363, 75);
            this.SearchGroupBox.TabIndex = 7;
            this.SearchGroupBox.TabStop = false;
            this.SearchGroupBox.Text = "Поиск";
            // 
            // CashierForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1452, 645);
            this.Controls.Add(this.SearchGroupBox);
            this.Controls.Add(this.CreateOrderButton);
            this.Controls.Add(this.OrdersGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CashierForm";
            this.Text = "Касир";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CashierForm_FormClosed);
            this.Shown += new System.EventHandler(this.CashierForm_Shown);
            this.Move += new System.EventHandler(this.CashierForm_Move);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).EndInit();
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView OrdersGridView;
        private System.Windows.Forms.Button CreateOrderButton;
        private System.Windows.Forms.Button buttonSearchOrder;
        private System.Windows.Forms.TextBox SearchOrderTextBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button OpenOrderButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.GroupBox SearchGroupBox;
    }
}
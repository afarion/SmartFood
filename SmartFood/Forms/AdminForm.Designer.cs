namespace SmartFood.Forms
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageConsumables = new System.Windows.Forms.TabPage();
            this.tabPageArrivalAndWriteOff = new System.Windows.Forms.TabPage();
            this.tabPageReports = new System.Windows.Forms.TabPage();
            this.tabPageGoods = new System.Windows.Forms.TabPage();
            this.tabPageAcounts = new System.Windows.Forms.TabPage();
            this.tabPageClients = new System.Windows.Forms.TabPage();
            this.tabPageEmployees = new System.Windows.Forms.TabPage();
            this.tabPageSuppliers = new System.Windows.Forms.TabPage();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAddConsumble = new System.Windows.Forms.Button();
            this.dataGridViewConsumbles = new System.Windows.Forms.DataGridView();
            this.dataGridViewArrival = new System.Windows.Forms.DataGridView();
            this.buttonArrivial = new System.Windows.Forms.Button();
            this.buttonWriteOff = new System.Windows.Forms.Button();
            this.groupBoxCostPrice = new System.Windows.Forms.GroupBox();
            this.groupBoxReport = new System.Windows.Forms.GroupBox();
            this.monthCalendarFrom = new System.Windows.Forms.MonthCalendar();
            this.monthCalendarTo = new System.Windows.Forms.MonthCalendar();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.buttonSelectConsumble = new System.Windows.Forms.Button();
            this.comboBoxSelectConsumble = new System.Windows.Forms.ComboBox();
            this.buttonAddAkkConsumbles = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.dataGridViewCostPrice = new System.Windows.Forms.DataGridView();
            this.groupBoxCurrentReport = new System.Windows.Forms.GroupBox();
            this.textBoxSummForToday = new System.Windows.Forms.TextBox();
            this.labelSummForToday = new System.Windows.Forms.Label();
            this.labelCostsForToday = new System.Windows.Forms.Label();
            this.textBoxCostsForToday = new System.Windows.Forms.TextBox();
            this.textBoxDiffForToday = new System.Windows.Forms.TextBox();
            this.labelDiffForToday = new System.Windows.Forms.Label();
            this.textBoxDiffForThisMonth = new System.Windows.Forms.TextBox();
            this.labelDiffForThisMonth = new System.Windows.Forms.Label();
            this.textBoxCostsForThisMonth = new System.Windows.Forms.TextBox();
            this.labelCostsForThisMonth = new System.Windows.Forms.Label();
            this.labelSummForThisMonth = new System.Windows.Forms.Label();
            this.textBoxSummForThisMonth = new System.Windows.Forms.TextBox();
            this.labelDiscountForToday = new System.Windows.Forms.Label();
            this.textBoxDiscountForToday = new System.Windows.Forms.TextBox();
            this.labelDiscountForThisMonth = new System.Windows.Forms.Label();
            this.textBoxDiscountForThisMonth = new System.Windows.Forms.TextBox();
            this.buttonRefreshCurrentReport = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPageConsumables.SuspendLayout();
            this.tabPageArrivalAndWriteOff.SuspendLayout();
            this.tabPageReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsumbles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArrival)).BeginInit();
            this.groupBoxCostPrice.SuspendLayout();
            this.groupBoxReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCostPrice)).BeginInit();
            this.groupBoxCurrentReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageConsumables);
            this.tabControl.Controls.Add(this.tabPageArrivalAndWriteOff);
            this.tabControl.Controls.Add(this.tabPageReports);
            this.tabControl.Controls.Add(this.tabPageGoods);
            this.tabControl.Controls.Add(this.tabPageAcounts);
            this.tabControl.Controls.Add(this.tabPageClients);
            this.tabControl.Controls.Add(this.tabPageEmployees);
            this.tabControl.Controls.Add(this.tabPageSuppliers);
            this.tabControl.Location = new System.Drawing.Point(3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1437, 631);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageConsumables
            // 
            this.tabPageConsumables.Controls.Add(this.dataGridViewConsumbles);
            this.tabPageConsumables.Controls.Add(this.buttonAddConsumble);
            this.tabPageConsumables.Controls.Add(this.buttonDelete);
            this.tabPageConsumables.Location = new System.Drawing.Point(4, 22);
            this.tabPageConsumables.Name = "tabPageConsumables";
            this.tabPageConsumables.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConsumables.Size = new System.Drawing.Size(1429, 605);
            this.tabPageConsumables.TabIndex = 0;
            this.tabPageConsumables.Text = "Расходники";
            this.tabPageConsumables.UseVisualStyleBackColor = true;
            // 
            // tabPageArrivalAndWriteOff
            // 
            this.tabPageArrivalAndWriteOff.Controls.Add(this.buttonWriteOff);
            this.tabPageArrivalAndWriteOff.Controls.Add(this.buttonArrivial);
            this.tabPageArrivalAndWriteOff.Controls.Add(this.dataGridViewArrival);
            this.tabPageArrivalAndWriteOff.Location = new System.Drawing.Point(4, 22);
            this.tabPageArrivalAndWriteOff.Name = "tabPageArrivalAndWriteOff";
            this.tabPageArrivalAndWriteOff.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageArrivalAndWriteOff.Size = new System.Drawing.Size(1429, 605);
            this.tabPageArrivalAndWriteOff.TabIndex = 1;
            this.tabPageArrivalAndWriteOff.Text = "Приход и списание";
            this.tabPageArrivalAndWriteOff.UseVisualStyleBackColor = true;
            // 
            // tabPageReports
            // 
            this.tabPageReports.Controls.Add(this.groupBoxCurrentReport);
            this.tabPageReports.Controls.Add(this.groupBoxReport);
            this.tabPageReports.Controls.Add(this.groupBoxCostPrice);
            this.tabPageReports.Location = new System.Drawing.Point(4, 22);
            this.tabPageReports.Name = "tabPageReports";
            this.tabPageReports.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReports.Size = new System.Drawing.Size(1429, 605);
            this.tabPageReports.TabIndex = 2;
            this.tabPageReports.Text = "Отчеты";
            this.tabPageReports.UseVisualStyleBackColor = true;
            // 
            // tabPageGoods
            // 
            this.tabPageGoods.Location = new System.Drawing.Point(4, 22);
            this.tabPageGoods.Name = "tabPageGoods";
            this.tabPageGoods.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGoods.Size = new System.Drawing.Size(1429, 605);
            this.tabPageGoods.TabIndex = 3;
            this.tabPageGoods.Text = "Товары";
            this.tabPageGoods.UseVisualStyleBackColor = true;
            // 
            // tabPageAcounts
            // 
            this.tabPageAcounts.Location = new System.Drawing.Point(4, 22);
            this.tabPageAcounts.Name = "tabPageAcounts";
            this.tabPageAcounts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAcounts.Size = new System.Drawing.Size(1429, 605);
            this.tabPageAcounts.TabIndex = 4;
            this.tabPageAcounts.Text = "Акаунты";
            this.tabPageAcounts.UseVisualStyleBackColor = true;
            // 
            // tabPageClients
            // 
            this.tabPageClients.Location = new System.Drawing.Point(4, 22);
            this.tabPageClients.Name = "tabPageClients";
            this.tabPageClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClients.Size = new System.Drawing.Size(1429, 605);
            this.tabPageClients.TabIndex = 5;
            this.tabPageClients.Text = "Клиенты";
            this.tabPageClients.UseVisualStyleBackColor = true;
            // 
            // tabPageEmployees
            // 
            this.tabPageEmployees.Location = new System.Drawing.Point(4, 22);
            this.tabPageEmployees.Name = "tabPageEmployees";
            this.tabPageEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmployees.Size = new System.Drawing.Size(1429, 605);
            this.tabPageEmployees.TabIndex = 6;
            this.tabPageEmployees.Text = "Сотрудники";
            this.tabPageEmployees.UseVisualStyleBackColor = true;
            // 
            // tabPageSuppliers
            // 
            this.tabPageSuppliers.Location = new System.Drawing.Point(4, 22);
            this.tabPageSuppliers.Name = "tabPageSuppliers";
            this.tabPageSuppliers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSuppliers.Size = new System.Drawing.Size(1429, 605);
            this.tabPageSuppliers.TabIndex = 7;
            this.tabPageSuppliers.Text = "Поставщики";
            this.tabPageSuppliers.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(1348, 576);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonAddConsumble
            // 
            this.buttonAddConsumble.Location = new System.Drawing.Point(1267, 576);
            this.buttonAddConsumble.Name = "buttonAddConsumble";
            this.buttonAddConsumble.Size = new System.Drawing.Size(75, 23);
            this.buttonAddConsumble.TabIndex = 2;
            this.buttonAddConsumble.Text = "Добавить";
            this.buttonAddConsumble.UseVisualStyleBackColor = true;
            // 
            // dataGridViewConsumbles
            // 
            this.dataGridViewConsumbles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsumbles.Location = new System.Drawing.Point(7, 7);
            this.dataGridViewConsumbles.Name = "dataGridViewConsumbles";
            this.dataGridViewConsumbles.Size = new System.Drawing.Size(1416, 563);
            this.dataGridViewConsumbles.TabIndex = 3;
            // 
            // dataGridViewArrival
            // 
            this.dataGridViewArrival.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArrival.Location = new System.Drawing.Point(7, 6);
            this.dataGridViewArrival.Name = "dataGridViewArrival";
            this.dataGridViewArrival.Size = new System.Drawing.Size(1416, 563);
            this.dataGridViewArrival.TabIndex = 4;
            // 
            // buttonArrivial
            // 
            this.buttonArrivial.Location = new System.Drawing.Point(1347, 576);
            this.buttonArrivial.Name = "buttonArrivial";
            this.buttonArrivial.Size = new System.Drawing.Size(75, 23);
            this.buttonArrivial.TabIndex = 5;
            this.buttonArrivial.Text = "Приход";
            this.buttonArrivial.UseVisualStyleBackColor = true;
            // 
            // buttonWriteOff
            // 
            this.buttonWriteOff.Location = new System.Drawing.Point(1266, 575);
            this.buttonWriteOff.Name = "buttonWriteOff";
            this.buttonWriteOff.Size = new System.Drawing.Size(75, 23);
            this.buttonWriteOff.TabIndex = 6;
            this.buttonWriteOff.Text = "Списание";
            this.buttonWriteOff.UseVisualStyleBackColor = true;
            // 
            // groupBoxCostPrice
            // 
            this.groupBoxCostPrice.Controls.Add(this.dataGridViewCostPrice);
            this.groupBoxCostPrice.Controls.Add(this.buttonClear);
            this.groupBoxCostPrice.Controls.Add(this.buttonAddAkkConsumbles);
            this.groupBoxCostPrice.Controls.Add(this.comboBoxSelectConsumble);
            this.groupBoxCostPrice.Controls.Add(this.buttonSelectConsumble);
            this.groupBoxCostPrice.Location = new System.Drawing.Point(692, 7);
            this.groupBoxCostPrice.Name = "groupBoxCostPrice";
            this.groupBoxCostPrice.Size = new System.Drawing.Size(459, 592);
            this.groupBoxCostPrice.TabIndex = 0;
            this.groupBoxCostPrice.TabStop = false;
            this.groupBoxCostPrice.Text = "Себестоимсость";
            // 
            // groupBoxReport
            // 
            this.groupBoxReport.Controls.Add(this.labelType);
            this.groupBoxReport.Controls.Add(this.labelTo);
            this.groupBoxReport.Controls.Add(this.labelFrom);
            this.groupBoxReport.Controls.Add(this.buttonSave);
            this.groupBoxReport.Controls.Add(this.buttonPrint);
            this.groupBoxReport.Controls.Add(this.comboBoxType);
            this.groupBoxReport.Controls.Add(this.monthCalendarTo);
            this.groupBoxReport.Controls.Add(this.monthCalendarFrom);
            this.groupBoxReport.Location = new System.Drawing.Point(1172, 7);
            this.groupBoxReport.Name = "groupBoxReport";
            this.groupBoxReport.Size = new System.Drawing.Size(240, 592);
            this.groupBoxReport.TabIndex = 1;
            this.groupBoxReport.TabStop = false;
            this.groupBoxReport.Text = "Отчет";
            // 
            // monthCalendarFrom
            // 
            this.monthCalendarFrom.Location = new System.Drawing.Point(21, 42);
            this.monthCalendarFrom.Name = "monthCalendarFrom";
            this.monthCalendarFrom.TabIndex = 0;
            // 
            // monthCalendarTo
            // 
            this.monthCalendarTo.Location = new System.Drawing.Point(21, 237);
            this.monthCalendarTo.Name = "monthCalendarTo";
            this.monthCalendarTo.TabIndex = 1;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(21, 430);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(178, 21);
            this.comboBoxType.TabIndex = 2;
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(159, 560);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(75, 23);
            this.buttonPrint.TabIndex = 3;
            this.buttonPrint.Text = "Печать";
            this.buttonPrint.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(78, 560);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(18, 20);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(20, 13);
            this.labelFrom.TabIndex = 5;
            this.labelFrom.Text = "От";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(19, 215);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(22, 13);
            this.labelTo.TabIndex = 6;
            this.labelTo.Text = "До";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(18, 409);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(62, 13);
            this.labelType.TabIndex = 7;
            this.labelType.Text = "Тип отчета";
            // 
            // buttonSelectConsumble
            // 
            this.buttonSelectConsumble.Location = new System.Drawing.Point(378, 563);
            this.buttonSelectConsumble.Name = "buttonSelectConsumble";
            this.buttonSelectConsumble.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectConsumble.TabIndex = 0;
            this.buttonSelectConsumble.Text = "Добавить";
            this.buttonSelectConsumble.UseVisualStyleBackColor = true;
            // 
            // comboBoxSelectConsumble
            // 
            this.comboBoxSelectConsumble.FormattingEnabled = true;
            this.comboBoxSelectConsumble.Location = new System.Drawing.Point(182, 565);
            this.comboBoxSelectConsumble.Name = "comboBoxSelectConsumble";
            this.comboBoxSelectConsumble.Size = new System.Drawing.Size(190, 21);
            this.comboBoxSelectConsumble.TabIndex = 1;
            // 
            // buttonAddAkkConsumbles
            // 
            this.buttonAddAkkConsumbles.Location = new System.Drawing.Point(87, 563);
            this.buttonAddAkkConsumbles.Name = "buttonAddAkkConsumbles";
            this.buttonAddAkkConsumbles.Size = new System.Drawing.Size(89, 23);
            this.buttonAddAkkConsumbles.TabIndex = 2;
            this.buttonAddAkkConsumbles.Text = "Добавить все";
            this.buttonAddAkkConsumbles.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(6, 563);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCostPrice
            // 
            this.dataGridViewCostPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCostPrice.Location = new System.Drawing.Point(7, 20);
            this.dataGridViewCostPrice.Name = "dataGridViewCostPrice";
            this.dataGridViewCostPrice.Size = new System.Drawing.Size(446, 537);
            this.dataGridViewCostPrice.TabIndex = 4;
            // 
            // groupBoxCurrentReport
            // 
            this.groupBoxCurrentReport.Controls.Add(this.buttonRefreshCurrentReport);
            this.groupBoxCurrentReport.Controls.Add(this.textBoxDiscountForThisMonth);
            this.groupBoxCurrentReport.Controls.Add(this.labelDiscountForThisMonth);
            this.groupBoxCurrentReport.Controls.Add(this.textBoxDiscountForToday);
            this.groupBoxCurrentReport.Controls.Add(this.labelDiscountForToday);
            this.groupBoxCurrentReport.Controls.Add(this.textBoxDiffForThisMonth);
            this.groupBoxCurrentReport.Controls.Add(this.labelDiffForThisMonth);
            this.groupBoxCurrentReport.Controls.Add(this.textBoxCostsForThisMonth);
            this.groupBoxCurrentReport.Controls.Add(this.labelCostsForThisMonth);
            this.groupBoxCurrentReport.Controls.Add(this.labelSummForThisMonth);
            this.groupBoxCurrentReport.Controls.Add(this.textBoxSummForThisMonth);
            this.groupBoxCurrentReport.Controls.Add(this.textBoxDiffForToday);
            this.groupBoxCurrentReport.Controls.Add(this.labelDiffForToday);
            this.groupBoxCurrentReport.Controls.Add(this.textBoxCostsForToday);
            this.groupBoxCurrentReport.Controls.Add(this.labelCostsForToday);
            this.groupBoxCurrentReport.Controls.Add(this.labelSummForToday);
            this.groupBoxCurrentReport.Controls.Add(this.textBoxSummForToday);
            this.groupBoxCurrentReport.Location = new System.Drawing.Point(6, 7);
            this.groupBoxCurrentReport.Name = "groupBoxCurrentReport";
            this.groupBoxCurrentReport.Size = new System.Drawing.Size(680, 592);
            this.groupBoxCurrentReport.TabIndex = 2;
            this.groupBoxCurrentReport.TabStop = false;
            this.groupBoxCurrentReport.Text = "Текущий отчет";
            this.groupBoxCurrentReport.Enter += new System.EventHandler(this.groupBoxCurrentReport_Enter);
            // 
            // textBoxSummForToday
            // 
            this.textBoxSummForToday.Location = new System.Drawing.Point(6, 36);
            this.textBoxSummForToday.Name = "textBoxSummForToday";
            this.textBoxSummForToday.ReadOnly = true;
            this.textBoxSummForToday.Size = new System.Drawing.Size(149, 20);
            this.textBoxSummForToday.TabIndex = 0;
            this.textBoxSummForToday.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelSummForToday
            // 
            this.labelSummForToday.AutoSize = true;
            this.labelSummForToday.Location = new System.Drawing.Point(3, 20);
            this.labelSummForToday.Name = "labelSummForToday";
            this.labelSummForToday.Size = new System.Drawing.Size(100, 13);
            this.labelSummForToday.TabIndex = 1;
            this.labelSummForToday.Text = "Сумма за сегодня";
            this.labelSummForToday.Click += new System.EventHandler(this.labelSummForToday_Click);
            // 
            // labelCostsForToday
            // 
            this.labelCostsForToday.AutoSize = true;
            this.labelCostsForToday.Location = new System.Drawing.Point(3, 59);
            this.labelCostsForToday.Name = "labelCostsForToday";
            this.labelCostsForToday.Size = new System.Drawing.Size(110, 13);
            this.labelCostsForToday.TabIndex = 2;
            this.labelCostsForToday.Text = "Расходы за сегодня";
            // 
            // textBoxCostsForToday
            // 
            this.textBoxCostsForToday.Location = new System.Drawing.Point(6, 75);
            this.textBoxCostsForToday.Name = "textBoxCostsForToday";
            this.textBoxCostsForToday.ReadOnly = true;
            this.textBoxCostsForToday.Size = new System.Drawing.Size(149, 20);
            this.textBoxCostsForToday.TabIndex = 3;
            this.textBoxCostsForToday.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxDiffForToday
            // 
            this.textBoxDiffForToday.Location = new System.Drawing.Point(6, 114);
            this.textBoxDiffForToday.Name = "textBoxDiffForToday";
            this.textBoxDiffForToday.ReadOnly = true;
            this.textBoxDiffForToday.Size = new System.Drawing.Size(149, 20);
            this.textBoxDiffForToday.TabIndex = 5;
            this.textBoxDiffForToday.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // labelDiffForToday
            // 
            this.labelDiffForToday.AutoSize = true;
            this.labelDiffForToday.Location = new System.Drawing.Point(3, 98);
            this.labelDiffForToday.Name = "labelDiffForToday";
            this.labelDiffForToday.Size = new System.Drawing.Size(96, 13);
            this.labelDiffForToday.TabIndex = 4;
            this.labelDiffForToday.Text = "Итого за сегодня";
            this.labelDiffForToday.Click += new System.EventHandler(this.labelDiffForToday_Click);
            // 
            // textBoxDiffForThisMonth
            // 
            this.textBoxDiffForThisMonth.Location = new System.Drawing.Point(184, 114);
            this.textBoxDiffForThisMonth.Name = "textBoxDiffForThisMonth";
            this.textBoxDiffForThisMonth.ReadOnly = true;
            this.textBoxDiffForThisMonth.Size = new System.Drawing.Size(149, 20);
            this.textBoxDiffForThisMonth.TabIndex = 17;
            // 
            // labelDiffForThisMonth
            // 
            this.labelDiffForThisMonth.AutoSize = true;
            this.labelDiffForThisMonth.Location = new System.Drawing.Point(181, 98);
            this.labelDiffForThisMonth.Name = "labelDiffForThisMonth";
            this.labelDiffForThisMonth.Size = new System.Drawing.Size(112, 13);
            this.labelDiffForThisMonth.TabIndex = 16;
            this.labelDiffForThisMonth.Text = "Итого за этот месяц";
            // 
            // textBoxCostsForThisMonth
            // 
            this.textBoxCostsForThisMonth.Location = new System.Drawing.Point(184, 75);
            this.textBoxCostsForThisMonth.Name = "textBoxCostsForThisMonth";
            this.textBoxCostsForThisMonth.ReadOnly = true;
            this.textBoxCostsForThisMonth.Size = new System.Drawing.Size(149, 20);
            this.textBoxCostsForThisMonth.TabIndex = 15;
            // 
            // labelCostsForThisMonth
            // 
            this.labelCostsForThisMonth.AutoSize = true;
            this.labelCostsForThisMonth.Location = new System.Drawing.Point(181, 59);
            this.labelCostsForThisMonth.Name = "labelCostsForThisMonth";
            this.labelCostsForThisMonth.Size = new System.Drawing.Size(126, 13);
            this.labelCostsForThisMonth.TabIndex = 14;
            this.labelCostsForThisMonth.Text = "Расходы за этот месяц";
            // 
            // labelSummForThisMonth
            // 
            this.labelSummForThisMonth.AutoSize = true;
            this.labelSummForThisMonth.Location = new System.Drawing.Point(181, 20);
            this.labelSummForThisMonth.Name = "labelSummForThisMonth";
            this.labelSummForThisMonth.Size = new System.Drawing.Size(116, 13);
            this.labelSummForThisMonth.TabIndex = 13;
            this.labelSummForThisMonth.Text = "Сумма за этот месяц";
            // 
            // textBoxSummForThisMonth
            // 
            this.textBoxSummForThisMonth.Location = new System.Drawing.Point(184, 36);
            this.textBoxSummForThisMonth.Name = "textBoxSummForThisMonth";
            this.textBoxSummForThisMonth.ReadOnly = true;
            this.textBoxSummForThisMonth.Size = new System.Drawing.Size(149, 20);
            this.textBoxSummForThisMonth.TabIndex = 12;
            // 
            // labelDiscountForToday
            // 
            this.labelDiscountForToday.AutoSize = true;
            this.labelDiscountForToday.Location = new System.Drawing.Point(3, 137);
            this.labelDiscountForToday.Name = "labelDiscountForToday";
            this.labelDiscountForToday.Size = new System.Drawing.Size(103, 13);
            this.labelDiscountForToday.TabIndex = 18;
            this.labelDiscountForToday.Text = "Скидки за сегодня";
            // 
            // textBoxDiscountForToday
            // 
            this.textBoxDiscountForToday.Location = new System.Drawing.Point(6, 153);
            this.textBoxDiscountForToday.Name = "textBoxDiscountForToday";
            this.textBoxDiscountForToday.ReadOnly = true;
            this.textBoxDiscountForToday.Size = new System.Drawing.Size(149, 20);
            this.textBoxDiscountForToday.TabIndex = 19;
            // 
            // labelDiscountForThisMonth
            // 
            this.labelDiscountForThisMonth.AutoSize = true;
            this.labelDiscountForThisMonth.Location = new System.Drawing.Point(181, 137);
            this.labelDiscountForThisMonth.Name = "labelDiscountForThisMonth";
            this.labelDiscountForThisMonth.Size = new System.Drawing.Size(119, 13);
            this.labelDiscountForThisMonth.TabIndex = 20;
            this.labelDiscountForThisMonth.Text = "Скидки за этот месяц";
            // 
            // textBoxDiscountForThisMonth
            // 
            this.textBoxDiscountForThisMonth.Location = new System.Drawing.Point(184, 153);
            this.textBoxDiscountForThisMonth.Name = "textBoxDiscountForThisMonth";
            this.textBoxDiscountForThisMonth.ReadOnly = true;
            this.textBoxDiscountForThisMonth.Size = new System.Drawing.Size(149, 20);
            this.textBoxDiscountForThisMonth.TabIndex = 21;
            // 
            // buttonRefreshCurrentReport
            // 
            this.buttonRefreshCurrentReport.Location = new System.Drawing.Point(599, 562);
            this.buttonRefreshCurrentReport.Name = "buttonRefreshCurrentReport";
            this.buttonRefreshCurrentReport.Size = new System.Drawing.Size(75, 23);
            this.buttonRefreshCurrentReport.TabIndex = 22;
            this.buttonRefreshCurrentReport.Text = "Обновить";
            this.buttonRefreshCurrentReport.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 645);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.Text = "Администратор";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.Shown += new System.EventHandler(this.AdminForm_Shown);
            this.Move += new System.EventHandler(this.AdminForm_Move);
            this.tabControl.ResumeLayout(false);
            this.tabPageConsumables.ResumeLayout(false);
            this.tabPageArrivalAndWriteOff.ResumeLayout(false);
            this.tabPageReports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsumbles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArrival)).EndInit();
            this.groupBoxCostPrice.ResumeLayout(false);
            this.groupBoxReport.ResumeLayout(false);
            this.groupBoxReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCostPrice)).EndInit();
            this.groupBoxCurrentReport.ResumeLayout(false);
            this.groupBoxCurrentReport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageConsumables;
        private System.Windows.Forms.TabPage tabPageArrivalAndWriteOff;
        private System.Windows.Forms.TabPage tabPageReports;
        private System.Windows.Forms.TabPage tabPageGoods;
        private System.Windows.Forms.TabPage tabPageAcounts;
        private System.Windows.Forms.TabPage tabPageClients;
        private System.Windows.Forms.TabPage tabPageEmployees;
        private System.Windows.Forms.TabPage tabPageSuppliers;
        private System.Windows.Forms.DataGridView dataGridViewConsumbles;
        private System.Windows.Forms.Button buttonAddConsumble;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonWriteOff;
        private System.Windows.Forms.Button buttonArrivial;
        private System.Windows.Forms.DataGridView dataGridViewArrival;
        private System.Windows.Forms.GroupBox groupBoxCurrentReport;
        private System.Windows.Forms.TextBox textBoxDiffForToday;
        private System.Windows.Forms.Label labelDiffForToday;
        private System.Windows.Forms.TextBox textBoxCostsForToday;
        private System.Windows.Forms.Label labelCostsForToday;
        private System.Windows.Forms.Label labelSummForToday;
        private System.Windows.Forms.TextBox textBoxSummForToday;
        private System.Windows.Forms.GroupBox groupBoxReport;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.MonthCalendar monthCalendarTo;
        private System.Windows.Forms.MonthCalendar monthCalendarFrom;
        private System.Windows.Forms.GroupBox groupBoxCostPrice;
        private System.Windows.Forms.DataGridView dataGridViewCostPrice;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonAddAkkConsumbles;
        private System.Windows.Forms.ComboBox comboBoxSelectConsumble;
        private System.Windows.Forms.Button buttonSelectConsumble;
        private System.Windows.Forms.TextBox textBoxDiffForThisMonth;
        private System.Windows.Forms.Label labelDiffForThisMonth;
        private System.Windows.Forms.TextBox textBoxCostsForThisMonth;
        private System.Windows.Forms.Label labelCostsForThisMonth;
        private System.Windows.Forms.Label labelSummForThisMonth;
        private System.Windows.Forms.TextBox textBoxSummForThisMonth;
        private System.Windows.Forms.Button buttonRefreshCurrentReport;
        private System.Windows.Forms.TextBox textBoxDiscountForThisMonth;
        private System.Windows.Forms.Label labelDiscountForThisMonth;
        private System.Windows.Forms.TextBox textBoxDiscountForToday;
        private System.Windows.Forms.Label labelDiscountForToday;
    }
}
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
            this.checkBoxPrint = new System.Windows.Forms.CheckBox();
            this.buttonPrintConsumbles = new System.Windows.Forms.Button();
            this.buttonConsumbleCategories = new System.Windows.Forms.Button();
            this.buttonConsumbleTypes = new System.Windows.Forms.Button();
            this.dataGridViewConsumbles = new System.Windows.Forms.DataGridView();
            this.buttonAddConsumble = new System.Windows.Forms.Button();
            this.tabPageArrivalAndWriteOff = new System.Windows.Forms.TabPage();
            this.dataGridViewWriteOff = new System.Windows.Forms.DataGridView();
            this.buttonWriteOff = new System.Windows.Forms.Button();
            this.buttonArrivial = new System.Windows.Forms.Button();
            this.dataGridViewArrival = new System.Windows.Forms.DataGridView();
            this.tabPageReports = new System.Windows.Forms.TabPage();
            this.groupBoxCurrentReport = new System.Windows.Forms.GroupBox();
            this.buttonRefreshCurrentReport = new System.Windows.Forms.Button();
            this.textBoxDiscountForThisMonth = new System.Windows.Forms.TextBox();
            this.labelDiscountForThisMonth = new System.Windows.Forms.Label();
            this.textBoxDiscountForToday = new System.Windows.Forms.TextBox();
            this.labelDiscountForToday = new System.Windows.Forms.Label();
            this.textBoxDiffForThisMonth = new System.Windows.Forms.TextBox();
            this.labelDiffForThisMonth = new System.Windows.Forms.Label();
            this.textBoxCostsForThisMonth = new System.Windows.Forms.TextBox();
            this.labelCostsForThisMonth = new System.Windows.Forms.Label();
            this.labelSummForThisMonth = new System.Windows.Forms.Label();
            this.textBoxSummForThisMonth = new System.Windows.Forms.TextBox();
            this.textBoxDiffForToday = new System.Windows.Forms.TextBox();
            this.labelDiffForToday = new System.Windows.Forms.Label();
            this.textBoxCostsForToday = new System.Windows.Forms.TextBox();
            this.labelCostsForToday = new System.Windows.Forms.Label();
            this.labelSummForToday = new System.Windows.Forms.Label();
            this.textBoxSummForToday = new System.Windows.Forms.TextBox();
            this.groupBoxReport = new System.Windows.Forms.GroupBox();
            this.labelType = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.monthCalendarTo = new System.Windows.Forms.MonthCalendar();
            this.monthCalendarFrom = new System.Windows.Forms.MonthCalendar();
            this.groupBoxCostPrice = new System.Windows.Forms.GroupBox();
            this.dataGridViewCostPrice = new System.Windows.Forms.DataGridView();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonAddAllConsumbles = new System.Windows.Forms.Button();
            this.comboBoxSelectGood = new System.Windows.Forms.ComboBox();
            this.buttonSelectConsumble = new System.Windows.Forms.Button();
            this.tabPageGoods = new System.Windows.Forms.TabPage();
            this.buttonCopyGood = new System.Windows.Forms.Button();
            this.dataGridViewGoods = new System.Windows.Forms.DataGridView();
            this.buttonAddGood = new System.Windows.Forms.Button();
            this.tabPageAcounts = new System.Windows.Forms.TabPage();
            this.dataGridViewAcount = new System.Windows.Forms.DataGridView();
            this.buttonAddAcount = new System.Windows.Forms.Button();
            this.tabPageClients = new System.Windows.Forms.TabPage();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.tabPageEmployees = new System.Windows.Forms.TabPage();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.buttonAddEmploye = new System.Windows.Forms.Button();
            this.tabPageSuppliers = new System.Windows.Forms.TabPage();
            this.dataGridViewSuppliers = new System.Windows.Forms.DataGridView();
            this.buttonAddSupplier = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPageConsumables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsumbles)).BeginInit();
            this.tabPageArrivalAndWriteOff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWriteOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArrival)).BeginInit();
            this.tabPageReports.SuspendLayout();
            this.groupBoxCurrentReport.SuspendLayout();
            this.groupBoxReport.SuspendLayout();
            this.groupBoxCostPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCostPrice)).BeginInit();
            this.tabPageGoods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGoods)).BeginInit();
            this.tabPageAcounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAcount)).BeginInit();
            this.tabPageClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.tabPageEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.tabPageSuppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuppliers)).BeginInit();
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
            this.tabPageConsumables.Controls.Add(this.checkBoxPrint);
            this.tabPageConsumables.Controls.Add(this.buttonPrintConsumbles);
            this.tabPageConsumables.Controls.Add(this.buttonConsumbleCategories);
            this.tabPageConsumables.Controls.Add(this.buttonConsumbleTypes);
            this.tabPageConsumables.Controls.Add(this.dataGridViewConsumbles);
            this.tabPageConsumables.Controls.Add(this.buttonAddConsumble);
            this.tabPageConsumables.Location = new System.Drawing.Point(4, 22);
            this.tabPageConsumables.Name = "tabPageConsumables";
            this.tabPageConsumables.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConsumables.Size = new System.Drawing.Size(1429, 605);
            this.tabPageConsumables.TabIndex = 0;
            this.tabPageConsumables.Text = "Расходники";
            this.tabPageConsumables.UseVisualStyleBackColor = true;
            // 
            // checkBoxPrint
            // 
            this.checkBoxPrint.AutoSize = true;
            this.checkBoxPrint.Location = new System.Drawing.Point(1111, 581);
            this.checkBoxPrint.Name = "checkBoxPrint";
            this.checkBoxPrint.Size = new System.Drawing.Size(151, 17);
            this.checkBoxPrint.TabIndex = 7;
            this.checkBoxPrint.Text = "Печатать с количеством";
            this.checkBoxPrint.UseVisualStyleBackColor = true;
            // 
            // buttonPrintConsumbles
            // 
            this.buttonPrintConsumbles.Location = new System.Drawing.Point(1267, 575);
            this.buttonPrintConsumbles.Name = "buttonPrintConsumbles";
            this.buttonPrintConsumbles.Size = new System.Drawing.Size(75, 23);
            this.buttonPrintConsumbles.TabIndex = 6;
            this.buttonPrintConsumbles.Text = "Печать";
            this.buttonPrintConsumbles.UseVisualStyleBackColor = true;
            this.buttonPrintConsumbles.Click += new System.EventHandler(this.buttonPrintConsumbles_Click);
            // 
            // buttonConsumbleCategories
            // 
            this.buttonConsumbleCategories.Location = new System.Drawing.Point(61, 575);
            this.buttonConsumbleCategories.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConsumbleCategories.Name = "buttonConsumbleCategories";
            this.buttonConsumbleCategories.Size = new System.Drawing.Size(50, 15);
            this.buttonConsumbleCategories.TabIndex = 5;
            this.buttonConsumbleCategories.Text = "Категории";
            this.buttonConsumbleCategories.UseVisualStyleBackColor = true;
            this.buttonConsumbleCategories.Click += new System.EventHandler(this.buttonConsumbleCategories_Click);
            // 
            // buttonConsumbleTypes
            // 
            this.buttonConsumbleTypes.Location = new System.Drawing.Point(7, 576);
            this.buttonConsumbleTypes.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConsumbleTypes.Name = "buttonConsumbleTypes";
            this.buttonConsumbleTypes.Size = new System.Drawing.Size(50, 15);
            this.buttonConsumbleTypes.TabIndex = 4;
            this.buttonConsumbleTypes.Text = "Типы";
            this.buttonConsumbleTypes.UseVisualStyleBackColor = true;
            this.buttonConsumbleTypes.Click += new System.EventHandler(this.buttonConsumbleTypes_Click);
            // 
            // dataGridViewConsumbles
            // 
            this.dataGridViewConsumbles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsumbles.Location = new System.Drawing.Point(7, 7);
            this.dataGridViewConsumbles.Name = "dataGridViewConsumbles";
            this.dataGridViewConsumbles.Size = new System.Drawing.Size(1416, 563);
            this.dataGridViewConsumbles.TabIndex = 3;
            // 
            // buttonAddConsumble
            // 
            this.buttonAddConsumble.Location = new System.Drawing.Point(1348, 575);
            this.buttonAddConsumble.Name = "buttonAddConsumble";
            this.buttonAddConsumble.Size = new System.Drawing.Size(75, 23);
            this.buttonAddConsumble.TabIndex = 2;
            this.buttonAddConsumble.Text = "Добавить";
            this.buttonAddConsumble.UseVisualStyleBackColor = true;
            this.buttonAddConsumble.Click += new System.EventHandler(this.buttonAddConsumble_Click);
            // 
            // tabPageArrivalAndWriteOff
            // 
            this.tabPageArrivalAndWriteOff.Controls.Add(this.dataGridViewWriteOff);
            this.tabPageArrivalAndWriteOff.Controls.Add(this.buttonWriteOff);
            this.tabPageArrivalAndWriteOff.Controls.Add(this.buttonArrivial);
            this.tabPageArrivalAndWriteOff.Controls.Add(this.dataGridViewArrival);
            this.tabPageArrivalAndWriteOff.Location = new System.Drawing.Point(4, 22);
            this.tabPageArrivalAndWriteOff.Name = "tabPageArrivalAndWriteOff";
            this.tabPageArrivalAndWriteOff.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageArrivalAndWriteOff.Size = new System.Drawing.Size(1429, 605);
            this.tabPageArrivalAndWriteOff.TabIndex = 1;
            this.tabPageArrivalAndWriteOff.Text = "Приход и Списание";
            this.tabPageArrivalAndWriteOff.UseVisualStyleBackColor = true;
            // 
            // dataGridViewWriteOff
            // 
            this.dataGridViewWriteOff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWriteOff.Location = new System.Drawing.Point(728, 6);
            this.dataGridViewWriteOff.Name = "dataGridViewWriteOff";
            this.dataGridViewWriteOff.Size = new System.Drawing.Size(694, 553);
            this.dataGridViewWriteOff.TabIndex = 7;
            // 
            // buttonWriteOff
            // 
            this.buttonWriteOff.Location = new System.Drawing.Point(1347, 575);
            this.buttonWriteOff.Name = "buttonWriteOff";
            this.buttonWriteOff.Size = new System.Drawing.Size(75, 23);
            this.buttonWriteOff.TabIndex = 6;
            this.buttonWriteOff.Text = "Списание";
            this.buttonWriteOff.UseVisualStyleBackColor = true;
            this.buttonWriteOff.Click += new System.EventHandler(this.buttonWriteOff_Click);
            // 
            // buttonArrivial
            // 
            this.buttonArrivial.Location = new System.Drawing.Point(626, 575);
            this.buttonArrivial.Name = "buttonArrivial";
            this.buttonArrivial.Size = new System.Drawing.Size(75, 23);
            this.buttonArrivial.TabIndex = 5;
            this.buttonArrivial.Text = "Приход";
            this.buttonArrivial.UseVisualStyleBackColor = true;
            this.buttonArrivial.Click += new System.EventHandler(this.buttonArrivial_Click);
            // 
            // dataGridViewArrival
            // 
            this.dataGridViewArrival.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArrival.Location = new System.Drawing.Point(7, 6);
            this.dataGridViewArrival.Name = "dataGridViewArrival";
            this.dataGridViewArrival.Size = new System.Drawing.Size(694, 553);
            this.dataGridViewArrival.TabIndex = 4;
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
            this.groupBoxCurrentReport.Size = new System.Drawing.Size(358, 592);
            this.groupBoxCurrentReport.TabIndex = 2;
            this.groupBoxCurrentReport.TabStop = false;
            this.groupBoxCurrentReport.Text = "Текущий отчет";
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
            // textBoxDiscountForThisMonth
            // 
            this.textBoxDiscountForThisMonth.Location = new System.Drawing.Point(184, 153);
            this.textBoxDiscountForThisMonth.Name = "textBoxDiscountForThisMonth";
            this.textBoxDiscountForThisMonth.ReadOnly = true;
            this.textBoxDiscountForThisMonth.Size = new System.Drawing.Size(149, 20);
            this.textBoxDiscountForThisMonth.TabIndex = 21;
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
            // textBoxDiscountForToday
            // 
            this.textBoxDiscountForToday.Location = new System.Drawing.Point(6, 153);
            this.textBoxDiscountForToday.Name = "textBoxDiscountForToday";
            this.textBoxDiscountForToday.ReadOnly = true;
            this.textBoxDiscountForToday.Size = new System.Drawing.Size(149, 20);
            this.textBoxDiscountForToday.TabIndex = 19;
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
            // textBoxDiffForToday
            // 
            this.textBoxDiffForToday.Location = new System.Drawing.Point(6, 114);
            this.textBoxDiffForToday.Name = "textBoxDiffForToday";
            this.textBoxDiffForToday.ReadOnly = true;
            this.textBoxDiffForToday.Size = new System.Drawing.Size(149, 20);
            this.textBoxDiffForToday.TabIndex = 5;
            // 
            // labelDiffForToday
            // 
            this.labelDiffForToday.AutoSize = true;
            this.labelDiffForToday.Location = new System.Drawing.Point(3, 98);
            this.labelDiffForToday.Name = "labelDiffForToday";
            this.labelDiffForToday.Size = new System.Drawing.Size(96, 13);
            this.labelDiffForToday.TabIndex = 4;
            this.labelDiffForToday.Text = "Итого за сегодня";
            // 
            // textBoxCostsForToday
            // 
            this.textBoxCostsForToday.Location = new System.Drawing.Point(6, 75);
            this.textBoxCostsForToday.Name = "textBoxCostsForToday";
            this.textBoxCostsForToday.ReadOnly = true;
            this.textBoxCostsForToday.Size = new System.Drawing.Size(149, 20);
            this.textBoxCostsForToday.TabIndex = 3;
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
            // labelSummForToday
            // 
            this.labelSummForToday.AutoSize = true;
            this.labelSummForToday.Location = new System.Drawing.Point(3, 20);
            this.labelSummForToday.Name = "labelSummForToday";
            this.labelSummForToday.Size = new System.Drawing.Size(100, 13);
            this.labelSummForToday.TabIndex = 1;
            this.labelSummForToday.Text = "Сумма за сегодня";
            // 
            // textBoxSummForToday
            // 
            this.textBoxSummForToday.Location = new System.Drawing.Point(6, 36);
            this.textBoxSummForToday.Name = "textBoxSummForToday";
            this.textBoxSummForToday.ReadOnly = true;
            this.textBoxSummForToday.Size = new System.Drawing.Size(149, 20);
            this.textBoxSummForToday.TabIndex = 0;
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
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(29, 409);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(62, 13);
            this.labelType.TabIndex = 7;
            this.labelType.Text = "Тип отчета";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(38, 215);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(22, 13);
            this.labelTo.TabIndex = 6;
            this.labelTo.Text = "До";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(29, 20);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(20, 13);
            this.labelFrom.TabIndex = 5;
            this.labelFrom.Text = "От";
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
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(159, 560);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(75, 23);
            this.buttonPrint.TabIndex = 3;
            this.buttonPrint.Text = "Печать";
            this.buttonPrint.UseVisualStyleBackColor = true;
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(32, 425);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(178, 21);
            this.comboBoxType.TabIndex = 2;
            // 
            // monthCalendarTo
            // 
            this.monthCalendarTo.Location = new System.Drawing.Point(32, 237);
            this.monthCalendarTo.Name = "monthCalendarTo";
            this.monthCalendarTo.TabIndex = 1;
            // 
            // monthCalendarFrom
            // 
            this.monthCalendarFrom.Location = new System.Drawing.Point(32, 42);
            this.monthCalendarFrom.Name = "monthCalendarFrom";
            this.monthCalendarFrom.TabIndex = 0;
            // 
            // groupBoxCostPrice
            // 
            this.groupBoxCostPrice.Controls.Add(this.dataGridViewCostPrice);
            this.groupBoxCostPrice.Controls.Add(this.buttonClear);
            this.groupBoxCostPrice.Controls.Add(this.buttonAddAllConsumbles);
            this.groupBoxCostPrice.Controls.Add(this.comboBoxSelectGood);
            this.groupBoxCostPrice.Controls.Add(this.buttonSelectConsumble);
            this.groupBoxCostPrice.Location = new System.Drawing.Point(370, 7);
            this.groupBoxCostPrice.Name = "groupBoxCostPrice";
            this.groupBoxCostPrice.Size = new System.Drawing.Size(781, 592);
            this.groupBoxCostPrice.TabIndex = 0;
            this.groupBoxCostPrice.TabStop = false;
            this.groupBoxCostPrice.Text = "Себестоимсость";
            // 
            // dataGridViewCostPrice
            // 
            this.dataGridViewCostPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCostPrice.Location = new System.Drawing.Point(7, 20);
            this.dataGridViewCostPrice.Name = "dataGridViewCostPrice";
            this.dataGridViewCostPrice.Size = new System.Drawing.Size(753, 537);
            this.dataGridViewCostPrice.TabIndex = 4;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(7, 563);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonAddAllConsumbles
            // 
            this.buttonAddAllConsumbles.Location = new System.Drawing.Point(87, 563);
            this.buttonAddAllConsumbles.Name = "buttonAddAllConsumbles";
            this.buttonAddAllConsumbles.Size = new System.Drawing.Size(89, 23);
            this.buttonAddAllConsumbles.TabIndex = 2;
            this.buttonAddAllConsumbles.Text = "Добавить все";
            this.buttonAddAllConsumbles.UseVisualStyleBackColor = true;
            this.buttonAddAllConsumbles.Click += new System.EventHandler(this.buttonAddAllConsumbles_Click);
            // 
            // comboBoxSelectGood
            // 
            this.comboBoxSelectGood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectGood.FormattingEnabled = true;
            this.comboBoxSelectGood.Location = new System.Drawing.Point(182, 565);
            this.comboBoxSelectGood.Name = "comboBoxSelectGood";
            this.comboBoxSelectGood.Size = new System.Drawing.Size(497, 21);
            this.comboBoxSelectGood.TabIndex = 1;
            // 
            // buttonSelectConsumble
            // 
            this.buttonSelectConsumble.Location = new System.Drawing.Point(685, 562);
            this.buttonSelectConsumble.Name = "buttonSelectConsumble";
            this.buttonSelectConsumble.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectConsumble.TabIndex = 0;
            this.buttonSelectConsumble.Text = "Добавить";
            this.buttonSelectConsumble.UseVisualStyleBackColor = true;
            this.buttonSelectConsumble.Click += new System.EventHandler(this.buttonSelectConsumble_Click);
            // 
            // tabPageGoods
            // 
            this.tabPageGoods.Controls.Add(this.buttonCopyGood);
            this.tabPageGoods.Controls.Add(this.dataGridViewGoods);
            this.tabPageGoods.Controls.Add(this.buttonAddGood);
            this.tabPageGoods.Location = new System.Drawing.Point(4, 22);
            this.tabPageGoods.Name = "tabPageGoods";
            this.tabPageGoods.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGoods.Size = new System.Drawing.Size(1429, 605);
            this.tabPageGoods.TabIndex = 3;
            this.tabPageGoods.Text = "Товары";
            this.tabPageGoods.UseVisualStyleBackColor = true;
            // 
            // buttonCopyGood
            // 
            this.buttonCopyGood.Location = new System.Drawing.Point(1267, 576);
            this.buttonCopyGood.Name = "buttonCopyGood";
            this.buttonCopyGood.Size = new System.Drawing.Size(75, 23);
            this.buttonCopyGood.TabIndex = 4;
            this.buttonCopyGood.Text = "Копировать";
            this.buttonCopyGood.UseVisualStyleBackColor = true;
            this.buttonCopyGood.Click += new System.EventHandler(this.buttonCopyGood_Click);
            // 
            // dataGridViewGoods
            // 
            this.dataGridViewGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGoods.Location = new System.Drawing.Point(7, 7);
            this.dataGridViewGoods.Name = "dataGridViewGoods";
            this.dataGridViewGoods.Size = new System.Drawing.Size(1416, 563);
            this.dataGridViewGoods.TabIndex = 3;
            // 
            // buttonAddGood
            // 
            this.buttonAddGood.Location = new System.Drawing.Point(1348, 576);
            this.buttonAddGood.Name = "buttonAddGood";
            this.buttonAddGood.Size = new System.Drawing.Size(75, 23);
            this.buttonAddGood.TabIndex = 0;
            this.buttonAddGood.Text = "Добавить";
            this.buttonAddGood.UseVisualStyleBackColor = true;
            this.buttonAddGood.Click += new System.EventHandler(this.buttonAddGood_Click);
            // 
            // tabPageAcounts
            // 
            this.tabPageAcounts.Controls.Add(this.dataGridViewAcount);
            this.tabPageAcounts.Controls.Add(this.buttonAddAcount);
            this.tabPageAcounts.Location = new System.Drawing.Point(4, 22);
            this.tabPageAcounts.Name = "tabPageAcounts";
            this.tabPageAcounts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAcounts.Size = new System.Drawing.Size(1429, 605);
            this.tabPageAcounts.TabIndex = 4;
            this.tabPageAcounts.Text = "Акаунты";
            this.tabPageAcounts.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAcount
            // 
            this.dataGridViewAcount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAcount.Location = new System.Drawing.Point(7, 7);
            this.dataGridViewAcount.Name = "dataGridViewAcount";
            this.dataGridViewAcount.Size = new System.Drawing.Size(1416, 563);
            this.dataGridViewAcount.TabIndex = 3;
            // 
            // buttonAddAcount
            // 
            this.buttonAddAcount.Location = new System.Drawing.Point(1348, 576);
            this.buttonAddAcount.Name = "buttonAddAcount";
            this.buttonAddAcount.Size = new System.Drawing.Size(75, 23);
            this.buttonAddAcount.TabIndex = 0;
            this.buttonAddAcount.Text = "Добавить";
            this.buttonAddAcount.UseVisualStyleBackColor = true;
            this.buttonAddAcount.Click += new System.EventHandler(this.buttonAddAcount_Click);
            // 
            // tabPageClients
            // 
            this.tabPageClients.Controls.Add(this.dataGridViewClients);
            this.tabPageClients.Controls.Add(this.buttonAddClient);
            this.tabPageClients.Location = new System.Drawing.Point(4, 22);
            this.tabPageClients.Name = "tabPageClients";
            this.tabPageClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClients.Size = new System.Drawing.Size(1429, 605);
            this.tabPageClients.TabIndex = 5;
            this.tabPageClients.Text = "Клиенты";
            this.tabPageClients.UseVisualStyleBackColor = true;
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Location = new System.Drawing.Point(7, 7);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.Size = new System.Drawing.Size(1416, 563);
            this.dataGridViewClients.TabIndex = 3;
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.Location = new System.Drawing.Point(1348, 576);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(75, 23);
            this.buttonAddClient.TabIndex = 1;
            this.buttonAddClient.Text = "Добавить";
            this.buttonAddClient.UseVisualStyleBackColor = true;
            this.buttonAddClient.Click += new System.EventHandler(this.buttonAddClient_Click);
            // 
            // tabPageEmployees
            // 
            this.tabPageEmployees.Controls.Add(this.dataGridViewEmployees);
            this.tabPageEmployees.Controls.Add(this.buttonAddEmploye);
            this.tabPageEmployees.Location = new System.Drawing.Point(4, 22);
            this.tabPageEmployees.Name = "tabPageEmployees";
            this.tabPageEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmployees.Size = new System.Drawing.Size(1429, 605);
            this.tabPageEmployees.TabIndex = 6;
            this.tabPageEmployees.Text = "Сотрудники";
            this.tabPageEmployees.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(7, 7);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.Size = new System.Drawing.Size(1416, 563);
            this.dataGridViewEmployees.TabIndex = 5;
            // 
            // buttonAddEmploye
            // 
            this.buttonAddEmploye.Location = new System.Drawing.Point(1348, 576);
            this.buttonAddEmploye.Name = "buttonAddEmploye";
            this.buttonAddEmploye.Size = new System.Drawing.Size(75, 23);
            this.buttonAddEmploye.TabIndex = 1;
            this.buttonAddEmploye.Text = "Добавить";
            this.buttonAddEmploye.UseVisualStyleBackColor = true;
            this.buttonAddEmploye.Click += new System.EventHandler(this.buttonAddEmploye_Click);
            // 
            // tabPageSuppliers
            // 
            this.tabPageSuppliers.Controls.Add(this.dataGridViewSuppliers);
            this.tabPageSuppliers.Controls.Add(this.buttonAddSupplier);
            this.tabPageSuppliers.Location = new System.Drawing.Point(4, 22);
            this.tabPageSuppliers.Name = "tabPageSuppliers";
            this.tabPageSuppliers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSuppliers.Size = new System.Drawing.Size(1429, 605);
            this.tabPageSuppliers.TabIndex = 7;
            this.tabPageSuppliers.Text = "Поставщики";
            this.tabPageSuppliers.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSuppliers
            // 
            this.dataGridViewSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSuppliers.Location = new System.Drawing.Point(7, 7);
            this.dataGridViewSuppliers.Name = "dataGridViewSuppliers";
            this.dataGridViewSuppliers.Size = new System.Drawing.Size(1416, 563);
            this.dataGridViewSuppliers.TabIndex = 3;
            // 
            // buttonAddSupplier
            // 
            this.buttonAddSupplier.Location = new System.Drawing.Point(1348, 576);
            this.buttonAddSupplier.Name = "buttonAddSupplier";
            this.buttonAddSupplier.Size = new System.Drawing.Size(75, 23);
            this.buttonAddSupplier.TabIndex = 0;
            this.buttonAddSupplier.Text = "Добавить";
            this.buttonAddSupplier.UseVisualStyleBackColor = true;
            this.buttonAddSupplier.Click += new System.EventHandler(this.buttonAddSupplier_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 668);
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
            this.tabPageConsumables.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsumbles)).EndInit();
            this.tabPageArrivalAndWriteOff.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWriteOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArrival)).EndInit();
            this.tabPageReports.ResumeLayout(false);
            this.groupBoxCurrentReport.ResumeLayout(false);
            this.groupBoxCurrentReport.PerformLayout();
            this.groupBoxReport.ResumeLayout(false);
            this.groupBoxReport.PerformLayout();
            this.groupBoxCostPrice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCostPrice)).EndInit();
            this.tabPageGoods.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGoods)).EndInit();
            this.tabPageAcounts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAcount)).EndInit();
            this.tabPageClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.tabPageEmployees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.tabPageSuppliers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuppliers)).EndInit();
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
        private System.Windows.Forms.Button buttonAddAllConsumbles;
        private System.Windows.Forms.ComboBox comboBoxSelectGood;
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
        private System.Windows.Forms.DataGridView dataGridViewWriteOff;
        private System.Windows.Forms.DataGridView dataGridViewGoods;
        private System.Windows.Forms.Button buttonAddGood;
        private System.Windows.Forms.Button buttonAddAcount;
        private System.Windows.Forms.DataGridView dataGridViewAcount;
        private System.Windows.Forms.Button buttonAddClient;
        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.Button buttonAddEmploye;
        private System.Windows.Forms.DataGridView dataGridViewSuppliers;
        private System.Windows.Forms.Button buttonAddSupplier;
        private System.Windows.Forms.Button buttonConsumbleCategories;
        private System.Windows.Forms.Button buttonConsumbleTypes;
        private System.Windows.Forms.Button buttonCopyGood;
        private System.Windows.Forms.CheckBox checkBoxPrint;
        private System.Windows.Forms.Button buttonPrintConsumbles;
    }
}
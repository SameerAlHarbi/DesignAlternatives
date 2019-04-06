namespace DesignAlternatives.WinApp
{
    partial class frmSettings
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
            designAlternativesDb.Dispose();
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label aestheticsLabel;
            System.Windows.Forms.Label maintenanceLabel;
            System.Windows.Forms.Label energyLabel;
            System.Windows.Forms.Label timeLabel;
            System.Windows.Forms.Label costLabel;
            System.Windows.Forms.Label sizeLabel;
            System.Windows.Forms.Label relationLabel;
            System.Windows.Forms.Label accessibilityLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.categoryDataGridView = new System.Windows.Forms.DataGridView();
            this.subCategoryDataGridView = new System.Windows.Forms.DataGridView();
            this.subCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.designOptionDataGridView = new System.Windows.Forms.DataGridView();
            this.designOptionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.aestheticsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.maintenanceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.energyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.timeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.costNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.relationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.accessibilityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnResetDefaults = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            aestheticsLabel = new System.Windows.Forms.Label();
            maintenanceLabel = new System.Windows.Forms.Label();
            energyLabel = new System.Windows.Forms.Label();
            timeLabel = new System.Windows.Forms.Label();
            costLabel = new System.Windows.Forms.Label();
            sizeLabel = new System.Windows.Forms.Label();
            relationLabel = new System.Windows.Forms.Label();
            accessibilityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subCategoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.designOptionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.designOptionsBindingSource)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aestheticsNumericUpDown)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.energyNumericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relationNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessibilityNumericUpDown)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // aestheticsLabel
            // 
            aestheticsLabel.AutoSize = true;
            aestheticsLabel.Location = new System.Drawing.Point(12, 30);
            aestheticsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            aestheticsLabel.Name = "aestheticsLabel";
            aestheticsLabel.Size = new System.Drawing.Size(71, 16);
            aestheticsLabel.TabIndex = 0;
            aestheticsLabel.Text = "Aesthetics:";
            // 
            // maintenanceLabel
            // 
            maintenanceLabel.AutoSize = true;
            maintenanceLabel.Location = new System.Drawing.Point(17, 55);
            maintenanceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            maintenanceLabel.Name = "maintenanceLabel";
            maintenanceLabel.Size = new System.Drawing.Size(85, 16);
            maintenanceLabel.TabIndex = 2;
            maintenanceLabel.Text = "Maintenance:";
            // 
            // energyLabel
            // 
            energyLabel.AutoSize = true;
            energyLabel.Location = new System.Drawing.Point(50, 30);
            energyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            energyLabel.Name = "energyLabel";
            energyLabel.Size = new System.Drawing.Size(52, 16);
            energyLabel.TabIndex = 0;
            energyLabel.Text = "Energy:";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new System.Drawing.Point(44, 52);
            timeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new System.Drawing.Size(42, 16);
            timeLabel.TabIndex = 2;
            timeLabel.Text = "Time:";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new System.Drawing.Point(44, 30);
            costLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(38, 16);
            costLabel.TabIndex = 0;
            costLabel.Text = "Cost:";
            // 
            // sizeLabel
            // 
            sizeLabel.AutoSize = true;
            sizeLabel.Location = new System.Drawing.Point(66, 82);
            sizeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new System.Drawing.Size(37, 16);
            sizeLabel.TabIndex = 4;
            sizeLabel.Text = "Size:";
            // 
            // relationLabel
            // 
            relationLabel.AutoSize = true;
            relationLabel.Location = new System.Drawing.Point(44, 55);
            relationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            relationLabel.Name = "relationLabel";
            relationLabel.Size = new System.Drawing.Size(59, 16);
            relationLabel.TabIndex = 2;
            relationLabel.Text = "Relation:";
            // 
            // accessibilityLabel
            // 
            accessibilityLabel.AutoSize = true;
            accessibilityLabel.Location = new System.Drawing.Point(22, 30);
            accessibilityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            accessibilityLabel.Name = "accessibilityLabel";
            accessibilityLabel.Size = new System.Drawing.Size(81, 16);
            accessibilityLabel.TabIndex = 0;
            accessibilityLabel.Text = "Accessibility:";
            // 
            // categoryDataGridView
            // 
            this.categoryDataGridView.AllowUserToAddRows = false;
            this.categoryDataGridView.AllowUserToDeleteRows = false;
            this.categoryDataGridView.AutoGenerateColumns = false;
            this.categoryDataGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categoryDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.categoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.categoryDataGridView.DataSource = this.categoryBindingSource;
            this.categoryDataGridView.Location = new System.Drawing.Point(9, 25);
            this.categoryDataGridView.Name = "categoryDataGridView";
            this.categoryDataGridView.ReadOnly = true;
            this.categoryDataGridView.RowHeadersVisible = false;
            this.categoryDataGridView.Size = new System.Drawing.Size(300, 241);
            this.categoryDataGridView.TabIndex = 0;
            // 
            // subCategoryDataGridView
            // 
            this.subCategoryDataGridView.AllowUserToAddRows = false;
            this.subCategoryDataGridView.AllowUserToDeleteRows = false;
            this.subCategoryDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subCategoryDataGridView.AutoGenerateColumns = false;
            this.subCategoryDataGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.subCategoryDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.subCategoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subCategoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3});
            this.subCategoryDataGridView.DataSource = this.subCategoriesBindingSource;
            this.subCategoryDataGridView.Location = new System.Drawing.Point(321, 25);
            this.subCategoryDataGridView.Name = "subCategoryDataGridView";
            this.subCategoryDataGridView.ReadOnly = true;
            this.subCategoryDataGridView.RowHeadersVisible = false;
            this.subCategoryDataGridView.Size = new System.Drawing.Size(300, 241);
            this.subCategoryDataGridView.TabIndex = 1;
            // 
            // subCategoriesBindingSource
            // 
            this.subCategoriesBindingSource.DataMember = "SubCategories";
            this.subCategoriesBindingSource.DataSource = this.categoryBindingSource;
            // 
            // designOptionDataGridView
            // 
            this.designOptionDataGridView.AllowUserToAddRows = false;
            this.designOptionDataGridView.AllowUserToDeleteRows = false;
            this.designOptionDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.designOptionDataGridView.AutoGenerateColumns = false;
            this.designOptionDataGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.designOptionDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.designOptionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.designOptionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5});
            this.designOptionDataGridView.DataSource = this.designOptionsBindingSource;
            this.designOptionDataGridView.Location = new System.Drawing.Point(633, 25);
            this.designOptionDataGridView.Name = "designOptionDataGridView";
            this.designOptionDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.designOptionDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.designOptionDataGridView.RowHeadersVisible = false;
            this.designOptionDataGridView.Size = new System.Drawing.Size(300, 241);
            this.designOptionDataGridView.TabIndex = 2;
            // 
            // designOptionsBindingSource
            // 
            this.designOptionsBindingSource.DataMember = "designOptions";
            this.designOptionsBindingSource.DataSource = this.subCategoriesBindingSource;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.aestheticsNumericUpDown);
            this.groupBox5.Controls.Add(aestheticsLabel);
            this.groupBox5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(631, 348);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(202, 119);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Aesthetics";
            // 
            // aestheticsNumericUpDown
            // 
            this.aestheticsNumericUpDown.BackColor = System.Drawing.SystemColors.Info;
            this.aestheticsNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.designOptionsBindingSource, "Aesthetics", true));
            this.aestheticsNumericUpDown.DecimalPlaces = 2;
            this.aestheticsNumericUpDown.Location = new System.Drawing.Point(87, 27);
            this.aestheticsNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.aestheticsNumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.aestheticsNumericUpDown.Name = "aestheticsNumericUpDown";
            this.aestheticsNumericUpDown.Size = new System.Drawing.Size(68, 23);
            this.aestheticsNumericUpDown.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(maintenanceLabel);
            this.groupBox3.Controls.Add(this.maintenanceNumericUpDown);
            this.groupBox3.Controls.Add(energyLabel);
            this.groupBox3.Controls.Add(this.energyNumericUpDown);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(424, 348);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(202, 119);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operation Performance";
            // 
            // maintenanceNumericUpDown
            // 
            this.maintenanceNumericUpDown.BackColor = System.Drawing.SystemColors.Info;
            this.maintenanceNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.designOptionsBindingSource, "Maintenance", true));
            this.maintenanceNumericUpDown.DecimalPlaces = 2;
            this.maintenanceNumericUpDown.Location = new System.Drawing.Point(106, 53);
            this.maintenanceNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.maintenanceNumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.maintenanceNumericUpDown.Name = "maintenanceNumericUpDown";
            this.maintenanceNumericUpDown.Size = new System.Drawing.Size(68, 23);
            this.maintenanceNumericUpDown.TabIndex = 1;
            // 
            // energyNumericUpDown
            // 
            this.energyNumericUpDown.BackColor = System.Drawing.SystemColors.Info;
            this.energyNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.designOptionsBindingSource, "Energy", true));
            this.energyNumericUpDown.DecimalPlaces = 2;
            this.energyNumericUpDown.Location = new System.Drawing.Point(106, 27);
            this.energyNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.energyNumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.energyNumericUpDown.Name = "energyNumericUpDown";
            this.energyNumericUpDown.Size = new System.Drawing.Size(68, 23);
            this.energyNumericUpDown.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(timeLabel);
            this.groupBox2.Controls.Add(this.timeNumericUpDown);
            this.groupBox2.Controls.Add(costLabel);
            this.groupBox2.Controls.Add(this.costNumericUpDown);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(217, 348);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(202, 119);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Construction Performance";
            // 
            // timeNumericUpDown
            // 
            this.timeNumericUpDown.BackColor = System.Drawing.SystemColors.Info;
            this.timeNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.designOptionsBindingSource, "Time", true));
            this.timeNumericUpDown.DecimalPlaces = 2;
            this.timeNumericUpDown.Location = new System.Drawing.Point(90, 53);
            this.timeNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.timeNumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.timeNumericUpDown.Name = "timeNumericUpDown";
            this.timeNumericUpDown.Size = new System.Drawing.Size(68, 23);
            this.timeNumericUpDown.TabIndex = 1;
            // 
            // costNumericUpDown
            // 
            this.costNumericUpDown.BackColor = System.Drawing.SystemColors.Info;
            this.costNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.designOptionsBindingSource, "Cost", true));
            this.costNumericUpDown.DecimalPlaces = 2;
            this.costNumericUpDown.Location = new System.Drawing.Point(90, 27);
            this.costNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.costNumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.costNumericUpDown.Name = "costNumericUpDown";
            this.costNumericUpDown.Size = new System.Drawing.Size(68, 23);
            this.costNumericUpDown.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(sizeLabel);
            this.groupBox1.Controls.Add(this.sizeNumericUpDown);
            this.groupBox1.Controls.Add(relationLabel);
            this.groupBox1.Controls.Add(this.relationNumericUpDown);
            this.groupBox1.Controls.Add(accessibilityLabel);
            this.groupBox1.Controls.Add(this.accessibilityNumericUpDown);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 348);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(202, 119);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Space Functionality";
            // 
            // sizeNumericUpDown
            // 
            this.sizeNumericUpDown.BackColor = System.Drawing.SystemColors.Info;
            this.sizeNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.designOptionsBindingSource, "Size", true));
            this.sizeNumericUpDown.DecimalPlaces = 2;
            this.sizeNumericUpDown.Location = new System.Drawing.Point(113, 80);
            this.sizeNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.sizeNumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.sizeNumericUpDown.Name = "sizeNumericUpDown";
            this.sizeNumericUpDown.Size = new System.Drawing.Size(68, 23);
            this.sizeNumericUpDown.TabIndex = 2;
            // 
            // relationNumericUpDown
            // 
            this.relationNumericUpDown.BackColor = System.Drawing.SystemColors.Info;
            this.relationNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.designOptionsBindingSource, "Relation", true));
            this.relationNumericUpDown.DecimalPlaces = 2;
            this.relationNumericUpDown.Location = new System.Drawing.Point(113, 53);
            this.relationNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.relationNumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.relationNumericUpDown.Name = "relationNumericUpDown";
            this.relationNumericUpDown.Size = new System.Drawing.Size(68, 23);
            this.relationNumericUpDown.TabIndex = 1;
            // 
            // accessibilityNumericUpDown
            // 
            this.accessibilityNumericUpDown.BackColor = System.Drawing.SystemColors.Info;
            this.accessibilityNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.designOptionsBindingSource, "Accessibility", true));
            this.accessibilityNumericUpDown.DecimalPlaces = 2;
            this.accessibilityNumericUpDown.Location = new System.Drawing.Point(113, 28);
            this.accessibilityNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.accessibilityNumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.accessibilityNumericUpDown.Name = "accessibilityNumericUpDown";
            this.accessibilityNumericUpDown.Size = new System.Drawing.Size(68, 23);
            this.accessibilityNumericUpDown.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(838, 349);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(95, 116);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sum";
            // 
            // label1
            // 
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.designOptionsBindingSource, "Sum", true));
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Image = global::DesignAlternatives.WinApp.Properties.Resources.floppy_64;
            this.btnSave.Location = new System.Drawing.Point(421, 488);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 81);
            this.btnSave.TabIndex = 10;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnResetDefaults
            // 
            this.btnResetDefaults.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnResetDefaults.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetDefaults.Image = global::DesignAlternatives.WinApp.Properties.Resources.refresh64_2;
            this.btnResetDefaults.Location = new System.Drawing.Point(10, 488);
            this.btnResetDefaults.Name = "btnResetDefaults";
            this.btnResetDefaults.Size = new System.Drawing.Size(100, 81);
            this.btnResetDefaults.TabIndex = 9;
            this.btnResetDefaults.UseVisualStyleBackColor = true;
            this.btnResetDefaults.Click += new System.EventHandler(this.btnResetDefaults_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox6.Location = new System.Drawing.Point(9, 275);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(458, 62);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Sub Category Description";
            // 
            // label2
            // 
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subCategoriesBindingSource, "Description", true));
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(446, 23);
            this.label2.TabIndex = 0;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox7.Location = new System.Drawing.Point(475, 275);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(458, 62);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Design Option Description";
            // 
            // label3
            // 
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.designOptionsBindingSource, "Description", true));
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(446, 23);
            this.label3.TabIndex = 0;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(DesignAlternatives.WinApp.Models.Category);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn5.HeaderText = "Design Option";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Sub Category";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Category";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 584);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.designOptionDataGridView);
            this.Controls.Add(this.subCategoryDataGridView);
            this.Controls.Add(this.btnResetDefaults);
            this.Controls.Add(this.categoryDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subCategoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subCategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.designOptionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.designOptionsBindingSource)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aestheticsNumericUpDown)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.energyNumericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relationNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessibilityNumericUpDown)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.BindingSource subCategoriesBindingSource;
        private System.Windows.Forms.BindingSource designOptionsBindingSource;
        private System.Windows.Forms.DataGridView categoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnResetDefaults;
        private System.Windows.Forms.DataGridView subCategoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView designOptionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown aestheticsNumericUpDown;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown maintenanceNumericUpDown;
        private System.Windows.Forms.NumericUpDown energyNumericUpDown;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown timeNumericUpDown;
        private System.Windows.Forms.NumericUpDown costNumericUpDown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown sizeNumericUpDown;
        private System.Windows.Forms.NumericUpDown relationNumericUpDown;
        private System.Windows.Forms.NumericUpDown accessibilityNumericUpDown;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label3;
    }
}
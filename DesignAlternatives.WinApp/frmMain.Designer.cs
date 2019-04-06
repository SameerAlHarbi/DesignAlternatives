namespace DesignAlternatives.WinApp
{
    partial class frmMain
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
            System.Windows.Forms.Label planEfficiencyIdLabel;
            System.Windows.Forms.Label shapeComplexityIdLabel;
            System.Windows.Forms.Label numberOfStoreyIdLabel;
            System.Windows.Forms.Label averageStoreyHeightIdLabel;
            System.Windows.Forms.Label glazingShapeIdLabel;
            System.Windows.Forms.Label glazingEfficiencyIdLabel;
            System.Windows.Forms.Label sunBreakersGeometryIdLabel;
            System.Windows.Forms.Label spanDimensionIdLabel;
            System.Windows.Forms.Label circulationAreaIdLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.designAlternativeResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSettings = new System.Windows.Forms.Button();
            this.designAlternativeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccessibilityTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RelationTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnergyTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaintenanceTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AestheticsTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designAlternativeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.nudAlternativesNumber = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.relatedToViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.relatedToWindBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.glazingPercentageIdComboBox = new System.Windows.Forms.ComboBox();
            this.glazingPercentageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.facadeMaterialIdComboBox = new System.Windows.Forms.ComboBox();
            this.facadeMaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buildingFormIdComboBox = new System.Windows.Forms.ComboBox();
            this.buildingFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.shapeComplexityIdComboBox = new System.Windows.Forms.ComboBox();
            this.shapeComplexityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.planEfficiencyIdComboBox = new System.Windows.Forms.ComboBox();
            this.planEfficiencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.sunBreakersGeometryIdComboBox = new System.Windows.Forms.ComboBox();
            this.sunBreakersGeometryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.glazingEfficiencyIdComboBox = new System.Windows.Forms.ComboBox();
            this.glazingEfficiencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.glazingShapeIdComboBox = new System.Windows.Forms.ComboBox();
            this.glazingShapeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.averageStoreyHeightIdComboBox = new System.Windows.Forms.ComboBox();
            this.averageStoreyHeightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numberOfStoreyIdComboBox = new System.Windows.Forms.ComboBox();
            this.numberOfStoreyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.spanDimensionIdComboBox = new System.Windows.Forms.ComboBox();
            this.spanDimensionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.circulationAreaIdComboBox = new System.Windows.Forms.ComboBox();
            this.circulationAreaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnResetDefaults = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.label59 = new System.Windows.Forms.Label();
            this.lblBestCriteriaPercentage = new System.Windows.Forms.Label();
            this.lblBestCriteria = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.rdAethiticas = new System.Windows.Forms.RadioButton();
            this.rdOperationPerformance = new System.Windows.Forms.RadioButton();
            this.rdConstructionPerformance = new System.Windows.Forms.RadioButton();
            this.rdSpaceFunctionality = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.designAlternativeDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn46 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn47 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn49 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn50 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn51 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn52 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn53 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn54 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn55 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn56 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn57 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn58 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn59 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn60 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn61 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn62 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn63 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn64 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn65 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn66 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.designAlternativeDataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            planEfficiencyIdLabel = new System.Windows.Forms.Label();
            shapeComplexityIdLabel = new System.Windows.Forms.Label();
            numberOfStoreyIdLabel = new System.Windows.Forms.Label();
            averageStoreyHeightIdLabel = new System.Windows.Forms.Label();
            glazingShapeIdLabel = new System.Windows.Forms.Label();
            glazingEfficiencyIdLabel = new System.Windows.Forms.Label();
            sunBreakersGeometryIdLabel = new System.Windows.Forms.Label();
            spanDimensionIdLabel = new System.Windows.Forms.Label();
            circulationAreaIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.designAlternativeResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.designAlternativeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.designAlternativeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlternativesNumber)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.relatedToViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatedToWindBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glazingPercentageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facadeMaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingFormBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shapeComplexityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planEfficiencyBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sunBreakersGeometryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glazingEfficiencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glazingShapeBindingSource)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.averageStoreyHeightBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfStoreyBindingSource)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spanDimensionBindingSource)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circulationAreaBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.designAlternativeDataGridView1)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.designAlternativeDataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // planEfficiencyIdLabel
            // 
            planEfficiencyIdLabel.AutoSize = true;
            planEfficiencyIdLabel.Location = new System.Drawing.Point(14, 34);
            planEfficiencyIdLabel.Name = "planEfficiencyIdLabel";
            planEfficiencyIdLabel.Size = new System.Drawing.Size(109, 16);
            planEfficiencyIdLabel.TabIndex = 0;
            planEfficiencyIdLabel.Text = "a. Plan Efficiency:";
            this.toolTip1.SetToolTip(planEfficiencyIdLabel, "The ratio of building exterior walls area to the building Gross Floors Area (GFA)" +
        "");
            // 
            // shapeComplexityIdLabel
            // 
            shapeComplexityIdLabel.AutoSize = true;
            shapeComplexityIdLabel.Location = new System.Drawing.Point(14, 95);
            shapeComplexityIdLabel.Name = "shapeComplexityIdLabel";
            shapeComplexityIdLabel.Size = new System.Drawing.Size(130, 16);
            shapeComplexityIdLabel.TabIndex = 2;
            shapeComplexityIdLabel.Text = "b. Shape Complexity:";
            this.toolTip1.SetToolTip(shapeComplexityIdLabel, "The proportion degree of building plan dimensions and its setting out ");
            // 
            // numberOfStoreyIdLabel
            // 
            numberOfStoreyIdLabel.AutoSize = true;
            numberOfStoreyIdLabel.Location = new System.Drawing.Point(14, 34);
            numberOfStoreyIdLabel.Name = "numberOfStoreyIdLabel";
            numberOfStoreyIdLabel.Size = new System.Drawing.Size(131, 16);
            numberOfStoreyIdLabel.TabIndex = 0;
            numberOfStoreyIdLabel.Text = "a. Number Of Storey:";
            this.toolTip1.SetToolTip(numberOfStoreyIdLabel, "The number of storeys that building contains to the same floors area");
            // 
            // averageStoreyHeightIdLabel
            // 
            averageStoreyHeightIdLabel.AutoSize = true;
            averageStoreyHeightIdLabel.Location = new System.Drawing.Point(14, 93);
            averageStoreyHeightIdLabel.Name = "averageStoreyHeightIdLabel";
            averageStoreyHeightIdLabel.Size = new System.Drawing.Size(156, 16);
            averageStoreyHeightIdLabel.TabIndex = 2;
            averageStoreyHeightIdLabel.Text = "b. Average Storey Height:";
            this.toolTip1.SetToolTip(averageStoreyHeightIdLabel, "The different range of the storeys heights that give the average building height");
            // 
            // glazingShapeIdLabel
            // 
            glazingShapeIdLabel.AutoSize = true;
            glazingShapeIdLabel.Location = new System.Drawing.Point(13, 38);
            glazingShapeIdLabel.Name = "glazingShapeIdLabel";
            glazingShapeIdLabel.Size = new System.Drawing.Size(105, 16);
            glazingShapeIdLabel.TabIndex = 0;
            glazingShapeIdLabel.Text = "a.Glazing Shape:";
            this.toolTip1.SetToolTip(glazingShapeIdLabel, "The outline configuration shape of different building façade windows ");
            // 
            // glazingEfficiencyIdLabel
            // 
            glazingEfficiencyIdLabel.AutoSize = true;
            glazingEfficiencyIdLabel.Location = new System.Drawing.Point(13, 96);
            glazingEfficiencyIdLabel.Name = "glazingEfficiencyIdLabel";
            glazingEfficiencyIdLabel.Size = new System.Drawing.Size(122, 16);
            glazingEfficiencyIdLabel.TabIndex = 2;
            glazingEfficiencyIdLabel.Text = "b.Glazing Efficiency:";
            this.toolTip1.SetToolTip(glazingEfficiencyIdLabel, "The glazing elements features (Panel number, Reflectivity, Thermal Break, U-value" +
        ") ");
            // 
            // sunBreakersGeometryIdLabel
            // 
            sunBreakersGeometryIdLabel.AutoSize = true;
            sunBreakersGeometryIdLabel.Location = new System.Drawing.Point(13, 161);
            sunBreakersGeometryIdLabel.Name = "sunBreakersGeometryIdLabel";
            sunBreakersGeometryIdLabel.Size = new System.Drawing.Size(162, 16);
            sunBreakersGeometryIdLabel.TabIndex = 4;
            sunBreakersGeometryIdLabel.Text = "c. Sun Breakers Geometry:";
            this.toolTip1.SetToolTip(sunBreakersGeometryIdLabel, "The sun-breakers panels configuration and shading areas");
            // 
            // spanDimensionIdLabel
            // 
            spanDimensionIdLabel.AutoSize = true;
            spanDimensionIdLabel.Location = new System.Drawing.Point(14, 38);
            spanDimensionIdLabel.Name = "spanDimensionIdLabel";
            spanDimensionIdLabel.Size = new System.Drawing.Size(120, 16);
            spanDimensionIdLabel.TabIndex = 0;
            spanDimensionIdLabel.Text = "a. Span Dimension:";
            this.toolTip1.SetToolTip(spanDimensionIdLabel, "The longest distance of usable area between exterior wall and fixed interior elem" +
        "ent");
            // 
            // circulationAreaIdLabel
            // 
            circulationAreaIdLabel.AutoSize = true;
            circulationAreaIdLabel.Location = new System.Drawing.Point(14, 46);
            circulationAreaIdLabel.Name = "circulationAreaIdLabel";
            circulationAreaIdLabel.Size = new System.Drawing.Size(119, 16);
            circulationAreaIdLabel.TabIndex = 0;
            circulationAreaIdLabel.Text = "a. Circulation Area:";
            this.toolTip1.SetToolTip(circulationAreaIdLabel, "The ratio of building circulation space area to the building Gross Floors Area (G" +
        "FA)");
            // 
            // designAlternativeResultBindingSource
            // 
            this.designAlternativeResultBindingSource.DataSource = typeof(DesignAlternatives.WinApp.Models.DesignAlternativeResult);
            // 
            // btnSettings
            // 
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.Image = global::DesignAlternatives.WinApp.Properties.Resources.settings64_2;
            this.btnSettings.Location = new System.Drawing.Point(806, 568);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(2);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(108, 91);
            this.btnSettings.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnSettings, "Design options settings");
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // designAlternativeDataGridView
            // 
            this.designAlternativeDataGridView.AllowUserToAddRows = false;
            this.designAlternativeDataGridView.AllowUserToDeleteRows = false;
            this.designAlternativeDataGridView.AutoGenerateColumns = false;
            this.designAlternativeDataGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.designAlternativeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.designAlternativeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.AccessibilityTotal,
            this.RelationTotal,
            this.SizeTotal,
            this.CostTotal,
            this.TimeTotal,
            this.EnergyTotal,
            this.MaintenanceTotal,
            this.AestheticsTotal,
            this.Score,
            this.Percentage,
            this.Rank});
            this.designAlternativeDataGridView.DataSource = this.designAlternativeBindingSource;
            this.designAlternativeDataGridView.Location = new System.Drawing.Point(14, 90);
            this.designAlternativeDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.designAlternativeDataGridView.Name = "designAlternativeDataGridView";
            this.designAlternativeDataGridView.ReadOnly = true;
            this.designAlternativeDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.designAlternativeDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.designAlternativeDataGridView.RowTemplate.Height = 35;
            this.designAlternativeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.designAlternativeDataGridView.Size = new System.Drawing.Size(386, 455);
            this.designAlternativeDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn2.HeaderText = "Design Alternatives";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // AccessibilityTotal
            // 
            this.AccessibilityTotal.DataPropertyName = "AccessibilityTotal";
            this.AccessibilityTotal.HeaderText = "Accessibility";
            this.AccessibilityTotal.Name = "AccessibilityTotal";
            this.AccessibilityTotal.ReadOnly = true;
            this.AccessibilityTotal.Visible = false;
            this.AccessibilityTotal.Width = 90;
            // 
            // RelationTotal
            // 
            this.RelationTotal.DataPropertyName = "RelationTotal";
            this.RelationTotal.HeaderText = "Relation";
            this.RelationTotal.Name = "RelationTotal";
            this.RelationTotal.ReadOnly = true;
            this.RelationTotal.Visible = false;
            this.RelationTotal.Width = 80;
            // 
            // SizeTotal
            // 
            this.SizeTotal.DataPropertyName = "SizeTotal";
            this.SizeTotal.HeaderText = "Size";
            this.SizeTotal.Name = "SizeTotal";
            this.SizeTotal.ReadOnly = true;
            this.SizeTotal.Visible = false;
            this.SizeTotal.Width = 60;
            // 
            // CostTotal
            // 
            this.CostTotal.DataPropertyName = "CostTotal";
            this.CostTotal.HeaderText = "Cost";
            this.CostTotal.Name = "CostTotal";
            this.CostTotal.ReadOnly = true;
            this.CostTotal.Visible = false;
            this.CostTotal.Width = 60;
            // 
            // TimeTotal
            // 
            this.TimeTotal.DataPropertyName = "TimeTotal";
            this.TimeTotal.HeaderText = "Time";
            this.TimeTotal.Name = "TimeTotal";
            this.TimeTotal.ReadOnly = true;
            this.TimeTotal.Visible = false;
            this.TimeTotal.Width = 60;
            // 
            // EnergyTotal
            // 
            this.EnergyTotal.DataPropertyName = "EnergyTotal";
            this.EnergyTotal.HeaderText = "Energy";
            this.EnergyTotal.Name = "EnergyTotal";
            this.EnergyTotal.ReadOnly = true;
            this.EnergyTotal.Visible = false;
            this.EnergyTotal.Width = 80;
            // 
            // MaintenanceTotal
            // 
            this.MaintenanceTotal.DataPropertyName = "MaintenanceTotal";
            this.MaintenanceTotal.HeaderText = "Maintenance";
            this.MaintenanceTotal.Name = "MaintenanceTotal";
            this.MaintenanceTotal.ReadOnly = true;
            this.MaintenanceTotal.Visible = false;
            this.MaintenanceTotal.Width = 90;
            // 
            // AestheticsTotal
            // 
            this.AestheticsTotal.DataPropertyName = "AestheticsTotal";
            this.AestheticsTotal.HeaderText = "Aesthetics";
            this.AestheticsTotal.Name = "AestheticsTotal";
            this.AestheticsTotal.ReadOnly = true;
            this.AestheticsTotal.Visible = false;
            this.AestheticsTotal.Width = 80;
            // 
            // Score
            // 
            this.Score.DataPropertyName = "Score";
            this.Score.HeaderText = "Score";
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            this.Score.Visible = false;
            this.Score.Width = 80;
            // 
            // Percentage
            // 
            this.Percentage.DataPropertyName = "PercentageText";
            this.Percentage.HeaderText = "Percentage";
            this.Percentage.Name = "Percentage";
            this.Percentage.ReadOnly = true;
            this.Percentage.Visible = false;
            this.Percentage.Width = 90;
            // 
            // Rank
            // 
            this.Rank.DataPropertyName = "Rank";
            this.Rank.HeaderText = "Rank";
            this.Rank.Name = "Rank";
            this.Rank.ReadOnly = true;
            this.Rank.Visible = false;
            this.Rank.Width = 70;
            // 
            // designAlternativeBindingSource
            // 
            this.designAlternativeBindingSource.DataSource = typeof(DesignAlternatives.WinApp.Models.DesignAlternative);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Image = global::DesignAlternatives.WinApp.Properties.Resources.add32;
            this.btnAdd.Location = new System.Drawing.Point(339, 24);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(51, 40);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.btnAdd, "Add new design alternatives and remove the old data");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // nudAlternativesNumber
            // 
            this.nudAlternativesNumber.Font = new System.Drawing.Font("Tahoma", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAlternativesNumber.Location = new System.Drawing.Point(261, 33);
            this.nudAlternativesNumber.Margin = new System.Windows.Forms.Padding(2);
            this.nudAlternativesNumber.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudAlternativesNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAlternativesNumber.Name = "nudAlternativesNumber";
            this.nudAlternativesNumber.Size = new System.Drawing.Size(66, 25);
            this.nudAlternativesNumber.TabIndex = 4;
            this.nudAlternativesNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Number Of Design Alternatives :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(404, 89);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(261, 225);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. Building Orientation";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(216, 52);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 24);
            this.button3.TabIndex = 26;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(216, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.designAlternativeBindingSource, "RelatedToViewId", true));
            this.comboBox2.DataSource = this.relatedToViewBindingSource;
            this.comboBox2.DisplayMember = "Name";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(14, 114);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(197, 24);
            this.comboBox2.TabIndex = 1;
            this.toolTip1.SetToolTip(this.comboBox2, "The building site sitting orientation to have natural or  not natural views");
            this.comboBox2.ValueMember = "Id";
            // 
            // relatedToViewBindingSource
            // 
            this.relatedToViewBindingSource.AllowNew = false;
            this.relatedToViewBindingSource.DataSource = typeof(DesignAlternatives.WinApp.Models.DesignOption);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "b. Related To View:";
            this.toolTip1.SetToolTip(this.label3, "The building site sitting orientation to have natural or  not natural views");
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.designAlternativeBindingSource, "RelatedToWindId", true));
            this.comboBox1.DataSource = this.relatedToWindBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 52);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 24);
            this.comboBox1.TabIndex = 1;
            this.toolTip1.SetToolTip(this.comboBox1, "The building site sitting orientation to face the likely and unlikely winds ");
            this.comboBox1.ValueMember = "Id";
            // 
            // relatedToWindBindingSource
            // 
            this.relatedToWindBindingSource.AllowNew = false;
            this.relatedToWindBindingSource.DataSource = typeof(DesignAlternatives.WinApp.Models.DesignOption);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "a. Related To Wind:";
            this.toolTip1.SetToolTip(this.label2, "The building site sitting orientation to face the likely and unlikely winds ");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.glazingPercentageIdComboBox);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.facadeMaterialIdComboBox);
            this.groupBox2.Controls.Add(this.buildingFormIdComboBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(404, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 225);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2. Building Envelope";
            // 
            // glazingPercentageIdComboBox
            // 
            this.glazingPercentageIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.designAlternativeBindingSource, "GlazingPercentageId", true));
            this.glazingPercentageIdComboBox.DataSource = this.glazingPercentageBindingSource;
            this.glazingPercentageIdComboBox.DisplayMember = "Name";
            this.glazingPercentageIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.glazingPercentageIdComboBox.FormattingEnabled = true;
            this.glazingPercentageIdComboBox.Location = new System.Drawing.Point(14, 181);
            this.glazingPercentageIdComboBox.Name = "glazingPercentageIdComboBox";
            this.glazingPercentageIdComboBox.Size = new System.Drawing.Size(197, 24);
            this.glazingPercentageIdComboBox.TabIndex = 6;
            this.toolTip1.SetToolTip(this.glazingPercentageIdComboBox, "The ratio of façade glazing area to the same façade of wall area");
            this.glazingPercentageIdComboBox.ValueMember = "Id";
            // 
            // glazingPercentageBindingSource
            // 
            this.glazingPercentageBindingSource.AllowNew = false;
            this.glazingPercentageBindingSource.DataSource = typeof(DesignAlternatives.WinApp.Models.DesignOption);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(217, 182);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(35, 23);
            this.button6.TabIndex = 26;
            this.button6.Text = "...";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(216, 58);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(35, 23);
            this.button5.TabIndex = 26;
            this.button5.Text = "...";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(216, 117);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 23);
            this.button4.TabIndex = 26;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // facadeMaterialIdComboBox
            // 
            this.facadeMaterialIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.designAlternativeBindingSource, "FacadeMaterialId", true));
            this.facadeMaterialIdComboBox.DataSource = this.facadeMaterialBindingSource;
            this.facadeMaterialIdComboBox.DisplayMember = "Name";
            this.facadeMaterialIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.facadeMaterialIdComboBox.FormattingEnabled = true;
            this.facadeMaterialIdComboBox.Location = new System.Drawing.Point(15, 116);
            this.facadeMaterialIdComboBox.Name = "facadeMaterialIdComboBox";
            this.facadeMaterialIdComboBox.Size = new System.Drawing.Size(196, 24);
            this.facadeMaterialIdComboBox.TabIndex = 5;
            this.toolTip1.SetToolTip(this.facadeMaterialIdComboBox, "The exterior wall materials used to enclose the building façade and form");
            this.facadeMaterialIdComboBox.ValueMember = "Id";
            // 
            // facadeMaterialBindingSource
            // 
            this.facadeMaterialBindingSource.AllowNew = false;
            this.facadeMaterialBindingSource.DataSource = typeof(DesignAlternatives.WinApp.Models.DesignOption);
            // 
            // buildingFormIdComboBox
            // 
            this.buildingFormIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.designAlternativeBindingSource, "BuildingFormId", true));
            this.buildingFormIdComboBox.DataSource = this.buildingFormBindingSource;
            this.buildingFormIdComboBox.DisplayMember = "Name";
            this.buildingFormIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.buildingFormIdComboBox.FormattingEnabled = true;
            this.buildingFormIdComboBox.Location = new System.Drawing.Point(15, 58);
            this.buildingFormIdComboBox.Name = "buildingFormIdComboBox";
            this.buildingFormIdComboBox.Size = new System.Drawing.Size(196, 24);
            this.buildingFormIdComboBox.TabIndex = 4;
            this.toolTip1.SetToolTip(this.buildingFormIdComboBox, "The degree of how different building masses interlocking to the whole form");
            this.buildingFormIdComboBox.ValueMember = "Id";
            // 
            // buildingFormBindingSource
            // 
            this.buildingFormBindingSource.AllowNew = false;
            this.buildingFormBindingSource.DataSource = typeof(DesignAlternatives.WinApp.Models.DesignOption);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "a. Building Form:";
            this.toolTip1.SetToolTip(this.label4, "The degree of how different building masses interlocking to the whole form");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 162);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "c. Glazing Percentage:";
            this.toolTip1.SetToolTip(this.label6, "The ratio of façade glazing area to the same façade of wall area");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "b. Facade Material:";
            this.toolTip1.SetToolTip(this.label5, "The exterior wall materials used to enclose the building façade and form");
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.shapeComplexityIdComboBox);
            this.groupBox3.Controls.Add(shapeComplexityIdLabel);
            this.groupBox3.Controls.Add(planEfficiencyIdLabel);
            this.groupBox3.Controls.Add(this.planEfficiencyIdComboBox);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(670, 89);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(261, 225);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3. Plan Shape and Complexity";
            // 
            // shapeComplexityIdComboBox
            // 
            this.shapeComplexityIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.designAlternativeBindingSource, "ShapeComplexityId", true));
            this.shapeComplexityIdComboBox.DataSource = this.shapeComplexityBindingSource;
            this.shapeComplexityIdComboBox.DisplayMember = "Name";
            this.shapeComplexityIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shapeComplexityIdComboBox.FormattingEnabled = true;
            this.shapeComplexityIdComboBox.Location = new System.Drawing.Point(17, 114);
            this.shapeComplexityIdComboBox.Name = "shapeComplexityIdComboBox";
            this.shapeComplexityIdComboBox.Size = new System.Drawing.Size(228, 24);
            this.shapeComplexityIdComboBox.TabIndex = 4;
            this.toolTip1.SetToolTip(this.shapeComplexityIdComboBox, "The proportion degree of building plan dimensions and its setting out ");
            this.shapeComplexityIdComboBox.ValueMember = "Id";
            // 
            // shapeComplexityBindingSource
            // 
            this.shapeComplexityBindingSource.DataSource = typeof(DesignAlternatives.WinApp.Models.DesignOption);
            // 
            // planEfficiencyIdComboBox
            // 
            this.planEfficiencyIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.designAlternativeBindingSource, "PlanEfficiencyId", true));
            this.planEfficiencyIdComboBox.DataSource = this.planEfficiencyBindingSource;
            this.planEfficiencyIdComboBox.DisplayMember = "Name";
            this.planEfficiencyIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.planEfficiencyIdComboBox.FormattingEnabled = true;
            this.planEfficiencyIdComboBox.Location = new System.Drawing.Point(17, 52);
            this.planEfficiencyIdComboBox.Name = "planEfficiencyIdComboBox";
            this.planEfficiencyIdComboBox.Size = new System.Drawing.Size(228, 24);
            this.planEfficiencyIdComboBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.planEfficiencyIdComboBox, "The ratio of building exterior walls area to the building Gross Floors Area (GFA)" +
        "");
            this.planEfficiencyIdComboBox.ValueMember = "Id";
            // 
            // planEfficiencyBindingSource
            // 
            this.planEfficiencyBindingSource.DataSource = typeof(DesignAlternatives.WinApp.Models.DesignOption);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(sunBreakersGeometryIdLabel);
            this.groupBox4.Controls.Add(this.sunBreakersGeometryIdComboBox);
            this.groupBox4.Controls.Add(glazingEfficiencyIdLabel);
            this.groupBox4.Controls.Add(this.glazingEfficiencyIdComboBox);
            this.groupBox4.Controls.Add(glazingShapeIdLabel);
            this.groupBox4.Controls.Add(this.glazingShapeIdComboBox);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(937, 90);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(261, 225);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "5. Windows Glazing ";
            // 
            // sunBreakersGeometryIdComboBox
            // 
            this.sunBreakersGeometryIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.designAlternativeBindingSource, "SunBreakersGeometryId", true));
            this.sunBreakersGeometryIdComboBox.DataSource = this.sunBreakersGeometryBindingSource;
            this.sunBreakersGeometryIdComboBox.DisplayMember = "Name";
            this.sunBreakersGeometryIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sunBreakersGeometryIdComboBox.FormattingEnabled = true;
            this.sunBreakersGeometryIdComboBox.Location = new System.Drawing.Point(16, 180);
            this.sunBreakersGeometryIdComboBox.Name = "sunBreakersGeometryIdComboBox";
            this.sunBreakersGeometryIdComboBox.Size = new System.Drawing.Size(228, 24);
            this.sunBreakersGeometryIdComboBox.TabIndex = 5;
            this.toolTip1.SetToolTip(this.sunBreakersGeometryIdComboBox, "The sun-breakers panels configuration and shading areas");
            this.sunBreakersGeometryIdComboBox.ValueMember = "Id";
            // 
            // sunBreakersGeometryBindingSource
            // 
            this.sunBreakersGeometryBindingSource.DataSource = typeof(DesignAlternatives.WinApp.Models.DesignOption);
            // 
            // glazingEfficiencyIdComboBox
            // 
            this.glazingEfficiencyIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.designAlternativeBindingSource, "GlazingEfficiencyId", true));
            this.glazingEfficiencyIdComboBox.DataSource = this.glazingEfficiencyBindingSource;
            this.glazingEfficiencyIdComboBox.DisplayMember = "Name";
            this.glazingEfficiencyIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.glazingEfficiencyIdComboBox.FormattingEnabled = true;
            this.glazingEfficiencyIdComboBox.Location = new System.Drawing.Point(16, 115);
            this.glazingEfficiencyIdComboBox.Name = "glazingEfficiencyIdComboBox";
            this.glazingEfficiencyIdComboBox.Size = new System.Drawing.Size(228, 24);
            this.glazingEfficiencyIdComboBox.TabIndex = 3;
            this.toolTip1.SetToolTip(this.glazingEfficiencyIdComboBox, "The glazing elements features (Panel number, Reflectivity, Thermal Break, U-value" +
        ") ");
            this.glazingEfficiencyIdComboBox.ValueMember = "Id";
            // 
            // glazingEfficiencyBindingSource
            // 
            this.glazingEfficiencyBindingSource.DataSource = typeof(DesignAlternatives.WinApp.Models.DesignOption);
            // 
            // glazingShapeIdComboBox
            // 
            this.glazingShapeIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.designAlternativeBindingSource, "GlazingShapeId", true));
            this.glazingShapeIdComboBox.DataSource = this.glazingShapeBindingSource;
            this.glazingShapeIdComboBox.DisplayMember = "Name";
            this.glazingShapeIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.glazingShapeIdComboBox.FormattingEnabled = true;
            this.glazingShapeIdComboBox.Location = new System.Drawing.Point(16, 57);
            this.glazingShapeIdComboBox.Name = "glazingShapeIdComboBox";
            this.glazingShapeIdComboBox.Size = new System.Drawing.Size(228, 24);
            this.glazingShapeIdComboBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.glazingShapeIdComboBox, "The outline configuration shape of different building façade windows ");
            this.glazingShapeIdComboBox.ValueMember = "Id";
            // 
            // glazingShapeBindingSource
            // 
            this.glazingShapeBindingSource.DataSource = typeof(DesignAlternatives.WinApp.Models.DesignOption);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(averageStoreyHeightIdLabel);
            this.groupBox5.Controls.Add(this.averageStoreyHeightIdComboBox);
            this.groupBox5.Controls.Add(numberOfStoreyIdLabel);
            this.groupBox5.Controls.Add(this.numberOfStoreyIdComboBox);
            this.groupBox5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(671, 320);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(261, 225);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "4. Storey and Height";
            // 
            // averageStoreyHeightIdComboBox
            // 
            this.averageStoreyHeightIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.designAlternativeBindingSource, "AverageStoreyHeightId", true));
            this.averageStoreyHeightIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.designAlternativeBindingSource, "AverageStoreyHeightId", true));
            this.averageStoreyHeightIdComboBox.DataSource = this.averageStoreyHeightBindingSource;
            this.averageStoreyHeightIdComboBox.DisplayMember = "Name";
            this.averageStoreyHeightIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.averageStoreyHeightIdComboBox.FormattingEnabled = true;
            this.averageStoreyHeightIdComboBox.Location = new System.Drawing.Point(17, 114);
            this.averageStoreyHeightIdComboBox.Name = "averageStoreyHeightIdComboBox";
            this.averageStoreyHeightIdComboBox.Size = new System.Drawing.Size(228, 24);
            this.averageStoreyHeightIdComboBox.TabIndex = 3;
            this.toolTip1.SetToolTip(this.averageStoreyHeightIdComboBox, "The different range of the storeys heights that give the average building height");
            this.averageStoreyHeightIdComboBox.ValueMember = "Id";
            // 
            // averageStoreyHeightBindingSource
            // 
            this.averageStoreyHeightBindingSource.DataSource = typeof(DesignAlternatives.WinApp.Models.DesignOption);
            // 
            // numberOfStoreyIdComboBox
            // 
            this.numberOfStoreyIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.designAlternativeBindingSource, "NumberOfStoreyId", true));
            this.numberOfStoreyIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.designAlternativeBindingSource, "NumberOfStoreyId", true));
            this.numberOfStoreyIdComboBox.DataSource = this.numberOfStoreyBindingSource;
            this.numberOfStoreyIdComboBox.DisplayMember = "Name";
            this.numberOfStoreyIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numberOfStoreyIdComboBox.FormattingEnabled = true;
            this.numberOfStoreyIdComboBox.Location = new System.Drawing.Point(17, 52);
            this.numberOfStoreyIdComboBox.Name = "numberOfStoreyIdComboBox";
            this.numberOfStoreyIdComboBox.Size = new System.Drawing.Size(228, 24);
            this.numberOfStoreyIdComboBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.numberOfStoreyIdComboBox, "The number of storeys that building contains to the same floors area");
            this.numberOfStoreyIdComboBox.ValueMember = "Id";
            // 
            // numberOfStoreyBindingSource
            // 
            this.numberOfStoreyBindingSource.DataSource = typeof(DesignAlternatives.WinApp.Models.DesignOption);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(spanDimensionIdLabel);
            this.groupBox6.Controls.Add(this.spanDimensionIdComboBox);
            this.groupBox6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(937, 324);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(261, 109);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "6. Floor Spans";
            // 
            // spanDimensionIdComboBox
            // 
            this.spanDimensionIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.designAlternativeBindingSource, "SpanDimensionId", true));
            this.spanDimensionIdComboBox.DataSource = this.spanDimensionBindingSource;
            this.spanDimensionIdComboBox.DisplayMember = "Name";
            this.spanDimensionIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.spanDimensionIdComboBox.FormattingEnabled = true;
            this.spanDimensionIdComboBox.Location = new System.Drawing.Point(17, 57);
            this.spanDimensionIdComboBox.Name = "spanDimensionIdComboBox";
            this.spanDimensionIdComboBox.Size = new System.Drawing.Size(228, 24);
            this.spanDimensionIdComboBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.spanDimensionIdComboBox, "The longest distance of usable area between exterior wall and fixed interior elem" +
        "ent");
            this.spanDimensionIdComboBox.ValueMember = "Id";
            // 
            // spanDimensionBindingSource
            // 
            this.spanDimensionBindingSource.DataSource = typeof(DesignAlternatives.WinApp.Models.DesignOption);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(circulationAreaIdLabel);
            this.groupBox7.Controls.Add(this.circulationAreaIdComboBox);
            this.groupBox7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(937, 440);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(261, 105);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "7. Circulation Space";
            // 
            // circulationAreaIdComboBox
            // 
            this.circulationAreaIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.designAlternativeBindingSource, "CirculationAreaId", true));
            this.circulationAreaIdComboBox.DataSource = this.circulationAreaBindingSource;
            this.circulationAreaIdComboBox.DisplayMember = "Name";
            this.circulationAreaIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.circulationAreaIdComboBox.FormattingEnabled = true;
            this.circulationAreaIdComboBox.Location = new System.Drawing.Point(17, 65);
            this.circulationAreaIdComboBox.Name = "circulationAreaIdComboBox";
            this.circulationAreaIdComboBox.Size = new System.Drawing.Size(228, 24);
            this.circulationAreaIdComboBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.circulationAreaIdComboBox, "The ratio of building circulation space area to the building Gross Floors Area (G" +
        "FA)");
            this.circulationAreaIdComboBox.ValueMember = "Id";
            // 
            // circulationAreaBindingSource
            // 
            this.circulationAreaBindingSource.DataSource = typeof(DesignAlternatives.WinApp.Models.DesignOption);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.ForeColor = System.Drawing.Color.Blue;
            this.btnSave.Image = global::DesignAlternatives.WinApp.Properties.Resources.floppy_64;
            this.btnSave.Location = new System.Drawing.Point(693, 568);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 91);
            this.btnSave.TabIndex = 12;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.btnSave, "Save design alternative data");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Description";
            // 
            // btnResetDefaults
            // 
            this.btnResetDefaults.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnResetDefaults.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetDefaults.Image = global::DesignAlternatives.WinApp.Properties.Resources.refresh64_2;
            this.btnResetDefaults.Location = new System.Drawing.Point(14, 568);
            this.btnResetDefaults.Name = "btnResetDefaults";
            this.btnResetDefaults.Size = new System.Drawing.Size(108, 91);
            this.btnResetDefaults.TabIndex = 25;
            this.toolTip1.SetToolTip(this.btnResetDefaults, "Reset to default designs");
            this.btnResetDefaults.UseVisualStyleBackColor = true;
            this.btnResetDefaults.Click += new System.EventHandler(this.btnResetDefaults_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1219, 706);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.label46);
            this.tabPage4.Controls.Add(this.label45);
            this.tabPage4.Controls.Add(this.label44);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1211, 677);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Main Page";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Image = global::DesignAlternatives.WinApp.Properties.Resources.start_64;
            this.button1.Location = new System.Drawing.Point(509, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 84);
            this.button1.TabIndex = 25;
            this.button1.Text = "Start";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label46.Location = new System.Drawing.Point(479, 170);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(253, 29);
            this.label46.TabIndex = 24;
            this.label46.Text = "Mr. Abdullah Al Saggaf";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label45.Location = new System.Drawing.Point(586, 122);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(39, 29);
            this.label45.TabIndex = 24;
            this.label45.Text = "By";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label44.Location = new System.Drawing.Point(404, 45);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(402, 39);
            this.label44.TabIndex = 24;
            this.label44.Text = "Design Alternatives System";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCalc);
            this.tabPage1.Controls.Add(this.btnResetDefaults);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.nudAlternativesNumber);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.designAlternativeDataGridView);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox7);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btnSettings);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1211, 677);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "  Design Alternatives  ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCalc
            // 
            this.btnCalc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalc.Image = global::DesignAlternatives.WinApp.Properties.Resources.calc_63;
            this.btnCalc.Location = new System.Drawing.Point(404, 568);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(108, 91);
            this.btnCalc.TabIndex = 26;
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(633, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(340, 33);
            this.label9.TabIndex = 24;
            this.label9.Text = "Design Alternatives Options";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.button7);
            this.tabPage6.Controls.Add(this.groupBox14);
            this.tabPage6.Controls.Add(this.groupBox13);
            this.tabPage6.Controls.Add(this.groupBox12);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1211, 677);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "  Best Criteria/Sub-Criteria  ";
            this.tabPage6.UseVisualStyleBackColor = true;
            this.tabPage6.Click += new System.EventHandler(this.tabPage6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(125, 407);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(189, 46);
            this.button7.TabIndex = 1;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // groupBox14
            // 
            this.groupBox14.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox14.Location = new System.Drawing.Point(742, 38);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(377, 235);
            this.groupBox14.TabIndex = 1;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Best Design ( Sub Criteria )";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.label59);
            this.groupBox13.Controls.Add(this.lblBestCriteriaPercentage);
            this.groupBox13.Controls.Add(this.lblBestCriteria);
            this.groupBox13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox13.Location = new System.Drawing.Point(345, 38);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(391, 235);
            this.groupBox13.TabIndex = 1;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Best Design ( Criteria )";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label59.Location = new System.Drawing.Point(134, 129);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(122, 17);
            this.label59.TabIndex = 2;
            this.label59.Text = "Relative Index (%)";
            this.label59.Click += new System.EventHandler(this.label59_Click);
            // 
            // lblBestCriteriaPercentage
            // 
            this.lblBestCriteriaPercentage.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestCriteriaPercentage.ForeColor = System.Drawing.Color.Green;
            this.lblBestCriteriaPercentage.Location = new System.Drawing.Point(96, 153);
            this.lblBestCriteriaPercentage.Name = "lblBestCriteriaPercentage";
            this.lblBestCriteriaPercentage.Size = new System.Drawing.Size(198, 55);
            this.lblBestCriteriaPercentage.TabIndex = 1;
            this.lblBestCriteriaPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBestCriteriaPercentage.Click += new System.EventHandler(this.label57_Click);
            // 
            // lblBestCriteria
            // 
            this.lblBestCriteria.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestCriteria.ForeColor = System.Drawing.Color.Blue;
            this.lblBestCriteria.Location = new System.Drawing.Point(96, 30);
            this.lblBestCriteria.Name = "lblBestCriteria";
            this.lblBestCriteria.Size = new System.Drawing.Size(198, 81);
            this.lblBestCriteria.TabIndex = 1;
            this.lblBestCriteria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBestCriteria.Click += new System.EventHandler(this.label57_Click);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.rdAethiticas);
            this.groupBox12.Controls.Add(this.rdOperationPerformance);
            this.groupBox12.Controls.Add(this.rdConstructionPerformance);
            this.groupBox12.Controls.Add(this.rdSpaceFunctionality);
            this.groupBox12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox12.Location = new System.Drawing.Point(12, 38);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(327, 235);
            this.groupBox12.TabIndex = 0;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Criteria";
            // 
            // rdAethiticas
            // 
            this.rdAethiticas.AutoSize = true;
            this.rdAethiticas.Location = new System.Drawing.Point(42, 172);
            this.rdAethiticas.Name = "rdAethiticas";
            this.rdAethiticas.Size = new System.Drawing.Size(95, 23);
            this.rdAethiticas.TabIndex = 0;
            this.rdAethiticas.Text = "Aethiticas";
            this.rdAethiticas.UseVisualStyleBackColor = true;
            this.rdAethiticas.CheckedChanged += new System.EventHandler(this.rdSpaceFunctionality_CheckedChanged);
            // 
            // rdOperationPerformance
            // 
            this.rdOperationPerformance.AutoSize = true;
            this.rdOperationPerformance.Location = new System.Drawing.Point(42, 130);
            this.rdOperationPerformance.Name = "rdOperationPerformance";
            this.rdOperationPerformance.Size = new System.Drawing.Size(191, 23);
            this.rdOperationPerformance.TabIndex = 0;
            this.rdOperationPerformance.Text = "Operation Performance";
            this.rdOperationPerformance.UseVisualStyleBackColor = true;
            this.rdOperationPerformance.CheckedChanged += new System.EventHandler(this.rdSpaceFunctionality_CheckedChanged);
            // 
            // rdConstructionPerformance
            // 
            this.rdConstructionPerformance.AutoSize = true;
            this.rdConstructionPerformance.Location = new System.Drawing.Point(42, 88);
            this.rdConstructionPerformance.Name = "rdConstructionPerformance";
            this.rdConstructionPerformance.Size = new System.Drawing.Size(210, 23);
            this.rdConstructionPerformance.TabIndex = 0;
            this.rdConstructionPerformance.Text = "Construction Performance";
            this.rdConstructionPerformance.UseVisualStyleBackColor = true;
            this.rdConstructionPerformance.CheckedChanged += new System.EventHandler(this.rdSpaceFunctionality_CheckedChanged);
            // 
            // rdSpaceFunctionality
            // 
            this.rdSpaceFunctionality.AutoSize = true;
            this.rdSpaceFunctionality.Location = new System.Drawing.Point(42, 46);
            this.rdSpaceFunctionality.Name = "rdSpaceFunctionality";
            this.rdSpaceFunctionality.Size = new System.Drawing.Size(162, 23);
            this.rdSpaceFunctionality.TabIndex = 0;
            this.rdSpaceFunctionality.Text = "Space Functionality";
            this.rdSpaceFunctionality.UseVisualStyleBackColor = true;
            this.rdSpaceFunctionality.CheckedChanged += new System.EventHandler(this.rdSpaceFunctionality_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox11);
            this.tabPage2.Controls.Add(this.groupBox10);
            this.tabPage2.Controls.Add(this.groupBox9);
            this.tabPage2.Controls.Add(this.groupBox8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1211, 677);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "  Results  ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label47);
            this.groupBox11.Controls.Add(this.label48);
            this.groupBox11.Controls.Add(this.label49);
            this.groupBox11.Controls.Add(this.label50);
            this.groupBox11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox11.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox11.Location = new System.Drawing.Point(915, 102);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(286, 251);
            this.groupBox11.TabIndex = 24;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Aesthetics";
            // 
            // label47
            // 
            this.label47.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label47.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.designAlternativeResultBindingSource, "BestAestheticsDesignName", true));
            this.label47.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.ForeColor = System.Drawing.Color.Maroon;
            this.label47.Location = new System.Drawing.Point(19, 64);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(119, 33);
            this.label47.TabIndex = 0;
            this.label47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label48.Location = new System.Drawing.Point(37, 37);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(79, 17);
            this.label48.TabIndex = 1;
            this.label48.Text = "Best Design";
            // 
            // label49
            // 
            this.label49.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label49.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.designAlternativeResultBindingSource, "BestAestheticsDesignPercentageText", true));
            this.label49.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.ForeColor = System.Drawing.Color.Maroon;
            this.label49.Location = new System.Drawing.Point(144, 64);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(124, 33);
            this.label49.TabIndex = 0;
            this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label50.Location = new System.Drawing.Point(168, 37);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(77, 17);
            this.label50.TabIndex = 1;
            this.label50.Text = "Percentage";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label17);
            this.groupBox10.Controls.Add(this.label20);
            this.groupBox10.Controls.Add(this.label21);
            this.groupBox10.Controls.Add(this.label24);
            this.groupBox10.Controls.Add(this.label42);
            this.groupBox10.Controls.Add(this.label41);
            this.groupBox10.Controls.Add(this.label31);
            this.groupBox10.Controls.Add(this.label39);
            this.groupBox10.Controls.Add(this.label32);
            this.groupBox10.Controls.Add(this.label38);
            this.groupBox10.Controls.Add(this.label34);
            this.groupBox10.Controls.Add(this.label36);
            this.groupBox10.Controls.Add(this.label37);
            this.groupBox10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox10.Location = new System.Drawing.Point(613, 102);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(286, 251);
            this.groupBox10.TabIndex = 24;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Operation Performance";
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.designAlternativeResultBindingSource, "BestOperationPerformanceDesignName", true));
            this.label17.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Maroon;
            this.label17.Location = new System.Drawing.Point(19, 64);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(119, 33);
            this.label17.TabIndex = 0;
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label20.Location = new System.Drawing.Point(37, 37);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 17);
            this.label20.TabIndex = 1;
            this.label20.Text = "Best Design";
            // 
            // label21
            // 
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label21.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.designAlternativeResultBindingSource, "BestOperationPerformanceDesignPercentageText", true));
            this.label21.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Maroon;
            this.label21.Location = new System.Drawing.Point(144, 64);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(124, 33);
            this.label21.TabIndex = 0;
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label24.Location = new System.Drawing.Point(168, 37);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(77, 17);
            this.label24.TabIndex = 1;
            this.label24.Text = "Percentage";
            // 
            // label42
            // 
            this.label42.BackColor = System.Drawing.Color.Transparent;
            this.label42.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label42.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.Color.DarkBlue;
            this.label42.Location = new System.Drawing.Point(10, 187);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(77, 23);
            this.label42.TabIndex = 1;
            this.label42.Text = "Maintenance";
            this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label42.Click += new System.EventHandler(this.label40_Click);
            // 
            // label41
            // 
            this.label41.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label41.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.designAlternativeResultBindingSource, "BestEnergyDesignPercentageText", true));
            this.label41.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.Color.Maroon;
            this.label41.Location = new System.Drawing.Point(189, 160);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(88, 23);
            this.label41.TabIndex = 0;
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label41.Click += new System.EventHandler(this.label35_Click);
            // 
            // label31
            // 
            this.label31.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label31.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.designAlternativeResultBindingSource, "BestMaintenanceDesignPercentageText", true));
            this.label31.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.Maroon;
            this.label31.Location = new System.Drawing.Point(189, 187);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(88, 23);
            this.label31.TabIndex = 0;
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label39
            // 
            this.label39.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label39.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label39.Location = new System.Drawing.Point(189, 132);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(88, 23);
            this.label39.TabIndex = 1;
            this.label39.Text = "Relative Index";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label32
            // 
            this.label32.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label32.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label32.Location = new System.Drawing.Point(93, 132);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(88, 23);
            this.label32.TabIndex = 1;
            this.label32.Text = "Best Design";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label38
            // 
            this.label38.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label38.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.designAlternativeResultBindingSource, "BestEnergyDesignName", true));
            this.label38.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.Color.Maroon;
            this.label38.Location = new System.Drawing.Point(93, 160);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(88, 23);
            this.label38.TabIndex = 0;
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label34
            // 
            this.label34.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label34.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.designAlternativeResultBindingSource, "BestMaintenanceDesignName", true));
            this.label34.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.Maroon;
            this.label34.Location = new System.Drawing.Point(93, 187);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(88, 23);
            this.label34.TabIndex = 0;
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label36
            // 
            this.label36.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label36.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label36.Location = new System.Drawing.Point(10, 132);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(77, 23);
            this.label36.TabIndex = 1;
            this.label36.Text = "Sub Criteria";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label37
            // 
            this.label37.BackColor = System.Drawing.Color.Transparent;
            this.label37.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label37.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.Color.DarkBlue;
            this.label37.Location = new System.Drawing.Point(10, 160);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(77, 23);
            this.label37.TabIndex = 1;
            this.label37.Text = "Energy";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label13);
            this.groupBox9.Controls.Add(this.label14);
            this.groupBox9.Controls.Add(this.label15);
            this.groupBox9.Controls.Add(this.label16);
            this.groupBox9.Controls.Add(this.label30);
            this.groupBox9.Controls.Add(this.label18);
            this.groupBox9.Controls.Add(this.label29);
            this.groupBox9.Controls.Add(this.label19);
            this.groupBox9.Controls.Add(this.label22);
            this.groupBox9.Controls.Add(this.label28);
            this.groupBox9.Controls.Add(this.label25);
            this.groupBox9.Controls.Add(this.label33);
            this.groupBox9.Controls.Add(this.label26);
            this.groupBox9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox9.Location = new System.Drawing.Point(311, 102);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(286, 251);
            this.groupBox9.TabIndex = 24;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Construction Performance";
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.designAlternativeResultBindingSource, "BestConstructionPerformanceDesignName", true));
            this.label13.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Maroon;
            this.label13.Location = new System.Drawing.Point(19, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 33);
            this.label13.TabIndex = 0;
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(37, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 17);
            this.label14.TabIndex = 1;
            this.label14.Text = "Best Design";
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.designAlternativeResultBindingSource, "BestConstructionPerformanceDesignPercentageText", true));
            this.label15.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Maroon;
            this.label15.Location = new System.Drawing.Point(144, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(124, 33);
            this.label15.TabIndex = 0;
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Location = new System.Drawing.Point(168, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 17);
            this.label16.TabIndex = 1;
            this.label16.Text = "Percentage";
            // 
            // label30
            // 
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label30.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.DarkBlue;
            this.label30.Location = new System.Drawing.Point(10, 187);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(77, 23);
            this.label30.TabIndex = 1;
            this.label30.Text = "Time";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label30.Click += new System.EventHandler(this.label40_Click);
            // 
            // label18
            // 
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label18.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.designAlternativeResultBindingSource, "BestCosteDesignPercentageText", true));
            this.label18.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Maroon;
            this.label18.Location = new System.Drawing.Point(189, 160);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 23);
            this.label18.TabIndex = 0;
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label18.Click += new System.EventHandler(this.label35_Click);
            // 
            // label29
            // 
            this.label29.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label29.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label29.Location = new System.Drawing.Point(189, 132);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(88, 23);
            this.label29.TabIndex = 1;
            this.label29.Text = "Relative Index";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label19.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.designAlternativeResultBindingSource, "BestCosteDesignName", true));
            this.label19.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Maroon;
            this.label19.Location = new System.Drawing.Point(93, 160);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 23);
            this.label19.TabIndex = 0;
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label22.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.DarkBlue;
            this.label22.Location = new System.Drawing.Point(10, 160);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(77, 23);
            this.label22.TabIndex = 1;
            this.label22.Text = "Cost";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            this.label28.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label28.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.designAlternativeResultBindingSource, "BestTimeDesignName", true));
            this.label28.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.Maroon;
            this.label28.Location = new System.Drawing.Point(93, 187);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(88, 23);
            this.label28.TabIndex = 0;
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label25.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label25.Location = new System.Drawing.Point(93, 132);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(88, 23);
            this.label25.TabIndex = 1;
            this.label25.Text = "Best Design";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label33
            // 
            this.label33.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label33.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label33.Location = new System.Drawing.Point(10, 132);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(77, 23);
            this.label33.TabIndex = 1;
            this.label33.Text = "Sub Criteria";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            this.label26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label26.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.designAlternativeResultBindingSource, "BestTimeDesignPercentageText", true));
            this.label26.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Maroon;
            this.label26.Location = new System.Drawing.Point(189, 187);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(88, 23);
            this.label26.TabIndex = 0;
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label8);
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Controls.Add(this.label12);
            this.groupBox8.Controls.Add(this.label11);
            this.groupBox8.Controls.Add(this.label52);
            this.groupBox8.Controls.Add(this.label40);
            this.groupBox8.Controls.Add(this.label61);
            this.groupBox8.Controls.Add(this.label55);
            this.groupBox8.Controls.Add(this.label56);
            this.groupBox8.Controls.Add(this.label54);
            this.groupBox8.Controls.Add(this.label53);
            this.groupBox8.Controls.Add(this.label23);
            this.groupBox8.Controls.Add(this.label51);
            this.groupBox8.Controls.Add(this.label43);
            this.groupBox8.Controls.Add(this.label27);
            this.groupBox8.Controls.Add(this.label35);
            this.groupBox8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox8.Location = new System.Drawing.Point(9, 102);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(286, 251);
            this.groupBox8.TabIndex = 24;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Space Functionality";
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.designAlternativeResultBindingSource, "BestSpaceFunctionalityDesignName", true));
            this.label8.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(19, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 33);
            this.label8.TabIndex = 0;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(37, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Best Design";
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.designAlternativeResultBindingSource, "BestSpaceFunctionalityDesignPercentageText", true));
            this.label12.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Maroon;
            this.label12.Location = new System.Drawing.Point(144, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 33);
            this.label12.TabIndex = 0;
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(168, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Percentage";
            // 
            // label52
            // 
            this.label52.BackColor = System.Drawing.Color.Transparent;
            this.label52.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label52.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.ForeColor = System.Drawing.Color.DarkBlue;
            this.label52.Location = new System.Drawing.Point(10, 213);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(77, 23);
            this.label52.TabIndex = 1;
            this.label52.Text = "Size";
            this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label52.Click += new System.EventHandler(this.label40_Click);
            // 
            // label40
            // 
            this.label40.BackColor = System.Drawing.Color.Transparent;
            this.label40.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label40.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.Color.DarkBlue;
            this.label40.Location = new System.Drawing.Point(10, 187);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(77, 23);
            this.label40.TabIndex = 1;
            this.label40.Text = "Relation";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label40.Click += new System.EventHandler(this.label40_Click);
            // 
            // label61
            // 
            this.label61.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label61.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label61.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label61.Location = new System.Drawing.Point(189, 132);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(88, 23);
            this.label61.TabIndex = 1;
            this.label61.Text = "Relative Index";
            this.label61.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label55
            // 
            this.label55.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label55.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.designAlternativeResultBindingSource, "BestSizeDesignPercentageText", true));
            this.label55.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.ForeColor = System.Drawing.Color.Maroon;
            this.label55.Location = new System.Drawing.Point(189, 213);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(88, 23);
            this.label55.TabIndex = 0;
            this.label55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label56
            // 
            this.label56.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label56.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.designAlternativeResultBindingSource, "BestSizeDesignName", true));
            this.label56.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.ForeColor = System.Drawing.Color.Maroon;
            this.label56.Location = new System.Drawing.Point(93, 213);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(88, 23);
            this.label56.TabIndex = 0;
            this.label56.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label54
            // 
            this.label54.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label54.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.designAlternativeResultBindingSource, "BestRelationDesignName", true));
            this.label54.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.ForeColor = System.Drawing.Color.Maroon;
            this.label54.Location = new System.Drawing.Point(93, 187);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(88, 23);
            this.label54.TabIndex = 0;
            this.label54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label53
            // 
            this.label53.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label53.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.designAlternativeResultBindingSource, "BestRelationDesignPercentageText", true));
            this.label53.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.ForeColor = System.Drawing.Color.Maroon;
            this.label53.Location = new System.Drawing.Point(189, 187);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(88, 23);
            this.label53.TabIndex = 0;
            this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label23.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label23.Location = new System.Drawing.Point(10, 132);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(77, 23);
            this.label23.TabIndex = 1;
            this.label23.Text = "Sub Criteria";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label51
            // 
            this.label51.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label51.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label51.Location = new System.Drawing.Point(93, 132);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(88, 23);
            this.label51.TabIndex = 1;
            this.label51.Text = "Best Design";
            this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label43
            // 
            this.label43.BackColor = System.Drawing.Color.Transparent;
            this.label43.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label43.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.Color.DarkBlue;
            this.label43.Location = new System.Drawing.Point(10, 160);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(77, 23);
            this.label43.TabIndex = 1;
            this.label43.Text = "Accessibility";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label27.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.designAlternativeResultBindingSource, "BestAccessibilityDesignName", true));
            this.label27.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Maroon;
            this.label27.Location = new System.Drawing.Point(93, 160);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(88, 23);
            this.label27.TabIndex = 0;
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label35
            // 
            this.label35.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label35.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.designAlternativeResultBindingSource, "BestAccessibilityDesignPercentageText", true));
            this.label35.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.Maroon;
            this.label35.Location = new System.Drawing.Point(189, 160);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(88, 23);
            this.label35.TabIndex = 0;
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label35.Click += new System.EventHandler(this.label35_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(361, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(488, 27);
            this.label7.TabIndex = 23;
            this.label7.Text = "Best Design for Each Quality Criteria/Sub-Criteria";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.designAlternativeDataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1211, 677);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // designAlternativeDataGridView1
            // 
            this.designAlternativeDataGridView1.AllowUserToAddRows = false;
            this.designAlternativeDataGridView1.AllowUserToDeleteRows = false;
            this.designAlternativeDataGridView1.AutoGenerateColumns = false;
            this.designAlternativeDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.designAlternativeDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn33,
            this.dataGridViewTextBoxColumn34,
            this.dataGridViewTextBoxColumn35,
            this.dataGridViewTextBoxColumn36,
            this.dataGridViewTextBoxColumn37,
            this.dataGridViewTextBoxColumn38,
            this.dataGridViewTextBoxColumn39,
            this.dataGridViewTextBoxColumn40,
            this.dataGridViewTextBoxColumn41,
            this.dataGridViewTextBoxColumn42,
            this.dataGridViewTextBoxColumn43,
            this.dataGridViewTextBoxColumn44,
            this.dataGridViewTextBoxColumn45,
            this.dataGridViewTextBoxColumn46,
            this.dataGridViewTextBoxColumn47,
            this.dataGridViewTextBoxColumn48,
            this.dataGridViewTextBoxColumn49,
            this.dataGridViewTextBoxColumn50,
            this.dataGridViewTextBoxColumn51,
            this.dataGridViewTextBoxColumn52,
            this.dataGridViewTextBoxColumn53,
            this.dataGridViewTextBoxColumn54,
            this.dataGridViewTextBoxColumn55,
            this.dataGridViewTextBoxColumn56,
            this.dataGridViewTextBoxColumn57,
            this.dataGridViewTextBoxColumn58,
            this.dataGridViewTextBoxColumn59,
            this.dataGridViewTextBoxColumn60,
            this.dataGridViewTextBoxColumn61,
            this.dataGridViewTextBoxColumn62,
            this.dataGridViewTextBoxColumn63,
            this.dataGridViewTextBoxColumn64,
            this.dataGridViewTextBoxColumn65,
            this.dataGridViewTextBoxColumn66});
            this.designAlternativeDataGridView1.DataSource = this.designAlternativeBindingSource;
            this.designAlternativeDataGridView1.Location = new System.Drawing.Point(6, 15);
            this.designAlternativeDataGridView1.Name = "designAlternativeDataGridView1";
            this.designAlternativeDataGridView1.ReadOnly = true;
            this.designAlternativeDataGridView1.Size = new System.Drawing.Size(1185, 532);
            this.designAlternativeDataGridView1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn4.HeaderText = "Description";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "AccessibilityTotal";
            this.dataGridViewTextBoxColumn33.HeaderText = "AccessibilityTotal";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "AccessibilityResult";
            this.dataGridViewTextBoxColumn34.HeaderText = "AccessibilityResult";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "AccessibilityPercentage";
            this.dataGridViewTextBoxColumn35.HeaderText = "AccessibilityPercentage";
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            this.dataGridViewTextBoxColumn35.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.DataPropertyName = "RelationTotal";
            this.dataGridViewTextBoxColumn36.HeaderText = "RelationTotal";
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            this.dataGridViewTextBoxColumn36.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.DataPropertyName = "RelationResult";
            this.dataGridViewTextBoxColumn37.HeaderText = "RelationResult";
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            this.dataGridViewTextBoxColumn37.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.DataPropertyName = "RelationPercentage";
            this.dataGridViewTextBoxColumn38.HeaderText = "RelationPercentage";
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            this.dataGridViewTextBoxColumn38.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn39
            // 
            this.dataGridViewTextBoxColumn39.DataPropertyName = "SizeTotal";
            this.dataGridViewTextBoxColumn39.HeaderText = "SizeTotal";
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            this.dataGridViewTextBoxColumn39.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn40
            // 
            this.dataGridViewTextBoxColumn40.DataPropertyName = "SizeResult";
            this.dataGridViewTextBoxColumn40.HeaderText = "SizeResult";
            this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
            this.dataGridViewTextBoxColumn40.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn41
            // 
            this.dataGridViewTextBoxColumn41.DataPropertyName = "SizePercentage";
            this.dataGridViewTextBoxColumn41.HeaderText = "SizePercentage";
            this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
            this.dataGridViewTextBoxColumn41.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn42
            // 
            this.dataGridViewTextBoxColumn42.DataPropertyName = "CostTotal";
            this.dataGridViewTextBoxColumn42.HeaderText = "CostTotal";
            this.dataGridViewTextBoxColumn42.Name = "dataGridViewTextBoxColumn42";
            this.dataGridViewTextBoxColumn42.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn43
            // 
            this.dataGridViewTextBoxColumn43.DataPropertyName = "CostResult";
            this.dataGridViewTextBoxColumn43.HeaderText = "CostResult";
            this.dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43";
            this.dataGridViewTextBoxColumn43.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn44
            // 
            this.dataGridViewTextBoxColumn44.DataPropertyName = "CostPercentage";
            this.dataGridViewTextBoxColumn44.HeaderText = "CostPercentage";
            this.dataGridViewTextBoxColumn44.Name = "dataGridViewTextBoxColumn44";
            this.dataGridViewTextBoxColumn44.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn45
            // 
            this.dataGridViewTextBoxColumn45.DataPropertyName = "TimeTotal";
            this.dataGridViewTextBoxColumn45.HeaderText = "TimeTotal";
            this.dataGridViewTextBoxColumn45.Name = "dataGridViewTextBoxColumn45";
            this.dataGridViewTextBoxColumn45.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn46
            // 
            this.dataGridViewTextBoxColumn46.DataPropertyName = "TimeResult";
            this.dataGridViewTextBoxColumn46.HeaderText = "TimeResult";
            this.dataGridViewTextBoxColumn46.Name = "dataGridViewTextBoxColumn46";
            this.dataGridViewTextBoxColumn46.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn47
            // 
            this.dataGridViewTextBoxColumn47.DataPropertyName = "TimePercentage";
            this.dataGridViewTextBoxColumn47.HeaderText = "TimePercentage";
            this.dataGridViewTextBoxColumn47.Name = "dataGridViewTextBoxColumn47";
            this.dataGridViewTextBoxColumn47.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn48
            // 
            this.dataGridViewTextBoxColumn48.DataPropertyName = "EnergyTotal";
            this.dataGridViewTextBoxColumn48.HeaderText = "EnergyTotal";
            this.dataGridViewTextBoxColumn48.Name = "dataGridViewTextBoxColumn48";
            this.dataGridViewTextBoxColumn48.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn49
            // 
            this.dataGridViewTextBoxColumn49.DataPropertyName = "EnergyResult";
            this.dataGridViewTextBoxColumn49.HeaderText = "EnergyResult";
            this.dataGridViewTextBoxColumn49.Name = "dataGridViewTextBoxColumn49";
            this.dataGridViewTextBoxColumn49.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn50
            // 
            this.dataGridViewTextBoxColumn50.DataPropertyName = "EnergyPercentage";
            this.dataGridViewTextBoxColumn50.HeaderText = "EnergyPercentage";
            this.dataGridViewTextBoxColumn50.Name = "dataGridViewTextBoxColumn50";
            this.dataGridViewTextBoxColumn50.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn51
            // 
            this.dataGridViewTextBoxColumn51.DataPropertyName = "MaintenanceTotal";
            this.dataGridViewTextBoxColumn51.HeaderText = "MaintenanceTotal";
            this.dataGridViewTextBoxColumn51.Name = "dataGridViewTextBoxColumn51";
            this.dataGridViewTextBoxColumn51.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn52
            // 
            this.dataGridViewTextBoxColumn52.DataPropertyName = "MaintenanceResult";
            this.dataGridViewTextBoxColumn52.HeaderText = "MaintenanceResult";
            this.dataGridViewTextBoxColumn52.Name = "dataGridViewTextBoxColumn52";
            this.dataGridViewTextBoxColumn52.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn53
            // 
            this.dataGridViewTextBoxColumn53.DataPropertyName = "MaintenancePercentage";
            this.dataGridViewTextBoxColumn53.HeaderText = "MaintenancePercentage";
            this.dataGridViewTextBoxColumn53.Name = "dataGridViewTextBoxColumn53";
            this.dataGridViewTextBoxColumn53.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn54
            // 
            this.dataGridViewTextBoxColumn54.DataPropertyName = "AestheticsTotal";
            this.dataGridViewTextBoxColumn54.HeaderText = "AestheticsTotal";
            this.dataGridViewTextBoxColumn54.Name = "dataGridViewTextBoxColumn54";
            this.dataGridViewTextBoxColumn54.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn55
            // 
            this.dataGridViewTextBoxColumn55.DataPropertyName = "AestheticsResult";
            this.dataGridViewTextBoxColumn55.HeaderText = "AestheticsResult";
            this.dataGridViewTextBoxColumn55.Name = "dataGridViewTextBoxColumn55";
            this.dataGridViewTextBoxColumn55.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn56
            // 
            this.dataGridViewTextBoxColumn56.DataPropertyName = "AestheticsPercentage";
            this.dataGridViewTextBoxColumn56.HeaderText = "AestheticsPercentage";
            this.dataGridViewTextBoxColumn56.Name = "dataGridViewTextBoxColumn56";
            this.dataGridViewTextBoxColumn56.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn57
            // 
            this.dataGridViewTextBoxColumn57.DataPropertyName = "Score";
            this.dataGridViewTextBoxColumn57.HeaderText = "Score";
            this.dataGridViewTextBoxColumn57.Name = "dataGridViewTextBoxColumn57";
            this.dataGridViewTextBoxColumn57.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn58
            // 
            this.dataGridViewTextBoxColumn58.DataPropertyName = "Percentage";
            this.dataGridViewTextBoxColumn58.HeaderText = "Percentage";
            this.dataGridViewTextBoxColumn58.Name = "dataGridViewTextBoxColumn58";
            this.dataGridViewTextBoxColumn58.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn59
            // 
            this.dataGridViewTextBoxColumn59.DataPropertyName = "PercentageText";
            this.dataGridViewTextBoxColumn59.HeaderText = "PercentageText";
            this.dataGridViewTextBoxColumn59.Name = "dataGridViewTextBoxColumn59";
            this.dataGridViewTextBoxColumn59.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn60
            // 
            this.dataGridViewTextBoxColumn60.DataPropertyName = "Rank";
            this.dataGridViewTextBoxColumn60.HeaderText = "Rank";
            this.dataGridViewTextBoxColumn60.Name = "dataGridViewTextBoxColumn60";
            this.dataGridViewTextBoxColumn60.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn61
            // 
            this.dataGridViewTextBoxColumn61.DataPropertyName = "SpaceFunctionalityTotal";
            this.dataGridViewTextBoxColumn61.HeaderText = "SpaceFunctionalityTotal";
            this.dataGridViewTextBoxColumn61.Name = "dataGridViewTextBoxColumn61";
            this.dataGridViewTextBoxColumn61.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn62
            // 
            this.dataGridViewTextBoxColumn62.DataPropertyName = "SpaceFunctionalityPercentage";
            this.dataGridViewTextBoxColumn62.HeaderText = "SpaceFunctionalityPercentage";
            this.dataGridViewTextBoxColumn62.Name = "dataGridViewTextBoxColumn62";
            this.dataGridViewTextBoxColumn62.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn63
            // 
            this.dataGridViewTextBoxColumn63.DataPropertyName = "ConstructionPerformanceTotal";
            this.dataGridViewTextBoxColumn63.HeaderText = "ConstructionPerformanceTotal";
            this.dataGridViewTextBoxColumn63.Name = "dataGridViewTextBoxColumn63";
            this.dataGridViewTextBoxColumn63.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn64
            // 
            this.dataGridViewTextBoxColumn64.DataPropertyName = "ConstructionPerformancePercentage";
            this.dataGridViewTextBoxColumn64.HeaderText = "ConstructionPerformancePercentage";
            this.dataGridViewTextBoxColumn64.Name = "dataGridViewTextBoxColumn64";
            this.dataGridViewTextBoxColumn64.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn65
            // 
            this.dataGridViewTextBoxColumn65.DataPropertyName = "OperationPerformanceTotal";
            this.dataGridViewTextBoxColumn65.HeaderText = "OperationPerformanceTotal";
            this.dataGridViewTextBoxColumn65.Name = "dataGridViewTextBoxColumn65";
            this.dataGridViewTextBoxColumn65.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn66
            // 
            this.dataGridViewTextBoxColumn66.DataPropertyName = "OperationPerformancePercentage";
            this.dataGridViewTextBoxColumn66.HeaderText = "OperationPerformancePercentage";
            this.dataGridViewTextBoxColumn66.Name = "dataGridViewTextBoxColumn66";
            this.dataGridViewTextBoxColumn66.ReadOnly = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.designAlternativeDataGridView2);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1211, 677);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // designAlternativeDataGridView2
            // 
            this.designAlternativeDataGridView2.AllowUserToAddRows = false;
            this.designAlternativeDataGridView2.AllowUserToDeleteRows = false;
            this.designAlternativeDataGridView2.AutoGenerateColumns = false;
            this.designAlternativeDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.designAlternativeDataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn30});
            this.designAlternativeDataGridView2.DataSource = this.designAlternativeBindingSource;
            this.designAlternativeDataGridView2.Location = new System.Drawing.Point(6, 6);
            this.designAlternativeDataGridView2.Name = "designAlternativeDataGridView2";
            this.designAlternativeDataGridView2.ReadOnly = true;
            this.designAlternativeDataGridView2.Size = new System.Drawing.Size(1199, 220);
            this.designAlternativeDataGridView2.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn6.HeaderText = "Description";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "RelatedToWind";
            this.dataGridViewTextBoxColumn8.HeaderText = "RelatedToWind";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "RelatedToView";
            this.dataGridViewTextBoxColumn10.HeaderText = "RelatedToView";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "BuildingForm";
            this.dataGridViewTextBoxColumn12.HeaderText = "BuildingForm";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "FacadeMaterial";
            this.dataGridViewTextBoxColumn14.HeaderText = "FacadeMaterial";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "GlazingPercentage";
            this.dataGridViewTextBoxColumn16.HeaderText = "GlazingPercentage";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "PlanEfficiency";
            this.dataGridViewTextBoxColumn18.HeaderText = "PlanEfficiency";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "ShapeComplexity";
            this.dataGridViewTextBoxColumn20.HeaderText = "ShapeComplexity";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "NumberOfStorey";
            this.dataGridViewTextBoxColumn22.HeaderText = "NumberOfStorey";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "AverageStoreyHeight";
            this.dataGridViewTextBoxColumn24.HeaderText = "AverageStoreyHeight";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "GlazingShape";
            this.dataGridViewTextBoxColumn26.HeaderText = "GlazingShape";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "GlazingEfficiency";
            this.dataGridViewTextBoxColumn28.HeaderText = "GlazingEfficiency";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "SunBreakersGeometry";
            this.dataGridViewTextBoxColumn30.HeaderText = "SunBreakersGeometry";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.ReadOnly = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 730);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Design Alternatives";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.designAlternativeResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.designAlternativeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.designAlternativeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlternativesNumber)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.relatedToViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatedToWindBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glazingPercentageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facadeMaterialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingFormBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shapeComplexityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planEfficiencyBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sunBreakersGeometryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glazingEfficiencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glazingShapeBindingSource)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.averageStoreyHeightBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfStoreyBindingSource)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spanDimensionBindingSource)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circulationAreaBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.designAlternativeDataGridView1)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.designAlternativeDataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.BindingSource designAlternativeBindingSource;
        private System.Windows.Forms.DataGridView designAlternativeDataGridView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown nudAlternativesNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource relatedToWindBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource relatedToViewBindingSource;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource buildingFormBindingSource;
        private System.Windows.Forms.BindingSource facadeMaterialBindingSource;
        private System.Windows.Forms.BindingSource glazingPercentageBindingSource;
        private System.Windows.Forms.ComboBox buildingFormIdComboBox;
        private System.Windows.Forms.ComboBox facadeMaterialIdComboBox;
        private System.Windows.Forms.ComboBox glazingPercentageIdComboBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox shapeComplexityIdComboBox;
        private System.Windows.Forms.BindingSource shapeComplexityBindingSource;
        private System.Windows.Forms.ComboBox planEfficiencyIdComboBox;
        private System.Windows.Forms.BindingSource planEfficiencyBindingSource;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox averageStoreyHeightIdComboBox;
        private System.Windows.Forms.BindingSource averageStoreyHeightBindingSource;
        private System.Windows.Forms.ComboBox numberOfStoreyIdComboBox;
        private System.Windows.Forms.BindingSource numberOfStoreyBindingSource;
        private System.Windows.Forms.ComboBox sunBreakersGeometryIdComboBox;
        private System.Windows.Forms.BindingSource sunBreakersGeometryBindingSource;
        private System.Windows.Forms.ComboBox glazingEfficiencyIdComboBox;
        private System.Windows.Forms.BindingSource glazingEfficiencyBindingSource;
        private System.Windows.Forms.ComboBox glazingShapeIdComboBox;
        private System.Windows.Forms.BindingSource glazingShapeBindingSource;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox spanDimensionIdComboBox;
        private System.Windows.Forms.ComboBox circulationAreaIdComboBox;
        private System.Windows.Forms.BindingSource spanDimensionBindingSource;
        private System.Windows.Forms.BindingSource circulationAreaBindingSource;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.BindingSource designAlternativeResultBindingSource;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView designAlternativeDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn45;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn46;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn47;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn48;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn49;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn50;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn51;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn52;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn53;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn54;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn55;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn56;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn57;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn58;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn59;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn60;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn61;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn62;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn63;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn64;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn65;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn66;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnResetDefaults;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessibilityTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn RelationTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnergyTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaintenanceTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn AestheticsTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rank;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView designAlternativeDataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.RadioButton rdAethiticas;
        private System.Windows.Forms.RadioButton rdOperationPerformance;
        private System.Windows.Forms.RadioButton rdConstructionPerformance;
        private System.Windows.Forms.RadioButton rdSpaceFunctionality;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Label lblBestCriteria;
        private System.Windows.Forms.Label lblBestCriteriaPercentage;
        private System.Windows.Forms.Label label59;
    }
}


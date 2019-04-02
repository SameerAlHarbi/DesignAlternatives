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
            System.Windows.Forms.Label label31;
            System.Windows.Forms.Label label30;
            System.Windows.Forms.Label label45;
            System.Windows.Forms.Label label46;
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.relatedToViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.relatedToWindBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.glazingPercentageIdComboBox = new System.Windows.Forms.ComboBox();
            this.glazingPercentageBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
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
            planEfficiencyIdLabel = new System.Windows.Forms.Label();
            shapeComplexityIdLabel = new System.Windows.Forms.Label();
            numberOfStoreyIdLabel = new System.Windows.Forms.Label();
            averageStoreyHeightIdLabel = new System.Windows.Forms.Label();
            glazingShapeIdLabel = new System.Windows.Forms.Label();
            glazingEfficiencyIdLabel = new System.Windows.Forms.Label();
            sunBreakersGeometryIdLabel = new System.Windows.Forms.Label();
            spanDimensionIdLabel = new System.Windows.Forms.Label();
            circulationAreaIdLabel = new System.Windows.Forms.Label();
            label31 = new System.Windows.Forms.Label();
            label30 = new System.Windows.Forms.Label();
            label45 = new System.Windows.Forms.Label();
            label46 = new System.Windows.Forms.Label();
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
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.designAlternativeDataGridView1)).BeginInit();
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
            // 
            // shapeComplexityIdLabel
            // 
            shapeComplexityIdLabel.AutoSize = true;
            shapeComplexityIdLabel.Location = new System.Drawing.Point(14, 95);
            shapeComplexityIdLabel.Name = "shapeComplexityIdLabel";
            shapeComplexityIdLabel.Size = new System.Drawing.Size(130, 16);
            shapeComplexityIdLabel.TabIndex = 2;
            shapeComplexityIdLabel.Text = "b. Shape Complexity:";
            // 
            // numberOfStoreyIdLabel
            // 
            numberOfStoreyIdLabel.AutoSize = true;
            numberOfStoreyIdLabel.Location = new System.Drawing.Point(14, 34);
            numberOfStoreyIdLabel.Name = "numberOfStoreyIdLabel";
            numberOfStoreyIdLabel.Size = new System.Drawing.Size(131, 16);
            numberOfStoreyIdLabel.TabIndex = 0;
            numberOfStoreyIdLabel.Text = "a. Number Of Storey:";
            // 
            // averageStoreyHeightIdLabel
            // 
            averageStoreyHeightIdLabel.AutoSize = true;
            averageStoreyHeightIdLabel.Location = new System.Drawing.Point(14, 93);
            averageStoreyHeightIdLabel.Name = "averageStoreyHeightIdLabel";
            averageStoreyHeightIdLabel.Size = new System.Drawing.Size(156, 16);
            averageStoreyHeightIdLabel.TabIndex = 2;
            averageStoreyHeightIdLabel.Text = "b. Average Storey Height:";
            // 
            // glazingShapeIdLabel
            // 
            glazingShapeIdLabel.AutoSize = true;
            glazingShapeIdLabel.Location = new System.Drawing.Point(13, 38);
            glazingShapeIdLabel.Name = "glazingShapeIdLabel";
            glazingShapeIdLabel.Size = new System.Drawing.Size(105, 16);
            glazingShapeIdLabel.TabIndex = 0;
            glazingShapeIdLabel.Text = "a.Glazing Shape:";
            // 
            // glazingEfficiencyIdLabel
            // 
            glazingEfficiencyIdLabel.AutoSize = true;
            glazingEfficiencyIdLabel.Location = new System.Drawing.Point(13, 96);
            glazingEfficiencyIdLabel.Name = "glazingEfficiencyIdLabel";
            glazingEfficiencyIdLabel.Size = new System.Drawing.Size(122, 16);
            glazingEfficiencyIdLabel.TabIndex = 2;
            glazingEfficiencyIdLabel.Text = "b.Glazing Efficiency:";
            // 
            // sunBreakersGeometryIdLabel
            // 
            sunBreakersGeometryIdLabel.AutoSize = true;
            sunBreakersGeometryIdLabel.Location = new System.Drawing.Point(13, 161);
            sunBreakersGeometryIdLabel.Name = "sunBreakersGeometryIdLabel";
            sunBreakersGeometryIdLabel.Size = new System.Drawing.Size(162, 16);
            sunBreakersGeometryIdLabel.TabIndex = 4;
            sunBreakersGeometryIdLabel.Text = "c. Sun Breakers Geometry:";
            // 
            // spanDimensionIdLabel
            // 
            spanDimensionIdLabel.AutoSize = true;
            spanDimensionIdLabel.Location = new System.Drawing.Point(14, 38);
            spanDimensionIdLabel.Name = "spanDimensionIdLabel";
            spanDimensionIdLabel.Size = new System.Drawing.Size(120, 16);
            spanDimensionIdLabel.TabIndex = 0;
            spanDimensionIdLabel.Text = "a. Span Dimension:";
            // 
            // circulationAreaIdLabel
            // 
            circulationAreaIdLabel.AutoSize = true;
            circulationAreaIdLabel.Location = new System.Drawing.Point(14, 46);
            circulationAreaIdLabel.Name = "circulationAreaIdLabel";
            circulationAreaIdLabel.Size = new System.Drawing.Size(119, 16);
            circulationAreaIdLabel.TabIndex = 0;
            circulationAreaIdLabel.Text = "a. Circulation Area:";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.designAlternativeResultBindingSource, "BestRelationDesignPercentageText", true));
            label31.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label31.ForeColor = System.Drawing.Color.Maroon;
            label31.Location = new System.Drawing.Point(520, 515);
            label31.Name = "label31";
            label31.Size = new System.Drawing.Size(0, 16);
            label31.TabIndex = 0;
            label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // designAlternativeResultBindingSource
            // 
            this.designAlternativeResultBindingSource.DataSource = typeof(DesignAlternatives.WinApp.Models.DesignAlternativeResult);
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.designAlternativeResultBindingSource, "BestRelationDesignName", true));
            label30.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label30.ForeColor = System.Drawing.Color.Maroon;
            label30.Location = new System.Drawing.Point(520, 480);
            label30.Name = "label30";
            label30.Size = new System.Drawing.Size(0, 16);
            label30.TabIndex = 0;
            label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.designAlternativeResultBindingSource, "BestTimeDesignName", true));
            label45.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label45.ForeColor = System.Drawing.Color.Maroon;
            label45.Location = new System.Drawing.Point(656, 260);
            label45.Name = "label45";
            label45.Size = new System.Drawing.Size(0, 16);
            label45.TabIndex = 0;
            label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.designAlternativeResultBindingSource, "BestTimeDesignPercentage", true));
            label46.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label46.ForeColor = System.Drawing.Color.Maroon;
            label46.Location = new System.Drawing.Point(656, 295);
            label46.Name = "label46";
            label46.Size = new System.Drawing.Size(0, 16);
            label46.TabIndex = 0;
            label46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Score.Width = 80;
            // 
            // Percentage
            // 
            this.Percentage.DataPropertyName = "PercentageText";
            this.Percentage.HeaderText = "Percentage";
            this.Percentage.Name = "Percentage";
            this.Percentage.ReadOnly = true;
            this.Percentage.Width = 90;
            // 
            // Rank
            // 
            this.Rank.DataPropertyName = "Rank";
            this.Rank.HeaderText = "Rank";
            this.Rank.Name = "Rank";
            this.Rank.ReadOnly = true;
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
            this.comboBox2.Size = new System.Drawing.Size(229, 24);
            this.comboBox2.TabIndex = 1;
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
            this.comboBox1.Size = new System.Drawing.Size(228, 24);
            this.comboBox1.TabIndex = 1;
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
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.glazingPercentageIdComboBox);
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
            this.glazingPercentageIdComboBox.Size = new System.Drawing.Size(229, 24);
            this.glazingPercentageIdComboBox.TabIndex = 6;
            this.glazingPercentageIdComboBox.ValueMember = "Id";
            // 
            // glazingPercentageBindingSource
            // 
            this.glazingPercentageBindingSource.AllowNew = false;
            this.glazingPercentageBindingSource.DataSource = typeof(DesignAlternatives.WinApp.Models.DesignOption);
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
            this.facadeMaterialIdComboBox.Size = new System.Drawing.Size(228, 24);
            this.facadeMaterialIdComboBox.TabIndex = 5;
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
            this.buildingFormIdComboBox.Size = new System.Drawing.Size(228, 24);
            this.buildingFormIdComboBox.TabIndex = 4;
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1219, 706);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox8);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label39);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label38);
            this.tabPage2.Controls.Add(this.label51);
            this.tabPage2.Controls.Add(this.label37);
            this.tabPage2.Controls.Add(this.label36);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.groupBox11);
            this.tabPage2.Controls.Add(this.label50);
            this.tabPage2.Controls.Add(this.label49);
            this.tabPage2.Controls.Add(this.label29);
            this.tabPage2.Controls.Add(this.groupBox10);
            this.tabPage2.Controls.Add(this.label48);
            this.tabPage2.Controls.Add(this.label32);
            this.tabPage2.Controls.Add(this.label47);
            this.tabPage2.Controls.Add(this.label28);
            this.tabPage2.Controls.Add(label46);
            this.tabPage2.Controls.Add(label31);
            this.tabPage2.Controls.Add(label45);
            this.tabPage2.Controls.Add(label30);
            this.tabPage2.Controls.Add(this.label25);
            this.tabPage2.Controls.Add(this.label42);
            this.tabPage2.Controls.Add(this.label41);
            this.tabPage2.Controls.Add(this.label26);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1211, 677);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "  Results  ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label8);
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Controls.Add(this.label12);
            this.groupBox8.Controls.Add(this.label11);
            this.groupBox8.Controls.Add(this.label52);
            this.groupBox8.Controls.Add(this.label40);
            this.groupBox8.Controls.Add(this.label43);
            this.groupBox8.Controls.Add(this.label56);
            this.groupBox8.Controls.Add(this.label60);
            this.groupBox8.Controls.Add(this.label58);
            this.groupBox8.Controls.Add(this.label34);
            this.groupBox8.Controls.Add(this.label55);
            this.groupBox8.Controls.Add(this.label54);
            this.groupBox8.Controls.Add(this.label53);
            this.groupBox8.Controls.Add(this.label27);
            this.groupBox8.Controls.Add(this.label59);
            this.groupBox8.Controls.Add(this.label57);
            this.groupBox8.Controls.Add(this.label35);
            this.groupBox8.Controls.Add(this.label33);
            this.groupBox8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox8.Location = new System.Drawing.Point(6, 102);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(302, 445);
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
            this.label8.Location = new System.Drawing.Point(27, 64);
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
            this.label10.Location = new System.Drawing.Point(45, 37);
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
            this.label12.Location = new System.Drawing.Point(152, 64);
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
            this.label11.Location = new System.Drawing.Point(176, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Percentage";
            // 
            // label52
            // 
            this.label52.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label52.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label52.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label52.Location = new System.Drawing.Point(27, 353);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(249, 23);
            this.label52.TabIndex = 1;
            this.label52.Text = "Size";
            this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label52.Click += new System.EventHandler(this.label40_Click);
            // 
            // label40
            // 
            this.label40.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label40.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label40.Location = new System.Drawing.Point(27, 241);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(249, 23);
            this.label40.TabIndex = 1;
            this.label40.Text = "Relation";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label40.Click += new System.EventHandler(this.label40_Click);
            // 
            // label43
            // 
            this.label43.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label43.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label43.Location = new System.Drawing.Point(27, 121);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(249, 23);
            this.label43.TabIndex = 1;
            this.label43.Text = "Accessibility";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label56
            // 
            this.label56.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label56.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.designAlternativeResultBindingSource, "BestSizeDesignName", true));
            this.label56.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.ForeColor = System.Drawing.Color.Maroon;
            this.label56.Location = new System.Drawing.Point(54, 408);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(92, 23);
            this.label56.TabIndex = 0;
            this.label56.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label60.Location = new System.Drawing.Point(165, 385);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(70, 14);
            this.label60.TabIndex = 1;
            this.label60.Text = "Percentage";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label58.Location = new System.Drawing.Point(165, 276);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(70, 14);
            this.label58.TabIndex = 1;
            this.label58.Text = "Percentage";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label34.Location = new System.Drawing.Point(165, 158);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(70, 14);
            this.label34.TabIndex = 1;
            this.label34.Text = "Percentage";
            // 
            // label55
            // 
            this.label55.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label55.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.designAlternativeResultBindingSource, "BestSizeDesignPercentageText", true));
            this.label55.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.ForeColor = System.Drawing.Color.Maroon;
            this.label55.Location = new System.Drawing.Point(152, 408);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(92, 23);
            this.label55.TabIndex = 0;
            this.label55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label54
            // 
            this.label54.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label54.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.designAlternativeResultBindingSource, "BestRelationDesignName", true));
            this.label54.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.ForeColor = System.Drawing.Color.Maroon;
            this.label54.Location = new System.Drawing.Point(56, 304);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(92, 23);
            this.label54.TabIndex = 0;
            this.label54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label53
            // 
            this.label53.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label53.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.designAlternativeResultBindingSource, "BestRelationDesignPercentageText", true));
            this.label53.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.ForeColor = System.Drawing.Color.Maroon;
            this.label53.Location = new System.Drawing.Point(154, 304);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(92, 23);
            this.label53.TabIndex = 0;
            this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label27.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.designAlternativeResultBindingSource, "BestAccessibilityDesignName", true));
            this.label27.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Maroon;
            this.label27.Location = new System.Drawing.Point(56, 185);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(92, 23);
            this.label27.TabIndex = 0;
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label59.Location = new System.Drawing.Point(67, 385);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(71, 14);
            this.label59.TabIndex = 1;
            this.label59.Text = "Best Design";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label57.Location = new System.Drawing.Point(67, 276);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(71, 14);
            this.label57.TabIndex = 1;
            this.label57.Text = "Best Design";
            // 
            // label35
            // 
            this.label35.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label35.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.designAlternativeResultBindingSource, "BestAccessibilityDesignPercentageText", true));
            this.label35.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.Maroon;
            this.label35.Location = new System.Drawing.Point(154, 185);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(92, 23);
            this.label35.TabIndex = 0;
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label35.Click += new System.EventHandler(this.label35_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label33.Location = new System.Drawing.Point(67, 158);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(71, 14);
            this.label33.TabIndex = 1;
            this.label33.Text = "Best Design";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Location = new System.Drawing.Point(605, 138);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 17);
            this.label16.TabIndex = 1;
            this.label16.Text = "Percentage";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label39.Location = new System.Drawing.Point(444, 632);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(70, 14);
            this.label39.TabIndex = 1;
            this.label39.Text = "Percentage";
            // 
            // label13
            // 
            this.label13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.designAlternativeResultBindingSource, "BestConstructionPerformanceDesignName", true));
            this.label13.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Maroon;
            this.label13.Location = new System.Drawing.Point(445, 165);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 45);
            this.label13.TabIndex = 0;
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(468, 138);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 17);
            this.label15.TabIndex = 1;
            this.label15.Text = "Best Design";
            // 
            // label14
            // 
            this.label14.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.designAlternativeResultBindingSource, "BestConstructionPerformanceDesignPercentage", true));
            this.label14.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Maroon;
            this.label14.Location = new System.Drawing.Point(581, 165);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 45);
            this.label14.TabIndex = 0;
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label38.Location = new System.Drawing.Point(443, 597);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(71, 14);
            this.label38.TabIndex = 1;
            this.label38.Text = "Best Design";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label51.Location = new System.Drawing.Point(580, 296);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(70, 14);
            this.label51.TabIndex = 1;
            this.label51.Text = "Percentage";
            // 
            // label37
            // 
            this.label37.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label37.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label37.Location = new System.Drawing.Point(444, 558);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(125, 23);
            this.label37.TabIndex = 1;
            this.label37.Text = "Size";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.designAlternativeResultBindingSource, "BestSizeDesignPercentageText", true));
            this.label36.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.Maroon;
            this.label36.Location = new System.Drawing.Point(426, 521);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(0, 16);
            this.label36.TabIndex = 0;
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label24);
            this.groupBox11.Controls.Add(this.label23);
            this.groupBox11.Controls.Add(this.label21);
            this.groupBox11.Controls.Add(this.label22);
            this.groupBox11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox11.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox11.Location = new System.Drawing.Point(902, 369);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(285, 203);
            this.groupBox11.TabIndex = 21;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Aesthetics";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label24.Location = new System.Drawing.Point(169, 37);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(77, 17);
            this.label24.TabIndex = 1;
            this.label24.Text = "Percentage";
            // 
            // label23
            // 
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label23.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.designAlternativeResultBindingSource, "BestAestheticsDesignName", true));
            this.label23.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Maroon;
            this.label23.Location = new System.Drawing.Point(15, 64);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(124, 45);
            this.label23.TabIndex = 0;
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label21.Location = new System.Drawing.Point(38, 37);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(79, 17);
            this.label21.TabIndex = 1;
            this.label21.Text = "Best Design";
            // 
            // label22
            // 
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label22.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.designAlternativeResultBindingSource, "BestAestheticsDesignPercentage", true));
            this.label22.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Maroon;
            this.label22.Location = new System.Drawing.Point(145, 64);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(124, 45);
            this.label22.TabIndex = 0;
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label50.Location = new System.Drawing.Point(579, 261);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(71, 14);
            this.label50.TabIndex = 1;
            this.label50.Text = "Best Design";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label49.Location = new System.Drawing.Point(607, 636);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(70, 14);
            this.label49.TabIndex = 1;
            this.label49.Text = "Percentage";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label29.Location = new System.Drawing.Point(340, 552);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(70, 14);
            this.label29.TabIndex = 1;
            this.label29.Text = "Percentage";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label20);
            this.groupBox10.Controls.Add(this.label19);
            this.groupBox10.Controls.Add(this.label17);
            this.groupBox10.Controls.Add(this.label18);
            this.groupBox10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox10.Location = new System.Drawing.Point(902, 6);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(294, 157);
            this.groupBox10.TabIndex = 22;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Operation Performance";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label20.Location = new System.Drawing.Point(169, 37);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 17);
            this.label20.TabIndex = 1;
            this.label20.Text = "Percentage";
            // 
            // label19
            // 
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label19.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.designAlternativeResultBindingSource, "BestOperationPerformanceDesignName", true));
            this.label19.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Maroon;
            this.label19.Location = new System.Drawing.Point(15, 64);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(124, 45);
            this.label19.TabIndex = 0;
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.designAlternativeResultBindingSource, "BestOperationPerformanceDesignPercentage", true));
            this.label17.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Maroon;
            this.label17.Location = new System.Drawing.Point(145, 64);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(124, 45);
            this.label17.TabIndex = 0;
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label18.Location = new System.Drawing.Point(38, 37);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 17);
            this.label18.TabIndex = 1;
            this.label18.Text = "Best Design";
            // 
            // label48
            // 
            this.label48.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label48.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label48.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label48.Location = new System.Drawing.Point(580, 223);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(125, 23);
            this.label48.TabIndex = 1;
            this.label48.Text = "Time";
            this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label32
            // 
            this.label32.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label32.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label32.Location = new System.Drawing.Point(444, 443);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(125, 23);
            this.label32.TabIndex = 1;
            this.label32.Text = "Relation";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label47.Location = new System.Drawing.Point(606, 611);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(71, 14);
            this.label47.TabIndex = 1;
            this.label47.Text = "Best Design";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label28.Location = new System.Drawing.Point(583, 533);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(71, 14);
            this.label28.TabIndex = 1;
            this.label28.Text = "Best Design";
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label25.Location = new System.Drawing.Point(777, 507);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(119, 23);
            this.label25.TabIndex = 1;
            this.label25.Text = "Accessibility";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.designAlternativeResultBindingSource, "BestCosteDesignName", true));
            this.label42.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.Color.Maroon;
            this.label42.Location = new System.Drawing.Point(677, 610);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(0, 16);
            this.label42.TabIndex = 0;
            this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.designAlternativeResultBindingSource, "BestCosteDesignPercentage", true));
            this.label41.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.Color.Maroon;
            this.label41.Location = new System.Drawing.Point(677, 635);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(0, 16);
            this.label41.TabIndex = 0;
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.designAlternativeResultBindingSource, "BestAccessibilityDesignName", true));
            this.label26.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Maroon;
            this.label26.Location = new System.Drawing.Point(366, 480);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(0, 16);
            this.label26.TabIndex = 0;
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.designAlternativeDataGridView1)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.BindingSource designAlternativeResultBindingSource;
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
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label57;
    }
}


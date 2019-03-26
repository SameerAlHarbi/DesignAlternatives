namespace DesignAlternatives.WinApp
{
    partial class Form1
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
            System.Windows.Forms.Label aestheticsLabel;
            System.Windows.Forms.Label categoryNameLabel;
            System.Windows.Forms.Label subCategoryNameLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label maintenanceLabel;
            System.Windows.Forms.Label energyLabel;
            System.Windows.Forms.Label timeLabel;
            System.Windows.Forms.Label costLabel;
            System.Windows.Forms.Label sizeLabel;
            System.Windows.Forms.Label relationLabel;
            System.Windows.Forms.Label accessibilityLabel;
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.aestheticsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.categoryNameTextBox = new System.Windows.Forms.TextBox();
            this.subCategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
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
            aestheticsLabel = new System.Windows.Forms.Label();
            categoryNameLabel = new System.Windows.Forms.Label();
            subCategoryNameLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            maintenanceLabel = new System.Windows.Forms.Label();
            energyLabel = new System.Windows.Forms.Label();
            timeLabel = new System.Windows.Forms.Label();
            costLabel = new System.Windows.Forms.Label();
            sizeLabel = new System.Windows.Forms.Label();
            relationLabel = new System.Windows.Forms.Label();
            accessibilityLabel = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aestheticsNumericUpDown)).BeginInit();
            this.groupBox4.SuspendLayout();
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
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(416, 309);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 38);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(593, 309);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(151, 38);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.aestheticsNumericUpDown);
            this.groupBox5.Controls.Add(aestheticsLabel);
            this.groupBox5.Location = new System.Drawing.Point(592, 178);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(152, 119);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Aesthetics";
            // 
            // aestheticsNumericUpDown
            // 
            this.aestheticsNumericUpDown.DecimalPlaces = 2;
            this.aestheticsNumericUpDown.Location = new System.Drawing.Point(73, 29);
            this.aestheticsNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.aestheticsNumericUpDown.Name = "aestheticsNumericUpDown";
            this.aestheticsNumericUpDown.Size = new System.Drawing.Size(68, 20);
            this.aestheticsNumericUpDown.TabIndex = 1;
            // 
            // aestheticsLabel
            // 
            aestheticsLabel.AutoSize = true;
            aestheticsLabel.Location = new System.Drawing.Point(12, 30);
            aestheticsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            aestheticsLabel.Name = "aestheticsLabel";
            aestheticsLabel.Size = new System.Drawing.Size(61, 13);
            aestheticsLabel.TabIndex = 0;
            aestheticsLabel.Text = "Aesthetics:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.categoryNameTextBox);
            this.groupBox4.Controls.Add(categoryNameLabel);
            this.groupBox4.Controls.Add(this.subCategoryNameTextBox);
            this.groupBox4.Controls.Add(subCategoryNameLabel);
            this.groupBox4.Controls.Add(this.nameTextBox);
            this.groupBox4.Controls.Add(nameLabel);
            this.groupBox4.Location = new System.Drawing.Point(55, 104);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(691, 70);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Description";
            // 
            // categoryNameTextBox
            // 
            this.categoryNameTextBox.Location = new System.Drawing.Point(101, 30);
            this.categoryNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.categoryNameTextBox.Name = "categoryNameTextBox";
            this.categoryNameTextBox.Size = new System.Drawing.Size(137, 20);
            this.categoryNameTextBox.TabIndex = 2;
            // 
            // categoryNameLabel
            // 
            categoryNameLabel.AutoSize = true;
            categoryNameLabel.Location = new System.Drawing.Point(14, 32);
            categoryNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            categoryNameLabel.Name = "categoryNameLabel";
            categoryNameLabel.Size = new System.Drawing.Size(86, 13);
            categoryNameLabel.TabIndex = 1;
            categoryNameLabel.Text = "Category Name:";
            // 
            // subCategoryNameTextBox
            // 
            this.subCategoryNameTextBox.Location = new System.Drawing.Point(337, 30);
            this.subCategoryNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.subCategoryNameTextBox.Name = "subCategoryNameTextBox";
            this.subCategoryNameTextBox.Size = new System.Drawing.Size(137, 20);
            this.subCategoryNameTextBox.TabIndex = 4;
            // 
            // subCategoryNameLabel
            // 
            subCategoryNameLabel.AutoSize = true;
            subCategoryNameLabel.Location = new System.Drawing.Point(260, 32);
            subCategoryNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            subCategoryNameLabel.Name = "subCategoryNameLabel";
            subCategoryNameLabel.Size = new System.Drawing.Size(77, 13);
            subCategoryNameLabel.TabIndex = 3;
            subCategoryNameLabel.Text = "Sub Category:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(538, 30);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(137, 20);
            this.nameTextBox.TabIndex = 6;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(497, 32);
            nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "Name:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(maintenanceLabel);
            this.groupBox3.Controls.Add(this.maintenanceNumericUpDown);
            this.groupBox3.Controls.Add(energyLabel);
            this.groupBox3.Controls.Add(this.energyNumericUpDown);
            this.groupBox3.Location = new System.Drawing.Point(408, 178);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(168, 119);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operation Performance";
            // 
            // maintenanceLabel
            // 
            maintenanceLabel.AutoSize = true;
            maintenanceLabel.Location = new System.Drawing.Point(9, 55);
            maintenanceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            maintenanceLabel.Name = "maintenanceLabel";
            maintenanceLabel.Size = new System.Drawing.Size(72, 13);
            maintenanceLabel.TabIndex = 2;
            maintenanceLabel.Text = "Maintenance:";
            // 
            // maintenanceNumericUpDown
            // 
            this.maintenanceNumericUpDown.DecimalPlaces = 2;
            this.maintenanceNumericUpDown.Location = new System.Drawing.Point(87, 54);
            this.maintenanceNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.maintenanceNumericUpDown.Name = "maintenanceNumericUpDown";
            this.maintenanceNumericUpDown.Size = new System.Drawing.Size(68, 20);
            this.maintenanceNumericUpDown.TabIndex = 3;
            // 
            // energyLabel
            // 
            energyLabel.AutoSize = true;
            energyLabel.Location = new System.Drawing.Point(34, 30);
            energyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            energyLabel.Name = "energyLabel";
            energyLabel.Size = new System.Drawing.Size(45, 13);
            energyLabel.TabIndex = 0;
            energyLabel.Text = "Energy:";
            // 
            // energyNumericUpDown
            // 
            this.energyNumericUpDown.DecimalPlaces = 2;
            this.energyNumericUpDown.Location = new System.Drawing.Point(87, 29);
            this.energyNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.energyNumericUpDown.Name = "energyNumericUpDown";
            this.energyNumericUpDown.Size = new System.Drawing.Size(68, 20);
            this.energyNumericUpDown.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(timeLabel);
            this.groupBox2.Controls.Add(this.timeNumericUpDown);
            this.groupBox2.Controls.Add(costLabel);
            this.groupBox2.Controls.Add(this.costNumericUpDown);
            this.groupBox2.Location = new System.Drawing.Point(239, 178);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(153, 119);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Construction Performance";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new System.Drawing.Point(15, 52);
            timeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new System.Drawing.Size(33, 13);
            timeLabel.TabIndex = 2;
            timeLabel.Text = "Time:";
            // 
            // timeNumericUpDown
            // 
            this.timeNumericUpDown.DecimalPlaces = 2;
            this.timeNumericUpDown.Location = new System.Drawing.Point(57, 51);
            this.timeNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.timeNumericUpDown.Name = "timeNumericUpDown";
            this.timeNumericUpDown.Size = new System.Drawing.Size(68, 20);
            this.timeNumericUpDown.TabIndex = 3;
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new System.Drawing.Point(19, 27);
            costLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(33, 13);
            costLabel.TabIndex = 0;
            costLabel.Text = "Cost:";
            // 
            // costNumericUpDown
            // 
            this.costNumericUpDown.DecimalPlaces = 2;
            this.costNumericUpDown.Location = new System.Drawing.Point(57, 25);
            this.costNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.costNumericUpDown.Name = "costNumericUpDown";
            this.costNumericUpDown.Size = new System.Drawing.Size(68, 20);
            this.costNumericUpDown.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(sizeLabel);
            this.groupBox1.Controls.Add(this.sizeNumericUpDown);
            this.groupBox1.Controls.Add(relationLabel);
            this.groupBox1.Controls.Add(this.relationNumericUpDown);
            this.groupBox1.Controls.Add(accessibilityLabel);
            this.groupBox1.Controls.Add(this.accessibilityNumericUpDown);
            this.groupBox1.Location = new System.Drawing.Point(55, 178);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(168, 119);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Space Functionality";
            // 
            // sizeLabel
            // 
            sizeLabel.AutoSize = true;
            sizeLabel.Location = new System.Drawing.Point(50, 82);
            sizeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new System.Drawing.Size(30, 13);
            sizeLabel.TabIndex = 4;
            sizeLabel.Text = "Size:";
            // 
            // sizeNumericUpDown
            // 
            this.sizeNumericUpDown.DecimalPlaces = 2;
            this.sizeNumericUpDown.Location = new System.Drawing.Point(83, 81);
            this.sizeNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.sizeNumericUpDown.Name = "sizeNumericUpDown";
            this.sizeNumericUpDown.Size = new System.Drawing.Size(68, 20);
            this.sizeNumericUpDown.TabIndex = 5;
            // 
            // relationLabel
            // 
            relationLabel.AutoSize = true;
            relationLabel.Location = new System.Drawing.Point(27, 55);
            relationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            relationLabel.Name = "relationLabel";
            relationLabel.Size = new System.Drawing.Size(50, 13);
            relationLabel.TabIndex = 2;
            relationLabel.Text = "Relation:";
            // 
            // relationNumericUpDown
            // 
            this.relationNumericUpDown.DecimalPlaces = 2;
            this.relationNumericUpDown.Location = new System.Drawing.Point(83, 54);
            this.relationNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.relationNumericUpDown.Name = "relationNumericUpDown";
            this.relationNumericUpDown.Size = new System.Drawing.Size(68, 20);
            this.relationNumericUpDown.TabIndex = 3;
            // 
            // accessibilityLabel
            // 
            accessibilityLabel.AutoSize = true;
            accessibilityLabel.Location = new System.Drawing.Point(12, 30);
            accessibilityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            accessibilityLabel.Name = "accessibilityLabel";
            accessibilityLabel.Size = new System.Drawing.Size(68, 13);
            accessibilityLabel.TabIndex = 0;
            accessibilityLabel.Text = "Accessibility:";
            // 
            // accessibilityNumericUpDown
            // 
            this.accessibilityNumericUpDown.DecimalPlaces = 2;
            this.accessibilityNumericUpDown.Location = new System.Drawing.Point(83, 29);
            this.accessibilityNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.accessibilityNumericUpDown.Name = "accessibilityNumericUpDown";
            this.accessibilityNumericUpDown.Size = new System.Drawing.Size(68, 20);
            this.accessibilityNumericUpDown.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aestheticsNumericUpDown)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown aestheticsNumericUpDown;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox categoryNameTextBox;
        private System.Windows.Forms.TextBox subCategoryNameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
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
    }
}
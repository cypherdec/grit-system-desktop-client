
namespace DemoGritLogin
{
    partial class ManageNutritionControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.gbxEditNutrition = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxFoodType = new System.Windows.Forms.ComboBox();
            this.btnSaveNewFood = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEditCalories = new System.Windows.Forms.TextBox();
            this.txtEditCarbs = new System.Windows.Forms.TextBox();
            this.lblEditFoodID = new System.Windows.Forms.Label();
            this.btnSaveEditFood = new System.Windows.Forms.Button();
            this.txtEditProtein = new System.Windows.Forms.TextBox();
            this.txtEditFat = new System.Windows.Forms.TextBox();
            this.txtEditFoodName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditFood = new System.Windows.Forms.Button();
            this.gridViewNutrition = new System.Windows.Forms.DataGridView();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.btnRefreshData = new System.Windows.Forms.Button();
            this.gbxEditNutrition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNutrition)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Yellow;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(18, -72);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(362, 69);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh Data";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.BackColor = System.Drawing.Color.Yellow;
            this.btnDeleteFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFood.Location = new System.Drawing.Point(820, 648);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(214, 35);
            this.btnDeleteFood.TabIndex = 9;
            this.btnDeleteFood.Text = "Delete Food";
            this.btnDeleteFood.UseVisualStyleBackColor = false;
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
            // 
            // gbxEditNutrition
            // 
            this.gbxEditNutrition.Controls.Add(this.label7);
            this.gbxEditNutrition.Controls.Add(this.cbxFoodType);
            this.gbxEditNutrition.Controls.Add(this.btnSaveNewFood);
            this.gbxEditNutrition.Controls.Add(this.label3);
            this.gbxEditNutrition.Controls.Add(this.txtEditCalories);
            this.gbxEditNutrition.Controls.Add(this.txtEditCarbs);
            this.gbxEditNutrition.Controls.Add(this.lblEditFoodID);
            this.gbxEditNutrition.Controls.Add(this.btnSaveEditFood);
            this.gbxEditNutrition.Controls.Add(this.txtEditProtein);
            this.gbxEditNutrition.Controls.Add(this.txtEditFat);
            this.gbxEditNutrition.Controls.Add(this.txtEditFoodName);
            this.gbxEditNutrition.Controls.Add(this.label6);
            this.gbxEditNutrition.Controls.Add(this.label5);
            this.gbxEditNutrition.Controls.Add(this.label4);
            this.gbxEditNutrition.Controls.Add(this.label2);
            this.gbxEditNutrition.Controls.Add(this.label1);
            this.gbxEditNutrition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEditNutrition.Location = new System.Drawing.Point(58, 530);
            this.gbxEditNutrition.Name = "gbxEditNutrition";
            this.gbxEditNutrition.Size = new System.Drawing.Size(745, 489);
            this.gbxEditNutrition.TabIndex = 8;
            this.gbxEditNutrition.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(249, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Macros are per gram of food item*";
            // 
            // cbxFoodType
            // 
            this.cbxFoodType.AutoCompleteCustomSource.AddRange(new string[] {
            "Protein",
            "Fat",
            "Carb"});
            this.cbxFoodType.BackColor = System.Drawing.Color.Black;
            this.cbxFoodType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFoodType.ForeColor = System.Drawing.Color.Yellow;
            this.cbxFoodType.FormattingEnabled = true;
            this.cbxFoodType.Items.AddRange(new object[] {
            "Protein",
            "Fat",
            "Carb"});
            this.cbxFoodType.Location = new System.Drawing.Point(346, 123);
            this.cbxFoodType.Name = "cbxFoodType";
            this.cbxFoodType.Size = new System.Drawing.Size(167, 28);
            this.cbxFoodType.TabIndex = 13;
            // 
            // btnSaveNewFood
            // 
            this.btnSaveNewFood.BackColor = System.Drawing.Color.Yellow;
            this.btnSaveNewFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveNewFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNewFood.Location = new System.Drawing.Point(236, 392);
            this.btnSaveNewFood.Name = "btnSaveNewFood";
            this.btnSaveNewFood.Size = new System.Drawing.Size(277, 40);
            this.btnSaveNewFood.TabIndex = 13;
            this.btnSaveNewFood.Text = "Save New Food";
            this.btnSaveNewFood.UseVisualStyleBackColor = false;
            this.btnSaveNewFood.Click += new System.EventHandler(this.btnSaveNewFood_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(232, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Calories (Cal):";
            // 
            // txtEditCalories
            // 
            this.txtEditCalories.BackColor = System.Drawing.Color.Black;
            this.txtEditCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditCalories.ForeColor = System.Drawing.Color.Yellow;
            this.txtEditCalories.Location = new System.Drawing.Point(346, 348);
            this.txtEditCalories.Name = "txtEditCalories";
            this.txtEditCalories.Size = new System.Drawing.Size(167, 26);
            this.txtEditCalories.TabIndex = 11;
            // 
            // txtEditCarbs
            // 
            this.txtEditCarbs.BackColor = System.Drawing.Color.Black;
            this.txtEditCarbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditCarbs.ForeColor = System.Drawing.Color.Yellow;
            this.txtEditCarbs.Location = new System.Drawing.Point(346, 292);
            this.txtEditCarbs.Name = "txtEditCarbs";
            this.txtEditCarbs.Size = new System.Drawing.Size(167, 26);
            this.txtEditCarbs.TabIndex = 10;
            // 
            // lblEditFoodID
            // 
            this.lblEditFoodID.AutoSize = true;
            this.lblEditFoodID.Location = new System.Drawing.Point(592, 23);
            this.lblEditFoodID.Name = "lblEditFoodID";
            this.lblEditFoodID.Size = new System.Drawing.Size(48, 20);
            this.lblEditFoodID.TabIndex = 9;
            this.lblEditFoodID.Text = "fod id";
            this.lblEditFoodID.Visible = false;
            // 
            // btnSaveEditFood
            // 
            this.btnSaveEditFood.BackColor = System.Drawing.Color.Yellow;
            this.btnSaveEditFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveEditFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEditFood.Location = new System.Drawing.Point(236, 392);
            this.btnSaveEditFood.Name = "btnSaveEditFood";
            this.btnSaveEditFood.Size = new System.Drawing.Size(277, 40);
            this.btnSaveEditFood.TabIndex = 4;
            this.btnSaveEditFood.Text = "Update Food Info";
            this.btnSaveEditFood.UseVisualStyleBackColor = false;
            this.btnSaveEditFood.Click += new System.EventHandler(this.btnSaveEditFood_Click);
            // 
            // txtEditProtein
            // 
            this.txtEditProtein.BackColor = System.Drawing.Color.Black;
            this.txtEditProtein.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditProtein.ForeColor = System.Drawing.Color.Yellow;
            this.txtEditProtein.Location = new System.Drawing.Point(346, 179);
            this.txtEditProtein.Name = "txtEditProtein";
            this.txtEditProtein.Size = new System.Drawing.Size(167, 26);
            this.txtEditProtein.TabIndex = 6;
            // 
            // txtEditFat
            // 
            this.txtEditFat.BackColor = System.Drawing.Color.Black;
            this.txtEditFat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditFat.ForeColor = System.Drawing.Color.Yellow;
            this.txtEditFat.Location = new System.Drawing.Point(346, 235);
            this.txtEditFat.Name = "txtEditFat";
            this.txtEditFat.Size = new System.Drawing.Size(167, 26);
            this.txtEditFat.TabIndex = 6;
            // 
            // txtEditFoodName
            // 
            this.txtEditFoodName.BackColor = System.Drawing.Color.Black;
            this.txtEditFoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditFoodName.ForeColor = System.Drawing.Color.Yellow;
            this.txtEditFoodName.Location = new System.Drawing.Point(346, 67);
            this.txtEditFoodName.Name = "txtEditFoodName";
            this.txtEditFoodName.Size = new System.Drawing.Size(167, 26);
            this.txtEditFoodName.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(232, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Protein (g):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(232, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fat (g):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(232, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Carbs (g):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Food Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Food Name:";
            // 
            // btnEditFood
            // 
            this.btnEditFood.BackColor = System.Drawing.Color.Yellow;
            this.btnEditFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditFood.Location = new System.Drawing.Point(820, 530);
            this.btnEditFood.Name = "btnEditFood";
            this.btnEditFood.Size = new System.Drawing.Size(214, 35);
            this.btnEditFood.TabIndex = 7;
            this.btnEditFood.Text = "Edit Food";
            this.btnEditFood.UseVisualStyleBackColor = false;
            this.btnEditFood.Click += new System.EventHandler(this.btnEditFood_Click);
            // 
            // gridViewNutrition
            // 
            this.gridViewNutrition.AllowUserToAddRows = false;
            this.gridViewNutrition.AllowUserToDeleteRows = false;
            this.gridViewNutrition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridViewNutrition.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewNutrition.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridViewNutrition.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewNutrition.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridViewNutrition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewNutrition.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridViewNutrition.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gridViewNutrition.Location = new System.Drawing.Point(3, 42);
            this.gridViewNutrition.MultiSelect = false;
            this.gridViewNutrition.Name = "gridViewNutrition";
            this.gridViewNutrition.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewNutrition.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridViewNutrition.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewNutrition.ShowCellErrors = false;
            this.gridViewNutrition.ShowCellToolTips = false;
            this.gridViewNutrition.ShowEditingIcon = false;
            this.gridViewNutrition.ShowRowErrors = false;
            this.gridViewNutrition.Size = new System.Drawing.Size(1070, 482);
            this.gridViewNutrition.TabIndex = 6;
            // 
            // btnAddFood
            // 
            this.btnAddFood.BackColor = System.Drawing.Color.Yellow;
            this.btnAddFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFood.Location = new System.Drawing.Point(820, 589);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(214, 35);
            this.btnAddFood.TabIndex = 11;
            this.btnAddFood.Text = "Add New Food";
            this.btnAddFood.UseVisualStyleBackColor = false;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // btnRefreshData
            // 
            this.btnRefreshData.BackColor = System.Drawing.Color.Yellow;
            this.btnRefreshData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshData.Location = new System.Drawing.Point(3, 0);
            this.btnRefreshData.Name = "btnRefreshData";
            this.btnRefreshData.Size = new System.Drawing.Size(163, 36);
            this.btnRefreshData.TabIndex = 12;
            this.btnRefreshData.Text = "Refresh Data";
            this.btnRefreshData.UseVisualStyleBackColor = false;
            this.btnRefreshData.Click += new System.EventHandler(this.btnRefreshData_Click);
            // 
            // ManageNutritionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.btnRefreshData);
            this.Controls.Add(this.btnAddFood);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDeleteFood);
            this.Controls.Add(this.gbxEditNutrition);
            this.Controls.Add(this.btnEditFood);
            this.Controls.Add(this.gridViewNutrition);
            this.Name = "ManageNutritionControl";
            this.Size = new System.Drawing.Size(1092, 552);
            this.Load += new System.EventHandler(this.ManageNutritionControl_Load);
            this.gbxEditNutrition.ResumeLayout(false);
            this.gbxEditNutrition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNutrition)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.GroupBox gbxEditNutrition;
        private System.Windows.Forms.Label lblEditFoodID;
        private System.Windows.Forms.Button btnSaveEditFood;
        private System.Windows.Forms.TextBox txtEditFat;
        private System.Windows.Forms.TextBox txtEditProtein;
        private System.Windows.Forms.TextBox txtEditFoodName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditFood;
        private System.Windows.Forms.DataGridView gridViewNutrition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEditCalories;
        private System.Windows.Forms.TextBox txtEditCarbs;
        private System.Windows.Forms.Button btnSaveNewFood;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Button btnRefreshData;
        private System.Windows.Forms.ComboBox cbxFoodType;
        private System.Windows.Forms.Label label7;
    }
}

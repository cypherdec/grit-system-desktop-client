
namespace DemoGritLogin
{
    partial class ManageFoodControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnNewFood = new System.Windows.Forms.Button();
            this.gbxEditClient = new System.Windows.Forms.GroupBox();
            this.lblFoodID = new System.Windows.Forms.Label();
            this.btnUpdateFood = new System.Windows.Forms.Button();
            this.txtFat = new System.Windows.Forms.TextBox();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditFood = new System.Windows.Forms.Button();
            this.gridViewFoods = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProtein = new System.Windows.Forms.TextBox();
            this.cbxFoodType = new System.Windows.Forms.ComboBox();
            this.txtCarbs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCalories = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSaveNewFood = new System.Windows.Forms.Button();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.gbxEditClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFoods)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Yellow;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(15, 20);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(362, 69);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh Data";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnNewFood
            // 
            this.btnNewFood.BackColor = System.Drawing.Color.Yellow;
            this.btnNewFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewFood.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewFood.Location = new System.Drawing.Point(1341, 701);
            this.btnNewFood.Name = "btnNewFood";
            this.btnNewFood.Size = new System.Drawing.Size(325, 69);
            this.btnNewFood.TabIndex = 9;
            this.btnNewFood.Text = "New Food";
            this.btnNewFood.UseVisualStyleBackColor = false;
            this.btnNewFood.Click += new System.EventHandler(this.btnNewFood_Click);
            // 
            // gbxEditClient
            // 
            this.gbxEditClient.Controls.Add(this.btnSaveNewFood);
            this.gbxEditClient.Controls.Add(this.label14);
            this.gbxEditClient.Controls.Add(this.txtCalories);
            this.gbxEditClient.Controls.Add(this.label4);
            this.gbxEditClient.Controls.Add(this.txtCarbs);
            this.gbxEditClient.Controls.Add(this.label3);
            this.gbxEditClient.Controls.Add(this.lblFoodID);
            this.gbxEditClient.Controls.Add(this.btnUpdateFood);
            this.gbxEditClient.Controls.Add(this.cbxFoodType);
            this.gbxEditClient.Controls.Add(this.txtProtein);
            this.gbxEditClient.Controls.Add(this.txtFat);
            this.gbxEditClient.Controls.Add(this.txtFoodName);
            this.gbxEditClient.Controls.Add(this.label6);
            this.gbxEditClient.Controls.Add(this.label5);
            this.gbxEditClient.Controls.Add(this.label2);
            this.gbxEditClient.Controls.Add(this.label1);
            this.gbxEditClient.Location = new System.Drawing.Point(15, 627);
            this.gbxEditClient.Name = "gbxEditClient";
            this.gbxEditClient.Size = new System.Drawing.Size(1320, 762);
            this.gbxEditClient.TabIndex = 8;
            this.gbxEditClient.TabStop = false;
            // 
            // lblFoodID
            // 
            this.lblFoodID.AutoSize = true;
            this.lblFoodID.Location = new System.Drawing.Point(76, 298);
            this.lblFoodID.Name = "lblFoodID";
            this.lblFoodID.Size = new System.Drawing.Size(39, 13);
            this.lblFoodID.TabIndex = 9;
            this.lblFoodID.Text = "food id";
            this.lblFoodID.Visible = false;
            // 
            // btnUpdateFood
            // 
            this.btnUpdateFood.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdateFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateFood.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateFood.Location = new System.Drawing.Point(284, 533);
            this.btnUpdateFood.Name = "btnUpdateFood";
            this.btnUpdateFood.Size = new System.Drawing.Size(774, 69);
            this.btnUpdateFood.TabIndex = 4;
            this.btnUpdateFood.Text = "Update Food";
            this.btnUpdateFood.UseVisualStyleBackColor = false;
            this.btnUpdateFood.Click += new System.EventHandler(this.btnUpdateFood_Click);
            // 
            // txtFat
            // 
            this.txtFat.BackColor = System.Drawing.Color.Black;
            this.txtFat.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFat.ForeColor = System.Drawing.Color.Yellow;
            this.txtFat.Location = new System.Drawing.Point(617, 317);
            this.txtFat.Name = "txtFat";
            this.txtFat.Size = new System.Drawing.Size(441, 66);
            this.txtFat.TabIndex = 6;
            // 
            // txtFoodName
            // 
            this.txtFoodName.BackColor = System.Drawing.Color.Black;
            this.txtFoodName.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoodName.ForeColor = System.Drawing.Color.Yellow;
            this.txtFoodName.Location = new System.Drawing.Point(617, 101);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(441, 66);
            this.txtFoodName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 58);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fat:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Food Name:";
            // 
            // btnEditFood
            // 
            this.btnEditFood.BackColor = System.Drawing.Color.Yellow;
            this.btnEditFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditFood.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditFood.Location = new System.Drawing.Point(1341, 626);
            this.btnEditFood.Name = "btnEditFood";
            this.btnEditFood.Size = new System.Drawing.Size(325, 69);
            this.btnEditFood.TabIndex = 7;
            this.btnEditFood.Text = "Edit Food";
            this.btnEditFood.UseVisualStyleBackColor = false;
            this.btnEditFood.Click += new System.EventHandler(this.btnEditFood_Click);
            // 
            // gridViewFoods
            // 
            this.gridViewFoods.AllowUserToAddRows = false;
            this.gridViewFoods.AllowUserToDeleteRows = false;
            this.gridViewFoods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridViewFoods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewFoods.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridViewFoods.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewFoods.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridViewFoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewFoods.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridViewFoods.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gridViewFoods.Location = new System.Drawing.Point(15, 95);
            this.gridViewFoods.MultiSelect = false;
            this.gridViewFoods.Name = "gridViewFoods";
            this.gridViewFoods.ReadOnly = true;
            this.gridViewFoods.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewFoods.ShowCellErrors = false;
            this.gridViewFoods.ShowCellToolTips = false;
            this.gridViewFoods.ShowEditingIcon = false;
            this.gridViewFoods.ShowRowErrors = false;
            this.gridViewFoods.Size = new System.Drawing.Size(1649, 526);
            this.gridViewFoods.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(274, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 58);
            this.label5.TabIndex = 4;
            this.label5.Text = "Protein:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(274, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(279, 58);
            this.label6.TabIndex = 5;
            this.label6.Text = "Food Type:";
            // 
            // txtProtein
            // 
            this.txtProtein.BackColor = System.Drawing.Color.Black;
            this.txtProtein.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProtein.ForeColor = System.Drawing.Color.Yellow;
            this.txtProtein.Location = new System.Drawing.Point(617, 245);
            this.txtProtein.Name = "txtProtein";
            this.txtProtein.Size = new System.Drawing.Size(441, 66);
            this.txtProtein.TabIndex = 6;
            // 
            // cbxFoodType
            // 
            this.cbxFoodType.BackColor = System.Drawing.Color.Black;
            this.cbxFoodType.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFoodType.ForeColor = System.Drawing.Color.Yellow;
            this.cbxFoodType.FormattingEnabled = true;
            this.cbxFoodType.Items.AddRange(new object[] {
            "Protein",
            "Fat",
            "Carbs"});
            this.cbxFoodType.Location = new System.Drawing.Point(617, 173);
            this.cbxFoodType.Name = "cbxFoodType";
            this.cbxFoodType.Size = new System.Drawing.Size(441, 66);
            this.cbxFoodType.TabIndex = 7;
            // 
            // txtCarbs
            // 
            this.txtCarbs.BackColor = System.Drawing.Color.Black;
            this.txtCarbs.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarbs.ForeColor = System.Drawing.Color.Yellow;
            this.txtCarbs.Location = new System.Drawing.Point(617, 389);
            this.txtCarbs.Name = "txtCarbs";
            this.txtCarbs.Size = new System.Drawing.Size(441, 66);
            this.txtCarbs.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(274, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 58);
            this.label3.TabIndex = 10;
            this.label3.Text = "Carbs:";
            // 
            // txtCalories
            // 
            this.txtCalories.BackColor = System.Drawing.Color.Black;
            this.txtCalories.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalories.ForeColor = System.Drawing.Color.Yellow;
            this.txtCalories.Location = new System.Drawing.Point(617, 461);
            this.txtCalories.Name = "txtCalories";
            this.txtCalories.Size = new System.Drawing.Size(441, 66);
            this.txtCalories.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(274, 465);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 58);
            this.label4.TabIndex = 12;
            this.label4.Text = "Calories:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Yellow;
            this.label14.Location = new System.Drawing.Point(6, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(239, 58);
            this.label14.TabIndex = 15;
            this.label14.Text = "Edit Food";
            // 
            // btnSaveNewFood
            // 
            this.btnSaveNewFood.BackColor = System.Drawing.Color.Yellow;
            this.btnSaveNewFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveNewFood.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNewFood.Location = new System.Drawing.Point(284, 608);
            this.btnSaveNewFood.Name = "btnSaveNewFood";
            this.btnSaveNewFood.Size = new System.Drawing.Size(774, 69);
            this.btnSaveNewFood.TabIndex = 16;
            this.btnSaveNewFood.Text = "Save New Food";
            this.btnSaveNewFood.UseVisualStyleBackColor = false;
            this.btnSaveNewFood.Click += new System.EventHandler(this.btnSaveNewFood_Click);
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.BackColor = System.Drawing.Color.Yellow;
            this.btnDeleteFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteFood.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFood.Location = new System.Drawing.Point(1341, 776);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(325, 69);
            this.btnDeleteFood.TabIndex = 11;
            this.btnDeleteFood.Text = "Delete Food";
            this.btnDeleteFood.UseVisualStyleBackColor = false;
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
            // 
            // ManageFoodControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.btnDeleteFood);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnNewFood);
            this.Controls.Add(this.gbxEditClient);
            this.Controls.Add(this.btnEditFood);
            this.Controls.Add(this.gridViewFoods);
            this.Name = "ManageFoodControl";
            this.Size = new System.Drawing.Size(1679, 1092);
            this.Load += new System.EventHandler(this.ManageFoodControl_Load);
            this.gbxEditClient.ResumeLayout(false);
            this.gbxEditClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFoods)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnNewFood;
        private System.Windows.Forms.GroupBox gbxEditClient;
        private System.Windows.Forms.Button btnSaveNewFood;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCalories;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCarbs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFoodID;
        private System.Windows.Forms.Button btnUpdateFood;
        private System.Windows.Forms.ComboBox cbxFoodType;
        private System.Windows.Forms.TextBox txtProtein;
        private System.Windows.Forms.TextBox txtFat;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditFood;
        private System.Windows.Forms.DataGridView gridViewFoods;
        private System.Windows.Forms.Button btnDeleteFood;
    }
}

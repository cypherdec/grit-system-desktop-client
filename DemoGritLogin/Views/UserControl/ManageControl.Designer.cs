
namespace DemoGritLogin
{
    partial class ManageControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.btnCoachHome = new System.Windows.Forms.Button();
            this.btnManageAdd = new System.Windows.Forms.Button();
            this.btnManageNutrition = new System.Windows.Forms.Button();
            this.btnManageClients = new System.Windows.Forms.Button();
            this.coachControl1 = new DemoGritLogin.CoachControl();
            this.clientControl1 = new DemoGritLogin.ClientControl();
            this.manageNutritionControl1 = new DemoGritLogin.ManageNutritionControl();
            this.manageClientControl2 = new DemoGritLogin.ManageClientControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.buttonPanel);
            this.panel1.Controls.Add(this.btnCoachHome);
            this.panel1.Controls.Add(this.btnManageAdd);
            this.panel1.Controls.Add(this.btnManageNutrition);
            this.panel1.Controls.Add(this.btnManageClients);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1109, 71);
            this.panel1.TabIndex = 0;
            // 
            // buttonPanel
            // 
            this.buttonPanel.BackColor = System.Drawing.Color.Yellow;
            this.buttonPanel.Location = new System.Drawing.Point(38, 16);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(159, 5);
            this.buttonPanel.TabIndex = 1;
            // 
            // btnCoachHome
            // 
            this.btnCoachHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoachHome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoachHome.ForeColor = System.Drawing.Color.Yellow;
            this.btnCoachHome.Location = new System.Drawing.Point(38, 16);
            this.btnCoachHome.Name = "btnCoachHome";
            this.btnCoachHome.Size = new System.Drawing.Size(159, 43);
            this.btnCoachHome.TabIndex = 3;
            this.btnCoachHome.Text = "Home";
            this.btnCoachHome.UseVisualStyleBackColor = true;
            this.btnCoachHome.Click += new System.EventHandler(this.btnCoachHome_Click);
            // 
            // btnManageAdd
            // 
            this.btnManageAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageAdd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageAdd.ForeColor = System.Drawing.Color.Yellow;
            this.btnManageAdd.Location = new System.Drawing.Point(219, 16);
            this.btnManageAdd.Name = "btnManageAdd";
            this.btnManageAdd.Size = new System.Drawing.Size(159, 43);
            this.btnManageAdd.TabIndex = 2;
            this.btnManageAdd.Text = "Add Client";
            this.btnManageAdd.UseVisualStyleBackColor = true;
            this.btnManageAdd.Click += new System.EventHandler(this.btnManageAdd_Click);
            // 
            // btnManageNutrition
            // 
            this.btnManageNutrition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageNutrition.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageNutrition.ForeColor = System.Drawing.Color.Yellow;
            this.btnManageNutrition.Location = new System.Drawing.Point(581, 16);
            this.btnManageNutrition.Name = "btnManageNutrition";
            this.btnManageNutrition.Size = new System.Drawing.Size(159, 43);
            this.btnManageNutrition.TabIndex = 2;
            this.btnManageNutrition.Text = "Manage Nutriton";
            this.btnManageNutrition.UseVisualStyleBackColor = true;
            this.btnManageNutrition.Click += new System.EventHandler(this.btnManageNutrtion_Click);
            // 
            // btnManageClients
            // 
            this.btnManageClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageClients.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageClients.ForeColor = System.Drawing.Color.Yellow;
            this.btnManageClients.Location = new System.Drawing.Point(400, 16);
            this.btnManageClients.Name = "btnManageClients";
            this.btnManageClients.Size = new System.Drawing.Size(159, 43);
            this.btnManageClients.TabIndex = 1;
            this.btnManageClients.Text = "Manage Clients";
            this.btnManageClients.UseVisualStyleBackColor = true;
            this.btnManageClients.Click += new System.EventHandler(this.btnManageClients_Click);
            // 
            // coachControl1
            // 
            this.coachControl1.AutoScroll = true;
            this.coachControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.coachControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.coachControl1.ForeColor = System.Drawing.Color.Black;
            this.coachControl1.Location = new System.Drawing.Point(0, 71);
            this.coachControl1.Name = "coachControl1";
            this.coachControl1.Size = new System.Drawing.Size(1109, 552);
            this.coachControl1.TabIndex = 2;
            // 
            // clientControl1
            // 
            this.clientControl1.AutoScroll = true;
            this.clientControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clientControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientControl1.Location = new System.Drawing.Point(0, 71);
            this.clientControl1.Name = "clientControl1";
            this.clientControl1.Size = new System.Drawing.Size(1109, 552);
            this.clientControl1.TabIndex = 4;
            // 
            // manageNutritionControl1
            // 
            this.manageNutritionControl1.AutoScroll = true;
            this.manageNutritionControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.manageNutritionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manageNutritionControl1.Location = new System.Drawing.Point(0, 71);
            this.manageNutritionControl1.Name = "manageNutritionControl1";
            this.manageNutritionControl1.Size = new System.Drawing.Size(1109, 552);
            this.manageNutritionControl1.TabIndex = 3;
            // 
            // manageClientControl2
            // 
            this.manageClientControl2.AutoScroll = true;
            this.manageClientControl2.AutoScrollMargin = new System.Drawing.Size(0, 10);
            this.manageClientControl2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.manageClientControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.manageClientControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manageClientControl2.Location = new System.Drawing.Point(0, 71);
            this.manageClientControl2.Name = "manageClientControl2";
            this.manageClientControl2.Size = new System.Drawing.Size(1109, 552);
            this.manageClientControl2.TabIndex = 5;
            // 
            // ManageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.manageClientControl2);
            this.Controls.Add(this.manageNutritionControl1);
            this.Controls.Add(this.clientControl1);
            this.Controls.Add(this.coachControl1);
            this.Controls.Add(this.panel1);
            this.Name = "ManageControl";
            this.Size = new System.Drawing.Size(1109, 623);
            this.Load += new System.EventHandler(this.ManageControl_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button btnCoachHome;
        private System.Windows.Forms.Button btnManageNutrition;
        private System.Windows.Forms.Button btnManageClients;
        private ManageClientControl manageClientControl1;
        private CoachControl coachControl1;
        private System.Windows.Forms.Button btnManageAdd;
        private ClientControl clientControl1;
        private ManageNutritionControl manageNutritionControl1;
        private ManageClientControl manageClientControl2;
    }
}

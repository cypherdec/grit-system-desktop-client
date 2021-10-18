namespace DemoGritLogin
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.pnMenu = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnAnalytics = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.btnProgress = new System.Windows.Forms.Button();
            this.btnDiet = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnTop = new System.Windows.Forms.Panel();
            this.lblMainEmail = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.pbResize = new System.Windows.Forms.PictureBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.loginControl1 = new DemoGritLogin.LoginControl();
            this.homeControl1 = new DemoGritLogin.HomeControl();
            this.progressControl1 = new DemoGritLogin.ProgressControl();
            this.nutritionControl1 = new DemoGritLogin.NutritionControl();
            this.analyticsControl1 = new DemoGritLogin.AnalyticsControl();
            this.pnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.AutoScroll = true;
            this.pnMenu.BackColor = System.Drawing.Color.Black;
            this.pnMenu.Controls.Add(this.SidePanel);
            this.pnMenu.Controls.Add(this.btnAnalytics);
            this.pnMenu.Controls.Add(this.btnManage);
            this.pnMenu.Controls.Add(this.btnProgress);
            this.pnMenu.Controls.Add(this.btnDiet);
            this.pnMenu.Controls.Add(this.btnHome);
            this.pnMenu.Controls.Add(this.pbLogo);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(161, 670);
            this.pnMenu.TabIndex = 0;
            this.pnMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnMenu_Paint);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.Yellow;
            this.SidePanel.Location = new System.Drawing.Point(0, 65);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 61);
            this.SidePanel.TabIndex = 2;
            // 
            // btnAnalytics
            // 
            this.btnAnalytics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnalytics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnalytics.FlatAppearance.BorderSize = 0;
            this.btnAnalytics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAnalytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalytics.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalytics.ForeColor = System.Drawing.Color.Yellow;
            this.btnAnalytics.Image = ((System.Drawing.Image)(resources.GetObject("btnAnalytics.Image")));
            this.btnAnalytics.Location = new System.Drawing.Point(0, 309);
            this.btnAnalytics.Name = "btnAnalytics";
            this.btnAnalytics.Size = new System.Drawing.Size(161, 61);
            this.btnAnalytics.TabIndex = 7;
            this.btnAnalytics.Text = "Analytics";
            this.btnAnalytics.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAnalytics.UseVisualStyleBackColor = true;
            this.btnAnalytics.Click += new System.EventHandler(this.btnAnalytics_Click);
            // 
            // btnManage
            // 
            this.btnManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManage.FlatAppearance.BorderSize = 0;
            this.btnManage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManage.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManage.ForeColor = System.Drawing.Color.Yellow;
            this.btnManage.Image = ((System.Drawing.Image)(resources.GetObject("btnManage.Image")));
            this.btnManage.Location = new System.Drawing.Point(0, 248);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(161, 61);
            this.btnManage.TabIndex = 6;
            this.btnManage.Text = "Manage";
            this.btnManage.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnManage.UseVisualStyleBackColor = true;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // btnProgress
            // 
            this.btnProgress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProgress.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProgress.FlatAppearance.BorderSize = 0;
            this.btnProgress.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProgress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProgress.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProgress.ForeColor = System.Drawing.Color.Yellow;
            this.btnProgress.Image = ((System.Drawing.Image)(resources.GetObject("btnProgress.Image")));
            this.btnProgress.Location = new System.Drawing.Point(0, 187);
            this.btnProgress.Name = "btnProgress";
            this.btnProgress.Size = new System.Drawing.Size(161, 61);
            this.btnProgress.TabIndex = 5;
            this.btnProgress.Text = "Progress";
            this.btnProgress.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnProgress.UseVisualStyleBackColor = true;
            this.btnProgress.Click += new System.EventHandler(this.btnProgress_Click);
            // 
            // btnDiet
            // 
            this.btnDiet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiet.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDiet.FlatAppearance.BorderSize = 0;
            this.btnDiet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiet.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiet.ForeColor = System.Drawing.Color.Yellow;
            this.btnDiet.Image = global::DemoGritLogin.Properties.Resources.food;
            this.btnDiet.Location = new System.Drawing.Point(0, 126);
            this.btnDiet.Name = "btnDiet";
            this.btnDiet.Size = new System.Drawing.Size(161, 61);
            this.btnDiet.TabIndex = 4;
            this.btnDiet.Text = "Nutrition";
            this.btnDiet.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDiet.UseVisualStyleBackColor = true;
            this.btnDiet.Click += new System.EventHandler(this.btnDiet_Click);
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Yellow;
            this.btnHome.Image = global::DemoGritLogin.Properties.Resources.home;
            this.btnHome.Location = new System.Drawing.Point(0, 65);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(161, 61);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbLogo.Image = global::DemoGritLogin.Properties.Resources.logo;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(161, 65);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.Black;
            this.pnTop.Controls.Add(this.lblMainEmail);
            this.pnTop.Controls.Add(this.btnLogout);
            this.pnTop.Controls.Add(this.pbMinimize);
            this.pnTop.Controls.Add(this.pbResize);
            this.pnTop.Controls.Add(this.pbExit);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(161, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1109, 47);
            this.pnTop.TabIndex = 1;
            this.pnTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTop_MouseDown);
            this.pnTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnTop_MouseMove);
            this.pnTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnTop_MouseUp);
            // 
            // lblMainEmail
            // 
            this.lblMainEmail.AutoSize = true;
            this.lblMainEmail.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainEmail.ForeColor = System.Drawing.Color.Yellow;
            this.lblMainEmail.Location = new System.Drawing.Point(150, 12);
            this.lblMainEmail.Name = "lblMainEmail";
            this.lblMainEmail.Size = new System.Drawing.Size(58, 22);
            this.lblMainEmail.TabIndex = 9;
            this.lblMainEmail.Text = "email";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Yellow;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(40, 9);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(84, 28);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pbMinimize
            // 
            this.pbMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbMinimize.BackgroundImage")));
            this.pbMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMinimize.Location = new System.Drawing.Point(953, 12);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(32, 25);
            this.pbMinimize.TabIndex = 6;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
            this.pbMinimize.MouseLeave += new System.EventHandler(this.pbMinimize_MouseLeave);
            this.pbMinimize.MouseHover += new System.EventHandler(this.pbMinimize_MouseHover);
            // 
            // pbResize
            // 
            this.pbResize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbResize.BackgroundImage = global::DemoGritLogin.Properties.Resources.enlarge;
            this.pbResize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbResize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbResize.Location = new System.Drawing.Point(1000, 12);
            this.pbResize.Name = "pbResize";
            this.pbResize.Size = new System.Drawing.Size(32, 25);
            this.pbResize.TabIndex = 3;
            this.pbResize.TabStop = false;
            this.pbResize.Click += new System.EventHandler(this.pbResize_Click);
            this.pbResize.MouseLeave += new System.EventHandler(this.pbResize_MouseLeave);
            this.pbResize.MouseHover += new System.EventHandler(this.pbResize_MouseHover);
            // 
            // pbExit
            // 
            this.pbExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbExit.BackColor = System.Drawing.Color.Black;
            this.pbExit.BackgroundImage = global::DemoGritLogin.Properties.Resources.exit_normal;
            this.pbExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExit.Location = new System.Drawing.Point(1047, 12);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(32, 25);
            this.pbExit.TabIndex = 2;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            this.pbExit.MouseLeave += new System.EventHandler(this.pbExit_MouseLeave);
            this.pbExit.MouseHover += new System.EventHandler(this.pbExit_MouseHover);
            // 
            // loginControl1
            // 
            this.loginControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginControl1.Location = new System.Drawing.Point(161, 47);
            this.loginControl1.Name = "loginControl1";
            this.loginControl1.Size = new System.Drawing.Size(1109, 623);
            this.loginControl1.TabIndex = 7;
            // 
            // homeControl1
            // 
            this.homeControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.homeControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.homeControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeControl1.BackgroundImage")));
            this.homeControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeControl1.Location = new System.Drawing.Point(161, 47);
            this.homeControl1.Margin = new System.Windows.Forms.Padding(1);
            this.homeControl1.Name = "homeControl1";
            this.homeControl1.Size = new System.Drawing.Size(1109, 623);
            this.homeControl1.TabIndex = 2;
            // 
            // progressControl1
            // 
            this.progressControl1.AutoScroll = true;
            this.progressControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.progressControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressControl1.Location = new System.Drawing.Point(161, 47);
            this.progressControl1.Name = "progressControl1";
            this.progressControl1.Size = new System.Drawing.Size(1109, 623);
            this.progressControl1.TabIndex = 5;
            // 
            // nutritionControl1
            // 
            this.nutritionControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nutritionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nutritionControl1.Location = new System.Drawing.Point(161, 47);
            this.nutritionControl1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.nutritionControl1.Name = "nutritionControl1";
            this.nutritionControl1.Size = new System.Drawing.Size(1109, 623);
            this.nutritionControl1.TabIndex = 4;
            // 
            // analyticsControl1
            // 
            this.analyticsControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.analyticsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.analyticsControl1.Location = new System.Drawing.Point(161, 47);
            this.analyticsControl1.Name = "analyticsControl1";
            this.analyticsControl1.Size = new System.Drawing.Size(1109, 623);
            this.analyticsControl1.TabIndex = 8;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1270, 670);
            this.Controls.Add(this.loginControl1);
            this.Controls.Add(this.homeControl1);
            this.Controls.Add(this.progressControl1);
            this.Controls.Add(this.nutritionControl1);
            this.Controls.Add(this.analyticsControl1);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.pnMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnDiet;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.PictureBox pbResize;
        private System.Windows.Forms.PictureBox pbExit;
        private HomeControl homeControl1;
        private NutritionControl nutritionControl1;
        private System.Windows.Forms.Button btnProgress;
        private ProgressControl progressControl1;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.Button btnManage;
        private ManageControl manageControl1;
        private LoginControl loginControl1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAnalytics;
        private System.Windows.Forms.Label lblMainEmail;
        private AnalyticsControl analyticsControl1;
    }
}


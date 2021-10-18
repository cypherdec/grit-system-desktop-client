
namespace DemoGritLogin
{
    partial class AnalyticsControl
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
            this.btnProgressAnalytics = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClientAnalytics = new System.Windows.Forms.Button();
            this.btnCoachAnalytics = new System.Windows.Forms.Button();
            this.btnOverview = new System.Windows.Forms.Button();
            this.analyticsOverview1 = new DemoGritLogin.AnalyticsOverview();
            this.analyticsCoach1 = new DemoGritLogin.AnalyticsCoach();
            this.analyticsClient1 = new DemoGritLogin.AnalyticsClient();
            this.analyticsProgress1 = new DemoGritLogin.AnalyticsProgress();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.buttonPanel);
            this.panel1.Controls.Add(this.btnProgressAnalytics);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClientAnalytics);
            this.panel1.Controls.Add(this.btnCoachAnalytics);
            this.panel1.Controls.Add(this.btnOverview);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1109, 72);
            this.panel1.TabIndex = 0;
            // 
            // buttonPanel
            // 
            this.buttonPanel.BackColor = System.Drawing.Color.Yellow;
            this.buttonPanel.Location = new System.Drawing.Point(281, 17);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(159, 5);
            this.buttonPanel.TabIndex = 4;
            // 
            // btnProgressAnalytics
            // 
            this.btnProgressAnalytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProgressAnalytics.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProgressAnalytics.ForeColor = System.Drawing.Color.Yellow;
            this.btnProgressAnalytics.Location = new System.Drawing.Point(836, 17);
            this.btnProgressAnalytics.Name = "btnProgressAnalytics";
            this.btnProgressAnalytics.Size = new System.Drawing.Size(159, 43);
            this.btnProgressAnalytics.TabIndex = 6;
            this.btnProgressAnalytics.Text = "Progress Analytics";
            this.btnProgressAnalytics.UseVisualStyleBackColor = true;
            this.btnProgressAnalytics.Click += new System.EventHandler(this.btnProgressAnalytics_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "GRIT Analytics";
            // 
            // btnClientAnalytics
            // 
            this.btnClientAnalytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientAnalytics.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientAnalytics.ForeColor = System.Drawing.Color.Yellow;
            this.btnClientAnalytics.Location = new System.Drawing.Point(651, 17);
            this.btnClientAnalytics.Name = "btnClientAnalytics";
            this.btnClientAnalytics.Size = new System.Drawing.Size(159, 43);
            this.btnClientAnalytics.TabIndex = 6;
            this.btnClientAnalytics.Text = "Client Analytics";
            this.btnClientAnalytics.UseVisualStyleBackColor = true;
            this.btnClientAnalytics.Click += new System.EventHandler(this.btnClientAnalytics_Click);
            // 
            // btnCoachAnalytics
            // 
            this.btnCoachAnalytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoachAnalytics.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoachAnalytics.ForeColor = System.Drawing.Color.Yellow;
            this.btnCoachAnalytics.Location = new System.Drawing.Point(466, 17);
            this.btnCoachAnalytics.Name = "btnCoachAnalytics";
            this.btnCoachAnalytics.Size = new System.Drawing.Size(159, 43);
            this.btnCoachAnalytics.TabIndex = 6;
            this.btnCoachAnalytics.Text = "Coach Analytics";
            this.btnCoachAnalytics.UseVisualStyleBackColor = true;
            this.btnCoachAnalytics.Click += new System.EventHandler(this.btnCoachAnalytics_Click);
            // 
            // btnOverview
            // 
            this.btnOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOverview.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOverview.ForeColor = System.Drawing.Color.Yellow;
            this.btnOverview.Location = new System.Drawing.Point(281, 17);
            this.btnOverview.Name = "btnOverview";
            this.btnOverview.Size = new System.Drawing.Size(159, 43);
            this.btnOverview.TabIndex = 5;
            this.btnOverview.Text = "Overview";
            this.btnOverview.UseVisualStyleBackColor = true;
            this.btnOverview.Click += new System.EventHandler(this.btnOverview_Click);
            // 
            // analyticsOverview1
            // 
            this.analyticsOverview1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.analyticsOverview1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.analyticsOverview1.Location = new System.Drawing.Point(0, 72);
            this.analyticsOverview1.Name = "analyticsOverview1";
            this.analyticsOverview1.Size = new System.Drawing.Size(1109, 551);
            this.analyticsOverview1.TabIndex = 1;
            // 
            // analyticsCoach1
            // 
            this.analyticsCoach1.AutoScroll = true;
            this.analyticsCoach1.AutoScrollMargin = new System.Drawing.Size(0, 10);
            this.analyticsCoach1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.analyticsCoach1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.analyticsCoach1.Location = new System.Drawing.Point(0, 72);
            this.analyticsCoach1.Name = "analyticsCoach1";
            this.analyticsCoach1.Size = new System.Drawing.Size(1109, 551);
            this.analyticsCoach1.TabIndex = 2;
            // 
            // analyticsClient1
            // 
            this.analyticsClient1.AutoScroll = true;
            this.analyticsClient1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.analyticsClient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.analyticsClient1.Location = new System.Drawing.Point(0, 72);
            this.analyticsClient1.Name = "analyticsClient1";
            this.analyticsClient1.Size = new System.Drawing.Size(1109, 551);
            this.analyticsClient1.TabIndex = 3;
            // 
            // analyticsProgress1
            // 
            this.analyticsProgress1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.analyticsProgress1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.analyticsProgress1.Location = new System.Drawing.Point(0, 72);
            this.analyticsProgress1.Name = "analyticsProgress1";
            this.analyticsProgress1.Size = new System.Drawing.Size(1109, 551);
            this.analyticsProgress1.TabIndex = 4;
            // 
            // AnalyticsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.analyticsProgress1);
            this.Controls.Add(this.analyticsClient1);
            this.Controls.Add(this.analyticsCoach1);
            this.Controls.Add(this.analyticsOverview1);
            this.Controls.Add(this.panel1);
            this.Name = "AnalyticsControl";
            this.Size = new System.Drawing.Size(1109, 623);
            this.Load += new System.EventHandler(this.AnalyticsControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProgressAnalytics;
        private System.Windows.Forms.Button btnClientAnalytics;
        private System.Windows.Forms.Button btnCoachAnalytics;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button btnOverview;
        private AnalyticsOverview analyticsOverview1;
        private AnalyticsCoach analyticsCoach1;
        private AnalyticsClient analyticsClient1;
        private AnalyticsProgress analyticsProgress1;
    }
}

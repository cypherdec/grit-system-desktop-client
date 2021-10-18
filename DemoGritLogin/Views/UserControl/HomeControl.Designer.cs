namespace DemoGritLogin
{
    partial class HomeControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeControl));
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.txtRegistered = new System.Windows.Forms.Label();
            this.lblRegistered = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(12, 13);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 20);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "date";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.BackColor = System.Drawing.Color.Transparent;
            this.lblDay.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.ForeColor = System.Drawing.Color.White;
            this.lblDay.Location = new System.Drawing.Point(64, 50);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(47, 22);
            this.lblDay.TabIndex = 0;
            this.lblDay.Text = "day";
            // 
            // txtRegistered
            // 
            this.txtRegistered.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtRegistered.AutoSize = true;
            this.txtRegistered.BackColor = System.Drawing.Color.Transparent;
            this.txtRegistered.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistered.ForeColor = System.Drawing.Color.White;
            this.txtRegistered.Location = new System.Drawing.Point(429, 531);
            this.txtRegistered.Name = "txtRegistered";
            this.txtRegistered.Size = new System.Drawing.Size(21, 24);
            this.txtRegistered.TabIndex = 1;
            this.txtRegistered.Text = "_";
            // 
            // lblRegistered
            // 
            this.lblRegistered.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRegistered.AutoSize = true;
            this.lblRegistered.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistered.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistered.ForeColor = System.Drawing.Color.White;
            this.lblRegistered.Location = new System.Drawing.Point(456, 531);
            this.lblRegistered.Name = "lblRegistered";
            this.lblRegistered.Size = new System.Drawing.Size(196, 24);
            this.lblRegistered.TabIndex = 1;
            this.lblRegistered.Text = "Clients Registered ";
            // 
            // HomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblRegistered);
            this.Controls.Add(this.txtRegistered);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblDate);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "HomeControl";
            this.Size = new System.Drawing.Size(1109, 623);
            this.Load += new System.EventHandler(this.HomeControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label txtRegistered;
        private System.Windows.Forms.Label lblRegistered;
    }
}

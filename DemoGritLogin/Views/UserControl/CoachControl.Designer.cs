
namespace DemoGritLogin
{
    partial class CoachControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRefreshCoach = new System.Windows.Forms.Button();
            this.gbxAddCoach = new System.Windows.Forms.GroupBox();
            this.btnAddNewCoach = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNewCoachPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNewCoachEmail = new System.Windows.Forms.TextBox();
            this.txtNewCoachTele = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNewCoachLname = new System.Windows.Forms.TextBox();
            this.txtNewCoachFname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridViewCoaches = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUpdateCurrentPass = new System.Windows.Forms.TextBox();
            this.txtUpdateConfirmPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxUpdateLogin = new System.Windows.Forms.GroupBox();
            this.lblCoachEmail = new System.Windows.Forms.Label();
            this.btnUpdateLogin = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUpdateNewPass = new System.Windows.Forms.TextBox();
            this.btnDeleteCoach = new System.Windows.Forms.Button();
            this.gbxAddCoach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCoaches)).BeginInit();
            this.gbxUpdateLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefreshCoach
            // 
            this.btnRefreshCoach.BackColor = System.Drawing.Color.Yellow;
            this.btnRefreshCoach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshCoach.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshCoach.Location = new System.Drawing.Point(3, 5);
            this.btnRefreshCoach.Name = "btnRefreshCoach";
            this.btnRefreshCoach.Size = new System.Drawing.Size(121, 42);
            this.btnRefreshCoach.TabIndex = 10;
            this.btnRefreshCoach.Text = "Refresh Data";
            this.btnRefreshCoach.UseVisualStyleBackColor = false;
            this.btnRefreshCoach.Click += new System.EventHandler(this.btnRefreshCoach_Click);
            // 
            // gbxAddCoach
            // 
            this.gbxAddCoach.Controls.Add(this.btnAddNewCoach);
            this.gbxAddCoach.Controls.Add(this.label9);
            this.gbxAddCoach.Controls.Add(this.txtNewCoachPass);
            this.gbxAddCoach.Controls.Add(this.label6);
            this.gbxAddCoach.Controls.Add(this.txtNewCoachEmail);
            this.gbxAddCoach.Controls.Add(this.txtNewCoachTele);
            this.gbxAddCoach.Controls.Add(this.label4);
            this.gbxAddCoach.Controls.Add(this.label5);
            this.gbxAddCoach.Controls.Add(this.txtNewCoachLname);
            this.gbxAddCoach.Controls.Add(this.txtNewCoachFname);
            this.gbxAddCoach.Controls.Add(this.label2);
            this.gbxAddCoach.Controls.Add(this.label1);
            this.gbxAddCoach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAddCoach.Location = new System.Drawing.Point(238, 253);
            this.gbxAddCoach.Name = "gbxAddCoach";
            this.gbxAddCoach.Size = new System.Drawing.Size(632, 415);
            this.gbxAddCoach.TabIndex = 8;
            this.gbxAddCoach.TabStop = false;
            // 
            // btnAddNewCoach
            // 
            this.btnAddNewCoach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddNewCoach.BackColor = System.Drawing.Color.Yellow;
            this.btnAddNewCoach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewCoach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCoach.Location = new System.Drawing.Point(190, 337);
            this.btnAddNewCoach.Name = "btnAddNewCoach";
            this.btnAddNewCoach.Size = new System.Drawing.Size(261, 50);
            this.btnAddNewCoach.TabIndex = 12;
            this.btnAddNewCoach.Text = "Save";
            this.btnAddNewCoach.UseVisualStyleBackColor = false;
            this.btnAddNewCoach.Click += new System.EventHandler(this.btnAddNewCoach_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "Add New Coach";
            // 
            // txtNewCoachPass
            // 
            this.txtNewCoachPass.BackColor = System.Drawing.Color.Black;
            this.txtNewCoachPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewCoachPass.ForeColor = System.Drawing.Color.Yellow;
            this.txtNewCoachPass.Location = new System.Drawing.Point(272, 285);
            this.txtNewCoachPass.Name = "txtNewCoachPass";
            this.txtNewCoachPass.PasswordChar = '*';
            this.txtNewCoachPass.Size = new System.Drawing.Size(179, 24);
            this.txtNewCoachPass.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(187, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Password:";
            // 
            // txtNewCoachEmail
            // 
            this.txtNewCoachEmail.BackColor = System.Drawing.Color.Black;
            this.txtNewCoachEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewCoachEmail.ForeColor = System.Drawing.Color.Yellow;
            this.txtNewCoachEmail.Location = new System.Drawing.Point(272, 229);
            this.txtNewCoachEmail.Name = "txtNewCoachEmail";
            this.txtNewCoachEmail.Size = new System.Drawing.Size(179, 24);
            this.txtNewCoachEmail.TabIndex = 10;
            // 
            // txtNewCoachTele
            // 
            this.txtNewCoachTele.BackColor = System.Drawing.Color.Black;
            this.txtNewCoachTele.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewCoachTele.ForeColor = System.Drawing.Color.Yellow;
            this.txtNewCoachTele.Location = new System.Drawing.Point(272, 173);
            this.txtNewCoachTele.Name = "txtNewCoachTele";
            this.txtNewCoachTele.Size = new System.Drawing.Size(179, 24);
            this.txtNewCoachTele.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(217, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(185, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telephone:";
            // 
            // txtNewCoachLname
            // 
            this.txtNewCoachLname.BackColor = System.Drawing.Color.Black;
            this.txtNewCoachLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewCoachLname.ForeColor = System.Drawing.Color.Yellow;
            this.txtNewCoachLname.Location = new System.Drawing.Point(272, 117);
            this.txtNewCoachLname.Name = "txtNewCoachLname";
            this.txtNewCoachLname.Size = new System.Drawing.Size(179, 24);
            this.txtNewCoachLname.TabIndex = 6;
            // 
            // txtNewCoachFname
            // 
            this.txtNewCoachFname.BackColor = System.Drawing.Color.Black;
            this.txtNewCoachFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewCoachFname.ForeColor = System.Drawing.Color.Yellow;
            this.txtNewCoachFname.Location = new System.Drawing.Point(272, 61);
            this.txtNewCoachFname.Name = "txtNewCoachFname";
            this.txtNewCoachFname.Size = new System.Drawing.Size(179, 24);
            this.txtNewCoachFname.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // gridViewCoaches
            // 
            this.gridViewCoaches.AllowUserToAddRows = false;
            this.gridViewCoaches.AllowUserToDeleteRows = false;
            this.gridViewCoaches.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridViewCoaches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewCoaches.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridViewCoaches.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewCoaches.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridViewCoaches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewCoaches.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridViewCoaches.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gridViewCoaches.Location = new System.Drawing.Point(3, 53);
            this.gridViewCoaches.MultiSelect = false;
            this.gridViewCoaches.Name = "gridViewCoaches";
            this.gridViewCoaches.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewCoaches.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.gridViewCoaches.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridViewCoaches.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewCoaches.ShowCellErrors = false;
            this.gridViewCoaches.ShowCellToolTips = false;
            this.gridViewCoaches.ShowEditingIcon = false;
            this.gridViewCoaches.ShowRowErrors = false;
            this.gridViewCoaches.Size = new System.Drawing.Size(1052, 194);
            this.gridViewCoaches.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(156, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 18);
            this.label10.TabIndex = 1;
            this.label10.Text = "Current Password:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(152, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "Confirm Password:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(175, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "New Password:";
            // 
            // txtUpdateCurrentPass
            // 
            this.txtUpdateCurrentPass.BackColor = System.Drawing.Color.Black;
            this.txtUpdateCurrentPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateCurrentPass.ForeColor = System.Drawing.Color.Yellow;
            this.txtUpdateCurrentPass.Location = new System.Drawing.Point(294, 76);
            this.txtUpdateCurrentPass.Name = "txtUpdateCurrentPass";
            this.txtUpdateCurrentPass.PasswordChar = '*';
            this.txtUpdateCurrentPass.Size = new System.Drawing.Size(179, 24);
            this.txtUpdateCurrentPass.TabIndex = 6;
            // 
            // txtUpdateConfirmPass
            // 
            this.txtUpdateConfirmPass.BackColor = System.Drawing.Color.Black;
            this.txtUpdateConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateConfirmPass.ForeColor = System.Drawing.Color.Yellow;
            this.txtUpdateConfirmPass.Location = new System.Drawing.Point(294, 156);
            this.txtUpdateConfirmPass.Name = "txtUpdateConfirmPass";
            this.txtUpdateConfirmPass.PasswordChar = '*';
            this.txtUpdateConfirmPass.Size = new System.Drawing.Size(179, 24);
            this.txtUpdateConfirmPass.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(545, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "client id";
            this.label3.Visible = false;
            // 
            // gbxUpdateLogin
            // 
            this.gbxUpdateLogin.Controls.Add(this.lblCoachEmail);
            this.gbxUpdateLogin.Controls.Add(this.btnUpdateLogin);
            this.gbxUpdateLogin.Controls.Add(this.label12);
            this.gbxUpdateLogin.Controls.Add(this.txtUpdateNewPass);
            this.gbxUpdateLogin.Controls.Add(this.label3);
            this.gbxUpdateLogin.Controls.Add(this.txtUpdateConfirmPass);
            this.gbxUpdateLogin.Controls.Add(this.txtUpdateCurrentPass);
            this.gbxUpdateLogin.Controls.Add(this.label7);
            this.gbxUpdateLogin.Controls.Add(this.label8);
            this.gbxUpdateLogin.Controls.Add(this.label10);
            this.gbxUpdateLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxUpdateLogin.Location = new System.Drawing.Point(238, 686);
            this.gbxUpdateLogin.Name = "gbxUpdateLogin";
            this.gbxUpdateLogin.Size = new System.Drawing.Size(632, 296);
            this.gbxUpdateLogin.TabIndex = 10;
            this.gbxUpdateLogin.TabStop = false;
            // 
            // lblCoachEmail
            // 
            this.lblCoachEmail.AutoSize = true;
            this.lblCoachEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoachEmail.ForeColor = System.Drawing.Color.Yellow;
            this.lblCoachEmail.Location = new System.Drawing.Point(134, 20);
            this.lblCoachEmail.Name = "lblCoachEmail";
            this.lblCoachEmail.Size = new System.Drawing.Size(43, 18);
            this.lblCoachEmail.TabIndex = 16;
            this.lblCoachEmail.Text = "email";
            // 
            // btnUpdateLogin
            // 
            this.btnUpdateLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateLogin.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdateLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateLogin.Location = new System.Drawing.Point(155, 208);
            this.btnUpdateLogin.Name = "btnUpdateLogin";
            this.btnUpdateLogin.Size = new System.Drawing.Size(318, 50);
            this.btnUpdateLogin.TabIndex = 15;
            this.btnUpdateLogin.Text = "Update";
            this.btnUpdateLogin.UseVisualStyleBackColor = false;
            this.btnUpdateLogin.Click += new System.EventHandler(this.btnUpdateLogin_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Yellow;
            this.label12.Location = new System.Drawing.Point(6, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 18);
            this.label12.TabIndex = 15;
            this.label12.Text = "Update Login For";
            // 
            // txtUpdateNewPass
            // 
            this.txtUpdateNewPass.BackColor = System.Drawing.Color.Black;
            this.txtUpdateNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateNewPass.ForeColor = System.Drawing.Color.Yellow;
            this.txtUpdateNewPass.Location = new System.Drawing.Point(294, 117);
            this.txtUpdateNewPass.Name = "txtUpdateNewPass";
            this.txtUpdateNewPass.PasswordChar = '*';
            this.txtUpdateNewPass.Size = new System.Drawing.Size(179, 24);
            this.txtUpdateNewPass.TabIndex = 10;
            // 
            // btnDeleteCoach
            // 
            this.btnDeleteCoach.BackColor = System.Drawing.Color.Yellow;
            this.btnDeleteCoach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCoach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCoach.Location = new System.Drawing.Point(876, 253);
            this.btnDeleteCoach.Name = "btnDeleteCoach";
            this.btnDeleteCoach.Size = new System.Drawing.Size(140, 46);
            this.btnDeleteCoach.TabIndex = 11;
            this.btnDeleteCoach.Text = "Delete";
            this.btnDeleteCoach.UseVisualStyleBackColor = false;
            this.btnDeleteCoach.Click += new System.EventHandler(this.btnDeleteCoach_Click);
            // 
            // CoachControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.btnDeleteCoach);
            this.Controls.Add(this.gbxUpdateLogin);
            this.Controls.Add(this.btnRefreshCoach);
            this.Controls.Add(this.gbxAddCoach);
            this.Controls.Add(this.gridViewCoaches);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "CoachControl";
            this.Size = new System.Drawing.Size(1058, 552);
            this.Load += new System.EventHandler(this.CoachControl_Load);
            this.gbxAddCoach.ResumeLayout(false);
            this.gbxAddCoach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCoaches)).EndInit();
            this.gbxUpdateLogin.ResumeLayout(false);
            this.gbxUpdateLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRefreshCoach;
        private System.Windows.Forms.GroupBox gbxAddCoach;
        private System.Windows.Forms.TextBox txtNewCoachLname;
        private System.Windows.Forms.TextBox txtNewCoachFname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridViewCoaches;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNewCoachEmail;
        private System.Windows.Forms.TextBox txtNewCoachTele;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUpdateCurrentPass;
        private System.Windows.Forms.TextBox txtUpdateConfirmPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbxUpdateLogin;
        private System.Windows.Forms.TextBox txtUpdateNewPass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNewCoachPass;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnDeleteCoach;
        private System.Windows.Forms.Button btnAddNewCoach;
        private System.Windows.Forms.Button btnUpdateLogin;
        private System.Windows.Forms.Label lblCoachEmail;
    }
}

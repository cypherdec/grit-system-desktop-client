
namespace DemoGritLogin
{
    partial class ManageClientControl
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
            this.gridViewClients = new System.Windows.Forms.DataGridView();
            this.gbxEditClient = new System.Windows.Forms.GroupBox();
            this.lblEditClientID = new System.Windows.Forms.Label();
            this.btnUpdateClient = new System.Windows.Forms.Button();
            this.dtEditDOB = new System.Windows.Forms.DateTimePicker();
            this.cbxEditGender = new System.Windows.Forms.ComboBox();
            this.txtEditTele = new System.Windows.Forms.TextBox();
            this.txtEditEmail = new System.Windows.Forms.TextBox();
            this.txtEditLname = new System.Windows.Forms.TextBox();
            this.txtEditFname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxCoaches = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClients)).BeginInit();
            this.gbxEditClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridViewClients
            // 
            this.gridViewClients.AllowUserToAddRows = false;
            this.gridViewClients.AllowUserToDeleteRows = false;
            this.gridViewClients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridViewClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewClients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridViewClients.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewClients.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridViewClients.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gridViewClients.Location = new System.Drawing.Point(3, 48);
            this.gridViewClients.MultiSelect = false;
            this.gridViewClients.Name = "gridViewClients";
            this.gridViewClients.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewClients.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridViewClients.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewClients.ShowCellErrors = false;
            this.gridViewClients.ShowCellToolTips = false;
            this.gridViewClients.ShowEditingIcon = false;
            this.gridViewClients.ShowRowErrors = false;
            this.gridViewClients.Size = new System.Drawing.Size(1019, 385);
            this.gridViewClients.TabIndex = 1;
            // 
            // gbxEditClient
            // 
            this.gbxEditClient.Controls.Add(this.lblEditClientID);
            this.gbxEditClient.Controls.Add(this.btnUpdateClient);
            this.gbxEditClient.Controls.Add(this.dtEditDOB);
            this.gbxEditClient.Controls.Add(this.cbxCoaches);
            this.gbxEditClient.Controls.Add(this.cbxEditGender);
            this.gbxEditClient.Controls.Add(this.txtEditTele);
            this.gbxEditClient.Controls.Add(this.txtEditEmail);
            this.gbxEditClient.Controls.Add(this.txtEditLname);
            this.gbxEditClient.Controls.Add(this.label7);
            this.gbxEditClient.Controls.Add(this.txtEditFname);
            this.gbxEditClient.Controls.Add(this.label6);
            this.gbxEditClient.Controls.Add(this.label5);
            this.gbxEditClient.Controls.Add(this.label3);
            this.gbxEditClient.Controls.Add(this.label4);
            this.gbxEditClient.Controls.Add(this.label2);
            this.gbxEditClient.Controls.Add(this.label1);
            this.gbxEditClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEditClient.Location = new System.Drawing.Point(109, 465);
            this.gbxEditClient.Name = "gbxEditClient";
            this.gbxEditClient.Size = new System.Drawing.Size(719, 533);
            this.gbxEditClient.TabIndex = 3;
            this.gbxEditClient.TabStop = false;
            // 
            // lblEditClientID
            // 
            this.lblEditClientID.AutoSize = true;
            this.lblEditClientID.Location = new System.Drawing.Point(61, 105);
            this.lblEditClientID.Name = "lblEditClientID";
            this.lblEditClientID.Size = new System.Drawing.Size(62, 20);
            this.lblEditClientID.TabIndex = 9;
            this.lblEditClientID.Text = "client id";
            this.lblEditClientID.Visible = false;
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdateClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateClient.Location = new System.Drawing.Point(166, 459);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(354, 54);
            this.btnUpdateClient.TabIndex = 4;
            this.btnUpdateClient.Text = "Update Client Info";
            this.btnUpdateClient.UseVisualStyleBackColor = false;
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click);
            // 
            // dtEditDOB
            // 
            this.dtEditDOB.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dtEditDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEditDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEditDOB.Location = new System.Drawing.Point(311, 356);
            this.dtEditDOB.Name = "dtEditDOB";
            this.dtEditDOB.Size = new System.Drawing.Size(209, 26);
            this.dtEditDOB.TabIndex = 8;
            // 
            // cbxEditGender
            // 
            this.cbxEditGender.BackColor = System.Drawing.Color.Black;
            this.cbxEditGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEditGender.ForeColor = System.Drawing.Color.Yellow;
            this.cbxEditGender.FormattingEnabled = true;
            this.cbxEditGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbxEditGender.Location = new System.Drawing.Point(311, 228);
            this.cbxEditGender.Name = "cbxEditGender";
            this.cbxEditGender.Size = new System.Drawing.Size(209, 28);
            this.cbxEditGender.TabIndex = 7;
            // 
            // txtEditTele
            // 
            this.txtEditTele.BackColor = System.Drawing.Color.Black;
            this.txtEditTele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditTele.ForeColor = System.Drawing.Color.Yellow;
            this.txtEditTele.Location = new System.Drawing.Point(311, 292);
            this.txtEditTele.Name = "txtEditTele";
            this.txtEditTele.Size = new System.Drawing.Size(209, 26);
            this.txtEditTele.TabIndex = 6;
            // 
            // txtEditEmail
            // 
            this.txtEditEmail.BackColor = System.Drawing.Color.Black;
            this.txtEditEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditEmail.ForeColor = System.Drawing.Color.Yellow;
            this.txtEditEmail.Location = new System.Drawing.Point(311, 170);
            this.txtEditEmail.Name = "txtEditEmail";
            this.txtEditEmail.Size = new System.Drawing.Size(209, 26);
            this.txtEditEmail.TabIndex = 6;
            // 
            // txtEditLname
            // 
            this.txtEditLname.BackColor = System.Drawing.Color.Black;
            this.txtEditLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditLname.ForeColor = System.Drawing.Color.Yellow;
            this.txtEditLname.Location = new System.Drawing.Point(311, 110);
            this.txtEditLname.Name = "txtEditLname";
            this.txtEditLname.Size = new System.Drawing.Size(209, 26);
            this.txtEditLname.TabIndex = 6;
            // 
            // txtEditFname
            // 
            this.txtEditFname.BackColor = System.Drawing.Color.Black;
            this.txtEditFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditFname.ForeColor = System.Drawing.Color.Yellow;
            this.txtEditFname.Location = new System.Drawing.Point(311, 46);
            this.txtEditFname.Name = "txtEditFname";
            this.txtEditFname.Size = new System.Drawing.Size(209, 26);
            this.txtEditFname.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(224, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Gender:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(203, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telephone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(239, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(185, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date Of Birth:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Yellow;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(3, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(151, 42);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh Data";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnEditClient
            // 
            this.btnEditClient.BackColor = System.Drawing.Color.Yellow;
            this.btnEditClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditClient.Location = new System.Drawing.Point(834, 465);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(150, 38);
            this.btnEditClient.TabIndex = 2;
            this.btnEditClient.Text = "Edit Client";
            this.btnEditClient.UseVisualStyleBackColor = false;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.BackColor = System.Drawing.Color.Yellow;
            this.btnDeleteClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClient.Location = new System.Drawing.Point(834, 511);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(150, 38);
            this.btnDeleteClient.TabIndex = 4;
            this.btnDeleteClient.Text = "Delete Client";
            this.btnDeleteClient.UseVisualStyleBackColor = false;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(162, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Assigned Coach:";
            // 
            // cbxCoaches
            // 
            this.cbxCoaches.BackColor = System.Drawing.Color.Black;
            this.cbxCoaches.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCoaches.ForeColor = System.Drawing.Color.Yellow;
            this.cbxCoaches.FormattingEnabled = true;
            this.cbxCoaches.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbxCoaches.Location = new System.Drawing.Point(311, 411);
            this.cbxCoaches.Name = "cbxCoaches";
            this.cbxCoaches.Size = new System.Drawing.Size(209, 28);
            this.cbxCoaches.TabIndex = 7;
            // 
            // ManageClientControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 10);
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDeleteClient);
            this.Controls.Add(this.gbxEditClient);
            this.Controls.Add(this.btnEditClient);
            this.Controls.Add(this.gridViewClients);
            this.Name = "ManageClientControl";
            this.Size = new System.Drawing.Size(1058, 552);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClients)).EndInit();
            this.gbxEditClient.ResumeLayout(false);
            this.gbxEditClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView gridViewClients;
        private System.Windows.Forms.GroupBox gbxEditClient;
        private System.Windows.Forms.TextBox txtEditTele;
        private System.Windows.Forms.TextBox txtEditLname;
        private System.Windows.Forms.TextBox txtEditFname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateClient;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblEditClientID;
        private System.Windows.Forms.DateTimePicker dtEditDOB;
        private System.Windows.Forms.ComboBox cbxEditGender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEditClient;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.TextBox txtEditEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxCoaches;
        private System.Windows.Forms.Label label7;
    }
}

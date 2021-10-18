namespace DemoGritLogin
{
    partial class ClientControl
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label teleLabel;
            System.Windows.Forms.Label currentWeightLabel;
            System.Windows.Forms.Label heightLabel;
            System.Windows.Forms.Label bMILabel;
            System.Windows.Forms.Label trainingGoalLabel;
            System.Windows.Forms.Label currentDateLabel;
            System.Windows.Forms.Label lbBmiRating;
            System.Windows.Forms.Label label1;
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtTele = new System.Windows.Forms.TextBox();
            this.txtCweight = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtBmi = new System.Windows.Forms.TextBox();
            this.dtCdate = new System.Windows.Forms.DateTimePicker();
            this.cbxTgoal = new System.Windows.Forms.ComboBox();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtBmiRating = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtDOB = new System.Windows.Forms.DateTimePicker();
            this.lblDOB = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cbxCoaches = new System.Windows.Forms.ComboBox();
            this.lblCoach = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            teleLabel = new System.Windows.Forms.Label();
            currentWeightLabel = new System.Windows.Forms.Label();
            heightLabel = new System.Windows.Forms.Label();
            bMILabel = new System.Windows.Forms.Label();
            trainingGoalLabel = new System.Windows.Forms.Label();
            currentDateLabel = new System.Windows.Forms.Label();
            lbBmiRating = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            firstNameLabel.Location = new System.Drawing.Point(366, 14);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(90, 20);
            firstNameLabel.TabIndex = 4;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lastNameLabel.Location = new System.Drawing.Point(366, 56);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(90, 20);
            lastNameLabel.TabIndex = 6;
            lastNameLabel.Text = "Last Name:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            genderLabel.Location = new System.Drawing.Point(366, 182);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(67, 20);
            genderLabel.TabIndex = 8;
            genderLabel.Text = "Gender:";
            // 
            // teleLabel
            // 
            teleLabel.AutoSize = true;
            teleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            teleLabel.Location = new System.Drawing.Point(366, 98);
            teleLabel.Name = "teleLabel";
            teleLabel.Size = new System.Drawing.Size(43, 20);
            teleLabel.TabIndex = 10;
            teleLabel.Text = "Tele:";
            // 
            // currentWeightLabel
            // 
            currentWeightLabel.AutoSize = true;
            currentWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            currentWeightLabel.Location = new System.Drawing.Point(366, 266);
            currentWeightLabel.Name = "currentWeightLabel";
            currentWeightLabel.Size = new System.Drawing.Size(151, 20);
            currentWeightLabel.TabIndex = 12;
            currentWeightLabel.Text = "Current Weight (kg):";
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            heightLabel.Location = new System.Drawing.Point(366, 308);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new System.Drawing.Size(95, 20);
            heightLabel.TabIndex = 14;
            heightLabel.Text = "Height (cm):";
            // 
            // bMILabel
            // 
            bMILabel.AutoSize = true;
            bMILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bMILabel.Location = new System.Drawing.Point(366, 434);
            bMILabel.Name = "bMILabel";
            bMILabel.Size = new System.Drawing.Size(42, 20);
            bMILabel.TabIndex = 16;
            bMILabel.Text = "BMI:";
            // 
            // trainingGoalLabel
            // 
            trainingGoalLabel.AutoSize = true;
            trainingGoalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            trainingGoalLabel.Location = new System.Drawing.Point(366, 350);
            trainingGoalLabel.Name = "trainingGoalLabel";
            trainingGoalLabel.Size = new System.Drawing.Size(107, 20);
            trainingGoalLabel.TabIndex = 18;
            trainingGoalLabel.Text = "Training Goal:";
            // 
            // currentDateLabel
            // 
            currentDateLabel.AutoSize = true;
            currentDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            currentDateLabel.Location = new System.Drawing.Point(366, 392);
            currentDateLabel.Name = "currentDateLabel";
            currentDateLabel.Size = new System.Drawing.Size(105, 20);
            currentDateLabel.TabIndex = 20;
            currentDateLabel.Text = "Current Date:";
            // 
            // lbBmiRating
            // 
            lbBmiRating.AutoSize = true;
            lbBmiRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbBmiRating.Location = new System.Drawing.Point(366, 476);
            lbBmiRating.Name = "lbBmiRating";
            lbBmiRating.Size = new System.Drawing.Size(93, 20);
            lbBmiRating.TabIndex = 27;
            lbBmiRating.Text = "BMI Rating:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(366, 140);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(52, 20);
            label1.TabIndex = 10;
            label1.Text = "Email:";
            // 
            // txtFname
            // 
            this.txtFname.BackColor = System.Drawing.Color.Black;
            this.txtFname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFname.ForeColor = System.Drawing.Color.Yellow;
            this.txtFname.Location = new System.Drawing.Point(523, 15);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(219, 19);
            this.txtFname.TabIndex = 5;
            // 
            // txtLname
            // 
            this.txtLname.BackColor = System.Drawing.Color.Black;
            this.txtLname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLname.ForeColor = System.Drawing.Color.Yellow;
            this.txtLname.Location = new System.Drawing.Point(523, 57);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(219, 19);
            this.txtLname.TabIndex = 7;
            // 
            // txtTele
            // 
            this.txtTele.BackColor = System.Drawing.Color.Black;
            this.txtTele.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTele.ForeColor = System.Drawing.Color.Yellow;
            this.txtTele.Location = new System.Drawing.Point(523, 99);
            this.txtTele.Name = "txtTele";
            this.txtTele.Size = new System.Drawing.Size(219, 19);
            this.txtTele.TabIndex = 11;
            // 
            // txtCweight
            // 
            this.txtCweight.BackColor = System.Drawing.Color.Black;
            this.txtCweight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCweight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCweight.ForeColor = System.Drawing.Color.Yellow;
            this.txtCweight.Location = new System.Drawing.Point(523, 267);
            this.txtCweight.Name = "txtCweight";
            this.txtCweight.Size = new System.Drawing.Size(219, 19);
            this.txtCweight.TabIndex = 13;
            this.txtCweight.TextChanged += new System.EventHandler(this.txtCweight_TextChanged);
            // 
            // txtHeight
            // 
            this.txtHeight.BackColor = System.Drawing.Color.Black;
            this.txtHeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.ForeColor = System.Drawing.Color.Yellow;
            this.txtHeight.Location = new System.Drawing.Point(523, 309);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(219, 19);
            this.txtHeight.TabIndex = 15;
            this.txtHeight.TextChanged += new System.EventHandler(this.txtHeight_TextChanged);
            // 
            // txtBmi
            // 
            this.txtBmi.BackColor = System.Drawing.Color.Black;
            this.txtBmi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBmi.ForeColor = System.Drawing.Color.Yellow;
            this.txtBmi.Location = new System.Drawing.Point(523, 435);
            this.txtBmi.Name = "txtBmi";
            this.txtBmi.ReadOnly = true;
            this.txtBmi.Size = new System.Drawing.Size(219, 19);
            this.txtBmi.TabIndex = 17;
            // 
            // dtCdate
            // 
            this.dtCdate.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dtCdate.CalendarTitleBackColor = System.Drawing.Color.DimGray;
            this.dtCdate.CalendarTitleForeColor = System.Drawing.Color.Yellow;
            this.dtCdate.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.dtCdate.Checked = false;
            this.dtCdate.CustomFormat = "";
            this.dtCdate.Enabled = false;
            this.dtCdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtCdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCdate.Location = new System.Drawing.Point(523, 389);
            this.dtCdate.Name = "dtCdate";
            this.dtCdate.Size = new System.Drawing.Size(219, 26);
            this.dtCdate.TabIndex = 21;
            // 
            // cbxTgoal
            // 
            this.cbxTgoal.BackColor = System.Drawing.Color.Black;
            this.cbxTgoal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTgoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxTgoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTgoal.ForeColor = System.Drawing.Color.Yellow;
            this.cbxTgoal.Items.AddRange(new object[] {
            "Weight Loss",
            "Weight Gain"});
            this.cbxTgoal.Location = new System.Drawing.Point(523, 346);
            this.cbxTgoal.Name = "cbxTgoal";
            this.cbxTgoal.Size = new System.Drawing.Size(219, 28);
            this.cbxTgoal.TabIndex = 23;
            // 
            // cbxGender
            // 
            this.cbxGender.BackColor = System.Drawing.Color.Black;
            this.cbxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGender.ForeColor = System.Drawing.Color.Yellow;
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbxGender.Location = new System.Drawing.Point(523, 178);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(219, 28);
            this.cbxGender.TabIndex = 22;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Yellow;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(523, 513);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(219, 34);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtBmiRating
            // 
            this.txtBmiRating.BackColor = System.Drawing.Color.Black;
            this.txtBmiRating.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBmiRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBmiRating.ForeColor = System.Drawing.Color.Yellow;
            this.txtBmiRating.Location = new System.Drawing.Point(523, 477);
            this.txtBmiRating.Name = "txtBmiRating";
            this.txtBmiRating.ReadOnly = true;
            this.txtBmiRating.Size = new System.Drawing.Size(219, 19);
            this.txtBmiRating.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1095, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(14, 552);
            this.panel1.TabIndex = 28;
            // 
            // dtDOB
            // 
            this.dtDOB.CalendarFont = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDOB.Location = new System.Drawing.Point(523, 221);
            this.dtDOB.Name = "dtDOB";
            this.dtDOB.Size = new System.Drawing.Size(219, 26);
            this.dtDOB.TabIndex = 29;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(366, 224);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(110, 20);
            this.lblDOB.TabIndex = 30;
            this.lblDOB.Text = "Date Of Birth: ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Black;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Yellow;
            this.txtEmail.Location = new System.Drawing.Point(523, 141);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(219, 19);
            this.txtEmail.TabIndex = 11;
            // 
            // cbxCoaches
            // 
            this.cbxCoaches.BackColor = System.Drawing.Color.Black;
            this.cbxCoaches.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCoaches.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxCoaches.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCoaches.ForeColor = System.Drawing.Color.Yellow;
            this.cbxCoaches.FormattingEnabled = true;
            this.cbxCoaches.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbxCoaches.Location = new System.Drawing.Point(215, 516);
            this.cbxCoaches.Name = "cbxCoaches";
            this.cbxCoaches.Size = new System.Drawing.Size(261, 28);
            this.cbxCoaches.TabIndex = 31;
            // 
            // lblCoach
            // 
            this.lblCoach.AutoSize = true;
            this.lblCoach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCoach.Location = new System.Drawing.Point(104, 519);
            this.lblCoach.Name = "lblCoach";
            this.lblCoach.Size = new System.Drawing.Size(105, 20);
            this.lblCoach.TabIndex = 32;
            this.lblCoach.Text = "Coach Name:";
            // 
            // ClientControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.lblCoach);
            this.Controls.Add(this.cbxCoaches);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.dtDOB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(lbBmiRating);
            this.Controls.Add(this.txtBmiRating);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(genderLabel);
            this.Controls.Add(label1);
            this.Controls.Add(teleLabel);
            this.Controls.Add(currentWeightLabel);
            this.Controls.Add(heightLabel);
            this.Controls.Add(trainingGoalLabel);
            this.Controls.Add(currentDateLabel);
            this.Controls.Add(this.cbxTgoal);
            this.Controls.Add(this.cbxGender);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTele);
            this.Controls.Add(this.txtCweight);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(bMILabel);
            this.Controls.Add(this.txtBmi);
            this.Controls.Add(this.dtCdate);
            this.Name = "ClientControl";
            this.Size = new System.Drawing.Size(1109, 552);
            this.Load += new System.EventHandler(this.ClientControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtTele;
        private System.Windows.Forms.TextBox txtCweight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtBmi;
        private System.Windows.Forms.DateTimePicker dtCdate;
        private System.Windows.Forms.ComboBox cbxTgoal;
        private System.Windows.Forms.ComboBox cbxGender;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtBmiRating;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtDOB;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cbxCoaches;
        private System.Windows.Forms.Label lblCoach;
    }
}

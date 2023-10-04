namespace Library_Mgmt
{
    partial class View_Students
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
            this.paneladdStudent = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtrefresh = new System.Windows.Forms.Button();
            this.PnlImage = new System.Windows.Forms.Panel();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.picStudent = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtEnterdata = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSearchby = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlUpdate = new System.Windows.Forms.Panel();
            this.chkbImage = new System.Windows.Forms.CheckBox();
            this.txtSemester = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtEmailId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtenrollmentNo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvViewStudent = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paneladdStudent.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PnlImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).BeginInit();
            this.panel3.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // paneladdStudent
            // 
            this.paneladdStudent.BackColor = System.Drawing.Color.RoyalBlue;
            this.paneladdStudent.Controls.Add(this.label11);
            this.paneladdStudent.Controls.Add(this.btnClose);
            this.paneladdStudent.Controls.Add(this.panel1);
            this.paneladdStudent.Location = new System.Drawing.Point(0, 0);
            this.paneladdStudent.Name = "paneladdStudent";
            this.paneladdStudent.Size = new System.Drawing.Size(1367, 750);
            this.paneladdStudent.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(8, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(315, 31);
            this.label11.TabIndex = 51;
            this.label11.Text = "View Student Here....";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnClose.Image = global::Library_Mgmt.Properties.Resources.CLOSE;
            this.btnClose.Location = new System.Drawing.Point(1329, 3);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(33, 27);
            this.btnClose.TabIndex = 37;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.txtrefresh);
            this.panel1.Controls.Add(this.PnlImage);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pnlUpdate);
            this.panel1.Controls.Add(this.dgvViewStudent);
            this.panel1.Location = new System.Drawing.Point(10, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1346, 706);
            this.panel1.TabIndex = 36;
            // 
            // txtrefresh
            // 
            this.txtrefresh.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtrefresh.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrefresh.ForeColor = System.Drawing.Color.White;
            this.txtrefresh.Location = new System.Drawing.Point(18, 247);
            this.txtrefresh.Name = "txtrefresh";
            this.txtrefresh.Size = new System.Drawing.Size(129, 33);
            this.txtrefresh.TabIndex = 3;
            this.txtrefresh.Text = "Refresh";
            this.txtrefresh.UseVisualStyleBackColor = false;
            this.txtrefresh.Click += new System.EventHandler(this.txtrefresh_Click);
            // 
            // PnlImage
            // 
            this.PnlImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlImage.Controls.Add(this.btnBrowse);
            this.PnlImage.Controls.Add(this.picStudent);
            this.PnlImage.Location = new System.Drawing.Point(18, 389);
            this.PnlImage.Name = "PnlImage";
            this.PnlImage.Size = new System.Drawing.Size(265, 304);
            this.PnlImage.TabIndex = 54;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(47, 234);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(167, 33);
            this.btnBrowse.TabIndex = 11;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // picStudent
            // 
            this.picStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picStudent.Location = new System.Drawing.Point(47, 33);
            this.picStudent.Name = "picStudent";
            this.picStudent.Size = new System.Drawing.Size(167, 183);
            this.picStudent.TabIndex = 53;
            this.picStudent.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.txtEnterdata);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cmbSearchby);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(18, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(265, 211);
            this.panel3.TabIndex = 53;
            // 
            // txtEnterdata
            // 
            this.txtEnterdata.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterdata.Location = new System.Drawing.Point(18, 138);
            this.txtEnterdata.Name = "txtEnterdata";
            this.txtEnterdata.Size = new System.Drawing.Size(224, 23);
            this.txtEnterdata.TabIndex = 2;
            this.txtEnterdata.TextChanged += new System.EventHandler(this.txtEnterdata_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(14, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 42;
            this.label2.Text = "Enter Data";
            // 
            // cmbSearchby
            // 
            this.cmbSearchby.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearchby.FormattingEnabled = true;
            this.cmbSearchby.Items.AddRange(new object[] {
            "Student Name",
            "Enrollment Number"});
            this.cmbSearchby.Location = new System.Drawing.Point(18, 57);
            this.cmbSearchby.Name = "cmbSearchby";
            this.cmbSearchby.Size = new System.Drawing.Size(224, 24);
            this.cmbSearchby.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(14, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 22);
            this.label1.TabIndex = 40;
            this.label1.Text = "Search By";
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlUpdate.Controls.Add(this.chkbImage);
            this.pnlUpdate.Controls.Add(this.txtSemester);
            this.pnlUpdate.Controls.Add(this.txtContactNo);
            this.pnlUpdate.Controls.Add(this.btnUpdate);
            this.pnlUpdate.Controls.Add(this.txtEmailId);
            this.pnlUpdate.Controls.Add(this.label12);
            this.pnlUpdate.Controls.Add(this.label13);
            this.pnlUpdate.Controls.Add(this.txtenrollmentNo);
            this.pnlUpdate.Controls.Add(this.label14);
            this.pnlUpdate.Controls.Add(this.label15);
            this.pnlUpdate.Controls.Add(this.label16);
            this.pnlUpdate.Controls.Add(this.txtDepartment);
            this.pnlUpdate.Controls.Add(this.label17);
            this.pnlUpdate.Controls.Add(this.txtStudentName);
            this.pnlUpdate.Controls.Add(this.btnCancel);
            this.pnlUpdate.Controls.Add(this.btnDelete);
            this.pnlUpdate.Location = new System.Drawing.Point(298, 394);
            this.pnlUpdate.Name = "pnlUpdate";
            this.pnlUpdate.Size = new System.Drawing.Size(1030, 299);
            this.pnlUpdate.TabIndex = 52;
            // 
            // chkbImage
            // 
            this.chkbImage.AutoSize = true;
            this.chkbImage.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.chkbImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkbImage.Location = new System.Drawing.Point(236, 178);
            this.chkbImage.Name = "chkbImage";
            this.chkbImage.Size = new System.Drawing.Size(245, 26);
            this.chkbImage.TabIndex = 10;
            this.chkbImage.Text = "If You want to change Image ";
            this.chkbImage.UseVisualStyleBackColor = true;
            this.chkbImage.CheckedChanged += new System.EventHandler(this.chkbImage_CheckedChanged);
            // 
            // txtSemester
            // 
            this.txtSemester.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSemester.Location = new System.Drawing.Point(657, 32);
            this.txtSemester.Name = "txtSemester";
            this.txtSemester.Size = new System.Drawing.Size(266, 23);
            this.txtSemester.TabIndex = 5;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNo.Location = new System.Drawing.Point(657, 81);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(266, 23);
            this.txtContactNo.TabIndex = 7;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(159, 234);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(172, 33);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtEmailId
            // 
            this.txtEmailId.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailId.Location = new System.Drawing.Point(657, 130);
            this.txtEmailId.Name = "txtEmailId";
            this.txtEmailId.Size = new System.Drawing.Size(266, 23);
            this.txtEmailId.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(543, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 22);
            this.label12.TabIndex = 62;
            this.label12.Text = "Contact No.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(568, 132);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 22);
            this.label13.TabIndex = 61;
            this.label13.Text = "Email Id";
            // 
            // txtenrollmentNo
            // 
            this.txtenrollmentNo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtenrollmentNo.Location = new System.Drawing.Point(236, 81);
            this.txtenrollmentNo.Name = "txtenrollmentNo";
            this.txtenrollmentNo.Size = new System.Drawing.Size(266, 23);
            this.txtenrollmentNo.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(524, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 22);
            this.label14.TabIndex = 59;
            this.label14.Text = "Semester/Year";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label15.Location = new System.Drawing.Point(119, 132);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 22);
            this.label15.TabIndex = 58;
            this.label15.Text = "Department";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label16.Location = new System.Drawing.Point(95, 83);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(125, 22);
            this.label16.TabIndex = 57;
            this.label16.Text = "Enrollment No.";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartment.Location = new System.Drawing.Point(236, 130);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(266, 23);
            this.txtDepartment.TabIndex = 8;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label17.Location = new System.Drawing.Point(102, 34);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(118, 22);
            this.label17.TabIndex = 56;
            this.label17.Text = "Student Name";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentName.Location = new System.Drawing.Point(236, 32);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(266, 23);
            this.txtStudentName.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(751, 234);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(172, 33);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(455, 234);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(172, 33);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvViewStudent
            // 
            this.dgvViewStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvViewStudent.Location = new System.Drawing.Point(298, 17);
            this.dgvViewStudent.Name = "dgvViewStudent";
            this.dgvViewStudent.Size = new System.Drawing.Size(1030, 365);
            this.dgvViewStudent.TabIndex = 51;
            this.dgvViewStudent.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvViewStudent_MouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Student_Name";
            this.Column2.HeaderText = "Student Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Enrollment";
            this.Column3.HeaderText = "Enrollment";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Department";
            this.Column4.HeaderText = "Department";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Semester";
            this.Column5.HeaderText = "Semester";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Contact_No";
            this.Column6.HeaderText = "Contact No";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Email_Id";
            this.Column7.HeaderText = "Email";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Image_link";
            this.Column8.HeaderText = "Image link";
            this.Column8.Name = "Column8";
            // 
            // View_Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1365, 750);
            this.Controls.Add(this.paneladdStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "View_Students";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "View_Student";
            this.Load += new System.EventHandler(this.View_Students_Load);
            this.paneladdStudent.ResumeLayout(false);
            this.paneladdStudent.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.PnlImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlUpdate.ResumeLayout(false);
            this.pnlUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneladdStudent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtEnterdata;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSearchby;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvViewStudent;
        private System.Windows.Forms.TextBox txtSemester;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtEmailId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtenrollmentNo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Panel PnlImage;
        private System.Windows.Forms.CheckBox chkbImage;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox picStudent;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button txtrefresh;
        private System.Windows.Forms.Label label11;
    }
}
namespace Library_Mgmt
{
    partial class Return_Book
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtrefresh = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.txtEnrollmentNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlReturnUpdate = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtbookname = new System.Windows.Forms.TextBox();
            this.dgvIssuedBooks = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.paneladdStudent.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlReturnUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssuedBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // paneladdStudent
            // 
            this.paneladdStudent.BackColor = System.Drawing.Color.RoyalBlue;
            this.paneladdStudent.Controls.Add(this.label11);
            this.paneladdStudent.Controls.Add(this.panel1);
            this.paneladdStudent.Location = new System.Drawing.Point(0, 0);
            this.paneladdStudent.Name = "paneladdStudent";
            this.paneladdStudent.Size = new System.Drawing.Size(1365, 747);
            this.paneladdStudent.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(10, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(305, 31);
            this.label11.TabIndex = 50;
            this.label11.Text = "Return Book Here....";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.txtrefresh);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pnlReturnUpdate);
            this.panel1.Controls.Add(this.dgvIssuedBooks);
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
            this.txtrefresh.Location = new System.Drawing.Point(18, 232);
            this.txtrefresh.Name = "txtrefresh";
            this.txtrefresh.Size = new System.Drawing.Size(129, 33);
            this.txtrefresh.TabIndex = 3;
            this.txtrefresh.Text = "Refresh";
            this.txtrefresh.UseVisualStyleBackColor = false;
            this.txtrefresh.Click += new System.EventHandler(this.txtrefresh_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnSearchBook);
            this.panel3.Controls.Add(this.txtEnrollmentNo);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(18, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(265, 194);
            this.panel3.TabIndex = 53;
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearchBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchBook.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBook.ForeColor = System.Drawing.Color.White;
            this.btnSearchBook.Location = new System.Drawing.Point(41, 127);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(171, 33);
            this.btnSearchBook.TabIndex = 2;
            this.btnSearchBook.Text = "Search Book";
            this.btnSearchBook.UseVisualStyleBackColor = false;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // txtEnrollmentNo
            // 
            this.txtEnrollmentNo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnrollmentNo.Location = new System.Drawing.Point(18, 67);
            this.txtEnrollmentNo.Name = "txtEnrollmentNo";
            this.txtEnrollmentNo.Size = new System.Drawing.Size(224, 23);
            this.txtEnrollmentNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(20, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 22);
            this.label1.TabIndex = 40;
            this.label1.Text = "Enter Student Enrollment";
            // 
            // pnlReturnUpdate
            // 
            this.pnlReturnUpdate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlReturnUpdate.Controls.Add(this.label3);
            this.pnlReturnUpdate.Controls.Add(this.dtpReturnDate);
            this.pnlReturnUpdate.Controls.Add(this.label2);
            this.pnlReturnUpdate.Controls.Add(this.dtpIssueDate);
            this.pnlReturnUpdate.Controls.Add(this.btnCancel);
            this.pnlReturnUpdate.Controls.Add(this.btnReturn);
            this.pnlReturnUpdate.Controls.Add(this.label17);
            this.pnlReturnUpdate.Controls.Add(this.txtbookname);
            this.pnlReturnUpdate.Location = new System.Drawing.Point(298, 424);
            this.pnlReturnUpdate.Name = "pnlReturnUpdate";
            this.pnlReturnUpdate.Size = new System.Drawing.Size(1030, 269);
            this.pnlReturnUpdate.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(80, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 22);
            this.label3.TabIndex = 61;
            this.label3.Text = "Return Date";
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReturnDate.Location = new System.Drawing.Point(190, 91);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(266, 23);
            this.dtpReturnDate.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(510, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 59;
            this.label2.Text = "Issue Date";
            // 
            // dtpIssueDate
            // 
            this.dtpIssueDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIssueDate.Location = new System.Drawing.Point(606, 44);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(266, 23);
            this.dtpIssueDate.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(606, 185);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(172, 33);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(284, 185);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(172, 33);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label17.Location = new System.Drawing.Point(84, 44);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 22);
            this.label17.TabIndex = 38;
            this.label17.Text = "Book Name";
            // 
            // txtbookname
            // 
            this.txtbookname.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbookname.Location = new System.Drawing.Point(190, 43);
            this.txtbookname.Name = "txtbookname";
            this.txtbookname.Size = new System.Drawing.Size(266, 23);
            this.txtbookname.TabIndex = 4;
            // 
            // dgvIssuedBooks
            // 
            this.dgvIssuedBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIssuedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIssuedBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvIssuedBooks.Location = new System.Drawing.Point(298, 17);
            this.dgvIssuedBooks.Name = "dgvIssuedBooks";
            this.dgvIssuedBooks.Size = new System.Drawing.Size(1030, 391);
            this.dgvIssuedBooks.TabIndex = 51;
            this.dgvIssuedBooks.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvIssuedBooks_MouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Book_name";
            this.Column2.HeaderText = "Book Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Student_Enrollment";
            this.Column3.HeaderText = "Student Enrollment";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Issue_Date";
            this.Column4.HeaderText = "Issue Date";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Return_Date";
            this.Column5.HeaderText = "Return Date";
            this.Column5.Name = "Column5";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnClose.Image = global::Library_Mgmt.Properties.Resources.CLOSE;
            this.btnClose.Location = new System.Drawing.Point(1327, 3);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(33, 27);
            this.btnClose.TabIndex = 39;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Return_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 750);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.paneladdStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Return_Book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Return_Book";
            this.Load += new System.EventHandler(this.Return_Book_Load);
            this.paneladdStudent.ResumeLayout(false);
            this.paneladdStudent.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlReturnUpdate.ResumeLayout(false);
            this.pnlReturnUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssuedBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneladdStudent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.TextBox txtEnrollmentNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlReturnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtbookname;
        private System.Windows.Forms.DataGridView dgvIssuedBooks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button txtrefresh;
        private System.Windows.Forms.Label label11;
    }
}
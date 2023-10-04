namespace Library_Mgmt
{
    partial class View_Books
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtEnterdata = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSearchby = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlUpdate = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtpublication = new System.Windows.Forms.TextBox();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtbookname = new System.Windows.Forms.TextBox();
            this.txtauthorname = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvViewBook = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paneladdStudent.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewBook)).BeginInit();
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
            this.paneladdStudent.Size = new System.Drawing.Size(1370, 750);
            this.paneladdStudent.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(12, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(276, 31);
            this.label11.TabIndex = 51;
            this.label11.Text = "View Book Here....";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnClose.Image = global::Library_Mgmt.Properties.Resources.CLOSE;
            this.btnClose.Location = new System.Drawing.Point(1332, 3);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(33, 27);
            this.btnClose.TabIndex = 38;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.txtrefresh);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pnlUpdate);
            this.panel1.Controls.Add(this.dgvViewBook);
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
            this.txtrefresh.Location = new System.Drawing.Point(18, 248);
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
            "Book Name",
            "Author Name"});
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
            this.pnlUpdate.Controls.Add(this.btnCancel);
            this.pnlUpdate.Controls.Add(this.btnUpdate);
            this.pnlUpdate.Controls.Add(this.btnDelete);
            this.pnlUpdate.Controls.Add(this.txtprice);
            this.pnlUpdate.Controls.Add(this.label12);
            this.pnlUpdate.Controls.Add(this.txtquantity);
            this.pnlUpdate.Controls.Add(this.label15);
            this.pnlUpdate.Controls.Add(this.label16);
            this.pnlUpdate.Controls.Add(this.txtpublication);
            this.pnlUpdate.Controls.Add(this.dtpdate);
            this.pnlUpdate.Controls.Add(this.label17);
            this.pnlUpdate.Controls.Add(this.label14);
            this.pnlUpdate.Controls.Add(this.txtbookname);
            this.pnlUpdate.Controls.Add(this.txtauthorname);
            this.pnlUpdate.Controls.Add(this.label13);
            this.pnlUpdate.Location = new System.Drawing.Point(298, 394);
            this.pnlUpdate.Name = "pnlUpdate";
            this.pnlUpdate.Size = new System.Drawing.Size(1030, 299);
            this.pnlUpdate.TabIndex = 52;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(738, 230);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(172, 33);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(176, 230);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(172, 33);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(457, 230);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(172, 33);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtprice
            // 
            this.txtprice.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(176, 131);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(266, 23);
            this.txtprice.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(112, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 22);
            this.label12.TabIndex = 44;
            this.label12.Text = "Price";
            // 
            // txtquantity
            // 
            this.txtquantity.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantity.Location = new System.Drawing.Point(645, 129);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(266, 23);
            this.txtquantity.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label15.Location = new System.Drawing.Point(64, 88);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 22);
            this.label15.TabIndex = 40;
            this.label15.Text = "Publication";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label16.Location = new System.Drawing.Point(515, 43);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(111, 22);
            this.label16.TabIndex = 39;
            this.label16.Text = "Author Name";
            // 
            // txtpublication
            // 
            this.txtpublication.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpublication.Location = new System.Drawing.Point(176, 86);
            this.txtpublication.Name = "txtpublication";
            this.txtpublication.Size = new System.Drawing.Size(266, 23);
            this.txtpublication.TabIndex = 6;
            // 
            // dtpdate
            // 
            this.dtpdate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdate.Location = new System.Drawing.Point(645, 85);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(266, 23);
            this.dtpdate.TabIndex = 7;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label17.Location = new System.Drawing.Point(62, 43);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 22);
            this.label17.TabIndex = 38;
            this.label17.Text = "Book Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(581, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 22);
            this.label14.TabIndex = 41;
            this.label14.Text = "Date";
            // 
            // txtbookname
            // 
            this.txtbookname.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbookname.Location = new System.Drawing.Point(176, 41);
            this.txtbookname.Name = "txtbookname";
            this.txtbookname.Size = new System.Drawing.Size(266, 23);
            this.txtbookname.TabIndex = 4;
            // 
            // txtauthorname
            // 
            this.txtauthorname.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtauthorname.Location = new System.Drawing.Point(645, 41);
            this.txtauthorname.Name = "txtauthorname";
            this.txtauthorname.Size = new System.Drawing.Size(266, 23);
            this.txtauthorname.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(549, 131);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 22);
            this.label13.TabIndex = 43;
            this.label13.Text = "Quantity";
            // 
            // dgvViewBook
            // 
            this.dgvViewBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViewBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvViewBook.Location = new System.Drawing.Point(298, 17);
            this.dgvViewBook.Name = "dgvViewBook";
            this.dgvViewBook.Size = new System.Drawing.Size(1030, 365);
            this.dgvViewBook.TabIndex = 51;
            this.dgvViewBook.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvViewBook_MouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Book_Name";
            this.Column2.HeaderText = "Book Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Author_Name";
            this.Column3.HeaderText = "Author Name";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Publication_Name";
            this.Column4.HeaderText = "Publication Name";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Purchase_Date";
            this.Column5.HeaderText = "Purchase Date";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Quentity";
            this.Column6.HeaderText = "Quentity";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Price";
            this.Column7.HeaderText = "Price";
            this.Column7.Name = "Column7";
            // 
            // View_Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 750);
            this.Controls.Add(this.paneladdStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "View_Books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "View_Student";
            this.Load += new System.EventHandler(this.View_Books_Load);
            this.paneladdStudent.ResumeLayout(false);
            this.paneladdStudent.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlUpdate.ResumeLayout(false);
            this.pnlUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneladdStudent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtauthorname;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtpublication;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtbookname;
        private System.Windows.Forms.DataGridView dgvViewBook;
        private System.Windows.Forms.Panel pnlUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbSearchby;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnterdata;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button txtrefresh;
        private System.Windows.Forms.Label label11;
    }
}
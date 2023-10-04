namespace Library_Mgmt
{
    partial class Book_Stock
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDueBooks = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlImage = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtxtContent = new System.Windows.Forms.RichTextBox();
            this.txtEmailId = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvRegisteredBooks = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtrefresh = new System.Windows.Forms.Button();
            this.paneladdStudent.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDueBooks)).BeginInit();
            this.PnlImage.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegisteredBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // paneladdStudent
            // 
            this.paneladdStudent.BackColor = System.Drawing.Color.RoyalBlue;
            this.paneladdStudent.Controls.Add(this.label11);
            this.paneladdStudent.Controls.Add(this.panel1);
            this.paneladdStudent.Location = new System.Drawing.Point(0, 0);
            this.paneladdStudent.Name = "paneladdStudent";
            this.paneladdStudent.Size = new System.Drawing.Size(1364, 750);
            this.paneladdStudent.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(11, -1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(360, 31);
            this.label11.TabIndex = 52;
            this.label11.Text = "View Book Stock Here....";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.txtrefresh);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dgvDueBooks);
            this.panel1.Controls.Add(this.PnlImage);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dgvRegisteredBooks);
            this.panel1.Location = new System.Drawing.Point(10, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1346, 706);
            this.panel1.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(349, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 25);
            this.label5.TabIndex = 57;
            this.label5.Text = "Due Books of Student";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(349, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(315, 25);
            this.label4.TabIndex = 56;
            this.label4.Text = "Registered Books of Student";
            // 
            // dgvDueBooks
            // 
            this.dgvDueBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDueBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDueBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15});
            this.dgvDueBooks.Location = new System.Drawing.Point(298, 399);
            this.dgvDueBooks.Name = "dgvDueBooks";
            this.dgvDueBooks.Size = new System.Drawing.Size(1030, 294);
            this.dgvDueBooks.TabIndex = 55;
            this.dgvDueBooks.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvDueBooks_MouseDoubleClick);
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Id";
            this.Column6.HeaderText = "Std Id";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Name";
            this.Column7.HeaderText = "Std Name";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Enroll";
            this.Column8.HeaderText = "Std Enrollment";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Department";
            this.Column9.HeaderText = "Std Department";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Semester";
            this.Column10.HeaderText = "Std Semester";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "Contact";
            this.Column11.HeaderText = "Std Contact No";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "Email";
            this.Column12.HeaderText = "Std Email";
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "Book_name";
            this.Column13.HeaderText = "Book Name";
            this.Column13.Name = "Column13";
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "Issue_Date";
            this.Column14.HeaderText = "Issue Date";
            this.Column14.Name = "Column14";
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "Return_Date";
            this.Column15.HeaderText = "Return Date";
            this.Column15.Name = "Column15";
            // 
            // PnlImage
            // 
            this.PnlImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlImage.Controls.Add(this.label6);
            this.PnlImage.Controls.Add(this.label3);
            this.PnlImage.Controls.Add(this.label1);
            this.PnlImage.Controls.Add(this.rtxtContent);
            this.PnlImage.Controls.Add(this.txtEmailId);
            this.PnlImage.Controls.Add(this.btnSend);
            this.PnlImage.Location = new System.Drawing.Point(18, 282);
            this.PnlImage.Name = "PnlImage";
            this.PnlImage.Size = new System.Drawing.Size(265, 411);
            this.PnlImage.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(35, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 25);
            this.label6.TabIndex = 53;
            this.label6.Text = "Send Notification";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(14, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 22);
            this.label3.TabIndex = 52;
            this.label3.Text = "Content";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(14, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 51;
            this.label1.Text = "Email Id";
            // 
            // rtxtContent
            // 
            this.rtxtContent.Location = new System.Drawing.Point(18, 184);
            this.rtxtContent.Name = "rtxtContent";
            this.rtxtContent.Size = new System.Drawing.Size(224, 110);
            this.rtxtContent.TabIndex = 3;
            this.rtxtContent.Text = "";
            // 
            // txtEmailId
            // 
            this.txtEmailId.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailId.Location = new System.Drawing.Point(18, 122);
            this.txtEmailId.Name = "txtEmailId";
            this.txtEmailId.Size = new System.Drawing.Size(224, 23);
            this.txtEmailId.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(40, 340);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(172, 33);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.txtBookName);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(18, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(265, 169);
            this.panel3.TabIndex = 53;
            // 
            // txtBookName
            // 
            this.txtBookName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookName.Location = new System.Drawing.Point(18, 59);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(224, 23);
            this.txtBookName.TabIndex = 1;
            this.txtBookName.TextChanged += new System.EventHandler(this.txtBookName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(14, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 22);
            this.label2.TabIndex = 42;
            this.label2.Text = "Search Book Name";
            // 
            // dgvRegisteredBooks
            // 
            this.dgvRegisteredBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRegisteredBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegisteredBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvRegisteredBooks.Location = new System.Drawing.Point(298, 51);
            this.dgvRegisteredBooks.Name = "dgvRegisteredBooks";
            this.dgvRegisteredBooks.Size = new System.Drawing.Size(1030, 294);
            this.dgvRegisteredBooks.TabIndex = 51;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Book_Name";
            this.Column1.HeaderText = "Book Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Author_Name";
            this.Column2.HeaderText = "Author Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Price";
            this.Column3.HeaderText = "Price";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Quentity";
            this.Column4.HeaderText = "Quantity";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Availabe";
            this.Column5.HeaderText = "Available Quantity";
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
            this.btnClose.TabIndex = 38;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtrefresh
            // 
            this.txtrefresh.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtrefresh.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrefresh.ForeColor = System.Drawing.Color.White;
            this.txtrefresh.Location = new System.Drawing.Point(18, 192);
            this.txtrefresh.Name = "txtrefresh";
            this.txtrefresh.Size = new System.Drawing.Size(129, 33);
            this.txtrefresh.TabIndex = 58;
            this.txtrefresh.Text = "Refresh";
            this.txtrefresh.UseVisualStyleBackColor = false;
            this.txtrefresh.Click += new System.EventHandler(this.txtrefresh_Click);
            // 
            // Book_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 750);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.paneladdStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Book_Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Book_Stock";
            this.Load += new System.EventHandler(this.Book_Stock_Load);
            this.paneladdStudent.ResumeLayout(false);
            this.paneladdStudent.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDueBooks)).EndInit();
            this.PnlImage.ResumeLayout(false);
            this.PnlImage.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegisteredBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneladdStudent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PnlImage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvRegisteredBooks;
        private System.Windows.Forms.DataGridView dgvDueBooks;
        private System.Windows.Forms.RichTextBox rtxtContent;
        private System.Windows.Forms.TextBox txtEmailId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.Button txtrefresh;
    }
}
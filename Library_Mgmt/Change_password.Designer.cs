namespace Library_Mgmt
{
    partial class Change_password
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
            this.paneladdbook = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtconfirm = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtnewpassword = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCurrent = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.paneladdbook.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneladdbook
            // 
            this.paneladdbook.BackColor = System.Drawing.Color.RoyalBlue;
            this.paneladdbook.Controls.Add(this.btnClose);
            this.paneladdbook.Controls.Add(this.panel1);
            this.paneladdbook.Controls.Add(this.label11);
            this.paneladdbook.Location = new System.Drawing.Point(0, 0);
            this.paneladdbook.Name = "paneladdbook";
            this.paneladdbook.Size = new System.Drawing.Size(646, 392);
            this.paneladdbook.TabIndex = 7;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnClose.Image = global::Library_Mgmt.Properties.Resources.CLOSE;
            this.btnClose.Location = new System.Drawing.Point(599, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(33, 27);
            this.btnClose.TabIndex = 39;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.txtconfirm);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtnewpassword);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.txtCurrent);
            this.panel1.Location = new System.Drawing.Point(9, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 351);
            this.panel1.TabIndex = 36;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(356, 243);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(159, 33);
            this.btnCancel.TabIndex = 5;
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
            this.btnUpdate.Location = new System.Drawing.Point(115, 243);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(159, 33);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtconfirm
            // 
            this.txtconfirm.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconfirm.Location = new System.Drawing.Point(249, 155);
            this.txtconfirm.Name = "txtconfirm";
            this.txtconfirm.PasswordChar = '●';
            this.txtconfirm.Size = new System.Drawing.Size(266, 23);
            this.txtconfirm.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(83, 156);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 22);
            this.label12.TabIndex = 44;
            this.label12.Text = "Confirm Password";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label15.Location = new System.Drawing.Point(111, 108);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 22);
            this.label15.TabIndex = 40;
            this.label15.Text = "New Password";
            // 
            // txtnewpassword
            // 
            this.txtnewpassword.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnewpassword.Location = new System.Drawing.Point(249, 107);
            this.txtnewpassword.Name = "txtnewpassword";
            this.txtnewpassword.PasswordChar = '●';
            this.txtnewpassword.Size = new System.Drawing.Size(266, 23);
            this.txtnewpassword.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label17.Location = new System.Drawing.Point(86, 60);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(145, 22);
            this.label17.TabIndex = 38;
            this.label17.Text = "Current Password";
            // 
            // txtCurrent
            // 
            this.txtCurrent.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrent.Location = new System.Drawing.Point(249, 59);
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.PasswordChar = '●';
            this.txtCurrent.Size = new System.Drawing.Size(266, 23);
            this.txtCurrent.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(10, -1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(379, 31);
            this.label11.TabIndex = 49;
            this.label11.Text = "Change Password Here....";
            // 
            // Change_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 392);
            this.Controls.Add(this.paneladdbook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Change_password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Change_password";
            this.Load += new System.EventHandler(this.Change_password_Load);
            this.paneladdbook.ResumeLayout(false);
            this.paneladdbook.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneladdbook;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtconfirm;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtnewpassword;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtCurrent;
        private System.Windows.Forms.Button btnCancel;
    }
}
using Library_Mgmt.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Mgmt
{
    public partial class New_Student : Form
    {
        Student_Detail model = new Student_Detail();
        Library_MgmtEntities1 db = new Library_MgmtEntities1();
      
        public New_Student()
        {
            InitializeComponent();
        }

        string imagelocation = "";

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imagelocation = dialog.FileName;

                    picStudent.ImageLocation = imagelocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error Occupied");
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if(txtStudentName.Text==""|| txtEnrollmentNo.Text==""||txtDepartment.Text=="" || txtSemester.Text == "" || txtContactNo.Text == "" || txtEmailId.Text == "" || imagelocation == "")
            {
                MessageBox.Show("Please Fill All Fields.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                model.Student_Name = txtStudentName.Text;
                model.Enrollment = txtEnrollmentNo.Text;
                model.Department = txtDepartment.Text;
                model.Semester = txtSemester.Text;
                model.Contact_No = txtContactNo.Text;
                model.Email_Id = txtEmailId.Text;
                model.Image_link = imagelocation.ToString();
                db.Student_Detail.Add(model);
                int a = db.SaveChanges();
                if (a > 0)
                {
                    MessageBox.Show("Data Inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                else
                {
                    MessageBox.Show("Data Not Inserted", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
           
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Reset()
        {
            txtStudentName.Clear();
            txtEnrollmentNo.Clear();
            txtDepartment.Clear();
            txtSemester.Clear();
            txtContactNo.Clear();
            txtEmailId.Clear();
            picStudent.ImageLocation = "";
        }
    }
}

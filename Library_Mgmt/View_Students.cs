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
    public partial class View_Students : Form
    {
        int id = 0;
        string imagelocation = "";
        Student_Detail model = new Student_Detail();
        Library_MgmtEntities1 db = new Library_MgmtEntities1();

        public View_Students()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            model.Id = id;
            model.Student_Name = txtStudentName.Text;
            model.Enrollment = txtenrollmentNo.Text;
            model.Department = txtDepartment.Text;
            model.Semester = txtSemester.Text;
            model.Contact_No = txtContactNo.Text;
            model.Email_Id = txtEmailId.Text;
            model.Image_link = picStudent.ImageLocation.ToString();
            db.Entry(model).State = EntityState.Modified;
            int a = db.SaveChanges();
            if (a > 0)
            {
                MessageBox.Show("Data Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadingData();
                pnlUpdate.Visible = false;
                PnlImage.Visible = false;
                Reset();
            }
            else
            {
                MessageBox.Show("Data Not Updated", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to delete data.", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                model = db.Student_Detail.Where(x => x.Id == id).FirstOrDefault();
                db.Entry(model).State = EntityState.Deleted;
                int a = db.SaveChanges();
                if (a > 0)
                {
                    MessageBox.Show("Data Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadingData();
                    pnlUpdate.Visible = false;
                }
                else
                {
                    MessageBox.Show("Data Not Deleted", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You have cancelled the Delete Operation", "Abort", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadingData();
                Reset();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
            pnlUpdate.Visible = false;
            PnlImage.Visible = false;
        }

        private void dgvViewStudent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pnlUpdate.Visible = true;
            if (chkbImage.Checked == true)
            {
                PnlImage.Visible = true;
            }
            else
            {
                PnlImage.Visible = false;
            }
            id = Convert.ToInt32(dgvViewStudent.SelectedRows[0].Cells[0].Value);
            model = db.Student_Detail.Where(x => x.Id == id).FirstOrDefault();
            txtStudentName.Text = model.Student_Name;
            txtenrollmentNo.Text = model.Enrollment.ToString();
            txtDepartment.Text = model.Department;
            txtSemester.Text = Convert.ToString(model.Semester);
            txtContactNo.Text = Convert.ToString(model.Contact_No);
            txtEmailId.Text = Convert.ToString(model.Email_Id);
            picStudent.ImageLocation = model.Image_link;

        }

        void Reset()
        {
            txtStudentName.Clear();
            txtenrollmentNo.Clear();
            txtDepartment.Clear();
            txtSemester.Clear();
            txtContactNo.Clear();
            txtEmailId.Clear();
            picStudent.ImageLocation = "";
        }

        private void View_Students_Load(object sender, EventArgs e)
        {
            pnlUpdate.Visible = false;
            PnlImage.Visible=false;
            LoadingData();
        }

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

        private void chkbImage_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbImage.Checked == true)
            {
                PnlImage.Visible = true;
            }
            else
            {
                PnlImage.Visible = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEnterdata_TextChanged(object sender, EventArgs e)
        {
            if (cmbSearchby.Text == "Student Name")
            {
                LoadingData();
            }
            else if (cmbSearchby.Text == "Enrollment Number")
            {
                LoadingDataByAuthor();
            }
            else
            {
                MessageBox.Show("Plaese Select Search By", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void LoadingData()
        {

            var studentname = db.Student_Detail.ToList();
            var q = (from model in db.Student_Detail
                     where model.Student_Name.Contains(txtEnterdata.Text)
                     select new
                     {
                         model.Id,
                         model.Student_Name,
                         model.Enrollment,
                         model.Department,
                         model.Semester,
                         model.Contact_No,
                         model.Email_Id,
                         model.Image_link
                     }).ToList();
            dgvViewStudent.Rows.Clear();
            q.ForEach(i => dgvViewStudent.Rows.Add(i.Id.ToString(), i.Student_Name, i.Enrollment, i.Department, i.Semester.ToString(), i.Contact_No.ToString(), i.Email_Id.ToString(), i.Image_link.ToString()));
        }

        void LoadingDataByAuthor()
        {
            var studentname = db.Student_Detail.ToList();
            var q = (from model in db.Student_Detail
                     where model.Enrollment.Contains(txtEnterdata.Text)
                     select new
                     {
                         model.Id,
                         model.Student_Name,
                         model.Enrollment,
                         model.Department,
                         model.Semester,
                         model.Contact_No,
                         model.Email_Id,
                         model.Image_link
                     }).ToList();
            dgvViewStudent.Rows.Clear();
            q.ForEach(i => dgvViewStudent.Rows.Add(i.Id.ToString(), i.Student_Name, i.Enrollment, i.Department, i.Semester.ToString(), i.Contact_No.ToString(), i.Email_Id.ToString(), i.Image_link.ToString()));
        }

        private void txtrefresh_Click(object sender, EventArgs e)
        {
            txtEnterdata.Clear();
            cmbSearchby.Text = "";
            LoadingData();
            PnlImage.Visible = false;
            pnlUpdate.Visible = false;
        }
    }
}

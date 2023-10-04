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
    public partial class Issue_Book : Form
    {
        Issue_Book_Detail model = new Issue_Book_Detail();
        Library_MgmtEntities3 db = new Library_MgmtEntities3();
        Book_Detail books = new Book_Detail();
        Library_MgmtEntities2 db1 = new Library_MgmtEntities2();
        Student_Detail sm = new Student_Detail();
        Library_MgmtEntities1 db2 = new Library_MgmtEntities1();

        public Issue_Book()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            model.Book_name = txtbookname.Text;
            model.Student_Enrollment = txtEnrollmentNo.Text;
            model.Issue_Date = Convert.ToDateTime(dtpIssueDate.Text);
            db.Issue_Book_Detail.Add(model);
            int a = db.SaveChanges();
            if (a > 0)
            {
                MessageBox.Show("Book Issue Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }
            else
            {
                MessageBox.Show("Book Issue Failed", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchData();
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
            txtbookname.Clear();
            dtpIssueDate.ResetText();
        }

        void BookName()
        {
            var name = from books in db1.Book_Detail select books.Book_Name;
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            source.AddRange(name.ToArray());
            txtbookname.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtbookname.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtbookname.AutoCompleteCustomSource = source;
        }

        private void Issue_Book_Load(object sender, EventArgs e)
        {
            BookName();
        }

        void SearchData()
        {
            sm = db2.Student_Detail.Where(x => x.Enrollment == txtEnrollmentNo.Text).FirstOrDefault();
            if (sm is null)
            {
                MessageBox.Show("Invalid Enrollment Number", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                txtStudentName.Text = sm.Student_Name;
                txtDepartment.Text = sm.Department;
                txtSemester.Text = Convert.ToString(sm.Semester);
                txtContactNo.Text = Convert.ToString(sm.Contact_No);
                txtEmailId.Text = Convert.ToString(sm.Email_Id);
            }
        }
    }
}

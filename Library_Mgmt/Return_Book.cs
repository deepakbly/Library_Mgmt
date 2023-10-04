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
    public partial class Return_Book : Form
    {
        int id = 0;
        Issue_Book_Detail model = new Issue_Book_Detail();
        Library_MgmtEntities3 db = new Library_MgmtEntities3();
      
        public Return_Book()
        {
            InitializeComponent();
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            LoadindIssueBook();
        }

        void LoadindIssueBook()
        {
            var studentname = db.Issue_Book_Detail.ToList();
            var q = (from model in db.Issue_Book_Detail
                     where model.Student_Enrollment.Contains(txtEnrollmentNo.Text)
                     select new
                     {
                         model.Id,
                         model.Book_name,
                         model.Student_Enrollment,
                         model.Issue_Date,
                         model.Return_Date
                     }).ToList();
            dgvIssuedBooks.Rows.Clear();
            q.ForEach(i => dgvIssuedBooks.Rows.Add(i.Id.ToString(), i.Book_name, i.Student_Enrollment, i.Issue_Date, i.Return_Date.ToString()));
        }

        private void Return_Book_Load(object sender, EventArgs e)
        {
            LoadindIssueBook();
            pnlReturnUpdate.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            model.Return_Date = Convert.ToDateTime(dtpReturnDate.Text);
            db.Entry(model).State = EntityState.Modified;
            int a = db.SaveChanges();
            if (a > 0)
            {
                MessageBox.Show("Book Returned Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pnlReturnUpdate.Visible = false;
                txtEnrollmentNo.Clear();
                Reset();
                LoadindIssueBook();
            }
            else
            {
                MessageBox.Show("Book Returned Process Failed", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
            LoadindIssueBook();
            pnlReturnUpdate.Visible = false;
        }

        void Reset()
        {
            txtbookname.Clear();
            dtpIssueDate.ResetText();
            dtpReturnDate.ResetText();
        }

        private void dgvIssuedBooks_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pnlReturnUpdate.Visible = true;
            id = Convert.ToInt32(dgvIssuedBooks.SelectedRows[0].Cells[0].Value);
            model = db.Issue_Book_Detail.Where(x => x.Id == id).FirstOrDefault();
            txtbookname.Text = model.Book_name;
            dtpIssueDate.Text = Convert.ToString(model.Issue_Date);
        }

        private void txtrefresh_Click(object sender, EventArgs e)
        {
            txtEnrollmentNo.Clear();
            LoadindIssueBook();
            pnlReturnUpdate.Visible = false;
        }
    }
}

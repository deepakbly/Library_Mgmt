using Library_Mgmt.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Mgmt
{
    public partial class Book_Stock : Form
    {
        Details_Result model = new Details_Result();
        Library_MgmtEntities db = new Library_MgmtEntities();
        Student_Detail std = new Student_Detail();
        Library_MgmtEntities1 db1 = new Library_MgmtEntities1();

        public Book_Stock()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("gmail", "Password");
                MailMessage msb = new MailMessage();
                msb.To.Add(txtEmailId.Text);
                msb.From = new MailAddress("gmail");
                msb.Body = rtxtContent.Text;
                client.Send(msb);
                MessageBox.Show("Your mail is sended", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void LoadingBooks()
        {
           using(Library_MgmtEntities db=new Library_MgmtEntities())
            {
                dgvRegisteredBooks.DataSource = db.Details(txtBookName.Text);
            }
        }
      
       
        private void txtBookName_TextChanged(object sender, EventArgs e)
        {
            LoadingBooks();
            LoadingDueBooks();
        }


        void LoadingDueBooks()
        {
            using (Library_MgmtEntities db = new Library_MgmtEntities())
            {
                dgvDueBooks.DataSource = db.DueBook(txtBookName.Text);
            }
        }

        private void Book_Stock_Load(object sender, EventArgs e)
        {
            LoadingDueBooks();
            LoadingBooks();
        }

        int id = 0;
        private void dgvDueBooks_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = Convert.ToInt32(dgvDueBooks.SelectedRows[0].Cells[0].Value);
            std = db1.Student_Detail.Where(x => x.Id == id).FirstOrDefault();
            txtEmailId.Text = std.Email_Id;
        }

        private void txtrefresh_Click(object sender, EventArgs e)
        {
            LoadingDueBooks();
            LoadingBooks();
            txtEmailId.Clear();
            rtxtContent.Clear();
        }
    }
}

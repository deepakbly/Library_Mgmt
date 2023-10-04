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
using System.Data.Entity;

namespace Library_Mgmt
{
    public partial class View_Books : Form
    {
        int id = 0;
        Book_Detail model = new Book_Detail();
        Library_MgmtEntities2 db = new Library_MgmtEntities2();

        public View_Books()
        {
            InitializeComponent();
        }

        private void View_Books_Load(object sender, EventArgs e)
        {
            LoadingData();
            pnlUpdate.Visible = false;
        }

        private void txtEnterdata_TextChanged(object sender, EventArgs e)
        {
            if (cmbSearchby.Text == "Book Name")
            {
                LoadingData();
            }
            else if (cmbSearchby.Text == "Author Name")
            {
                LoadingDataByAuthor();
            }
            else
            {
                MessageBox.Show("Plaese Select Search By", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dgvViewBook_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pnlUpdate.Visible = true;
            id = Convert.ToInt32(dgvViewBook.SelectedRows[0].Cells[0].Value);
            model = db.Book_Detail.Where(x => x.Id == id).FirstOrDefault();
            txtbookname.Text = model.Book_Name;
            txtauthorname.Text = model.Author_Name;
            txtpublication.Text = model.Publication_Name;
            dtpdate.Text = Convert.ToString(model.Purchase_Date);
            txtprice.Text = Convert.ToString(model.Price);
            txtquantity.Text = Convert.ToString(model.Quentity);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            model.Id = id;
            model.Book_Name = txtbookname.Text;
            model.Author_Name = txtauthorname.Text;
            model.Publication_Name = txtpublication.Text;
            model.Purchase_Date = Convert.ToDateTime(dtpdate.Text);
            model.Price = Convert.ToDecimal(txtprice.Text);
            model.Quentity = Convert.ToInt32(txtquantity.Text);
            db.Entry(model).State = EntityState.Modified;
            int a = db.SaveChanges();
            if (a > 0)
            {
                MessageBox.Show("Data Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadingData();
                pnlUpdate.Visible = false;
                Reset();
                txtEnterdata.Clear();
                cmbSearchby.Text = "";
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
                model = db.Book_Detail.Where(x => x.Id == id).FirstOrDefault();
                db.Entry(model).State = EntityState.Deleted;
                int a = db.SaveChanges();
                if (a > 0)
                {
                    MessageBox.Show("Data Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadingData();
                    pnlUpdate.Visible = false;
                    Reset();
                    txtEnterdata.Clear();
                    cmbSearchby.Text = "";
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
                txtEnterdata.Clear();
                cmbSearchby.Text = "";
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
            pnlUpdate.Visible = false;
            txtEnterdata.Clear();
            cmbSearchby.Text = "";
            LoadingData();
        }

        void Reset()
        {
            txtbookname.Clear();
            txtauthorname.Clear();
            txtpublication.Clear();
            txtprice.Clear();
            txtquantity.Clear();
            dtpdate.ResetText();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void LoadingData()
        {

            var bookname = db.Book_Detail.ToList();
            var q = (from model in db.Book_Detail
                     where model.Book_Name.Contains(txtEnterdata.Text)
                     select new
                     {
                         model.Id,
                         model.Book_Name,
                         model.Author_Name,
                         model.Publication_Name,
                         model.Purchase_Date,
                         model.Price,
                         model.Quentity
                     }).ToList();
            dgvViewBook.Rows.Clear();
            q.ForEach(i => dgvViewBook.Rows.Add(i.Id.ToString(), i.Book_Name, i.Author_Name, i.Publication_Name, i.Purchase_Date.ToString(), i.Quentity.ToString(), i.Price.ToString()));
        }

        void LoadingDataByAuthor()
        {

            var bookname = db.Book_Detail.ToList();
            var q = (from model in db.Book_Detail
                     where model.Author_Name.Contains(txtEnterdata.Text)
                     select new
                     {
                         model.Id,
                         model.Book_Name,
                         model.Author_Name,
                         model.Publication_Name,
                         model.Purchase_Date,
                         model.Price,
                         model.Quentity
                     }).ToList();
            dgvViewBook.Rows.Clear();
            q.ForEach(i => dgvViewBook.Rows.Add(i.Id.ToString(), i.Book_Name, i.Author_Name, i.Publication_Name, i.Purchase_Date.ToString(), i.Quentity.ToString(), i.Price.ToString()));
        }

        private void txtrefresh_Click(object sender, EventArgs e)
        {
            txtEnterdata.Clear();
            cmbSearchby.Text = "";
            LoadingData();
            pnlUpdate.Visible = false;
        }
    }
}

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
    public partial class New_Book : Form
    {
        Book_Detail model = new Book_Detail();
        Library_MgmtEntities2 db = new Library_MgmtEntities2();

        public New_Book()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if(txtbookname.Text=="" || txtauthorname.Text=="" || txtpublication.Text == "" || txtprice.Text == "" || txtquantity.Text == "")
            {
                MessageBox.Show("Please Fill All Fields.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                model.Book_Name = txtbookname.Text;
                model.Author_Name = txtauthorname.Text;
                model.Publication_Name = txtpublication.Text;
                model.Purchase_Date = Convert.ToDateTime(dtpdate.Text);
                model.Price = Convert.ToDecimal(txtprice.Text);
                model.Quentity = Convert.ToInt32(txtquantity.Text);
                db.Book_Detail.Add(model);
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
            txtbookname.Clear();
            txtauthorname.Clear();
            txtpublication.Clear();
            txtprice.Clear();
            txtquantity.Clear();
            dtpdate.ResetText();
        }
    }
}

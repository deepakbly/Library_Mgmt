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
    public partial class Change_password : Form
    {
        User_Detail model = new User_Detail();
        Library_MgmtEntities4 db = new Library_MgmtEntities4();

        public Change_password()
        {
            InitializeComponent();
        }

        private void Change_password_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCurrent.Text=="" || txtnewpassword.Text=="" || txtconfirm.Text=="")
            {
                MessageBox.Show("Please Fill All Fields.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (txtnewpassword.Text == txtconfirm.Text)
                {
                    model.id = GlbVariable.User_id;
                    model.user_name = GlbVariable.user_name;
                    model.password = txtnewpassword.Text;
                    model.name = GlbVariable.name;
                    model.address = GlbVariable.address;
                    model.contact_no = GlbVariable.contect_no;
                    model.image_link = GlbVariable.Image;
                    model.gmail = GlbVariable.Gmail;
                    db.Entry(model).State = EntityState.Modified;
                    int a = db.SaveChanges();
                    if (a > 0)
                    {
                        MessageBox.Show("Password Change Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show("Password Change Failure.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Password Mismatch", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Reset()
        {
            txtconfirm.Clear();
            txtCurrent.Clear();
            txtnewpassword.Clear();
        }
    }
}

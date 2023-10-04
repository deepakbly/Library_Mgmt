using Library_Mgmt.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Mgmt
{
    public partial class New_User : Form
    {
        User_Detail model = new User_Detail();
        Library_MgmtEntities4 db = new Library_MgmtEntities4();

        public New_User()
        {
            InitializeComponent();
        }

        private void New_User_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btncancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtpassword.Text == "" || txtusername.Text == "" || txtAddress.Text == "" || txtContactNo.Text == "" || txtEmailId.Text == "" || imagelocation == "")
            {
                MessageBox.Show("Please Fill All Fields.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (txtpassword.Text != txtconfirm.Text)
                {
                    MessageBox.Show("Password Mismatch", "Mismatched", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    model.user_name = txtusername.Text;
                    model.password = txtpassword.Text;
                    model.name = txtName.Text;
                    model.address = txtAddress.Text;
                    model.contact_no = txtContactNo.Text;
                    model.image_link = imagelocation.ToString();
                    model.gmail = txtEmailId.Text;
                    db.User_Detail.Add(model);
                    int a = db.SaveChanges();
                    if (a > 0)
                    {
                        MessageBox.Show("Sign Up Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Reset();
                        this.Close();
                        Thread th = new Thread(opennewform);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();
                    }
                    else
                    {
                        MessageBox.Show("Sign Up Failed", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        void opennewform()
        {
            Application.Run(new Login());
        }

        void Reset()
        {
            txtName.Clear();
            txtAddress.Clear();
            txtContactNo.Clear();
            txtEmailId.Clear();
            txtusername.Clear();
            txtpassword.Clear();
            txtconfirm.Clear();
            picStudent.ImageLocation = "";
        }
    }
}

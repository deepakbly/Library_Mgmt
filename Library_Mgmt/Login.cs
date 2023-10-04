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
    public partial class Login : Form
    {
        User_Detail model = new User_Detail();
        Library_MgmtEntities4 db = new Library_MgmtEntities4();

        public Login()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void opennewform(object obj)
        {
            Application.Run(new MDI_Main());
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("User Name or password field is blank");
            }
            else
            {
                var user = db.User_Detail.FirstOrDefault(x => x.user_name == txtUserName.Text);
                if (user.password == txtPassword.Text)
                {
                    GlbVariable.user_name = user.user_name;
                    GlbVariable.User_id = user.id;
                    GlbVariable.name = user.name;
                    GlbVariable.address = user.address;
                    GlbVariable.contect_no = user.contact_no;
                    GlbVariable.Gmail = user.gmail;
                    GlbVariable.Image = user.image_link;
                    //MessageBox.Show("Login Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    Thread th = new Thread(opennewform);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                else
                {
                    MessageBox.Show("Please Check Login Information", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread  th = new Thread(OpenRegistration);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        void OpenRegistration()
        {
            Application.Run(new New_User());
        }
    }
}

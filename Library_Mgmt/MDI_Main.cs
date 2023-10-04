using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace Library_Mgmt
{
    public partial class MDI_Main : Form
    {
       

        public MDI_Main()
        {
            InitializeComponent();
        }

        private void btnMenuStudent_Click(object sender, EventArgs e)
        {
            if (pnlStudent.Visible == true)
            {
                pnlStudent.Visible = false;
                pnlReport.Visible = false;
                pnlOtherFeature.Visible = false;
                pnlBook.Visible = false;
            }
            else
            {
                pnlStudent.Visible = true;
                pnlReport.Visible = false;
                pnlOtherFeature.Visible = false;
                pnlBook.Visible = false;
            }
        }

        private void btnMenuBook_Click(object sender, EventArgs e)
        {
            if (pnlBook.Visible == true)
            {
                pnlBook.Visible = false;
                pnlReport.Visible = false;
                pnlOtherFeature.Visible = false;
                pnlStudent.Visible = false;
            }
            else
            {
                pnlBook.Visible = true;
                pnlReport.Visible = false;
                pnlOtherFeature.Visible = false;
                pnlStudent.Visible = false;
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (pnlReport.Visible == true)
            {
                pnlReport.Visible = false;
                pnlStudent.Visible = false;
                pnlOtherFeature.Visible = false;
                pnlBook.Visible = false;
            }
            else
            {
                pnlReport.Visible = true;
                pnlStudent.Visible = false;
                pnlOtherFeature.Visible = false;
                pnlBook.Visible = false;
            }
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            if (pnlOtherFeature.Visible == true)
            {
                pnlOtherFeature.Visible = false;
                pnlReport.Visible = false;
                pnlStudent.Visible = false;
                pnlBook.Visible = false;
            }
            else
            {
                pnlOtherFeature.Visible = true;
                pnlReport.Visible = false;
                pnlStudent.Visible = false;
                pnlBook.Visible = false;
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(New_Student))
                {
                    form.Activate();
                    return;
                }
            }
            New_Student NS = new New_Student();
            NS.MdiParent = this;
            NS.Show();
        }

        private void btnViewStudent_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(View_Students))
                {
                    form.Activate();
                    return;
                }
            }
            View_Students VS = new View_Students();
            VS.MdiParent = this;
            VS.Show();
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Issue_Book))
                {
                    form.Activate();
                    return;
                }
            }
            Issue_Book IB = new Issue_Book();
            IB.MdiParent = this;
            IB.Show();
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Return_Book))
                {
                    form.Activate();
                    return;
                }
            }
            Return_Book RB = new Return_Book();
            RB.MdiParent = this;
            RB.Show();
        }

        private void btnBookStock_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Book_Stock))
                {
                    form.Activate();
                    return;
                }
            }
            Book_Stock BS = new Book_Stock();
            BS.MdiParent = this;
            BS.Show();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(New_Book))
                {
                    form.Activate();
                    return;
                }
            }
            New_Book NB = new New_Book();
            NB.MdiParent = this;
            NB.Show();
        }

        private void btnViewBook_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(View_Books))
                {
                    form.Activate();
                    return;
                }
            }
            View_Books VB = new View_Books();
            VB.MdiParent = this;
            VB.Show();
        }

        private void MDI_Main_Load(object sender, EventArgs e)
        {
            label2.Text = "Welcome : " + GlbVariable.name;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Change_password))
                {
                    form.Activate();
                    return;
                }
            }
            Change_password CW = new Change_password();
            CW.MdiParent = this;
            CW.Show();
        }

        void opennewform()
        {
            Application.Run(new Login());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            ////clsGlobalVariable.School_Name = cmbSchoolName.Text;
            Thread th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

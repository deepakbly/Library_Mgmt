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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 1;
            if (panel2.Width >= 700)
            {
                timer1.Stop();
                Login FL = new Login();
                FL.Show();
                this.Hide();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace HuraFormDesign
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        int PID = Process.GetCurrentProcess().Id;


        private void huraButton2_Click_1(object sender, EventArgs e)
        {
            Process p = Process.GetProcessById(PID);
            p.Kill();
        }

        private void huraForm2_Click(object sender, EventArgs e)
        {

        }

        private void huraButton1_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(userx.Text) && String.IsNullOrEmpty(passx.Text))
            {
                alertx.Text = "Do Not leave Text Fields Empty";
                alertx.AlertStyle = Hura_Theme.HuraAlertBox.Style.Warning;

            }
            else
            {
                /* Login Code */

                this.Hide();
                SplashScreen splash = new SplashScreen();
                splash.ShowDialog();
                this.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace HuraFormDesign
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private async void SplashScreen_Load(object sender, EventArgs e)
        {
            await Task.Delay(5000);
            this.Hide();
            Main Main = new Main();
            Main.ShowDialog();
            this.Close();
        }
    }
}

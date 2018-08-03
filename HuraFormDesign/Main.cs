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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        int PID = Process.GetCurrentProcess().Id;

        private void huraButton1_Click(object sender, EventArgs e)
        {

        }

        private void huraButton2_Click(object sender, EventArgs e)
        {
            Process p = Process.GetProcessById(PID);
            p.Kill();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void huraButton6_Click_1(object sender, EventArgs e)
        {
            progVal.Value = Convert.ToInt32(Progvalx.Text);
        }
    }
}

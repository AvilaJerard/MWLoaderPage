using MWLoaderPage.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MWLoaderPage
{
    public partial class ScreenLoader2 : Form
    {
        public ScreenLoader2()
        {
            InitializeComponent();
        }

        private void ScreenLoader2_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            progressBar1.Increment(2);
            if (progressBar1.Value == 50)
            {
                timer1.Enabled = false;
                UserDashboard UserDashboard = new UserDashboard();
                UserDashboard.Show();
                this.Hide();
            }
        }
    }
}

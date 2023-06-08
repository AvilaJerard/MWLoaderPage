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
    public partial class ScreenLoadcs : Form
    {
        public ScreenLoadcs()
        {
            InitializeComponent();
        }

        private void loaderScreen1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            progressBar1.Increment(2);
            if (progressBar1.Value == 50)
            {
                timer1.Enabled = false;
                DashboardMW_Moto_Hub dashboardMW_Moto_Hub = new DashboardMW_Moto_Hub();
                dashboardMW_Moto_Hub.Show();
                this.Hide();
            }
           
        }

        private void ScreenLoadcs_Load(object sender, EventArgs e)
        {

        }
    }
}

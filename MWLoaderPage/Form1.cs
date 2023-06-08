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
    public partial class Frm1LoaderMW : Form
    {
        public Frm1LoaderMW()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Frm1LoaderMW_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled= true;
            progressBar1.Increment(2);
            lbl2Percent.Text = progressBar1.Value.ToString() + "%";
            if(progressBar1.Value == 100) 
            { 
                timer1.Enabled= false;
                ChooseLoginMemberForm ChooseLoginMemberForm = new ChooseLoginMemberForm();
                ChooseLoginMemberForm.Show();
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

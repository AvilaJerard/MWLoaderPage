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
    public partial class ChooseLoginMemberForm : Form
    {
        public ChooseLoginMemberForm()
        {
            InitializeComponent();
        }

        private void ChooseLoginMemberForm_Load(object sender, EventArgs e)
        {

        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            Frm2LogInMW logInMW = new Frm2LogInMW();
            logInMW.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            UserForm UserForm = new UserForm();
            UserForm.Show();
            this.Hide();
        }
    }
}

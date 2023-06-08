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
using MWLoaderPage.Resources;

namespace MWLoaderPage
{
    public partial class Frm2LogInMW : Form
    {
        public Frm2LogInMW()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Avila\\Desktop\\CSS A403\\MWLoaderPage\\MWLoaderPage\\MWDatabase.mdf\";Integrated Security=True");
    //    SqlConnection connect = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Admin\\Desktop\\CSS A403\\MWLoaderPage\\MWLoaderPage\\MWDatabase.mdf\";Integrated Security=True");
        private void btn1Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            
           if (txtUsername.Text == "Enter username here" & txtPassword.Text == "Enter password here") 
            {
                lblPEU.Visible = true;
                lblPEP.Visible = true;
                lblErrrorMsg.Visible = true;
                lblErrrorMsg.Text = " Please input a valid username and passwork" +
                    "\n                     Please Try again " +
                    "\n" +
                    "\n" +
                    "\n" +
                    "\n";
                btnOkey.Visible = true;
                btnLogIn.Visible = false;
            }
           else
            {
                try
                {
         //         SqlConnection connect = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Admin\\Desktop\\CSS A403\\MWLoaderPage\\MWLoaderPage\\MWDatabase.mdf\";Integrated Security=True");
                    SqlCommand command = new SqlCommand("select * from LogIn where username = @username and password =@password", connect);
                    command.Parameters.AddWithValue("@username", txtUsername.Text);
                    command.Parameters.AddWithValue("@password", txtPassword.Text);
                    SqlDataAdapter data = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    data.Fill(dataTable);
                    if (dataTable.Rows.Count > 0)
                    {
                        
                        ScreenLoadcs screenLoadcs= new ScreenLoadcs();
                        screenLoadcs.Show();
                        this.Hide();
                    }
                    else
                    {
                        lblErrrorMsg.Visible = true;
                        btnLogIn.BackColor = Color.Red;
                        btnOkey.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }

        private void Frm2LogInMW_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShow.Checked)
            {
                txtPassword.UseSystemPasswordChar= false;
                checkBoxShow.Text = "Hide";
            }
            else
            {
                txtPassword.UseSystemPasswordChar= true;
                checkBoxShow.Text= "Show";
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOkey_Click(object sender, EventArgs e)
        {
            lblPEU.Visible = false;
            lblPEP.Visible = false;
            lblErrrorMsg.Visible = false;
            btnLogIn.Visible = true;
            btnLogIn.BackColor= Color.Black;

            if (btnOkey.Visible == true)
            {
                btnOkey.Visible = false;
            }
            else
            {
                btnOkey.Visible = true;
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Enter username here")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.White;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Enter username here";
                txtUsername.ForeColor = Color.Red;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Enter password here")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.White;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Enter password here";
                txtPassword.ForeColor = Color.Red;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ChooseLoginMemberForm ChooseLoginMemberForm = new ChooseLoginMemberForm();
            ChooseLoginMemberForm.Show();
            this.Hide();
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtUsername.Clear();
        }
    }
}

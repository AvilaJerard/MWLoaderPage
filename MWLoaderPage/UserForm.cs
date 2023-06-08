using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MWLoaderPage
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Avila\\Desktop\\CSS A403\\MWLoaderPage\\MWLoaderPage\\UserDatabase.mdf\";Integrated Security=True");
    //    SqlConnection connect = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Admin\\Desktop\\CSS A403\\MWLoaderPage\\MWLoaderPage\\UserDatabase.mdf\";Integrated Security=True");

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            ChooseLoginMemberForm chooseLoginMemberForm = new ChooseLoginMemberForm();
            chooseLoginMemberForm.Show();
            this.Hide();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShow.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                checkBoxShow.Text = "Hide";
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                checkBoxShow.Text = "Show";
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

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Enter username here" & txtPassword.Text == "Enter password here")
            {
                panel3.Visible = true;
                lblPEU.Visible = true;
                lblPEP.Visible = true;
                lblErrrorMsg.Visible = true;
                lblErrrorMsg.Text = " Please input a valid username and passwork" +
                    "\n                     Please Try again " +
                    "\n";
                btnOkey.Visible = true;
                btnLogIn.Visible = false;
            }
            else
            {
                try
                {
     //             SqlConnection connect = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Admin\\Desktop\\CSS A403\\MWLoaderPage\\MWLoaderPage\\UserDatabase.mdf\";Integrated Security=True");
                    SqlCommand command = new SqlCommand("select * from UserDatabase where username = @username and password =@password", connect);
                    command.Parameters.AddWithValue("@username", txtUsername.Text);
                    command.Parameters.AddWithValue("@password", txtPassword.Text);
                    SqlDataAdapter data = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    data.Fill(dataTable);
                    if (dataTable.Rows.Count > 0)
                    {

                        ScreenLoader2 screenLoader2 = new ScreenLoader2();
                        screenLoader2.Show();
                        this.Hide();
                    }
                    else
                    {
                        lblErrrorMsg.Visible = true;
                        btnLogIn.BackColor = Color.Red;
                        panel3.Visible = true;
                        btnOkey.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOkey_Click(object sender, EventArgs e)
        {
                panel3.Visible = false;
                lblPEU.Visible = false;
                lblPEP.Visible = false;
                lblErrrorMsg.Visible = false;
                btnLogIn.Visible = true;
                btnLogIn.BackColor = Color.Black;

                if (btnOkey.Visible == true)
                {
                    btnOkey.Visible = false;
                }
                else
                {
                    btnOkey.Visible = true;
                }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }
    }
}

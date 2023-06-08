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

namespace MWLoaderPage.Resources
{
    public partial class DashboardMW_Moto_Hub : Form
    {
        public DashboardMW_Moto_Hub()
        {
            InitializeComponent();
        }

       SqlConnection transt = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Avila\\Desktop\\CSS A403\\MWLoaderPage\\MWLoaderPage\\ItemList.mdf\";Integrated Security=True");
     //   SqlConnection transt = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Admin\\Desktop\\CSS A403\\MWLoaderPage\\MWLoaderPage\\ItemList.mdf\";Integrated Security=True");
        private void DashboardMW_Moto_Hub_Load(object sender, EventArgs e)
        {
            BindData();
            Data();
        }

        private void BindData()
        {
            SqlCommand cmd = new SqlCommand("SELECT item_name AS ItemName, stocks AS Stocks, Itemstatus AS ItemStatus, itemId AS ItemId FROM ItemsList", transt);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void btn1Quit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn2minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnItemList_Click(object sender, EventArgs e)
        {
            lblDashboard.Text = " Item List ";
            BindData();
            dataGridView1.Visible = true;
            dataGridView12.Visible = false;
            dataGridView3.Visible = false;
            btnadditemproduct.Visible = true;
            flowLayoutPanel1.Size = new Size(908, 43);
            btnRestocked.Visible = true;
            txtsearchbox.Clear();
        }


        private void btnadditemproduct_Click(object sender, EventArgs e)
        {
            ShowItemList showItemList = new ShowItemList();
            showItemList.Show();
            lblDashboard.Text = " Add Item";
            btnadditemproduct.Visible = false;
            flowLayoutPanel1.Size = new Size (678, 43);
            dataGridView12.Visible = false;
            dataGridView1.Visible = false;
            dataGridView3.Visible = false; 
            btnRestocked.Visible = true;
            txtsearchbox.Clear();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            lblLogOutQ.Visible = true;
            panel3.Visible = true;
            btnYes.Visible = true;
            btnNo.Visible = true;
            btnadditemproduct.Visible = true;
            lblDashboard.Text = " Log Out";
            dataGridView12.Visible = false;
            dataGridView3.Visible = false;
            dataGridView1.Visible = false;
            flowLayoutPanel1.Size = new Size(908, 43);
            btnRestocked.Visible = true;
            txtsearchbox.Clear();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            ChooseLoginMemberForm ChooseLoginMemberForm = new ChooseLoginMemberForm();
            ChooseLoginMemberForm.Show();
            this.Hide();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            lblLogOutQ.Visible=false;
            panel3.Visible = false;
            btnYes.Visible=false;
            btnNo.Visible=false;
            lblDashboard.Text = " Dashboard";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            lblDashboard.Text = " Dashboard";
            flowLayoutPanel1.Visible = true;
            dataGridView12.Visible = false;
            dataGridView1.Visible = false;
            dataGridView3.Visible = false;
            btnadditemproduct.Visible =true;
            flowLayoutPanel1.Size = new Size(908, 43);
            btnRestocked.Visible = true;
            txtsearchbox.Clear();
        }

        public void searchData (string valueToSearch)
        {
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM ItemsList WHERE item_name LIKE @valueToSearch OR stocks LIKE @valueToSearch OR Itemstatus LIKE @valueToSearch OR ItemId LIKE @valueToSearch", transt);
            cmd1.Parameters.AddWithValue("@valueToSearch", "%" + valueToSearch + "%");
            SqlDataAdapter adapter = new SqlDataAdapter(cmd1);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView12.DataSource = table;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtsearchbox.Text))
            {
                MessageBox.Show("Please enter a search term.");
                return;
            }
            string valueToSearch = txtsearchbox.Text;
            searchData(valueToSearch);
            dataGridView12.Visible = true;
            dataGridView1.Visible = false;
            dataGridView3.Visible = false;
            lblDashboard.Text = " Search/Display Items";
            btnadditemproduct.Visible = true;
            flowLayoutPanel1.Size = new Size(908, 43);
            btnRestocked.Visible = true;
            BindData();
        }

        private void btnRestocked_Click(object sender, EventArgs e)
        {
            lblDashboard.Text = " Restock Items";
            dataGridView12.Visible = false;
            dataGridView1.Visible = false;
            dataGridView3.Visible = false;
            txtsearchbox.Clear();
            btnadditemproduct.Visible = true;
            flowLayoutPanel1.Size = new Size(908, 43);
            RestockReDeployment RestockReDeployment = new RestockReDeployment();
            RestockReDeployment.Show();
            flowLayoutPanel1.Size = new Size(678, 43);
            btnRestocked.Visible = false;
        }

        private void btnBin_Click(object sender, EventArgs e)
        {
            lblDashboard.Text = " Bin ";
            Data();
            dataGridView12.Visible = false;
            dataGridView3.Visible = true;
            dataGridView1.Visible = false;
            txtsearchbox.Clear();
            btnadditemproduct.Visible = true;
            flowLayoutPanel1.Size = new Size(908, 43);
            btnRestocked.Visible = true;
        }

        private void Data()
        {
            SqlCommand cmd1 = new SqlCommand("SELECT item_name AS ItemName, stocks AS Stocks, Itemstatus AS ItemStatus, itemId AS ItemId FROM MWRestock", transt);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd1);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView3.DataSource = table;
        }

        private void lblDashboard_Click(object sender, EventArgs e)
        {
            lblDashboard.Text = "Dashboard";
            lblLogOutQ.Visible = false;
            panel3.Visible = false;
            btnYes.Visible = false;
            btnNo.Visible = false;
            txtsearchbox.Clear();
            btnadditemproduct.Visible = true;
            flowLayoutPanel1.Size = new Size(908, 43);
            dataGridView12.Visible = false;
            dataGridView3.Visible = false;
            dataGridView1.Visible = false;
            btnRestocked.Visible = true;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            {
                lblDashboard.Text = "Dashboard";
                lblLogOutQ.Visible = false;
                panel3.Visible = false;
                btnYes.Visible = false;
                btnNo.Visible = false;
                txtsearchbox.Clear();
                btnadditemproduct.Visible = true;
                flowLayoutPanel1.Size = new Size(908, 43);
                dataGridView12.Visible = false;
                dataGridView3.Visible = false;
                dataGridView1.Visible = false;
                btnRestocked.Visible = true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Data.Common;
using MWLoaderPage.Resources;

namespace MWLoaderPage
{
    public partial class ShowItemList : Form
    {
        public ShowItemList()
        {
            InitializeComponent();
        }
        SqlConnection cnt = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Avila\\Desktop\\CSS A403\\MWLoaderPage\\MWLoaderPage\\ItemList.mdf\";Integrated Security=True");
 //       SqlConnection cnt = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Admin\\Desktop\\CSS A403\\MWLoaderPage\\MWLoaderPage\\ItemList.mdf\";Integrated Security=True");
        private void ShowItemList_Load(object sender, EventArgs e)
        {
            BindData();
            txtStocks.ReadOnly = true;
            txtItemStatus.ReadOnly = true;
            txtitemid.ReadOnly = true;
            txtItemName.ReadOnly = true;
            txtNameDescription.ReadOnly = true;

        }

        private void BindData()
        {
            SqlCommand cmd = new SqlCommand("SELECT item_name As ItemName, Name_Description As NameDescription, stocks As Stocks, Itemstatus As ItemStatus, itemId AS ItemID from ItemsList ", cnt);
            SqlDataAdapter DataAdapter = new SqlDataAdapter(cmd);
            DataAdapter.SelectCommand = cmd;
            DataTable dataTable = new DataTable();
            dataTable.Clear();
            DataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtItemName.Text) ||
                string.IsNullOrEmpty(txtNameDescription.Text) ||
                string.IsNullOrEmpty(txtStocks.Text) ||
                string.IsNullOrEmpty(txtItemStatus.Text) ||
                string.IsNullOrEmpty(txtitemid.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            SqlCommand cmd1 = new SqlCommand("INSERT INTO ItemsList (item_name, Name_Description, stocks, Itemstatus, itemId) VALUES (@ItemName, @NameDescription, @Stocks, @ItemStatus, @ItemID)", cnt);
            cmd1.Parameters.AddWithValue("ItemName", txtItemName.Text);
            cmd1.Parameters.AddWithValue("NameDescription", txtNameDescription.Text);
            cmd1.Parameters.AddWithValue("Stocks", txtStocks.Text);
            cmd1.Parameters.AddWithValue("ItemStatus", txtItemStatus.Text);
            cmd1.Parameters.AddWithValue("ItemID", txtitemid.Text);
            MessageBox.Show("Successfully Inserted.");
            lblitemid.Visible = false;
            txtitemid.Visible = false;
            cnt.Open();
            cmd1.ExecuteNonQuery(); 
            cnt.Close();
            BindData();

            txtItemName.Clear();
            txtNameDescription.Clear();
            txtStocks.Clear();
            txtItemStatus.Clear();
            txtitemid.Clear();
            txtStocks.ReadOnly = true;
            txtItemStatus.ReadOnly = true;
            txtitemid.ReadOnly = true;
            txtItemName.ReadOnly = true;
            txtNameDescription.ReadOnly = true;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtItemName.Text) ||
                string.IsNullOrEmpty(txtNameDescription.Text) ||
                string.IsNullOrEmpty(txtStocks.Text) ||
                string.IsNullOrEmpty(txtItemStatus.Text) ||
                string.IsNullOrEmpty(txtitemid.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            SqlCommand cmd3 = new SqlCommand("Delete from ItemsList where item_name=@ItemName" , cnt);
            cmd3.Parameters.AddWithValue("ItemName", txtItemName.Text);
            MessageBox.Show("Successfully Deleted.");
            cnt.Open();
            cmd3.ExecuteNonQuery();
            cnt.Close();
            BindData();

            SqlCommand cmd4 = new SqlCommand("INSERT INTO MWRestock (item_name, Name_Description, stocks, Itemstatus, itemId) VALUES (@ItemName, @NameDescription, @Stocks, @ItemStatus, @ItemID)", cnt);
            cmd4.Parameters.AddWithValue("ItemName", txtItemName.Text);
            cmd4.Parameters.AddWithValue("NameDescription", txtNameDescription.Text);
            cmd4.Parameters.AddWithValue("Stocks", txtStocks.Text);
            cmd4.Parameters.AddWithValue("ItemStatus", txtItemStatus.Text);
            cmd4.Parameters.AddWithValue("ItemID", txtitemid.Text);
            cnt.Open();
            cmd4.ExecuteNonQuery();
            cnt.Close();
            BindData();

            txtItemName.Clear();
            txtNameDescription.Clear();
            txtStocks.Clear();
            txtItemStatus.Clear();
            txtitemid.Clear();
            txtStocks.ReadOnly = true;
            txtItemStatus.ReadOnly = true;
            txtitemid.ReadOnly = true;
            txtItemName.ReadOnly = true;
            txtNameDescription.ReadOnly = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtItemName.Text) ||
                string.IsNullOrEmpty(txtNameDescription.Text) ||
                string.IsNullOrEmpty(txtStocks.Text) ||
                string.IsNullOrEmpty(txtItemStatus.Text) ||
                string.IsNullOrEmpty(txtitemid.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            int itemId = int.Parse(txtitemid.Text);
            SqlCommand cmd2 = new SqlCommand("Update ItemsList Set item_name = @ItemName, Name_Description = @NameDescription, stocks = @Stocks, Itemstatus = @ItemStatus Where itemId = @ItemId", cnt);
            cmd2.Parameters.AddWithValue("ItemName", txtItemName.Text);
            cmd2.Parameters.AddWithValue("NameDescription", txtNameDescription.Text);
            cmd2.Parameters.AddWithValue("Stocks", txtStocks.Text);
            cmd2.Parameters.AddWithValue("ItemStatus", txtItemStatus.Text);
            cmd2.Parameters.AddWithValue("ItemId", itemId);
            try
            {
                cnt.Open();
                cmd2.ExecuteNonQuery();
                cnt.Close();
                MessageBox.Show("Successfully updated.");
                BindData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtItemName.Clear();
            txtNameDescription.Clear();
            txtStocks.Clear();
            txtItemStatus.Clear();
            txtitemid.Clear();
            txtStocks.ReadOnly = true;
            txtItemStatus.ReadOnly = true;
            txtitemid.ReadOnly = true;
            txtItemName.ReadOnly = true;
            txtNameDescription.ReadOnly = true;

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            btnAddItems.Visible = false;
            lblitemid.Visible = false;
            txtitemid.Visible = false;
            int index;
            index = e.RowIndex;
            DataGridViewRow selectedrow = dataGridView1.Rows[index];
            txtItemName.Text = selectedrow.Cells[0].Value.ToString();
            txtNameDescription.Text = selectedrow.Cells[1].Value.ToString();
            txtStocks.Text = selectedrow.Cells[2].Value.ToString();
            txtItemStatus.Text = selectedrow.Cells[3].Value.ToString();
            txtitemid.Text = selectedrow.Cells[4].Value.ToString();
            txtStocks.ReadOnly = false;
            txtItemStatus.ReadOnly = false;
            txtitemid.ReadOnly = true;
            txtItemName.ReadOnly = false;
            txtNameDescription.ReadOnly = false;
        }

        private void btnInsertNewProduct_Click(object sender, EventArgs e)
        {
            txtItemName.Clear();
            txtNameDescription.Clear();
            txtStocks.Clear();
            txtItemStatus.Clear();
            txtitemid.Clear();
            txtitemid.Visible = true;
            lblitemid.Visible = true;
            btnAddItems.Visible = true;
            txtStocks.ReadOnly = false;
            txtItemStatus.ReadOnly = false;
            txtitemid.ReadOnly = false;
            txtItemName.ReadOnly = false;
            txtNameDescription.ReadOnly = false;
            txtStocks.BackColor = Color.White;
            txtStocks.ForeColor = Color.Black;
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            txtItemName.Clear();
            txtNameDescription.Clear();
            txtStocks.Clear();
            txtItemStatus.Clear();
            txtitemid.Clear();
            txtitemid.Visible = false;
            lblitemid.Visible = false;
            btnAddItems.Visible = false;
            txtStocks.ReadOnly = true;
            txtItemStatus.ReadOnly = true;
            txtitemid.ReadOnly = true;
            txtItemName.ReadOnly = true;
            txtNameDescription.ReadOnly = true;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtStocks_TextChanged(object sender, EventArgs e)
        {
            txtStocks.ReadOnly = false;
            if (string.IsNullOrEmpty(txtStocks.Text))
            {
                txtStocks.Text = "1";
            }
            int value = Convert.ToInt32(txtStocks.Text);

            if (value == 0)
            {
                txtStocks.BackColor = Color.Red;
                txtStocks.ForeColor = Color.White;
                txtItemStatus.Text = "Unavailable";
                MessageBox.Show(" Warnig This Products is Out of Stock Please Deploy to Bin");
                btnDelete.Visible = true;
                btnUpdate.Visible = false;
            }

            else if (value < 11)
            {
                txtStocks.BackColor = Color.Red;
                txtStocks.ForeColor = Color.White;
                txtItemStatus.Text = "Unavailable";
                btnDelete.Visible = true;
                btnUpdate.Visible = false;
            }

            else if (value == 12)
            {
                txtStocks.BackColor = Color.Green;
                txtStocks.ForeColor = Color.White;
                txtItemStatus.Text = "Available";
                btnUpdate.Visible = true;
                btnDelete.Visible = false;
            }

            else if (value <= 99)
            {
                txtStocks.BackColor = Color.Green;
                txtStocks.ForeColor = Color.White;
                txtItemStatus.Text = "Available";
                btnDelete.Visible = false;
                btnUpdate.Visible = true;
            }

            else if (value == 100)
            {
                txtStocks.BackColor = Color.Green;
                txtStocks.ForeColor = Color.White;
                txtItemStatus.Text = "Available";
                btnDelete.Visible = false;
                btnUpdate.Visible = true;
            }

        }
    }
    
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace MWLoaderPage
{
    public partial class RestockReDeployment : Form
    {
        public RestockReDeployment()
        {
            InitializeComponent();
        }
        SqlConnection RRD = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Avila\\Desktop\\CSS A403\\MWLoaderPage\\MWLoaderPage\\ItemList.mdf\";Integrated Security=True");
   //     SqlConnection RRD = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Admin\\Desktop\\CSS A403\\MWLoaderPage\\MWLoaderPage\\ItemList.mdf\";Integrated Security=True");
        private void SeeData()
        {
            SqlCommand commad = new SqlCommand("SELECT item_name As ItemName, Name_Description As NameDescription, stocks As Stocks, Itemstatus As ItemStatus, itemId AS ItemID from MWRestock ", RRD);
            SqlDataAdapter DataAdapter = new SqlDataAdapter(commad);
            DataAdapter.SelectCommand = commad;
            DataTable dataTable = new DataTable();
            dataTable.Clear();
            DataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void RestockReDeployment_Load(object sender, EventArgs e)
        {
            SeeData();
            txtStocks.ReadOnly = true;
            txtitemid.ReadOnly = true;
            txtItemStatus.ReadOnly = true;
            txtItemName.ReadOnly = true;
            txtNameDescription.ReadOnly = true;
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

            int itemId = int.Parse(txtitemid.Text);
            SqlCommand SData = new SqlCommand("Update MWRestock Set item_name = @ItemName, Name_Description = @NameDescription, stocks = @Stocks, Itemstatus = @ItemStatus Where itemId = @ItemId", RRD);
            SData.Parameters.AddWithValue("ItemName", txtItemName.Text);
            SData.Parameters.AddWithValue("NameDescription", txtNameDescription.Text);
            SData.Parameters.AddWithValue("Stocks", txtStocks.Text);
            SData.Parameters.AddWithValue("ItemStatus", txtItemStatus.Text);
            SData.Parameters.AddWithValue("ItemId", itemId);
            try
            {
                RRD.Open();
                SData.ExecuteNonQuery();
                RRD.Close();
                MessageBox.Show("Successfully updated.");
                SeeData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            SqlCommand command1 = new SqlCommand("Delete from MWRestock where item_name=@ItemName", RRD);
            command1.Parameters.AddWithValue("ItemName", txtItemName.Text);
            MessageBox.Show("Successfully Deleted and Re_Deploy to the Item Stock.");
            RRD.Open();
            command1.ExecuteNonQuery();
            RRD.Close();
            SeeData();

            SqlCommand cmd4 = new SqlCommand("INSERT INTO ItemsList (item_name, Name_Description, stocks, Itemstatus, itemId) VALUES (@ItemName, @NameDescription, @Stocks, @ItemStatus, @ItemID)", RRD);
            cmd4.Parameters.AddWithValue("ItemName", txtItemName.Text);
            cmd4.Parameters.AddWithValue("NameDescription", txtNameDescription.Text);
            cmd4.Parameters.AddWithValue("Stocks", txtStocks.Text);
            cmd4.Parameters.AddWithValue("ItemStatus", txtItemStatus.Text);
            cmd4.Parameters.AddWithValue("ItemID", txtitemid.Text);
            RRD.Open();
            cmd4.ExecuteNonQuery();
            RRD.Close();
            SeeData();

            txtItemName.Clear();
            txtNameDescription.Clear();
            txtStocks.Clear();
            txtItemStatus.Clear();
            txtitemid.Clear();
            txtStocks.ReadOnly = true;
            txtitemid.ReadOnly = true;
            txtItemStatus.ReadOnly = true;
            txtItemName.ReadOnly = true;
            txtNameDescription.ReadOnly = true;
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
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
            SqlCommand SData = new SqlCommand("Update MWRestock Set item_name = @ItemName, Name_Description = @NameDescription, stocks = @Stocks, Itemstatus = @ItemStatus Where itemId = @ItemId", RRD);
            SData.Parameters.AddWithValue("ItemName", txtItemName.Text);
            SData.Parameters.AddWithValue("NameDescription", txtNameDescription.Text);
            SData.Parameters.AddWithValue("Stocks", txtStocks.Text);
            SData.Parameters.AddWithValue("ItemStatus", txtItemStatus.Text);
            SData.Parameters.AddWithValue("ItemId", itemId);
            try
            {
                RRD.Open();
                SData.ExecuteNonQuery();
                RRD.Close();
                MessageBox.Show("Successfully updated.");
                SeeData();
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
            txtitemid.ReadOnly = true;
            txtItemStatus.ReadOnly = true;
            txtItemName.ReadOnly = true;
            txtNameDescription.ReadOnly = true;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            DataGridViewRow selectedrow = dataGridView1.Rows[index];
            txtItemName.Text = selectedrow.Cells[0].Value.ToString();
            txtNameDescription.Text = selectedrow.Cells[1].Value.ToString();
            txtStocks.Text = selectedrow.Cells[2].Value.ToString();
            txtItemStatus.Text = selectedrow.Cells[3].Value.ToString();
            txtitemid.Text = selectedrow.Cells[4].Value.ToString();
            lblitemid.Visible = false;
            txtitemid.Visible = false;
            txtStocks.ReadOnly = false;
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
                MessageBox.Show(" Warnig This Products is Out of Stock Please Refill");
                btnDelete.Visible = false;
                btnUpdate.Visible = true;
            }
            else if (value < 11)
            {
                txtStocks.BackColor = Color.Red;
                txtStocks.ForeColor = Color.White;
                txtItemStatus.Text = "Unavailable";
                btnDelete.Visible = false;
                btnUpdate.Visible = true;
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
                MessageBox.Show("This product is Ready to Deploy at the Item Stock ");
                btnDelete.Visible = true;
                btnUpdate.Visible = false;
            }
        }

        private void txtItemStatus_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStocks.BackColor = Color.White;
            txtStocks.ForeColor = Color.Black;
            txtStocks.Clear();
            txtItemName.Clear();
            txtNameDescription.Clear();
            txtItemStatus.Clear();
            txtitemid.Clear();
            btnDelete.Visible = false;
            txtStocks.ReadOnly = true;
            txtitemid.ReadOnly = true;
            txtItemStatus.ReadOnly = true;
            txtItemName.ReadOnly = true;
            txtNameDescription.ReadOnly = true;
        }

        private void txtitemid_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtNameDescription_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtItemName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRecordDeleted_Click(object sender, EventArgs e)
        {
            SqlCommand command1 = new SqlCommand("Delete from MWRestock where item_name=@ItemName", RRD);
            command1.Parameters.AddWithValue("ItemName", txtItemName.Text);
            MessageBox.Show("Successfully Deleted. ");
            RRD.Open();
            command1.ExecuteNonQuery();
            RRD.Close();
            SeeData();
            txtStocks.Clear();
            txtItemName.Clear();
            txtNameDescription.Clear();
            txtItemStatus.Clear();
            txtitemid.Clear();
            btnDelete.Visible = false;
            txtStocks.ReadOnly = true;
            txtitemid.ReadOnly = true;
            txtItemStatus.ReadOnly = true;
            txtItemName.ReadOnly = true;
            txtNameDescription.ReadOnly = true;
        }
    }
}
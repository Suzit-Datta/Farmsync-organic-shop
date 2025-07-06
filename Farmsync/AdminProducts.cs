using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Farmsync
{
    public partial class AdminProducts : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=SUZITDATTA\\SQLEXPRESS;Initial Catalog=DB_Farmsync;Integrated Security=True;Trust Server Certificate=True");

        private string currentUsername;
        public AdminProducts(string currentUsername)
        {
            InitializeComponent();
            this.currentUsername = currentUsername;
            dataSellers.CellClick += dataSellers_CellClick;
            dataProducts.CellClick += dataProducts_CellClick;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Admin dashboardPage = new Admin(currentUsername);
            dashboardPage.Show();
            this.Hide();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            AdminProfile profilePage = new AdminProfile(currentUsername);
            profilePage.Show();
            this.Hide();
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            AdminRevenue revenuePage = new AdminRevenue(currentUsername);
            revenuePage.Show();
            this.Hide();
        }

        private void btnSellers_Click(object sender, EventArgs e)
        {
            AdminSellers sellersPage = new AdminSellers(currentUsername);
            sellersPage.Show();
            this.Hide();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            AdminCustomers customersPage = new AdminCustomers(currentUsername);
            customersPage.Show();
            this.Hide();
        }

        private void btnAdmins_Click(object sender, EventArgs e)
        {
            AdminAdmins adminsPage = new AdminAdmins(currentUsername);
            adminsPage.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loginForm loginPage = new loginForm();
            loginPage.Show();
            this.Hide();
        }

        // show all products data
        private void showProductsData()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select productId, productName, productQuantity, productPrice, productCatagory, productImage, productOf from product_table", connect);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            dataProducts.DataSource = ds.Tables[0];
            dataProducts.RowTemplate.Height = 80;
            dataProducts.Columns["productImage"].Width = 100;
            DataGridViewImageColumn imgCol = (DataGridViewImageColumn)dataProducts.Columns["productImage"];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        // show all sellers data
        private void showSellersData()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT sellerId, username, fullName, location, gender, dateOfBirth, revenue FROM seller_table", connect);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            dataSellers.DataSource = ds.Tables[0];

        }

        // show specific seller's product
        private void showSalesDataOfSeller(string username)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM product_table WHERE productOf = @username", connect);
            cmd.Parameters.AddWithValue("@username", username);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            try
            {
                adapter.Fill(ds);
                dataProducts.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error loading sales data: " + ex.Message);
                dataProducts.DataSource = null;
            }
        }

        private void dataSellers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string sellerInfo = "";
                DataGridViewRow row = dataSellers.Rows[e.RowIndex];
                sellerInfo = row.Cells["username"].Value.ToString();
                showSalesDataOfSeller(sellerInfo);
            }
        }

        string productId = "";
        private void dataProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataProducts.Rows[e.RowIndex];
                productId = row.Cells["productId"].Value.ToString();
            }
        }
        private void AdminProducts_Load(object sender, EventArgs e)
        {
            connect.Open();
            showSellersData();
            showProductsData();

            connect.Close();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            connect.Open();
            showProductsData();
            connect.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (productId == "")
            {
                MessageBox.Show("Please enter or select a product ID.");
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete Product ID '{productId}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM product_table WHERE productId = @productId", connect);
                cmd.Parameters.AddWithValue("@productId", productId);

                try
                {
                    connect.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product deleted successfully.");
                        showProductsData(); // Optional: refresh product list
                    }
                    else
                    {
                        MessageBox.Show("No product found with that ID.");
                    }
                    connect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting product: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Product delete canceled.");
            }
            productId = "";
        }
    }
}

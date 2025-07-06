using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Farmsync
{
    public partial class AdminRevenue : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=SUZITDATTA\\SQLEXPRESS;Initial Catalog=DB_Farmsync;Integrated Security=True;Trust Server Certificate=True");

        private string currentUsername;
        public AdminRevenue(string currentUsername)
        {
            InitializeComponent();
            this.currentUsername = currentUsername;
            dataSellers.CellClick += dataSellers_CellClick;
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

        private void btnSellers_Click(object sender, EventArgs e)
        {
            AdminSellers sellersPage = new AdminSellers(currentUsername);
            sellersPage.Show();
            this.Hide();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            AdminProducts productsPage = new AdminProducts(currentUsername);
            productsPage.Show();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // show all sales data
        private void showSalesData()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from order_table", connect);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            dataSales.DataSource = ds.Tables[0];

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

        // show specefic seller's sales data
        private void showSalesDataOfSeller(string username)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM order_table WHERE seller = @username", connect);
            cmd.Parameters.AddWithValue("@username", username);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            try
            {
                adapter.Fill(ds);
                dataSales.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error loading sales data: " + ex.Message);
                dataSales.DataSource = null;
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

        private void AdminRevenue_Load(object sender, EventArgs e)
        {
            connect.Open();

            SqlCommand cmd = new SqlCommand("select count(*) from order_table", connect);
            int countSales = (int)cmd.ExecuteScalar();
            lblSales.Text = countSales.ToString();

            showSalesData();
            showSellersData();

            connect.Close();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            connect.Open();
            showSalesData();
            connect.Close();
        }
    }
}

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
    public partial class SellerRevenue : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=SUZITDATTA\\SQLEXPRESS;Initial Catalog=DB_Farmsync;Integrated Security=True;Trust Server Certificate=True");

        string currentUsername;
        public SellerRevenue(string currentUsername)
        {
            InitializeComponent();
            this.currentUsername = currentUsername;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            SellerProfile sellerProfile = new SellerProfile(currentUsername);
            sellerProfile.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Seller seller = new Seller(currentUsername);
            seller.Show();
            this.Hide();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            SellerSale sellerSale = new SellerSale(currentUsername);
            sellerSale.Show();
            this.Hide();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            SellerProducts sellerProducts = new SellerProducts(currentUsername);
            sellerProducts.Show();
            this.Hide();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            SellerCustomers sellerCustomers = new SellerCustomers(currentUsername);
            sellerCustomers.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loginForm loginForm = new loginForm();
            loginForm.Show();
            this.Hide();
        }

        private void showSalesData()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select orderDate, totalPrice, customer from order_table where seller = @username", connect);
            adapter.SelectCommand.Parameters.AddWithValue("@username", currentUsername);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            dataSales.DataSource = ds.Tables[0];
        }

        private void SellerRevenue_Load(object sender, EventArgs e)
        {
            connect.Open();
            String revenueQuery, salesQuery, productQuery, customerQuery;
            int countSales, countProducts, countCustomers;

            revenueQuery = "select revenue from seller_table where username = @username";
            salesQuery = "select count(*) from order_table";

            SqlCommand cmd = new SqlCommand(revenueQuery, connect);
            cmd.Parameters.AddWithValue("@username", currentUsername);
            object result = cmd.ExecuteScalar();
            string revenue = (result != null && result != DBNull.Value) ? result.ToString() : "0";

            cmd = new SqlCommand(salesQuery, connect);
            countSales = (int)cmd.ExecuteScalar();


            lblRevenue.Text = "$" + revenue.ToString();
            lblSales.Text = countSales.ToString();

            showSalesData();
            connect.Close();
        }
    }
}

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
    public partial class Seller : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=SUZITDATTA\\SQLEXPRESS;Initial Catalog=DB_Farmsync;Integrated Security=True;Trust Server Certificate=True");
        string currentUsername;
        public Seller(string userName)
        {
            InitializeComponent();
            currentUsername = userName;
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

        private void Seller_Load(object sender, EventArgs e)
        {
            connect.Open();
            showSalesData();
            String revenueQuery, salesQuery, productQuery, customerQuery;
            int countSales, countProducts, countCustomers;

            revenueQuery = "select revenue from seller_table where username = @username";
            salesQuery = "select count(*) from order_table";
            productQuery = "select count(*) from product_table";
            customerQuery = "select count(*) from buyer_table";

            SqlCommand cmd = new SqlCommand(revenueQuery, connect);
            cmd.Parameters.AddWithValue("@username", currentUsername);
            object result = cmd.ExecuteScalar();
            string revenue = (result != null && result != DBNull.Value) ? result.ToString() : "0";

            cmd = new SqlCommand(salesQuery, connect);
            countSales = (int)cmd.ExecuteScalar();

            cmd = new SqlCommand(productQuery, connect);
            countProducts = (int)cmd.ExecuteScalar();

            cmd = new SqlCommand(customerQuery, connect);
            countCustomers = (int)cmd.ExecuteScalar();

            lblRevenue.Text = "$"+revenue.ToString();
            lblSales.Text = countSales.ToString();
            lblProducts.Text = countProducts.ToString();
            lblCustomers.Text = countCustomers.ToString();

            cmd = new SqlCommand("select fullName from seller_table WHERE username = @username", connect);
            cmd.Parameters.AddWithValue("@username", currentUsername);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lblFullName.Text = reader["fullName"].ToString();
            }
            reader.Close();
            connect.Close();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            SellerProfile sellerProfile = new SellerProfile(currentUsername);
            sellerProfile.Show();
            this.Hide();
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            SellerRevenue sellerRevenue = new SellerRevenue(currentUsername);
            sellerRevenue.Show();
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
            SellerProducts sellerProduct = new SellerProducts(currentUsername);
            sellerProduct.Show();
            this.Hide();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            SellerCustomers sellerCustomer = new SellerCustomers(currentUsername);
            sellerCustomer.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loginForm loginForm = new loginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}

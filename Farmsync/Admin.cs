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
    public partial class Admin : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=SUZITDATTA\\SQLEXPRESS;Initial Catalog=DB_Farmsync;Integrated Security=True;Trust Server Certificate=True");

        private String currentUsername;
        private int countSallers, countSales, countProducts, countCustomers;

        public Admin(string userName)  // constructor
        {
            InitializeComponent();
            currentUsername = userName;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            AdminSellers sellerPage = new AdminSellers(currentUsername);
            sellerPage.Show();
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
            AdminCustomers customerPage = new AdminCustomers(currentUsername);
            customerPage.Show();
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
            loginForm login = new loginForm();
            login.Show();
            this.Hide();
        }

        private void showSalesData()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from order_table", connect);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            dataSales.DataSource = ds.Tables[0];
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            connect.Open();
            showSalesData();
            String sallersQuery, salesQuery, productQuery, customerQuery;
            sallersQuery = "select count(*) from seller_table";
            salesQuery = "select count(*) from order_table";
            productQuery = "select count(*) from product_table";
            customerQuery = "select count(*) from buyer_table";

            SqlCommand cmd = new SqlCommand(sallersQuery, connect);
            countSallers = (int)cmd.ExecuteScalar();

            cmd = new SqlCommand(salesQuery, connect);
            countSales = (int)cmd.ExecuteScalar();

            cmd = new SqlCommand(productQuery, connect);
            countProducts = (int)cmd.ExecuteScalar();

            cmd = new SqlCommand(customerQuery, connect);
            countCustomers = (int)cmd.ExecuteScalar();

            lblSallers.Text = countSallers.ToString();
            lblSales.Text = countSales.ToString();
            lblProducts.Text = countProducts.ToString();
            lblCustomers.Text = countCustomers.ToString();

            cmd = new SqlCommand("select fullName from admin_table WHERE userName = @username", connect);
            cmd.Parameters.AddWithValue("@username", currentUsername);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lblFullName.Text = reader["fullName"].ToString();
            }
            reader.Close();
            connect.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class AdminCustomers : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=SUZITDATTA\\SQLEXPRESS;Initial Catalog=DB_Farmsync;Integrated Security=True;Trust Server Certificate=True");

        private String currentUsername;
        public AdminCustomers(string userName)
        {
            InitializeComponent();
            this.currentUsername = userName;
            dataCustomers.CellClick += dataCustomers_CellClick;
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

        private void btnProducts_Click(object sender, EventArgs e)
        {
            AdminProducts productsPage = new AdminProducts(currentUsername);
            productsPage.Show();
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

        // show all customer details
        private void showCustomersData()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM buyer_table", connect);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            dataCustomers.DataSource = ds.Tables[0];
        }

        string phone = "";
        private void dataCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataCustomers.Rows[e.RowIndex];
                phone = row.Cells["phone"].Value.ToString();
                comboBoxMembership.Text = row.Cells["membership"].Value.ToString();
            }
        }
        private void AdminCustomers_Load(object sender, EventArgs e)
        {
            connect.Open();
            showCustomersData();
            connect.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string membership = comboBoxMembership.Text;
            if (phone == "")
            {
                MessageBox.Show("Customer not selected. Please select a customer first.");
                return;
            }

            SqlCommand cmd = new SqlCommand("UPDATE buyer_table SET membership = @membership WHERE phone = @phone", connect);

            cmd.Parameters.AddWithValue("@membership", membership);
            cmd.Parameters.AddWithValue("@phone", phone);

            try
            {
                connect.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Membership updated successfully.");
                }
                else
                {
                    MessageBox.Show("Update failed. Username not found.");
                }
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            showCustomersData();
            phone = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (phone == "")
            {
                MessageBox.Show("Please enter or select a Customer.");
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete phone '{phone}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM buyer_table WHERE phone = @phone", connect);
                cmd.Parameters.AddWithValue("@phone", phone);

                try
                {
                    connect.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Customer deleted successfully.");
                        showCustomersData(); // Optional: refresh product list
                    }
                    else
                    {
                        MessageBox.Show("No customer found with that phone numbers.");
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
            phone = "";
        }
    }
}

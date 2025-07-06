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
    public partial class SellerCustomers : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=SUZITDATTA\\SQLEXPRESS;Initial Catalog=DB_Farmsync;Integrated Security=True;Trust Server Certificate=True");

        string currentUsername;
        public SellerCustomers(string currentUsername)
        {
            InitializeComponent();
            this.currentUsername = currentUsername;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Seller seller = new Seller(currentUsername);
            seller.Show();
            this.Hide();
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
            SellerProducts sellerProducts = new SellerProducts(currentUsername);
            sellerProducts.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loginForm loginForm = new loginForm();
            loginForm.Show();
            this.Hide();
        }
        private void btnCustomers_Click(object sender, EventArgs e)
        {

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
                txtFullName.Text = row.Cells["fullName"].Value.ToString();
                txtPhone.Text = row.Cells["phone"].Value.ToString();
                comboBoxMembership.Text = row.Cells["membership"].Value.ToString();
                comboBoxLocation.Text = row.Cells["userLocation"].Value.ToString();
            }
        }

        private void SellerCustomers_Load(object sender, EventArgs e)
        {
            connect.Open();
            showCustomersData();
            connect.Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            connect.Open();
            if (txtPhone.Text == "")
            {
                MessageBox.Show("Enter Phone number.", "Try again!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtFullName.Text == "")
            {
                MessageBox.Show("Enter Full Name.", "Try again!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    bool isCustomer = false;

                    // check user name exist in customer table
                    String checkUserSeller = "select * from buyer_table where phone = @phone";
                    SqlCommand cmdSeller = new SqlCommand(checkUserSeller, connect);
                    cmdSeller.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());

                    SqlDataReader readerSeller = cmdSeller.ExecuteReader();
                    isCustomer = readerSeller.HasRows;
                    readerSeller.Close();

                    if (isCustomer)
                    {
                        MessageBox.Show("Customer already exist.", "Try again!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        String insertData = "insert into buyer_table (fullname, phone, userLocation, membership) values (@fullName, @phone, @userLocation, @membership)";
                        SqlCommand insertCmd = new SqlCommand(insertData, connect);
                        insertCmd.Parameters.AddWithValue("@fullName", txtFullName.Text.Trim());
                        insertCmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                        insertCmd.Parameters.AddWithValue("@userLocation", comboBoxLocation.Text.Trim());
                        insertCmd.Parameters.AddWithValue("@membership", comboBoxMembership.Text.Trim());

                        insertCmd.ExecuteNonQuery();
                        MessageBox.Show("Congratulations! Customer have been registered.", "Registration done.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection error." + ex);
                }
            }
            txtFullName.Text = "";
            txtPhone.Text = "";
            comboBoxMembership.Text = "None";
            comboBoxLocation.Text = "";

            showCustomersData();
            connect.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (phone == "")
            {
                MessageBox.Show("Please enter or select a Customer.");
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete '{phone}'?",
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text;
            string phn = txtPhone.Text;
            string location = comboBoxLocation.Text;
            string membership = comboBoxMembership.Text;


            connect.Open();
            SqlCommand cmd = new SqlCommand("UPDATE buyer_table SET fullName = @fullName, phone = @phn, userLocation = @location, membership = @membership WHERE phone = @phone", connect);
            cmd.Parameters.AddWithValue("@fullName", fullName);
            cmd.Parameters.AddWithValue("@phn", phn);
            cmd.Parameters.AddWithValue("@location", location);
            cmd.Parameters.AddWithValue("@membership", membership);
            cmd.Parameters.AddWithValue("@phone", phone);

            try
            {
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Customer details updated successfully!");
                }
                else
                {
                    MessageBox.Show("Update failed. Customer not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            showCustomersData();
            connect.Close();

            txtFullName.Text = "";
            txtPhone.Text = "";
            comboBoxLocation.Text = "";
            comboBoxMembership.Text = "";
        }

        private void comboBoxLocation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

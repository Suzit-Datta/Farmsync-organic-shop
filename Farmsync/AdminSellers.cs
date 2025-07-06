using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Farmsync
{
    public partial class AdminSellers : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=SUZITDATTA\\SQLEXPRESS;Initial Catalog=DB_Farmsync;Integrated Security=True;Trust Server Certificate=True");

        private String currentUsername;
        public AdminSellers(string currentUsername)
        {
            InitializeComponent();
            this.currentUsername = currentUsername;
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

        // show all sellers data
        private void showSellersData()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT sellerId, username, fullName, location, gender, dateOfBirth, revenue FROM seller_table", connect);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            dataSellers.DataSource = ds.Tables[0];
        }

        private void dataSellers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataSellers.Rows[e.RowIndex];
                txtUserName.Text = row.Cells["username"].Value.ToString();
                txtFullName.Text = row.Cells["fullName"].Value.ToString();
                comboBoxLocation.Text = row.Cells["location"].Value.ToString();
                string dateString = row.Cells["dateOfBirth"].Value.ToString();

                if (DateTime.TryParse(dateString, out DateTime parsedDate))
                {
                    dateDob.Value = parsedDate;
                }

                string gender = row.Cells["gender"].Value.ToString();
                if (gender == "Male")
                {
                    radioBtnMale.Checked = true;
                }
                else if (gender == "Female")
                {
                    radioBtnFemale.Checked = true;
                }
                else
                {
                    radioBtnMale.Checked = false;
                    radioBtnFemale.Checked = false;
                }
            }
        }

        private void AdminSellers_Load(object sender, EventArgs e)
        {
            connect.Open();
            showSellersData();
            connect.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            connect.Open();
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Enter User Name.", "Try again!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtFullName.Text == "")
            {
                MessageBox.Show("Enter Full Name.", "Try again!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Enter Password.", "Try again!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (comboBoxLocation.Text == "")
            {
                MessageBox.Show("Enter Location.", "Try again!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!radioBtnFemale.Checked && !radioBtnMale.Checked)
            {
                MessageBox.Show("Enter Gender.", "Try again!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    bool isAdmin, isSeller;
                    isAdmin = isSeller = false;


                    // check user name exist in admin table
                    String checkUserAdmin = "select * from admin_table where userName = @userName";
                    SqlCommand cmdAdmin = new SqlCommand(checkUserAdmin, connect);
                    cmdAdmin.Parameters.AddWithValue("@userName", txtUserName.Text.Trim());

                    SqlDataReader readerAdmin = cmdAdmin.ExecuteReader();
                    isAdmin = readerAdmin.HasRows;
                    readerAdmin.Close();

                    // check user name exist in seller table
                    String checkUserSeller = "select * from seller_table where username = @userName";
                    SqlCommand cmdSeller = new SqlCommand(checkUserSeller, connect);
                    cmdSeller.Parameters.AddWithValue("@userName", txtUserName.Text.Trim());

                    SqlDataReader readerSeller = cmdSeller.ExecuteReader();
                    isSeller = readerSeller.HasRows;
                    readerSeller.Close();

                    if (isAdmin || isSeller)
                    {
                        MessageBox.Show("User Name already exist.", "Try again!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        String insertData = "insert into seller_table (username, fullname, location, password, gender, dateOfBirth) values (@userName, @fullName, @location, @password, @gender, @dateOfBirth)";
                        SqlCommand insertCmd = new SqlCommand(insertData, connect);
                        insertCmd.Parameters.AddWithValue("@userName", txtUserName.Text.Trim());
                        insertCmd.Parameters.AddWithValue("@fullName", txtFullName.Text.Trim());
                        insertCmd.Parameters.AddWithValue("@location", comboBoxLocation.Text.Trim());
                        insertCmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());

                        String gen = (radioBtnFemale.Checked) ? radioBtnFemale.Text.Trim() : radioBtnMale.Text.Trim();
                        insertCmd.Parameters.AddWithValue("@gender", gen);

                        insertCmd.Parameters.AddWithValue("@dateOfBirth", dateDob.Value.Date);

                        insertCmd.ExecuteNonQuery();
                        MessageBox.Show("Congratulations! Seller have been registered.", "Registration done.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection error." + ex);
                }
            }
            showSellersData();
            connect.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string fullName = txtFullName.Text;
            string location = comboBoxLocation.Text;
            DateTime dob = dateDob.Value;
            string gender = "";
            if (radioBtnMale.Checked) gender = "Male";
            else if (radioBtnFemale.Checked) gender = "Female";


            connect.Open();
            SqlCommand cmd = new SqlCommand("UPDATE seller_table SET fullName = @fullName, location = @location, dateOfBirth = @dob, gender = @gender WHERE username = @userName", connect);
            cmd.Parameters.AddWithValue("@fullName", fullName);
            cmd.Parameters.AddWithValue("@location", location);
            cmd.Parameters.AddWithValue("@dob", dob);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@userName", userName);

            try
            {
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("User details updated successfully!");
                }
                else
                {
                    MessageBox.Show("Update failed. User not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            showSellersData();
            connect.Close();

            txtUserName.Text = "";
            txtFullName.Text = "";
            comboBoxLocation.Text = "";
            dateDob.Value = DateTime.Today;
            radioBtnMale.Checked = false;
            radioBtnFemale.Checked = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text; 

            if (userName == "")
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete user '{userName}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (result == DialogResult.Yes) {
                connect.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM seller_table WHERE username = @userName", connect);
                cmd.Parameters.AddWithValue("@userName", userName);

                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Seller deleted successfully.");
                        showSellersData();
                    }
                    else
                    {
                        MessageBox.Show("No seller found with that username.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting seller: " + ex.Message);
                }
                connect.Close();
            }

        }
    }
}

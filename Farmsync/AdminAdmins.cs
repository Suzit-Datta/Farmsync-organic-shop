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
    public partial class AdminAdmins : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=SUZITDATTA\\SQLEXPRESS;Initial Catalog=DB_Farmsync;Integrated Security=True;Trust Server Certificate=True");

        private String currentUsername;

        public AdminAdmins(string userName)
        {
            InitializeComponent();
            this.currentUsername = userName;
            dataAdmins.CellClick += dataAdmins_CellClick;
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loginForm loginPage = new loginForm();
            loginPage.Show();
            this.Hide();
        }

        // show all admins data
        private void showAdminsData()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT userName, fullName, adminImage, dateOfBirth, phone FROM admin_table", connect);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            dataAdmins.DataSource = ds.Tables[0];
            dataAdmins.RowTemplate.Height = 100;
            dataAdmins.Columns["adminImage"].Width = 200;
            DataGridViewImageColumn imgCol = (DataGridViewImageColumn)dataAdmins.Columns["adminImage"];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        string adminInfo = "";
        private void dataAdmins_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataAdmins.Rows[e.RowIndex];
                adminInfo = row.Cells["userName"].Value.ToString();
            }
        }

        private void AdminAdmins_Load(object sender, EventArgs e)
        {
            connect.Open();
            showAdminsData();
            connect.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (adminInfo == currentUsername)
            {
                MessageBox.Show("You can't delete your account!");
                return;
            }

            if (adminInfo == "")
            {
                MessageBox.Show("Please enter or select a admin.");
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete admin user '{adminInfo}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM admin_table WHERE userName = @userName", connect);
                cmd.Parameters.AddWithValue("@userName", adminInfo);

                try
                {
                    connect.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Admin deleted successfully.");
                        showAdminsData();
                    }
                    else
                    {
                        MessageBox.Show("No admin found with that ID.");
                    }
                    connect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting admin: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Admin delete canceled.");
            }
            adminInfo = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
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
            else
            {
                try
                {
                    bool isAdmin, isSeller;
                    isAdmin = isSeller = false;

                    connect.Open();

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
                        String insertData = "insert into admin_table (username, fullname, password, dateOfBirth) values (@userName, @fullName, @password, @dateOfBirth)";
                        SqlCommand insertCmd = new SqlCommand(insertData, connect);
                        insertCmd.Parameters.AddWithValue("@userName", txtUserName.Text.Trim());
                        insertCmd.Parameters.AddWithValue("@fullName", txtFullName.Text.Trim());
                        insertCmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());
                        insertCmd.Parameters.AddWithValue("@dateOfBirth", dateDob.Value.Date);

                        insertCmd.ExecuteNonQuery();
                        MessageBox.Show("Congratulations! you have been registered an admin.", "Registration done.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    connect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection error." + ex);
                }
                showAdminsData();
            }
        }
    }
}

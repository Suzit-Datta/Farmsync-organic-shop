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
    public partial class regBuyer : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=SUZITDATTA\\SQLEXPRESS;Initial Catalog=DB_Farmsync;Integrated Security=True;Trust Server Certificate=True");
        
        public regBuyer()
        {
            InitializeComponent();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text == "")
            {
                MessageBox.Show("Enter User Name.", "Try again!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(txtFullName.Text == "")
            {
                MessageBox.Show("Enter Full Name.", "Try again!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(txtPhone.Text == "")
            {
                MessageBox.Show("Enter Phone Number.", "Try again!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(txtPassword.Text == "")
            {
                MessageBox.Show("Enter Password.", "Try again!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    bool isAdmin, isBuyer, isSeller;
                    isAdmin = isBuyer = isSeller = false;

                    connect.Open();

                    // check user name exist in admin table
                    String checkUserAdmin = "select * from admin_table where userName = @userName";
                    SqlCommand cmdAdmin = new SqlCommand(checkUserAdmin, connect);
                    cmdAdmin.Parameters.AddWithValue("@userName", txtUserName.Text.Trim());

                    SqlDataReader readerAdmin = cmdAdmin.ExecuteReader();
                    isAdmin = readerAdmin.HasRows;
                    readerAdmin.Close();

                    // check user name exist in buyer table
                    String checkUserBuyer = "select * from buyer_table where userName = @userName";
                    SqlCommand cmdBuyer = new SqlCommand(checkUserBuyer, connect);
                    cmdBuyer.Parameters.AddWithValue("@userName", txtUserName.Text.Trim());

                    SqlDataReader readerBuyer = cmdBuyer.ExecuteReader();
                    isBuyer = readerBuyer.HasRows;
                    readerBuyer.Close();

                    // check user name exist in seller table
                    String checkUserSeller = "select * from seller_table where userName = @userName";
                    SqlCommand cmdSeller = new SqlCommand(checkUserSeller, connect);
                    cmdSeller.Parameters.AddWithValue("@userName", txtUserName.Text.Trim());

                    SqlDataReader readerSeller = cmdSeller.ExecuteReader();
                    isSeller = readerSeller.HasRows;
                    readerSeller.Close();

                    if(isAdmin || isBuyer || isSeller)
                    {
                        MessageBox.Show("User Name already exist.", "Try again!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string insertData = "insert into buyer_table (userName, fullName, phone, password) values (@userName, @fullName, @phone, @password)";

                        SqlCommand insertCommand = new SqlCommand(insertData, connect);
                        insertCommand.Parameters.AddWithValue("@userName", txtUserName.Text.Trim());
                        insertCommand.Parameters.AddWithValue("@fullname", txtFullName.Text.Trim());
                        insertCommand.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                        insertCommand.Parameters.AddWithValue("@password", txtPassword.Text.Trim());
                        insertCommand.ExecuteNonQuery();

                        MessageBox.Show("Congratulations! you have been registered as a buyer.", "Registration done.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        loginForm login = new loginForm();
                        login.Show();
                        this.Hide();
                    }

                    connect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection error!" + ex);
                }
            }

        }

        public void label4_Click(object sender, EventArgs e)
        {
            loginForm loginPage = new loginForm();
            loginPage.Show();
            this.Hide();
        }
        public void regBuyer_Load_1(object sender, EventArgs e)
        {

        }

        private void btnCloseRegBuyer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

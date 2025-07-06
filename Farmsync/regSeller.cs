using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Farmsync
{
    public partial class regSeller : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=SUZITDATTA\\SQLEXPRESS;Initial Catalog=DB_Farmsync;Integrated Security=True;Trust Server Certificate=True");
        private byte[] sellerImage = null;
        public regSeller()
        {
            InitializeComponent();
        }
        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if(open.ShowDialog() == DialogResult.OK)
            {
                picBoxSeller.Image = new Bitmap(open.FileName);
                sellerImage = File.ReadAllBytes(open.FileName);
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
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
            else if (comboBoxLocation.Text == "")
            {
                MessageBox.Show("Enter Location.", "Try again!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (sellerImage == null)
            {
                MessageBox.Show("Enter Image.", "Try again!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        String insertData = "insert into seller_table (username, fullname, location, password, gender, dateOfBirth, sellerImage) values (@userName, @fullName, @location, @password, @gender, @dateOfBirth, @sellerImage)";
                        SqlCommand insertCmd = new SqlCommand(insertData, connect);
                        insertCmd.Parameters.AddWithValue("@userName", txtUserName.Text.Trim());
                        insertCmd.Parameters.AddWithValue("@fullName", txtFullName.Text.Trim());
                        insertCmd.Parameters.AddWithValue("@location", comboBoxLocation.Text.Trim());
                        insertCmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());
                        
                        String gen = (radioBtnFemale.Checked) ? radioBtnFemale.Text.Trim() : radioBtnMale.Text.Trim();
                        insertCmd.Parameters.AddWithValue("@gender", gen);
                        
                        insertCmd.Parameters.AddWithValue("@dateOfBirth", dateTimeDob.Value.Date);
                        insertCmd.Parameters.AddWithValue("@sellerImage", sellerImage);

                        insertCmd.ExecuteNonQuery();
                        MessageBox.Show("Congratulations! you have been registered as a seller.", "Registration done.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        loginForm login = new loginForm();
                        login.Show();
                        this.Hide();
                    }

                    connect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection error." + ex);
                }
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            loginForm loginPage = new loginForm();
            loginPage.Show();
            this.Hide();
        }

        private void btnCloseRegSeller_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}

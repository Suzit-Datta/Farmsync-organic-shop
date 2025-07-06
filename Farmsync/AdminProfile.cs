using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Farmsync
{
    public partial class AdminProfile : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=SUZITDATTA\\SQLEXPRESS;Initial Catalog=DB_Farmsync;Integrated Security=True;Trust Server Certificate=True");

        private String currentUsername;
        public AdminProfile(string userName)
        {
            InitializeComponent();
            this.currentUsername = userName;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            Admin dashboardPage = new Admin(currentUsername);
            dashboardPage.Show();
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

        // show all informations
        private void AdminProfile_Load(object sender, EventArgs e)
        {
            connect.Open();
            lblUserName.Text = currentUsername;

            // show full name
            SqlCommand cmd = new SqlCommand("select fullName from admin_table WHERE userName = @username", connect);
            cmd.Parameters.AddWithValue("@username", currentUsername);
            SqlDataReader reader;
            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblFullName.Text = reader["fullName"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // show phone number
            cmd = new SqlCommand("select phone from admin_table WHERE userName = @username", connect);
            cmd.Parameters.AddWithValue("@username", currentUsername);
            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblPhone.Text = reader["phone"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // show date of birth
            cmd = new SqlCommand("SELECT dateOfBirth FROM admin_table WHERE userName = @userName", connect);
            cmd.Parameters.AddWithValue("@userName", currentUsername);

            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read() && reader["dateOfBirth"] != DBNull.Value)
                {
                    DateTime dob = Convert.ToDateTime(reader["dateOfBirth"]);
                    lblDate.Text = dob.ToString("dd-MM-yyyy");
                }
                else
                {
                    lblDate.Text = "Not Update";
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // show image
            cmd = new SqlCommand("SELECT adminImage FROM admin_table WHERE userName = @userName", connect);
            cmd.Parameters.AddWithValue("@userName", currentUsername);

            try
            {
                reader = cmd.ExecuteReader();

                if (reader.Read() && reader["adminImage"] != DBNull.Value)
                {
                    byte[] imageBytes = (byte[])reader["adminImage"];
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        picBoxAdminImage.Image = Image.FromStream(ms);
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connect.Close();

            if (picBoxSaveImage.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    picBoxSaveImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    defaultImage = ms.ToArray();
                }
            }
        }


        // upload image
        private byte[] adminImage = null;
        private byte[] defaultImage = null;
        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                picBoxSaveImage.Image = new Bitmap(open.FileName);
                adminImage = File.ReadAllBytes(open.FileName);
            }
        }

        // edit profile informations
        private void btnSave_Click(object sender, EventArgs e)
        {
            connect.Open();
            String updateData;
            SqlCommand insertCmd;
            if (txtFullName.Text.Trim() != "")
            {
                updateData = "update admin_table set fullName = @fullName where userName = @userName";
                insertCmd = new SqlCommand(updateData, connect);
                insertCmd.Parameters.AddWithValue("@fullName", txtFullName.Text.Trim());
                insertCmd.Parameters.AddWithValue("@userName", currentUsername);
                insertCmd.ExecuteNonQuery();
            }

            if (txtPhone.Text.Trim() != "")
            {
                updateData = "update admin_table set phone = @phone where userName = @userName";
                insertCmd = new SqlCommand(updateData, connect);
                insertCmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                insertCmd.Parameters.AddWithValue("@userName", currentUsername);
                insertCmd.ExecuteNonQuery();
            }

            if(dateDob.Value.Date != DateTime.Today)
            {
                updateData = "update admin_table set dateOfBirth = @date where userName = @userName";
                insertCmd = new SqlCommand(updateData, connect);
                insertCmd.Parameters.AddWithValue("@date", dateDob.Value.Date);
                insertCmd.Parameters.AddWithValue("@userName", currentUsername);
                insertCmd.ExecuteNonQuery();
            }
            

            if (adminImage != null)
            {
                updateData = "update admin_table set adminImage = @image where userName = @userName";
                insertCmd = new SqlCommand(updateData, connect);
                insertCmd.Parameters.AddWithValue("@image", adminImage);
                insertCmd.Parameters.AddWithValue("@userName", currentUsername);
                insertCmd.ExecuteNonQuery();
            }
            connect.Close();

            MessageBox.Show("Change saved!", "Saved.", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtFullName.Text = "";
            txtPhone.Text = "";
            dateDob.Value = DateTime.Today;

            if (defaultImage != null && defaultImage.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(defaultImage))
                {
                    picBoxSaveImage.Image = Image.FromStream(ms);
                }
            }
            AdminProfile_Load(sender, e);
        }


        // change password
        private void btnChange_Click(object sender, EventArgs e)
        {
            connect.Open();

            string currentPass = "";
            SqlCommand cmd = new SqlCommand("select password from admin_table WHERE userName = @username", connect);
            cmd.Parameters.AddWithValue("@username", currentUsername);

            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    currentPass = reader["password"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if(currentPass == txtCurrentPass.Text)
            {
                if (txtChangePass.Text.Trim() != "")
                {
                    String updateData = "update admin_table set password = @password where userName = @userName";
                    SqlCommand insertCmd = new SqlCommand(updateData, connect);
                    insertCmd.Parameters.AddWithValue("@password", txtChangePass.Text.Trim());
                    insertCmd.Parameters.AddWithValue("@userName", currentUsername);
                    insertCmd.ExecuteNonQuery();
                    MessageBox.Show("Password Changed!", "Saved.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtCurrentPass.Text = "";
                    txtChangePass.Text = "";
                }
                else
                {
                    MessageBox.Show("Not a valid Password!", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            connect.Close();
        }
    }
}

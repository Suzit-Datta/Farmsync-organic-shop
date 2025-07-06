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
    public partial class SellerProfile : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=SUZITDATTA\\SQLEXPRESS;Initial Catalog=DB_Farmsync;Integrated Security=True;Trust Server Certificate=True");

        string currentUsername;
        public SellerProfile(string currentUsername)
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

        private void SellerProfile_Load(object sender, EventArgs e)
        {
            connect.Open();
            lblUserName.Text = currentUsername;
            // show full name
            SqlCommand cmd = new SqlCommand("select fullName from seller_table WHERE username = @username", connect);
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

            // show location number
            cmd = new SqlCommand("select location from seller_table WHERE username = @username", connect);
            cmd.Parameters.AddWithValue("@username", currentUsername);
            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblLocation.Text = reader["location"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // show date of birth
            cmd = new SqlCommand("SELECT dateOfBirth FROM seller_table WHERE username = @userName", connect);
            cmd.Parameters.AddWithValue("@userName", currentUsername);

            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read() && reader["dateOfBirth"] != DBNull.Value)
                {
                    DateTime dob = Convert.ToDateTime(reader["dateOfBirth"]);
                    lblDob.Text = dob.ToString("dd-MM-yyyy");
                }
                else
                {
                    lblDob.Text = "Not Update";
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // show gender number
            cmd = new SqlCommand("select gender from seller_table WHERE username = @username", connect);
            cmd.Parameters.AddWithValue("@username", currentUsername);
            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblGender.Text = reader["gender"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // show image
            cmd = new SqlCommand("SELECT sellerImage FROM seller_table WHERE username = @userName", connect);
            cmd.Parameters.AddWithValue("@userName", currentUsername);

            try
            {
                reader = cmd.ExecuteReader();

                if (reader.Read() && reader["sellerImage"] != DBNull.Value)
                {
                    byte[] imageBytes = (byte[])reader["sellerImage"];
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        picBoxSellerImage.Image = Image.FromStream(ms);
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
        private byte[] sellerImage = null;
        private byte[] defaultImage = null;

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                picBoxSaveImage.Image = new Bitmap(open.FileName);
                sellerImage = File.ReadAllBytes(open.FileName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            connect.Open();
            String updateData;
            SqlCommand insertCmd;
            if (txtFullName.Text.Trim() != "")
            {
                updateData = "update seller_table set fullName = @fullName where username = @userName";
                insertCmd = new SqlCommand(updateData, connect);
                insertCmd.Parameters.AddWithValue("@fullName", txtFullName.Text.Trim());
                insertCmd.Parameters.AddWithValue("@userName", currentUsername);
                insertCmd.ExecuteNonQuery();
            }

            if (comboBoxLocation.Text.Trim() != "")
            {
                updateData = "update seller_table set location = @location where username = @userName";
                insertCmd = new SqlCommand(updateData, connect);
                insertCmd.Parameters.AddWithValue("@location", comboBoxLocation.Text.Trim());
                insertCmd.Parameters.AddWithValue("@userName", currentUsername);
                insertCmd.ExecuteNonQuery();
            }

            if (dateDob.Value.Date != DateTime.Today)
            {
                updateData = "update seller_table set dateOfBirth = @date where username = @userName";
                insertCmd = new SqlCommand(updateData, connect);
                insertCmd.Parameters.AddWithValue("@date", dateDob.Value.Date);
                insertCmd.Parameters.AddWithValue("@userName", currentUsername);
                insertCmd.ExecuteNonQuery();
            }

            if (radioBtnMale.Checked || radioBtnFemale.Checked)
            {
                string gender = (radioBtnMale.Checked) ? "Male" : "Female";
                updateData = "update seller_table set gender = @gender where username = @userName";
                insertCmd = new SqlCommand(updateData, connect);
                insertCmd.Parameters.AddWithValue("@gender", gender);
                insertCmd.Parameters.AddWithValue("@userName", currentUsername);
                insertCmd.ExecuteNonQuery();
            }

            if (sellerImage != null)
            {
                updateData = "update seller_table set sellerImage = @image where username = @userName";
                insertCmd = new SqlCommand(updateData, connect);
                insertCmd.Parameters.AddWithValue("@image", sellerImage);
                insertCmd.Parameters.AddWithValue("@userName", currentUsername);
                insertCmd.ExecuteNonQuery();
            }

            connect.Close();
            MessageBox.Show("Change saved!", "Saved.", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtFullName.Text = "";
            comboBoxLocation.Text = "";
            dateDob.Value = DateTime.Today;
            radioBtnMale.Checked = false;
            radioBtnFemale.Checked = false;


            if (defaultImage != null && defaultImage.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(defaultImage))
                {
                    picBoxSaveImage.Image = Image.FromStream(ms);
                }
            }

            SellerProfile_Load(sender, e);
        }

        // change password
        private void btnChange_Click(object sender, EventArgs e)
        {
            connect.Open();
            string currentPass = "";
            SqlCommand cmd = new SqlCommand("select password from seller_table WHERE username = @username", connect);
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

            if (currentPass == txtCurrentPass.Text)
            {
                if (txtChangePass.Text.Trim() != "")
                {
                    String updateData = "update seller_table set password = @password where username = @userName";
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

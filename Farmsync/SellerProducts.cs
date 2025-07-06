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
    public partial class SellerProducts : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=SUZITDATTA\\SQLEXPRESS;Initial Catalog=DB_Farmsync;Integrated Security=True;Trust Server Certificate=True");

        string currentUsername;
        public SellerProducts(string currentUsername)
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

        // select product
        string productId = "";
        private void dataProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataProducts.Rows[e.RowIndex];
                productId = row.Cells["productId"].Value.ToString();
                txtName.Text = row.Cells["productName"].Value.ToString();
                txtQuantity.Text = row.Cells["productQuantity"].Value.ToString();
                txtPrice.Text = row.Cells["productPrice"].Value.ToString();
                comboBoxCatagory.Text = row.Cells["productCatagory"].Value.ToString();
            }
        }

        // show all products
        private void showProductsData()
        {
            string query = "SELECT productId, productName, productQuantity, productPrice, productCatagory, productImage FROM product_table WHERE productOf = @productOf";

            SqlCommand cmd = new SqlCommand(query, connect);
            cmd.Parameters.AddWithValue("@productOf", currentUsername);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);

            dataProducts.RowTemplate.Height = 100;

            dataProducts.DataSource = ds.Tables[0];

            if (dataProducts.Columns.Contains("productImage"))
            {
                dataProducts.Columns["productImage"].Width = 200;
                DataGridViewImageColumn imgCol = (DataGridViewImageColumn)dataProducts.Columns["productImage"];
                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
        }

        private void SellerProducts_Load(object sender, EventArgs e)
        {
            connect.Open();
            showProductsData();
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


        // get image
        private byte[] sellerImage = null;
        private byte[] defaultImage = null;

        private void btnUploadImage_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                picBoxSaveImage.Image = new Bitmap(open.FileName);
                sellerImage = File.ReadAllBytes(open.FileName);
            }
        }

        // add products
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Enter product Name.", "Try again!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtQuantity.Text == "")
            {
                MessageBox.Show("Enter product quantity.", "Try again!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtPrice.Text == "")
            {
                MessageBox.Show("Enter product price.", "Try again!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (comboBoxCatagory.Text == "")
            {
                MessageBox.Show("Enter product catagory.", "Try again!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (sellerImage == null)
            {
                MessageBox.Show("Enter product image.", "Try again!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    connect.Open();
                    String insertData = "insert into product_table (productName, productQuantity, productPrice, productImage, productCatagory, productOf) values (@productName, @productQuantity, @productPrice, @productImage, @productCatagory, @productOf)";
                    SqlCommand insertCmd = new SqlCommand(insertData, connect);
                    insertCmd.Parameters.AddWithValue("@productName", txtName.Text.Trim());
                    insertCmd.Parameters.AddWithValue("@productQuantity", txtQuantity.Text.Trim());
                    insertCmd.Parameters.AddWithValue("@productPrice", txtPrice.Text.Trim());
                    insertCmd.Parameters.AddWithValue("@productCatagory", comboBoxCatagory.Text);
                    insertCmd.Parameters.AddWithValue("@productImage", sellerImage);
                    insertCmd.Parameters.AddWithValue("@productOf", currentUsername);

                    insertCmd.ExecuteNonQuery();
                    MessageBox.Show("Congratulations! Product have been added.", "Add done.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    connect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection error." + ex);
                }

                txtName.Text = "";
                txtQuantity.Text = "";
                txtPrice.Text = "";
                comboBoxCatagory.Text = "";

                if (defaultImage != null && defaultImage.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(defaultImage))
                    {
                        picBoxSaveImage.Image = Image.FromStream(ms);
                    }
                }
                sellerImage = null;
                showProductsData();
            }
        }

        // update products
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connect.Open();
            String updateData;
            SqlCommand insertCmd;
            if (txtName.Text.Trim() != "")
            {
                updateData = "update product_table set productName = @productName where productId = @productId";
                insertCmd = new SqlCommand(updateData, connect);
                insertCmd.Parameters.AddWithValue("@productName", txtName.Text.Trim());
                insertCmd.Parameters.AddWithValue("@productId", productId);
                insertCmd.ExecuteNonQuery();
            }

            if (txtQuantity.Text.Trim() != "")
            {
                updateData = "update product_table set productQuantity = @productQuantity where productId = @productId";
                insertCmd = new SqlCommand(updateData, connect);
                insertCmd.Parameters.AddWithValue("@productQuantity", txtQuantity.Text.Trim());
                insertCmd.Parameters.AddWithValue("@productId", productId);
                insertCmd.ExecuteNonQuery();
            }

            if (txtPrice.Text.Trim() != "")
            {
                updateData = "update product_table set productPrice = @productPrice where productId = @productId";
                insertCmd = new SqlCommand(updateData, connect);
                insertCmd.Parameters.AddWithValue("@productPrice", txtPrice.Text.Trim());
                insertCmd.Parameters.AddWithValue("@productId", productId);
                insertCmd.ExecuteNonQuery();
            }

            if (comboBoxCatagory.Text.Trim() != "")
            {
                updateData = "update product_table set productCatagory = @productCatagory where productId = @productId";
                insertCmd = new SqlCommand(updateData, connect);
                insertCmd.Parameters.AddWithValue("@productCatagory", comboBoxCatagory.Text.Trim());
                insertCmd.Parameters.AddWithValue("@productId", productId);
                insertCmd.ExecuteNonQuery();
            }

            if (sellerImage != null)
            {
                updateData = "update product_table set productImage = @image where productId = @productId";
                insertCmd = new SqlCommand(updateData, connect);
                insertCmd.Parameters.AddWithValue("@image", sellerImage);
                insertCmd.Parameters.AddWithValue("@productId", productId);
                insertCmd.ExecuteNonQuery();
            }

            connect.Close();
            MessageBox.Show("Change saved!", "Saved.", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtName.Text = "";
            txtQuantity.Text = "";
            txtPrice.Text = "";
            comboBoxCatagory.Text = "";


            if (defaultImage != null && defaultImage.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(defaultImage))
                {
                    picBoxSaveImage.Image = Image.FromStream(ms);
                }
            }
            sellerImage = null;
            showProductsData();
        }

        // delete product
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (productId == "")
            {
                MessageBox.Show("Please enter or select a admin.");
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete '{productId}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM product_table WHERE productId = @productId", connect);
                cmd.Parameters.AddWithValue("@productId", productId);

                try
                {
                    connect.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product deleted.");
                        showProductsData();
                    }
                    else
                    {
                        MessageBox.Show("No product found with that ID.");
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
            productId = "";
        }
    }
}

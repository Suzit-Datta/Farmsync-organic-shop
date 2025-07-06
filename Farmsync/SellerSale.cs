using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmsync
{
    public partial class SellerSale : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=SUZITDATTA\\SQLEXPRESS;Initial Catalog=DB_Farmsync;Integrated Security=True;Trust Server Certificate=True");

        string currentUsername;
        public SellerSale(string currentUsername)
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

        private void btnProducts_Click(object sender, EventArgs e)
        {
            SellerProducts sellerProduct = new SellerProducts(currentUsername);
            sellerProduct.Show();
            this.Hide();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            SellerCustomers sellerCustomers = new SellerCustomers(currentUsername);
            sellerCustomers.Show();
            this.Hide();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            loginForm loginForm = new loginForm();
            loginForm.Show();
            this.Hide();
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

            dataProducts.RowTemplate.Height = 80;

            dataProducts.DataSource = ds.Tables[0];

            if (dataProducts.Columns.Contains("productImage"))
            {
                dataProducts.Columns["productImage"].Width = 100;
                DataGridViewImageColumn imgCol = (DataGridViewImageColumn)dataProducts.Columns["productImage"];
                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
        }

        private void showProductsData(string search)
        {
            string query = "SELECT productId, productName, productQuantity, productPrice, productCatagory, productImage FROM product_table WHERE productOf = @productOf AND productName = @productName";

            SqlCommand cmd = new SqlCommand(query, connect);
            cmd.Parameters.AddWithValue("@productOf", currentUsername);
            cmd.Parameters.AddWithValue("@productName", search);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);

            dataProducts.RowTemplate.Height = 80;

            dataProducts.DataSource = ds.Tables[0];

            if (dataProducts.Columns.Contains("productImage"))
            {
                dataProducts.Columns["productImage"].Width = 100;
                DataGridViewImageColumn imgCol = (DataGridViewImageColumn)dataProducts.Columns["productImage"];
                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
        }

        // show all selling products
        private void SetupDataSellGrid()
        {
            dataSell.Columns.Clear();
            dataSell.Columns.Add("productId", "ID");
            dataSell.Columns.Add("productName", "Name");
            dataSell.Columns.Add("productQuantity", "Quantity");
            dataSell.Columns.Add("productPrice", "Price");
        }
        private void SellerSale_Load(object sender, EventArgs e)
        {
            txtQuantity.Text = "0";
            connect.Open();
            showProductsData();
            SetupDataSellGrid();
            connect.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                connect.Open();
                showProductsData();
                connect.Close();
            }
            else
            {
                connect.Open();
                showProductsData(txtSearch.Text.Trim());
                connect.Close();
            }
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            string query = "SELECT fullName, membership FROM buyer_table WHERE phone = @phone";
            SqlCommand cmd = new SqlCommand(query, connect);
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());

            connect.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                lblName.Text = reader["fullName"].ToString();
                lblMembership.Text = reader["membership"].ToString();
            }
            else
            {
                lblName.Text = "Not registered";
                lblMembership.Text = "Not available";
            }

            connect.Close();

        }

        private void updateQuantityDB(string productId, int newQuantity)
        {
            string query = "UPDATE product_table SET productQuantity = @quantity WHERE productId = @productId";

            SqlCommand cmd = new SqlCommand(query, connect);
            cmd.Parameters.AddWithValue("@quantity", newQuantity);
            cmd.Parameters.AddWithValue("@productId", productId);

            try
            {
                connect.Open();
                cmd.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dataProducts.CurrentRow != null && int.TryParse(txtQuantity.Text.Trim(), out int sellQuantity))
            {
                DataGridViewRow selectedRow = dataProducts.CurrentRow;

                string productId = selectedRow.Cells["productId"].Value.ToString();
                string productName = selectedRow.Cells["productName"].Value.ToString();
                int currentQuantity = Convert.ToInt32(selectedRow.Cells["productQuantity"].Value);
                string productPrice = selectedRow.Cells["productPrice"].Value.ToString();
                if (sellQuantity == 0)
                {
                    MessageBox.Show("Not added quantity.", "Add Quantity", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }

                if (sellQuantity > currentQuantity)
                {
                    MessageBox.Show("Not enough stock available.", "Stock Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int newQuantity = currentQuantity - sellQuantity;

                dataSell.Rows.Add(productId, productName, sellQuantity.ToString(), productPrice);

                selectedRow.Cells["productQuantity"].Value = newQuantity.ToString();

                updateQuantityDB(productId, newQuantity);
            }
            else
            {
                MessageBox.Show("Please select a product and enter a valid quantity.");
            }
            txtQuantity.Text = "0";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataSell.CurrentRow != null)
            {
                DataGridViewRow sellRow = dataSell.CurrentRow;

                string productId = sellRow.Cells["productId"].Value.ToString();
                int removedQuantity = Convert.ToInt32(sellRow.Cells["productQuantity"].Value);

                dataSell.Rows.Remove(sellRow);

                foreach (DataGridViewRow productRow in dataProducts.Rows)
                {
                    if (productRow.Cells["productId"].Value.ToString() == productId)
                    {
                        int currentQuantity = Convert.ToInt32(productRow.Cells["productQuantity"].Value);
                        int updatedQuantity = currentQuantity + removedQuantity;

                        productRow.Cells["productQuantity"].Value = updatedQuantity.ToString();

                        updateQuantityDB(productId, updatedQuantity);
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a product from the sell list to remove.");
            }
            txtQuantity.Text = "0";
        }

        string receiptText = "";
        private void btnPay_Click(object sender, EventArgs e)
        {
            if (dataSell.Rows.Count == 0)
            {
                MessageBox.Show("No items to pay for.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Confirm payment
            DialogResult result = MessageBox.Show("Are you sure you want to complete this payment?", "Confirm Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }

            string membership = lblMembership.Text.Trim().ToLower();
            double discountPercent = 0;

            switch (membership)
            {
                case "silver":
                    discountPercent = 0.05;
                    break;
                case "gold":
                    discountPercent = 0.10;
                    break;
                case "diamond":
                    discountPercent = 0.25;
                    break;
                default:
                    discountPercent = 0.0;
                    break;
            }

            receiptText = "        --- FEE RECEIPT ---\n";
            receiptText += $"Date: {DateTime.Now}\n";
            receiptText += $"Membership: {membership}\n";
            receiptText += $"Discount: {discountPercent * 100}%\n";
            receiptText += "------------------------------\n";

            double total = 0;

            foreach (DataGridViewRow row in dataSell.Rows)
            {
                if (row.IsNewRow) continue;

                string name = row.Cells["productName"].Value.ToString();
                int quantity = Convert.ToInt32(row.Cells["productQuantity"].Value);
                double price = Convert.ToDouble(row.Cells["productPrice"].Value);
                double subtotal = quantity * price;

                total += subtotal;
                receiptText += $"{name,-20} x{quantity} = {subtotal:C}\n";
            }

            receiptText += "------------------------------\n";

            double discountAmount = total * discountPercent;
            double totalAfterDiscount = total - discountAmount;

            receiptText += $"Subtotal: {total:C}\n";
            receiptText += $"Discount: -{discountAmount:C}\n";
            receiptText += $"Total after discount: {totalAfterDiscount:C}\n";
            receiptText += "Thank you for your purchase!\n";

            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = printDocument1;
            preview.ShowDialog();

            string customer = lblName.Text.Trim() != "Not registered" ? lblName.Text.Trim() : "";

            SqlCommand cmd = new SqlCommand("INSERT INTO order_table (orderDate, totalPrice, customer, seller) VALUES (@date, @total, @customer, @seller)", connect);
            cmd.Parameters.AddWithValue("@date", DateTime.Now);
            cmd.Parameters.AddWithValue("@total", totalAfterDiscount);
            cmd.Parameters.AddWithValue("@customer", customer);
            cmd.Parameters.AddWithValue("@seller", currentUsername);

            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Close();

            dataSell.Rows.Clear();
            txtPhone.Text = "";
            txtQuantity.Text = "0";
            lblName.Text = "Not registered";
            lblMembership.Text = "Not available";

            MessageBox.Show("Payment completed and saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            SqlCommand updateRevenueCmd = new SqlCommand("UPDATE seller_table SET revenue = ISNULL(revenue, 0) + @amount WHERE username = @username", connect);
            updateRevenueCmd.Parameters.AddWithValue("@amount", totalAfterDiscount);
            updateRevenueCmd.Parameters.AddWithValue("@username", currentUsername);

            connect.Open();
            updateRevenueCmd.ExecuteNonQuery();
            connect.Close();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Courier New", 16);
            e.Graphics.DrawString(receiptText, font, Brushes.Black, new PointF(100, 100));
        }

        // quantity increase and decrease
        private void btnPlus_Click(object sender, EventArgs e)
        {
            int qty = 0;
            int.TryParse(txtQuantity.Text, out qty);
            qty++;
            txtQuantity.Text = qty.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int qty = 0;
            int.TryParse(txtQuantity.Text, out qty);

            if (qty > 0)
                qty--;

            txtQuantity.Text = qty.ToString();
        }
    }
}

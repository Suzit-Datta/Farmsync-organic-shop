//using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Farmsync
{
    public partial class loginForm : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=SUZITDATTA\\SQLEXPRESS;Initial Catalog=DB_Farmsync;Integrated Security=True;Trust Server Certificate=True");

        public loginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Enter all the informations!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    bool isAdmin, isSeller;
                    isAdmin = isSeller = false;

                    connect.Open();
                    String adminQuery = "select * from admin_table where userName = @userName and password = @password";
                    String sellerQuery = "select * from seller_table where userName = @userName and password = @password";

                    SqlCommand cmdAdmin = new SqlCommand(adminQuery, connect);
                    cmdAdmin.Parameters.AddWithValue("@userName", txtUserName.Text.Trim());
                    cmdAdmin.Parameters.AddWithValue("@password", txtPassword.Text.Trim());
                    SqlDataReader readerAdmin = cmdAdmin.ExecuteReader();
                    if (readerAdmin.HasRows)
                    {
                        isAdmin = true;
                    }
                    readerAdmin.Close();

                    SqlCommand cmdSeller = new SqlCommand(sellerQuery, connect);
                    cmdSeller.Parameters.AddWithValue("@userName", txtUserName.Text.Trim());
                    cmdSeller.Parameters.AddWithValue("@password", txtPassword.Text.Trim());
                    SqlDataReader readerSeller = cmdSeller.ExecuteReader();
                    if (readerSeller.HasRows)
                    {
                        isSeller = true;
                    }
                    readerSeller.Close();

                    if (isAdmin)
                    {
                        MessageBox.Show("Loged in as admin", "Login Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Admin admin = new Admin(txtUserName.Text.Trim());
                        admin.Show();
                        this.Hide();
                    }
                    else if (isSeller)
                    {
                        MessageBox.Show("Loged in as seller", "Login Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Seller seller = new Seller(txtUserName.Text.Trim());
                        seller.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    connect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection error!" + ex);
                }
            }
        }

        private void btnRegSeller_Click(object sender, EventArgs e)
        {
            regSeller sellerReg = new regSeller();
            sellerReg.Show();
            this.Hide();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

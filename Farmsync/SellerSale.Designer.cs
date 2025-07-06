namespace Farmsync
{
    partial class SellerSale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellerSale));
            btnClose = new Button();
            pictureBox1 = new PictureBox();
            label13 = new Label();
            btnLogout = new Button();
            btnCustomers = new Button();
            btnProducts = new Button();
            btnSale = new Button();
            panel2 = new Panel();
            btnRevenue = new Button();
            btnProfile = new Button();
            btnDashboard = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            btnRemove = new Button();
            btnPay = new Button();
            btnAdd = new Button();
            txtQuantity = new TextBox();
            btnMinus = new Button();
            btnPlus = new Button();
            btnSearchCustomer = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            txtPhone = new TextBox();
            dataSell = new DataGridView();
            dataProducts = new DataGridView();
            label5 = new Label();
            lblMembership = new Label();
            lblName = new Label();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataSell).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataProducts).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(52, 152, 219);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.FromArgb(52, 152, 219);
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(1233, 8);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(38, 38);
            btnClose.TabIndex = 2;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(60, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 180);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(74, 188);
            label13.Name = "label13";
            label13.Size = new Size(147, 40);
            label13.TabIndex = 1;
            label13.Text = "FARMSYNC";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(52, 152, 219);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 786);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(50, 0, 0, 0);
            btnLogout.Size = new Size(300, 56);
            btnLogout.TabIndex = 2;
            btnLogout.Text = " Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click_1;
            // 
            // btnCustomers
            // 
            btnCustomers.BackColor = Color.FromArgb(52, 152, 219);
            btnCustomers.Cursor = Cursors.Hand;
            btnCustomers.FlatAppearance.BorderSize = 0;
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomers.ForeColor = Color.White;
            btnCustomers.Image = (Image)resources.GetObject("btnCustomers.Image");
            btnCustomers.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomers.Location = new Point(-3, 574);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Padding = new Padding(50, 0, 0, 0);
            btnCustomers.Size = new Size(300, 56);
            btnCustomers.TabIndex = 2;
            btnCustomers.Text = " Customers";
            btnCustomers.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCustomers.UseVisualStyleBackColor = false;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.FromArgb(52, 152, 219);
            btnProducts.Cursor = Cursors.Hand;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProducts.ForeColor = Color.White;
            btnProducts.Image = (Image)resources.GetObject("btnProducts.Image");
            btnProducts.ImageAlign = ContentAlignment.MiddleLeft;
            btnProducts.Location = new Point(-3, 512);
            btnProducts.Name = "btnProducts";
            btnProducts.Padding = new Padding(50, 0, 0, 0);
            btnProducts.Size = new Size(300, 56);
            btnProducts.TabIndex = 2;
            btnProducts.Text = " Products";
            btnProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnProducts.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnSale
            // 
            btnSale.BackColor = Color.FromArgb(52, 152, 219);
            btnSale.Cursor = Cursors.Hand;
            btnSale.FlatAppearance.BorderSize = 0;
            btnSale.FlatStyle = FlatStyle.Flat;
            btnSale.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSale.ForeColor = Color.White;
            btnSale.Image = (Image)resources.GetObject("btnSale.Image");
            btnSale.ImageAlign = ContentAlignment.MiddleLeft;
            btnSale.Location = new Point(-3, 450);
            btnSale.Name = "btnSale";
            btnSale.Padding = new Padding(50, 0, 0, 0);
            btnSale.Size = new Size(300, 56);
            btnSale.TabIndex = 2;
            btnSale.Text = " Sale";
            btnSale.TextAlign = ContentAlignment.MiddleLeft;
            btnSale.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSale.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(52, 152, 219);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(btnCustomers);
            panel2.Controls.Add(btnProducts);
            panel2.Controls.Add(btnSale);
            panel2.Controls.Add(btnRevenue);
            panel2.Controls.Add(btnProfile);
            panel2.Controls.Add(btnDashboard);
            panel2.Dock = DockStyle.Left;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(0, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 845);
            panel2.TabIndex = 5;
            // 
            // btnRevenue
            // 
            btnRevenue.BackColor = Color.FromArgb(52, 152, 219);
            btnRevenue.Cursor = Cursors.Hand;
            btnRevenue.FlatAppearance.BorderSize = 0;
            btnRevenue.FlatStyle = FlatStyle.Flat;
            btnRevenue.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRevenue.ForeColor = Color.White;
            btnRevenue.Image = (Image)resources.GetObject("btnRevenue.Image");
            btnRevenue.ImageAlign = ContentAlignment.MiddleLeft;
            btnRevenue.Location = new Point(-3, 388);
            btnRevenue.Name = "btnRevenue";
            btnRevenue.Padding = new Padding(50, 0, 0, 0);
            btnRevenue.Size = new Size(300, 56);
            btnRevenue.TabIndex = 2;
            btnRevenue.Text = " Revenue";
            btnRevenue.TextAlign = ContentAlignment.MiddleLeft;
            btnRevenue.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRevenue.UseVisualStyleBackColor = false;
            btnRevenue.Click += btnRevenue_Click;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.FromArgb(52, 152, 219);
            btnProfile.Cursor = Cursors.Hand;
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfile.ForeColor = Color.White;
            btnProfile.Image = (Image)resources.GetObject("btnProfile.Image");
            btnProfile.ImageAlign = ContentAlignment.MiddleLeft;
            btnProfile.Location = new Point(-3, 326);
            btnProfile.Name = "btnProfile";
            btnProfile.Padding = new Padding(50, 0, 0, 0);
            btnProfile.Size = new Size(300, 56);
            btnProfile.TabIndex = 2;
            btnProfile.Text = " Profile";
            btnProfile.TextAlign = ContentAlignment.MiddleLeft;
            btnProfile.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(52, 152, 219);
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(-3, 264);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(50, 0, 0, 0);
            btnDashboard.Size = new Size(300, 56);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = " Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 152, 219);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1300, 55);
            panel1.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(251, 251, 251);
            panel3.Controls.Add(btnRemove);
            panel3.Controls.Add(btnPay);
            panel3.Controls.Add(btnAdd);
            panel3.Controls.Add(txtQuantity);
            panel3.Controls.Add(btnMinus);
            panel3.Controls.Add(btnPlus);
            panel3.Controls.Add(btnSearchCustomer);
            panel3.Controls.Add(btnSearch);
            panel3.Controls.Add(txtSearch);
            panel3.Controls.Add(txtPhone);
            panel3.Controls.Add(dataSell);
            panel3.Controls.Add(dataProducts);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(lblMembership);
            panel3.Controls.Add(lblName);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label4);
            panel3.Cursor = Cursors.Hand;
            panel3.Location = new Point(311, 65);
            panel3.Name = "panel3";
            panel3.Size = new Size(979, 823);
            panel3.TabIndex = 9;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(244, 2, 2);
            btnRemove.Cursor = Cursors.Hand;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Poppins", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(586, 746);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(139, 45);
            btnRemove.TabIndex = 26;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.FromArgb(22, 147, 75);
            btnPay.Cursor = Cursors.Hand;
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.Font = new Font("Poppins", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPay.ForeColor = Color.White;
            btnPay.Location = new Point(832, 745);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(139, 45);
            btnPay.TabIndex = 26;
            btnPay.Text = "Pay";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(22, 147, 75);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Poppins", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(434, 746);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(139, 45);
            btnAdd.TabIndex = 26;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.BorderStyle = BorderStyle.FixedSingle;
            txtQuantity.Location = new Point(177, 754);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(61, 27);
            txtQuantity.TabIndex = 25;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.FromArgb(251, 251, 251);
            btnMinus.BackgroundImage = (Image)resources.GetObject("btnMinus.BackgroundImage");
            btnMinus.BackgroundImageLayout = ImageLayout.Zoom;
            btnMinus.FlatAppearance.BorderSize = 0;
            btnMinus.FlatStyle = FlatStyle.Flat;
            btnMinus.ForeColor = Color.FromArgb(251, 251, 251);
            btnMinus.Location = new Point(253, 751);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(32, 32);
            btnMinus.TabIndex = 24;
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.FromArgb(251, 251, 251);
            btnPlus.BackgroundImage = (Image)resources.GetObject("btnPlus.BackgroundImage");
            btnPlus.BackgroundImageLayout = ImageLayout.Zoom;
            btnPlus.FlatAppearance.BorderSize = 0;
            btnPlus.FlatStyle = FlatStyle.Flat;
            btnPlus.ForeColor = Color.FromArgb(251, 251, 251);
            btnPlus.Location = new Point(132, 751);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(32, 32);
            btnPlus.TabIndex = 24;
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnSearchCustomer
            // 
            btnSearchCustomer.BackColor = Color.FromArgb(251, 251, 251);
            btnSearchCustomer.BackgroundImage = (Image)resources.GetObject("btnSearchCustomer.BackgroundImage");
            btnSearchCustomer.BackgroundImageLayout = ImageLayout.Zoom;
            btnSearchCustomer.FlatAppearance.BorderSize = 0;
            btnSearchCustomer.FlatStyle = FlatStyle.Flat;
            btnSearchCustomer.ForeColor = Color.FromArgb(251, 251, 251);
            btnSearchCustomer.Location = new Point(929, 56);
            btnSearchCustomer.Name = "btnSearchCustomer";
            btnSearchCustomer.Size = new Size(32, 32);
            btnSearchCustomer.TabIndex = 23;
            btnSearchCustomer.UseVisualStyleBackColor = false;
            btnSearchCustomer.Click += btnSearchCustomer_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(251, 251, 251);
            btnSearch.BackgroundImage = (Image)resources.GetObject("btnSearch.BackgroundImage");
            btnSearch.BackgroundImageLayout = ImageLayout.Zoom;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.FromArgb(251, 251, 251);
            btnSearch.Location = new Point(326, 50);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(32, 32);
            btnSearch.TabIndex = 23;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(11, 54);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(297, 27);
            txtSearch.TabIndex = 21;
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Location = new Point(670, 60);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(249, 27);
            txtPhone.TabIndex = 21;
            // 
            // dataSell
            // 
            dataSell.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataSell.BackgroundColor = Color.FromArgb(251, 251, 251);
            dataSell.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataSell.GridColor = Color.FromArgb(251, 251, 251);
            dataSell.Location = new Point(584, 217);
            dataSell.MultiSelect = false;
            dataSell.Name = "dataSell";
            dataSell.ReadOnly = true;
            dataSell.RowHeadersWidth = 51;
            dataSell.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataSell.Size = new Size(387, 506);
            dataSell.TabIndex = 4;
            // 
            // dataProducts
            // 
            dataProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataProducts.BackgroundColor = Color.FromArgb(251, 251, 251);
            dataProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataProducts.GridColor = Color.FromArgb(251, 251, 251);
            dataProducts.Location = new Point(11, 99);
            dataProducts.MultiSelect = false;
            dataProducts.Name = "dataProducts";
            dataProducts.ReadOnly = true;
            dataProducts.RowHeadersWidth = 51;
            dataProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataProducts.Size = new Size(564, 624);
            dataProducts.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(584, 158);
            label5.Name = "label5";
            label5.Size = new Size(151, 36);
            label5.TabIndex = 1;
            label5.Text = "Membership:";
            // 
            // lblMembership
            // 
            lblMembership.AutoSize = true;
            lblMembership.Font = new Font("Poppins Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMembership.Location = new Point(741, 158);
            lblMembership.Name = "lblMembership";
            lblMembership.Size = new Size(148, 36);
            lblMembership.TabIndex = 1;
            lblMembership.Text = "Not available";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Poppins Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(667, 108);
            lblName.Name = "lblName";
            lblName.Size = new Size(154, 36);
            lblName.TabIndex = 1;
            lblName.Text = "Not registered";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(11, 750);
            label6.Name = "label6";
            label6.Size = new Size(112, 36);
            label6.TabIndex = 1;
            label6.Text = "Quantity:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(584, 108);
            label3.Name = "label3";
            label3.Size = new Size(83, 36);
            label3.TabIndex = 1;
            label3.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(584, 55);
            label2.Name = "label2";
            label2.Size = new Size(84, 36);
            label2.TabIndex = 1;
            label2.Text = "Phone:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(584, 6);
            label1.Name = "label1";
            label1.Size = new Size(193, 36);
            label1.TabIndex = 1;
            label1.Text = "Customer Details";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 6);
            label4.Name = "label4";
            label4.Size = new Size(180, 36);
            label4.TabIndex = 1;
            label4.Text = "Selling Products";
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // SellerSale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1300, 900);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SellerSale";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SallerSale";
            Load += SellerSale_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataSell).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnClose;
        private PictureBox pictureBox1;
        private Label label13;
        private Button btnLogout;
        private Button btnCustomers;
        private Button btnProducts;
        private Button btnSale;
        private Panel panel2;
        private Button btnRevenue;
        private Button btnProfile;
        private Button btnDashboard;
        private Panel panel1;
        private Panel panel3;
        private Label label4;
        private DataGridView dataProducts;
        private DataGridView dataSell;
        private Label label2;
        private Label label1;
        private TextBox txtPhone;
        private Label label5;
        private Label lblMembership;
        private Label lblName;
        private Label label3;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label label6;
        private Button btnPlus;
        private TextBox txtQuantity;
        private Button btnMinus;
        private Button btnRemove;
        private Button btnAdd;
        private Button btnPay;
        private Button btnSearchCustomer;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
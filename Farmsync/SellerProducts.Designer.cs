namespace Farmsync
{
    partial class SellerProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellerProducts));
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
            panel6 = new Panel();
            btnUploadImage = new Button();
            picBoxSaveImage = new PictureBox();
            comboBoxCatagory = new ComboBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            label4 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            label16 = new Label();
            label10 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            label3 = new Label();
            panel4 = new Panel();
            dataProducts = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxSaveImage).BeginInit();
            panel4.SuspendLayout();
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
            btnLogout.Click += btnLogout_Click;
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
            btnSale.Click += btnSale_Click;
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
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(251, 251, 251);
            panel6.Controls.Add(btnUploadImage);
            panel6.Controls.Add(picBoxSaveImage);
            panel6.Controls.Add(comboBoxCatagory);
            panel6.Controls.Add(txtPrice);
            panel6.Controls.Add(txtQuantity);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(txtName);
            panel6.Controls.Add(label2);
            panel6.Controls.Add(label16);
            panel6.Controls.Add(label10);
            panel6.Controls.Add(btnAdd);
            panel6.Controls.Add(btnUpdate);
            panel6.Controls.Add(btnDelete);
            panel6.Controls.Add(label3);
            panel6.Location = new Point(311, 69);
            panel6.Name = "panel6";
            panel6.Size = new Size(976, 272);
            panel6.TabIndex = 11;
            // 
            // btnUploadImage
            // 
            btnUploadImage.BackColor = Color.FromArgb(52, 152, 219);
            btnUploadImage.Cursor = Cursors.Hand;
            btnUploadImage.FlatStyle = FlatStyle.Flat;
            btnUploadImage.Font = new Font("Poppins", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUploadImage.ForeColor = Color.White;
            btnUploadImage.Location = new Point(70, 212);
            btnUploadImage.Name = "btnUploadImage";
            btnUploadImage.Size = new Size(139, 39);
            btnUploadImage.TabIndex = 23;
            btnUploadImage.Text = "Upload";
            btnUploadImage.UseVisualStyleBackColor = false;
            btnUploadImage.Click += btnUploadImage_Click_1;
            // 
            // picBoxSaveImage
            // 
            picBoxSaveImage.Image = (Image)resources.GetObject("picBoxSaveImage.Image");
            picBoxSaveImage.Location = new Point(65, 52);
            picBoxSaveImage.Name = "picBoxSaveImage";
            picBoxSaveImage.Size = new Size(150, 150);
            picBoxSaveImage.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxSaveImage.TabIndex = 22;
            picBoxSaveImage.TabStop = false;
            // 
            // comboBoxCatagory
            // 
            comboBoxCatagory.Cursor = Cursors.Hand;
            comboBoxCatagory.FormattingEnabled = true;
            comboBoxCatagory.Items.AddRange(new object[] { "All", "Fruits", "Vegetables", "Dairy Products", "Meat & Poultry", "Fish", "Seeds" });
            comboBoxCatagory.Location = new Point(408, 213);
            comboBoxCatagory.Name = "comboBoxCatagory";
            comboBoxCatagory.Size = new Size(250, 28);
            comboBoxCatagory.TabIndex = 21;
            // 
            // txtPrice
            // 
            txtPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPrice.Location = new Point(408, 160);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(250, 27);
            txtPrice.TabIndex = 20;
            // 
            // txtQuantity
            // 
            txtQuantity.BorderStyle = BorderStyle.FixedSingle;
            txtQuantity.Location = new Point(408, 105);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(250, 27);
            txtQuantity.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(335, 159);
            label4.Name = "label4";
            label4.Size = new Size(61, 30);
            label4.TabIndex = 19;
            label4.Text = "Price:";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(408, 52);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 27);
            txtName.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(301, 104);
            label2.Name = "label2";
            label2.Size = new Size(95, 30);
            label2.TabIndex = 19;
            label2.Text = "Quantity:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(293, 213);
            label16.Name = "label16";
            label16.Size = new Size(103, 30);
            label16.TabIndex = 18;
            label16.Text = "Catagory:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(252, 51);
            label10.Name = "label10";
            label10.Size = new Size(144, 30);
            label10.TabIndex = 19;
            label10.Text = "Product Name:";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(22, 147, 75);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Poppins", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(728, 62);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(139, 45);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(52, 152, 219);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Poppins", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(728, 127);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(139, 45);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(244, 2, 2);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Poppins", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(728, 190);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(139, 45);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(14, 8);
            label3.Name = "label3";
            label3.Size = new Size(139, 36);
            label3.TabIndex = 1;
            label3.Text = "Edit Product";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(251, 251, 251);
            panel4.Controls.Add(dataProducts);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(311, 351);
            panel4.Name = "panel4";
            panel4.Size = new Size(977, 537);
            panel4.TabIndex = 16;
            // 
            // dataProducts
            // 
            dataProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataProducts.BackgroundColor = Color.FromArgb(251, 251, 251);
            dataProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataProducts.GridColor = Color.FromArgb(251, 251, 251);
            dataProducts.Location = new Point(20, 49);
            dataProducts.MultiSelect = false;
            dataProducts.Name = "dataProducts";
            dataProducts.ReadOnly = true;
            dataProducts.RowHeadersWidth = 51;
            dataProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataProducts.Size = new Size(940, 474);
            dataProducts.TabIndex = 3;
            dataProducts.CellClick += dataProducts_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(15, 7);
            label1.Name = "label1";
            label1.Size = new Size(157, 36);
            label1.TabIndex = 2;
            label1.Text = "Products Lists";
            // 
            // SellerProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1300, 900);
            Controls.Add(panel4);
            Controls.Add(panel6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SellerProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SallerProducts";
            Load += SellerProducts_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxSaveImage).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnClose;
        private PictureBox pictureBox1;
        private Label label13;
        private Button btnLogout;
        private Button btnAdmins;
        private Button btnCustomers;
        private Button btnProducts;
        private Button btnSale;
        private Panel panel2;
        private Button btnRevenue;
        private Button btnProfile;
        private Button btnDashboard;
        private Panel panel1;
        private Panel panel6;
        private Label label3;
        private Button btnUpdate;
        private Button btnDelete;
        private Panel panel4;
        private DataGridView dataProducts;
        private Label label1;
        private Button btnAdd;
        private ComboBox comboBoxCatagory;
        private TextBox txtName;
        private Label label16;
        private Label label10;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private Label label4;
        private Label label2;
        private Button btnUploadImage;
        private PictureBox picBoxSaveImage;
    }
}
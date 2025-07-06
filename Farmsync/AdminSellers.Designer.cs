namespace Farmsync
{
    partial class AdminSellers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSellers));
            panel1 = new Panel();
            btnExit = new Button();
            btnClose = new Button();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            label17 = new Label();
            btnLogout = new Button();
            btnAdmins = new Button();
            btnCustomers = new Button();
            btnProducts = new Button();
            btnSellers = new Button();
            btnRevenue = new Button();
            btnProfile = new Button();
            btnDashboard = new Button();
            panel3 = new Panel();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            radioBtnFemale = new RadioButton();
            radioBtnMale = new RadioButton();
            label8 = new Label();
            comboBoxLocation = new ComboBox();
            label6 = new Label();
            dateDob = new DateTimePicker();
            txtPassword = new TextBox();
            txtFullName = new TextBox();
            txtUserName = new TextBox();
            label2 = new Label();
            label11 = new Label();
            label16 = new Label();
            label10 = new Label();
            label1 = new Label();
            panel4 = new Panel();
            dataSellers = new DataGridView();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataSellers).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 152, 219);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(300, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 55);
            panel1.TabIndex = 12;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(52, 152, 219);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.FromArgb(52, 152, 219);
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new Point(933, 8);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(38, 38);
            btnExit.TabIndex = 16;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
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
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(52, 152, 219);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(btnAdmins);
            panel2.Controls.Add(btnCustomers);
            panel2.Controls.Add(btnProducts);
            panel2.Controls.Add(btnSellers);
            panel2.Controls.Add(btnRevenue);
            panel2.Controls.Add(btnProfile);
            panel2.Controls.Add(btnDashboard);
            panel2.Dock = DockStyle.Left;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 900);
            panel2.TabIndex = 13;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(60, 62);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(180, 180);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.White;
            label17.Location = new Point(74, 243);
            label17.Name = "label17";
            label17.Size = new Size(147, 40);
            label17.TabIndex = 13;
            label17.Text = "FARMSYNC";
            label17.TextAlign = ContentAlignment.MiddleCenter;
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
            btnLogout.Location = new Point(0, 841);
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
            // btnAdmins
            // 
            btnAdmins.BackColor = Color.FromArgb(52, 152, 219);
            btnAdmins.Cursor = Cursors.Hand;
            btnAdmins.FlatAppearance.BorderSize = 0;
            btnAdmins.FlatStyle = FlatStyle.Flat;
            btnAdmins.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdmins.ForeColor = Color.White;
            btnAdmins.Image = (Image)resources.GetObject("btnAdmins.Image");
            btnAdmins.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdmins.Location = new Point(0, 691);
            btnAdmins.Name = "btnAdmins";
            btnAdmins.Padding = new Padding(50, 0, 0, 0);
            btnAdmins.Size = new Size(300, 56);
            btnAdmins.TabIndex = 2;
            btnAdmins.Text = " Admins";
            btnAdmins.TextAlign = ContentAlignment.MiddleLeft;
            btnAdmins.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdmins.UseVisualStyleBackColor = false;
            btnAdmins.Click += btnAdmins_Click;
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
            btnCustomers.Location = new Point(0, 629);
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
            btnProducts.Location = new Point(0, 567);
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
            // btnSellers
            // 
            btnSellers.BackColor = Color.FromArgb(52, 152, 219);
            btnSellers.Cursor = Cursors.Hand;
            btnSellers.FlatAppearance.BorderSize = 0;
            btnSellers.FlatStyle = FlatStyle.Flat;
            btnSellers.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSellers.ForeColor = Color.White;
            btnSellers.Image = (Image)resources.GetObject("btnSellers.Image");
            btnSellers.ImageAlign = ContentAlignment.MiddleLeft;
            btnSellers.Location = new Point(0, 505);
            btnSellers.Name = "btnSellers";
            btnSellers.Padding = new Padding(50, 0, 0, 0);
            btnSellers.Size = new Size(300, 56);
            btnSellers.TabIndex = 2;
            btnSellers.Text = " Sellers";
            btnSellers.TextAlign = ContentAlignment.MiddleLeft;
            btnSellers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSellers.UseVisualStyleBackColor = false;
            btnSellers.Click += btnSellers_Click;
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
            btnRevenue.Location = new Point(0, 443);
            btnRevenue.Name = "btnRevenue";
            btnRevenue.Padding = new Padding(50, 0, 0, 0);
            btnRevenue.Size = new Size(300, 56);
            btnRevenue.TabIndex = 2;
            btnRevenue.Text = " Sales";
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
            btnProfile.Location = new Point(0, 381);
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
            btnDashboard.Location = new Point(-3, 319);
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
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(251, 251, 251);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnUpdate);
            panel3.Controls.Add(btnAdd);
            panel3.Controls.Add(radioBtnFemale);
            panel3.Controls.Add(radioBtnMale);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(comboBoxLocation);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(dateDob);
            panel3.Controls.Add(txtPassword);
            panel3.Controls.Add(txtFullName);
            panel3.Controls.Add(txtUserName);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(313, 69);
            panel3.Name = "panel3";
            panel3.Size = new Size(974, 305);
            panel3.TabIndex = 14;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(244, 2, 2);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Poppins", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(814, 197);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(139, 45);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(52, 152, 219);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Poppins", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(661, 197);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(139, 45);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(22, 147, 75);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Poppins", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(507, 197);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(139, 45);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // radioBtnFemale
            // 
            radioBtnFemale.AutoSize = true;
            radioBtnFemale.Cursor = Cursors.Hand;
            radioBtnFemale.Font = new Font("Poppins Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioBtnFemale.Location = new Point(721, 65);
            radioBtnFemale.Name = "radioBtnFemale";
            radioBtnFemale.Size = new Size(96, 34);
            radioBtnFemale.TabIndex = 19;
            radioBtnFemale.TabStop = true;
            radioBtnFemale.Text = "Female";
            radioBtnFemale.UseVisualStyleBackColor = true;
            // 
            // radioBtnMale
            // 
            radioBtnMale.AutoSize = true;
            radioBtnMale.Cursor = Cursors.Hand;
            radioBtnMale.Font = new Font("Poppins Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioBtnMale.Location = new Point(624, 65);
            radioBtnMale.Name = "radioBtnMale";
            radioBtnMale.Size = new Size(74, 34);
            radioBtnMale.TabIndex = 18;
            radioBtnMale.TabStop = true;
            radioBtnMale.Text = "Male";
            radioBtnMale.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(50, 50, 50);
            label8.Location = new Point(537, 69);
            label8.Name = "label8";
            label8.Size = new Size(81, 30);
            label8.TabIndex = 17;
            label8.Text = "Gender:";
            // 
            // comboBoxLocation
            // 
            comboBoxLocation.Cursor = Cursors.Hand;
            comboBoxLocation.FormattingEnabled = true;
            comboBoxLocation.Items.AddRange(new object[] { "Barisal", "Chattogram", "Dhaka", "Khulna", "Mymensingh", "Rajshahi", "Rangpur", "Sylhet" });
            comboBoxLocation.Location = new Point(186, 237);
            comboBoxLocation.Name = "comboBoxLocation";
            comboBoxLocation.Size = new Size(281, 28);
            comboBoxLocation.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(50, 50, 50);
            label6.Location = new Point(81, 237);
            label6.Name = "label6";
            label6.Size = new Size(93, 30);
            label6.TabIndex = 15;
            label6.Text = "Location:";
            // 
            // dateDob
            // 
            dateDob.Location = new Point(186, 180);
            dateDob.Name = "dateDob";
            dateDob.Size = new Size(281, 27);
            dateDob.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(624, 128);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(281, 27);
            txtPassword.TabIndex = 7;
            // 
            // txtFullName
            // 
            txtFullName.BorderStyle = BorderStyle.FixedSingle;
            txtFullName.Location = new Point(186, 125);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(281, 27);
            txtFullName.TabIndex = 7;
            // 
            // txtUserName
            // 
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Location = new Point(186, 70);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(281, 27);
            txtUserName.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(514, 125);
            label2.Name = "label2";
            label2.Size = new Size(104, 30);
            label2.TabIndex = 5;
            label2.Text = "Password:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(49, 180);
            label11.Name = "label11";
            label11.Size = new Size(125, 30);
            label11.TabIndex = 4;
            label11.Text = "Date of Birth:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(69, 122);
            label16.Name = "label16";
            label16.Size = new Size(105, 30);
            label16.TabIndex = 5;
            label16.Text = "Full Name:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(61, 69);
            label10.Name = "label10";
            label10.Size = new Size(113, 30);
            label10.TabIndex = 6;
            label10.Text = "User Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(13, 12);
            label1.Name = "label1";
            label1.Size = new Size(223, 36);
            label1.TabIndex = 2;
            label1.Text = "Sallers Infromations";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(251, 251, 251);
            panel4.Controls.Add(dataSellers);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(313, 382);
            panel4.Name = "panel4";
            panel4.Size = new Size(974, 507);
            panel4.TabIndex = 14;
            // 
            // dataSellers
            // 
            dataSellers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataSellers.BackgroundColor = Color.FromArgb(251, 251, 251);
            dataSellers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataSellers.GridColor = Color.FromArgb(251, 251, 251);
            dataSellers.Location = new Point(21, 52);
            dataSellers.MultiSelect = false;
            dataSellers.Name = "dataSellers";
            dataSellers.ReadOnly = true;
            dataSellers.RowHeadersWidth = 51;
            dataSellers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataSellers.Size = new Size(933, 440);
            dataSellers.TabIndex = 4;
            dataSellers.CellClick += dataSellers_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(13, 9);
            label3.Name = "label3";
            label3.Size = new Size(85, 36);
            label3.TabIndex = 2;
            label3.Text = "Sallers";
            // 
            // AdminSellers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1300, 900);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminSellers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminSellers";
            Load += AdminSellers_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataSellers).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button btnClose;
        private Panel panel2;
        private Button btnLogout;
        private Button btnAdmins;
        private Button btnCustomers;
        private Button btnProducts;
        private Button btnSellers;
        private Button btnRevenue;
        private Button btnProfile;
        private Button btnDashboard;
        private PictureBox pictureBox3;
        private Label label17;
        private Panel panel3;
        private Label label1;
        private DateTimePicker dateDob;
        private TextBox txtFullName;
        private TextBox txtUserName;
        private Label label11;
        private Label label16;
        private Label label10;
        private ComboBox comboBoxLocation;
        private Label label6;
        private RadioButton radioBtnFemale;
        private RadioButton radioBtnMale;
        private Label label8;
        private TextBox txtPassword;
        private Label label2;
        private Button btnDelete;
        private Button btnAdd;
        private Panel panel4;
        private Label label3;
        private Button btnUpdate;
        private Button btnExit;
        private DataGridView dataSellers;
    }
}
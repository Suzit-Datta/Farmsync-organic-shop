namespace Farmsync
{
    partial class loginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUserName = new TextBox();
            label4 = new Label();
            txtPassword = new TextBox();
            label5 = new Label();
            btnRegSeller = new Label();
            btnLogin = new Button();
            checkBoxShowPass = new CheckBox();
            btnClose = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(477, 700);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(592, 208);
            label1.Name = "label1";
            label1.Size = new Size(309, 34);
            label1.TabIndex = 1;
            label1.Text = "Welcome To Farmsync!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(532, 248);
            label2.Name = "label2";
            label2.Size = new Size(418, 30);
            label2.TabIndex = 2;
            label2.Text = "Here sell your farm fresh products to customers";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(50, 50, 50);
            label3.Location = new Point(510, 302);
            label3.Name = "label3";
            label3.Size = new Size(108, 30);
            label3.TabIndex = 2;
            label3.Text = "User Name";
            // 
            // txtUserName
            // 
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Location = new Point(515, 341);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(435, 40);
            txtUserName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(50, 50, 50);
            label4.Location = new Point(510, 395);
            label4.Name = "label4";
            label4.Size = new Size(99, 30);
            label4.TabIndex = 2;
            label4.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(515, 434);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(435, 40);
            txtPassword.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(603, 638);
            label5.Name = "label5";
            label5.Size = new Size(213, 30);
            label5.TabIndex = 2;
            label5.Text = "Don't have an account?";
            // 
            // btnRegSeller
            // 
            btnRegSeller.AutoSize = true;
            btnRegSeller.BackColor = Color.Transparent;
            btnRegSeller.Cursor = Cursors.Hand;
            btnRegSeller.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegSeller.ForeColor = Color.FromArgb(22, 147, 75);
            btnRegSeller.Location = new Point(809, 638);
            btnRegSeller.Name = "btnRegSeller";
            btnRegSeller.Size = new Size(84, 30);
            btnRegSeller.TabIndex = 2;
            btnRegSeller.Text = "Register";
            btnRegSeller.Click += btnRegSeller_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(22, 147, 75);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(655, 531);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(166, 56);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "LOG IN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // checkBoxShowPass
            // 
            checkBoxShowPass.AutoSize = true;
            checkBoxShowPass.Cursor = Cursors.Hand;
            checkBoxShowPass.Font = new Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxShowPass.Location = new Point(803, 484);
            checkBoxShowPass.Name = "checkBoxShowPass";
            checkBoxShowPass.Size = new Size(149, 30);
            checkBoxShowPass.TabIndex = 5;
            checkBoxShowPass.Text = "Show Password";
            checkBoxShowPass.UseVisualStyleBackColor = true;
            checkBoxShowPass.CheckedChanged += checkBoxShowPass_CheckedChanged;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(954, 11);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(34, 34);
            btnClose.TabIndex = 4;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(668, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 251, 251);
            ClientSize = new Size(1000, 700);
            Controls.Add(pictureBox1);
            Controls.Add(checkBoxShowPass);
            Controls.Add(btnClose);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnRegSeller);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "loginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += loginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUserName;
        private Label label4;
        private TextBox txtPassword;
        private Label label5;
        private Label btnRegSeller;
        private Button btnLogin;
        private CheckBox checkBoxShowPass;
        private Button btnClose;
        private PictureBox pictureBox1;
    }
}

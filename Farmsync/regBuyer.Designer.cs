namespace Farmsync
{
    partial class regBuyer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(regBuyer));
            panel1 = new Panel();
            btnCloseRegBuyer = new Button();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUserName = new TextBox();
            label4 = new Label();
            txtFullName = new TextBox();
            label5 = new Label();
            txtPhone = new TextBox();
            label6 = new Label();
            txtPassword = new TextBox();
            btnRegister = new Button();
            label7 = new Label();
            btnLogin = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 152, 219);
            panel1.Controls.Add(btnCloseRegBuyer);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 55);
            panel1.TabIndex = 0;
            // 
            // btnCloseRegBuyer
            // 
            btnCloseRegBuyer.BackColor = Color.FromArgb(52, 152, 219);
            btnCloseRegBuyer.BackgroundImage = (Image)resources.GetObject("btnCloseRegBuyer.BackgroundImage");
            btnCloseRegBuyer.BackgroundImageLayout = ImageLayout.Center;
            btnCloseRegBuyer.Cursor = Cursors.Hand;
            btnCloseRegBuyer.FlatAppearance.BorderSize = 0;
            btnCloseRegBuyer.FlatStyle = FlatStyle.Flat;
            btnCloseRegBuyer.Location = new Point(955, 9);
            btnCloseRegBuyer.Name = "btnCloseRegBuyer";
            btnCloseRegBuyer.Size = new Size(33, 33);
            btnCloseRegBuyer.TabIndex = 1;
            btnCloseRegBuyer.UseVisualStyleBackColor = false;
            btnCloseRegBuyer.Click += btnCloseRegBuyer_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(516, 127);
            panel2.Name = "panel2";
            panel2.Size = new Size(485, 475);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(199, 84);
            label1.Name = "label1";
            label1.Size = new Size(190, 34);
            label1.TabIndex = 2;
            label1.Text = "Register Here";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(67, 127);
            label2.Name = "label2";
            label2.Size = new Size(463, 30);
            label2.TabIndex = 3;
            label2.Text = "Provide Your Information And Start Buying Fresh Food.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(50, 50, 50);
            label3.Location = new Point(45, 173);
            label3.Name = "label3";
            label3.Size = new Size(108, 30);
            label3.TabIndex = 3;
            label3.Text = "User Name";
            // 
            // txtUserName
            // 
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Location = new Point(51, 211);
            txtUserName.MaximumSize = new Size(500, 40);
            txtUserName.MaxLength = 50;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(459, 27);
            txtUserName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(50, 50, 50);
            label4.Location = new Point(45, 253);
            label4.Name = "label4";
            label4.Size = new Size(100, 30);
            label4.TabIndex = 3;
            label4.Text = "Full Name";
            label4.Click += label4_Click;
            // 
            // txtFullName
            // 
            txtFullName.BorderStyle = BorderStyle.FixedSingle;
            txtFullName.Location = new Point(51, 291);
            txtFullName.MaximumSize = new Size(500, 40);
            txtFullName.MaxLength = 50;
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(459, 27);
            txtFullName.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(50, 50, 50);
            label5.Location = new Point(45, 340);
            label5.Name = "label5";
            label5.Size = new Size(67, 30);
            label5.TabIndex = 3;
            label5.Text = "Phone";
            label5.Click += label4_Click;
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Location = new Point(51, 378);
            txtPhone.MaximumSize = new Size(500, 40);
            txtPhone.MaxLength = 50;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(459, 27);
            txtPhone.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(50, 50, 50);
            label6.Location = new Point(45, 427);
            label6.Name = "label6";
            label6.Size = new Size(99, 30);
            label6.TabIndex = 3;
            label6.Text = "Password";
            label6.Click += label4_Click;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(51, 465);
            txtPassword.MaximumSize = new Size(500, 40);
            txtPassword.MaxLength = 50;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(459, 27);
            txtPassword.TabIndex = 4;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(22, 147, 75);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(188, 521);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(158, 60);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(51, 631);
            label7.Name = "label7";
            label7.Size = new Size(234, 30);
            label7.TabIndex = 3;
            label7.Text = "Already have an account?";
            // 
            // btnLogin
            // 
            btnLogin.AutoSize = true;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.FromArgb(22, 147, 75);
            btnLogin.Location = new Point(282, 631);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(64, 30);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Log in";
            btnLogin.Click += label4_Click;
            // 
            // regBuyer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 251, 251);
            ClientSize = new Size(1000, 700);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtPhone);
            Controls.Add(txtFullName);
            Controls.Add(label6);
            Controls.Add(btnLogin);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtUserName);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "regBuyer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += regBuyer_Load_1;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnCloseRegBuyer;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUserName;
        private Label label4;
        private TextBox txtFullName;
        private Label label5;
        private TextBox txtPhone;
        private Label label6;
        private TextBox txtPassword;
        private Button btnRegister;
        private Label label7;
        private Label btnLogin;
    }
}
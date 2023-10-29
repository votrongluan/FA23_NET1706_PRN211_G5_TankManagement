namespace Tank_Management
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            lbUsername = new Label();
            txtUsername = new TextBox();
            label1 = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Location = new Point(343, 222);
            lbUsername.Margin = new Padding(5, 0, 5, 0);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(121, 32);
            lbUsername.TabIndex = 0;
            lbUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(475, 217);
            txtUsername.Margin = new Padding(5, 5, 5, 5);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "username";
            txtUsername.Size = new Size(228, 39);
            txtUsername.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(343, 287);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(111, 32);
            label1.TabIndex = 2;
            label1.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(475, 283);
            txtPassword.Margin = new Padding(5, 5, 5, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "password";
            txtPassword.Size = new Size(228, 39);
            txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Location = new Point(550, 374);
            btnLogin.Margin = new Padding(5, 5, 5, 5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(153, 46);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(442, 78);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(183, 71);
            label2.TabIndex = 5;
            label2.Text = "LOGIN";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Margin = new Padding(5, 5, 5, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1042, 824);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 634);
            Controls.Add(label2);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Controls.Add(txtUsername);
            Controls.Add(lbUsername);
            Controls.Add(pictureBox1);
            Margin = new Padding(5, 5, 5, 5);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUsername;
        private TextBox txtUsername;
        private Label label1;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label label2;
        private PictureBox pictureBox1;
    }
}
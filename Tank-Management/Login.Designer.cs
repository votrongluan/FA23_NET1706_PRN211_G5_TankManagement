namespace Tank_Management {
    partial class Login {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            lbUsername = new Label();
            txtUsername = new TextBox();
            label1 = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lbLogin = new Label();
            SuspendLayout();
            // 
            // lbUsername
            // 
            lbUsername.Anchor = AnchorStyles.None;
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbUsername.Location = new Point(193, 131);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(99, 28);
            lbUsername.TabIndex = 0;
            lbUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.None;
            txtUsername.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtUsername.Cursor = Cursors.IBeam;
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(329, 128);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "username";
            txtUsername.Size = new Size(142, 34);
            txtUsername.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(199, 181);
            label1.Name = "label1";
            label1.Size = new Size(93, 28);
            label1.TabIndex = 2;
            label1.Text = "Password";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(329, 178);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "password";
            txtPassword.Size = new Size(142, 34);
            txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(255, 268);
            btnLogin.Name = "btnLogin";
            btnLogin.RightToLeft = RightToLeft.No;
            btnLogin.Size = new Size(123, 47);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lbLogin
            // 
            lbLogin.Anchor = AnchorStyles.Top;
            lbLogin.BackColor = Color.Transparent;
            lbLogin.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lbLogin.ForeColor = Color.Green;
            lbLogin.Location = new Point(223, 24);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(186, 62);
            lbLogin.TabIndex = 5;
            lbLogin.Text = "LOGIN";
            lbLogin.TextAlign = ContentAlignment.MiddleCenter;
            lbLogin.UseCompatibleTextRendering = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 396);
            Controls.Add(lbLogin);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Controls.Add(txtUsername);
            Controls.Add(lbUsername);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUsername;
        private TextBox txtUsername;
        private Label label1;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lbLogin;
        private PictureBox pictureBox1;
    }
}
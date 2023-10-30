namespace Tank_Management {
    partial class AdminDashboard {
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
            btnManageManufactory = new Button();
            btnManageAmmo = new Button();
            btnManageModel = new Button();
            btnLogout = new Button();
            label1 = new Label();
            btnManageTank = new Button();
            btnViewHistory = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnManageManufactory
            // 
            btnManageManufactory.Anchor = AnchorStyles.None;
            btnManageManufactory.Cursor = Cursors.Hand;
            btnManageManufactory.Location = new Point(114, 173);
            btnManageManufactory.Margin = new Padding(2);
            btnManageManufactory.Name = "btnManageManufactory";
            btnManageManufactory.Size = new Size(288, 29);
            btnManageManufactory.TabIndex = 9;
            btnManageManufactory.Text = "Mange Manufactory";
            btnManageManufactory.UseVisualStyleBackColor = true;
            btnManageManufactory.Click += btnManageManufactory_Click;
            // 
            // btnManageAmmo
            // 
            btnManageAmmo.Anchor = AnchorStyles.None;
            btnManageAmmo.Cursor = Cursors.Hand;
            btnManageAmmo.Location = new Point(114, 128);
            btnManageAmmo.Margin = new Padding(2);
            btnManageAmmo.Name = "btnManageAmmo";
            btnManageAmmo.Size = new Size(288, 29);
            btnManageAmmo.TabIndex = 8;
            btnManageAmmo.Text = "Manage Ammo";
            btnManageAmmo.UseVisualStyleBackColor = true;
            btnManageAmmo.Click += btnManageAmmo_Click;
            // 
            // btnManageModel
            // 
            btnManageModel.Anchor = AnchorStyles.None;
            btnManageModel.Cursor = Cursors.Hand;
            btnManageModel.Location = new Point(114, 81);
            btnManageModel.Margin = new Padding(2);
            btnManageModel.Name = "btnManageModel";
            btnManageModel.Size = new Size(288, 29);
            btnManageModel.TabIndex = 7;
            btnManageModel.Text = "Manage Model";
            btnManageModel.UseVisualStyleBackColor = true;
            btnManageModel.Click += btnManageModel_Click;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.None;
            btnLogout.BackColor = Color.FromArgb(255, 255, 192);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Location = new Point(114, 366);
            btnLogout.Margin = new Padding(2, 2, 2, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(288, 29);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(114, 14);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(299, 46);
            label1.TabIndex = 5;
            label1.Text = "Admin Dashboard";
            // 
            // btnManageTank
            // 
            btnManageTank.Anchor = AnchorStyles.None;
            btnManageTank.Cursor = Cursors.Hand;
            btnManageTank.Location = new Point(114, 220);
            btnManageTank.Margin = new Padding(2);
            btnManageTank.Name = "btnManageTank";
            btnManageTank.Size = new Size(288, 29);
            btnManageTank.TabIndex = 10;
            btnManageTank.Text = "Manage Tank";
            btnManageTank.UseVisualStyleBackColor = true;
            btnManageTank.Click += btnManageTank_Click;
            // 
            // btnViewHistory
            // 
            btnViewHistory.Anchor = AnchorStyles.None;
            btnViewHistory.Cursor = Cursors.Hand;
            btnViewHistory.Location = new Point(114, 316);
            btnViewHistory.Margin = new Padding(2, 2, 2, 2);
            btnViewHistory.Name = "btnViewHistory";
            btnViewHistory.Size = new Size(288, 29);
            btnViewHistory.TabIndex = 11;
            btnViewHistory.Text = "View History";
            btnViewHistory.UseVisualStyleBackColor = true;
            btnViewHistory.Click += btnViewHistory_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(114, 270);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(288, 27);
            button1.TabIndex = 12;
            button1.Text = "Mange Driver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 439);
            Controls.Add(button1);
            Controls.Add(btnViewHistory);
            Controls.Add(btnManageTank);
            Controls.Add(btnManageManufactory);
            Controls.Add(btnManageAmmo);
            Controls.Add(btnManageModel);
            Controls.Add(btnLogout);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnManageManufactory;
        private Button btnManageAmmo;
        private Button btnManageModel;
        private Button btnLogout;
        private Label label1;
        private Button btnManageTank;
        private Button btnViewHistory;
        private Button button1;
    }
}
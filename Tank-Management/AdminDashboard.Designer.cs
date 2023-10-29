namespace Tank_Management
{
    partial class AdminDashboard
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
            btnManageManufactory = new Button();
            btnManageAmmo = new Button();
            btnManageModel = new Button();
            btnLogout = new Button();
            label1 = new Label();
            btnManageTank = new Button();
            btnViewHistory = new Button();
            SuspendLayout();
            // 
            // btnManageManufactory
            // 
            btnManageManufactory.Location = new Point(185, 277);
            btnManageManufactory.Name = "btnManageManufactory";
            btnManageManufactory.Size = new Size(468, 46);
            btnManageManufactory.TabIndex = 9;
            btnManageManufactory.Text = "Mange Manufactory";
            btnManageManufactory.UseVisualStyleBackColor = true;
            btnManageManufactory.Click += btnManageManufactory_Click;
            // 
            // btnManageAmmo
            // 
            btnManageAmmo.Location = new Point(185, 205);
            btnManageAmmo.Name = "btnManageAmmo";
            btnManageAmmo.Size = new Size(468, 46);
            btnManageAmmo.TabIndex = 8;
            btnManageAmmo.Text = "Manage Ammo";
            btnManageAmmo.UseVisualStyleBackColor = true;
            btnManageAmmo.Click += btnManageAmmo_Click;
            // 
            // btnManageModel
            // 
            btnManageModel.Location = new Point(185, 129);
            btnManageModel.Name = "btnManageModel";
            btnManageModel.Size = new Size(468, 46);
            btnManageModel.TabIndex = 7;
            btnManageModel.Text = "Manage Model";
            btnManageModel.UseVisualStyleBackColor = true;
            btnManageModel.Click += btnManageModel_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(255, 255, 192);
            btnLogout.Location = new Point(185, 501);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(468, 46);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(185, 23);
            label1.Name = "label1";
            label1.Size = new Size(468, 71);
            label1.TabIndex = 5;
            label1.Text = "Admin Dashboard";
            // 
            // btnManageTank
            // 
            btnManageTank.Location = new Point(185, 352);
            btnManageTank.Name = "btnManageTank";
            btnManageTank.Size = new Size(468, 46);
            btnManageTank.TabIndex = 10;
            btnManageTank.Text = "Manage Tank";
            btnManageTank.UseVisualStyleBackColor = true;
            btnManageTank.Click += btnManageTank_Click;
            // 
            // btnViewHistory
            // 
            btnViewHistory.Location = new Point(185, 427);
            btnViewHistory.Name = "btnViewHistory";
            btnViewHistory.Size = new Size(468, 46);
            btnViewHistory.TabIndex = 11;
            btnViewHistory.Text = "View History";
            btnViewHistory.UseVisualStyleBackColor = true;
            btnViewHistory.Click += btnViewHistory_Click;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 604);
            Controls.Add(btnViewHistory);
            Controls.Add(btnManageTank);
            Controls.Add(btnManageManufactory);
            Controls.Add(btnManageAmmo);
            Controls.Add(btnManageModel);
            Controls.Add(btnLogout);
            Controls.Add(label1);
            Name = "AdminDashboard";
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
    }
}
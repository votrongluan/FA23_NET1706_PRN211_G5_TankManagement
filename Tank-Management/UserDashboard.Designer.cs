namespace Tank_Management
{
    partial class UserDashboard
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
            label1 = new Label();
            btnLogout = new Button();
            btnManageDriver = new Button();
            btnViewTankHistory = new Button();
            btnChangeUnit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(207, 32);
            label1.Name = "label1";
            label1.Size = new Size(416, 71);
            label1.TabIndex = 0;
            label1.Text = "User Dashboard";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(255, 255, 192);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Location = new Point(207, 354);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(416, 46);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnManageDriver
            // 
            btnManageDriver.Cursor = Cursors.Hand;
            btnManageDriver.Location = new Point(207, 135);
            btnManageDriver.Name = "btnManageDriver";
            btnManageDriver.Size = new Size(416, 46);
            btnManageDriver.TabIndex = 2;
            btnManageDriver.Text = "Manage Driver";
            btnManageDriver.UseVisualStyleBackColor = true;
            btnManageDriver.Click += btnManageDriver_Click;
            // 
            // btnViewTankHistory
            // 
            btnViewTankHistory.Cursor = Cursors.Hand;
            btnViewTankHistory.Location = new Point(207, 209);
            btnViewTankHistory.Name = "btnViewTankHistory";
            btnViewTankHistory.Size = new Size(416, 46);
            btnViewTankHistory.TabIndex = 3;
            btnViewTankHistory.Text = "View Tank History";
            btnViewTankHistory.UseVisualStyleBackColor = true;
            btnViewTankHistory.Click += btnViewTankHistory_Click;
            // 
            // btnChangeUnit
            // 
            btnChangeUnit.Cursor = Cursors.Hand;
            btnChangeUnit.Location = new Point(207, 281);
            btnChangeUnit.Name = "btnChangeUnit";
            btnChangeUnit.Size = new Size(416, 46);
            btnChangeUnit.TabIndex = 4;
            btnChangeUnit.Text = "Change Tank Unit";
            btnChangeUnit.UseVisualStyleBackColor = true;
            btnChangeUnit.Click += btnChangeUnit_Click;
            // 
            // UserDashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnChangeUnit);
            Controls.Add(btnViewTankHistory);
            Controls.Add(btnManageDriver);
            Controls.Add(btnLogout);
            Controls.Add(label1);
            Name = "UserDashboard";
            Text = "UserDashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnLogout;
        private Button btnManageDriver;
        private Button btnViewTankHistory;
        private Button btnChangeUnit;
    }
}
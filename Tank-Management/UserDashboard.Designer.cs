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
            btnViewTankHistory = new Button();
            btnChangeUnit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(141, 32);
            label1.Name = "label1";
            label1.Size = new Size(416, 71);
            label1.TabIndex = 0;
            label1.Text = "User Dashboard";
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.None;
            btnLogout.BackColor = Color.FromArgb(255, 255, 192);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Location = new Point(141, 355);
            btnLogout.Margin = new Padding(2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(416, 50);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnViewTankHistory
            // 
            btnViewTankHistory.Anchor = AnchorStyles.None;
            btnViewTankHistory.Cursor = Cursors.Hand;
            btnViewTankHistory.Location = new Point(141, 151);
            btnViewTankHistory.Margin = new Padding(2);
            btnViewTankHistory.Name = "btnViewTankHistory";
            btnViewTankHistory.Size = new Size(416, 50);
            btnViewTankHistory.TabIndex = 3;
            btnViewTankHistory.Text = "View Tank History";
            btnViewTankHistory.UseVisualStyleBackColor = true;
            btnViewTankHistory.Click += btnViewTankHistory_Click;
            // 
            // btnChangeUnit
            // 
            btnChangeUnit.Anchor = AnchorStyles.None;
            btnChangeUnit.Cursor = Cursors.Hand;
            btnChangeUnit.Location = new Point(141, 253);
            btnChangeUnit.Margin = new Padding(2);
            btnChangeUnit.Name = "btnChangeUnit";
            btnChangeUnit.Size = new Size(416, 50);
            btnChangeUnit.TabIndex = 4;
            btnChangeUnit.Text = "Change Tank Unit";
            btnChangeUnit.UseVisualStyleBackColor = true;
            btnChangeUnit.Click += btnChangeUnit_Click;
            // 
            // UserDashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 533);
            Controls.Add(btnChangeUnit);
            Controls.Add(btnViewTankHistory);
            Controls.Add(btnLogout);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "UserDashboard";
            Text = "UserDashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnLogout;
        private Button btnViewTankHistory;
        private Button btnChangeUnit;
    }
}
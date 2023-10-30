namespace Tank_Management
{
    partial class DriverTank
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
            btnResetTankDgv = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label4 = new Label();
            btnBack = new Button();
            btnChange = new Button();
            cbxTankId = new ComboBox();
            txtDriverIdCard = new TextBox();
            label3 = new Label();
            label2 = new Label();
            dgvTank = new DataGridView();
            label1 = new Label();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTank).BeginInit();
            SuspendLayout();
            // 
            // btnResetTankDgv
            // 
            btnResetTankDgv.Location = new Point(59, 842);
            btnResetTankDgv.Name = "btnResetTankDgv";
            btnResetTankDgv.Size = new Size(220, 46);
            btnResetTankDgv.TabIndex = 24;
            btnResetTankDgv.Text = "Reset tank data";
            btnResetTankDgv.UseVisualStyleBackColor = true;
            btnResetTankDgv.Click += btnResetTankDgv_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1461, 143);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(150, 46);
            btnSearch.TabIndex = 23;
            btnSearch.Text = "Find";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(175, 147);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Find by id, model or manufactory";
            txtSearch.Size = new Size(1258, 39);
            txtSearch.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 150);
            label4.Name = "label4";
            label4.Size = new Size(85, 32);
            label4.TabIndex = 21;
            label4.Text = "Search";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(255, 255, 192);
            btnBack.Location = new Point(1319, 842);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(292, 46);
            btnBack.TabIndex = 20;
            btnBack.Text = "Back to Dashboard";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnChange
            // 
            btnChange.Location = new Point(1461, 403);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(150, 46);
            btnChange.TabIndex = 19;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // cbxTankId
            // 
            cbxTankId.FormattingEnabled = true;
            cbxTankId.Location = new Point(1336, 321);
            cbxTankId.Name = "cbxTankId";
            cbxTankId.Size = new Size(275, 40);
            cbxTankId.TabIndex = 18;
            // 
            // txtDriverIdCard
            // 
            txtDriverIdCard.Enabled = false;
            txtDriverIdCard.Location = new Point(1336, 259);
            txtDriverIdCard.Name = "txtDriverIdCard";
            txtDriverIdCard.ReadOnly = true;
            txtDriverIdCard.Size = new Size(275, 39);
            txtDriverIdCard.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1124, 324);
            label3.Name = "label3";
            label3.Size = new Size(182, 32);
            label3.TabIndex = 16;
            label3.Text = "Tank Model - Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1141, 262);
            label2.Name = "label2";
            label2.Size = new Size(165, 32);
            label2.TabIndex = 15;
            label2.Text = "Chosen Driver";
            // 
            // dgvTank
            // 
            dgvTank.BackgroundColor = Color.White;
            dgvTank.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTank.Location = new Point(59, 224);
            dgvTank.Name = "dgvTank";
            dgvTank.ReadOnly = true;
            dgvTank.RowHeadersWidth = 82;
            dgvTank.RowTemplate.Height = 41;
            dgvTank.Size = new Size(1050, 578);
            dgvTank.TabIndex = 14;
            dgvTank.CellDoubleClick += dgvTank_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(647, 27);
            label1.Name = "label1";
            label1.Size = new Size(514, 71);
            label1.TabIndex = 13;
            label1.Text = "Manage Tank Driver";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1156, 403);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 46);
            btnDelete.TabIndex = 25;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // TankDriver
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1671, 927);
            Controls.Add(btnDelete);
            Controls.Add(btnResetTankDgv);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label4);
            Controls.Add(btnBack);
            Controls.Add(btnChange);
            Controls.Add(cbxTankId);
            Controls.Add(txtDriverIdCard);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvTank);
            Controls.Add(label1);
            Name = "TankDriver";
            Text = "TankDriver";
            ((System.ComponentModel.ISupportInitialize)dgvTank).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnResetTankDgv;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label4;
        private Button btnBack;
        private Button btnChange;
        private ComboBox cbxTankId;
        private TextBox txtDriverIdCard;
        private Label label3;
        private Label label2;
        private DataGridView dgvTank;
        private Label label1;
        private Button btnDelete;
    }
}
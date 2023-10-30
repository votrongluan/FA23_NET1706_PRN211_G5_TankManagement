namespace Tank_Management {
    partial class DriverTank {
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
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvTank).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnResetTankDgv
            // 
            btnResetTankDgv.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnResetTankDgv.Location = new Point(0, 443);
            btnResetTankDgv.Margin = new Padding(2);
            btnResetTankDgv.Name = "btnResetTankDgv";
            btnResetTankDgv.Size = new Size(135, 29);
            btnResetTankDgv.TabIndex = 24;
            btnResetTankDgv.Text = "Reset tank data";
            btnResetTankDgv.UseVisualStyleBackColor = true;
            btnResetTankDgv.Click += btnResetTankDgv_Click;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Location = new Point(552, 15);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(92, 29);
            btnSearch.TabIndex = 23;
            btnSearch.Text = "Find";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(59, 15);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Find by id, model or manufactory";
            txtSearch.Size = new Size(489, 27);
            txtSearch.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(2, 18);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 21;
            label4.Text = "Search";
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBack.BackColor = Color.FromArgb(255, 255, 192);
            btnBack.Location = new Point(812, 526);
            btnBack.Margin = new Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(180, 29);
            btnBack.TabIndex = 20;
            btnBack.Text = "Back to Dashboard";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnChange
            // 
            btnChange.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnChange.Location = new Point(899, 252);
            btnChange.Margin = new Padding(2);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(92, 29);
            btnChange.TabIndex = 19;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // cbxTankId
            // 
            cbxTankId.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbxTankId.FormattingEnabled = true;
            cbxTankId.Location = new Point(822, 201);
            cbxTankId.Margin = new Padding(2);
            cbxTankId.Name = "cbxTankId";
            cbxTankId.Size = new Size(171, 28);
            cbxTankId.TabIndex = 18;
            // 
            // txtDriverIdCard
            // 
            txtDriverIdCard.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtDriverIdCard.Enabled = false;
            txtDriverIdCard.Location = new Point(822, 162);
            txtDriverIdCard.Margin = new Padding(2);
            txtDriverIdCard.Name = "txtDriverIdCard";
            txtDriverIdCard.ReadOnly = true;
            txtDriverIdCard.Size = new Size(171, 27);
            txtDriverIdCard.TabIndex = 17;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(692, 202);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 16;
            label3.Text = "Tank Model - Id";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(702, 164);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 15;
            label2.Text = "Chosen Driver";
            // 
            // dgvTank
            // 
            dgvTank.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTank.BackgroundColor = Color.White;
            dgvTank.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTank.Location = new Point(36, 140);
            dgvTank.Margin = new Padding(2);
            dgvTank.Name = "dgvTank";
            dgvTank.ReadOnly = true;
            dgvTank.RowHeadersWidth = 82;
            dgvTank.RowTemplate.Height = 41;
            dgvTank.Size = new Size(646, 361);
            dgvTank.TabIndex = 14;
            dgvTank.CellDoubleClick += dgvTank_CellDoubleClick;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(398, 17);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(329, 46);
            label1.TabIndex = 13;
            label1.Text = "Manage Tank Driver";
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Location = new Point(711, 252);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 29);
            btnDelete.TabIndex = 25;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(btnResetTankDgv);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnSearch);
            panel1.Location = new Point(36, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(646, 472);
            panel1.TabIndex = 26;
            // 
            // DriverTank
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 579);
            Controls.Add(btnDelete);
            Controls.Add(btnBack);
            Controls.Add(btnChange);
            Controls.Add(cbxTankId);
            Controls.Add(txtDriverIdCard);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvTank);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "DriverTank";
            Text = "TankDriver";
            ((System.ComponentModel.ISupportInitialize)dgvTank).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
    }
}
namespace Tank_Management {
    partial class ChangeUnit {
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
            label1 = new Label();
            dgvTank = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            txtTankId = new TextBox();
            cbxUnitId = new ComboBox();
            btnChange = new Button();
            btnBack = new Button();
            label4 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnResetTankDgv = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvTank).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(431, 12);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(211, 46);
            label1.TabIndex = 1;
            label1.Text = "Change Unit";
            // 
            // dgvTank
            // 
            dgvTank.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTank.BackgroundColor = Color.White;
            dgvTank.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTank.Location = new Point(25, 128);
            dgvTank.Margin = new Padding(2);
            dgvTank.Name = "dgvTank";
            dgvTank.ReadOnly = true;
            dgvTank.RowHeadersWidth = 82;
            dgvTank.RowTemplate.Height = 41;
            dgvTank.Size = new Size(646, 361);
            dgvTank.TabIndex = 2;
            dgvTank.CellDoubleClick += dgvTank_CellDoubleClick;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(684, 152);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 3;
            label2.Text = "Chosen Tank Id";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(756, 191);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 4;
            label3.Text = "Unit";
            // 
            // txtTankId
            // 
            txtTankId.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTankId.Enabled = false;
            txtTankId.Location = new Point(810, 150);
            txtTankId.Margin = new Padding(2);
            txtTankId.Name = "txtTankId";
            txtTankId.ReadOnly = true;
            txtTankId.Size = new Size(171, 27);
            txtTankId.TabIndex = 5;
            // 
            // cbxUnitId
            // 
            cbxUnitId.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbxUnitId.FormattingEnabled = true;
            cbxUnitId.Location = new Point(810, 189);
            cbxUnitId.Margin = new Padding(2);
            cbxUnitId.Name = "cbxUnitId";
            cbxUnitId.Size = new Size(171, 28);
            cbxUnitId.TabIndex = 6;
            // 
            // btnChange
            // 
            btnChange.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnChange.Location = new Point(887, 240);
            btnChange.Margin = new Padding(2);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(92, 29);
            btnChange.TabIndex = 7;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBack.BackColor = Color.FromArgb(255, 255, 192);
            btnBack.Location = new Point(800, 514);
            btnBack.Margin = new Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(180, 29);
            btnBack.TabIndex = 8;
            btnBack.Text = "Back to Dashboard";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(2, 9);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 9;
            label4.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(59, 6);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Find by unit, name, manfactory";
            txtSearch.Size = new Size(489, 27);
            txtSearch.TabIndex = 10;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Location = new Point(552, 6);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(92, 29);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Find";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnResetTankDgv
            // 
            btnResetTankDgv.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnResetTankDgv.Location = new Point(2, 430);
            btnResetTankDgv.Margin = new Padding(2);
            btnResetTankDgv.Name = "btnResetTankDgv";
            btnResetTankDgv.Size = new Size(135, 29);
            btnResetTankDgv.TabIndex = 12;
            btnResetTankDgv.Text = "Reset tank data";
            btnResetTankDgv.UseVisualStyleBackColor = true;
            btnResetTankDgv.Click += btnResetTankDgv_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(btnResetTankDgv);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtSearch);
            panel1.Location = new Point(25, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(646, 461);
            panel1.TabIndex = 13;
            // 
            // ChangeUnit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 572);
            Controls.Add(btnBack);
            Controls.Add(btnChange);
            Controls.Add(cbxUnitId);
            Controls.Add(txtTankId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvTank);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "ChangeUnit";
            Text = "ChangeUnit";
            ((System.ComponentModel.ISupportInitialize)dgvTank).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvTank;
        private Label label2;
        private Label label3;
        private TextBox txtTankId;
        private ComboBox cbxUnitId;
        private Button btnChange;
        private Button btnResetTankDgv;
        private Button btnBack;
        private Label label4;
        private TextBox txtSearch;
        private Button btnSearch;
        private Panel panel1;
    }
}
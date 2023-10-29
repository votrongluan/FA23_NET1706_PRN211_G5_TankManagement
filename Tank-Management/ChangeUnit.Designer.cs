namespace Tank_Management
{
    partial class ChangeUnit
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
            ((System.ComponentModel.ISupportInitialize)dgvTank).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(560, 20);
            label1.Name = "label1";
            label1.Size = new Size(329, 71);
            label1.TabIndex = 1;
            label1.Text = "Change Unit";
            // 
            // dgvTank
            // 
            dgvTank.BackgroundColor = Color.White;
            dgvTank.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTank.Location = new Point(40, 205);
            dgvTank.Name = "dgvTank";
            dgvTank.ReadOnly = true;
            dgvTank.RowHeadersWidth = 82;
            dgvTank.RowTemplate.Height = 41;
            dgvTank.Size = new Size(757, 578);
            dgvTank.TabIndex = 2;
            dgvTank.CellDoubleClick += dgvTank_CellDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(834, 243);
            label2.Name = "label2";
            label2.Size = new Size(176, 32);
            label2.TabIndex = 3;
            label2.Text = "Chosen Tank Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(952, 305);
            label3.Name = "label3";
            label3.Size = new Size(58, 32);
            label3.TabIndex = 4;
            label3.Text = "Unit";
            // 
            // txtTankId
            // 
            txtTankId.Enabled = false;
            txtTankId.Location = new Point(1040, 240);
            txtTankId.Name = "txtTankId";
            txtTankId.ReadOnly = true;
            txtTankId.Size = new Size(275, 39);
            txtTankId.TabIndex = 5;
            // 
            // cbxUnitId
            // 
            cbxUnitId.FormattingEnabled = true;
            cbxUnitId.Location = new Point(1040, 302);
            cbxUnitId.Name = "cbxUnitId";
            cbxUnitId.Size = new Size(275, 40);
            cbxUnitId.TabIndex = 6;
            // 
            // btnChange
            // 
            btnChange.Location = new Point(1165, 384);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(150, 46);
            btnChange.TabIndex = 7;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(255, 255, 192);
            btnBack.Location = new Point(1023, 823);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(292, 46);
            btnBack.TabIndex = 8;
            btnBack.Text = "Back to Dashboard";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 131);
            label4.Name = "label4";
            label4.Size = new Size(85, 32);
            label4.TabIndex = 9;
            label4.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(156, 128);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Find by id, model or manufactory";
            txtSearch.Size = new Size(977, 39);
            txtSearch.TabIndex = 10;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1165, 124);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(150, 46);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Find";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnResetTankDgv
            // 
            btnResetTankDgv.Location = new Point(40, 823);
            btnResetTankDgv.Name = "btnResetTankDgv";
            btnResetTankDgv.Size = new Size(220, 46);
            btnResetTankDgv.TabIndex = 12;
            btnResetTankDgv.Text = "Reset tank data";
            btnResetTankDgv.UseVisualStyleBackColor = true;
            btnResetTankDgv.Click += btnResetTankDgv_Click;
            // 
            // ChangeUnit
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1351, 916);
            Controls.Add(btnResetTankDgv);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label4);
            Controls.Add(btnBack);
            Controls.Add(btnChange);
            Controls.Add(cbxUnitId);
            Controls.Add(txtTankId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvTank);
            Controls.Add(label1);
            Name = "ChangeUnit";
            Text = "ChangeUnit";
            ((System.ComponentModel.ISupportInitialize)dgvTank).EndInit();
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
    }
}
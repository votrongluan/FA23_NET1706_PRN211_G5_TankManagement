namespace Tank_Management
{
    partial class AmmoGrid
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
            btnReset = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnCreate = new Button();
            label7 = new Label();
            txtPrice = new TextBox();
            label6 = new Label();
            txtName = new TextBox();
            label5 = new Label();
            btnResetAmmoDgv = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label4 = new Label();
            btnBack = new Button();
            txtId = new TextBox();
            label2 = new Label();
            dgvAmmo = new DataGridView();
            label1 = new Label();
            txtWeight = new TextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvAmmo).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReset.Location = new Point(1676, 683);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(150, 46);
            btnReset.TabIndex = 56;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(1313, 683);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 46);
            btnDelete.TabIndex = 55;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(1313, 592);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(150, 46);
            btnUpdate.TabIndex = 54;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCreate
            // 
            btnCreate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCreate.Location = new Point(1676, 592);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(150, 46);
            btnCreate.TabIndex = 53;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(1313, 501);
            label7.Name = "label7";
            label7.Size = new Size(137, 32);
            label7.TabIndex = 51;
            label7.Text = "Weight (kg)";
            // 
            // txtPrice
            // 
            txtPrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPrice.Location = new Point(1470, 416);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(362, 39);
            txtPrice.TabIndex = 50;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(1306, 416);
            label6.Name = "label6";
            label6.Size = new Size(99, 32);
            label6.TabIndex = 49;
            label6.Text = "Price ($)";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtName.Location = new Point(1470, 336);
            txtName.Name = "txtName";
            txtName.Size = new Size(362, 39);
            txtName.TabIndex = 48;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(1308, 336);
            label5.Name = "label5";
            label5.Size = new Size(78, 32);
            label5.TabIndex = 47;
            label5.Text = "Name";
            // 
            // btnResetAmmoDgv
            // 
            btnResetAmmoDgv.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnResetAmmoDgv.Location = new Point(0, 698);
            btnResetAmmoDgv.Name = "btnResetAmmoDgv";
            btnResetAmmoDgv.Size = new Size(219, 46);
            btnResetAmmoDgv.TabIndex = 45;
            btnResetAmmoDgv.Text = "Reset table data";
            btnResetAmmoDgv.UseVisualStyleBackColor = true;
            btnResetAmmoDgv.Click += btnResetAmmoDgv_Click;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Location = new Point(1048, 6);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(150, 46);
            btnSearch.TabIndex = 44;
            btnSearch.Text = "Find";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(96, 10);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Find by name, price , weight";
            txtSearch.Size = new Size(911, 39);
            txtSearch.TabIndex = 43;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 14);
            label4.Name = "label4";
            label4.Size = new Size(85, 32);
            label4.TabIndex = 42;
            label4.Text = "Search";
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBack.BackColor = Color.FromArgb(255, 255, 192);
            btnBack.Location = new Point(1535, 837);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(292, 46);
            btnBack.TabIndex = 41;
            btnBack.Text = "Back to Dashboard";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtId.Enabled = false;
            txtId.Location = new Point(1470, 254);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(362, 39);
            txtId.TabIndex = 40;
            // 
            // label2
            // 
            label2.AllowDrop = true;
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(1313, 256);
            label2.Name = "label2";
            label2.Size = new Size(34, 32);
            label2.TabIndex = 38;
            label2.Text = "Id";
            // 
            // dgvAmmo
            // 
            dgvAmmo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAmmo.BackgroundColor = Color.White;
            dgvAmmo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAmmo.Location = new Point(91, 218);
            dgvAmmo.Name = "dgvAmmo";
            dgvAmmo.ReadOnly = true;
            dgvAmmo.RowHeadersWidth = 82;
            dgvAmmo.RowTemplate.Height = 41;
            dgvAmmo.Size = new Size(1198, 578);
            dgvAmmo.TabIndex = 37;
            dgvAmmo.CellDoubleClick += dgvAmmo_CellDoubleClick_1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(848, 32);
            label1.Name = "label1";
            label1.Size = new Size(375, 71);
            label1.TabIndex = 36;
            label1.Text = "Mange Ammo";
            // 
            // txtWeight
            // 
            txtWeight.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtWeight.Location = new Point(1470, 494);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(362, 39);
            txtWeight.TabIndex = 57;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnResetAmmoDgv);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(btnSearch);
            panel1.Location = new Point(91, 138);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1198, 744);
            panel1.TabIndex = 58;
            // 
            // AmmoGrid
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1921, 936);
            Controls.Add(txtWeight);
            Controls.Add(btnReset);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(label7);
            Controls.Add(txtPrice);
            Controls.Add(label6);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(btnBack);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(dgvAmmo);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(5);
            Name = "AmmoGrid";
            Text = "AmmoGrid";
            ((System.ComponentModel.ISupportInitialize)dgvAmmo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReset;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnCreate;
        private Label label7;
        private TextBox txtPrice;
        private Label label6;
        private TextBox txtName;
        private Label label5;
        private Button btnResetAmmoDgv;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label4;
        private Button btnBack;
        private TextBox txtId;
        private Label label2;
        private DataGridView dgvAmmo;
        private Label label1;
        private TextBox txtWeight;
        private Panel panel1;
    }
}
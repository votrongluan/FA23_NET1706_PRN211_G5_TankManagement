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
            ((System.ComponentModel.ISupportInitialize)dgvAmmo).BeginInit();
            SuspendLayout();
            // 
            // btnReset
            // 
            btnReset.Location = new Point(1011, 427);
            btnReset.Margin = new Padding(2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(92, 29);
            btnReset.TabIndex = 56;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(808, 427);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 29);
            btnDelete.TabIndex = 55;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(808, 370);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(92, 29);
            btnUpdate.TabIndex = 54;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(1011, 370);
            btnCreate.Margin = new Padding(2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(92, 29);
            btnCreate.TabIndex = 53;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(798, 316);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(56, 20);
            label7.TabIndex = 51;
            label7.Text = "Weight";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(881, 260);
            txtPrice.Margin = new Padding(2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(224, 27);
            txtPrice.TabIndex = 50;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(804, 260);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 49;
            label6.Text = "Price";
            // 
            // txtName
            // 
            txtName.Location = new Point(881, 210);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(224, 27);
            txtName.TabIndex = 48;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(805, 210);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 47;
            label5.Text = "Name";
            // 
            // btnResetAmmoDgv
            // 
            btnResetAmmoDgv.Location = new Point(77, 522);
            btnResetAmmoDgv.Margin = new Padding(2);
            btnResetAmmoDgv.Name = "btnResetAmmoDgv";
            btnResetAmmoDgv.Size = new Size(135, 29);
            btnResetAmmoDgv.TabIndex = 45;
            btnResetAmmoDgv.Text = "Reset ammo data";
            btnResetAmmoDgv.UseVisualStyleBackColor = true;
            btnResetAmmoDgv.Click += btnResetAmmoDgv_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1011, 86);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(92, 29);
            btnSearch.TabIndex = 44;
            btnSearch.Text = "Find";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(148, 88);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Find by id, model or manufactory";
            txtSearch.Size = new Size(854, 27);
            txtSearch.TabIndex = 43;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 90);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 42;
            label4.Text = "Search";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(255, 255, 192);
            btnBack.Location = new Point(924, 523);
            btnBack.Margin = new Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(180, 29);
            btnBack.TabIndex = 41;
            btnBack.Text = "Back to Dashboard";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(881, 159);
            txtId.Margin = new Padding(2);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(224, 27);
            txtId.TabIndex = 40;
            // 
            // label2
            // 
            label2.AllowDrop = true;
            label2.AutoSize = true;
            label2.Location = new Point(808, 160);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(22, 20);
            label2.TabIndex = 38;
            label2.Text = "Id";
            // 
            // dgvAmmo
            // 
            dgvAmmo.BackgroundColor = Color.White;
            dgvAmmo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAmmo.Location = new Point(77, 136);
            dgvAmmo.Margin = new Padding(2);
            dgvAmmo.Name = "dgvAmmo";
            dgvAmmo.ReadOnly = true;
            dgvAmmo.RowHeadersWidth = 82;
            dgvAmmo.RowTemplate.Height = 41;
            dgvAmmo.Size = new Size(702, 361);
            dgvAmmo.TabIndex = 37;
            dgvAmmo.CellContentClick += dgvAmmo_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(522, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(239, 46);
            label1.TabIndex = 36;
            label1.Text = "Mange Ammo";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(881, 309);
            txtWeight.Margin = new Padding(2);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(224, 27);
            txtWeight.TabIndex = 57;
            // 
            // AmmoGrid
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 668);
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
            Controls.Add(btnResetAmmoDgv);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label4);
            Controls.Add(btnBack);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(dgvAmmo);
            Controls.Add(label1);
            Name = "AmmoGrid";
            Text = "AmmoGrid";
            ((System.ComponentModel.ISupportInitialize)dgvAmmo).EndInit();
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
    }
}
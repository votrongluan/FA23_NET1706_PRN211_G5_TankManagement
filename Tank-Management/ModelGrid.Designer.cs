namespace Tank_Management
{
    partial class ModelGrid
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
            dgvListModels = new DataGridView();
            btnBackToDashboard = new Button();
            lblId = new Label();
            txtId = new TextBox();
            lblWeight = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtDetail = new TextBox();
            txtName = new TextBox();
            cbAmmo = new ComboBox();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnReset = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            nudWeight = new NumericUpDown();
            nudMaxSpeed = new NumericUpDown();
            nudMaxNoDriver = new NumericUpDown();
            nudPrice = new NumericUpDown();
            nudShootingRange = new NumericUpDown();
            panel1 = new Panel();
            btnResetTable = new Button();
            label1 = new Label();
            label9 = new Label();
            txtAmmoDepricated = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvListModels).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxNoDriver).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudShootingRange).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvListModels
            // 
            dgvListModels.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvListModels.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvListModels.BackgroundColor = Color.White;
            dgvListModels.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListModels.Location = new Point(517, 105);
            dgvListModels.Name = "dgvListModels";
            dgvListModels.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvListModels.RowTemplate.Height = 33;
            dgvListModels.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListModels.Size = new Size(1382, 794);
            dgvListModels.TabIndex = 0;
            dgvListModels.CellDoubleClick += dgvListModels_CellDoubleClick;
            // 
            // btnBackToDashboard
            // 
            btnBackToDashboard.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBackToDashboard.BackColor = Color.FromArgb(255, 255, 192);
            btnBackToDashboard.Location = new Point(1113, 820);
            btnBackToDashboard.Name = "btnBackToDashboard";
            btnBackToDashboard.Size = new Size(270, 44);
            btnBackToDashboard.TabIndex = 3;
            btnBackToDashboard.Text = "Back to Dashboard";
            btnBackToDashboard.UseVisualStyleBackColor = false;
            btnBackToDashboard.Click += btnBackToDashboard_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(21, 161);
            lblId.Name = "lblId";
            lblId.Size = new Size(34, 32);
            lblId.TabIndex = 4;
            lblId.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(237, 161);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(228, 39);
            txtId.TabIndex = 5;
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Location = new Point(16, 220);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(140, 32);
            lblWeight.TabIndex = 6;
            lblWeight.Text = "Weight(ton)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 282);
            label2.Name = "label2";
            label2.Size = new Size(203, 32);
            label2.TabIndex = 7;
            label2.Text = "Max Speed(km/h)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 334);
            label3.Name = "label3";
            label3.Size = new Size(76, 32);
            label3.TabIndex = 8;
            label3.Text = "Detail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 392);
            label4.Name = "label4";
            label4.Size = new Size(169, 32);
            label4.TabIndex = 9;
            label4.Text = "Max No Driver";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 456);
            label5.Name = "label5";
            label5.Size = new Size(85, 32);
            label5.TabIndex = 10;
            label5.Text = "Ammo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 571);
            label6.Name = "label6";
            label6.Size = new Size(92, 32);
            label6.TabIndex = 11;
            label6.Text = "Price($)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 635);
            label7.Name = "label7";
            label7.Size = new Size(78, 32);
            label7.TabIndex = 12;
            label7.Text = "Name";
            // 
            // txtDetail
            // 
            txtDetail.Location = new Point(237, 334);
            txtDetail.Name = "txtDetail";
            txtDetail.Size = new Size(233, 39);
            txtDetail.TabIndex = 15;
            // 
            // txtName
            // 
            txtName.Location = new Point(237, 630);
            txtName.Name = "txtName";
            txtName.Size = new Size(233, 39);
            txtName.TabIndex = 19;
            // 
            // cbAmmo
            // 
            cbAmmo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAmmo.FormattingEnabled = true;
            cbAmmo.Location = new Point(237, 449);
            cbAmmo.Name = "cbAmmo";
            cbAmmo.Size = new Size(233, 40);
            cbAmmo.TabIndex = 21;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(16, 751);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(146, 44);
            btnCreate.TabIndex = 22;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(169, 751);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(146, 44);
            btnUpdate.TabIndex = 23;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightCoral;
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(325, 751);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(146, 44);
            btnDelete.TabIndex = 24;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnReset.Location = new Point(325, 817);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(146, 44);
            btnReset.TabIndex = 25;
            btnReset.Text = "Reset data";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(16, 105);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by Id, Name";
            txtSearch.Size = new Size(298, 39);
            txtSearch.TabIndex = 26;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(325, 105);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(109, 44);
            btnSearch.TabIndex = 27;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // nudWeight
            // 
            nudWeight.Location = new Point(237, 220);
            nudWeight.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nudWeight.Name = "nudWeight";
            nudWeight.Size = new Size(234, 39);
            nudWeight.TabIndex = 28;
            // 
            // nudMaxSpeed
            // 
            nudMaxSpeed.Location = new Point(237, 279);
            nudMaxSpeed.Name = "nudMaxSpeed";
            nudMaxSpeed.Size = new Size(234, 39);
            nudMaxSpeed.TabIndex = 29;
            // 
            // nudMaxNoDriver
            // 
            nudMaxNoDriver.Location = new Point(237, 390);
            nudMaxNoDriver.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nudMaxNoDriver.Name = "nudMaxNoDriver";
            nudMaxNoDriver.Size = new Size(234, 39);
            nudMaxNoDriver.TabIndex = 30;
            // 
            // nudPrice
            // 
            nudPrice.Location = new Point(237, 568);
            nudPrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(234, 39);
            nudPrice.TabIndex = 31;
            // 
            // nudShootingRange
            // 
            nudShootingRange.Location = new Point(237, 692);
            nudShootingRange.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nudShootingRange.Name = "nudShootingRange";
            nudShootingRange.Size = new Size(234, 39);
            nudShootingRange.TabIndex = 32;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(btnResetTable);
            panel1.Controls.Add(btnBackToDashboard);
            panel1.Location = new Point(517, 105);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1386, 868);
            panel1.TabIndex = 33;
            // 
            // btnResetTable
            // 
            btnResetTable.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnResetTable.Location = new Point(0, 824);
            btnResetTable.Name = "btnResetTable";
            btnResetTable.Size = new Size(224, 44);
            btnResetTable.TabIndex = 34;
            btnResetTable.Text = "Reset table data";
            btnResetTable.UseVisualStyleBackColor = true;
            btnResetTable.Click += btnResetTable_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 694);
            label1.Name = "label1";
            label1.Size = new Size(220, 32);
            label1.TabIndex = 13;
            label1.Text = "Shooting Range(m)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(810, 9);
            label9.Name = "label9";
            label9.Size = new Size(368, 71);
            label9.TabIndex = 37;
            label9.Text = "Mange Model";
            // 
            // txtAmmoDepricated
            // 
            txtAmmoDepricated.AutoSize = true;
            txtAmmoDepricated.ForeColor = SystemColors.ActiveBorder;
            txtAmmoDepricated.Location = new Point(237, 513);
            txtAmmoDepricated.Name = "txtAmmoDepricated";
            txtAmmoDepricated.Size = new Size(91, 32);
            txtAmmoDepricated.TabIndex = 38;
            txtAmmoDepricated.Text = "label10";
            txtAmmoDepricated.Visible = false;
            // 
            // ModelGrid
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1932, 992);
            Controls.Add(txtAmmoDepricated);
            Controls.Add(label9);
            Controls.Add(btnReset);
            Controls.Add(nudShootingRange);
            Controls.Add(nudPrice);
            Controls.Add(nudMaxNoDriver);
            Controls.Add(nudMaxSpeed);
            Controls.Add(nudWeight);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(cbAmmo);
            Controls.Add(txtName);
            Controls.Add(txtDetail);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblWeight);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(dgvListModels);
            Controls.Add(panel1);
            Name = "ModelGrid";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Model Manager";
            ((System.ComponentModel.ISupportInitialize)dgvListModels).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxNoDriver).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudShootingRange).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvListModels;
        private Button button1;
        private Button btnBackToDashboard;
        private Label lblId;
        private TextBox txtId;
        private Label lblWeight;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtDetail;
        private TextBox txtName;
        private ComboBox cbAmmo;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnReset;
        private TextBox txtSearch;
        private Button btnSearch;
        private NumericUpDown nudWeight;
        private NumericUpDown nudMaxSpeed;
        private NumericUpDown nudMaxNoDriver;
        private NumericUpDown nudPrice;
        private NumericUpDown nudShootingRange;
        private Panel panel1;
        private Label label1;
        private Button btnResetTable;
        private Label label9;
        private Label txtAmmoDepricated;
    }
}
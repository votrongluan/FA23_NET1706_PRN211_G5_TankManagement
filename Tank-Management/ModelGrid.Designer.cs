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
            label8 = new Label();
            txtDetail = new TextBox();
            txtName = new TextBox();
            cbAmmoId = new ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)dgvListModels).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxNoDriver).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudShootingRange).BeginInit();
            SuspendLayout();
            // 
            // dgvListModels
            // 
            dgvListModels.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListModels.Location = new Point(368, 47);
            dgvListModels.Name = "dgvListModels";
            dgvListModels.RowHeadersWidth = 62;
            dgvListModels.RowTemplate.Height = 33;
            dgvListModels.Size = new Size(839, 500);
            dgvListModels.TabIndex = 1;
            dgvListModels.CellDoubleClick += dgvListModels_CellDoubleClick;
            // 
            // btnBackToDashboard
            // 
            btnBackToDashboard.BackColor = Color.FromArgb(255, 255, 192);
            btnBackToDashboard.Location = new Point(988, 567);
            btnBackToDashboard.Name = "btnBackToDashboard";
            btnBackToDashboard.Size = new Size(207, 34);
            btnBackToDashboard.TabIndex = 3;
            btnBackToDashboard.Text = "Back to Dashboard";
            btnBackToDashboard.UseVisualStyleBackColor = false;
            btnBackToDashboard.Click += btnBackToDashboard_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(16, 87);
            lblId.Name = "lblId";
            lblId.Size = new Size(28, 25);
            lblId.TabIndex = 4;
            lblId.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(158, 87);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(176, 31);
            txtId.TabIndex = 5;
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Location = new Point(12, 134);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(68, 25);
            lblWeight.TabIndex = 6;
            lblWeight.Text = "Weight";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 181);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 7;
            label2.Text = "Max Speed";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 222);
            label3.Name = "label3";
            label3.Size = new Size(57, 25);
            label3.TabIndex = 8;
            label3.Text = "Detail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 268);
            label4.Name = "label4";
            label4.Size = new Size(126, 25);
            label4.TabIndex = 9;
            label4.Text = "Max No Driver";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 320);
            label5.Name = "label5";
            label5.Size = new Size(88, 25);
            label5.TabIndex = 10;
            label5.Text = "Ammo Id";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 366);
            label6.Name = "label6";
            label6.Size = new Size(49, 25);
            label6.TabIndex = 11;
            label6.Text = "Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 416);
            label7.Name = "label7";
            label7.Size = new Size(59, 25);
            label7.TabIndex = 12;
            label7.Text = "Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 462);
            label8.Name = "label8";
            label8.Size = new Size(140, 25);
            label8.TabIndex = 13;
            label8.Text = "Shooting Range";
            // 
            // txtDetail
            // 
            txtDetail.Location = new Point(158, 222);
            txtDetail.Name = "txtDetail";
            txtDetail.Size = new Size(180, 31);
            txtDetail.TabIndex = 15;
            // 
            // txtName
            // 
            txtName.Location = new Point(158, 413);
            txtName.Name = "txtName";
            txtName.Size = new Size(180, 31);
            txtName.TabIndex = 19;
            // 
            // cbAmmoId
            // 
            cbAmmoId.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAmmoId.FormattingEnabled = true;
            cbAmmoId.Location = new Point(158, 312);
            cbAmmoId.Name = "cbAmmoId";
            cbAmmoId.Size = new Size(180, 33);
            cbAmmoId.TabIndex = 21;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(12, 506);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(112, 34);
            btnCreate.TabIndex = 22;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(130, 506);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 23;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightCoral;
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(250, 506);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 24;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(419, 567);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(112, 34);
            btnReset.TabIndex = 25;
            btnReset.Text = "Reset data";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 44);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by Id, Name";
            txtSearch.Size = new Size(230, 31);
            txtSearch.TabIndex = 26;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(250, 44);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(84, 34);
            btnSearch.TabIndex = 27;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // nudWeight
            // 
            nudWeight.Location = new Point(158, 134);
            nudWeight.Name = "nudWeight";
            nudWeight.Size = new Size(180, 31);
            nudWeight.TabIndex = 28;
            // 
            // nudMaxSpeed
            // 
            nudMaxSpeed.Location = new Point(158, 179);
            nudMaxSpeed.Name = "nudMaxSpeed";
            nudMaxSpeed.Size = new Size(180, 31);
            nudMaxSpeed.TabIndex = 29;
            // 
            // nudMaxNoDriver
            // 
            nudMaxNoDriver.Location = new Point(158, 266);
            nudMaxNoDriver.Name = "nudMaxNoDriver";
            nudMaxNoDriver.Size = new Size(180, 31);
            nudMaxNoDriver.TabIndex = 30;
            // 
            // nudPrice
            // 
            nudPrice.Location = new Point(158, 364);
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(180, 31);
            nudPrice.TabIndex = 31;
            // 
            // nudShootingRange
            // 
            nudShootingRange.Location = new Point(158, 460);
            nudShootingRange.Name = "nudShootingRange";
            nudShootingRange.Size = new Size(180, 31);
            nudShootingRange.TabIndex = 32;
            // 
            // ModelGrid
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 613);
            Controls.Add(nudShootingRange);
            Controls.Add(nudPrice);
            Controls.Add(nudMaxNoDriver);
            Controls.Add(nudMaxSpeed);
            Controls.Add(nudWeight);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnReset);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(cbAmmoId);
            Controls.Add(txtName);
            Controls.Add(txtDetail);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblWeight);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(btnBackToDashboard);
            Controls.Add(dgvListModels);
            Name = "ModelGrid";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Model Manager";
            ((System.ComponentModel.ISupportInitialize)dgvListModels).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxNoDriver).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudShootingRange).EndInit();
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
        private ComboBox cbAmmoId;
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
    }
}
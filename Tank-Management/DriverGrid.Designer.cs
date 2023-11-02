namespace Tank_Management
{
    partial class DriverGrid
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
            txtId = new TextBox();
            label3 = new Label();
            label2 = new Label();
            dgvDriver = new DataGridView();
            label1 = new Label();
            txtIdCard = new TextBox();
            label5 = new Label();
            txtName = new TextBox();
            label6 = new Label();
            txtPhone = new TextBox();
            label7 = new Label();
            cbxUnit = new ComboBox();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnReset = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvDriver).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnResetTankDgv
            // 
            btnResetTankDgv.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnResetTankDgv.Location = new Point(0, 704);
            btnResetTankDgv.Name = "btnResetTankDgv";
            btnResetTankDgv.Size = new Size(219, 46);
            btnResetTankDgv.TabIndex = 24;
            btnResetTankDgv.Text = "Reset data";
            btnResetTankDgv.UseVisualStyleBackColor = true;
            btnResetTankDgv.Click += btnResetTankDgv_Click;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Location = new Point(993, 32);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(150, 46);
            btnSearch.TabIndex = 23;
            btnSearch.Text = "Find";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(98, 30);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Find by id, model or manufactory";
            txtSearch.Size = new Size(886, 39);
            txtSearch.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 38);
            label4.Name = "label4";
            label4.Size = new Size(85, 32);
            label4.TabIndex = 21;
            label4.Text = "Search";
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBack.BackColor = Color.FromArgb(255, 255, 192);
            btnBack.Location = new Point(1417, 824);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(292, 46);
            btnBack.TabIndex = 20;
            btnBack.Text = "Back to Dashboard";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtId.Enabled = false;
            txtId.Location = new Point(1347, 242);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(362, 39);
            txtId.TabIndex = 17;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(1228, 306);
            label3.Name = "label3";
            label3.Size = new Size(86, 32);
            label3.TabIndex = 16;
            label3.Text = "Id card";
            // 
            // label2
            // 
            label2.AllowDrop = true;
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(1228, 243);
            label2.Name = "label2";
            label2.Size = new Size(34, 32);
            label2.TabIndex = 15;
            label2.Text = "Id";
            // 
            // dgvDriver
            // 
            dgvDriver.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDriver.BackgroundColor = Color.White;
            dgvDriver.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDriver.Location = new Point(0, 80);
            dgvDriver.Name = "dgvDriver";
            dgvDriver.ReadOnly = true;
            dgvDriver.RowHeadersWidth = 82;
            dgvDriver.RowTemplate.Height = 41;
            dgvDriver.Size = new Size(1146, 578);
            dgvDriver.TabIndex = 14;
            dgvDriver.CellDoubleClick += dgvDriver_CellDoubleClick;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(764, 19);
            label1.Name = "label1";
            label1.Size = new Size(360, 71);
            label1.TabIndex = 13;
            label1.Text = "Mange Driver";
            // 
            // txtIdCard
            // 
            txtIdCard.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtIdCard.Location = new Point(1347, 306);
            txtIdCard.Name = "txtIdCard";
            txtIdCard.Size = new Size(362, 39);
            txtIdCard.TabIndex = 25;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(1228, 368);
            label5.Name = "label5";
            label5.Size = new Size(78, 32);
            label5.TabIndex = 26;
            label5.Text = "Name";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtName.Location = new Point(1347, 368);
            txtName.Name = "txtName";
            txtName.Size = new Size(362, 39);
            txtName.TabIndex = 27;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(1228, 434);
            label6.Name = "label6";
            label6.Size = new Size(82, 32);
            label6.TabIndex = 28;
            label6.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPhone.Location = new Point(1347, 426);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(362, 39);
            txtPhone.TabIndex = 29;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(1224, 499);
            label7.Name = "label7";
            label7.Size = new Size(58, 32);
            label7.TabIndex = 30;
            label7.Text = "Unit";
            // 
            // cbxUnit
            // 
            cbxUnit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbxUnit.FormattingEnabled = true;
            cbxUnit.Location = new Point(1347, 499);
            cbxUnit.Name = "cbxUnit";
            cbxUnit.Size = new Size(362, 40);
            cbxUnit.TabIndex = 31;
            // 
            // btnCreate
            // 
            btnCreate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCreate.Location = new Point(1558, 579);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(150, 46);
            btnCreate.TabIndex = 32;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(1228, 579);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(150, 46);
            btnUpdate.TabIndex = 33;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(1228, 670);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 46);
            btnDelete.TabIndex = 34;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReset.Location = new Point(1558, 670);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(150, 46);
            btnReset.TabIndex = 35;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnResetTankDgv);
            panel1.Controls.Add(dgvDriver);
            panel1.Location = new Point(36, 120);
            panel1.Margin = new Padding(5, 5, 5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1146, 749);
            panel1.TabIndex = 36;
            // 
            // DriverGrid
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1753, 909);
            Controls.Add(btnReset);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(cbxUnit);
            Controls.Add(label7);
            Controls.Add(txtPhone);
            Controls.Add(label6);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(txtIdCard);
            Controls.Add(btnBack);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "DriverGrid";
            Text = "DriverGrid";
            ((System.ComponentModel.ISupportInitialize)dgvDriver).EndInit();
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
        private TextBox txtId;
        private Label label3;
        private Label label2;
        private DataGridView dgvDriver;
        private Label label1;
        private TextBox txtIdCard;
        private Label label5;
        private TextBox txtName;
        private Label label6;
        private TextBox txtPhone;
        private Label label7;
        private ComboBox cbxUnit;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnReset;
        private Panel panel1;
    }
}
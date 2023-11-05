namespace Tank_Management
{
    partial class TankGrid
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
            btnSearch = new Button();
            txtSearch = new TextBox();
            label4 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            dgvTank = new DataGridView();
            label1 = new Label();
            Mode = new Label();
            cbModel = new ComboBox();
            label3 = new Label();
            cbManufactory = new ComboBox();
            label5 = new Label();
            cbUnit = new ComboBox();
            btnBack = new Button();
            btnResetTankDgv = new Button();
            txtModelDepricated = new Label();
            txtManufactoryDepricatedName = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTank).BeginInit();
            SuspendLayout();
            // 
            // btnReset
            // 
            btnReset.Location = new Point(1442, 680);
            btnReset.Margin = new Padding(3, 2, 3, 2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(151, 46);
            btnReset.TabIndex = 54;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(1076, 680);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(151, 46);
            btnDelete.TabIndex = 53;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(1448, 584);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(151, 46);
            btnUpdate.TabIndex = 52;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(1076, 584);
            btnCreate.Margin = new Padding(3, 2, 3, 2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(151, 46);
            btnCreate.TabIndex = 51;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1536, 133);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(151, 46);
            btnSearch.TabIndex = 43;
            btnSearch.Text = "Find";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click_1;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(191, 134);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Find by id, model or manufactory";
            txtSearch.Size = new Size(1327, 39);
            txtSearch.TabIndex = 42;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 137);
            label4.Name = "label4";
            label4.Size = new Size(85, 32);
            label4.TabIndex = 41;
            label4.Text = "Search";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(1308, 250);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(285, 39);
            txtId.TabIndex = 40;
            // 
            // label2
            // 
            label2.AllowDrop = true;
            label2.AutoSize = true;
            label2.Location = new Point(1076, 251);
            label2.Name = "label2";
            label2.Size = new Size(34, 32);
            label2.TabIndex = 38;
            label2.Text = "Id";
            // 
            // dgvTank
            // 
            dgvTank.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTank.BackgroundColor = Color.White;
            dgvTank.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTank.Location = new Point(63, 222);
            dgvTank.Margin = new Padding(3, 2, 3, 2);
            dgvTank.Name = "dgvTank";
            dgvTank.ReadOnly = true;
            dgvTank.RowHeadersWidth = 82;
            dgvTank.RowTemplate.Height = 41;
            dgvTank.Size = new Size(972, 578);
            dgvTank.TabIndex = 37;
            dgvTank.CellDoubleClick += dgvTank_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(647, 27);
            label1.Name = "label1";
            label1.Size = new Size(324, 71);
            label1.TabIndex = 36;
            label1.Text = "Mange Tank";
            // 
            // Mode
            // 
            Mode.AutoSize = true;
            Mode.Location = new Point(1076, 317);
            Mode.Margin = new Padding(5, 0, 5, 0);
            Mode.Name = "Mode";
            Mode.Size = new Size(154, 32);
            Mode.TabIndex = 55;
            Mode.Text = "Model Name";
            // 
            // cbModel
            // 
            cbModel.FormattingEnabled = true;
            cbModel.Location = new Point(1308, 314);
            cbModel.Margin = new Padding(5, 6, 5, 6);
            cbModel.Name = "cbModel";
            cbModel.Size = new Size(280, 40);
            cbModel.TabIndex = 56;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1076, 421);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(220, 32);
            label3.TabIndex = 57;
            label3.Text = "Manufactory Name";
            // 
            // cbManufactory
            // 
            cbManufactory.FormattingEnabled = true;
            cbManufactory.Location = new Point(1308, 418);
            cbManufactory.Margin = new Padding(5, 6, 5, 6);
            cbManufactory.Name = "cbManufactory";
            cbManufactory.Size = new Size(280, 40);
            cbManufactory.TabIndex = 58;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1076, 516);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(58, 32);
            label5.TabIndex = 59;
            label5.Text = "Unit";
            // 
            // cbUnit
            // 
            cbUnit.FormattingEnabled = true;
            cbUnit.Location = new Point(1308, 513);
            cbUnit.Margin = new Padding(5, 6, 5, 6);
            cbUnit.Name = "cbUnit";
            cbUnit.Size = new Size(280, 40);
            cbUnit.TabIndex = 60;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(255, 255, 192);
            btnBack.Location = new Point(1308, 853);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(291, 46);
            btnBack.TabIndex = 61;
            btnBack.Text = "Back to Dashboard";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnResetTankDgv
            // 
            btnResetTankDgv.Location = new Point(63, 853);
            btnResetTankDgv.Margin = new Padding(3, 2, 3, 2);
            btnResetTankDgv.Name = "btnResetTankDgv";
            btnResetTankDgv.Size = new Size(219, 46);
            btnResetTankDgv.TabIndex = 62;
            btnResetTankDgv.Text = "Reset tank data";
            btnResetTankDgv.UseVisualStyleBackColor = true;
            btnResetTankDgv.Click += btnResetTankDgv_Click;
            // 
            // txtModelDepricated
            // 
            txtModelDepricated.AutoSize = true;
            txtModelDepricated.ForeColor = SystemColors.ActiveBorder;
            txtModelDepricated.Location = new Point(1308, 360);
            txtModelDepricated.Margin = new Padding(5, 0, 5, 0);
            txtModelDepricated.Name = "txtModelDepricated";
            txtModelDepricated.Size = new Size(154, 32);
            txtModelDepricated.TabIndex = 63;
            txtModelDepricated.Text = "Model Name";
            txtModelDepricated.Visible = false;
            // 
            // txtManufactoryDepricatedName
            // 
            txtManufactoryDepricatedName.AutoSize = true;
            txtManufactoryDepricatedName.ForeColor = SystemColors.ActiveBorder;
            txtManufactoryDepricatedName.Location = new Point(1308, 464);
            txtManufactoryDepricatedName.Margin = new Padding(5, 0, 5, 0);
            txtManufactoryDepricatedName.Name = "txtManufactoryDepricatedName";
            txtManufactoryDepricatedName.Size = new Size(154, 32);
            txtManufactoryDepricatedName.TabIndex = 64;
            txtManufactoryDepricatedName.Text = "Model Name";
            txtManufactoryDepricatedName.Visible = false;
            // 
            // TankGrid
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1698, 955);
            Controls.Add(txtManufactoryDepricatedName);
            Controls.Add(txtModelDepricated);
            Controls.Add(btnResetTankDgv);
            Controls.Add(btnBack);
            Controls.Add(cbUnit);
            Controls.Add(label5);
            Controls.Add(cbManufactory);
            Controls.Add(label3);
            Controls.Add(cbModel);
            Controls.Add(Mode);
            Controls.Add(btnReset);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label4);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(dgvTank);
            Controls.Add(label1);
            Margin = new Padding(5, 6, 5, 6);
            Name = "TankGrid";
            Text = "TankGrid";
            ((System.ComponentModel.ISupportInitialize)dgvTank).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReset;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnCreate;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label4;
        private TextBox txtId;
        private Label label2;
        private DataGridView dgvTank;
        private Label label1;
        private Label Mode;
        private ComboBox cbModel;
        private Label label3;
        private ComboBox cbManufactory;
        private Label label5;
        private ComboBox cbUnit;
        private Button btnBack;
        private Button btnResetTankDgv;
        private Label txtModelDepricated;
        private Label txtManufactoryDepricatedName;
    }
}
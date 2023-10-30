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
            ((System.ComponentModel.ISupportInitialize)dgvTank).BeginInit();
            SuspendLayout();
            // 
            // btnReset
            // 
            btnReset.Location = new Point(776, 319);
            btnReset.Margin = new Padding(2, 1, 2, 1);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(81, 22);
            btnReset.TabIndex = 54;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(598, 319);
            btnDelete.Margin = new Padding(2, 1, 2, 1);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(81, 22);
            btnDelete.TabIndex = 53;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(776, 274);
            btnUpdate.Margin = new Padding(2, 1, 2, 1);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(81, 22);
            btnUpdate.TabIndex = 52;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(598, 274);
            btnCreate.Margin = new Padding(2, 1, 2, 1);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(81, 22);
            btnCreate.TabIndex = 51;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(827, 62);
            btnSearch.Margin = new Padding(2, 1, 2, 1);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(81, 22);
            btnSearch.TabIndex = 43;
            btnSearch.Text = "Find";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(72, 63);
            txtSearch.Margin = new Padding(2, 1, 2, 1);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Find by id, model or manufactory";
            txtSearch.Size = new Size(748, 23);
            txtSearch.TabIndex = 42;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 64);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 41;
            label4.Text = "Search";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(704, 117);
            txtId.Margin = new Padding(2, 1, 2, 1);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(155, 23);
            txtId.TabIndex = 40;
            // 
            // label2
            // 
            label2.AllowDrop = true;
            label2.AutoSize = true;
            label2.Location = new Point(588, 118);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 38;
            label2.Text = "Id";
            // 
            // dgvTank
            // 
            dgvTank.BackgroundColor = Color.White;
            dgvTank.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTank.Location = new Point(34, 104);
            dgvTank.Margin = new Padding(2, 1, 2, 1);
            dgvTank.Name = "dgvTank";
            dgvTank.ReadOnly = true;
            dgvTank.RowHeadersWidth = 82;
            dgvTank.RowTemplate.Height = 41;
            dgvTank.Size = new Size(523, 271);
            dgvTank.TabIndex = 37;
            dgvTank.CellDoubleClick += dgvTank_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(348, 13);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(165, 37);
            label1.TabIndex = 36;
            label1.Text = "Mange Tank";
            // 
            // Mode
            // 
            Mode.AutoSize = true;
            Mode.Location = new Point(588, 166);
            Mode.Name = "Mode";
            Mode.Size = new Size(73, 15);
            Mode.TabIndex = 55;
            Mode.Text = "ModelName";
            // 
            // cbModel
            // 
            cbModel.FormattingEnabled = true;
            cbModel.Location = new Point(704, 158);
            cbModel.Name = "cbModel";
            cbModel.Size = new Size(153, 23);
            cbModel.TabIndex = 56;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(588, 201);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 57;
            label3.Text = "ManufactoryName";
            // 
            // cbManufactory
            // 
            cbManufactory.FormattingEnabled = true;
            cbManufactory.Location = new Point(704, 193);
            cbManufactory.Name = "cbManufactory";
            cbManufactory.Size = new Size(153, 23);
            cbManufactory.TabIndex = 58;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(588, 237);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 59;
            label5.Text = "Unit";
            // 
            // cbUnit
            // 
            cbUnit.FormattingEnabled = true;
            cbUnit.Location = new Point(704, 229);
            cbUnit.Name = "cbUnit";
            cbUnit.Size = new Size(153, 23);
            cbUnit.TabIndex = 60;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(255, 255, 192);
            btnBack.Location = new Point(704, 400);
            btnBack.Margin = new Padding(2, 1, 2, 1);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(157, 22);
            btnBack.TabIndex = 61;
            btnBack.Text = "Back to Dashboard";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnResetTankDgv
            // 
            btnResetTankDgv.Location = new Point(34, 400);
            btnResetTankDgv.Margin = new Padding(2, 1, 2, 1);
            btnResetTankDgv.Name = "btnResetTankDgv";
            btnResetTankDgv.Size = new Size(118, 22);
            btnResetTankDgv.TabIndex = 62;
            btnResetTankDgv.Text = "Reset tank data";
            btnResetTankDgv.UseVisualStyleBackColor = true;
            btnResetTankDgv.Click += btnResetTankDgv_Click;
            // 
            // TankGrid
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 448);
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
    }
}
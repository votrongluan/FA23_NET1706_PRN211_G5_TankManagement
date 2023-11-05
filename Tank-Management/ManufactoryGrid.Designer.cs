namespace Tank_Management
{
    partial class ManufactoryGrid
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
            manufactorydgv = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            idtxt = new TextBox();
            nametxt = new TextBox();
            btnUpdate = new Button();
            btnCreate = new Button();
            btnDelete = new Button();
            btnReset = new Button();
            btnResetDgv = new Button();
            searchtxt = new TextBox();
            btnSearch = new Button();
            label5 = new Label();
            locationcbx = new ComboBox();
            btnBack = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)manufactorydgv).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(1063, 211);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(34, 32);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // manufactorydgv
            // 
            manufactorydgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            manufactorydgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            manufactorydgv.BackgroundColor = Color.White;
            manufactorydgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            manufactorydgv.Location = new Point(23, 210);
            manufactorydgv.Margin = new Padding(5, 6, 5, 6);
            manufactorydgv.Name = "manufactorydgv";
            manufactorydgv.RowHeadersWidth = 51;
            manufactorydgv.RowTemplate.Height = 25;
            manufactorydgv.Size = new Size(999, 667);
            manufactorydgv.TabIndex = 1;
            manufactorydgv.CellDoubleClick += manufactorydgv_CellDoubleClick;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(372, 19);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(823, 89);
            label2.TabIndex = 2;
            label2.Text = "Manufactory Management";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(1063, 277);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(78, 32);
            label3.TabIndex = 3;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(1063, 344);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(104, 32);
            label4.TabIndex = 4;
            label4.Text = "Location";
            // 
            // idtxt
            // 
            idtxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            idtxt.Location = new Point(1209, 205);
            idtxt.Margin = new Padding(5, 6, 5, 6);
            idtxt.Name = "idtxt";
            idtxt.ReadOnly = true;
            idtxt.Size = new Size(183, 39);
            idtxt.TabIndex = 5;
            // 
            // nametxt
            // 
            nametxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nametxt.Location = new Point(1209, 270);
            nametxt.Margin = new Padding(5, 6, 5, 6);
            nametxt.Name = "nametxt";
            nametxt.Size = new Size(183, 39);
            nametxt.TabIndex = 6;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdate.Location = new Point(1063, 469);
            btnUpdate.Margin = new Padding(5, 6, 5, 6);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(140, 50);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCreate
            // 
            btnCreate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCreate.Location = new Point(1256, 469);
            btnCreate.Margin = new Padding(5, 6, 5, 6);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(140, 50);
            btnCreate.TabIndex = 9;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Location = new Point(1063, 558);
            btnDelete.Margin = new Padding(5, 6, 5, 6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 50);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReset.Location = new Point(1256, 558);
            btnReset.Margin = new Padding(5, 6, 5, 6);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(140, 50);
            btnReset.TabIndex = 11;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnResetDgv
            // 
            btnResetDgv.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnResetDgv.Location = new Point(0, 774);
            btnResetDgv.Margin = new Padding(5, 6, 5, 6);
            btnResetDgv.Name = "btnResetDgv";
            btnResetDgv.Size = new Size(210, 50);
            btnResetDgv.TabIndex = 12;
            btnResetDgv.Text = "Reset Data View";
            btnResetDgv.UseVisualStyleBackColor = true;
            btnResetDgv.Click += btnResetDgv_Click;
            // 
            // searchtxt
            // 
            searchtxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            searchtxt.Location = new Point(101, 21);
            searchtxt.Margin = new Padding(5, 6, 5, 6);
            searchtxt.Name = "searchtxt";
            searchtxt.PlaceholderText = "Find by id or model";
            searchtxt.Size = new Size(748, 39);
            searchtxt.TabIndex = 13;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Location = new Point(861, 21);
            btnSearch.Margin = new Padding(5, 6, 5, 6);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(138, 50);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 26);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(85, 32);
            label5.TabIndex = 15;
            label5.Text = "Search";
            // 
            // locationcbx
            // 
            locationcbx.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            locationcbx.FormattingEnabled = true;
            locationcbx.Location = new Point(1209, 338);
            locationcbx.Margin = new Padding(5, 6, 5, 6);
            locationcbx.Name = "locationcbx";
            locationcbx.Size = new Size(183, 40);
            locationcbx.TabIndex = 16;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBack.BackColor = Color.FromArgb(255, 255, 192);
            btnBack.Location = new Point(1157, 883);
            btnBack.Margin = new Padding(5, 6, 5, 6);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(239, 56);
            btnBack.TabIndex = 17;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(btnResetDgv);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(searchtxt);
            panel1.Location = new Point(23, 115);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1004, 824);
            panel1.TabIndex = 18;
            // 
            // ManufactoryGrid
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1485, 960);
            Controls.Add(btnBack);
            Controls.Add(locationcbx);
            Controls.Add(btnReset);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Controls.Add(btnUpdate);
            Controls.Add(nametxt);
            Controls.Add(idtxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(manufactorydgv);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(5, 6, 5, 6);
            Name = "ManufactoryGrid";
            Text = "ManufactoryGrid";
            ((System.ComponentModel.ISupportInitialize)manufactorydgv).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView manufactorydgv;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox idtxt;
        private TextBox nametxt;
        private Button btnUpdate;
        private Button btnCreate;
        private Button btnDelete;
        private Button btnReset;
        private Button btnResetDgv;
        private TextBox searchtxt;
        private Button btnSearch;
        private Label label5;
        private ComboBox locationcbx;
        private Button btnBack;
        private Panel panel1;
    }
}
namespace Tank_Management {
    partial class HistoryGrid {
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
            lbHistory = new Label();
            button1 = new Button();
            dgvHistory = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            SuspendLayout();
            // 
            // lbHistory
            // 
            lbHistory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbHistory.BackColor = Color.Transparent;
            lbHistory.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lbHistory.Location = new Point(318, 43);
            lbHistory.Name = "lbHistory";
            lbHistory.Size = new Size(272, 46);
            lbHistory.TabIndex = 1;
            lbHistory.Text = "History Table";
            lbHistory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(350, 440);
            button1.Name = "button1";
            button1.Size = new Size(197, 64);
            button1.TabIndex = 2;
            button1.Text = "Back to dashboard";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgvHistory
            // 
            dgvHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.Location = new Point(118, 128);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.RowHeadersWidth = 51;
            dgvHistory.RowTemplate.Height = 29;
            dgvHistory.Size = new Size(678, 274);
            dgvHistory.TabIndex = 0;
            // 
            // HistoryGrid
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 538);
            Controls.Add(button1);
            Controls.Add(lbHistory);
            Controls.Add(dgvHistory);
            Name = "HistoryGrid";
            Text = "HistoryGrid";
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button button1;
        private DataGridView dgvHistory;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn FromUnit;
        private DataGridViewTextBoxColumn ToUnit;
        private DataGridViewTextBoxColumn TankID;
        private DataGridViewTextBoxColumn Date;
        private Label lbHistory;
    }
}
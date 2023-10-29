using Data.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tank_Management {
    public partial class HistoryGrid : Form {
        public TankRepository tankRepository = new TankRepository();
        public UnitRepository unitRepository = new UnitRepository();
        public LocationRepository locationRepository = new LocationRepository();
        public HistoryRepository historyRepository = new HistoryRepository();

        private int unitId = 0;

        public void updateGridView() {
            var histories = historyRepository.GetAll().
                Include(p => p.FromUnit).
                Include(p => p.ToUnit).
                Include(p => p.Tank).
                ToList();

            if (histories != null) {
                var listHistory = histories.ToList();

                dgvHistory.DataSource = histories.Select(p => new {
                    Id = p.Id,
                    FromUnit = p.FromUnit.Name,
                    ToUnit = p.ToUnit.Name,
                    TankId = p.TankId,
                    Date = p.Date,
                }).ToList();
            }
        }

        public HistoryGrid() {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            lbHistory.Text = "History Table".ToUpper();
            lbHistory.Size = new Size(this.ClientSize.Width, 50);
            lbHistory.BackColor = Color.Transparent;
            updateGridView();
        }

        private void button1_Click(object sender, EventArgs e) {
            UserDashboard userDashboard = new UserDashboard();
            userDashboard.Show();
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tank_Management {
    public partial class UserDashboard : Form {
        public UserDashboard() {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnManageDriver_Click(object sender, EventArgs e) {
            var manageDriver = new DriverTank();
            manageDriver.Show();
            this.Hide();
        }

        private void btnViewTankHistory_Click(object sender, EventArgs e) {
            var historyGrid = new HistoryGrid();
            historyGrid.Show();
            this.Hide();
        }

        private void btnChangeUnit_Click(object sender, EventArgs e) {
            var changeUnit = new ChangeUnit();
            changeUnit.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e) {
            Program.user = null;
            var login = new Login();
            login.Show();
            this.Hide();
        }
    }
}

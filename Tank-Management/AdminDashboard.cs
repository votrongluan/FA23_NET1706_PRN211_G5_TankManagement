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
    public partial class AdminDashboard : Form {
        public AdminDashboard() {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnLogout_Click(object sender, EventArgs e) {
            Program.user = null;
            var login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnManageModel_Click(object sender, EventArgs e) {
            var manageModel = new ModelGrid();
            manageModel.Show();
            this.Hide();
        }

        private void btnManageAmmo_Click(object sender, EventArgs e) {
            var manageAmmo = new AmmoGrid();
            manageAmmo.Show();
            this.Hide();
        }

        private void btnManageManufactory_Click(object sender, EventArgs e) {
            var manageManufactory = new ManufactoryGrid();
            manageManufactory.Show();
            this.Hide();
        }

        private void btnManageTank_Click(object sender, EventArgs e) {
            var manageTank = new TankGrid();
            manageTank.Show();
            this.Hide();
        }

        private void btnViewHistory_Click(object sender, EventArgs e) {
            var historyGrid = new HistoryGrid();
            historyGrid.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e) {
            var manageDriver = new DriverGrid();
            manageDriver.Show();
            this.Hide();
        }
    }
}

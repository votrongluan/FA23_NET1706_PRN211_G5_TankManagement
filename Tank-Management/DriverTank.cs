using Data.Models;
using Data.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Tank_Management.ChangeUnit;

namespace Tank_Management {
    public partial class DriverTank : Form {
        private TankRepository tankRepository = new TankRepository();
        private TankDriverRepository tankDriverRepository = new TankDriverRepository();
        private DriverRepository driverRepository = new DriverRepository();
        private UnitRepository unitRepository = new UnitRepository();
        private UnitManagerRepository unitManagerRepository = new UnitManagerRepository();
        private HistoryRepository historyRepository = new HistoryRepository();
        internal record TData(string Driver_Name, string Id_Card, int Tank_Id, string Model);
        private Unit currentUnit = null;

        private void setCurrentUnit() {
            var unit = unitManagerRepository.GetAll()
                 .Where(um => um.UserId == Program.user.Id)
                 .Select(um => um.Unit)
                 .FirstOrDefault();

            currentUnit = unit;
        }

        private void LoadTankIdCbx() {
            var tanks = tankRepository.GetAll()
                .Where(t => t.UnitId == currentUnit.Id)
                .Select(t => new {
                    Id = t.Id,
                    Model = t.Model.Name,
                    Display = t.Model.Name + " - " + t.Id
                })
                .ToList();

            cbxTankId.DataSource = tanks;
            cbxTankId.DisplayMember = "Display";
            cbxTankId.ValueMember = "Id";
        }

        private void LoadTank(string search = "") {
            var driverWithoutTank = driverRepository.GetAll()
                .Where(d => d.UnitId == currentUnit.Id)
                .Select(d => new TData(
                    d.Name,
                    d.IdCard,
                    d.TankDrivers.FirstOrDefault().TankId ?? 0,
                    d.TankDrivers.FirstOrDefault().Tank.Model.Name
                 ))
                .ToList();

            var driverWithTank = tankDriverRepository
                .GetAll()
                .Include(td => td.Tank)
                .Include(td => td.Driver)
                .Where(td => td.Tank.UnitId == currentUnit.Id)
                .Select(td => new TData(
                    td.Driver.Name,
                    td.Driver.IdCard,
                    td.Tank.Id,
                    td.Tank.Model.Name
                ))
                .ToList();


            var tanks = driverWithoutTank.Concat(driverWithTank).ToList();

            if (search != "") {
                tanks = tanks.Where(t =>
                    (t.Driver_Name != null && t.Driver_Name.Contains(search)) ||
                    (t.Id_Card != null && t.Id_Card.Contains(search)) ||
                    (t.Model != null && t.Model.Contains(search)) ||
                    (t.Tank_Id != null && t.Tank_Id.ToString().Contains(search))
                ).ToList();
            }

            dgvTank.DataSource = tanks;

            if (dgvTank.Rows.Count > 0) {
                txtDriverIdCard.Text = dgvTank.Rows[0].Cells[0].Value.ToString();
            }
        }

        public DriverTank() {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            setCurrentUnit();
            LoadTank();
            LoadTankIdCbx();
        }

        private void btnResetTankDgv_Click(object sender, EventArgs e) {
            LoadTank();
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            // Get the search keyword
            string keyword = txtSearch.Text;
            LoadTank(keyword);
        }

        private void btnBack_Click(object sender, EventArgs e) {
            var userDashboard = new UserDashboard();
            userDashboard.Show();
            this.Hide();
        }

        private void dgvTank_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            // Display the tank id in the txtTankId
            txtDriverIdCard.Text = dgvTank.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnChange_Click(object sender, EventArgs e) {
            // Get the tank id_Card and tank id
            string idCard = txtDriverIdCard.Text;

            // Find the driver
            var driver = driverRepository.GetAll()
                .Where(d => d.IdCard == idCard)
                .FirstOrDefault();
            int tankId = int.Parse(txtDriverIdCard.Text);

            if (driver != null) {
                // add the TankDriver table with the new tank id, driver id
                var tankDriver = new TankDriver() {
                    TankId = tankId,
                    DriverId = driver.Id
                };

                tankDriverRepository.Add(tankDriver);
            } else {
                // Show error message with icon
                MessageBox.Show("Error has occured", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

using Data.Models;
using Data.Repository;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tank_Management
{
    public partial class ChangeUnit : Form
    {
        private TankRepository tankRepository = new TankRepository();
        private UnitRepository unitRepository = new UnitRepository();
        private UnitManagerRepository unitManagerRepository = new UnitManagerRepository();
        private HistoryRepository historyRepository = new HistoryRepository();
        internal record TankData(int Id, string Model, string Manufactory);
        private Unit currentUnit = null;

        private void setCurrentUnit()
        {
            var unit = unitManagerRepository.GetAll()
                 .Where(um => um.UserId == Program.user.Id)
                 .Select(um => um.Unit)
                 .FirstOrDefault();

            currentUnit = unit;
        }

        private void LoadTank(string search = "")
        {
            var tanks = tankRepository.GetAll()
                .Where(t => t.UnitId == currentUnit.Id)
                .Select(t => new TankData(
                    t.Id,
                    t.Model.Name,
                    t.Manufactory.Name
                ))
                .ToList();

            if (!string.IsNullOrEmpty(search))
            {
                tanks = tanks
                    .Where(t => t.Model.Contains(search, StringComparison.OrdinalIgnoreCase) || t.Manufactory.Contains(search, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            dgvTank.DataSource = tanks;

            if (dgvTank.Rows.Count > 0)
            {
                txtTankId.Text = dgvTank.Rows[0].Cells[0].Value.ToString();
            }
        }

        private void LoadUnit()
        {
            cbxUnitId.DataSource = unitRepository.GetAll()
                .Where(u => u.Id != Program.user.Id)
                .Select(u => new { u.Id, u.Name })
                .ToList();
            cbxUnitId.ValueMember = "Id";
            cbxUnitId.DisplayMember = "Name";
            cbxUnitId.SelectedIndex = 0;
        }

        public ChangeUnit()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            setCurrentUnit();
            LoadTank();
            LoadUnit();
        }



        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                int tankId = int.Parse(txtTankId.Text);
                int unitId = int.Parse(cbxUnitId.SelectedValue.ToString());

                // Create a history object
                var history = new History()
                {
                    TankId = tankId,
                    FromUnitId = currentUnit.Id,
                    ToUnitId = unitId,
                    Date = DateTime.Now.Date
                };

                // Load the tank with the tank id
                var tank = tankRepository.GetAll()
                    .Where(t => t.Id == tankId)
                    .FirstOrDefault();

                tank.UnitId = unitId;
                tankRepository.Update(tank);
                historyRepository.Add(history);

                // Show the success message
                MessageBox.Show("Change unit successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadTank();
            }
            catch (Exception)
            {
                MessageBox.Show("Tank id or unit id is invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void dgvTank_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Display the tank id in the txtTankId
            txtTankId.Text = dgvTank.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var userDashboard = new UserDashboard();
            userDashboard.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Get the search keyword
            string keyword = txtSearch.Text;
            LoadTank(keyword);
        }

        private void btnResetTankDgv_Click(object sender, EventArgs e)
        {
            LoadTank();
        }
    }
}

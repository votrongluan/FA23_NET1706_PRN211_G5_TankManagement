using Data.Models;
using Data.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static Azure.Core.HttpHeader;
using static Tank_Management.DriverGrid;

namespace Tank_Management
{
    public partial class TankGrid : Form
    {
        private UnitRepository unitRepository = new UnitRepository();
        private ModelRepository modelRepository = new ModelRepository();
        private ManufactoryRepository manufactoryRepository = new ManufactoryRepository();
        private TankRepository tankRepository = new TankRepository();
        internal record DriverData(int Id, string Model, string Manufactory, string Unit);
        private void LoadUnit()
        {
            cbUnit.DataSource = unitRepository.GetAll()
                .Select(u => new { u.Id, u.Name })
                .ToList();
            cbUnit.ValueMember = "Id";
            cbUnit.DisplayMember = "Name";
            cbUnit.SelectedIndex = 0;
        }

        private void LoadModel()
        {
            cbModel.DataSource = modelRepository.GetAll()
                .Select(u => new { u.Id, u.Name })
                .ToList();
            cbModel.ValueMember = "Id";
            cbModel.DisplayMember = "Name";
            cbModel.SelectedIndex = 0;
        }

        private void LoadManufactory()
        {
            cbManufactory.DataSource = manufactoryRepository.GetAll()
                .Select(u => new { u.Id, u.Name })
                .ToList();
            cbManufactory.ValueMember = "Id";
            cbManufactory.DisplayMember = "Name";
            cbManufactory.SelectedIndex = 0;
        }

        private void LoadDriver(string search = "")
        {
            var drivers = tankRepository.GetAll()
                .Select(t => new DriverData(
                    t.Id,
                    t.Model.Name,
                    t.Manufactory.Name,
                    t.Unit.Name
                ))
                .ToList();

            if (!string.IsNullOrEmpty(search))
            {
                drivers = drivers
                    .Where(t => t.Model.Contains(search, StringComparison.OrdinalIgnoreCase) || t.Manufactory.Contains(search, StringComparison.OrdinalIgnoreCase) || t.Unit.Contains(search, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            dgvTank.DataSource = drivers;
        }

        public TankGrid()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            LoadDriver();
            LoadModel();
            LoadManufactory();
            LoadUnit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Hide();
        }

        private void disableCreate()
        {
            btnCreate.Enabled = false;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void enableCreate()
        {
            btnCreate.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void clearTextBox()
        {
            txtId.Text = "";
            cbModel.SelectedIndex = 0;
            cbManufactory.SelectedIndex = 0;
            cbUnit.SelectedIndex = 0;
        }

        private void dgvTank_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Display the selected row's data in TextBoxes
            txtId.Text = dgvTank.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbModel.Text = dgvTank.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbManufactory.Text = dgvTank.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbUnit.Text = dgvTank.Rows[e.RowIndex].Cells[3].Value.ToString();

            // Disable create button and enable delete and update button
            disableCreate();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Load data from TextBoxes
            var modelId = int.Parse(cbModel.SelectedIndex.ToString());
            var manufactoryId = int.Parse(cbManufactory.SelectedIndex.ToString());
            var unitId = int.Parse(cbUnit.SelectedValue.ToString());

            // Create new driver
            var tank = new Tank()
            {
                ModelId = modelId,
                ManufactoryId = manufactoryId,
                UnitId = unitId,
            };

            // Add new driver to database
            tankRepository.Add(tank);

            // Reload data
            LoadDriver();
            clearTextBox();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Load the id from TextBox
            var id = int.Parse(txtId.Text);

            // Get the driver by id
            var tank = tankRepository.GetAll().Where(d => d.Id == id).FirstOrDefault();

            // Delete the driver
            try
            {
                tankRepository.Delete(tank);

                // Reload data
                LoadDriver();
                clearTextBox();
                enableCreate();
            }
            catch (Exception)
            {
                // Show the error message
                MessageBox.Show("Can not delete this driver!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearTextBox();
            enableCreate();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Load data from TextBoxes
            var id = int.Parse(txtId.Text);
            var modelId = int.Parse(cbModel.SelectedIndex.ToString());
            var manufactoryId = int.Parse(cbManufactory.SelectedIndex.ToString());
            var unitId = int.Parse(cbUnit.SelectedValue.ToString());

            // Get the driver by id
            var driver = tankRepository.GetAll().Where(d => d.Id == id).FirstOrDefault();
            if (driver != null)
            {
                // Update the driver
                driver.ModelId = modelId;
                driver.ManufactoryId = manufactoryId;
                driver.UnitId = unitId;

                // Update the driver
                tankRepository.Update(driver);

                // Reload data
                LoadDriver();
                clearTextBox();
                enableCreate();
            }
        }

        private void btnResetTankDgv_Click(object sender, EventArgs e)
        {
            LoadDriver();
            clearTextBox();
            enableCreate();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            var search = txtSearch.Text;
            LoadDriver(search);
        }
    }
}

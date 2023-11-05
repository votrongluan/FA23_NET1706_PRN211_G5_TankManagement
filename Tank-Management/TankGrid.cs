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

        private bool checkAllInput()
        {
            if (cbModel.Text == "" || cbManufactory.Text == "" || cbUnit.Text == "")
            {
                // show error message
                MessageBox.Show("Please fill all the fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
        private void LoadUnit()
        {
            cbUnit.DataSource = unitRepository.GetAll()
                .Where(u => u.IsDelete == false || u.IsDelete == null)
                .Select(u => new { u.Id, u.Name })
                .ToList();
            cbUnit.ValueMember = "Id";
            cbUnit.DisplayMember = "Name";
            cbUnit.SelectedIndex = 0;
        }

        private void LoadModel()
        {
            cbModel.DataSource = modelRepository.GetAll()
                .Where(u => u.IsDelete == false || u.IsDelete == null)
                .Select(u => new { u.Id, u.Name })
                .ToList();
            cbModel.ValueMember = "Id";
            cbModel.DisplayMember = "Name";
            if (cbModel.Items.Count > 0)
            {
                cbModel.SelectedIndex = 0;
            }
        }

        private void LoadManufactory()
        {
            cbManufactory.DataSource = manufactoryRepository.GetAll()
                .Where(u => u.IsDelete == false || u.IsDelete == null)
                .Select(u => new { u.Id, u.Name })
                .ToList();
            cbManufactory.ValueMember = "Id";
            cbManufactory.DisplayMember = "Name";

            if (cbManufactory.Items.Count > 0)
            {
                cbManufactory.SelectedIndex = 0;
            }
        }

        private void LoadTank(string search = "")
        {
            var tanks = tankRepository.GetAll()
                .Where(t => t.IsDelete == false || t.IsDelete == null)
                .Select(t => new DriverData(
                    t.Id,
                    t.Model.Name,
                    t.Manufactory.Name,
                    t.Unit.Name
                ))
                .ToList();

            if (!string.IsNullOrEmpty(search))
            {
                tanks = tanks
                    .Where(t => t.Model.Contains(search, StringComparison.OrdinalIgnoreCase) || t.Manufactory.Contains(search, StringComparison.OrdinalIgnoreCase) || t.Unit.Contains(search, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            dgvTank.DataSource = tanks;
        }

        public TankGrid()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            LoadTank();
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
            txtManufactoryDepricatedName.Text = "";
            txtModelDepricated.Text = "";
            if (cbModel.Items.Count > 0)
            {
                cbModel.SelectedIndex = 0;
            }

            if (cbManufactory.Items.Count > 0)
            {
                cbManufactory.SelectedIndex = 0;
            }

            cbUnit.SelectedIndex = 0;
        }

        private void dgvTank_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Display the selected row's data in TextBoxes
                txtId.Text = dgvTank.Rows[e.RowIndex].Cells[0].Value.ToString();
                cbModel.Text = dgvTank.Rows[e.RowIndex].Cells[1].Value.ToString();

                var tank = tankRepository.GetAll().Where(t => t.Id == int.Parse(txtId.Text)).FirstOrDefault();
                var model = modelRepository.GetAll().Where(m => m.Id == tank.ModelId).FirstOrDefault();
                var manufactory = manufactoryRepository.GetAll().Where(m => m.Id == tank.ManufactoryId).FirstOrDefault();

                // Check if the Manufactory is isDelete
                if (manufactory.IsDelete == true)
                {
                    txtManufactoryDepricatedName.Text = manufactory.Name + " " + "(depricated)";
                    txtManufactoryDepricatedName.Visible = true;
                }
                else
                {
                    cbManufactory.Text = dgvTank.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtManufactoryDepricatedName.Visible = false;
                }

                // Check if the Model is isDelete
                if (model.IsDelete == true)
                {
                    txtModelDepricated.Text = model.Name + " " + "(depricated)";
                    txtModelDepricated.Visible = true;
                }
                else
                {
                    cbModel.Text = dgvTank.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtModelDepricated.Visible = false;
                }

                cbUnit.Text = dgvTank.Rows[e.RowIndex].Cells[3].Value.ToString();

                // Disable create button and enable delete and update button
                disableCreate();
            }
            catch
            {
                // Show error message because user click on header of DataGridView
                MessageBox.Show("Please click on the row!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!checkAllInput())
            {
                return;
            }

            // Load data from TextBoxes
            var modelId = int.Parse(cbModel.SelectedValue.ToString());
            var manufactoryId = int.Parse(cbManufactory.SelectedValue.ToString());
            var unitId = int.Parse(cbUnit.SelectedValue.ToString());

            try
            {
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
                LoadTank();
                clearTextBox();
            }
            catch
            {
                // Show the error message
                MessageBox.Show("Can not create this tank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Load the id from TextBox
            var id = int.Parse(txtId.Text);

            // Get the driver by id
            var tank = tankRepository.GetAll().Where(d => d.Id == id).FirstOrDefault();
            tank.IsDelete = true;

            // Delete the driver
            try
            {
                tankRepository.Update(tank);

                // Reload data
                LoadTank();
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
            if (!checkAllInput())
            {
                return;
            }

            // Load data from TextBoxes
            var id = int.Parse(txtId.Text);
            var modelId = int.Parse(cbModel.SelectedValue.ToString());
            var manufactoryId = int.Parse(cbManufactory.SelectedValue.ToString());
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
                LoadTank();
                clearTextBox();
                enableCreate();
            }
        }

        private void btnResetTankDgv_Click(object sender, EventArgs e)
        {
            LoadTank();
            clearTextBox();
            enableCreate();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            var search = txtSearch.Text;
            LoadTank(search);
        }
    }
}

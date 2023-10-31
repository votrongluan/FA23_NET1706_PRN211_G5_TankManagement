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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using static Tank_Management.ChangeUnit;

namespace Tank_Management
{
    public partial class DriverGrid : Form
    {
        private DriverRepository driverRepository = new DriverRepository();
        private UnitManagerRepository unitManagerRepository = new UnitManagerRepository();
        private UnitRepository unitRepository = new UnitRepository();
        internal record DriverData(int Id, string IdCard, string Name, string Phone, string Unit);

        private void LoadUnit()
        {
            cbxUnit.DataSource = unitRepository.GetAll()
                .Select(u => new { u.Id, u.Name })
                .ToList();
            cbxUnit.ValueMember = "Id";
            cbxUnit.DisplayMember = "Name";
            cbxUnit.SelectedIndex = 0;
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
            txtIdCard.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            cbxUnit.SelectedIndex = 0;
        }

        private void LoadDriver(string search = "")
        {
            var drivers = driverRepository.GetAll()
                .Select(t => new DriverData(
                    t.Id,
                    t.IdCard,
                    t.Name,
                    t.Phone,
                    t.Unit.Name
                ))
                .ToList();

            if (!string.IsNullOrEmpty(search))
            {
                drivers = drivers
                    .Where(t => t.IdCard.Contains(search, StringComparison.OrdinalIgnoreCase) || t.Name.Contains(search, StringComparison.OrdinalIgnoreCase) || t.Phone.Contains(search, StringComparison.OrdinalIgnoreCase) || t.Unit.Contains(search, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            dgvDriver.DataSource = drivers;
        }

        public DriverGrid()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            LoadDriver();
            LoadUnit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Hide();
        }

        private void dgvDriver_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Display the selected row's data in TextBoxes
            try
            {
                txtId.Text = dgvDriver.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtIdCard.Text = dgvDriver.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtName.Text = dgvDriver.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPhone.Text = dgvDriver.Rows[e.RowIndex].Cells[3].Value.ToString();
                cbxUnit.Text = dgvDriver.Rows[e.RowIndex].Cells[4].Value.ToString();

                // Disable create button and enable delete and update button
                disableCreate();
            } catch
            {
                // Show the error message
                MessageBox.Show("Can not select this row!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Load data from TextBoxes
            var idCard = txtIdCard.Text;
            var name = txtName.Text;
            var phone = txtPhone.Text;
            var unitId = int.Parse(cbxUnit.SelectedValue.ToString());

            // Check the idCard with regex for indentity card
            if (!System.Text.RegularExpressions.Regex.IsMatch(idCard, @"^\d{10,}$"))
            {
                MessageBox.Show("Identity is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check the phone with regex for phone number
            if (!System.Text.RegularExpressions.Regex.IsMatch(phone, @"^0\d{9,10}$"))
            {
                MessageBox.Show("Phone is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check name is empty
            if (name == "")
            {
                MessageBox.Show("Name is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create new driver
            var driver = new Driver()
            {
                IdCard = idCard,
                Name = name,
                Phone = phone,
                UnitId = unitId
            };

            // Add new driver to database
            driverRepository.Add(driver);

            // Reload data
            LoadDriver();
            clearTextBox();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Load the id from TextBox
            var id = int.Parse(txtId.Text);

            // Get the driver by id
            var driver = driverRepository.GetAll().Where(d => d.Id == id).FirstOrDefault();

            // Delete the driver
            try
            {
                driverRepository.Delete(driver);

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
            var idCard = txtIdCard.Text;
            var name = txtName.Text;
            var phone = txtPhone.Text;
            var unitId = int.Parse(cbxUnit.SelectedValue.ToString());

            // Check the idCard with regex for indentity card
            if (!System.Text.RegularExpressions.Regex.IsMatch(idCard, @"^\d{10,}$"))
            {
                MessageBox.Show("Identity is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check the phone with regex for phone number
            if (!System.Text.RegularExpressions.Regex.IsMatch(phone, @"^0\d{9,10}$"))
            {
                MessageBox.Show("Phone is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check name is empty
            if (name == "")
            {
                MessageBox.Show("Name is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the driver by id
            var driver = driverRepository.GetAll().Where(d => d.Id == id).FirstOrDefault();
            if (driver != null)
            {
                // Update the driver
                driver.IdCard = idCard;
                driver.Name = name;
                driver.Phone = phone;
                driver.UnitId = unitId;

                // Update the driver
                driverRepository.Update(driver);

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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var search = txtSearch.Text;
            LoadDriver(search);
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Models;
using Data.Repository;
using Microsoft.EntityFrameworkCore;

namespace Tank_Management
{
    public partial class ModelGrid : Form
    {
        public ModelRepository _modelRepository;
        public AmmoRepository _ammoRepository;
        public ModelGrid()
        {
            _modelRepository = new ModelRepository();
            _ammoRepository = new AmmoRepository();

            InitializeComponent();

            // get model data
            LoadData();

            // get ammo data (combobox)
            LoadCbData();

            ClearText();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ControlBtnCreateOn();

            var check = CheckInputs();
            if (!check) return;

            Model model = new Model
            {
                Name = txtName.Text,
                Weight = int.Parse(nudWeight.Text),
                MaxSpeed = int.Parse(nudMaxSpeed.Text),
                Detail = txtDetail.Text,
                MaxNoDriver = int.Parse(nudMaxNoDriver.Text),
                AmmoId = (int)cbAmmo.SelectedValue,
                Price = int.Parse(nudPrice.Text),
                ShootingRange = int.Parse(nudShootingRange.Text)
            };

            _modelRepository.Add(model);
            LoadData();
            ClearText();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ControlBtnCreateOn();

            var check = CheckInputs();
            if (!check)
            {
                ControlBtnCreateOff();
                return;
            }

            var model = _modelRepository.GetAll().FirstOrDefault(x => x.Id == int.Parse(txtId.Text));

            if (model != null)
            {
                // update model data
                model.Name = txtName.Text;
                model.Weight = int.Parse(nudWeight.Text);
                model.MaxSpeed = int.Parse(nudMaxSpeed.Text);
                model.Detail = txtDetail.Text;
                model.MaxNoDriver = int.Parse(nudMaxNoDriver.Text);
                model.AmmoId = (int)cbAmmo.SelectedValue;
                model.Price = int.Parse(nudPrice.Text);
                model.ShootingRange = int.Parse(nudShootingRange.Text);

                _modelRepository.Update(model);
            }

            LoadData();
            ClearText();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show(@"Are you sure?", @"Warning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (res != DialogResult.Yes) return;
            ControlBtnCreateOn();

            try
            {
                var check = CheckInputs();
                if (!check)
                {
                    ControlBtnCreateOff();
                    return;
                }

                var model = _modelRepository.GetAll().FirstOrDefault(x => x.Id == int.Parse(txtId.Text));
                if (model != null)
                {
                    _modelRepository.Delete(model);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("The data is saved by another table!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

            LoadData();
            ClearText();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void btnBackToDashboard_Click(object sender, EventArgs e)
        {
            var adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var source = new BindingSource();
            source.DataSource = _modelRepository.GetAll()
                .Where(x => x.Name.Contains(txtSearch.Text) || x.Id.ToString().Contains(txtSearch.Text))
                .ToList();
            dgvListModels.DataSource = source.DataSource;
        }

        private void LoadData()
        {
            var source = new BindingSource();

            // display all comlumn exclude ammo and tank
            source.DataSource = _modelRepository.GetAll()
                .Include(x => x.Ammo)
                .Select(x => new
                {
                    x.Id,
                    x.Name,
                    x.Weight,
                    x.MaxSpeed,
                    x.Detail,
                    x.MaxNoDriver,
                    x.Price,
                    x.ShootingRange,
                    Ammo = x.Ammo.Name,
                })
                .ToList();

            dgvListModels.DataSource = source.DataSource;
        }

        private void LoadCbData()
        {
            var source = new BindingSource();
            source.DataSource = _ammoRepository.GetAll()
                .ToList();
            cbAmmo.DataSource = source.DataSource;
            cbAmmo.DisplayMember = "Name";
            cbAmmo.ValueMember = "Id";
            if (cbAmmo.Items.Count <= 0) return;
            cbAmmo.SelectedIndex = 0;
        }

        private bool checkInput(Control txt)
        {
            if (String.IsNullOrEmpty(txt.Text))
            {
                MessageBox.Show("Please input data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // check input > 0 if txt is nud
            if (txt is NumericUpDown)
            {
                if (int.Parse(txt.Text) <= 0)
                {
                    MessageBox.Show("Please input data > 0!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        private void ControlBtnCreateOn()
        {
            btnUpdate.Enabled = false;
            btnCreate.Enabled = true;
            btnDelete.Enabled = false;
        }

        private void ControlBtnCreateOff()
        {
            btnDelete.Enabled = true;
            btnCreate.Enabled = false;
            btnUpdate.Enabled = true;
        }

        private void ClearText()
        {
            txtName.Text = "";
            nudWeight.Text = "";
            nudMaxSpeed.Text = "";
            txtDetail.Text = "";
            nudMaxNoDriver.Text = "";
            cbAmmo.Text = "";
            nudPrice.Text = "";
            nudShootingRange.Text = "";
        }

        private void dgvListModels_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ControlBtnCreateOff();
            try
            {
                var row = dgvListModels.Rows[e.RowIndex];
                txtId.Text = row.Cells["Id"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                nudWeight.Text = row.Cells["Weight"].Value.ToString();
                nudMaxSpeed.Text = row.Cells["MaxSpeed"].Value.ToString();
                txtDetail.Text = row.Cells["Detail"].Value.ToString();
                nudMaxNoDriver.Text = row.Cells["MaxNoDriver"].Value.ToString();
                cbAmmo.Text = row.Cells["Ammo"].Value.ToString();
                nudPrice.Text = row.Cells["Price"].Value.ToString();
                nudShootingRange.Text = row.Cells["ShootingRange"].Value.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Please select a row!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private bool CheckInputs()
        {
            if (!checkInput(txtName)) return false;
            if (!checkInput(nudWeight)) return false;
            if (!checkInput(nudMaxSpeed)) return false;
            if (!checkInput(txtDetail)) return false;
            if (!checkInput(nudMaxNoDriver)) return false;
            if (!checkInput(cbAmmo)) return false;
            if (!checkInput(nudPrice)) return false;
            if (!checkInput(nudShootingRange)) return false;

            return true;
        }
    }
}

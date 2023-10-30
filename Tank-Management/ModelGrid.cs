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

namespace Tank_Management {
    public partial class ModelGrid : Form {
        public ModelRepository _modelRepository;
        public AmmoRepository _ammoRepository;
        public ModelGrid() {
            _modelRepository = new ModelRepository();
            _ammoRepository = new AmmoRepository();

            InitializeComponent();

            // get model data
            LoadData();

            // get ammo data (combobox)
            LoadCbData();

            ClearText();
        }

        private void btnCreate_Click(object sender, EventArgs e) {
            ControlBtnCreateOn();

            var check = CheckInputs();
            if (!check) return;

            Model model = new Model {
                Name = txtName.Text,
                Weight = int.Parse(nudWeight.Text),
                MaxSpeed = int.Parse(nudMaxSpeed.Text),
                Detail = txtDetail.Text,
                MaxNoDriver = int.Parse(nudMaxNoDriver.Text),
                AmmoId = (int)cbAmmoId.SelectedValue,
                Price = int.Parse(nudPrice.Text),
                ShootingRange = int.Parse(nudShootingRange.Text)
            };

            _modelRepository.Add(model);
            LoadData();
            ClearText();
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            ControlBtnCreateOn();

            var check = CheckInputs();
            if (!check) {
                ControlBtnCreateOff();
                return;
            }

            var model = _modelRepository.GetAll().FirstOrDefault(x => x.Id == int.Parse(txtId.Text));

            if (model != null) {
                // update model data
                model.Name = txtName.Text;
                model.Weight = int.Parse(nudWeight.Text);
                model.MaxSpeed = int.Parse(nudMaxSpeed.Text);
                model.Detail = txtDetail.Text;
                model.MaxNoDriver = int.Parse(nudMaxNoDriver.Text);
                model.AmmoId = (int)cbAmmoId.SelectedValue;
                model.Price = int.Parse(nudPrice.Text);
                model.ShootingRange = int.Parse(nudShootingRange.Text);

                _modelRepository.Update(model);
            }

            LoadData();
            ClearText();
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            var res = MessageBox.Show(@"Are you sure?", @"Warning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (res != DialogResult.Yes) return;
            ControlBtnCreateOn();

            var check = CheckInputs();
            if (!check) {
                ControlBtnCreateOff();
                return;
            }

            var model = _modelRepository.GetAll().FirstOrDefault(x => x.Id == int.Parse(txtId.Text));
            if (model != null) {
                _modelRepository.Delete(model);
            }

            LoadData();
            ClearText();
        }

        private void btnReset_Click(object sender, EventArgs e) {
            ClearText();
        }

        private void btnBackToDashboard_Click(object sender, EventArgs e) {
            var adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            var source = new BindingSource();
            source.DataSource = _modelRepository.GetAll()
                .Where(x => x.Name.Contains(txtSearch.Text) || x.Id == int.Parse(txtId.Text))
                .ToList();
            dgvListModels.DataSource = source.DataSource;
        }

        private void LoadData() {
            var source = new BindingSource();
            source.DataSource = _modelRepository.GetAll().ToList();
            dgvListModels.DataSource = source.DataSource;
        }

        private void LoadCbData() {
            var source = new BindingSource();
            source.DataSource = _ammoRepository.GetAll().ToList();
            cbAmmoId.DataSource = source.DataSource;
            cbAmmoId.DisplayMember = "Name";
            cbAmmoId.ValueMember = "Id";
            if (cbAmmoId.Items.Count <= 0) return;
            cbAmmoId.SelectedIndex = 0;
        }

        private bool checkInput(Control txt) {
            if (String.IsNullOrEmpty(txt.Text)) {
                MessageBox.Show("Please input data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // check input > 0 if txt is nud
            if (txt is NumericUpDown) {
                if (int.Parse(txt.Text) <= 0) {
                    MessageBox.Show("Please input data > 0!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        private static void ShowErrorMessageBox(string message, string errorLocation) {
            MessageBox.Show("Error at " + errorLocation + "\n" + message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ControlBtnCreateOn() {
            btnUpdate.Enabled = false;
            btnCreate.Enabled = true;
            btnDelete.Enabled = false;
        }

        private void ControlBtnCreateOff() {
            btnDelete.Enabled = true;
            btnCreate.Enabled = false;
            btnUpdate.Enabled = true;
        }

        private void ClearText() {
            txtName.Text = "";
            nudWeight.Text = "";
            nudMaxSpeed.Text = "";
            txtDetail.Text = "";
            nudMaxNoDriver.Text = "";
            cbAmmoId.Text = "";
            nudPrice.Text = "";
            nudShootingRange.Text = "";
        }

        private void dgvListModels_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            ControlBtnCreateOff();

            var row = dgvListModels.Rows[e.RowIndex];
            txtId.Text = row.Cells["Id"].Value.ToString();
            txtName.Text = row.Cells["Name"].Value.ToString();
            nudWeight.Text = row.Cells["Weight"].Value.ToString();
            nudMaxSpeed.Text = row.Cells["MaxSpeed"].Value.ToString();
            txtDetail.Text = row.Cells["Detail"].Value.ToString();
            nudMaxNoDriver.Text = row.Cells["MaxNoDriver"].Value.ToString();
            cbAmmoId.Text = row.Cells["AmmoId"].Value.ToString();
            nudPrice.Text = row.Cells["Price"].Value.ToString();
            nudShootingRange.Text = row.Cells["ShootingRange"].Value.ToString();
        }

        private bool CheckInputs() {
            if (!checkInput(txtName)) return false;
            if (!checkInput(nudWeight)) return false;
            if (!checkInput(nudMaxSpeed)) return false;
            if (!checkInput(txtDetail)) return false;
            if (!checkInput(nudMaxNoDriver)) return false;
            if (!checkInput(cbAmmoId)) return false;
            if (!checkInput(nudPrice)) return false;
            if (!checkInput(nudShootingRange)) return false;

            return true;
        }
    }
}

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

namespace Tank_Management
{
    public partial class AmmoGrid : Form
    {
        private AmmoRepository ammoRepository = new AmmoRepository();
        private UnitManagerRepository unitManagerRepository = new UnitManagerRepository();
        private UnitRepository unitRepository = new UnitRepository();

        internal record AmmoData(int Id, string Name, int Price, int Weight);

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
            txtName.Text = "";
            txtPrice.Text = "";
            txtWeight.Text = "";
        }

        //load Ammo
        private void LoadAmmo(string search = "")
        {
            var ammos = ammoRepository.GetAll()
                .Where(a => a.IsDelete == false || a.IsDelete == null)
                .Select(t => new AmmoData(
                 t.Id,
                 t.Name,
                 (int)t.Price,
                 (int)t.Weight
                 ))
                .ToList();

            if (!string.IsNullOrEmpty(search))
            {
                ammos = ammos
                    //seach by name, price, weight
                    .Where(t => t.Name.Contains(search, StringComparison.OrdinalIgnoreCase) || t.Price.ToString().Contains(search, StringComparison.OrdinalIgnoreCase) || t.Weight.ToString().Contains(search, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            dgvAmmo.DataSource = ammos;
        }
        public AmmoGrid()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            LoadAmmo();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            var adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Hide();
        }

        private void dgvAmmo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvAmmo.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvAmmo.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPrice.Text = dgvAmmo.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtWeight.Text = dgvAmmo.Rows[e.RowIndex].Cells[3].Value.ToString();

            disableCreate();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var name = txtName.Text;
            var price = txtPrice.Text;
            var weight = txtWeight.Text;

            //check name is not empty
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Name is required");
                return;
            }

            //check price is not empty
            if (string.IsNullOrEmpty(price))
            {
                MessageBox.Show("Price is required");
                return;
            }

            //check weight is not empty
            if (string.IsNullOrEmpty(weight))
            {
                MessageBox.Show("Weight is required");
                return;
            }

            //check price are integer and not negative 
            if (!int.TryParse(price, out int priceInt) || priceInt < 0)
            {
                MessageBox.Show("Price must be integer and not negative");
                return;
            }


            //check weight are integer and not negative
            if (!int.TryParse(weight, out int weightInt) || weightInt < 0)
            {
                MessageBox.Show("Weight must be integer and not negative");
                return;
            }

            //create new ammo
            var ammo = new Ammo
            {
                Name = name,
                Price = priceInt,
                Weight = weightInt
            };

            //save to database
            ammoRepository.Add(ammo);

            //reload data
            LoadAmmo();

            //clear text box
            clearTextBox();

            //enable create button
            enableCreate();

            //catch enter button
            this.AcceptButton = btnCreate;


        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //load id from textbox
            var id = int.Parse(txtId.Text);

            //get ammo by id
            var ammo = ammoRepository.GetAll().Where(a => a.Id == id).FirstOrDefault();
            
            if (ammo != null)
            {
                ammo.IsDelete = true;
                //delete ammo
                try
                {
                    ammoRepository.Update(ammo);

                    //reload data
                    LoadAmmo();
                    clearTextBox();
                    enableCreate();

                    //catch enter button
                    this.AcceptButton = btnCreate;
                }
                catch (Exception)
                {
                    //show error message
                    MessageBox.Show("Can not delete this ammo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //load data from textbox
            var id = int.Parse(txtId.Text);
            var name = txtName.Text;
            var price = txtPrice.Text;
            var weight = txtWeight.Text;

            //check name is not empty
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Name is required");
                return;
            }

            //check price is not empty
            if (string.IsNullOrEmpty(price))
            {
                MessageBox.Show("Price is required");
                return;
            }

            //check weight is not empty
            if (string.IsNullOrEmpty(weight))
            {
                MessageBox.Show("Weight is required");
                return;
            }

            //check price are integer and not negative 
            if (!int.TryParse(price, out int priceInt) || priceInt < 0)
            {
                MessageBox.Show("Price must be integer and not negative");
                return;
            }


            //check weight are integer and not negative
            if (!int.TryParse(weight, out int weightInt) || weightInt < 0)
            {
                MessageBox.Show("Weight must be integer and not negative");
                return;
            }

            //get the ammo by id
            var ammo = ammoRepository.GetAll().Where(a => a.Id == id).FirstOrDefault();
            if (ammo != null)
            {
                //update ammo
                try
                {
                    ammo.Name = name;
                    ammo.Price = priceInt;
                    ammo.Weight = weightInt;

                    ammoRepository.Update(ammo);

                    //reload data
                    LoadAmmo();
                    clearTextBox();
                    enableCreate();

                    //catch enter button
                    this.AcceptButton = btnCreate;
                }
                catch (Exception)
                {
                    //show error message
                    MessageBox.Show("Can not update this ammo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnResetAmmoDgv_Click(object sender, EventArgs e)
        {
            LoadAmmo();
            clearTextBox();
            enableCreate();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var search = txtSearch.Text;
            LoadAmmo(search);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearTextBox();
            enableCreate();

            //catch enter button
            this.AcceptButton = btnCreate;
        }

        private void dgvAmmo_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvAmmo.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvAmmo.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPrice.Text = dgvAmmo.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtWeight.Text = dgvAmmo.Rows[e.RowIndex].Cells[3].Value.ToString();

            disableCreate();
        }

    }
}

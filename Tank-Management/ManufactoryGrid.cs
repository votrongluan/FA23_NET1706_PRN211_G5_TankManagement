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
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Tank_Management
{
    public partial class ManufactoryGrid : Form
    {
        private ManufactoryRepository manufactoryRepository = new ManufactoryRepository();
        private LocationRepository locationRepository = new LocationRepository();

        internal record ManufactoryData(int Id, string Name, string locationId);
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
        public ManufactoryGrid()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            LoadLocation();
            LoadManufactory();
        }
        private void clearTextBox()
        {
            idtxt.Text = "";
            nametxt.Text = "";
            locationcbx.SelectedIndex = 0;
        }

        public void LoadLocation()
        {
            locationcbx.DataSource = locationRepository.GetAll()
                .Select(l => new { l.Id, l.Name })
                .ToList();
            locationcbx.ValueMember = "Id";
            locationcbx.DisplayMember = "Name";
            locationcbx.SelectedIndex = 0;
        }

        private void LoadManufactory(string search = "")
        {
            var manufactories = manufactoryRepository.GetAll().
                Select(m => new ManufactoryData
                (
                    m.Id,
                    m.Name,
                    m.Location.Name
                )).ToList();

            if (!string.IsNullOrEmpty(search))
            {
                manufactories = manufactories.Where(m => m.Id.ToString().Contains(search, StringComparison.OrdinalIgnoreCase) || m.Name.Contains(search, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }
            manufactorydgv.DataSource = manufactories;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var id = idtxt.Text;
            var name = nametxt.Text;
            var locationId = int.Parse(locationcbx.SelectedValue.ToString());

            if (name == "")
            {
                MessageBox.Show("Name is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var manufactory = new Manufactory()
            {
                Name = name,
                LocationId = locationId
            };

            manufactoryRepository.Add(manufactory);

            LoadManufactory();
            clearTextBox();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Hide();
        }

        private void manufactorydgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idtxt.Text = manufactorydgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            nametxt.Text = manufactorydgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            locationcbx.Text = manufactorydgv.Rows[e.RowIndex].Cells[2].Value.ToString();

            disableCreate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var id = int.Parse(idtxt.Text);

            var manu = manufactoryRepository.GetAll().Where(m => m.Id == id).FirstOrDefault();

            try
            {
                manufactoryRepository.Delete(manu);

                // Reload data
                LoadManufactory();
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
            var id = int.Parse(idtxt.Text);
            var name = nametxt.Text;
            var locationId = int.Parse(locationcbx.SelectedValue.ToString());

            if (name == "")
            {
                MessageBox.Show("Name is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var manu = manufactoryRepository.GetAll().Where(d => d.Id == id).FirstOrDefault();
            if (manu != null)
            {
                // Update the driver

                manu.Name = name;
                manu.LocationId = locationId;

                // Update the driver
                manufactoryRepository.Update(manu);

                // Reload data
                LoadManufactory();
                clearTextBox();
                enableCreate();
            }
        }

        private void btnResetDgv_Click(object sender, EventArgs e)
        {
            LoadManufactory();
            clearTextBox();
            enableCreate();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var search = searchtxt.Text;
            LoadManufactory(search);
        }
    }
}

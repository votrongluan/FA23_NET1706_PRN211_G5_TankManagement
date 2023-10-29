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

namespace Tank_Management {
    public partial class Login : Form {
        public UserRepository userRepository;
        public RoleRepository roleRepostiry = new RoleRepository();
        public Login() {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            lbLogin.BackColor = Color.Transparent;
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            userRepository = new UserRepository();
            var users = userRepository.GetAll().ToList();
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Find user with below conditions
            var user = users.Where(u => u.Username == username && u.Password == password).FirstOrDefault();

            if (user != null) {
                var checkRole = roleRepostiry.GetAll().Where(r => r.Id == user.RoleId).FirstOrDefault();
                Program.user = user;
                if (checkRole.Description.Equals("ad")) {
                    var adminDasboard = new AdminDashboard();
                    adminDasboard.Show();
                    this.Hide();
                } else {
                    var userDashboard = new UserDashboard();
                    userDashboard.Show();
                    this.Hide();
                }
            } else {
                MessageBox.Show("Username or password is incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

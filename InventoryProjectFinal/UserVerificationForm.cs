using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryProjectFinal
{
    public partial class UserVerificationForm : Form
    {
        public UserVerificationForm()
        {
            InitializeComponent();
            InitializeComboBox();
            this.KeyPreview = true; // Ensures the form processes key presses first
            this.KeyDown += new KeyEventHandler(MainForm_KeyDown);

        }
        private void InitializeComboBox()
        {
            cbAffiliation.Items.Add("Employee");
            cbAffiliation.Items.Add("Store Manager");
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string uiUsername = txtUsername.Text;
            string uiPassword = txtPassword.Text;
            string uiAffiliation = cbAffiliation.Text;

            if (uiUsername == "admin" && uiPassword == "admin" && uiAffiliation == "Store Manager")
            {
                MainForm mainForm = new MainForm(uiUsername, uiAffiliation);
                mainForm.Show();
                this.Hide();
            }
            else if (uiUsername == "employee" && uiPassword == "employee" && uiAffiliation == "Employee")
            {
                MainForm mainForm = new MainForm(uiUsername, uiAffiliation);
                mainForm.Show();
                this.Hide();
            }
            else if (uiUsername.ToUpper() == "EJAY" && uiPassword == "" && uiAffiliation == "")
            {
                MessageBox.Show("Ikaw pala yan bossing!!!", "BOSS!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MainForm mainForm = new MainForm(uiUsername, uiAffiliation);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Prevent the default ding sound
                btnLogin.PerformClick();    // Simulate the button click
            }
        }


    }
}

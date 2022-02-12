using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
            txtCPasswordRegister.MaxLength = 16;
        }

        SqlConnection con = new SqlConnection("Data Source = localhost; Initial Catalog = Inventory; Integrated Security = True");

        private void usernameCombo_MouseHover(object sender, EventArgs e)
        {
            toolTipRegister.SetToolTip(usernameCombo, "Select user");
        }

        private void textBoxMouseHover(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            switch (textbox.Name)
            {
                case "txtRegisterName":
                    toolTipRegister.SetToolTip(txtRegisterName, "Enter Name");
                    break;
                case "txtPhoneRegister":
                    toolTipRegister.SetToolTip(txtPhoneRegister, "Phone Number");
                    break;
                case "txtPasswordRegister":
                    toolTipRegister.SetToolTip(txtPasswordRegister, "Password");
                    break;
                case "txtCPasswordRegister":
                    toolTipRegister.SetToolTip(txtCPasswordRegister, "Confirm Password");
                    break;
                case "txtCompanyNameRegister":
                    toolTipRegister.SetToolTip(txtCompanyNameRegister, "Company Name");
                    break;
                default:
                    MessageBox.Show("Invalid Request");
                    break;
            }
        }
        private void txtCPasswordRegister_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtPasswordRegister.Text != txtCPasswordRegister.Text)
            {
                lblPasswordMsg.Text = "Passwords do not match";
                lblPasswordMsg.ForeColor = SystemColors.Control;
                lblPasswordMsg.BackColor = Color.Red;
                return;
            }else if (txtPasswordRegister.Text == "")
            {
                lblPasswordMsg.Text = "Password fields are blank";
                lblPasswordMsg.ForeColor = SystemColors.Control;
                lblPasswordMsg.BackColor = Color.Red;
                return;
            }
            else
            {
                lblPasswordMsg.Text = "Password is correct";
                lblPasswordMsg.ForeColor = SystemColors.Control;
                lblPasswordMsg.BackColor = Color.DarkSeaGreen;
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(usernameCombo.Text == "" || txtRegisterName.Text == "" || txtPhoneRegister.Text == ""
                || txtCompanyNameRegister.Text == "")
            {
                lblPasswordMsg.Text = "Something is wrong.";
                lblPasswordMsg.ForeColor = SystemColors.Control;
                lblPasswordMsg.BackColor = Color.Red;
                return;
            }else if (txtCPasswordRegister.Text == "" || txtPasswordRegister.Text == "")
            {
                lblPasswordMsg.Text = "Password fields are blank";
                lblPasswordMsg.ForeColor = SystemColors.Control;
                lblPasswordMsg.BackColor = Color.Red;
                return;
            }
            else if(usernameCombo.Text != "admin")
            {
                lblPasswordMsg.Text = "Please select admin from dropdown";
                lblPasswordMsg.ForeColor = SystemColors.Control;
                lblPasswordMsg.BackColor = Color.Red;
                return;
            }
            else
            {
                con.Open();
                SqlCommand regCMD = new SqlCommand("insert into users(username, name, phone_number, password, company_name, suspended) values('"+ usernameCombo.Text +"', '"+ txtRegisterName.Text +"', '"+ txtPhoneRegister.Text +"', '"+ txtPasswordRegister.Text +"', '"+ txtCompanyNameRegister.Text +"', 0)", con);
                regCMD.ExecuteNonQuery();
                lblPasswordMsg.Text = "Account created successfully";
                lblPasswordMsg.ForeColor = SystemColors.Control;
                lblPasswordMsg.BackColor = Color.DarkSeaGreen;
                con.Close();
            }
        }

        private void btnRegisterLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            login _login = new login();
            _login.ShowDialog();
        }
    }
}

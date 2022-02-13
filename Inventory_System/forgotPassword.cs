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
    public partial class forgotPassword : Form
    {
        public forgotPassword()
        {
            InitializeComponent();
            txtPasswordRecover.MaxLength = 16;
            txtRCPassword.MaxLength = 16;
        }

        SqlConnection con = new SqlConnection("Data Source = localhost; Initial Catalog = Inventory; Integrated Security = True");

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRecover_Click(object sender, EventArgs e)
        {
            if(txtRecoverNumber.Text == "" || txtCNRecover.Text == "" || txtRCPassword.Text == "" 
                || txtRCPassword.Text == "")
            {
                lblRecoverMsg.Text = "All fields are required.";
                lblRecoverMsg.ForeColor = SystemColors.Control;
                lblRecoverMsg.BackColor = Color.Red;
            }
            else
            {
                con.Open();
                SqlCommand checkCMD = new SqlCommand("select phone_number, company_name from users where phone_number = '"+ txtRecoverNumber.Text +"' AND company_name = '"+ txtCNRecover.Text +"' AND username = 'admin' ", con);
                SqlDataAdapter checkDA = new SqlDataAdapter(checkCMD);
                DataTable cDA = new DataTable();
                con.Close();

                checkDA.Fill(cDA);
                
                if (cDA.Rows.Count == 1)
                {
                    con.Open();
                    SqlCommand recoverCMD = new SqlCommand("update users set password = '" + txtPasswordRecover.Text + "' where phone_number = '" + txtRecoverNumber.Text + "' AND company_name = '" + txtCNRecover.Text + "' AND username = 'admin'", con);
                    recoverCMD.ExecuteNonQuery();
                    lblRecoverMsg.Text = "New password created successfully.";
                    lblRecoverMsg.ForeColor = SystemColors.Control;
                    lblRecoverMsg.BackColor = Color.DarkSeaGreen;
                    con.Close();
                    txtRecoverNumber.Clear(); txtCNRecover.Clear(); txtPasswordRecover.Clear(); txtRCPassword.Clear();
                }
                else
                {
                    lblRecoverMsg.Text = "Wrong phone number or company name.";
                    lblRecoverMsg.ForeColor = SystemColors.Control;
                    lblRecoverMsg.BackColor = Color.Red;
                }
            }
            
        }

        private void txtRCPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if(txtRCPassword.Text != txtPasswordRecover.Text)
            {
                lblRecoverMsg.Text = "Passwords do not match.";
                lblRecoverMsg.ForeColor = SystemColors.Control;
                lblRecoverMsg.BackColor = Color.Red;
            }
            else if (txtPasswordRecover.TextLength < 8 || txtPasswordRecover.MaxLength > 16)
            {
                lblRecoverMsg.Text = "Password length should be 8 characters less than 16.";
                lblRecoverMsg.ForeColor = SystemColors.Control;
                lblRecoverMsg.BackColor = Color.Red;
            }
            else
            {
                lblRecoverMsg.Text = "Confirm password is correct.";
                lblRecoverMsg.ForeColor = SystemColors.Control;
                lblRecoverMsg.BackColor = Color.DarkSeaGreen;
            }
        }

        private void lblRecoverLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            login _login = new login();
            _login.ShowDialog();
        }
    }
}

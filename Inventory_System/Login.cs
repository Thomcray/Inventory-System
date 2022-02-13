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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            txtPassword.MaxLength = 16;
        }
        SqlConnection con = new SqlConnection("Data Source = localhost; Initial Catalog = Inventory; Integrated Security = True");
        string userID { get; set; }
        string user { get; set; }
        string companyName { get; set; }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select username, password from users where username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "' ", con);
            SqlDataAdapter SDA = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            con.Close();
            SDA.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                // Check if user is suspended
                con.Open();
                SqlCommand cmd_1 = new SqlCommand("select username, suspended from users where username = '" + txtUsername.Text + "' AND NOT suspended = 0", con);
                SqlDataAdapter SDA_1 = new SqlDataAdapter(cmd_1);
                DataTable dt_1 = new DataTable();
                SDA_1.Fill(dt_1);
                con.Close();
                if (dt_1.Rows.Count == 1)
                {
                    MessageBox.Show("User is suspended. Contact admin.");
                    return;
                }
                else
                {
                    // Get username for User Access Control
                    con.Open();
                    SqlCommand cmd2 = new SqlCommand("select id, username, company_name from users where username = '" + txtUsername.Text + "'", con);
                    //string user = cmd2.ExecuteScalar() as string;
                    SqlDataReader myReader;
                    myReader = cmd2.ExecuteReader();
                    while (myReader.Read())
                    {
                        userID = myReader["id"].ToString();
                        user = myReader["username"].ToString();
                        companyName = myReader["company_name"].ToString();
                        ProgressBar pb = new ProgressBar(this, userID, user, companyName);
                        pb.Show();
                        this.Hide();
                    }
                    con.Close();
                }

            }
            else
            {
                lblErrorMsg.Text = "Invalid username or password";
                lblErrorMsg.BackColor = Color.Red;
            }
        }

        private void passwordIcon_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtPassword.TextLength < 8 || txtPassword.MaxLength > 16)
            {
                lblErrorMsg.Text = "Password should be atleast 8 characters less than 16";
                lblErrorMsg.BackColor = Color.Red;
            }
            else
            {
                lblErrorMsg.Text = "";
            }
        }

        private void lblRegisterNew_Click(object sender, EventArgs e)
        {
            this.Hide();
            register newReg = new register();
            newReg.ShowDialog();
        }

        private void btnCloseLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            forgotPassword recoverWindow = new forgotPassword();
            recoverWindow.ShowDialog();
        }
    }
}

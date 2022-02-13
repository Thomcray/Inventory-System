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
    public partial class manageUsers : Form
    {
        string MU_NUser;
        string MU_NewName;
        string MU_NewPhone;
        string MU_NewCName;
        string MU_NewPassword;

        //
        private login _login;
        public string _UserID;
        public string _User;
        public string _CompanyName;
        public manageUsers(login login, string userID, string user, string companyName)
        {
            InitializeComponent();
            _login = login;
            _UserID = userID;
            _User = user;
            _CompanyName = companyName;

            //PREVENT DEFAULT BLUE SELECTION OF CELL FROM MUDISPLAYGRID
            muDisplayGrid.DefaultCellStyle.SelectionBackColor = Color.White;
            muDisplayGrid.DefaultCellStyle.SelectionForeColor = Color.Black;

            //txtCPasswordChange maxlength
            txtCPasswordChange.MaxLength = 16;
            //txtMUNewPassword maxlength
            txtMUNewPassword.MaxLength = 16;
        }

        SqlConnection con = new SqlConnection("Data Source = localhost; Initial Catalog = Inventory; Integrated Security = True");

        public void FillmuDisplayGrid()
        {
            try
            {
                con.Open();
                SqlCommand muCMD = new SqlCommand("select id as UserID, username as 'User Role', name as Name, phone_number as 'Phone Number', password as Password, company_name as 'Company Name', suspended as Suspended from users where company_name = '" + _CompanyName + "' AND NOT username = 'admin' ", con);
                SqlDataAdapter muSDA = new SqlDataAdapter(muCMD);
                DataTable muDT = new DataTable();
                muSDA.Fill(muDT);
                muDisplayGrid.DataSource = muDT;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void manageUsers_Load(object sender, EventArgs e)
        {
            FillmuDisplayGrid();
            txtMUUserID.ReadOnly = true;
            msgNewUserPanel.Visible = false;

            txtMUNewCName.ReadOnly = true;
            txtMUNewCName.Text = _CompanyName;
        }

        private void muDisplayGrid_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                string userActivateIndex = muDisplayGrid.CurrentRow.Cells[0].Value.ToString();
                //muDisplayGrid.Rows.RemoveAt(muDisplayGrid.CurrentCell.RowIndex);
                if (userActivateIndex == "")
                {
                    //muPanel.Visible = false;
                    MessageBox.Show("Select user to ACTIVATE/SUSPEND.");
                    return;
                }
                else
                {
                    //muPanel.Visible = true;
                    txtMUUserID.Text = muDisplayGrid.CurrentRow.Cells[0].Value.ToString();
                    txtMUUserRole.Text = muDisplayGrid.CurrentRow.Cells[1].Value.ToString();
                    txtMUName.Text = muDisplayGrid.CurrentRow.Cells[2].Value.ToString();
                    txtMUPhone.Text = muDisplayGrid.CurrentRow.Cells[3].Value.ToString();
                    txtMUCompany_.Text = muDisplayGrid.CurrentRow.Cells[5].Value.ToString();
                    txtMUSuspended.Text = muDisplayGrid.CurrentRow.Cells[6].Value.ToString();
                    txtPasswordChange.Text = muDisplayGrid.CurrentRow.Cells[4].Value.ToString();
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void MUSuspUserIcon_Click(object sender, EventArgs e)
        {
            try
            {
                string userSusupendIndex = muDisplayGrid.CurrentRow.Cells[0].Value.ToString();
                //muDisplayGrid.Rows.RemoveAt(muDisplayGrid.CurrentCell.RowIndex);
                if (userSusupendIndex == "")
                {
                    MessageBox.Show("Select user to SUSPEND.");
                    return;
                }
                else
                {
                    con.Open();
                    SqlCommand suCMD = new SqlCommand("update users set suspended = 1 where id = '" + txtMUUserID.Text + "' AND company_name = '" + _CompanyName + "'", con);
                    suCMD.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("User suspended.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtMUNewCPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if(txtMUNewCPassword.Text != txtMUNewPassword.Text)
            {
                msgNewUserPanel.Visible = true;
                msgNewUserPanel.BackColor = Color.Red;
                btnMUNewUser.Visible = false;
                lblNewUserMsg.Text = "Password do not match.";
            }
            else if (txtMUNewPassword.TextLength < 8 || txtMUNewPassword.MaxLength == 16)
            {
                msgNewUserPanel.Visible = true;
                msgNewUserPanel.BackColor = Color.Red;
                btnMUNewUser.Visible = false;
                lblNewUserMsg.Text = "Password should be at least 8 characters less than 16.";
            }
            else
            {
                msgNewUserPanel.Visible = true;
                msgNewUserPanel.BackColor = Color.DarkSeaGreen;
                btnMUNewUser.Visible = true;
                lblNewUserMsg.Text = "Password match.";
            }
        }

        private void btnMUNewUser_Click(object sender, EventArgs e)
        {
            MU_NUser = txtMUNewUser.Text;
            MU_NewName = txtMUNewName.Text;
            MU_NewPhone = txtMUNewPhone.Text;
            MU_NewCName = txtMUNewCName.Text;
            MU_NewPassword = txtMUNewPassword.Text;
            
            if (MU_NUser == "" || MU_NewName == "" || MU_NewPhone == "" || MU_NewCName == ""
                || MU_NewPassword == "")
            {
                msgNewUserPanel.Visible = true;
                msgNewUserPanel.BackColor = Color.Red;
                btnMUNewUser.Visible = false;
                lblNewUserMsg.Text = "Empty field(s).";
                return;
            }
            else
            {
                btnMUNewUser.Visible = true;
                con.Open();
                SqlCommand nuCMD = new SqlCommand("insert into users(username, name, phone_number, password, company_name, suspended) values('"+ MU_NUser +"', '"+ MU_NewName +"', '"+ MU_NewPhone +"', '"+ MU_NewPassword +"', '"+ MU_NewCName +"', 0)", con);
                nuCMD.ExecuteNonQuery();
                msgNewUserPanel.Visible = true;
                msgNewUserPanel.BackColor = Color.DarkSeaGreen;
                btnMUNewUser.Visible = false;
                lblNewUserMsg.Text = "User Created Successfully.";
                con.Close();
                //Display in manage user table
                FillmuDisplayGrid();
            }
            txtMUNewUser.Clear(); txtMUNewName.Clear(); txtMUNewPhone.Clear(); txtMUNewCName.Clear(); txtMUNewPassword.Clear(); txtMUNewCPassword.Clear(); 
        }

        private void ActivateUserIcon_Click(object sender, EventArgs e)
        {
            try
            {
                string userActivateIndex = muDisplayGrid.CurrentRow.Cells[0].Value.ToString();
                //muDisplayGrid.Rows.RemoveAt(muDisplayGrid.CurrentCell.RowIndex);
                if (userActivateIndex == "")
                {
                    MessageBox.Show("Select user to ACTIVATE.");
                    return;
                }
                else
                {
                    con.Open();
                    SqlCommand suCMD = new SqlCommand("update users set suspended = 0 where id = '" + txtMUUserID.Text + "' AND company_name = '" + _CompanyName + "'", con);
                    suCMD.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("User activated.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void MURefreshIcon_Click(object sender, EventArgs e)
        {
            FillmuDisplayGrid();
        }

        private void btnCloseMU_Click(object sender, EventArgs e)
        {
            DialogResult saleConfirm;
            saleConfirm = MessageBox.Show("Are you sure you want to close?", "Inventory System", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (saleConfirm == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCPasswordChange.Text == "")
                {
                    lblMUChangePMsg.Text = "Enter new password to make changes.";
                    lblMUChangePMsg.BackColor = Color.Red;
                    return;
                }
                else if(txtCPasswordChange.TextLength < 8 || txtCPasswordChange.MaxLength > 16)
                {

                    lblMUChangePMsg.Text = "Password should be at least 8 characters less than 16.";
                    lblMUChangePMsg.BackColor = Color.Red;
                    return;
                }
                else
                {
                    con.Open();
                    SqlCommand suCMD = new SqlCommand("update users set password = '"+ txtCPasswordChange.Text +"' where id = '" + txtMUUserID.Text + "' AND company_name = '" + _CompanyName + "'", con);
                    suCMD.ExecuteNonQuery();
                    con.Close();
                    lblMUChangePMsg.Text = "Password changed successfully.";
                    lblMUChangePMsg.BackColor = Color.DarkSeaGreen;
                    txtPasswordChange.Clear();
                    txtCPasswordChange.Clear();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}

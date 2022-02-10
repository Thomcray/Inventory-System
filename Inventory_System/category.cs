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
    public partial class category : Form
    {
        private login _login;
        public string _UserID;
        public string _User;
        public string _CompanyName;
        public category(login login, string userID, string user, string companyName)
        {
            InitializeComponent();
            _login = login;
            _UserID = userID;
            _User = user;
            _CompanyName = companyName;
        }
        SqlConnection con = new SqlConnection("Data Source = localhost; Initial Catalog = Inventory; Integrated Security = True");


        private void category_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(_UserID + _User);
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtCategory.Text == "")
                {
                    lblSearchMsg.Text = "Field is empty.";
                    lblSearchMsg.ForeColor = Color.Red;
                    return;
                }
                else
                {
                    con.Open();
                    SqlCommand searchCMD = new SqlCommand("insert into category(cname, date_added, user_role, userid, company_name) values('" + txtCategory.Text + "', getdate(), '" + _User + "', '" + _UserID + "', '"+ _CompanyName +"')", con);
                    searchCMD.ExecuteNonQuery();
                    con.Close();
                    lblSearchMsg.Text = "Category added successfully";
                    lblSearchMsg.ForeColor = Color.Green;
                }
            }
            catch (Exception)
            {

                lblSearchMsg.Text = "Something went wrong.";
                lblSearchMsg.ForeColor = Color.Red;
            }
            
        }
        private void btnCloseCategory_Click(object sender, EventArgs e)
        {
            DialogResult saleConfirm;
            saleConfirm = MessageBox.Show("Are you sure you want to close?", "Inventory System", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (saleConfirm == DialogResult.Yes)
            {
                this.Hide();
            }
        }
    }
}

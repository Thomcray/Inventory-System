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
    public partial class mainWindow : Form
    {
        public string _UserID { get; set; }
        public string _User { get; set; }
        public string _CompanyName { get; set; }

        private login _login;

        SqlConnection con = new SqlConnection("Data Source = localhost; Initial Catalog = Inventory; Integrated Security = True");

        public mainWindow(login login, string userID, string user, string companyName)
        {
            InitializeComponent();
            _CompanyName = companyName;
            _UserID = userID;
            _User = user;
            _login = login;

        }
        // Login instance for window open parameter
        login login = new login();

        public void chartdashboard()
        {
            if(_User == "admin")
            {
                // GET SUM OF COST MADE BY ALL USERs
                con.Open();
                SqlCommand cdash = new SqlCommand("SELECT SUM(total) AS total FROM(SELECT MAX(total) AS total FROM sales where company_name = '"+ _CompanyName + "' GROUP BY transaction_id) T1", con);

                SqlDataReader dashReader;
                dashReader = cdash.ExecuteReader();

                while (dashReader.Read())
                  {
                    sumTotalSale.Text = dashReader["total"].ToString();
                  }
                con.Close();

                // GET DAY SUM OF COST MADE BY ALL USERs 
                con.Open();
                SqlCommand cdash1 = new SqlCommand("SELECT SUM(total) AS total FROM (SELECT MAX(total) AS total FROM sales where company_name = '"+ _CompanyName +"' AND Day(date) = DAY(getdate()) GROUP BY transaction_id) T1", con);
                //SELECT SUM(total)FROM(SELECT MAX(total) AS total FROM sales GROUP BY transaction_id) T1
                SqlDataReader dashReader1;
                dashReader1 = cdash1.ExecuteReader();

                while (dashReader1.Read())
                {
                    sumSaleToday.Text = dashReader1["total"].ToString();
                }
                con.Close();

                // GET SUM OF ITEM QTY IN STOCK
                con.Open();
                SqlCommand cdash2 = new SqlCommand("select SUM(qty) as'Total qty' from stock where company_name = '" + _CompanyName + "'  AND utype = '" + _User + "'", con);

                SqlDataReader dashReader2;
                dashReader2 = cdash2.ExecuteReader();

                while (dashReader2.Read())
                {
                    sumTotalItems.Text = dashReader2["Total qty"].ToString();
                }
                con.Close();

                // GET COUNT OF ITEM QTY IN STOCK
                con.Open();
                SqlCommand cdash3 = new SqlCommand("select COUNT(id) as'Total count' from stock where company_name = '" + _CompanyName + "'", con);

                SqlDataReader dashReader3;
                dashReader3 = cdash3.ExecuteReader();

                while (dashReader3.Read())
                {
                    countRecords.Text = dashReader3["Total count"].ToString();
                }
                con.Close();
            }
            else
            {
                // GET SUM OF COST MADE BY LOGGED IN USERs
                con.Open();
                SqlCommand cdash = new SqlCommand("SELECT SUM(total) AS total FROM (SELECT MAX(total) AS total FROM sales where company_name = '" + _CompanyName + "' AND utype = '" + _User + "' GROUP BY transaction_id) T1", con);

                SqlDataReader dashReader;
                dashReader = cdash.ExecuteReader();

                while (dashReader.Read())
                {
                    sumTotalSale.Text = dashReader["total"].ToString();
                }
                con.Close();

                // GET DAY SUM OF COST MADE BY LOGGED IN USERs
                con.Open();
                SqlCommand cdash1 = new SqlCommand("SELECT SUM(total) AS total FROM (SELECT MAX(total) AS total FROM sales where company_name = '" + _CompanyName + "' AND Day(date) = DAY(getdate())  AND utype = '" + _User + "' GROUP BY transaction_id) T1", con);

                SqlDataReader dashReader1;
                dashReader1 = cdash1.ExecuteReader();

                while (dashReader1.Read())
                {
                    sumSaleToday.Text = dashReader1["total"].ToString();
                }
                con.Close();

                // GET SUM OF ITEM QTY IN STOCK
                con.Open();
                SqlCommand cdash2 = new SqlCommand("select SUM(qty) as'Total qty' from stock where company_name = '" + _CompanyName + "'", con);

                SqlDataReader dashReader2;
                dashReader2 = cdash2.ExecuteReader();

                while (dashReader2.Read())
                {
                    sumTotalItems.Text = dashReader2["Total qty"].ToString();
                }
                con.Close();

                // GET COUNT OF ITEM QTY IN STOCK
                con.Open();
                SqlCommand cdash3 = new SqlCommand("select COUNT(id) as'Total count' from stock where company_name = '" + _CompanyName + "'", con);

                SqlDataReader dashReader3;
                dashReader3 = cdash3.ExecuteReader();

                while (dashReader3.Read())
                {
                    countRecords.Text = dashReader3["Total count"].ToString();
                }
                con.Close();
            }
            
        }
        private void mainWindow_Load(object sender, EventArgs e)
        {
            // To display chart on dashboard 
            chartdashboard();

            //chart1.Series["Activity Chart"].Points.AddXY("Total Sales", sumTotalSale.Text);
            //chart1.Series["Activity Chart"].Points.AddXY("Total Sales Today", sumSaleToday.Text);
            //chart1.Series["Activity Chart"].Points.AddXY("Total Items", sumTotalItems.Text);
            //chart1.Series["Activity Chart"].Points.AddXY("Total Records", countRecords.Text);

            // Check user sign in
            if (_User != "admin")
            {
                btnMenuItem.Enabled = false;
                lblLoggedUser.Text = "Welcome, " + _User;
                lblManageUsers.Visible = false;
                btnCategory.Enabled = false;
                btnSettings.Enabled = false;
                //signIn.Visible = false;

            }
            else
            {
                lblLoggedUser.Text = "Welcome, " + _User;
                lblLoggedUser.ForeColor = SystemColors.Control;
                //lblManageUsers.Visible = false;
                //btnSettings.Enabled = false;
            }
        }
        private void dashRefreshIcon_Click(object sender, EventArgs e)
        {
            chartdashboard();
        }
        private void btnMenuItem_Click(object sender, EventArgs e)
        {
            Button menuType = (Button)sender;
            switch (menuType.Text)
            {
                case "Add Items":
                    addItems newItem = new addItems(login, _UserID, _User, _CompanyName);
                    newItem.ShowDialog();
                    //newItem.Show();
                    break;
                case "Category":
                    category categoryWindow = new category(login, _UserID, _User, _CompanyName);
                    categoryWindow.ShowDialog();
                    //categoryWindow.Show();
                    break;
                case "Sales":
                    sales salesWindow = new sales(login, _UserID, _User, _CompanyName);
                    salesWindow.ShowDialog();
                    //salesWindow.Show();
                    break;
                case "Records":
                    records _records = new records(login, _UserID, _User, _CompanyName);
                    _records.ShowDialog();
                    //_records.Show();
                    break;
                case "Item in Stock":
                    inStock _inStock = new inStock(login, _UserID, _User, _CompanyName);
                    _inStock.ShowDialog();
                   // _inStock.Show();
                    break;
                case "Settings":
                    settings _settings = new settings(login, _UserID, _User, _CompanyName);
                    _settings.ShowDialog();
                    //_settings.Show();
                    break;
                case "x":
                   
                     DialogResult saleConfirm;
                     saleConfirm = MessageBox.Show("Are you sure you want to Exit?", "Inventory System", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                       if (saleConfirm == DialogResult.Yes)
                         Application.Exit();
                    
                    break;
                default:
                    MessageBox.Show("Invalid request");
                    break;
            }

        }
        private void lblItems(object sender, EventArgs e)
        {
            Label lblType = (Label)sender;
            switch (lblType.Text)
            {
                case "Manage Users":
                    manageUsers muUsers = new manageUsers(login, _UserID, _User, _CompanyName);
                    muUsers.Show();
                    break;
                case "LogOut":
                    this.Hide();
                    login.Show();
                    break;
                default:
                    MessageBox.Show("Invalid request");
                    break;
            }
        }
    }
}

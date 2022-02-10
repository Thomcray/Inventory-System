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
    public partial class inStock : Form
    {
        private login _login;
        public string _UserID;
        public string _User;
        public string _CompanyName;
        public inStock(login login, string userID, string user, string companyName)
        {
            InitializeComponent();
            _login = login;
            _UserID = userID;
            _User = user;
            _CompanyName = companyName;
            //MessageBox.Show(_CompanyName);

            //PREVENT DEFAULT BLUE SELECTION OF CELL FROM INSTOCKDATAVIEW
            inStockDataView.DefaultCellStyle.SelectionBackColor = Color.White;
            inStockDataView.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
        SqlConnection con = new SqlConnection("Data Source = localhost; Initial Catalog = Inventory; Integrated Security = True");

        public void FillInStockData()
        {
            con.Open();
            SqlCommand fisCMD = new SqlCommand("select itemid as ItemID, iname as 'Item Name', description as Description, category as Category, qty as Available, brand as Brand, price as 'Price(NGN)', date_added as 'Date Added', utype as 'Added By', company_name as 'Company Name' from stock where company_name = '" + _CompanyName +"' ORDER BY date_added DESC", con);
            SqlDataAdapter fisSDA = new SqlDataAdapter(fisCMD);
            DataTable fisDT = new DataTable();
            fisSDA.Fill(fisDT);
            inStockDataView.DataSource = fisDT;
            con.Close();
        }

        private void inStock_Load(object sender, EventArgs e)
        {
            FillInStockData();
            if (_User != "admin")
            {
                lblAddNewItem.Visible = false; // Prevent non admin user from clicking on 'Add New Item'
            }
        }

        private void lblAddNewItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            addItems newItems = new addItems(_login, _UserID, _User, _CompanyName);
            newItems.ShowDialog();
        }

        public void searchByItemIS()
        {
            con.Open();
            SqlCommand isStock = new SqlCommand("select itemid as ItemID, iname as 'Item Name', description as Description, category as Category, qty as Available, brand as Brand, price as 'Price(NGN)', date_added as 'Date Added', utype as 'Added By', company_name as 'Company Name' from stock where iname LIKE '%" + txtItemNameIS.Text + "%' AND company_name = '" + _CompanyName + "'", con);
            SqlDataAdapter isDA = new SqlDataAdapter(isStock);
            DataTable isDT = new DataTable();
            isDA.Fill(isDT);

            inStockDataView.DataSource = isDT;
            con.Close();
        }

        public void searchByDateIS()
        {
            con.Open();
            SqlCommand isStock = new SqlCommand("select itemid as ItemID, iname as 'Item Name', description as Description, category as Category, qty as Available, brand as Brand, price as Price, date_added as 'Date Added', utype as 'Added By', company_name as 'Company Name' from stock where date_added BETWEEN '"+ startFromISDate.Value +"' AND '"+ endAtISDate.Value +"' AND company_name = '" + _CompanyName + "' ORDER BY date_added DESC", con);
            SqlDataAdapter isDA = new SqlDataAdapter(isStock);
            DataTable isDT = new DataTable();
            isDA.Fill(isDT);

            inStockDataView.DataSource = isDT;
            con.Close();
        }
        private void txtSearchItemIconIS_Click(object sender, EventArgs e)
        {
            searchByItemIS();
        }

        private void txtItemNameIS_KeyUp(object sender, KeyEventArgs e)
        {
            searchByItemIS();
        }

        private void dateSearchIconIS_Click(object sender, EventArgs e)
        {
            searchByDateIS();
        }

        private void inStockRefreshIcon_Click(object sender, EventArgs e)
        {
            FillInStockData();
        }

        private void btnCloseStock_Click(object sender, EventArgs e)
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

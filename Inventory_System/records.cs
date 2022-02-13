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
    public partial class records : Form
    {
        private login _login;
        public string _UserID;
        public string _User;
        public string _CompanyName;
        public records(login login, string userID, string user, string companyName)
        {
            InitializeComponent();
            _login = login;
            _UserID = userID;
            _User = user;
            _CompanyName = companyName;

            //PREVENT DEFAULT BLUE SELECTION OF CELL FROM RECEIPTDGVIEW
            recordsDataGridView.DefaultCellStyle.SelectionBackColor = Color.White;
            recordsDataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
        SqlConnection con = new SqlConnection("Data Source = localhost; Initial Catalog = Inventory; Integrated Security = True");

        public void FillRecordsData()
        {
            if(_User == "admin")
            {
                con.Open();
                SqlCommand frdCMD = new SqlCommand("select transaction_id as 'TxnID', qty as Quantity, iname as 'Item Name', description as Description, brand as Brand, uprice as 'Unit Price(NGN)', cost as 'Cost(NGN)', sub_total as 'Sub Total(NGN)', total as 'Total(NGN)', discount as 'Discount %', ptype as 'Payment Method', utype as 'User Role', date as Date, company_name as 'Company Name' from sales where company_name = '" + _CompanyName + "' and NOT iname = '' ORDER BY date DESC", con);
                SqlDataAdapter frdSDA = new SqlDataAdapter(frdCMD);
                DataTable frdDT = new DataTable();
                frdSDA.Fill(frdDT);
                recordsDataGridView.DataSource = frdDT;
                con.Close();
            }
            else
            {
                con.Open();
                SqlCommand frdCMD = new SqlCommand("select transaction_id as 'TxnID', qty as Quantity, iname as 'Item Name', description as Description, brand as Brand, uprice as 'Unit Price(NGN)', cost as 'Cost(NGN)', sub_total as 'Sub Total(NGN)', total as 'Total(NGN)', discount as 'Discount %', ptype as 'Payment Method', date as Date, company_name as 'Company Name' from sales where  utype = '" + _User + "' and userid = '" + _UserID + "' and company_name = '" + _CompanyName + "' and NOT iname = '' ORDER BY date DESC", con);
                SqlDataAdapter frdSDA = new SqlDataAdapter(frdCMD);
                DataTable frdDT = new DataTable();
                frdSDA.Fill(frdDT);
                recordsDataGridView.DataSource = frdDT;
                con.Close();
            }
            
        }
        private void records_Load(object sender, EventArgs e)
        {
            FillRecordsData();
        }

        private void btnCloseRecords_Click(object sender, EventArgs e)
        {
            DialogResult saleConfirm;
            saleConfirm = MessageBox.Show("Are you sure you want to close?", "Inventory System", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (saleConfirm == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void searchRecordsByDate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand srbdCMD = new SqlCommand("select transaction_id as 'TxnID', qty as Quantity, iname as 'Item Name', description as Description, brand as Brand, uprice as 'Unit Price(NGN)', cost as 'Cost(NGN)', sub_total as 'Sub Total(NGN)', total as 'Total(NGN)', discount as 'Discount %', ptype as 'Payment Method', date as Date, company_name as 'Company Name' from sales where date BETWEEN '" + startDateValue.Value + "' AND '"+ endDateValue.Value +"' AND company_name = '" + _CompanyName + "' ORDER BY date DESC", con);
            SqlDataAdapter srbdDA = new SqlDataAdapter(srbdCMD);
            DataTable srbdDT = new DataTable();
            srbdDA.Fill(srbdDT);

            recordsDataGridView.DataSource = srbdDT;
            con.Close();
        }
    }
}

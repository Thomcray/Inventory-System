using System;
using System.Collections;
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
    public partial class settings : Form
    {
        public string couponCode;
        public int _couponValue;
        public int _couponExpiry;
        //
        private login _login;
        public string _UserID;
        public string _User;
        public string _CompanyName;
        public settings(login login, string userID, string user, string companyName)
        {
            InitializeComponent();
            _login = login;
            _UserID = userID;
            _User = user;
            _CompanyName = companyName;
        }

        SqlConnection con = new SqlConnection("Data Source = localhost; Initial Catalog = Inventory; Integrated Security = True");

        private void settings_Load(object sender, EventArgs e)
        {
            getCoupon_Details();
            couponMsgPanel.Visible = false;
        }

        public void createCoupon()
        {
            couponCode = txtCoupon.Text;
            _couponValue = (int)couponValue.Value;
            _couponExpiry = (int)couponExpiryDay.Value;

            if (couponCode == "" || _couponValue == 0 || _couponExpiry == 0)
            {
                couponMsgPanel.Visible = true;
                couponMsgPanel.BackColor = Color.Red;
                couponMsg.Text = "All fields are required";
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand couponCMD = new SqlCommand("insert into coupon_details(coupon_name, value, date_created, expiry_date, validity, userid, utype, company_name) values('" + couponCode + "', '" + _couponValue + "', getdate(), DATEADD(day, Convert(int, '"+ _couponExpiry +"'), getdate()), '" + _couponExpiry + "', '" + _UserID + "', '" + _User + "', '" + _CompanyName + "')", con);
                    couponCMD.ExecuteNonQuery();
                    con.Close();
                    couponMsgPanel.Visible = true;
                    couponMsgPanel.BackColor = Color.DarkSeaGreen;
                    couponMsg.Text = "Coupon created successfully.";
                    getCoupon_Details();

                    txtCoupon.Clear(); _couponValue = 0; _couponExpiry = 0;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
        }

        public void getCoupon_Details()
        {
            try
            {
                con.Open();
                SqlCommand getCouponCMD = new SqlCommand("select id as CouponID, coupon_name as Coupon, value as 'Value %', date_created as 'Date Created', expiry_date as 'Expiry Date', validity as 'Validity (Days)', company_name as 'Company Name' from coupon_details where company_name = '"+ _CompanyName +"' AND utype = 'admin' ORDER BY date_created DESC", con);
                SqlDataAdapter couponSDA = new SqlDataAdapter(getCouponCMD);
                DataTable couponDT = new DataTable();
                couponSDA.Fill(couponDT);

                couponDetailsGrid.DataSource = couponDT;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnCreateCoupon_Click(object sender, EventArgs e)
        {
            createCoupon();
        }

        private void btnCloseSettings_Click_1(object sender, EventArgs e)
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

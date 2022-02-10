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
    public partial class sales : Form
    {
        public string itemID;
        public int qtySale;
        public decimal discount;
        public string discount_value;
        public string itemName;
        public string type;
        public string brandLabel;
        public string price;
        public string priceQty;
        public string searchText;

        public string txtTxnID_;

        // Get the current date.
        DateTime thisDay = DateTime.Now;
        //
        private login _login;
        public string _UserID { get; set; }
        public string _User { get; set; }
        public string _CompanyName { get; set; }

        public sales(login login, string userID, string user, string companyName)
        {
            this.ShowInTaskbar = false;
            InitializeComponent();
            _login = login;
            _UserID = userID;
            _User = user;
            _CompanyName = companyName;

            listViewTable.ColumnCount = 7;
            listViewTable.Columns[0].Name = "Item ID";
            listViewTable.Columns[1].Name = "Qty";
            listViewTable.Columns[2].Name = "Item Name";
            listViewTable.Columns[3].Name = "Description";
            listViewTable.Columns[4].Name = "Brand";
            listViewTable.Columns[5].Name = "Unit Price";
            listViewTable.Columns[6].Name = "Cost";
            //
            checkDiscountValid();

            //PREVENT DEFAULT BLUE SELECTION OF CELL FROM LISTVIEWTABLE
            listViewTable.DefaultCellStyle.SelectionBackColor = Color.White;
            listViewTable.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
        SqlConnection con = new SqlConnection("Data Source = localhost; Initial Catalog = Inventory; Integrated Security = True");
        private void sales_Load(object sender, EventArgs e)
        {
            //
            genTxnID();
            //
            saleDiscount();
            //
            txtItemID.ReadOnly = true;
            txtItemName.ReadOnly = true;
            txtDescription.ReadOnly = true;
            txtItemAvailable.ReadOnly = true;
            txtBrandlabel.ReadOnly = true;
            txtUnitPrice.ReadOnly = true;
            txtCost.ReadOnly = true;
            txtSaleDiscount.ReadOnly = true;
            txtSubTotal.ReadOnly = true;
            txtTxnID.ReadOnly = true;
            salesMgsPanel.Visible = false;
            discountMsgPanel.Visible = false;

            //this prevent adding empty row after populated row
            listViewTable.AllowUserToAddRows = false;
        }

        public void fillListBox()
        {
            itemID = txtItemID.Text;
            qtySale = (int)saleQty.Value;
            itemName = txtItemName.Text;
            type = txtDescription.Text;
            brandLabel = txtBrandlabel.Text;
            price = txtUnitPrice.Text;
            priceQty = txtCost.Text;

            try
            {
                if (itemID == "" || qtySale < 1 || itemName == "" || type == "" || brandLabel == ""
                    || txtUnitPrice.Text == "" || txtCost.Text == "")
                {
                    MessageBox.Show("Enter all fields");
                }
                else if (Convert.ToInt32(txtItemAvailable.Text) == 0)
                {
                    MessageBox.Show("OUT OF STOCK");
                    return;
                }
                else if (Convert.ToInt32(txtItemAvailable.Text) < qtySale)
                {
                    MessageBox.Show("Check available quantity");
                    return;
                }
                else
                {
                    if (Convert.ToInt32(txtItemAvailable.Text) < 5 || Convert.ToInt32(txtItemAvailable.Text) == 1)
                    {
                        MessageBox.Show("Available quantity is low. please update");
                        listViewTable.Rows.Add(itemID, qtySale, itemName, type, brandLabel, price, priceQty);
                        //Check for discount then calculate method
                        saleDiscount();
                    }
                    else
                    {
                        //
                        listViewTable.Rows.Add(itemID, qtySale, itemName, type, brandLabel, price, priceQty);
                        //Check for discount then calculate method
                        saleDiscount();
                    }
                    
                }
                txtItemID.Clear(); saleQty.Value = 0; txtItemName.Clear(); txtDescription.Clear(); txtBrandlabel.Clear(); txtUnitPrice.Clear(); txtCost.Clear();
                txtSearchSale.Clear(); txtItemAvailable.Clear();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void checkDiscountValid()
        {
            // Get coupon name and coupon value from database
            con.Open();
            SqlCommand discountCMD = new SqlCommand("select TOP 1 coupon_name, value, date_created, expiry_date, DAY(expiry_date) as expiryDay, validity from coupon_details where company_name = '" + _CompanyName + "' ORDER BY id DESC", con);
            SqlDataReader discountReader;
            discountReader = discountCMD.ExecuteReader();
            while (discountReader.Read())
            {
                DateTime dateCreated = Convert.ToDateTime(discountReader["date_created"]);
                string coupon_ = discountReader["coupon_name"].ToString();
                string _couponValue = discountReader["value"].ToString();
                string _expiryDate_ = discountReader["expiry_date"].ToString();
                string _expiryDay = discountReader["expiryDay"].ToString();
                //Check if thisDay Time&Date equals _expiryDate_ to discard discount
                if (thisDay > Convert.ToDateTime(_expiryDate_))
                {
                    txtSaleDiscount.Text = "";
                    lblDiscountName.Text = "";
                    discountMsgPanel.Visible = true;
                    lblDBExpiryDate.Text = "Coupon has expired";
                    //this.Hide();
                }
                else
                {
                    lblDiscountName.Text = coupon_ + " is applied";
                    txtSaleDiscount.Text = _couponValue;
                    lblDBExpiryDate.Text = _expiryDate_;
                }
            }
            con.Close();
        }
        private void btnAddSaleList_Click(object sender, EventArgs e)
        {
            fillListBox();
        }

        private void removeListItemIcon_Click(object sender, EventArgs e)
        {
            try
            {
                string removeItem = listViewTable.CurrentRow.Cells[0].Value.ToString();
                //muDisplayGrid.Rows.RemoveAt(muDisplayGrid.CurrentCell.RowIndex);
                if (removeItem == "")
                {
                    //muPanel.Visible = false;
                    MessageBox.Show("Select item to remove from list.");
                    return;
                }
                else
                {
                    con.Open();
                    SqlCommand updStockQty = new SqlCommand("update stock set qty = qty + '" + listViewTable.CurrentRow.Cells[1].Value.ToString() + "' where itemid = '" + listViewTable.CurrentRow.Cells[0].Value.ToString() + "' AND company_name = '" + _CompanyName + "'", con);
                    updStockQty.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //
            try
            {

                double sum = 0;
                listViewTable.Rows.RemoveAt(listViewTable.CurrentCell.RowIndex);
                for (int i = 0; i < listViewTable.Rows.Count; i++)
                {
                    sum += Convert.ToDouble(listViewTable.Rows[i].Cells[6].Value);

                }
                lblTotalListItem.Text = sum.ToString();
                txtSubTotal.Text = sum.ToString();
                //Calculate discount after an item is removed from the list
                discount = Convert.ToInt32(txtSubTotal.Text) - (Convert.ToInt32(discount_value) * Convert.ToInt32(txtSubTotal.Text)) / 100;
                lblTotalListItem.Text = Convert.ToString(discount);
                // Clear fields
                txtItemID.Clear(); saleQty.Value = 0; txtItemName.Clear(); txtDescription.Clear(); txtBrandlabel.Clear(); txtCost.Clear();
                searchResultView.Visible = false;
                txtSearchSale.Clear(); txtItemAvailable.Clear();
            }
            catch (Exception)
            {

                MessageBox.Show("Empty List.");
            }
        }

        //Discount Method -----------------------------------------------------------------------------------//
        public void saleDiscount()
        {
            try
            {
                discount_value = txtSaleDiscount.Text;
                // Check discount
                if (discount_value != "")
                {
                    double sum = 0;
                    for (int i = 0; i < listViewTable.Rows.Count; i++)
                    {
                        sum += Convert.ToDouble(listViewTable.Rows[i].Cells[6].Value);
                    }
                    lblTotalListItem.Text = sum.ToString();
                    txtSubTotal.Text = sum.ToString();
                    searchResultView.Visible = false;
                    /// Calculate discount
                    discount = Convert.ToInt32(txtSubTotal.Text) - (Convert.ToInt32(discount_value) * Convert.ToInt32(txtSubTotal.Text)) / 100;
                    lblTotalListItem.Text = Convert.ToString(discount);
                    //// Subtract qty item bought from available in database when item is added to list
                    //// Method call Here -------------------------------------//
                    refreshQtyNeg();
                    //Remove discountMsgpanel if discount is applied
                    discountMsgPanel.Visible = true;
                }
                else
                {
                    double sum = 0;
                    for (int i = 0; i < listViewTable.Rows.Count; i++)
                    {
                        sum += Convert.ToDouble(listViewTable.Rows[i].Cells[6].Value);
                    }
                    lblTotalListItem.Text = sum.ToString();
                    txtSubTotal.Text = sum.ToString();
                    searchResultView.Visible = false;
                    //// Subtract qty item bought from available in database when item is added to list
                    //// Method call Here -------------------------------------//
                    refreshQtyNeg();
                    //Remove discountMsgpanel if discount is not applied
                    discountMsgPanel.Visible = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        //Generate new txnID method
        public void genTxnID()
        {
            con.Open();
            SqlCommand idCMD_1 = new SqlCommand("select MAX(transaction_id) as 'TxnID' from sales where company_name = '" + _CompanyName + "'", con);
            SqlDataReader idReader;
            idReader = idCMD_1.ExecuteReader();
            while (idReader.Read())
            {
                int defaultTxnID;
                int newTxnID;
                string txn_ID = idReader["TxnID"].ToString();
                if (txn_ID == "")
                {
                    defaultTxnID = 100000;
                    txtTxnID.Text = Convert.ToString(defaultTxnID);

                }
                else
                {
                    newTxnID = Convert.ToInt32(txn_ID) + 1;
                    txtTxnID.Text = Convert.ToString(newTxnID);
                }
            }
            con.Close();
        }
        private void btnPaymentMethod_Click(object sender, EventArgs e)
        {
            Button btnPay = (Button)sender;
            
            if (txtSubTotal.Text == "")
            {
                MessageBox.Show("Empty list.");
                return;
            }
            else
            {
                try
                {
                    //generate new txnID when sale is successful
                    genTxnID();
                    for (int i = 0; i < listViewTable.Rows.Count; i++)
                    {
                        con.Open();
                        SqlCommand saleCMD = new SqlCommand("insert into sales(item_id, transaction_id, qty, iname, description, brand, uprice, cost, sub_total, discount, total, ptype, date, utype, userid, company_name) values('" + listViewTable.Rows[i].Cells[0].Value + "', '"+ txtTxnID.Text +"', '" + listViewTable.Rows[i].Cells[1].Value + "', '" + listViewTable.Rows[i].Cells[2].Value + "', '" + listViewTable.Rows[i].Cells[3].Value + "', '" + listViewTable.Rows[i].Cells[4].Value + "', '" + listViewTable.Rows[i].Cells[5].Value + "', '" + listViewTable.Rows[i].Cells[6].Value + "', '" + txtSubTotal.Text + "', '"+ txtSaleDiscount.Text +"', '" + lblTotalListItem.Text + "', '" + btnPay.Text + "', getdate(), '" + _User + "', '" + _UserID + "', '" + _CompanyName + "')", con);
                        saleCMD.ExecuteNonQuery();
                        MessageBox.Show(Convert.ToString(listViewTable.Rows[i].Cells[0].Value));
                        con.Close();
                        salesMgsPanel.Visible = true;
                    }
                    listViewTable.Rows.Clear();
                    lblSalesMsgs.Text = "Success. Receipt ready for printing";
                    print();
                }
                catch (Exception ex)
                {

                    lblSalesMsgs.Text = ex.Message;
                }
            }
            
        }
        //Print Method
        public void print()
        {
            receiptView receipt = new receiptView();
            receipt.ReceiptNo = txtTxnID.Text;
            receipt.ShowDialog();
        }

        //// Subtract qty item bought from available in database when item is added to list
        //// Program Here -------------------------------------//
        public void refreshQtyNeg()
        {
            try
            {
                con.Open();
                SqlCommand updStockQty1 = new SqlCommand("update stock set qty -= '" + saleQty.Text + "' where itemid = '" + txtItemID.Text + "' AND company_name = '" + _CompanyName + "'", con);
                updStockQty1.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void txtSearchSale_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                searchText = txtSearchSale.Text;
                con.Open();
                SqlCommand searchCMD = new SqlCommand("select itemid as ItemID, iname as 'Item Name', description as Description, category as Category, qty as Available, brand as Brand, price as Price from stock where (iname Like '%" + searchText + "%' or description Like '%" + searchText + "%' or brand Like '%" + searchText + "%' or price Like '%" + searchText + " %') AND company_name = '" + _CompanyName + "'", con);
                SqlDataAdapter searchSDA = new SqlDataAdapter(searchCMD);
                con.Close();
                DataTable SDT = new DataTable();
                searchSDA.Fill(SDT);
                searchResultView.DataSource = SDT;
                searchResultView.Visible = true;
                checkDiscountValid();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void searchResultView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtItemID.Text = searchResultView.CurrentRow.Cells[0].Value.ToString();
                txtItemName.Text = searchResultView.CurrentRow.Cells[1].Value.ToString();
                txtDescription.Text = searchResultView.CurrentRow.Cells[2].Value.ToString();
                txtItemAvailable.Text = searchResultView.CurrentRow.Cells[4].Value.ToString();
                txtBrandlabel.Text = searchResultView.CurrentRow.Cells[5].Value.ToString();
                txtUnitPrice.Text = searchResultView.CurrentRow.Cells[6].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void saleQty_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                double cost;
                cost = (int)saleQty.Value * Convert.ToInt32(txtUnitPrice.Text);
                txtCost.Text = Convert.ToString(cost);
            }
            catch (Exception)
            {
                if (txtUnitPrice.Text == "")
                {
                    MessageBox.Show("Unit price field is empty");
                }
            }
        }

        private void btnCloseSale_Click(object sender, EventArgs e)
        {
            try
            {
                string itemOnList = listViewTable.CurrentRow.Cells[0].Value.ToString();
                if (itemOnList != "")
                {
                    MessageBox.Show("Remove item from list before closing.");
                    return;
                }
            }
            catch (Exception)
            {
                // Instead of handling exception, it should display the code below
                DialogResult saleConfirm;
                saleConfirm = MessageBox.Show("Are you sure you want to close?", "Inventory System", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (saleConfirm == DialogResult.Yes)
                {
                    this.Hide();
                }
            }
        }

        private void btnRemoveDMP_Click(object sender, EventArgs e)
        {
            discountMsgPanel.Visible = false;
        }
    }
}

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
    public partial class addItems : Form
    {
        public int a_itemID;
        public string a_itemName;
        public string a_desc;
        public string a_category;
        public int a_qty;
        public string a_brandLabel;
        public string a_price;
        public DateTime date_added;

        //
        private login _login;
        public string _UserID;
        public string _User;
        public string _CompanyName;
        public addItems(login login, string userID, string user, string companyName)
        {
            InitializeComponent();

            _login = login;
            _UserID = userID;
            _User = user;
            _CompanyName = companyName;

            //PREVENT DEFAULT BLUE SELECTION OF CELL FROM UPDATEITEMVIEW
            updateItemView.DefaultCellStyle.SelectionBackColor = Color.White;
            updateItemView.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        SqlConnection con = new SqlConnection("Data Source = localhost; Initial Catalog = Inventory; Integrated Security = True");


        private void btnAddNewItems_Click(object sender, EventArgs e)
        {
            a_itemID = Convert.ToInt32(txtNewItemID.Text);
            a_itemName = txtNewItemName.Text;
            a_desc = txtNewItemDesc.Text;
            a_category = txtNewCategoryCombo.Text;
            a_qty = (int)intNewQty.Value;
            a_brandLabel = txtNewBrand.Text;
            a_price = txtNewPrice.Text;
            date_added = newDateAdded.Value;

            try
            {
                if (a_qty < 1 || a_itemName == "" || a_desc == "" || a_brandLabel == ""
                    || a_category == "" || a_price == "")
                {
                    addItemMsgPanel.Visible = true;
                    addItemMsgPanel.BackColor = Color.Red;
                    lblAddItemMsg.Text = "Enter all fields";


                }
                else
                {
                    con.Open();
                    SqlCommand addCMD = new SqlCommand("insert into stock(itemid, iname, description, category, qty, brand, price, date_added, utype, userid, company_name) values('" + a_itemID + "', '" + a_itemName + "', '" + a_desc + "', '" + a_category + "', '" + a_qty + "', '" + a_brandLabel + "', '" + a_price + "', getdate(), '" + _User + "', '" + _UserID + "', '" + _CompanyName + "')", con);
                    addCMD.ExecuteNonQuery();
                    con.Close();

                    addItemMsgPanel.Visible = true;
                    addItemMsgPanel.BackColor = Color.DarkSeaGreen;
                    lblAddItemMsg.Text = "Item added successfully";
                    genItemID();
                }
                a_qty = 0; txtNewItemName.Clear(); txtNewItemDesc.Clear(); txtNewPrice.Clear();
                //addedItemsDB();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void categoryDropDown()
        {
            // Get category item from database
            con.Open();
            SqlCommand cddCMD = new SqlCommand("select cname from category where userid = '" + _UserID + "' and company_name = '" + _CompanyName + "'", con);
            SqlDataReader cddReader;
            cddReader = cddCMD.ExecuteReader();

            while (cddReader.Read())
            {
                string _category = cddReader["cname"].ToString();
                txtNewCategoryCombo.Items.Add(_category);
            }
            con.Close();
        }
        public void brandDropDown()
        {
            // Get brand name from database
            con.Open();
            SqlCommand bddCMD = new SqlCommand("select company_name from users where id = '" + _UserID + "' and company_name = '" + _CompanyName + "'", con);
            SqlDataReader bddReader;
            bddReader = bddCMD.ExecuteReader();

            while (bddReader.Read())
            {
                string _companyName_ = bddReader["company_name"].ToString();
                txtNewBrand.Text = _companyName_;
            }
            con.Close();
        }

        private void addItems_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryDataSet.stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.inventoryDataSet.stock);
            txtNewItemID.ReadOnly = true;
            txtNewBrand.ReadOnly = true;
            categoryDropDown();
            brandDropDown();
            addItemMsgPanel.Visible = false;
            genItemID();
            //addedItemsDB();
        }

        private void btnCloseAddItems_Click(object sender, EventArgs e)
        {
            DialogResult saleConfirm;
            saleConfirm = MessageBox.Show("Are you sure you want to close?", "Inventory System", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (saleConfirm == DialogResult.Yes)
            {
                this.Hide();
            }
        }
        //Generate ItemID method
        public void genItemID()
        {
            con.Open();
            SqlCommand idCMD_1 = new SqlCommand("select MAX(itemid) as 'MaxID' from stock where company_name = '" + _CompanyName + "'", con);
            SqlDataReader idReader;
            idReader = idCMD_1.ExecuteReader();
            while (idReader.Read())
            {
                int defaultID;
                int newID;
                string stockID = idReader["MaxID"].ToString();
                if (stockID == "")
                {
                    defaultID = 1;
                    txtNewItemID.Text = Convert.ToString(defaultID);
                    
                }
                else
                {
                    newID = Convert.ToInt32(stockID) + 1;
                    txtNewItemID.Text = Convert.ToString(newID);
                }
            }
            con.Close();
        }

        private void updateItemView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Update item if button in column 5(Update) is triggered
            if(e.ColumnIndex == 6)
            {
                try
                {
                    string updID = updateItemView.CurrentRow.Cells[0].Value.ToString();
                    string updName = updateItemView.CurrentRow.Cells[1].Value.ToString();
                    string updQty = updateItemView.CurrentRow.Cells[2].Value.ToString();
                    string updPrice = updateItemView.CurrentRow.Cells[3].Value.ToString();

                    con.Open();
                    SqlCommand uivCMD = new SqlCommand("update stock set iname = '"+ updName +"', qty = '"+ updQty +"', price = '"+ updPrice +"', date_updated = getdate() where company_name = '"+ _CompanyName +"' AND itemid = '"+ updID +"'", con);
                    uivCMD.ExecuteNonQuery();
                    MessageBox.Show("Item updated successfully.");
                    con.Close();
                    this.Hide();
                }
                catch (Exception  ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

    }        
}

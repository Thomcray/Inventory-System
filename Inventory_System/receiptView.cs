using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class receiptView : Form
    {
        public string Date, ReceiptNo;
        SqlConnection con = new SqlConnection("Data Source = localhost; Initial Catalog = Inventory; Integrated Security = True");

        public receiptView()
        {
            InitializeComponent();
            //Date = DateTime.Now.ToString("M/d/yyyy");
            Date = DateTime.Now.ToString();
            receipDGView.ReadOnly = true;
            //PREVENT DEFAULT BLUE SELECTION OF CELL FROM RECEIPTDGVIEW
            receipDGView.DefaultCellStyle.SelectionBackColor = Color.White;
            receipDGView.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
        // method to print content in panelPrint
        private void Print(Panel pn1)
        {
            PrinterSettings ps = new PrinterSettings();
            panelPrint = pn1;
            getprintarea(pn1);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();
        }

        private Bitmap memoryimg;
        private void getprintarea(Panel pn1)
        {
            memoryimg = new Bitmap(pn1.Width, pn1.Height);
            pn1.DrawToBitmap(memoryimg, new Rectangle(0, 0, pn1.Width, pn1.Height));
        }
        private void printIcon_Click(object sender, EventArgs e)
        {
            Print(this.panelPrint);
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pageArea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pageArea.Width / 2) - (this.panelPrint.Width / 2), this.panelPrint.Location.Y);
        }

        private void receiptView_Load(object sender, EventArgs e)
        {
            receiptRead();
            
        }

        private void printIcon_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(printIcon, "print");
        }
        
        public void receiptRead()
        {
            try
            {
                con.Open();
                lblRDate.Text = Date;
                lblRNumber.Text = ReceiptNo;
                SqlCommand receiptCMD = new SqlCommand("select iname AS 'Item Name', qty AS Qty, uprice AS 'Unit Price', cost AS Cost from sales where transaction_id = '"+ lblRNumber.Text +"'", con);
                SqlDataAdapter receiptDA = new SqlDataAdapter(receiptCMD);
                DataTable receiptDT = new DataTable();
                receiptDA.Fill(receiptDT);
                receipDGView.DataSource = receiptDT;

                // Get usertype, companyname, subtotal, total, discount 
                SqlCommand receiptCMD_1 = new SqlCommand("select utype, company_name, sub_total, discount, total from sales where transaction_id = '" + lblRNumber.Text + "'", con);
                SqlDataReader receiptReader_1;
                receiptReader_1 = receiptCMD_1.ExecuteReader();
                while (receiptReader_1.Read())
                {
                    lblAttendant_.Text = receiptReader_1["utype"].ToString();
                    lblCompanyNameR.Text = (receiptReader_1["company_name"].ToString() + " Clothings").ToUpper();
                    lblSubtotal_.Text = receiptReader_1["sub_total"].ToString();
                    lblDiscount_.Text = receiptReader_1["discount"].ToString();
                    lblTotal_.Text = receiptReader_1["total"].ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
    }
}

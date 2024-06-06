using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterLimited
{
    public partial class PurchaseOrderPrint : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user id =root;password=;database=betterlimited");
        MySqlCommand cmd;
        MySqlDataAdapter adpt;
        DataTable dt;
        string sql;
        string OrderID;
        string purchaseOrderID;

        public PurchaseOrderPrint()
        {
            InitializeComponent();

        }

        public void openConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void closeConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        public string getOrderID
        {
            get
            {
                return OrderID;
            }
        }

        public string setOrderID
        {
            set
            {
                OrderID = value;
            }
        }
        public void DisplayTable()
        {
            sql = "SELECT p.ItemID, i.ItemName, p.Qty, i.SupplierPrice, p.Qty*i.SupplierPrice AS Total " +
                "FROM purchaseorder_item p, item i " +
                "WHERE p.ItemID = i.ItemID AND p.PurchaseOrderID = '"+ purchaseOrderID +"';";
            openConnection();
            cmd = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dgvPurchaseDetails.DataSource = tb1;

            closeConnection();
        }

        public void countTotal()
        {
            int total = 0;
            for (int i = 0; i< dgvPurchaseDetails.RowCount; i++)
            {
                
                total += Convert.ToInt32(dgvPurchaseDetails.Rows[i].Cells[4].Value);
                

            }
            TotalPriceLbl.Text ="Total:  $" + total.ToString();
        }

        Bitmap bmp;
        public void Print()
        {
            purchaseOrderID = getOrderID;

            sql = "SELECT p.PurchaseOrderID, p.OrderDate, p.OrderTime, s.SupplierName, s.Address " +
                "FROM purchaseorder p, Supplier s " +
                "WHERE p.SupplierID = s.SupplierID AND p.PurchaseOrderID = '" + purchaseOrderID + "';";
            cmd = new MySqlCommand(sql, conn);
            openConnection();
            MySqlDataReader reader = cmd.ExecuteReader();


            if (reader.Read())
            {
                OrderIDLbl.Text = reader["PurchaseOrderID"].ToString();
                DateLbl.Text = reader["OrderDate"].ToString();
                TimeLbl.Text = reader["OrderTime"].ToString();
                supplierNameLbl.Text = reader["SupplierName"].ToString();
                addressLbl.Text = reader["Address"].ToString();


            }
            closeConnection();
            DisplayTable();
            countTotal();
            var createControl = this.GetType().GetMethod("CreateControl", BindingFlags.Instance | BindingFlags.NonPublic);
            createControl.Invoke(this, new object[] { true });

            Graphics myGraphics = this.CreateGraphics();
            bmp = new Bitmap(this.Width, this.Height, myGraphics);
            this.DrawToBitmap(bmp, new Rectangle(0, 0, 900, 1000));

            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Custom", 850, 900);
            printPreviewDialog1.Size = new Size(800, 900);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void dgvPurchaseDetails_SelectionChanged(object sender, EventArgs e)
        {
            dgvPurchaseDetails.ClearSelection();
        }
    }
}

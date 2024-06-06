using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterLimited
{
    public partial class PurchaseInvoiceForm : Form
    {
        // Setting for MySql Database.
        MySqlConnection conn = new MySqlConnection("server=localhost;user id =root;password=;database=betterlimited");
        MySqlCommand command;
        MySqlDataAdapter adpt;
        DataTable dt;
        string sql = "SELECT po.PurchaseOrderID,  po.SupplierID, OrderDate, SUM(poi.Qty * i.SupplierPrice) AS Total FROM purchaseorder po, purchaseorder_item poi, item i WHERE po.PurchaseOrderID = poi.PurchaseOrderID AND poi.ItemID = i.ItemID AND OrderStatus = 'Done' GROUP BY po.PurchaseOrderID";
        string itemID, staffID, department, position, purchaseorderID;
        int itemSearch;


        public string getItemID
        {
            get
            {
                return itemID;
            }
        }
        public string setStaffID
        {
            set
            {
                staffID = value;
            }
        }
        public string getStaffID
        {
            get
            {
                return staffID;
            }
        }

        public string setDepartment
        {
            set
            {
                department = value;
            }
        }

        public string getDepartment
        {
            get
            {
                return department;
            }
        }
        public string setPosition
        {
            set
            {
                position = value;
            }
        }

        public string getPosition
        {
            get
            {
                return position;
            }
        }
        public PurchaseInvoiceForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            showData(sql);
            cbxItemSearch.SelectedIndex = 0;


        }

        public void showData(string sql)
        {
            try
            {
                openConnection();
                command = new MySqlCommand(sql, conn);
                adpt = new MySqlDataAdapter(command);
                dt = new DataTable();
                adpt.Fill(dt);
                dgvPurchaseInvoice.DataSource = dt;
                /*switch (department)
                {
                    case "Inventory":
                    case "Admin":
                    case "CEO":
                        this.dgvPurchaseInvoice.Columns["UpdateLowLevel"].Visible = true;
                        this.dgvPurchaseInvoice.Columns["ReOrder"].Visible = true;
                        break;
                    default:
                        this.dgvPurchaseInvoice.Columns["UpdateLowLevel"].Visible = false;
                        this.dgvPurchaseInvoice.Columns["ReOrder"].Visible = false;
                        break;
                }*/
                dgvPurchaseInvoice.DefaultCellStyle.ForeColor = Color.Blue;
                dgvPurchaseInvoice.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPurchaseInvoice.DefaultCellStyle.Font = new Font("Microsoft YaHei", 9);
                closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                closeConnection();
            }
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            switch (itemSearch)
            {
                case 0:
                    sql = "SELECT po.PurchaseOrderID,  po.SupplierID, OrderDate, SUM(poi.Qty * i.SupplierPrice) AS Total FROM purchaseorder po, purchaseorder_item poi, item i WHERE po.PurchaseOrderID = poi.PurchaseOrderID AND poi.ItemID = i.ItemID AND OrderStatus = 'Done' AND po.PurchaseOrderID LIKE '%" + this.txtSearch.Text + "%' GROUP BY po.PurchaseOrderID";
                    showData(sql);
                    break;

            }
        }

        private void dgvPurchaseInvoice_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                {
                    e.Value = "Details";
                }
                else
                {

                    e.Value = Properties.Settings.Default.DetailsZh;

                }
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbxItemSearch.SelectedIndex == 0)
            {
                if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
                {
                    e.Handled = true;
                }
            }
        }

        private void InventoryStockLevelForm_Shown(object sender, EventArgs e)
        {
            showData(sql);
        }

        private void dgvPurchaseInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                purchaseorderID = dgvPurchaseInvoice.Rows[e.RowIndex].Cells[1].Value.ToString();
                PurchaseOrderRecord porform = new PurchaseOrderRecord();
                porform.showDetails(purchaseorderID);
                porform.Show();
            }
        }

        private void dgvPurchaseInvoice_SelectionChanged(object sender, EventArgs e)
        {
            dgvPurchaseInvoice.ClearSelection();
        }
    }
}

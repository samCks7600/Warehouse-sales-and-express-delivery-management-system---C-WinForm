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
    public partial class CreateGoodsReceivedNote : Form
    {
        // Setting for MySql Database.
        MySqlConnection conn = new MySqlConnection("server=localhost;user id =root;password=;database=betterlimited;");
        MySqlCommand command;
        MySqlDataAdapter adpt;
        DataTable dt;
        string sql = "SELECT * FROM purchaseorder";
        string itemID, staffID, department, position, purchaseOrderID, supplierID;
        int itemSearch, qty, addQty;


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
        public string selectQueryValue(string sql, string column)
        {
            command = conn.CreateCommand();
            command.CommandText = sql;
            try
            {
                openConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                return reader.GetString(column);
            }
            else
            {
                closeConnection();
                return null;
            }
        }

        public CreateGoodsReceivedNote()
        {
            InitializeComponent();
            showData(sql);
            cbxPOSearch.SelectedIndex = 0;
            btnCreate.Visible = false;
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
                dgvPurchaseOrder.DataSource = dt;
                switch (department)
                {
                    case "Inventory":
                    case "Admin":
                    case "CEO":
                        this.dgvPurchaseOrder.Columns["Receive"].Visible = true;
                        break;
                    default:
                        this.dgvPurchaseOrder.Columns["Receive"].Visible = false;
                        break;
                }

                dgvPurchaseOrder.DefaultCellStyle.ForeColor = Color.Blue;
                dgvPurchaseOrder.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPurchaseOrder.DefaultCellStyle.Font = new Font("Microsoft YaHei", 9);
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

        private void txtPOSearch_TextChanged(object sender, EventArgs e)
        {
            switch (itemSearch)
            {
                case 0:
                    sql = "SELECT PurchaseOrderID, StaffID, SupplierID, OrderDate, OrderTime, OrderStatus FROM purchaseorder WHERE PurchaseOrderID LIKE '%" + this.txtPOSearch.Text + "%'";
                    showData(sql);
                    break;
                case 1:
                    sql = "SELECT PurchaseOrderID, StaffID, SupplierID, OrderDate, OrderTime, OrderStatus FROM purchaseorder WHERE StaffID LIKE '%" + this.txtPOSearch.Text + "%'";
                    showData(sql);
                    break;
                case 2:
                    sql = "SELECT PurchaseOrderID, StaffID, SupplierID, OrderDate, OrderTime, OrderStatus FROM purchaseorder WHERE SupplierID LIKE '%" + this.txtPOSearch.Text + "%'";
                    showData(sql);
                    break;
            }
        }

        private void txtPOSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvpoi in dgvPurchaseOrderItem.Rows)
            {
                DataGridViewCheckBoxCell cb = dgvpoi.Cells[0] as DataGridViewCheckBoxCell;

                if (Convert.ToBoolean(cb.Value) == true)
                {
                    itemID = dgvpoi.Cells[1].Value.ToString();
                    addQty = Int32.Parse(dgvpoi.Cells[3].Value.ToString());

                    sql = "SELECT Quantity from inventorystocklevel where itemID = '" + itemID + "';";
                    command = new MySqlCommand(sql, conn);
                    openConnection();
                    var queryResult = command.ExecuteScalar();
                    if (queryResult != null)
                    {
                        qty = Convert.ToInt32(queryResult);
                        using (command = new MySqlCommand())
                        {
                            command.Connection = conn;
                            command.CommandText = @"UPDATE inventorystocklevel SET Quantity = '" + (qty + addQty) + "' WHERE itemID = '" + itemID + "';";
                            command.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        qty = 0;
                    }
                    closeConnection();
                }
                else
                {
                    string issueItemID = dgvpoi.Cells[1].Value.ToString();
                    if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                    {
                        MessageBox.Show("Item ID: " + issueItemID + " not received. Please contact to the supplier.");
                    }
                    else
                    {
                        MessageBox.Show(issueItemID + Properties.Settings.Default.NotRecSupplierZh);
                    }
                }
            }

            using (conn)
            {
                openConnection();
                using (command = new MySqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = @"INSERT INTO goodsreceivednote (ReceivedID, PurchaseOrderID, SupplierID, InboundDate, InboundTime) VALUES (@ReceivedID, @PurchaseOrderID, @SupplierID, @InboundDate, @InboundTime);" +
                                           "UPDATE purchaseorder SET OrderStatus = 'Done' WHERE PurchaseOrderID = '" + purchaseOrderID + "';";

                    command.Parameters.AddWithValue("@ReceivedID", null);
                    command.Parameters.AddWithValue("@PurchaseOrderID", purchaseOrderID);
                    command.Parameters.AddWithValue("@SupplierID", supplierID);
                    command.Parameters.AddWithValue("@InboundDate", DateTime.Now.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@InboundTime", DateTime.Now.ToString("HH:mm:ss"));
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                    string receivedID = getReceivedID();
                    if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                    {
                        MessageBox.Show("Goods received note created successfully.\nReceived ID: " + receivedID);
                    }
                    else
                    {
                        MessageBox.Show(Properties.Settings.Default.RecCreateSucZh + receivedID);
                    }
                }
                closeConnection();
            }
            sql = "SELECT * FROM purchaseorder";
            showData(sql);
            while (dgvPurchaseOrderItem.RowCount > 0) { dgvPurchaseOrderItem.Rows.RemoveAt(0); }
            lblDetails.Text = "Purchase Order Details";
            btnCreate.Visible = false;
        }

        private void dgvPurchaseOrder_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex == this.dgvPurchaseOrder.NewRowIndex)
                return;

            if (e.ColumnIndex == 0)
            {
                if (dgvPurchaseOrder.Rows[e.RowIndex].Cells[6].Value.ToString() == "Done")
                {
                    e.Value = "Details";
                }

            }
        }

        public string getReceivedID()
        {
            string sql = "SELECT ReceivedID FROM goodsreceivednote ORDER BY ReceivedID DESC LIMIT 1;";
            return selectQueryValue(sql, "ReceivedID");
        }

        private void cbxPOSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemSearch = cbxPOSearch.SelectedIndex;
            txtPOSearch.Text = "";
        }

        private void CreateGoodsReceivedNote_Shown(object sender, EventArgs e)
        {
            showData(sql);
        }

        private void dgvPurchaseOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                purchaseOrderID = dgvPurchaseOrder.Rows[e.RowIndex].Cells[1].Value.ToString();
                supplierID = dgvPurchaseOrder.Rows[e.RowIndex].Cells[3].Value.ToString();
                lblDetails.Text = "Purchase Order Details: " + purchaseOrderID;
                if (dgvPurchaseOrder.Rows[e.RowIndex].Cells[6].Value.ToString() == "Pending")
                {
                    btnCreate.Visible = true;
                    dgvPurchaseOrderItem.Columns["ItemReceived"].Visible = true;
                }
                else
                {
                    btnCreate.Visible = false;
                    dgvPurchaseOrderItem.Columns["ItemReceived"].Visible = false;
                }

                try
                {
                    openConnection();
                    sql = "SELECT poi.ItemID, i.ItemName, poi.Qty FROM purchaseorder_item poi, item i WHERE poi.ItemID = i.ItemID AND PurchaseOrderID = '" + purchaseOrderID + "';";
                    command = new MySqlCommand(sql, conn);
                    adpt = new MySqlDataAdapter(command);
                    dt = new DataTable();
                    adpt.Fill(dt);
                    dgvPurchaseOrderItem.DataSource = dt;

                    dgvPurchaseOrderItem.DefaultCellStyle.ForeColor = Color.Blue;
                    dgvPurchaseOrderItem.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvPurchaseOrderItem.DefaultCellStyle.Font = new Font("Microsoft YaHei", 9);
                    closeConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    closeConnection();
                }
            }
        }

        private void dgvPurchaseOrder_SelectionChanged(object sender, EventArgs e)
        {
            dgvPurchaseOrder.ClearSelection();
        }
        private void dgvPurchaseOrderItem_SelectionChanged(object sender, EventArgs e)
        {
            dgvPurchaseOrderItem.ClearSelection();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                MenuForm menuform = Application.OpenForms["MenuForm"] as MenuForm;
                GoodsReceivedNoteRecord grnrform = new GoodsReceivedNoteRecord();
                if (menuform != null)
                {
                    menuform.setStaffID = getStaffID;
                    menuform.setDepartment = getDepartment;
                    menuform.setPosition = getPosition;
                    menuform.loadform(grnrform);
                }
            }
        }
    }
}
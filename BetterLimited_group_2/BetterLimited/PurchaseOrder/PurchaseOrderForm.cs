using MySql.Data.MySqlClient;
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
using BetterLimited;
using System.Reflection;
using System.Drawing.Printing;
using System.Threading;

namespace BetterLimited {
    public partial class PurchaseOrderForm : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user id =root;password=;database=betterlimited");
        MySqlConnection thisConn = new MySqlConnection("server=localhost;user id =root;password=;database=betterlimited");
        MySqlCommand cmd;
        MySqlDataAdapter adpt;
        DataTable dt;
        string sql = "SELECT ReorderRequestID, StaffID, RequestDate, RequestTime FROM reorderrequest WHERE RequestStatus ='Pending';";
        string staffID, department, position, supplierID, reorderRequestID, OrderID;
        int itemSearch;

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
        public string getDepartment
        {
            get
            {
                return department;
            }
        }

        public string setDepartment
        {
            set
            {
                department = value;
            }
        }

        public string getPosition
        {
            get
            {
                return position;
            }
        }
        public string setPosition
        {
            set
            {
                position = value;
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
        public void showData(string sql)
        {
            try
            {
                openConnection();
                cmd = new MySqlCommand(sql, conn);
                adpt = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                adpt.Fill(dt);
                dgvSelectItem.DataSource = dt;
                switch (department)
                {
                    case "Purchase":
                    case "Admin":
                    case "CEO":
                        this.dgvSelectItem.Columns["purchase"].Visible = true;
                        btnSendRequest.Visible = true;
                        btnClear.Visible = true;
                        break;
                    default:
                        this.dgvSelectItem.Columns["purchase"].Visible = false;
                        btnSendRequest.Visible = false;
                        btnClear.Visible = false;
                        break;
                }
                dgvSelectItem.DefaultCellStyle.ForeColor = Color.Blue;
                dgvSelectItem.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvSelectItem.DefaultCellStyle.Font = new Font("Microsoft YaHei", 9);

                closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                closeConnection();
            }
        }
        public PurchaseOrderForm()
        {
            InitializeComponent();
        }

        private void btnReOrderRecor_Click(object sender, EventArgs e)
        {
            PurchaseOrderRecord POR = new PurchaseOrderRecord();
            POR.setStaffID = getStaffID;
            POR.setDepartment = getDepartment;
            POR.setPosition = getPosition;
            POR.Show();
        }

        private void cbxItemSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemSearch = cbxItemSearch.SelectedIndex;
            txtItemSearch.Text = "";
        }

        private void txtItemSearch_TextChanged(object sender, EventArgs e)
        {
            switch (itemSearch)
            {
                case 0:
                    sql = "SELECT ReorderRequestID, StaffID, RequestDate, RequestTime FROM reorderrequest WHERE RequestStatus ='Pending'AND ReorderRequestID LIKE '%" + this.txtItemSearch.Text + "%'";
                    showData(sql);
                    break;
                case 1:
                    sql = "SELECT ReorderRequestID, StaffID, RequestDate, RequestTime FROM reorderrequest WHERE RequestStatus ='Pending'AND StaffID LIKE '%" + this.txtItemSearch.Text + "%'";
                    showData(sql);
                    break;
            }

        }

        private void PurchaseOrderForm_Load(object sender, EventArgs e)
        {
            showData(sql);
        }

        private void dgvSelectItem_SelectionChanged(object sender, EventArgs e)
        {
            dgvSelectItem.ClearSelection();
        }

        private void dgvPurchaseOrder_SelectionChanged(object sender, EventArgs e)
        {
            dgvPurchaseOrder.ClearSelection();
        }

        private void dgvSelectItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Add
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                reorderRequestID = dgvSelectItem.Rows[e.RowIndex].Cells[1].Value.ToString();
                sql = "SELECT ReorderRequestID, StaffID, RequestDate, RequestTime FROM reorderrequest WHERE RequestStatus ='Pending' AND ReorderRequestID !=" + reorderRequestID;
                openConnection();
                cmd = new MySqlCommand(sql, conn);
                adpt = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                adpt.Fill(dt);
                dgvSelectItem.DataSource = dt;
                if (dgvPurchaseOrder.RowCount == 0)
                {
                    sql = "SELECT ReorderRequestID, item.SupplierID, reorderrequest_item.ItemID, item.ItemName, Qty FROM reorderrequest_item,item " +
                        "WHERE item.ItemID = reorderrequest_item.ItemID AND ReorderRequestID =" + reorderRequestID;

                    cmd = new MySqlCommand(sql, conn);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        RRID.Text = reader.GetValue(0).ToString();
                        var supplierID = reader.GetValue(1);
                        var itemID = reader.GetValue(2);
                        var itemName = reader.GetValue(3);
                        var qty = reader.GetValue(4);
                        dgvPurchaseOrder.Rows.Add(supplierID.ToString(), itemID.ToString(), itemName.ToString(), qty.ToString());
                    }


                    closeConnection();
                }
                else
                {
                    openConnection();
                    dgvPurchaseOrder.Rows.Clear();
                    sql = "SELECT ReorderRequestID, item.SupplierID, reorderrequest_item.ItemID, item.ItemName, Qty FROM reorderrequest_item,item " +
                        "WHERE item.ItemID = reorderrequest_item.ItemID AND ReorderRequestID =" + reorderRequestID;

                    cmd = new MySqlCommand(sql, conn);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        RRID.Text = reader.GetValue(0).ToString();
                        var supplierID = reader.GetValue(1);
                        var itemID = reader.GetValue(2);
                        var itemName = reader.GetValue(3);
                        var qty = reader.GetValue(4);
                        dgvPurchaseOrder.Rows.Add(supplierID.ToString(), itemID.ToString(), itemName.ToString(), qty.ToString());
                    }
                    closeConnection();

                }

            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvPurchaseOrder.Rows.Clear();
            sql = "SELECT ReorderRequestID, StaffID, RequestDate, RequestTime FROM reorderrequest WHERE RequestStatus ='Pending';";
            showData(sql);
        }

        public string selectQueryValue(string sql, string column)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            try
            {
                openConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MySqlDataReader reader = cmd.ExecuteReader();
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

        public string getPurchaseOrderID()
        {
            string sql = "SELECT PurchaseOrderID FROM purchaseorder ORDER BY PurchaseOrderID DESC LIMIT 1;";
            return selectQueryValue(sql, "PurchaseOrderID");
        }

        private void btnSendRequest_Click(object sender, EventArgs e)
        {
            if (dgvPurchaseOrder.RowCount == 0)
            {
                MessageBox.Show("Purchase unsuccessfully.");
            }
            else
            {
                Dictionary<string, List<PurchaseItem>> supplierMap = new Dictionary<string, List<PurchaseItem>>();

                for (int i = 0; i < dgvPurchaseOrder.RowCount; i++)
                {
                    supplierID = dgvPurchaseOrder.Rows[i].Cells[0].Value.ToString();
                    if (!supplierMap.ContainsKey(supplierID))
                    {
                        List<PurchaseItem> items = new List<PurchaseItem>();
                        PurchaseItem item = new PurchaseItem(
                            dgvPurchaseOrder.Rows[i].Cells[0].Value.ToString(),
                            dgvPurchaseOrder.Rows[i].Cells[1].Value.ToString(),
                            dgvPurchaseOrder.Rows[i].Cells[2].Value.ToString(),
                            dgvPurchaseOrder.Rows[i].Cells[3].Value.ToString());
                        items.Add(item);
                        supplierMap.Add(supplierID, items);
                    }
                    else
                    {
                        List<PurchaseItem> items = supplierMap[supplierID];
                        PurchaseItem item = new PurchaseItem(
                            dgvPurchaseOrder.Rows[i].Cells[0].Value.ToString(),
                            dgvPurchaseOrder.Rows[i].Cells[1].Value.ToString(),
                            dgvPurchaseOrder.Rows[i].Cells[2].Value.ToString(),
                            dgvPurchaseOrder.Rows[i].Cells[3].Value.ToString());
                        items.Add(item);
                        supplierMap[supplierID] = items;
                    }
                }
                foreach (KeyValuePair<string, List<PurchaseItem>> entry in supplierMap)
                {
                    string supplierID = entry.Key;
                    List<PurchaseItem> data = entry.Value;
                    try
                    {
                        openConnection();
                        sql = "INSERT INTO purchaseorder (PurchaseOrderID, StaffID, SupplierID, OrderDate, OrderTime, OrderStatus) VALUES (@PurchaseOrderID, @StaffID, @SupplierID, @OrderDate, @OderTime, 'Pending');";
                        cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@PurchaseOrderID", null);
                        cmd.Parameters.AddWithValue("@StaffID", getStaffID);
                        cmd.Parameters.AddWithValue("@SupplierID", supplierID);
                        cmd.Parameters.AddWithValue("@OrderDate", DateTime.Now.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@OderTime", DateTime.Now.ToString("HH:mm:ss"));
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        string purchaseOrderID = getPurchaseOrderID();
                        OrderID = purchaseOrderID;

                        closeConnection();
                        for (int j = 0; j < data.Count; j++)
                        {
                            try
                            {
                                openConnection();
                                sql = "INSERT INTO purchaseorder_item (PurchaseOrderID, ReorderRequestID, ItemID, Qty) VALUES (@PurchaseOrderID, @ReorderRequestID, @ItemID, @Qty);";
                                cmd = new MySqlCommand(sql, conn);
                                cmd.Parameters.AddWithValue("@PurchaseOrderID", purchaseOrderID);
                                cmd.Parameters.AddWithValue("@ReorderRequestID", RRID.Text);
                                cmd.Parameters.AddWithValue("@ItemID", data[j].itemID);
                                cmd.Parameters.AddWithValue("@Qty", data[j].qty);
                                cmd.ExecuteNonQuery();
                                cmd.Parameters.Clear();

                                closeConnection();
                            }
                            catch (Exception ex)
                            {

                                closeConnection();

                            }
                        }

                        PurchaseOrderPrint POP = new PurchaseOrderPrint();
                        POP.setOrderID = getOrderID;
                        POP.Print();
                    }
                    catch (Exception ex)
                    {
                        if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                        {
                            MessageBox.Show("Purchase unsuccessfully. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show(Properties.Settings.Default.PurchaseUnZh + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        closeConnection();

                    }

                }
                MessageBox.Show("Purchase Order successfully.", "Purchase Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvPurchaseOrder.Rows.Clear();
                RRID.Text = "";
                try
                {
                    openConnection();
                    sql = "UPDATE reorderrequest SET RequestStatus = 'Done' WHERE ReorderRequestID = '" + RRID.Text + "';";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    closeConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    closeConnection();

                }
            }
            
        }
        public void addPurchaseOrder(string orderID)
        {
            openConnection();
            sql = "SELECT ReorderRequestID, item.SupplierID, reorderrequest_item.ItemID, item.ItemName, Qty FROM reorderrequest_item,item " +
                       "WHERE item.ItemID = reorderrequest_item.ItemID AND ReorderRequestID =" + orderID;

            cmd = new MySqlCommand(sql, conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                RRID.Text = reader.GetValue(0).ToString();
                var supplierID = reader.GetValue(1);
                var itemID = reader.GetValue(2);
                var itemName = reader.GetValue(3);
                var qty = reader.GetValue(4);
                dgvPurchaseOrder.Rows.Add(supplierID.ToString(), itemID.ToString(), itemName.ToString(), qty.ToString());
            }


            closeConnection();
            sql = "SELECT ReorderRequestID, StaffID, RequestDate, RequestTime FROM reorderrequest WHERE RequestStatus ='Pending';";
            showData(sql);
        }
    }
}
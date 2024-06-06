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
    public partial class ReOrderRequestForm : Form
    {
        // Setting for MySql Database.
        MySqlConnection conn = new MySqlConnection("server=localhost;user id =root;password=;database=betterlimited");
        MySqlCommand command;
        MySqlDataAdapter adpt;
        DataTable dt;
        string sql = "SELECT i.ItemID, i.ItemName, isl.Quantity , isl.LowLevelQty FROM inventorystocklevel isl, item i WHERE i.ItemID = isl.ItemID";
        string itemID, staffID, department, position;
        int itemSearch;

        public string getItemID
        {
            get
            {
                return itemID;
            }
        }

        public string getStaffID
        {
            get
            {
                return staffID;
            }
        }

        public string setStaffID
        {
            set
            {
                staffID = value;
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

        public ReOrderRequestForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            showData(sql);
            cbxItemSearch.SelectedIndex = 0;
            dgvReOrderRequest.DefaultCellStyle.ForeColor = Color.Blue;
            dgvReOrderRequest.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvReOrderRequest.DefaultCellStyle.Font = new Font("Microsoft YaHei", 9);
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

        public void showData(string sql)
        {
            try
            {
                openConnection();
                command = new MySqlCommand(sql, conn);
                adpt = new MySqlDataAdapter(command);
                dt = new DataTable();
                adpt.Fill(dt);
                dgvSelect.DataSource = dt;

                switch (position)
                {
                    case "Inventory Manager":
                    case "Inventory Clerk":
                    case "Admin":
                    case "CEO":                               
                        this.dgvSelect.Columns["ReOrder"].Visible = true;
                        btnClear.Visible = true;
                        btnSendRequest.Visible = true;
                        break;
                    default:
                        this.dgvSelect.Columns["ReOrder"].Visible = false;
                        btnClear.Visible = false;
                        btnSendRequest.Visible = false;
                        break;
                }
                dgvSelect.DefaultCellStyle.ForeColor = Color.Blue;
                dgvSelect.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvSelect.DefaultCellStyle.Font = new Font("Microsoft YaHei", 9);
                checkStock();
                closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                closeConnection();
            }
        }

        private void checkStock()
        {
            int quantity;
            int lowLevel;
            for (int i = 0; i < dgvSelect.Rows.Count; i++)
            {
                quantity = Convert.ToInt32(dgvSelect.Rows[i].Cells[3].Value.ToString());
                lowLevel = Convert.ToInt32(dgvSelect.Rows[i].Cells[4].Value.ToString());
                if (quantity < lowLevel)
                {
                    dgvSelect.Rows[i].Cells[3].Style.BackColor = Color.LightCoral;
                    dgvSelect.Rows[i].Cells[3].Style.Font = new Font("Microsoft YaHei", 12, FontStyle.Bold);
                }
                else if (quantity < (lowLevel + 5))
                {
                    dgvSelect.Rows[i].Cells[3].Style.BackColor = Color.LightPink;
                    dgvSelect.Rows[i].Cells[3].Style.Font = new Font("Microsoft YaHei", 12, FontStyle.Bold);
                }
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

        }

        private void InventoryStockLevelForm_Shown(object sender, EventArgs e)
        {
            showData(sql);
        }

        private void dgvSelectItem_SelectionChanged(object sender, EventArgs e)
        {
            dgvSelect.ClearSelection();
        }

        private void txtItemSearch_TextChanged(object sender, EventArgs e)
        {
            switch (itemSearch)
            {
                case 0:
                    sql = "SELECT i.ItemID, i.ItemName, isl.Quantity , isl.LowLevelQty FROM inventorystocklevel isl, item i WHERE i.ItemID = isl.ItemID AND i.ItemID LIKE '%" + this.txtItemSearch.Text + "%'";
                    showData(sql);
                    break;
                case 1:
                    sql = "SELECT i.ItemID, i.ItemName, isl.Quantity , isl.LowLevelQty FROM inventorystocklevel isl, item i WHERE i.ItemID = isl.ItemID AND i.ItemName LIKE '%" + this.txtItemSearch.Text + "%'";
                    showData(sql);
                    break;
            }
        }

        

        public void addReOrderItem(string itemID, string itemName)
        {
            dgvReOrderRequest.Rows.Add(itemID, itemName, "", "1");
        }

        private string addQty(string qty)
        {
            int addQty = Convert.ToInt32(qty);
            addQty++;
            qty = addQty.ToString();
            return qty;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvReOrderRequest.Rows.Clear();
        }

        private string minusQty(string qty)
        {
            int minusQty = Convert.ToInt32(qty);
            if (minusQty > 1)
            {
                minusQty--;
            }
            qty = minusQty.ToString();
            return qty;
        }

        private void btnSendRequest_Click(object sender, EventArgs e)
        {
            if (dgvReOrderRequest.Rows.Count != 0)
            {

                try
                {
                    openConnection();
                    sql = "INSERT INTO reorderrequest (ReorderRequestID, StaffID, RequestDate, RequestTime) VALUES (@ReorderRequestID, @StaffID, @RequestDate, @RequestTime);";
                    command = new MySqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@ReorderRequestID", null);
                    command.Parameters.AddWithValue("@StaffID", staffID);
                    command.Parameters.AddWithValue("@RequestDate", DateTime.Now.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@RequestTime", DateTime.Now.ToString("HH:mm:ss"));
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                    string reOrderRequestID = getReorderRequestID();
                    closeConnection();

                    openConnection();
                    for (int i = 0; i < dgvReOrderRequest.RowCount; i++)
                    {
                        sql = "INSERT INTO reorderrequest_item (ItemID, ReorderRequestID, Qty) VALUES (@ItemID, @ReorderRequestID, @Qty);";
                        command = new MySqlCommand(sql, conn);
                        command.Parameters.AddWithValue("@ItemID", dgvReOrderRequest.Rows[i].Cells[0].Value.ToString());
                        command.Parameters.AddWithValue("@ReorderRequestID", reOrderRequestID);
                        command.Parameters.AddWithValue("@Qty", dgvReOrderRequest.Rows[i].Cells[3].Value.ToString());
                        command.ExecuteNonQuery();
                        command.Parameters.Clear();
                    }
                    closeConnection();
                    if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                    {
                        MessageBox.Show("Re-order request successfully.\nReorderRequestID: " + reOrderRequestID, "Re-order Request", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(Properties.Settings.Default.ReorderSucZh + reOrderRequestID, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                    {
                        MessageBox.Show("Re-order unsuccessfully. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(Properties.Settings.Default.ReorderUnsZh + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                dgvReOrderRequest.Rows.Clear();
            }
            else
            {
                if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                {
                    MessageBox.Show("Please select item(s).");
                }
                else
                {
                    MessageBox.Show(Properties.Settings.Default.SelectItemZh);
                }
            }
        }

        public string getReorderRequestID()
        {
            string sql = "SELECT ReorderRequestID FROM reorderrequest ORDER BY ReorderRequestID DESC LIMIT 1;";
            return selectQueryValue(sql, "ReorderRequestID");
        }

        private void btnReOrderRecord_Click(object sender, EventArgs e)
        {
            ReOrderRequestRecord rorrform = new ReOrderRequestRecord(this);
            rorrform.setStaffID = getStaffID;
            rorrform.setDepartment = getDepartment;
            rorrform.setPosition = getPosition;
            rorrform.Show();
        }

        private void txtItemSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbxItemSearch.SelectedIndex == 0)
            {
                if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
                {
                    e.Handled = true;
                }
            }
        }

        private void ReOrderRequestForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvSelect_SelectionChanged(object sender, EventArgs e)
        {
            dgvSelect.ClearSelection();
        }

        private void dgvSelect_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                if (dgvReOrderRequest.RowCount == 0)
                {
                    dgvReOrderRequest.Rows.Add(dgvSelect.Rows[e.RowIndex].Cells[1].Value.ToString(), dgvSelect.Rows[e.RowIndex].Cells[2].Value.ToString(), "", "1");
                }
                else
                {
                    for (int i = 0; i < dgvReOrderRequest.RowCount; i++)
                    {
                        if (dgvSelect.Rows[e.RowIndex].Cells[1].Value.ToString().Equals(dgvReOrderRequest.Rows[i].Cells[0].Value.ToString()))
                        {
                            dgvReOrderRequest.Rows[i].Cells[3].Value = addQty(dgvReOrderRequest.Rows[i].Cells[3].Value.ToString());
                            return;
                        }
                    }
                    dgvReOrderRequest.Rows.Add(dgvSelect.Rows[e.RowIndex].Cells[1].Value.ToString(), dgvSelect.Rows[e.RowIndex].Cells[2].Value.ToString(), "", "1");
                }
            }
        }

        private void cbxItemSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemSearch = cbxItemSearch.SelectedIndex;
            txtItemSearch.Text = "";
        }

        private void dgvReOrderRequest_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 4 && e.RowIndex != -1)
            {
                dgvReOrderRequest.Rows[e.RowIndex].Cells[3].Value = addQty(dgvReOrderRequest.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            if (e.ColumnIndex == 2 && e.RowIndex != -1)
            {
                if (!dgvReOrderRequest.Rows[e.RowIndex].Cells[3].Value.Equals("1"))
                {
                    dgvReOrderRequest.Rows[e.RowIndex].Cells[3].Value = minusQty(dgvReOrderRequest.Rows[e.RowIndex].Cells[3].Value.ToString());
                }
                else
                {
                    dgvReOrderRequest.Rows.RemoveAt(e.RowIndex);
                }
            }


        }

        private void dgvInventoryStockLevel_SelectionChanged(object sender, EventArgs e)
        {
            dgvReOrderRequest.ClearSelection();
        }
    }
}

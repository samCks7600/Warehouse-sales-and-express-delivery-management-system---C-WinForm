using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterLimited
{
    public partial class RetailStockLevelForm : Form
    {
        // Setting for MySql Database.
        MySqlConnection conn = new MySqlConnection("server=localhost;user id =root;password=;database=betterlimited");
        MySqlCommand command;
        MySqlDataAdapter adpt;
        DataTable dt;
        string sql = "SELECT rsl.itemID, i.itemName, rsl.Quantity, rsl.LowLevelQty FROM retailstocklevel rsl, item i WHERE rsl.itemID = i.itemID AND storeID = 1";
        string itemID, itemName, staffID, department, position, supplierID, storeID = "1";
        int itemSearch;


        public string getItemID
        {
            get
            {
                return itemID;
            }
        }
        public string getStoreID
        {
            get
            {
                return storeID;
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
        public RetailStockLevelForm()
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
                dgvRetailStockLevel.DataSource = dt;
                dgvRetailStockLevel.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvRetailStockLevel.DefaultCellStyle.Font = new Font("Microsoft YaHei", 9);
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
            for (int i = 0; i < dgvRetailStockLevel.Rows.Count; i++)
            {

                quantity = Convert.ToInt32(dgvRetailStockLevel.Rows[i].Cells[4].Value.ToString());
                lowLevel = Convert.ToInt32(dgvRetailStockLevel.Rows[i].Cells[5].Value.ToString());
                if (quantity < lowLevel)
                {
                    dgvRetailStockLevel.Rows[i].Cells[4].Style.BackColor = Color.LightCoral;
                    dgvRetailStockLevel.Rows[i].Cells[4].Style.Font = new Font("Microsoft YaHei", 12, FontStyle.Bold);
                }
                else if (quantity < (lowLevel + 5))
                {
                    dgvRetailStockLevel.Rows[i].Cells[4].Style.BackColor = Color.LightPink;
                    dgvRetailStockLevel.Rows[i].Cells[4].Style.Font = new Font("Microsoft YaHei", 12, FontStyle.Bold);
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
            switch (itemSearch)
            {
                case 0:
                    sql = "SELECT rsl.itemID, i.itemName, rsl.Quantity, rsl.LowLevelQty FROM retailstocklevel rsl, item i WHERE rsl.itemID = i.itemID AND storeID = '" + storeID + "' AND rsl.ItemID LIKE '%" + this.txtSearch.Text + "%'";
                    showData(sql);
                    break;
                case 1:
                    sql = "SELECT rsl.itemID, i.itemName, rsl.Quantity, rsl.LowLevelQty FROM retailstocklevel rsl, item i WHERE rsl.itemID = i.itemID AND storeID = '" + storeID + "' AND i.ItemName LIKE '%" + this.txtSearch.Text + "%'";
                    showData(sql);
                    break;
            }
        }

        private void btnTW_Click(object sender, EventArgs e)
        {
            storeID = "1";
            sql = "SELECT rsl.itemID, i.itemName, rsl.Quantity, rsl.LowLevelQty FROM retailstocklevel rsl, item i WHERE rsl.itemID = i.itemID AND storeID = 1";
            showData(sql);
            label3.Text = "Tsuen Wan Store Stock Level";
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

        private void RetailStockLevelForm_Load(object sender, EventArgs e)
        {
            showData(sql);
        }

        private void btnKB_Click(object sender, EventArgs e)
        {
            storeID = "2";
            sql = "SELECT rsl.itemID, i.itemName, rsl.Quantity, rsl.LowLevelQty FROM retailstocklevel rsl, item i WHERE rsl.itemID = i.itemID AND storeID = 2";
            showData(sql);
            label3.Text = "Kowloon Bay Store Stock Level";
        }

        private void cbxItemSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemSearch = cbxItemSearch.SelectedIndex;
            txtSearch.Text = "";
        }


        private void dgvRetailStockLevel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                itemID = dgvRetailStockLevel.Rows[e.RowIndex].Cells[2].Value.ToString();
                UpdateRetailLowLevelQty urllqfrm = new UpdateRetailLowLevelQty(this);
                urllqfrm.setItemID = getItemID;
                urllqfrm.setStoreID = getStoreID;
                urllqfrm.Show();
            }

            if (e.ColumnIndex == 1 && e.RowIndex != -1)
            {
                MenuForm menuform = Application.OpenForms["MenuForm"] as MenuForm;
                itemID = dgvRetailStockLevel.Rows[e.RowIndex].Cells[2].Value.ToString();
                itemName = dgvRetailStockLevel.Rows[e.RowIndex].Cells[3].Value.ToString();
                supplierID = getSupplierID(itemID);

                if (menuform != null)
                {
                    menuform.setStaffID = getStaffID;
                    menuform.setDepartment = getDepartment;
                    menuform.setPosition = getPosition;
                    menuform.addReStockItem(itemID, itemName, supplierID, storeID);
                }
            }
        }


        private void dgvRetailStockLevel_SelectionChanged(object sender, EventArgs e)
        {
            dgvRetailStockLevel.ClearSelection();
        }

        private string getSupplierID(string itemID)
        {

            openConnection();
            command = new MySqlCommand("SELECT supplierID FROM ITEM WHERE itemID = " + itemID + ";", conn);
            MySqlDataReader reader;
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                supplierID = reader["supplierID"].ToString();
            }
            closeConnection();
            return supplierID;
        }
    }
}

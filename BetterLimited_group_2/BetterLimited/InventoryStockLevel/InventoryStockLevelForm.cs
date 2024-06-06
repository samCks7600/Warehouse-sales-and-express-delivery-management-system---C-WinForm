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
    public partial class InventoryStockLevelForm : Form
    {
        // Setting for MySql Database.
        MySqlConnection conn = new MySqlConnection("server=localhost;user id =root;password=;database=betterlimited");
        MySqlCommand command;
        MySqlDataAdapter adpt;
        DataTable dt;
        string sql = "SELECT isl.ItemID, i.ItemName, isl.Quantity, isl.LowLevelQty FROM inventorystocklevel isl, item i WHERE isl.ItemID = i.ItemID";
        string itemID, itemName, staffID, department, position;
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
        public InventoryStockLevelForm()
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
                dgvInventoryStockLevel.DataSource = dt;

                switch (position)
                {
                    case "Inventory Manager":
                    case "Inventory Clerk":
                    case "Admin":
                    case "CEO":
                        this.dgvInventoryStockLevel.Columns["UpdateLowLevel"].Visible = true;
                        this.dgvInventoryStockLevel.Columns["ReOrder"].Visible = true;
                        break;
                    default:
                        this.dgvInventoryStockLevel.Columns["UpdateLowLevel"].Visible = false;
                        this.dgvInventoryStockLevel.Columns["ReOrder"].Visible = false;
                        break;
                }
                      
                dgvInventoryStockLevel.DefaultCellStyle.ForeColor = Color.Blue;
                dgvInventoryStockLevel.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvInventoryStockLevel.DefaultCellStyle.Font = new Font("Microsoft YaHei", 9);
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
            for (int i = 0; i < dgvInventoryStockLevel.Rows.Count; i++)
            {
                quantity = Convert.ToInt32(dgvInventoryStockLevel.Rows[i].Cells[4].Value.ToString());
                lowLevel = Convert.ToInt32(dgvInventoryStockLevel.Rows[i].Cells[5].Value.ToString());
                if (quantity < lowLevel)
                {
                    dgvInventoryStockLevel.Rows[i].Cells[4].Style.BackColor = Color.LightCoral;
                    dgvInventoryStockLevel.Rows[i].Cells[4].Style.Font = new Font("Microsoft YaHei", 12, FontStyle.Bold);
                }
                else if (quantity < (lowLevel + 5))
                {
                    dgvInventoryStockLevel.Rows[i].Cells[4].Style.BackColor = Color.LightPink;
                    dgvInventoryStockLevel.Rows[i].Cells[4].Style.Font = new Font("Microsoft YaHei", 12, FontStyle.Bold);
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
                    sql = "SELECT isl.ItemID, i.ItemName, isl.Quantity, isl.LowLevelQty FROM inventorystocklevel isl, item i WHERE isl.ItemID = i.ItemID AND i.ItemID LIKE '%" + this.txtSearch.Text + "%'";
                    showData(sql);
                    break;
                case 1:
                    sql = "SELECT isl.ItemID, i.ItemName, isl.Quantity, isl.LowLevelQty FROM inventorystocklevel isl, item i WHERE isl.ItemID = i.ItemID AND i.ItemName LIKE '%" + this.txtSearch.Text + "%'";
                    showData(sql);
                    break;
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

        private void cbxItemSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemSearch = cbxItemSearch.SelectedIndex;
            txtSearch.Text = "";
        }

        private void InventoryStockLevelForm_Shown(object sender, EventArgs e)
        {
            showData(sql);
        }

        private void dgvInventoryStockLevel_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                itemID = dgvInventoryStockLevel.Rows[e.RowIndex].Cells[2].Value.ToString();
                int lowLevelQty;
                UpdateInventoryLowLevelQty uillqfrm = new UpdateInventoryLowLevelQty(this);
                uillqfrm.setItemID = getItemID;
                uillqfrm.Show();
            }

            if (e.ColumnIndex == 1 && e.RowIndex != -1)
            {
                MenuForm menuform = Application.OpenForms["MenuForm"] as MenuForm;
                itemID = dgvInventoryStockLevel.Rows[e.RowIndex].Cells[2].Value.ToString();
                itemName = dgvInventoryStockLevel.Rows[e.RowIndex].Cells[3].Value.ToString();
                ReOrderRequestForm rorform = new ReOrderRequestForm();
                rorform.addReOrderItem(itemID, itemName);
                if (menuform != null)
                {
                    menuform.setStaffID = getStaffID;
                    menuform.setDepartment = getDepartment;
                    menuform.setPosition = getPosition;
                    menuform.addReOrderItem(itemID, itemName);
                }
            }
        }

        private void dgvInventoryStockLevel_SelectionChanged(object sender, EventArgs e)
        {
            dgvInventoryStockLevel.ClearSelection();
        }
    }
}

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
    public partial class GoodsReceivedNoteRecord : Form
    {
        // Setting for MySql Database.
        MySqlConnection conn = new MySqlConnection("server=localhost;user id =root;password=;database=betterlimited");
        MySqlCommand command;
        MySqlDataAdapter adpt;
        DataTable dt, dt1;
        string sql = "SELECT ReceivedID, SupplierID, InboundDate, InboundTime FROM goodsreceivednote";
        string staffID, department, position, receivedID;
        int IDSearch;

        public GoodsReceivedNoteRecord()
        {
            InitializeComponent();
            cbxIDSearch.SelectedIndex = 0;
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

        public bool selectQuery(string sql)
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
                closeConnection();
                return true;
            }
            else
            {
                closeConnection();
                return false;
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
                dgvGoodsReceivedNoteRecord.DataSource = dt;
                switch (department)
                {
                    case "Inventory":
                    case "Admin":
                    case "CEO":
                        btnCreate.Visible = true;
                        break;
                    default:
                        btnCreate.Visible = false;
                        break;
                }
                dgvGoodsReceivedNoteRecord.DefaultCellStyle.ForeColor = Color.Blue;
                dgvGoodsReceivedNoteRecord.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvGoodsReceivedNoteRecord.DefaultCellStyle.Font = new Font("Segoe Print", 9);
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

        private void ReOrderRequestRecord_Load(object sender, EventArgs e)
        {
            showData(sql);
        }

        private void dgvReOrderRecord_SelectionChanged(object sender, EventArgs e)
        {
            dgvGoodsReceivedNoteRecord.ClearSelection();
        }

        private void addToDetails(string receivedID)
        {
            sql = "SELECT i.ItemID, i.ItemName, poi.Qty FROM item i, purchaseorder_item poi, goodsreceivednote grn WHERE grn.ReceivedID = " + receivedID + " AND grn.PurchaseOrderID = poi.PurchaseOrderID AND i.ItemID = poi.ItemID ORDER BY poi.ItemID;";
            label1.Text = "Goods Received Note Details: " + receivedID;
            try
            {
                openConnection();
                command = new MySqlCommand(sql, conn);
                adpt = new MySqlDataAdapter(command);
                dt1 = new DataTable();
                adpt.Fill(dt1);
                dgvGoodsReceivedNoteDetails.DataSource = dt1;

                dgvGoodsReceivedNoteDetails.DefaultCellStyle.ForeColor = Color.Blue;
                dgvGoodsReceivedNoteDetails.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvGoodsReceivedNoteDetails.DefaultCellStyle.Font = new Font("Segoe Print", 9);
                closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                closeConnection();
            }
        }
        private void cbxIDSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            IDSearch = cbxIDSearch.SelectedIndex;
            txtSearch.Text = "";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateGoodsReceivedNote cgrnform = new CreateGoodsReceivedNote();
            cgrnform.setStaffID = getStaffID;
            cgrnform.setDepartment = getDepartment;
            cgrnform.setPosition = getPosition;
            cgrnform.Show();
        }

        private void dgvGoodsReceivedNoteRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    receivedID = dgvGoodsReceivedNoteRecord.Rows[e.RowIndex].Cells[1].Value.ToString();
                    addToDetails(receivedID);
                }
            }
            catch (Exception ex)
            {
                if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                {
                    MessageBox.Show("Click below goods received note to show details.");
                }
                else
                {
                    MessageBox.Show(Properties.Settings.Default.ClickRecDetailsZh);
                }
            }
        }

        private void dgvReOrderDetails_SelectionChanged(object sender, EventArgs e)
        {
            dgvGoodsReceivedNoteDetails.ClearSelection();

        }

        public void closeConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void txtReOrderRecord_TextChanged(object sender, EventArgs e)
        {
            switch (IDSearch)
            {
                case 0:
                    sql = "SELECT ReceivedID, SupplierID, InboundDate, InboundTime FROM goodsreceivednote WHERE ReceivedID LIKE '%" + this.txtSearch.Text + "%'";
                    showData(sql);
                    break;
                case 1:
                    sql = "SELECT ReceivedID, SupplierID, InboundDate, InboundTime FROM goodsreceivednote WHERE SupplierID LIKE '%" + this.txtSearch.Text + "%'";
                    showData(sql);
                    break;
            }
        }
    }
}
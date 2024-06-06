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
    public partial class PurchaseOrderRecord : Form
    {
        // Setting for MySql Database.
        MySqlConnection conn = new MySqlConnection("server=localhost;user id =root;password=;database=betterlimited");
        MySqlCommand cmd;
        MySqlDataAdapter adpt;
        DataTable dt, dt1;
        string sql = "SELECT * FROM purchaseorder";
        string staffID, department, position, PurchaseOrderID;
        int IDSearch;
        public PurchaseOrderRecord()
        {
            InitializeComponent();
        }

        public string getStaffID
        {
            get
            {
                return staffID;
            }
        }

        private void cbxIDSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            IDSearch = cbxIDSearch.SelectedIndex;
            txtPurchaseRecord.Text = "";
        }

        private void txtReOrderRecord_TextChanged(object sender, EventArgs e)
        {
            switch (IDSearch)
            {
                case 0:
                    sql = "SELECT * FROM purchaseorder WHERE PurchaseOrderID LIKE '%" + this.txtPurchaseRecord.Text + "%'";
                    showData(sql);
                    break;
                case 1:
                    sql = "SELECT * FROM purchaseorder WHERE StaffID LIKE '%" + this.txtPurchaseRecord.Text + "%'";
                    showData(sql);
                    break;
                case 2:
                    sql = "SELECT * FROM purchaseorder WHERE SupplierID LIKE '%" + this.txtPurchaseRecord.Text + "%'";
                    showData(sql);
                    break;
            }
        }

        public string setStaffID
        {
            set
            {
                staffID = value;
            }
        }

        private void PurchaseOrderRecord_Load(object sender, EventArgs e)
        {
            showData(sql);
            btnDelete.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteOrder(PurchaseOrderID);
            sql = "SELECT * FROM purchaseorder";
            showData(sql);
            dt1.Rows.Clear();
        }

        private void deleteOrder(string id)
        {
            try
            {
                openConnection();
                sql = "DELETE FROM purchaseorder WHERE PurchaseOrderID = '" + id + "';";
                cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                sql = "DELETE FROM purchaseorder_item WHERE PurchaseOrderID = '" + id + "';";
                cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                {
                    MessageBox.Show("Delete Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(Properties.Settings.Default.ViewStaffDeleteZh, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                {
                    MessageBox.Show("Delete Unsuccessful. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(Properties.Settings.Default.ViewStaffDeleteFailZh + "\n" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            closeConnection();
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

        public void openConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        private void dgvPurchaseRecord_SelectionChanged(object sender, EventArgs e)
        {
            dgvPurchaseRecord.ClearSelection();
        }

        private void dgvPurchaseDetails_SelectionChanged(object sender, EventArgs e)
        {
            dgvPurchaseDetails.ClearSelection();
        }

        public void closeConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
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
                dgvPurchaseRecord.DataSource = dt;
                closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                closeConnection();
            }
        }

        public void addToDetails(string purchaseId)
        {
            sql = "SELECT item.ItemID, item.ItemName, purchaseorder_item.Qty FROM purchaseorder, purchaseorder_item, item " +
                "WHERE purchaseorder.PurchaseOrderID = "+purchaseId+" " +
                "AND purchaseorder.PurchaseOrderID = purchaseorder_item.PurchaseOrderID AND purchaseorder_item.ItemID = item.ItemID;";
            label2.Text = "Purchase Order Details: " + purchaseId;
            try
            {
                openConnection();
                cmd = new MySqlCommand(sql, conn);
                adpt = new MySqlDataAdapter(cmd);
                dt1 = new DataTable();
                adpt.Fill(dt1);
                dgvPurchaseDetails.DataSource = dt1;

                closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                closeConnection();
            }
        }

        public void showDetails(string purchaseId)
        {
            sql = "SELECT item.ItemID, item.ItemName, purchaseorder_item.Qty FROM purchaseorder, purchaseorder_item, item " +
                "WHERE purchaseorder.PurchaseOrderID = " + purchaseId + " " +
                "AND purchaseorder.PurchaseOrderID = purchaseorder_item.PurchaseOrderID AND purchaseorder_item.ItemID = item.ItemID;";
            label2.Text = "Purchase Order Details: " + purchaseId;
            try
            {
                openConnection();
                cmd = new MySqlCommand(sql, conn);
                adpt = new MySqlDataAdapter(cmd);
                dt1 = new DataTable();
                adpt.Fill(dt1);
                dgvPurchaseDetails.DataSource = dt1;

                closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                closeConnection();
            }
            sql = "SELECT * FROM purchaseorder";
            showData(sql);
        }

        private void dgvPurchaseRecord_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                PurchaseOrderID = dgvPurchaseRecord.Rows[e.RowIndex].Cells[1].Value.ToString();
                addToDetails(PurchaseOrderID);
                switch (department)
                {
                    case "Purchase":
                    case "Admin":
                    case "CEO":
                        btnDelete.Visible = true;
                        break;
                    default:
                        btnDelete.Visible = false;
                        break;
                }
            }
        }
    }
}

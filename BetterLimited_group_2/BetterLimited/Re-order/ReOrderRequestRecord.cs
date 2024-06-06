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
    public partial class ReOrderRequestRecord : Form
    {
        // Setting for MySql Database.
        MySqlConnection conn = new MySqlConnection("server=localhost;user id =root;password=;database=betterlimited");
        MySqlCommand command;
        MySqlDataAdapter adpt;
        DataTable dt, dt1;
        string sql = "SELECT * FROM reorderrequest";
        string staffID, department, position, itemID, ReorderRequestID, qty, newQty, orderID, itemName, supplierID;
        int IDSearch;

        public ReOrderRequestRecord(ReOrderRequestForm rorform)
        {
            InitializeComponent();
            cbxIDSearch.SelectedIndex = 0;
            btnDelete.Visible = false;
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
                dgvReOrderRecord.DataSource = dt;
                switch (department)
                {
                    case "Purchase":
                    case "Admin":
                    case "CEO":
                        this.dgvReOrderRecord.Columns["Accept"].Visible = true;
                        break;
                    default:
                        this.dgvReOrderRecord.Columns["Accept"].Visible = false;
                        break;
                }

                for (int i = 0; i < dgvReOrderRecord.Rows.Count; i++)
                {
                    if (dgvReOrderRecord.Rows[i].Cells[6].Value.ToString() == "Done")
                    {
                        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
                        dataGridViewCellStyle2.Padding = new Padding(0, 0, 1000, 0);
                        dgvReOrderRecord.Rows[i].Cells[1].Style = dataGridViewCellStyle2;
                    }
                }

                dgvReOrderRecord.DefaultCellStyle.ForeColor = Color.Blue;
                dgvReOrderRecord.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvReOrderRecord.DefaultCellStyle.Font = new Font("Segoe Print", 9);
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
            dgvReOrderRecord.ClearSelection();
        }

        private void addToDetails(string requestid)
        {
            sql = "SELECT i.ItemID, i.ItemName, ri.Qty FROM reorderrequest ror, reorderrequest_item ri, item i WHERE ror.ReorderRequestID = " + requestid + " AND ror.ReorderRequestID = ri.ReorderRequestID AND ri.ItemID = i.ItemID ORDER BY ri.ItemID;";
            label1.Text = "Re-order Request Details: " + ReorderRequestID;
            btnDelete.Visible = true;
            try
            {
                openConnection();
                command = new MySqlCommand(sql, conn);
                adpt = new MySqlDataAdapter(command);
                dt1 = new DataTable();
                adpt.Fill(dt1);
                dgvReOrderDetails.DataSource = dt1;

                dgvReOrderDetails.DefaultCellStyle.ForeColor = Color.Blue;
                dgvReOrderDetails.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvReOrderDetails.DefaultCellStyle.Font = new Font("Segoe Print", 9);
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
            txtReOrderRecord.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteRequest(ReorderRequestID);
            label1.Text = "Re-order Request Details: ";
            btnDelete.Visible = false;
            sql = "SELECT * FROM reorderrequest";
            showData(sql);
            dt1.Rows.Clear();
        }

        private void deleteRequest(string id)
        {
            try
            {
                openConnection();
                sql = "DELETE FROM reorderrequest WHERE ReorderRequestID = '" + id + "';";
                command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
                sql = "DELETE FROM reorderrequest_item WHERE ReorderRequestID = '" + id + "';";
                command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
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

        private void dgvReOrderRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                openConnection();
                if (e.ColumnIndex == 0 && e.RowIndex != -1)
                {
                    ReorderRequestID = dgvReOrderRecord.Rows[e.RowIndex].Cells[2].Value.ToString();
                    addToDetails(ReorderRequestID);
                }
                else if (e.ColumnIndex == 1 && dgvReOrderRecord.Rows[e.RowIndex].Cells[6].Value.ToString() == "Done")
                {
                    if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                    {
                        MessageBox.Show("Please click the pending re-order request.");
                    }
                    else
                    {
                        MessageBox.Show(Properties.Settings.Default.ClickReorderZh);
                    }
                }
                else
                {
                    MenuForm menuform = Application.OpenForms["MenuForm"] as MenuForm;
                    orderID = dgvReOrderRecord.Rows[e.RowIndex].Cells[2].Value.ToString();

                    try
                    {
                        openConnection();
                        string sql = "SELECT SupplierID, rori.ItemID, i.ItemName, rori.Qty FROM reorderrequest ror, reorderrequest_item rori, item i WHERE ror.ReorderRequestID = rori.ReorderRequestID AND rori.ItemID = i.ItemID AND ror.ReorderRequestID = '" + orderID + "';";
                        command = new MySqlCommand(sql, conn);
                        MySqlDataReader reader;
                        reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            supplierID = reader["SupplierID"].ToString();
                            itemID = reader["ItemID"].ToString();
                            itemName = reader["ItemName"].ToString();
                            qty = reader["Qty"].ToString();
                            closeConnection();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        closeConnection();
                    }
                    // Pass to purchase 
                    PurchaseOrderForm poform = new PurchaseOrderForm();

                    poform.addPurchaseOrder(orderID);
                    Close();
                    if (menuform != null)
                    {
                        menuform.setStaffID = getStaffID;
                        menuform.setDepartment = getDepartment;
                        menuform.setPosition = getPosition;
                        menuform.addPurchaseOrder(orderID);

                    }

                }


            }
            catch (Exception ex)
            {
                if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                {
                    MessageBox.Show("Click below re-order request to show details." + ex);
                }
                else
                {
                    MessageBox.Show(Properties.Settings.Default.ClickRoDetailsZh + ex);
                }
                closeConnection();
            }
        }

        private void dgvReOrderDetails_SelectionChanged(object sender, EventArgs e)
        {
            dgvReOrderDetails.ClearSelection();

        }

        private void dgvReOrderDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                itemID = dgvReOrderDetails.Rows[e.RowIndex].Cells[2].Value.ToString();
                qty = dgvReOrderDetails.Rows[e.RowIndex].Cells[4].Value.ToString();
                if (EditRequestQty(qty))
                {
                    if (newQty == "0")
                    {
                        try
                        {
                            openConnection();
                            sql = "DELETE FROM reorderrequest_item WHERE ItemID = '" + itemID + "' AND ReorderRequestID = '" + ReorderRequestID + "';";
                            command = new MySqlCommand(sql, conn);
                            command.ExecuteNonQuery();
                            if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                            {
                                MessageBox.Show("Update Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(Properties.Settings.Default.UpdateSucZh, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                            {
                                MessageBox.Show("Update Unsuccessful.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show(Properties.Settings.Default.UpdateUnsucZh + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        closeConnection();
                        addToDetails(ReorderRequestID);
                    }
                    else
                    {
                        try
                        {
                            openConnection();
                            sql = "UPDATE reorderrequest_item SET Qty = '" + newQty + "' WHERE ItemID = '" + itemID + "' AND ReorderRequestID = '" + ReorderRequestID + "';";
                            command = new MySqlCommand(sql, conn);
                            command.ExecuteNonQuery();
                            if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                            {
                                MessageBox.Show("Update Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(Properties.Settings.Default.UpdateSucZh, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                            {
                                MessageBox.Show("Update Unsuccessful.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show(Properties.Settings.Default.UpdateUnsucZh + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        closeConnection();
                        addToDetails(ReorderRequestID);
                    }
                }

            }


            if (e.ColumnIndex == 1 && e.RowIndex != -1)
            {
                if (dgvReOrderDetails.Rows.Count > 1)
                {
                    itemID = dgvReOrderDetails.Rows[e.RowIndex].Cells[2].Value.ToString();
                    try
                    {
                        openConnection();
                        sql = "DELETE FROM reorderrequest_item WHERE ItemID = '" + itemID + "' AND ReorderRequestID = '" + ReorderRequestID + "';";
                        command = new MySqlCommand(sql, conn);
                        command.ExecuteNonQuery();
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
                    dgvReOrderDetails.Rows.RemoveAt(e.RowIndex);
                }
                else
                {
                    deleteRequest(ReorderRequestID);
                    dgvReOrderDetails.Rows.RemoveAt(e.RowIndex);
                    label1.Text = "Re-order Request Details: ";
                    btnDelete.Visible = false;
                    sql = "SELECT * FROM reorderrequest";
                    showData(sql);
                }

            }
        }
        public bool EditRequestQty(string qty)
        {
            EditRequestQtyForm testDialog = new EditRequestQtyForm();
            testDialog.textBox1.Text = qty;
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                testDialog.Hide();
                newQty = testDialog.textBox1.Text;
                return true;
            }
            else
            {
                return false;
            }
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
                    sql = "SELECT * FROM reorderrequest WHERE ReorderRequestID LIKE '%" + this.txtReOrderRecord.Text + "%'";
                    showData(sql);
                    break;
                case 1:
                    sql = "SELECT * FROM reorderrequest WHERE StaffID LIKE '%" + this.txtReOrderRecord.Text + "%'";
                    showData(sql);
                    break;
            }

        }
    }
}

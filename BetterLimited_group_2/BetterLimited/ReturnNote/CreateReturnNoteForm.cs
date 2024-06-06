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
using MySql.Data.MySqlClient;

namespace BetterLimited
{
    public partial class CreateReturnNoteForm : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user id =root;password=;database=betterlimited");
        MySqlCommand command;
        string ReturnNoteID;
        string staffID, storeID;

        private ReturnNoteForm _rnf;

        public string getReturnNoteID
        {
            get
            {
                return ReturnNoteID;
            }
        }

        public string setStaffID
        {
            set
            {
                staffID = value;
            }
        }
        //get set StaffID
        public string getStaffID
        {
            get
            {
                return staffID;
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


        public CreateReturnNoteForm(ReturnNoteForm rnf)
        {
            InitializeComponent();
            _rnf = rnf;

        }

        public void DisplayTable()
        {
            string sql = "SELECT SalesOrderID, PaymentStatus, PaidAmt, Date, Time, ExpDate, CustomerID FROM salesorder;";
            openConnection();
            command = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(command);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView_SalesOrderTable.DataSource = tb1;
            closeConnection();
        }

        private void dataGridView_SalesOrderTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                if (dataGridView_ReturnNote.Rows.Count > 0)
                {
                    if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                    {
                        MessageBox.Show("You can't select other sales order when placed item in return note \n please clear the return Note and try again."
                        , "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(Properties.Settings.Default.ReturnCSZh, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return;
                }

                string salesOrderID = dataGridView_SalesOrderTable.Rows[e.RowIndex].Cells[1].Value.ToString();
                label_SelectedOrderID.Text = salesOrderID;
                string sql = "SELECT ItemID,SalePrice,Qty FROM salesorder_item WHERE SalesOrderID = " + salesOrderID + ";";

                openConnection();
                command = new MySqlCommand(sql, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(command);
                DataTable tb2 = new DataTable();
                adp.Fill(tb2);
                dataGridView_OrderItemTable.DataSource = tb2;
                closeConnection();
            }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            string sql;

            if (textBox_Search.Text == "")
            {
                sql = "SELECT SalesOrderID, PaymentStatus, PaidAmt, Date, Time, ExpDate, CustomerID FROM salesorder;";
            }
            else
            {
                sql = "SELECT SalesOrderID, PaymentStatus, PaidAmt, Date, Time, ExpDate, CustomerID FROM salesorder Where SalesOrderID = " + textBox_Search.Text + ";";
            }
            openConnection();
            command = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(command);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView_SalesOrderTable.DataSource = tb1;
            closeConnection();
        }

        private void textBox_Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_Search.Text = "";
            string sql = "SELECT SalesOrderID, PaymentStatus, PaidAmt, Date, Time, ExpDate, CustomerID FROM salesorder;";
            openConnection();
            command = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(command);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView_SalesOrderTable.DataSource = tb1;
            closeConnection();
        }

        private void dataGridView_OrderItemTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (dataGridView_ReturnNote.RowCount == 0)
                {
                    string itemID = dataGridView_OrderItemTable.Rows[e.RowIndex].Cells[1].Value.ToString();
                    int SalesPrice = Int32.Parse(dataGridView_OrderItemTable.Rows[e.RowIndex].Cells[2].Value.ToString());
                    int Qty = Int32.Parse(dataGridView_OrderItemTable.Rows[e.RowIndex].Cells[3].Value.ToString());
                    dataGridView_ReturnNote.Rows.Add(itemID, SalesPrice, "", 1, "", (SalesPrice * 1), "");
                }
                else
                {
                    for (int i = 0; i < dataGridView_ReturnNote.RowCount; i++)
                    {
                        //Use A.Equals(B) to check if(string  A == string B)
                        if (dataGridView_OrderItemTable.Rows[e.RowIndex].Cells[1].Value.ToString()
                            .Equals(dataGridView_ReturnNote.Rows[i].Cells[0].Value.ToString())
                            )
                        {
                            if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                            {
                                MessageBox.Show("this item is already selected", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(Properties.Settings.Default.AlreadyZh, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            return;
                        }

                    }
                    string itemID = dataGridView_OrderItemTable.Rows[e.RowIndex].Cells[1].Value.ToString();
                    int SalesPrice = Int32.Parse(dataGridView_OrderItemTable.Rows[e.RowIndex].Cells[2].Value.ToString());
                    int Qty = Int32.Parse(dataGridView_OrderItemTable.Rows[e.RowIndex].Cells[3].Value.ToString());
                    dataGridView_ReturnNote.Rows.Add(itemID, SalesPrice, "", 1, "", (SalesPrice * 1), "");

                }
                calculateAmount();

            }
        }

        private void dataGridView_ReturnNote_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int qty;
            int SalesPrice;
            string itemID;
            qty = Int32.Parse(dataGridView_ReturnNote.Rows[e.RowIndex].Cells[3].Value.ToString());
            itemID = dataGridView_ReturnNote.Rows[e.RowIndex].Cells[0].Value.ToString();
            SalesPrice = Int32.Parse(dataGridView_ReturnNote.Rows[e.RowIndex].Cells[1].Value.ToString());

            //add
            if (e.ColumnIndex == 2 && e.RowIndex != -1)
            {
                try
                {
                    foreach (DataGridViewRow row in dataGridView_OrderItemTable.Rows)
                    {
                        if (row.Cells[3].Value.ToString().Equals(qty.ToString()) && itemID.Equals(row.Cells[1].Value.ToString()))
                        {
                            if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                            {
                                MessageBox.Show("This order have not that much item quantity", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(Properties.Settings.Default.ItmQtyZh, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }                            
                            return;
                        }
                    }

                    qty++;

                    dataGridView_ReturnNote.Rows[e.RowIndex].Cells[3].Value = qty;
                    dataGridView_ReturnNote.Rows[e.RowIndex].Cells[5].Value = qty * SalesPrice;

                    calculateAmount();

                }
                catch (Exception ex)
                {
                    if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                    {
                        MessageBox.Show("Qty can't be null \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(Properties.Settings.Default.QtyNullZh + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                    
                }
                calculateAmount();
            }
            //remove
            if (e.ColumnIndex == 4 && e.RowIndex != -1)
            {
                try
                {
                    if (qty == 1)
                    {
                        if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                        {
                            MessageBox.Show("This item Qty can't smaller than 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(Properties.Settings.Default.SmallThanOneZh, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        return;
                    }
                    else
                    {
                        qty--;

                        dataGridView_ReturnNote.Rows[e.RowIndex].Cells[3].Value = qty;
                        dataGridView_ReturnNote.Rows[e.RowIndex].Cells[5].Value = qty * SalesPrice;

                        calculateAmount();
                    }
                }
                catch (Exception ex)
                {
                    if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                    {
                        MessageBox.Show("Qty can't be null \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(Properties.Settings.Default.QtyNullZh + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            //delete
            if (e.ColumnIndex == 6 && e.RowIndex != -1)
            {
                dataGridView_ReturnNote.Rows.RemoveAt(e.RowIndex);
                calculateAmount();
            }
        }

        private void calculateAmount()
        {

            int amount = 0;
            foreach (DataGridViewRow row in dataGridView_ReturnNote.Rows)
            {
                amount += Int32.Parse(row.Cells[5].Value.ToString());
            }

            if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
            {
                label_TotalReturnAmount.Text = "Return Amount : $ " + amount;
            }
            else
            {
                label_TotalReturnAmount.Text = Properties.Settings.Default.ReturnAmtZh + amount;
            }
            
        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            if (dataGridView_ReturnNote.Rows.Count == 0)
            {
                if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                {
                    MessageBox.Show("You have not items in Return Note.");
                }
                else
                {
                    MessageBox.Show(Properties.Settings.Default.ReturnHvZh);
                }                
                return;
            }
            if (cbxStore.SelectedItem == null)
            {
                if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                {
                    MessageBox.Show("You have not select the store for place Return Note.");
                }
                else
                {
                    MessageBox.Show(Properties.Settings.Default.ReturnNoSelZh);
                }                
                return;
            }
            else
            {
                string itemID;
                string qty;
                AddReturnNoteRecord();
                for (int i = 0; i < dataGridView_ReturnNote.RowCount; i++)
                {
                    //Use A.Equals(B) to check if(string  A == string B)
                    itemID = dataGridView_ReturnNote.Rows[i].Cells[0].Value.ToString();
                    qty = dataGridView_ReturnNote.Rows[i].Cells[3].Value.ToString();
                    Insert_data(itemID, qty);
                }
                MessageBox.Show("Submit Successfuly. \n" + "restockRequestID : " + ReturnNoteID, "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Create Goods Return Note
                frmGdsRtnNote rtnNote = new frmGdsRtnNote(Int32.Parse(ReturnNoteID));
                rtnNote.Print();
            }
            _rnf.DisplayTable();
            this.Hide();
            return;

        }

        //<<get the RestorckRequestRecordID>> then  <<Add item to RestorckRequestRecord_item>>
        private void Insert_data(string itemID, string Quantity)
        {

            //select the newest ID first
            string sql = "SELECT MAX(ReturnNoteID) FROM goodreturnnote;";

            openConnection();
            command = new MySqlCommand(sql, conn);
            MySqlDataReader reader;
            reader = command.ExecuteReader();

            if (reader.Read())
            {
                ReturnNoteID = reader["MAX(ReturnNoteID)"].ToString();
            }
            else
            {
                MessageBox.Show("Submit unuccessfuly. \n  Debug:line 196 \n  method : Insert_data()\n" + ReturnNoteID, "Information",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            closeConnection();


            //Insert to ID that We selected
            sql = "INSERT INTO goodreturnnote_item ( ReturnNoteID , ItemID , Qty ) VALUES (@returnNoteID,@itemID,@qty);";
            openConnection();

            command = new MySqlCommand(sql, conn);
            command.Parameters.AddWithValue("returnNoteID", ReturnNoteID);
            command.Parameters.AddWithValue("itemID", itemID);
            command.Parameters.AddWithValue("qty", Quantity);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Submit unuccessfuly. \n Debug:line 322 \n  method : Insert_data()\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            closeConnection();

        }



        public void AddReturnNoteRecord()
        {
            if (cbxStore.SelectedIndex == 0)
            {
                storeID = "1";
            }
            if (cbxStore.SelectedIndex == 1)
            {
                storeID = "2";
            }
            string sql = "INSERT INTO goodreturnnote(ReturnNoteID, SalesOrderID, StoreID, StaffID, Date, Time) " +
                         "VALUES(NULL, @salesOrderID, @storeID, @staffID, current_timestamp,current_timestamp);";

            openConnection();
            command = new MySqlCommand(sql, conn);

            command.Parameters.AddWithValue("salesOrderID", label_SelectedOrderID.Text);
            command.Parameters.AddWithValue("storeID", storeID);
            command.Parameters.AddWithValue("staffID", getStaffID);
            try
            {
                command.ExecuteNonQuery();
                closeConnection();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("AddReturnNoteRecord() unuccessfuly. line 357 \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                closeConnection();
            }

        }

        private void CreateReturnNoteForm_Load(object sender, EventArgs e)
        {
            textBox_Nowdate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            textBox_NowTime.Text = DateTime.Now.ToString("hh:mm:ss");
            textbox_StaffID.Text = getStaffID;
            DisplayTable();
        }
    }
}

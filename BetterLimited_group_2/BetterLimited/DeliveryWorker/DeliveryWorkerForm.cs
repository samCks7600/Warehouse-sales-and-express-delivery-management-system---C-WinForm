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
    public partial class DeliveryWorkerForm : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user id =root;password=;database=betterlimited");
        MySqlCommand command;
        string staffID, department, position;

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


        public void closeConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }


        public void openConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }



        public DeliveryWorkerForm()
        {
            InitializeComponent();
        }

        private void button_clear_Worker_Click(object sender, EventArgs e)
        {
            textBox_Search_Worker.Text = "";
            string sql = "SELECT StaffID,StaffName,Gender,Tel,Email FROM staff WHERE Position = 'Delivery Workman';";
            openConnection();
            command = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(command);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView_WorkerTable.DataSource = tb1;
            closeConnection();
        }

        private void DeliveryWorkerForm_Load(object sender, EventArgs e)
        {
            DisplayTableWorkerTable();
            DisplayTableDeliveryTable();
        }

        private void dataGridView_WorkerTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                if (textBox_WorkID.Text.Equals(""))
                {
                    string staffID = dataGridView_WorkerTable.Rows[e.RowIndex].Cells[1].Value.ToString();
                    textBox_WorkID.Text = staffID;
                }
                else
                {
                    for (int i = 0; i < dataGridView_WorkerTable.RowCount; i++)
                    {
                        //Use A.Equals(B) to check if(string  A == string B)
                        if (dataGridView_WorkerTable.Rows[e.RowIndex].Cells[1].Value.ToString().Equals(textBox_WorkID.Text))
                        {
                            if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                            {
                                MessageBox.Show("This item is already selected.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(Properties.Settings.Default.DeliveryWorkerZh, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            return;
                        }

                    }

                    string staffID = dataGridView_WorkerTable.Rows[e.RowIndex].Cells[1].Value.ToString();
                    textBox_WorkID.Text = staffID;
                }
            }
            
        }

        private void DisplayTableWorkerTable()
        {
            string sql = "SELECT StaffID,StaffName,Gender,Tel,Email FROM staff WHERE Position = 'Delivery Workman';";
            openConnection();
            command = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(command);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView_WorkerTable.DataSource = tb1;
            closeConnection();
        }

        private void dataGridView_DeliveryTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                if (dataGridView_arrengeTable.RowCount == 0)
                {
                    string DeliveryID = dataGridView_DeliveryTable.Rows[e.RowIndex].Cells[1].Value.ToString();
                    dataGridView_arrengeTable.Rows.Add(DeliveryID);
                }
                else
                {
                    for (int i = 0; i < dataGridView_arrengeTable.RowCount; i++)
                    {
                        //Use A.Equals(B) to check if(string  A == string B)
                        if (dataGridView_DeliveryTable.Rows[e.RowIndex].Cells[1].Value.ToString()
                            .Equals(dataGridView_arrengeTable.Rows[i].Cells[0].Value.ToString())
                            )
                        {
                            if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                            {
                                MessageBox.Show("This Delivery Order is already selected.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(Properties.Settings.Default.DeliveryWorkerDeZh, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            return;
                        }

                    }
                    string DeliveryID = dataGridView_DeliveryTable.Rows[e.RowIndex].Cells[1].Value.ToString();

                    dataGridView_arrengeTable.Rows.Add(DeliveryID);
                }
            }

        }

        private void dataGridView_arrengeTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex != -1)
            {
                dataGridView_arrengeTable.Rows.RemoveAt(e.RowIndex);
            }

        }

        private void button_clearAll_arrangeList_Click(object sender, EventArgs e)
        {

            dataGridView_arrengeTable.Rows.Clear();
            
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if (textBox_WorkID.Text.Equals(""))
            {
                if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                {
                    MessageBox.Show("Please select a workman.");
                }
                else
                {
                    MessageBox.Show(Properties.Settings.Default.SelectWorkmanZh);
                }
                return;
            }


            if (dataGridView_arrengeTable.RowCount == 0)
            {
                if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                {
                    MessageBox.Show("Please select the delivery order to arrangement list.");
                }
                else
                {
                    MessageBox.Show(Properties.Settings.Default.SelectDOZh);
                }
                return;
            }




            StringBuilder sql = new StringBuilder();
            string staffID;
            string DeliveryID;
            for (int i = 0; i < dataGridView_arrengeTable.RowCount; i++)
            {
                DeliveryID = dataGridView_arrengeTable.Rows[i].Cells[0].Value.ToString();
                sql.Append("UPDATE deliveryorder SET WorkmanID  = '" + textBox_WorkID.Text + "'  Where  DeliveryID = ' " + DeliveryID + "';");
            }
            //////------------------------------------------------------
            openConnection();
            command = new MySqlCommand(sql.ToString(), conn);
            try
            {
                command.ExecuteNonQuery();
                if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                {
                    MessageBox.Show("Arrange Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(Properties.Settings.Default.ArrangeSucZh, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                {
                    MessageBox.Show("Arrange Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(Properties.Settings.Default.ArrangeUnsucZh + "\n" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            closeConnection();
            ResetForm();
        }

        private void DisplayTableDeliveryTable()
        {
            string sql = "SELECT DeliveryID,SalesOrderID,DeliveryDate,DeliveryTime,DeliveryStatus FROM deliveryorder Where WorkmanID is Null;";
            openConnection();
            command = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(command);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView_DeliveryTable.DataSource = tb1;
            closeConnection();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void textBox_Search_Worker_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void button_Search_Worker_Click(object sender, EventArgs e)
        {
            string sql;

            if (textBox_Search_Worker.Text == "")
            {
                sql = "SELECT StaffID,StaffName,Gender,Tel,Email FROM staff WHERE Position = 'Delivery Workman';";
            }
            else
            {
                sql = "SELECT StaffID,StaffName,Gender,Tel,Email FROM staff " +
                    "WHERE Position = 'Delivery Workman' AND StaffID = " + textBox_Search_Worker.Text + ";";
            }
            openConnection();
            command = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(command);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView_WorkerTable.DataSource = tb1;
            closeConnection();
        }

        private void ResetForm()
        {
            DisplayTableWorkerTable();
            DisplayTableDeliveryTable();
            dataGridView_arrengeTable.Rows.Clear();

        }

    }
}

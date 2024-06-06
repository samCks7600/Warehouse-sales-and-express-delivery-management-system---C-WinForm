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




    public partial class ViewDeliveryWorkmanForm : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user id =root;password=;database=betterlimited");
        MySqlCommand command;

        public ViewDeliveryWorkmanForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

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

        public void DisplayTable()
        {
            string sql = "SELECT DeliveryID,SalesOrderID,DeliveryDate,DeliveryTime,DeliveryStatus,WorkmanID FROM deliveryorder;";
            openConnection();
            command = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(command);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView_DeliveryTable.DataSource = tb1;
            closeConnection();
        }


        private void ViewEditDeliveryWorkmanForm_Load(object sender, EventArgs e)
        {
            DisplayTable();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            string sql;

            if (textBox_Search.Text == "")
            {
                sql = "SELECT DeliveryID,SalesOrderID,DeliveryDate,DeliveryTime,DeliveryStatus,WorkmanID FROM deliveryorder;";
            }
            else
            {
                sql = "SELECT DeliveryID,SalesOrderID,DeliveryDate,DeliveryTime,DeliveryStatus,WorkmanID FROM deliveryorder Where DeliveryID = " + textBox_Search.Text + ";";
            }
            openConnection();
            command = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(command);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView_DeliveryTable.DataSource = tb1;
            closeConnection();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_Search.Text = "";
            string sql = "SELECT DeliveryID,SalesOrderID,DeliveryDate,DeliveryTime,DeliveryStatus,WorkmanID FROM deliveryorder;";
            openConnection();
            command = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(command);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView_DeliveryTable.DataSource = tb1;
            closeConnection();
        }





        private void dataGridView_DeliveryTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                textBox_DeliveryID.Text = dataGridView_DeliveryTable.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox_SalesOrderID.Text = dataGridView_DeliveryTable.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox_DeliveryDate.Text = dataGridView_DeliveryTable.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBox_DeliveryTime.Text = dataGridView_DeliveryTable.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBox_DeliveryStatus.Text = dataGridView_DeliveryTable.Rows[e.RowIndex].Cells[5].Value.ToString();
                textBox_WorkmanID.Text = dataGridView_DeliveryTable.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            openConnection();

            if (textBox_DeliveryID.Text.Equals(""))
            {
                if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                {
                    MessageBox.Show("Please Select the record that you want to update.");
                }
                else
                {
                    MessageBox.Show(Properties.Settings.Default.SelectUpdateZh);
                }
                return;
            }
            string sql = "UPDATE deliveryorder SET WorkmanID=@WorkmanID WHERE DeliveryID = @DeliveryID; ";
            command = new MySqlCommand(sql, conn);

            if (textBox_WorkmanID.Text.Equals(""))
            {
                command.Parameters.AddWithValue("WorkmanID", null);
            }
            else
            {
                command.Parameters.AddWithValue("WorkmanID", textBox_WorkmanID.Text);
            }
            command.Parameters.AddWithValue("DeliveryID", textBox_DeliveryID.Text);

            try
            {
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
            catch (MySqlException ex)
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_DeliveryID.Text = "";
            textBox_SalesOrderID.Text = "";
            textBox_DeliveryDate.Text = "";
            textBox_DeliveryTime.Text = "";
            textBox_DeliveryStatus.Text = "";
            textBox_WorkmanID.Text = "";
        }

        private void button_cacel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_WorkmanID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void textBox_Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void button_clearWorkmanID_Click(object sender, EventArgs e)
        {
            textBox_WorkmanID.Text = "";
        }
    }
}

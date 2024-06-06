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




    public partial class ViewInstallationWorkmanForm : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user id =root;password=;database=betterlimited");
        MySqlCommand command;

        public ViewInstallationWorkmanForm()
        {
            InitializeComponent();
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
            string sql = "SELECT InstallationID,SalesOrderID,InstallationDate,InstallationTime,InstallationStatus,WorkmanID FROM installationorder;";
            openConnection();
            command = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(command);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView_InstallationTable.DataSource = tb1;
            closeConnection();
        }


        private void ViewEditInstallationWorkmanForm_Load(object sender, EventArgs e)
        {
            DisplayTable();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            string sql;

            if (textBox_Search.Text == "")
            {
                sql = "SELECT InstallationID,SalesOrderID,InstallationDate,InstallationTime,InstallationStatus,WorkmanID FROM Installationorder;";
            }
            else
            {
                sql = "SELECT InstallationID,SalesOrderID,InstallationDate,InstallationTime,InstallationStatus,WorkmanID FROM Installationorder Where InstallationID = " + textBox_Search.Text + ";";
            }
            openConnection();
            command = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(command);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView_InstallationTable.DataSource = tb1;
            closeConnection();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_Search.Text = "";
            string sql = "SELECT InstallationID,SalesOrderID,InstallationDate,InstallationTime,InstallationStatus,WorkmanID FROM Installationorder;";
            openConnection();
            command = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(command);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView_InstallationTable.DataSource = tb1;
            closeConnection();
        }





        private void dataGridView_InstallationTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                textBox_InstallationID.Text = dataGridView_InstallationTable.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox_SalesOrderID.Text = dataGridView_InstallationTable.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox_InstallationDate.Text = dataGridView_InstallationTable.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBox_InstallationTime.Text = dataGridView_InstallationTable.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBox_InstallationStatus.Text = dataGridView_InstallationTable.Rows[e.RowIndex].Cells[5].Value.ToString();
                textBox_WorkmanID.Text = dataGridView_InstallationTable.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            openConnection();

            if (textBox_InstallationID.Text.Equals(""))
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
            string sql = "UPDATE Installationorder SET WorkmanID=@WorkmanID WHERE InstallationID = @InstallationID; ";
            command = new MySqlCommand(sql, conn);

            if (textBox_WorkmanID.Text.Equals(""))
            {
                command.Parameters.AddWithValue("WorkmanID", null);
            }
            else
            {
                command.Parameters.AddWithValue("WorkmanID", textBox_WorkmanID.Text);
            }
            command.Parameters.AddWithValue("InstallationID", textBox_InstallationID.Text);

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
            textBox_InstallationID.Text = "";
            textBox_SalesOrderID.Text = "";
            textBox_InstallationDate.Text = "";
            textBox_InstallationTime.Text = "";
            textBox_InstallationStatus.Text = "";
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

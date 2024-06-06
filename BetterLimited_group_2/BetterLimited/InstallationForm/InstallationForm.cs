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
    public partial class InstallationForm : Form
    {

        MySqlConnection conn = new MySqlConnection("server=localhost;user id =root;password=;database=betterlimited");
        MySqlCommand command;
        string InstallationID, salesOrderID, staffID, department, position;



        //get set SalesOrderID
        public string setSalesOrderID
        {
            set
            {
                salesOrderID = value;
            }
        }
        public string getSalesOrderID
        {
            get
            {
                return salesOrderID;
            }
        }
        //get set InstallationID
        public string setInstallationID
        {
            set
            {
                InstallationID = value;
            }
        }
        
        public string getInstallationID
        {
            get
            {
                return InstallationID;
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
        //

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

        public InstallationForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

        }

        public void DisplayTable()
        {
            string sql = "SELECT InstallationID,SalesOrderID,InstallationDate,InstallationTime,InstallationStatus FROM installationorder";
            openConnection();
            command = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(command);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView_InstallationOrder_Table.DataSource = tb1;
            closeConnection();
        }

        private void DelectDelivery(string id)
        {
            string sql = "DELETE FROM installationorder WHERE InstallationID =" + id + ";";
            openConnection();
            command = new MySqlCommand(sql, conn);
            try
            {
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

        private void button_Search_Click(object sender, EventArgs e)
        {
            string sql;

            if (textBox_Search.Text == "")
            {
                sql = "SELECT InstallationID,SalesOrderID,InstallationDate,InstallationTime,InstallationStatus FROM installationorder;";
            }
            else
            {
                sql = "SELECT InstallationID,SalesOrderID,InstallationDate,InstallationTime,InstallationStatus FROM installationorder Where InstallationID = " + textBox_Search.Text + ";";
            }
            openConnection();
            command = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(command);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView_InstallationOrder_Table.DataSource = tb1;
            closeConnection();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_Search.Text = "";
            string sql = "SELECT InstallationID,SalesOrderID,InstallationDate,InstallationTime,InstallationStatus FROM installationorder;";
            openConnection();
            command = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(command);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView_InstallationOrder_Table.DataSource = tb1;
            closeConnection();
        }

        private void dataGridView_InstallationOrder_Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //search item
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                string SalesOrderID = dataGridView_InstallationOrder_Table.Rows[e.RowIndex].Cells[4].Value.ToString();
                string sql = "SELECT * From salesorder_item Where SalesOrderID = " + SalesOrderID + ";";

                openConnection();
                command = new MySqlCommand(sql, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(command);
                DataTable tb2 = new DataTable();
                adp.Fill(tb2);
                dataGridView_InstallationOrder_item_Table.DataSource = tb2;
                closeConnection();
            }

            //Edit
            if (e.ColumnIndex == 1 && e.RowIndex != -1)
            {
                InstallationID = dataGridView_InstallationOrder_Table.Rows[e.RowIndex].Cells[3].Value.ToString();
                salesOrderID = dataGridView_InstallationOrder_Table.Rows[e.RowIndex].Cells[4].Value.ToString();
                InstallationForm_UpdateForm updateForm = new InstallationForm_UpdateForm(this);

                updateForm.setSalesOrderID = getSalesOrderID;
                updateForm.setInstallationID = getInstallationID;
                updateForm.Show();
            }
            //Delete
            if (e.ColumnIndex == 2 && e.RowIndex != -1)
            {


                if (MessageBox.Show("You want to delect this sales order record ?? ", "Infomation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    DelectDelivery(dataGridView_InstallationOrder_Table.Rows[e.RowIndex].Cells[3].Value.ToString());
                    DisplayTable();
                }
                return;
            }



        }

        private void InstallationForm_Load(object sender, EventArgs e)
        {
            dataGridView_InstallationOrder_Table.Columns[2].DefaultCellStyle.Format = "yyyy/MM/dd";
            DisplayTable(); 
        }

        private void textBox_Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}

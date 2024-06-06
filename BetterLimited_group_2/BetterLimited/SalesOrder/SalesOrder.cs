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
    public partial class SalesOrder : Form
    {
        
        MySqlConnection conn = new MySqlConnection("server=localhost;user id =root;password=;database=betterlimited");
        MySqlCommand command;
        string salesOrderID;
        string staffID, department, position;

        public string setSalesOrderID
        {
            set
            {
                salesOrderID = value;
            }
        }
        //get set StaffID
        public string getSalesOrderID
        {
            get
            {
                return salesOrderID;
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




        public SalesOrder()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }


        private void DisplayTable() 
        {
            string sql = "SELECT * FROM salesorder";
            openConnection();
            command = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(command);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView_SalesOrderTable.DataSource = tb1;
            closeConnection();
        }

        private void DelectSalesOrder(string id) 
        {
            string sql = "DELETE FROM salesorder WHERE salesorderID =" + id+";";
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

            if (textBox_Search.Text =="")
            {
                sql = "SELECT * FROM salesorder;";
            }
            else 
            {
                sql = "SELECT * FROM salesorder Where SalesOrderId = " + textBox_Search.Text + ";";
            }
            openConnection();
            command = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(command);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView_SalesOrderTable.DataSource = tb1;
            closeConnection();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_Search.Text ="";
            string sql = "SELECT * FROM salesorder;";
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
            //Edit
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                salesOrderID = dataGridView_SalesOrderTable.Rows[e.RowIndex].Cells[2].Value.ToString();
                SalesOrder_UpdateForm updateForm = new SalesOrder_UpdateForm();
                updateForm.setSalesOrderID = getSalesOrderID;
                updateForm.Show();
            }
            //Delete
            if (e.ColumnIndex == 1 && e.RowIndex != -1) 
            {
                if (MessageBox.Show("You want to delect this sales order record ?? ", "Infomation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DelectSalesOrder(dataGridView_SalesOrderTable.Rows[e.RowIndex].Cells[2].Value.ToString());
                    DisplayTable();
                }
                return;
            }
        }




        private void dataGridView_SalesOrderTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_SalesOrderTable_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView_SalesOrderTable.ClearSelection();
        }

        private void textBox_Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void SalesOrder_Load(object sender, EventArgs e)
        {
            switch (position)
            {
                case "Admin":
                case "CEO":
                case "Accounting Manager":
                case "Inventory Manager":
                case "Sales Manager":
                case "Purchase manager":
                case "Sales Representative":
                    this.dataGridView_SalesOrderTable.Columns["EditButton"].Visible = true;
                    this.dataGridView_SalesOrderTable.Columns["DeleteButton"].Visible = true;
                    break;
                default:
                    this.dataGridView_SalesOrderTable.Columns["EditButton"].Visible = false;
                    this.dataGridView_SalesOrderTable.Columns["DeleteButton"].Visible = false;
                    break;
            }
            dataGridView_SalesOrderTable.Columns[7].DefaultCellStyle.Format = "yyyy/MM/dd";
            dataGridView_SalesOrderTable.Columns[5].DefaultCellStyle.Format = "yyyy/MM/dd";
            DisplayTable();
        }

        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

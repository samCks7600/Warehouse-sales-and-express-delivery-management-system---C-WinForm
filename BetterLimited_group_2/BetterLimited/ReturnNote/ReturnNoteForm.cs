using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BetterLimited
{
    public partial class ReturnNoteForm : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user id =root;password=;database=betterlimited");
        MySqlCommand command;
        string staffID, department, position, storeID;

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
        public string setStoreID
        {
            set
            {
                storeID = value;
            }
        }
        //get set StaffID
        public string getStoreID
        {
            get
            {
                return storeID;
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

        public void DisplayTable()
        {
            string sql = "SELECT ReturnNoteID, SalesOrderID, StoreID, StaffID, Date, Time FROM goodreturnnote;";
            openConnection();
            command = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(command);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView_ReuturnNoteTable.DataSource = tb1;
            closeConnection();
            switch (department)
            {
                case "Sales":
                case "Admin":
                case "CEO":
                    this.dataGridView_ReuturnNoteTable.Columns["Select"].Visible = true;
                    button_Create.Visible = true;
                    break;
                default:
                    this.dataGridView_ReuturnNoteTable.Columns["Select"].Visible = false;
                    button_Create.Visible = false;
                    break;
            }
        }


        public ReturnNoteForm()
        {
            InitializeComponent();
        }

        private void ReturnNoteForm_Load(object sender, EventArgs e)
        {
            textbox_StaffID.Text = staffID;
            DisplayTable();
        }


        private void button_Search_Click(object sender, EventArgs e)
        {
            string sql;

            if (textBox_Search.Text == "")
            {
                sql = "SELECT ReturnNoteID, SalesOrderID, StoreID, StaffID, Date, Time FROM goodreturnnote;";
            }
            else
            {
                sql = "SELECT ReturnNoteID, SalesOrderID, StoreID, StaffID, Date, Time FROM goodreturnnote WHERE ReturnNoteID= " + textBox_Search.Text + ";";
            }
            openConnection();
            command = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(command);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView_ReuturnNoteTable.DataSource = tb1;
            closeConnection();
        }


        private void textBox_Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void dataGridView_ReuturnNoteTable_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView_ReturnItemTable.ClearSelection();
        }

        private void dataGridView_ReturnItemTable_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView_ReturnItemTable.ClearSelection();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_Search.Text = "";
            string sql = "SELECT ReturnNoteID, SalesOrderID, StoreID, StaffID, Date, Time FROM goodreturnnote;";
            openConnection();
            command = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(command);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView_ReuturnNoteTable.DataSource = tb1;
            closeConnection();
        }

        private void dataGridView_ReuturnNoteTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                string ReturnID = dataGridView_ReuturnNoteTable.Rows[e.RowIndex].Cells[1].Value.ToString();
                string sql = "SELECT * FROM goodreturnnote_item Where ReturnNoteID = " + ReturnID + ";";
                
                openConnection();
                command = new MySqlCommand(sql, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(command);
                DataTable tb2 = new DataTable();
                adp.Fill(tb2);
                dataGridView_ReturnItemTable.DataSource = tb2;
                closeConnection();
            }
        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            CreateReturnNoteForm CreateForm = new CreateReturnNoteForm(this);
            CreateForm.setStaffID = getStaffID;
            CreateForm.Show();


        }

    }
}

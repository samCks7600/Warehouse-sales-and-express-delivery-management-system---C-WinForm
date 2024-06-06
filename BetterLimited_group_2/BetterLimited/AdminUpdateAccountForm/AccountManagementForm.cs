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
    public partial class AccountManagementForm : Form
    {

        MySqlConnection conn = new MySqlConnection("server=localhost;user id =root;password=;database=betterlimited");
        MySqlCommand command;
        string userAccountID;
        string staffID, department, position;

        public AccountManagementForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        public string setUserAccountID
        {
            set
            {
                userAccountID = value;
            }
        }
        //get set StaffID
        public string getUserAccountID
        {
            get
            {
                return userAccountID;
            }
        }

        //permisstion
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

        private void DisplayTable()
        {
            string sql = "SELECT useraccount.UserAccountID,useraccount.StaffID,useraccount.UserName,useraccount.Email,staff.Depart,staff.Position " +
                "FROM useraccount,staff " +
                "WHERE useraccount.StaffID = staff.StaffID; ";
            openConnection();
            command = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(command);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView_AccountTable.DataSource = tb1;
            closeConnection();
        }


        private void DelectSalesOrder(string id)
        {
            string sql = "DELETE FROM useraccount WHERE UserAccountID =" + id + ";";
            openConnection();
            command = new MySqlCommand(sql, conn);
            try
            {
                command.ExecuteNonQuery();
                if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                {
                    MessageBox.Show("Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show("Deleted Unsuccessfully \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(Properties.Settings.Default.ViewStaffDeleteFailZh + "\n" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }                
            }
            closeConnection();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            string sql;

        
        
            if (textBox_Search.Text == "")
            {
                sql = "SELECT useraccount.UserAccountID,useraccount.StaffID,useraccount.UserName,useraccount.Email,staff.Depart,staff.Position " +
                "FROM useraccount,staff " +
                "WHERE useraccount.StaffID = staff.StaffID; ";
            }
            else
            {
                sql = "SELECT useraccount.UserAccountID,useraccount.StaffID,useraccount.UserName,useraccount.Email,staff.Depart,staff.Position " +
                "FROM useraccount,staff " +
                "WHERE useraccount.StaffID = staff.StaffID AND  staff.StaffID = " + textBox_Search.Text + ";; ";
            }
            openConnection();
            command = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(command);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView_AccountTable.DataSource = tb1;
            closeConnection();
        }



        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_Search.Text = "";
            string sql = "SELECT useraccount.UserAccountID,useraccount.StaffID,useraccount.UserName,useraccount.Email,staff.Depart,staff.Position " +
                "FROM useraccount,staff " +
                "WHERE useraccount.StaffID = staff.StaffID; ";
            openConnection();
            command = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(command);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView_AccountTable.DataSource = tb1;
            closeConnection();
        }

        private void dataGridView_AccountTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Edit
            if (e.ColumnIndex == 0)
            {
                userAccountID = dataGridView_AccountTable.Rows[e.RowIndex].Cells[2].Value.ToString();
                UpdateUserAccountForm updateForm = new UpdateUserAccountForm();
                updateForm.setUserAccountID = getUserAccountID;
                updateForm.Show();
            }
            //Delete
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("You want to delect this user accuont ?? ", "Infomation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DelectSalesOrder(dataGridView_AccountTable.Rows[e.RowIndex].Cells[2].Value.ToString());
                    DisplayTable();
                }
                return;
            }
        }

        private void AccountManagementForm_Load(object sender, EventArgs e)
        {
            
            dataGridView_AccountTable.Columns[5].DefaultCellStyle.Format = "yyyy/MM/dd";
            dataGridView_AccountTable.Columns[6].DefaultCellStyle.Format = "yyyy/MM/dd";
            DisplayTable();
        }

    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterLimited
{
    public partial class RestockRequestRecord : Form
    {
        //Database 
        static string conString = "Server=localhost; Database=betterlimited; user id=root; Password=;";
        MySqlConnection con = new MySqlConnection(conString);
        MySqlCommand cmd;
        string restockRequestRecordID;
        string staffID, department, position;

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
        //get set restockRequestRecordID
        public string setRestockRequestRecord
        {
            set
            {
                restockRequestRecordID = value;
            }
        }

        public string getRestockRequestRecord
        {
            get
            {
                return restockRequestRecordID;
            }
        }


        public void openConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void closeConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        public RestockRequestRecord()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //DATAGRIDVIEW PROPERTIES
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void RestockRequestRecord_Load(object sender, EventArgs e)
        {

            dataGridView1.Columns[2].DefaultCellStyle.Format = "yyyy/MM/dd";
            dataGridView1.DataSource = GetRestockRequest();
        }

        // get restock request data
        private DataTable GetRestockRequest()
        {
            DataTable dtRestock = new DataTable();

            using (con)
            {
                using (cmd = new MySqlCommand("SELECT * FROM restockrequest;", con))
                {
                    openConnection();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dtRestock.Load(reader);
                    closeConnection();
                }
            }
            return dtRestock;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Details" && e.RowIndex != -1)
            {
                restockRequestRecordID = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                RestockRequestDetail detailsForm = new RestockRequestDetail();
                detailsForm.setRestockRequestRecord = getRestockRequestRecord;
                detailsForm.Show();
            }

        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            string sql;
            if (textBox_Search.Text == "")
            {
                sql = "SELECT * FROM restockrequest;";
            }
            else
            {
                sql = "SELECT * FROM restockrequest Where RestockRequestID = " + textBox_Search.Text + ";";
            }
            openConnection();
            cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView1.DataSource = tb1;
            closeConnection();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_Search.Text = "";
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            MenuForm menuform = Application.OpenForms["MenuForm"] as MenuForm;
            CreateRestockRequestForm rorform = new CreateRestockRequestForm();
            if (menuform != null)
            {
                menuform.setStaffID = getStaffID;
                menuform.setDepartment = getDepartment;
                menuform.setPosition = getPosition;
                menuform.createRestock();
            }
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

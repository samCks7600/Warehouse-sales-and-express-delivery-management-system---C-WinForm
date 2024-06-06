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
    public partial class RestockRequestDetail : Form
    {
        static string conString = "Server=localhost; Database=betterlimited; user id=root; Password=;";
        MySqlConnection con = new MySqlConnection(conString);
        MySqlCommand cmd;
        string restockRequestRecordID;

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
        public string setRestockRequestRecord
        {
            set
            {
                restockRequestRecordID = value;
            }
        }
        //get set StaffID
        public string getRestockRequestRecord
        {
            get
            {
                return restockRequestRecordID;
            }
        }
        public RestockRequestDetail()
        {
            InitializeComponent();
        }

        private void backBtm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RestockRequestDetail_Load(object sender, EventArgs e)
        {
            label2.Text = getRestockRequestRecord;
            string sql = "SELECT * FROM restockrequest_item Where RestockRequestID = " + getRestockRequestRecord + ";";
            openConnection();
            cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView1.DataSource = tb1;
            closeConnection();
        }
    }
}

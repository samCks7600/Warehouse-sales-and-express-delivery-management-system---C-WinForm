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
    public partial class dailyDelivery : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user id =root;password=;database=betterlimited");
        MySqlCommand command;
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
            lblTimeSlot.Text = "All Time";
            openConnection();

            string sql = "SELECT DeliveryID,SalesOrderID,DeliveryDate,DeliveryTime,DeliveryStatus,WorkmanID FROM deliveryorder Where DeliveryDate = ' " + dateTimePicker__DeliveryDate.Text + " ' AND WorkmanID IS NOT NULL;;";

            command = new MySqlCommand(sql, conn);

            //command.Parameters.AddWithValue("deliveryDate", dateTimePicker__DeliveryDate.Text);

            MySqlDataAdapter adp = new MySqlDataAdapter(command);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView_dealiyDelivery.DataSource = tb1;
            closeConnection();

            if (dataGridView_dealiyDelivery.Rows.Count == 0)
            {
                label_Noduty.Visible = true;
            }
            else
            {
                label_Noduty.Visible = false;
            }
        }



        public dailyDelivery()
        {
            InitializeComponent();
        }

        private void dailyDelivery_Load(object sender, EventArgs e)
        {
            dateTimePicker__DeliveryDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            textBox_Nowdate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            label_Noduty.Visible = false;
            DisplayTable();

            //position = "Admin"; //for test 



            if (position.Equals("Delivery Workman"))
            {
                
                textBox_WorkmanID.Text = staffID;
            }
            else
            {
                textBox_WorkmanID.Text = "Admin";
            }


        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            openConnection();

            string sql;
            if (position.Equals("Admin"))
            {
                sql = "SELECT DeliveryID,SalesOrderID,DeliveryDate,DeliveryTime,DeliveryStatus,WorkmanID FROM deliveryorder " +
                    "Where DeliveryDate = ' " + dateTimePicker__DeliveryDate.Text + " ' AND WorkmanID IS NOT NULL;";

            }
            else
            {
               sql = "SELECT DeliveryID,SalesOrderID,DeliveryDate,DeliveryTime,DeliveryStatus,WorkmanID FROM deliveryorder " +
                    "Where DeliveryDate = ' " + dateTimePicker__DeliveryDate.Text + " ' AND WorkmanID ='"+ textBox_WorkmanID.Text+ "' ;";
            }

            command = new MySqlCommand(sql, conn);

            //command.Parameters.AddWithValue("deliveryDate", dateTimePicker__DeliveryDate.Text);

            MySqlDataAdapter adp = new MySqlDataAdapter(command);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView_dealiyDelivery.DataSource = tb1;
            closeConnection();

            if (dataGridView_dealiyDelivery.Rows.Count == 0)
            {
                label_Noduty.Visible = true;
            }
            else
            {
                label_Noduty.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblTimeSlot.Text = "09:00 - 12:00 Delivery Time Slot";
            openConnection();

            string sql;

            if (position.Equals("Admin"))
            {
                sql = "SELECT DeliveryID,SalesOrderID,DeliveryDate,DeliveryTime,DeliveryStatus,WorkmanID FROM deliveryorder Where DeliveryDate = '" + dateTimePicker__DeliveryDate.Text +
                "' AND DeliveryTime BETWEEN '09:00:00' and '12:59:59' AND WorkmanID IS NOT NULL;;";

            }
            else
            {
                sql = "SELECT DeliveryID,SalesOrderID,DeliveryDate,DeliveryTime,DeliveryStatus,WorkmanID FROM deliveryorder Where DeliveryDate = '" + dateTimePicker__DeliveryDate.Text +
                "' AND DeliveryTime BETWEEN '09:00:00' and '12:59:59' AND WorkmanID ='" + textBox_WorkmanID.Text + "' ;";
            }



            command = new MySqlCommand(sql, conn);

            //command.Parameters.AddWithValue("deliveryDate", dateTimePicker__DeliveryDate.Text);

            MySqlDataAdapter adp = new MySqlDataAdapter(command);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView_dealiyDelivery.DataSource = tb1;
            closeConnection();

            if (dataGridView_dealiyDelivery.Rows.Count == 0)
            {
                label_Noduty.Visible = true;
            }
            else
            {
                label_Noduty.Visible = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblTimeSlot.Text = "13:00 - 17:00 Delivery Time Slot";
            openConnection();

            string sql;

            if (position.Equals("Admin"))
            {
                sql = "SELECT DeliveryID,SalesOrderID,DeliveryDate,DeliveryTime,DeliveryStatus,WorkmanID FROM deliveryorder Where DeliveryDate = '" + dateTimePicker__DeliveryDate.Text +
                "' AND DeliveryTime BETWEEN '13:00:00' and '17:59:59' AND WorkmanID IS NOT NULL;;";

            }
            else
            {
                sql = "SELECT DeliveryID,SalesOrderID,DeliveryDate,DeliveryTime,DeliveryStatus,WorkmanID FROM deliveryorder Where DeliveryDate = '" + dateTimePicker__DeliveryDate.Text +
                "' AND DeliveryTime BETWEEN '13:00:00' and '17:59:59' AND WorkmanID ='" + textBox_WorkmanID.Text + "' ;";
            }


            command = new MySqlCommand(sql, conn);

            //command.Parameters.AddWithValue("deliveryDate", dateTimePicker__DeliveryDate.Text);

            MySqlDataAdapter adp = new MySqlDataAdapter(command);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView_dealiyDelivery.DataSource = tb1;
            closeConnection();

            if (dataGridView_dealiyDelivery.Rows.Count == 0)
            {
                label_Noduty.Visible = true;
            }
            else
            {
                label_Noduty.Visible = false;
            }

        }

        private void dataGridView_dealiyDelivery_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1) {
                string DeliveryID = dataGridView_dealiyDelivery.Rows[e.RowIndex].Cells[1].Value.ToString();
                string DeliveryStatus  = dataGridView_dealiyDelivery.Rows[e.RowIndex].Cells[5].Value.ToString();
                UpdateDeliveryStatus updateForm = new UpdateDeliveryStatus();

                updateForm.setDeliveryID = DeliveryID;
                updateForm.Show();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblTimeSlot.Text = "18:00 - 22:00 Delivery Time Slot"; 
            openConnection();

            string sql;

            if (position.Equals("Admin"))
            {
                sql = "SELECT DeliveryID,SalesOrderID,DeliveryDate,DeliveryTime,DeliveryStatus,WorkmanID FROM deliveryorder Where DeliveryDate = '" + dateTimePicker__DeliveryDate.Text +
                "' AND DeliveryTime BETWEEN '18:00:00' and '22:59:59' AND WorkmanID IS NOT NULL;;";

            }
            else
            {
                sql = "SELECT DeliveryID,SalesOrderID,DeliveryDate,DeliveryTime,DeliveryStatus,WorkmanID FROM deliveryorder Where DeliveryDate = '" + dateTimePicker__DeliveryDate.Text +
                "' AND DeliveryTime BETWEEN '18:00:00' and '22:59:59' AND WorkmanID ='" + textBox_WorkmanID.Text + "' ;";
            }


            command = new MySqlCommand(sql, conn);

            //command.Parameters.AddWithValue("deliveryDate", dateTimePicker__DeliveryDate.Text);

            MySqlDataAdapter adp = new MySqlDataAdapter(command);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView_dealiyDelivery.DataSource = tb1;
            closeConnection();

            if (dataGridView_dealiyDelivery.Rows.Count == 0)
            {
                label_Noduty.Visible = true;
            }
            else
            {
                label_Noduty.Visible = false;
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblTimeSlot.Text = "All Time"; 
            openConnection();

            string sql = "SELECT DeliveryID,SalesOrderID,DeliveryDate,DeliveryTime,DeliveryStatus,WorkmanID FROM deliveryorder Where DeliveryDate = ' " + dateTimePicker__DeliveryDate.Text + " ';";

            if (position.Equals("Admin"))
            {
                sql = "SELECT DeliveryID,SalesOrderID,DeliveryDate,DeliveryTime,DeliveryStatus,WorkmanID FROM deliveryorder Where DeliveryDate = '" + dateTimePicker__DeliveryDate.Text +
                "' AND WorkmanID IS NOT NULL;";

            }
            else
            {
                sql = "SELECT DeliveryID,SalesOrderID,DeliveryDate,DeliveryTime,DeliveryStatus,WorkmanID FROM deliveryorder Where DeliveryDate = '" + dateTimePicker__DeliveryDate.Text +
                "' AND WorkmanID ='" + textBox_WorkmanID.Text + "' ;";
            }


            command = new MySqlCommand(sql, conn);

            //command.Parameters.AddWithValue("deliveryDate", dateTimePicker__DeliveryDate.Text);

            MySqlDataAdapter adp = new MySqlDataAdapter(command);
            DataTable tb1 = new DataTable();
            adp.Fill(tb1);
            dataGridView_dealiyDelivery.DataSource = tb1;
            closeConnection();

            if (dataGridView_dealiyDelivery.Rows.Count == 0)
            {
                label_Noduty.Visible = true;
            }
            else
            {
                label_Noduty.Visible = false;
            }

        }


    }
}

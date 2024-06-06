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
    public partial class DeliveryForm_UpdateForm : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user id =root;password=;database=betterlimited");
        MySqlCommand command;
        string deliveryID;
        private DeliveryForm _deliveryform;
        public DeliveryForm_UpdateForm(DeliveryForm deliveryform)
        {
            InitializeComponent();
            _deliveryform = deliveryform;
        }
        public string setDeliveryID
        {
            set
            {
                deliveryID = value;
            }
        }
        //get set StaffID
        public string getDeliveryID
        {
            get
            {
                return deliveryID;
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


        private void DeliveryForm_UpdateForm_Load(object sender, EventArgs e)
        {
            dateTimePicker__DeliveryTime.Format = DateTimePickerFormat.Time;
            dateTimePicker__DeliveryTime.ShowUpDown = true;


            openConnection();

            string sql = "SELECT * FROM deliveryorder WHERE DeliveryID = @deliveryID;";
            command = new MySqlCommand(sql, conn);
            command.Parameters.AddWithValue("deliveryID", getDeliveryID);

            MySqlDataReader reader;
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                //textBox_Date.Text = reader["Date"].ToString();
                textBox_DeliveryID.Text = reader["DeliveryID"].ToString();
                textBox_SalesOrderID.Text = reader["SalesOrderID"].ToString();
                dateTimePicker__DeliveryDate.Text = Convert.ToDateTime(reader["DeliveryDate"]).ToString("yyyy/MM/dd");
                dateTimePicker__DeliveryTime.Text = reader["DeliveryTime"].ToString();
                comboBox_deliveryStatus.Text = reader["DeliveryStatus"].ToString();
            }
            closeConnection();
        }

        private void button_cacel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            openConnection();

            string sql = "UPDATE deliveryorder SET " +
                "DeliveryDate=@deliveryDate," +
                "DeliveryTime=@deliveryTime," +
                "DeliveryStatus=@deliveryStatus" +
                " WHERE DeliveryID = @deliveryID;";

            command = new MySqlCommand(sql, conn);
            command.Parameters.AddWithValue("deliveryDate", dateTimePicker__DeliveryDate.Text);
            command.Parameters.AddWithValue("deliveryTime", dateTimePicker__DeliveryTime.Text);
            command.Parameters.AddWithValue("deliveryStatus", comboBox_deliveryStatus.Text);
            command.Parameters.AddWithValue("deliveryID", textBox_DeliveryID.Text);


            try
            {
                command.ExecuteNonQuery();
                if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                {
                    MessageBox.Show("Update Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(Properties.Settings.Default.UpdateUserZh, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                {
                    MessageBox.Show("Update Unsuccessful. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(Properties.Settings.Default.UpdateUserFailZh + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            closeConnection();
            this.Hide();
            _deliveryform.DisplayTable();
            
        }

        private void dateTimePicker__DeliveryDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

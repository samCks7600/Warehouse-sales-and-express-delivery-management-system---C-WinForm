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
    public partial class UpdateDeliveryStatus : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user id =root;password=;database=betterlimited");
        MySqlCommand command;
        string deliveryID = "";

        public string setDeliveryID
        {
            set
            {
                deliveryID = value;
            }
        }
        public string getDeliveryID
        {
            get
            {
                return deliveryID;
            }
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


        public UpdateDeliveryStatus()
        {
            InitializeComponent();
        }


        private void UpdateInstallStatus_Load(object sender, EventArgs e)
        {
            textBox_DeliveryID.Text = getDeliveryID;

            openConnection();

            string sql = "SELECT * FROM deliveryorder WHERE DeliveryID = @deliveryID;";
            command = new MySqlCommand(sql, conn);
            command.Parameters.AddWithValue("deliveryID", getDeliveryID);

            MySqlDataReader reader;
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                //textBox_Date.Text = reader["Date"].ToString();
                comboBox_DeliveryStatus.Text = reader["DeliveryStatus"].ToString();
            }
            else
            {
                MessageBox.Show("Dedug: code in SalesOrder_UpdateForm.cs, Error :  Not Data Found");
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

            string sql = "UPDATE deliveryorder SET DeliveryStatus=@deliveryStatus WHERE DeliveryID =@deliveryID;";
            command = new MySqlCommand(sql, conn);
            command.Parameters.AddWithValue("deliveryStatus", comboBox_DeliveryStatus.Text);
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
            this.Hide();
        }
    }
}

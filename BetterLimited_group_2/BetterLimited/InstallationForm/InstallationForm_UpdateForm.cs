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
    public partial class InstallationForm_UpdateForm : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user id =root;password=;database=betterlimited");
        MySqlCommand command;
        string InstallationID, salesOrderID, staffID, department, position;
        private InstallationForm _installationform;



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


        public InstallationForm_UpdateForm(InstallationForm installationform)
        {
            InitializeComponent();
            _installationform = installationform;
        }

        private void InstallationForm_UpdateForm_Load(object sender, EventArgs e)
        {
            MySqlDataReader reader;
            //---------------
            dateTimePicker_InstallationTime.Format = DateTimePickerFormat.Time;
            dateTimePicker_InstallationTime.ShowUpDown = true;

            //----------------
            openConnection();

            //Get all installationorder Info
            string sql = "SELECT * FROM installationorder WHERE InstallationID = @installationID;";
            command = new MySqlCommand(sql, conn);



            command.Parameters.AddWithValue("installationID", getInstallationID);

            reader = command.ExecuteReader();

            if (reader.Read())
            {
                //textBox_Date.Text = reader["Date"].ToString();
                textBox_InstallationID.Text = reader["InstallationID"].ToString();
                textBox_SalesOrderID.Text = reader["SalesOrderID"].ToString();
                dateTimePicker__InstallationDate.Text = Convert.ToDateTime(reader["InstallationDate"]).ToString("yyyy/MM/dd");
                dateTimePicker_InstallationTime.Text = (reader["InstallationTime"]).ToString();
                comboBox_InstallationStatus.Text = reader["InstallationStatus"].ToString();
                reader.Close();

            }
            else
            {
                MessageBox.Show("Error : Not Data Found,The Delivery order was deleted,this Installation order can delecte now.");
                reader.Close();
            }

            setMinOfTimeAndDate();

        }

        private void button_cacel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            openConnection();

            string sql = "UPDATE installationorder SET " +
                "InstallationDate=@installationDate," +
                "InstallationTime=@installationTime," +
                "InstallationStatus=@installationStatus" +
                " WHERE InstallationID = @installationID;";

            command = new MySqlCommand(sql, conn);
            command.Parameters.AddWithValue("installationDate", dateTimePicker__InstallationDate.Text);
            command.Parameters.AddWithValue("installationTime", dateTimePicker_InstallationTime.Text);
            command.Parameters.AddWithValue("installationStatus", comboBox_InstallationStatus.Text);
            command.Parameters.AddWithValue("installationID", textBox_InstallationID.Text);


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
            _installationform.DisplayTable();
        }

        private void dateTimePicker__InstallationDate_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Compare(dateTimePicker__DeliveryDate.Value, dateTimePicker__InstallationDate.Value) == 0)
            {
                dateTimePicker_InstallationTime.MinDate = DateTime.Parse((textBox_DeliveryTime.Text)).AddHours(2);
            }
            else
            {
                dateTimePicker_InstallationTime.MinDate = DateTime.Parse("00:00:00");
            }
        }



        private void textBox_InstallationID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void textBox_SalesOrderID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void textbox_CustomerID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void setMinOfTimeAndDate()
        {
            MySqlDataReader reader;
            //if (reader == null) { };
            string sql;
            //get Mix input installtion 
            sql = "SELECT * FROM deliveryorder WHERE SalesOrderID = @salesOrderID;";
            openConnection();
            command = new MySqlCommand(sql, conn);
            command.Parameters.AddWithValue("salesOrderID", getSalesOrderID);



            reader = command.ExecuteReader();
            if (reader.Read())
            {
                //textBox_Date.Text = reader["Date"].ToString();
                dateTimePicker__DeliveryDate.Text = Convert.ToDateTime(reader["DeliveryDate"]).ToString("yyyy/MM/dd");
                DateTime deliveryDate = Convert.ToDateTime(reader["DeliveryDate"]);

                textBox_DeliveryTime.Text = reader["DeliveryTime"].ToString();
                dateTimePicker__InstallationDate.MinDate = Convert.ToDateTime(dateTimePicker__DeliveryDate.Text);

                if (DateTime.Compare(deliveryDate, dateTimePicker__InstallationDate.Value) == 0)
                {
                    dateTimePicker_InstallationTime.MinDate = DateTime.Parse(textBox_DeliveryTime.Text).AddHours(2);
                    //textBox_DeliveryTime
                }
                else
                {
                    dateTimePicker_InstallationTime.MinDate = DateTime.Parse("00:00:00");
                }
            }
            else
            {
                MessageBox.Show("Dedug: code in Installation_UpdateForm.cs, Error :  Not Data Found");
            }
            closeConnection();
        }

    }
}

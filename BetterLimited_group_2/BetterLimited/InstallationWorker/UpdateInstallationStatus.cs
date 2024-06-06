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
    public partial class UpdateInstallationStatus : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user id =root;password=;database=betterlimited");
        MySqlCommand command;
        string InstallationID = "";

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




        public UpdateInstallationStatus()
        {
            InitializeComponent();
        }

        private void UpdateInstallationStatus_Load(object sender, EventArgs e)
        {
            textBox_InstallationID.Text = getInstallationID;

            openConnection();

            string sql = "SELECT * FROM Installationorder WHERE InstallationID = @InstallationID;";
            command = new MySqlCommand(sql, conn);
            command.Parameters.AddWithValue("InstallationID", getInstallationID);

            MySqlDataReader reader;
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                //textBox_Date.Text = reader["Date"].ToString();
                comboBox_InstallationStatus.Text = reader["InstallationStatus"].ToString();
            }
            else
            {
                MessageBox.Show("Dedug: code in SalesOrder_UpdateForm.cs, Error :  Not Data Found");
            }
            closeConnection();

        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            openConnection();

            string sql = "UPDATE Installationorder SET InstallationStatus=@InstallationStatus WHERE InstallationID =@InstallationID;";
            command = new MySqlCommand(sql, conn);
            command.Parameters.AddWithValue("InstallationStatus", comboBox_InstallationStatus.Text);
            command.Parameters.AddWithValue("InstallationID", textBox_InstallationID.Text);

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

        private void button_cacel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

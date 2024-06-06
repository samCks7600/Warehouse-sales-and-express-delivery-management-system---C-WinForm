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
    public partial class EditStaffForm : Form
    {


        MySqlConnection conn = new MySqlConnection("server=localhost;user id =root;password=;database=betterlimited");
        MySqlCommand command;

        string staffID;

        //get set StaffID
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


        public EditStaffForm()
        {
            InitializeComponent();
        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            if (textBox_StaffName.Text.Trim().Length < 1 ||
               comboBox_Gender.SelectedItem == null ||
               textBox_Tel.Text.Trim().Length < 1 ||
               textBox_Email.Text.Trim().Length < 1 ||
               comboBox_Depart.SelectedItem == null ||
               comboBox_Position.SelectedItem == null
               )
            {
                if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                {
                    MessageBox.Show("All information should be filled.");
                }
                else
                {
                    MessageBox.Show(Properties.Settings.Default.CreateStaffFormMsgBoxFillZh);
                }
            }
            else
            {
                string sql;
                if (comboBox_Depart.SelectedItem.Equals("Sales"))
                {
                    sql = "UPDATE staff SET StaffName = @StaffName," +
                        "Gender = @Gender," +
                        "DateOfBirth = @DateOfBirth," +
                        "Tel = @Tel," +
                        "Email = @Email," +
                        "Position = @Position," +
                        "Depart = @Depart," +
                        "Salary = @Salary," +
                        "storeID = @storeID " +
                        "WHERE StaffID = @StaffID;";
                }
                else
                {
                    sql = "UPDATE staff SET StaffName = @StaffName," +
                        "Gender = @Gender," +
                        "DateOfBirth = @DateOfBirth," +
                        "Tel = @Tel," +
                        "Email = @Email," +
                        "Position = @Position," +
                        "Depart = @Depart," +
                        "Salary = @Salary," +
                        "storeID = NULL " +
                        "WHERE StaffID = @StaffID;";
                }
                openConnection();

                command = new MySqlCommand(sql, conn);


                command.Parameters.AddWithValue("@StaffID", textbox_StaffID.Text);
                command.Parameters.AddWithValue("@StaffName", textBox_StaffName.Text);
                command.Parameters.AddWithValue("@Gender", comboBox_Gender.Text);
                command.Parameters.AddWithValue("@DateOfBirth", dateTimePicker_DateOfBirth.Text);
                command.Parameters.AddWithValue("@Tel", textBox_Tel.Text);
                command.Parameters.AddWithValue("@Email", textBox_Email.Text);
                command.Parameters.AddWithValue("@Position", comboBox_Position.Text);
                command.Parameters.AddWithValue("@Depart", comboBox_Depart.Text);
                command.Parameters.AddWithValue("@Salary", textBox_Salary.Text);
                if (comboBox_Depart.SelectedItem.Equals("Sales"))
                {
                    command.Parameters.AddWithValue("@StoreID", (comboBox_Store.SelectedIndex + 1).ToString());
                }
                try
                {
                    command.ExecuteNonQuery();
                    if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                    {
                        MessageBox.Show("Update Staff's Information Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(Properties.Settings.Default.EditStaffUpdateZh, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    closeConnection();
                }
                catch (MySqlException ex)
                {
                    if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                    {
                        MessageBox.Show("Update Staff's Information Unuccessfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(Properties.Settings.Default.EditStaffUpdateFailZh, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    closeConnection();
                }

                this.Close();
            }
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox_Depart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Depart.SelectedItem.Equals("Sales"))
            {
                comboBox_Store.Visible = true;
            }

            else
            {
                comboBox_Store.Visible = false;
            }
        }

        private void EditStaffForm_Load(object sender, EventArgs e)
        {
            comboBox_Store.Visible = false;
            comboBox_Store.SelectedIndex = 0;


            //////////////////////////
            openConnection();

            string sql = "SELECT * FROM staff WHERE staffID = @staffID;";
            command = new MySqlCommand(sql, conn);
            command.Parameters.AddWithValue("staffID", getStaffID);

            MySqlDataReader reader;
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                //textBox_Date.Text = reader["Date"].ToString();
                textbox_StaffID.Text = reader["StaffID"].ToString();
                textBox_StaffName.Text = reader["StaffName"].ToString();
                comboBox_Gender.Text = reader["Gender"].ToString();
                dateTimePicker_DateOfBirth.Text = Convert.ToDateTime(reader["DateOfBirth"]).ToString("yyyy/MM/dd");
                textBox_Tel.Text = reader["Tel"].ToString();
                textBox_Email.Text = reader["Email"].ToString();
                comboBox_Depart.Text = reader["Depart"].ToString();
                
                comboBox_Position.Text = reader["Position"].ToString();
                textBox_Salary.Text = reader["Salary"].ToString();


                if (!reader["StoreID"].ToString().Equals(""))
                {
                    comboBox_Store.Text = reader["StoreID"].ToString();
                }
                

            }
            closeConnection();

            //////////////////////////
        }
    }
}

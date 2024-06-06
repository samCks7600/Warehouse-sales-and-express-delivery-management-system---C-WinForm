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
    public partial class CreateStaffForm : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user id =root;password=;database=betterlimited");
        MySqlCommand command;

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

        public CreateStaffForm()
        {
            InitializeComponent();
        }

        private void textBox_Password_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)) )
            {
                e.Handled = true;
            }

        }

        private void textBox_Salary_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }

        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            if (textBox_StaffName.Text.Trim().Length < 1 ||
               comboBox_Gender.SelectedItem == null ||
               textBox_Tel.Text.Trim().Length < 1 ||
               textBox_Email.Text.Trim().Length < 1 ||
               comboBox_Depart.SelectedItem == null ||
               comboBox_Position.SelectedItem == null ||
               textBox_Salary.Text.Trim().Length < 1
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
            else {
                string sql;
                if (comboBox_Depart.SelectedItem.Equals("Sales"))
                {
                    sql = "INSERT INTO staff(StaffID,StaffName,Gender,DateOfBirth,Tel,Email,Position,Depart,Salary,StoreID) " +
                          "VALUES (NULL,@StaffName,@Gender,@DateOfBirth,@Tel,@Email,@Position,@Depart,@Salary,@StoreID)";
                }
                else
                {
                    sql = "INSERT INTO  staff ( StaffID,StaffName,Gender,DateOfBirth,Tel,Email,Position,Depart,Salary,StoreID) " +
                          "VALUES (NULL,@StaffName,@Gender,@DateOfBirth,@Tel,@Email,@Position,@Depart,@Salary,NULL)";
                }
                openConnection();

                command = new MySqlCommand(sql, conn);
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
                    command.Parameters.AddWithValue("@StoreID", (comboBox_Store.SelectedIndex+1).ToString());
                }
                try
                {
                    command.ExecuteNonQuery();
                    if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                    {
                        MessageBox.Show("Create Staff Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(Properties.Settings.Default.CreateStaffFormMsgBoxSucZh, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    closeConnection();
                }
                catch (MySqlException ex)
                {
                    if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                    {
                        MessageBox.Show("Create Staff unsuccessfully. \n " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(Properties.Settings.Default.CreateStaffFormMsgBoxUnucZh, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    MessageBox.Show("Create Staff unuccessfuly. \n " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    closeConnection();
                }

                this.Close();

            }
        }

        private void CreateStaffForm_Load(object sender, EventArgs e)
        {
            comboBox_Store.Visible = false;
            comboBox_Store.SelectedIndex = 0;

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

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

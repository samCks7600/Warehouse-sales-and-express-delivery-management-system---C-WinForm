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
    public partial class UpdateUserAccountForm : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user id =root;password=;database=betterlimited");
        MySqlCommand command;
        string userAccountID;
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


        public UpdateUserAccountForm()
        {
            InitializeComponent();
        }

        private void UpdateUserAccountForm_Load(object sender, EventArgs e)
        {
            openConnection();

            string sql = "SELECT useraccount.UserAccountID," +
                "useraccount.StaffID," +
                "useraccount.UserName," +
                "useraccount.Email," +
                "staff.Position," +
                "staff.Depart" +
                " FROM useraccount,staff" +
                " WHERE useraccount.StaffID = staff.StaffID " +
                "AND useraccount.UserAccountID = @userAccountID;";
            command = new MySqlCommand(sql, conn);
            command.Parameters.AddWithValue("userAccountID", userAccountID);

            MySqlDataReader reader;
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                //textBox_Date.Text = reader["Date"].ToString();
                textBox_UserAccountID.Text = reader["UserAccountID"].ToString();
                textbox_StaffID.Text = reader["StaffID"].ToString();
                textBox_UserName.Text = reader["UserName"].ToString();
                textBox_Email.Text = reader["Email"].ToString();
                comboBox_Position.Text = reader["Position"].ToString();
                comboBox_Depart.Text = reader["Depart"].ToString();
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

            string sql = "UPDATE useraccount SET UserName=@UserName,Email=@Email" +
                " WHERE UserAccountID = @UserAccountID; " +
                "UPDATE staff SET Position=@Position,Depart=@Depart Where StaffID =@StaffID";
            command = new MySqlCommand(sql, conn);
            command.Parameters.AddWithValue("UserName", textBox_UserName.Text);
            command.Parameters.AddWithValue("Email", textBox_Email.Text);
            command.Parameters.AddWithValue("UserAccountID", textBox_UserAccountID.Text);
            command.Parameters.AddWithValue("Position", comboBox_Position.Text);
            command.Parameters.AddWithValue("Depart", comboBox_Depart.Text);
            command.Parameters.AddWithValue("StaffID", textbox_StaffID.Text);


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

        }
    }
}

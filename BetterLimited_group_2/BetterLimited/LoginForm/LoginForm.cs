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
using System.Threading;
using System.Globalization;

namespace BetterLimited
{
    public partial class LoginForm : Form
    {
        Boolean show;
        Bitmap picShow = Properties.Resources.show;
        Bitmap picHide = Properties.Resources.hide;
        string username, password, sqlStr, staffid;

        // Setting for MySql Database.
        MySqlConnection conn = new MySqlConnection("server=localhost;user id =root;password=;database=betterlimited");
        MySqlCommand command;
        public LoginForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            CultureInfo currentCulture = Thread.CurrentThread.CurrentUICulture;

        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = btnLogin;
            txtUsername.ForeColor = Color.Gray;
            txtPassword.ForeColor = Color.Gray;
            username = txtUsername.Text.ToString();
            password = txtPassword.Text.ToString();
        }

        public string getStaffID
        {
            get
            {
                sqlStr = "SELECT staffID FROM useraccount WHERE UserName = '" + txtUsername.Text + "' AND Password = '" + txtPassword.Text + "'";
                return staffid = selectQueryValue(sqlStr, "StaffID");
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

        //Insert, Update, and Delete data query
        public bool iudQuery(string sql)
        {
            try
            {
                openConnection();
                command = new MySqlCommand(sql, conn);
                if (command.ExecuteNonQuery() == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                closeConnection();
            }
        }

        //Select data query
        public bool selectQuery(string sql)
        {
            command = conn.CreateCommand();
            command.CommandText = sql;
            try
            {
                openConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                closeConnection();
                return true;
            }
            else
            {
                closeConnection();
                return false;
            }
        }

        public string selectQueryValue(string sql, string column)
        {
            command = conn.CreateCommand();
            command.CommandText = sql;
            try
            {
                openConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                return reader.GetString(column);
            }
            else
            {
                closeConnection();
                return null;
            }
        }

        
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == username)
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = username;
                txtUsername.ForeColor = Color.Gray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == password && !show)
            {
                txtPassword.Text = "";
                txtPassword.PasswordChar = '*';
                txtPassword.ForeColor = Color.Black;
            }
            else if (txtPassword.Text == password && show)
            {
                txtPassword.Text = "";
                txtPassword.PasswordChar = '\0';
                txtPassword.ForeColor = Color.Black;
            }
            else if (txtPassword.Text == null && show)
            {
                txtPassword.Text = "";
                txtPassword.PasswordChar = '\0';
                txtPassword.ForeColor = Color.Black;
            }
        }
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = password;
                txtPassword.PasswordChar = '\0';
                txtPassword.ForeColor = Color.Gray;
            }
        }

        private void lblSignup_Click(object sender, EventArgs e)
        {
            SignupForm singupform = new SignupForm();
            this.Hide();
            singupform.Show();

        }
        private void picShowPassword_Click(object sender, EventArgs e)
        {

            if (picShowPassword.Image == picHide)
            {
                show = false;
                picShowPassword.Image = picShow;
            }
            else
            {
                show = true;
                picShowPassword.Image = picHide;
            }

            if (txtPassword.Text != password || txtPassword.Text == "")
            {
                txtPassword.PasswordChar = show ? '\0' : '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            sqlStr = "SELECT * FROM useraccount WHERE UserName = '" + txtUsername.Text + "' AND Password = '" + txtPassword.Text + "'";
            if (selectQuery(sqlStr))
            {
                sqlStr = "UPDATE useraccount SET LastLoginDateTime = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE UserName = '" + txtUsername.Text + "'; ";
                iudQuery(sqlStr);

                MenuForm menuform = new MenuForm();

                menuform.setStaffID = getStaffID;

                this.Hide();
                menuform.Show();
            }
            else
            {
                if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                {
                    MessageBox.Show(Properties.Settings.Default.LoginMsgBoxEn);
                }
                else
                {
                    MessageBox.Show(Properties.Settings.Default.LoginMsgBoxZh);
                }
                txtUsername.Text = username;
                txtUsername.ForeColor = Color.Gray;
                txtPassword.Text = password;
                txtPassword.PasswordChar = '\0';
                txtPassword.ForeColor = Color.Gray;
            }
        }

        private void comboBox_language_TextChanged(object sender, EventArgs e)
        {
            if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
            {
                comboBox_language.Text = Properties.Settings.Default.LanZh;
            }
            else
            {
                comboBox_language.Text = "Language";
            }
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm forgotpasswordform = new ForgotPasswordForm();
            this.Hide();
            forgotpasswordform.Show();
        }

        private void comboBox_language_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_language.SelectedIndex)
            {
                case 0:
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
                    break;
                case 1:
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("zh");
                    break;
            }
            this.Controls.Clear();
            ReloadForm();
        }

        private void ReloadForm()
        {
            InitializeComponent();
            this.ActiveControl = btnLogin;
            txtUsername.ForeColor = Color.Gray;
            txtPassword.ForeColor = Color.Gray;
            username = txtUsername.Text.ToString();
            password = txtPassword.Text.ToString();
        }
    }
}
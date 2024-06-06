using MySql.Data.MySqlClient;
using System.Net;
using System.Net.Mail;
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
    public partial class ForgotPasswordForm : Form
    {
        Bitmap picShow = Properties.Resources.show;
        Bitmap picHide = Properties.Resources.hide;
        string verifyCode;

        // Setting for MySql Database.
        MySqlConnection conn = new MySqlConnection("server=localhost;user id =root;password=;database=betterlimited");
        MySqlCommand command;
        string sqlStr;

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

        public ForgotPasswordForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            txtNewPassword.PasswordChar = '*';
            txtConfirmPassword.PasswordChar = '*';

            lblUsernameWarning.Text = "";
            lblNewPasswordWarning.Text = "";
            lblCPasswordWarning.Text = "";
        }

        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = btnReset;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            string errorMsg;
            if (!ValidUsername(txtUsername.Text, out errorMsg))
            {
                // Display the error text.
                lblUsernameWarning.Text = errorMsg;
            }
            else
            {
                lblUsernameWarning.Text = "";
            }
        }

        public bool ValidUsername(string username, out string errorMessage)
        {
            // Confirm that the username string is not empty.
            if (username.Length == 0)
            {
                errorMessage = "username is required.";
                return false;
            }

            // Confirm that the username string is in valid length (4 to 20).
            if (username.Length >= 4 && username.Length <= 20)
            {
                errorMessage = "";
                return true;
            }
            else
            {
                errorMessage = "Usernames must be between 4 and 20 characters.";
                return false;
            }
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            string errorMsg;
            if (!ValidNewPassword(txtNewPassword.Text, out errorMsg))
            {
                // Display the error text.
                lblNewPasswordWarning.Text = errorMsg;
            }
            else
            {
                lblNewPasswordWarning.Text = "";
            }
            if (!ConfirmPassword(txtConfirmPassword.Text, out errorMsg))
            {
                // Display the error text.
                lblCPasswordWarning.Text = errorMsg;
            }
            else
            {
                lblCPasswordWarning.Text = "";
            }
        }

        public bool ValidNewPassword(string password, out string errorMessage)
        {
            // Confirm that the password string is not empty.
            if (password.Length == 0)
            {
                errorMessage = "Password is required.";
                return false;
            }
            // Confirm that the password string is more than 8 characters.
            if (password.Length >= 8)
            {
                errorMessage = "";
                return true;
            }
            else
            {
                errorMessage = "Password must be at least 8 characters long.";
                return false;
            }
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            string errorMsg;
            if (!ConfirmPassword(txtConfirmPassword.Text, out errorMsg))
            {
                // Display the error text.
                lblCPasswordWarning.Text = errorMsg;
            }
            else
            {
                lblCPasswordWarning.Text = "";
            }
            if (!ValidNewPassword(txtNewPassword.Text, out errorMsg))
            {
                // Display the error text.
                lblNewPasswordWarning.Text = errorMsg;
            }
            else
            {
                lblNewPasswordWarning.Text = "";
            }
        }
        public bool ConfirmPassword(string cpassword, out string errorMessage)
        {
            // Confirm that the confirm password string is not empty.
            if (cpassword.Length == 0)
            {
                errorMessage = "Confirm password is required.";
                return false;
            }

            // Confirm that the confirm password is matching with the password.
            if (cpassword == txtNewPassword.Text)
            {
                errorMessage = "";
                return true;
            }
            else
            {
                errorMessage = "Passwords do not match. Please try again";
                return false;
            }
        }

        private void picShowNewPassword_Click(object sender, EventArgs e)
        {
            // Change the show password icon.
            if (picShowNewPassword.Image == picHide)
            {
                picShowNewPassword.Image = picShow;
            }
            else
            {
                picShowNewPassword.Image = picHide;
            }
            // Show or hide the password with '*'.
            txtNewPassword.PasswordChar = picShowNewPassword.Image == picHide ? '\0' : '*';
        }

        private void picShowCPassword_Click(object sender, EventArgs e)
        {
            if (picShowCPassword.Image == picHide)
            {
                picShowCPassword.Image = picShow;
            }
            else
            {
                picShowCPassword.Image = picHide;
            }
            txtConfirmPassword.PasswordChar = picShowCPassword.Image == picHide ? '\0' : '*';
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Return back to Login page.
            LoginForm loginfrm = new LoginForm();
            this.Hide();
            loginfrm.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all the text box text and warning label.
            txtUsername.Text = "";
            txtNewPassword.Text = "";
            txtConfirmPassword.Text = "";

            lblUsernameWarning.Text = "";
            lblNewPasswordWarning.Text = "";
            lblCPasswordWarning.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            if (!checkInputData())
            {
                MessageBox.Show("Reset failed. Please reset again.");
            }
            else if (!checkExistUsername(txtUsername.Text))
            {
                MessageBox.Show("Reset failed. Username was not found");
            }
            else
            {
                sqlStr = "UPDATE useraccount SET Password = '" + txtNewPassword.Text + "' WHERE UserName = '" + txtUsername.Text + "'; ";
                if (iudQuery(sqlStr))
                {
                    MessageBox.Show("Password has been reset successfully");
                    LoginForm loginform = new LoginForm();
                    this.Hide();
                    loginform.Show();
                }
            }
        }

        public bool checkInputData()
        {
            if (txtVerifyCode.Text == verifyCode && txtUsername.Text != "" && txtNewPassword.Text != "" && txtConfirmPassword.Text != "" &&
                lblUsernameWarning.Text + lblNewPasswordWarning.Text + lblCPasswordWarning.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool checkStaffID(string staffid)
        {
            sqlStr = "SELECT staffID FROM useraccount WHERE staffID = '" + staffid + "';";
            if (selectQuery(sqlStr))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool checkExistUsername(string name)
        {
            sqlStr = "SELECT username FROM useraccount WHERE username = '" + name + "';";
            if (selectQuery(sqlStr))
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public void sendEmail(string code)
        {
            try
            {
                SmtpClient Client = new SmtpClient()
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential()
                    {
                        UserName = "betterlimitedcompany@gmail.com",
                        Password = "rdclafuyqqhjzabi"
                    }
                };
                MailAddress FromEmail = new MailAddress("betterlimitedcompany@gmail.com", "Better Limited");
                MailAddress ToEmail = new MailAddress(getEmail(txtUsername.Text));

                closeConnection();
                MailMessage Message = new MailMessage()
                {
                    From = FromEmail,
                    Subject = "Reset password for Better Limited System Account",
                    Body = "Use this code: " + code + " to verify and reset password."
                };
                Message.To.Add(ToEmail);

                Client.SendCompleted += Client_SendCompleted;
                Client.SendMailAsync(Message);
            }
            catch (Exception Ex) {
                MessageBox.Show("Username not found.");
                txtUsername.Text = "";
            }
        }

        private void Client_SendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show("Something wrong \n " + e.Error.Message);
            }
            MessageBox.Show("Sent successfully, please check your email.");
            btnGetVerify.Enabled = false;
            txtUsername.Enabled = false;
        }

        private void btnGetVerify_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int code = random.Next(111111, 1000000);
            verifyCode = code.ToString();
            if (txtUsername.Text != "")
            {
                sendEmail(verifyCode);
            }
            else
            {
                MessageBox.Show("Please enter username.");
            }
        }

        public string getEmail(string uname)
        {
            try
            {
                sqlStr = "SELECT Email FROM useraccount WHERE username = '" + uname + "';";
                return selectQueryValue(sqlStr, "Email");
            }
            catch (Exception Ex)
            {
                return null;
            }

        }
    }
}

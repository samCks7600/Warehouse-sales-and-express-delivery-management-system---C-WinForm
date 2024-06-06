using MySql.Data.MySqlClient;
using System;
using System.Net;
using System.Net.Mail;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BetterLimited
{
    public partial class SignupForm : Form
    {
        Bitmap picShow = Properties.Resources.show;
        Bitmap picHide = Properties.Resources.hide;

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

        public SignupForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            txtPassword.PasswordChar = '*';
            txtConfirmPassword.PasswordChar = '*';

            //Handle the user's keyboard input in Staff ID text box.
            txtStaffID.KeyPress += new KeyPressEventHandler(txtStaffID_KeyPress);

            lblStaffIDWarning.Text = "";
            lblUsernameWarning.Text = "";
            lblPasswordWarning.Text = "";
            lblCPasswordWarning.Text = "";
            lblEmailWarning.Text = "";
        }

        private void SignupForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtStaffID;
        }

        private void txtStaffID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == Convert.ToChar(8)) //represents a backspace
            {
                e.Handled = false; //Accept the input.
                lblStaffIDWarning.Text = "";
            }
            else
            {
                e.Handled = true; //Reject the input.
                if (txtStaffID.TextLength != 5) {
                    if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                    {
                        lblStaffIDWarning.Text = Properties.Settings.Default.lblStaffIDWarningEn;
                    }
                    else
                    {
                        lblStaffIDWarning.Text = Properties.Settings.Default.lblStaffIDWarningZh;
                    }
                    
                }
            }
        }



        private void txtStaffID_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidStaffID(txtStaffID.Text, out errorMsg))
            {
                // Display the error text.
                lblStaffIDWarning.Text = errorMsg;
            }
            else
            {
                lblStaffIDWarning.Text = "";
            }
        }
        public bool ValidStaffID(string staffid, out string errorMessage)
        {
            // Confirm that the staff ID is not empty.
            if (staffid.Length == 0)
            {
                if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                {
                    errorMessage = Properties.Settings.Default.errorMessageRequiredEn;
                }
                else
                {
                    errorMessage = Properties.Settings.Default.errorMessageRequiredZh;
                }
                return false;
            }
            // Confirm that the staff ID is in correct length (5).
            if (staffid.Length == 5)
            {
                errorMessage = "";
                return true;
            }
            else
            {
                if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                {
                    errorMessage = Properties.Settings.Default.errorMessageFiveEn;
                }
                else
                {
                    errorMessage = Properties.Settings.Default.errorMessageFiveZh;
                }
                return false;
            }
        }
        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidUsername(txtUsername.Text, out errorMsg))
            {
                // Display the error text.
                lblUsernameWarning.Text = errorMsg;
            }
            else {
                lblUsernameWarning.Text = "";
            }
        }

        public bool ValidUsername(string username, out string errorMessage)
        {
            // Confirm that the username string is not empty.
            if (username.Length == 0)
            {
                if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                {
                    errorMessage = Properties.Settings.Default.errorMessageUsernameEn;
                }
                else
                {
                    errorMessage = Properties.Settings.Default.errorMessageUsernameZh;
                }
                return false;
            }

            // Confirm that the username string is in valid length (4 to 20).
            if (username.Length >= 4 && username.Length <= 20)
            {
                errorMessage = "";
                return true;
            } else
            {
                if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                {
                    errorMessage = Properties.Settings.Default.errorMessageUsernameValidEn;
                }
                else
                {
                    errorMessage = Properties.Settings.Default.errorMessageUsernameValidZh;
                }
                return false;
            }
        }
        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidPassword(txtPassword.Text, out errorMsg))
            {
                // Display the error text.
                lblPasswordWarning.Text = errorMsg;
            }
            else if (!CheckStrength(txtPassword.Text, out errorMsg)) 
            {
                lblPasswordWarning.Text = errorMsg;
            }
            else
            {
                lblPasswordWarning.Text = "";
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            string errorMsg;
            if (!CheckStrength(txtPassword.Text, out errorMsg))
            {
                // Display the error text.
                lblPasswordWarning.Text = errorMsg;
            }
            else
            {
                lblPasswordWarning.Text = "";
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

        private bool CheckStrength(string password, out string errorMessage)
        {
            if (Regex.IsMatch(password, @"[a-z]", RegexOptions.ECMAScript))
            {
                lblLowercase.BackColor = Color.Green;
            }
            else {
                lblLowercase.BackColor = Color.FromArgb(98, 114, 123);
            }

            if (Regex.IsMatch(password, @"[A-Z]", RegexOptions.ECMAScript))
            {
                lblUppercase.BackColor = Color.Green;
            }
            else
            {
                lblUppercase.BackColor = Color.FromArgb(98, 114, 123); ;
            }

            if (Regex.IsMatch(password, @"[\d]", RegexOptions.ECMAScript))
            {
                lblNumber.BackColor = Color.Green;
            }
            else
            {
                lblNumber.BackColor = Color.FromArgb(98, 114, 123); ;
            }

            if (Regex.IsMatch(password, @"[~`!@#$%\^\&\*\(\)\-_\+=\[\{\]\}\|\\;:'\""<\,>\.\?\/£]", RegexOptions.ECMAScript))
            {
                lblSymbols.BackColor = Color.Green;
            }
            else
            {
                lblSymbols.BackColor = Color.FromArgb(98, 114, 123);
            }
            if (lblLowercase.BackColor == Color.FromArgb(98, 114, 123) || lblUppercase.BackColor == Color.FromArgb(98, 114, 123) || lblNumber.BackColor == Color.FromArgb(98, 114, 123) || lblSymbols.BackColor == Color.FromArgb(98, 114, 123))
            {
                if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                {
                    errorMessage = Properties.Settings.Default.errorMessagePasswordEn;
                }
                else
                {
                    errorMessage = Properties.Settings.Default.errorMessagePasswordZh;
                }
                return false;
            }
            else {
                errorMessage = "";
                return true;
            }
        }
        public bool ValidPassword(string password, out string errorMessage)
        {
            // Confirm that the password string is not empty.
            if (password.Length == 0)
            {
                if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                {
                    errorMessage = Properties.Settings.Default.errorMessagePasswordRequiredEn;
                }
                else
                {
                    errorMessage = Properties.Settings.Default.errorMessagePasswordRequiredZh;
                }
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
                if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                {
                    errorMessage = Properties.Settings.Default.errorMessagePasswordValidEn;
                }
                else
                {
                    errorMessage = Properties.Settings.Default.errorMessagePasswordValidZh;
                }
                return false;
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
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
        }

        public bool ConfirmPassword(string cpassword, out string errorMessage)
        {
            // Confirm that the confirm password string is not empty.
            if (cpassword.Length == 0)
            {
                if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                {
                    errorMessage = Properties.Settings.Default.errorMessagePasswordConfirmEn;
                }
                else
                {
                    errorMessage = Properties.Settings.Default.errorMessagePasswordConfirmZh;
                }
                return false;
            }

            // Confirm that the confirm password is matching with the password.
            if (cpassword == txtPassword.Text)
            {
                errorMessage = "";
                return true;
            }
            else
            {
                if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                {
                    errorMessage = Properties.Settings.Default.errorMessagePasswordMatchEn;
                }
                else
                {
                    errorMessage = Properties.Settings.Default.errorMessagePasswordMatchZh;
                }
                return false;
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidEmail(txtEmail.Text, out errorMsg))
            {
                // Display the error text.
                lblEmailWarning.Text = errorMsg;
            }
            else
            {
                lblEmailWarning.Text = "";
            }
        }

        public bool ValidEmail(string email, out string errorMessage)
        {
            // Confirm that the email address string is not empty.
            if (email.Length == 0)
            {
                if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                {
                    errorMessage = Properties.Settings.Default.errorMessageEmailEn;
                }
                else
                {
                    errorMessage = Properties.Settings.Default.errorMessageEmailZh;
                }
                return false;
            }

            // Confirm that there is an "@" and a "." in the email address, and in the correct order.
            if (email.IndexOf("@") > -1)
            {
                if (email.IndexOf(".", email.IndexOf("@")) > email.IndexOf("@"))
                {
                    // Confirm that the "@" is not the first index and "." is not the last index.
                    if (email.IndexOf("@") != 0 && email.IndexOf(".") != email.Length - 1)
                    {
                        errorMessage = "";
                        return true;
                    }
                }
            }
            if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
            {
                errorMessage = Properties.Settings.Default.errorMessageEmailValidEn;
            }
            else
            {
                errorMessage = Properties.Settings.Default.errorMessageEmailValidZh;
            }
            return false;
        }

        private void picShowPassword_Click(object sender, EventArgs e)
        {
            // Change the show password icon.
            if (picShowPassword.Image == picHide)
            {
                picShowPassword.Image = picShow;
            }
            else
            {
                picShowPassword.Image = picHide;
            }
            // Show or hide the password with '*'.
            txtPassword.PasswordChar = picShowPassword.Image == picHide ? '\0' : '*';

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
            txtStaffID.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtEmail.Text = "";

            lblStaffIDWarning.Text = "";
            lblUsernameWarning.Text = "";
            lblPasswordWarning.Text = "";
            lblCPasswordWarning.Text = "";
            lblEmailWarning.Text = "";
        }


        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (!checkInputData()) {
                if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                {
                    MessageBox.Show(Properties.Settings.Default.SignupMsgBoxFailEn);
                }
                else
                {
                    MessageBox.Show(Properties.Settings.Default.SignupMsgBoxFailZh);
                }
            }
            else if (!checkStaffID(txtStaffID.Text)) {
                if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                {
                    MessageBox.Show(Properties.Settings.Default.SignupMsgBoxStaffIDFailEn);
                }
                else
                {
                    MessageBox.Show(Properties.Settings.Default.SignupMsgBoxStaffIDFailZh);
                }
            }
            else if (checkExistUsername(txtUsername.Text))
            {
                if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                {
                    MessageBox.Show(Properties.Settings.Default.SignupMsgBoxUsernameFailEn);
                }
                else
                {
                    MessageBox.Show(Properties.Settings.Default.SignupMsgBoxUsernameFailZh);
                }
            }
            else {
                sqlStr = "INSERT INTO useraccount VALUES(NULL, '" + txtStaffID.Text + "', '" + txtUsername.Text + "', '" + txtPassword.Text + "', '" + txtEmail.Text + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                + "', NULL);";
                if (iudQuery(sqlStr))
                {
                    sendEmail();
                }
            }
        }

        public bool checkInputData() 
        {
            if (txtStaffID.Text != "" && txtUsername.Text != "" && txtPassword.Text != "" && txtConfirmPassword.Text != "" && txtEmail.Text != ""
                && lblStaffIDWarning.Text + lblUsernameWarning.Text + lblPasswordWarning.Text + lblCPasswordWarning.Text + lblEmailWarning.Text == "")
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
            sqlStr = "SELECT staffID FROM staff WHERE staffID = '" + staffid + "';";
            if (selectQuery(sqlStr))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool checkExistUsername(string name) {
            sqlStr = "SELECT username FROM useraccount WHERE username = '" + name + "';";
            if (selectQuery(sqlStr))
            {
                return true;
            }
            else {
                return false;
            }
        }

        public void sendEmail()
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
            MailAddress ToEmail = new MailAddress(txtEmail.Text);
            closeConnection();
            MailMessage Message = new MailMessage()
            {
                From = FromEmail,
                Subject = "Welcome to Better Limited - Create account successfully",
                Body = "Hello " + txtStaffID.Text + ",\nYour username is " + txtUsername.Text,
            };
            Message.To.Add(ToEmail);

            Client.SendCompleted += Client_SendCompleted;
            Client.SendMailAsync(Message);
        }

        private void Client_SendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
            {
                DialogResult result = MessageBox.Show(Properties.Settings.Default.SignupMsgBoxEmailEn, "Welcome", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    LoginForm loginform = new LoginForm();
                    this.Hide();
                    loginform.Show();
                }
            }
            else
            {
                DialogResult result = MessageBox.Show(Properties.Settings.Default.SignupMsgBoxEmailZh, Properties.Settings.Default.SignupMsgBoxEmailTitleZh, MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    LoginForm loginform = new LoginForm();
                    this.Hide();
                    loginform.Show();
                }
            }
        }
    }
}
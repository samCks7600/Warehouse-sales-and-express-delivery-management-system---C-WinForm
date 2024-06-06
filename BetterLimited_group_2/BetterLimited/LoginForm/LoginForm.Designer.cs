
namespace BetterLimited
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblForgotPassword = new System.Windows.Forms.Label();
            this.lblSignup = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.picUsername = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.picPassword = new System.Windows.Forms.PictureBox();
            this.picShowPassword = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox_language = new System.Windows.Forms.ComboBox();
            this.gradientTable1 = new BetterLimited.GradientTable();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsername)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShowPassword)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gradientTable1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            resources.ApplyResources(this.txtUsername, "txtUsername");
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // lblForgotPassword
            // 
            resources.ApplyResources(this.lblForgotPassword, "lblForgotPassword");
            this.lblForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForgotPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Click += new System.EventHandler(this.lblForgotPassword_Click);
            // 
            // lblSignup
            // 
            resources.ApplyResources(this.lblSignup, "lblSignup");
            this.lblSignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSignup.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSignup.Name = "lblSignup";
            this.lblSignup.Click += new System.EventHandler(this.lblSignup_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(179)))), ((int)(((byte)(190)))));
            this.label1.Name = "label1";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.picUsername, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtUsername, 1, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // picUsername
            // 
            resources.ApplyResources(this.picUsername, "picUsername");
            this.picUsername.Name = "picUsername";
            this.picUsername.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.picPassword, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.picShowPassword, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtPassword, 1, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // picPassword
            // 
            resources.ApplyResources(this.picPassword, "picPassword");
            this.picPassword.Name = "picPassword";
            this.picPassword.TabStop = false;
            // 
            // picShowPassword
            // 
            resources.ApplyResources(this.picShowPassword, "picShowPassword");
            this.picShowPassword.Image = global::BetterLimited.Properties.Resources.show;
            this.picShowPassword.Name = "picShowPassword";
            this.picShowPassword.TabStop = false;
            this.picShowPassword.Click += new System.EventHandler(this.picShowPassword_Click);
            // 
            // tableLayoutPanel5
            // 
            resources.ApplyResources(this.tableLayoutPanel5, "tableLayoutPanel5");
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            // 
            // tableLayoutPanel6
            // 
            resources.ApplyResources(this.tableLayoutPanel6, "tableLayoutPanel6");
            this.tableLayoutPanel6.Controls.Add(this.lblForgotPassword, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.lblSignup, 1, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.btnLogin, 1, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // btnLogin
            // 
            resources.ApplyResources(this.btnLogin, "btnLogin");
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(142)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            resources.ApplyResources(this.tableLayoutPanel7, "tableLayoutPanel7");
            this.tableLayoutPanel7.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.comboBox_language, 2, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BackgroundImage = global::BetterLimited.Properties.Resources.logo_big;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // comboBox_language
            // 
            resources.ApplyResources(this.comboBox_language, "comboBox_language");
            this.comboBox_language.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.comboBox_language.ForeColor = System.Drawing.Color.White;
            this.comboBox_language.FormattingEnabled = true;
            this.comboBox_language.Items.AddRange(new object[] {
            resources.GetString("comboBox_language.Items"),
            resources.GetString("comboBox_language.Items1")});
            this.comboBox_language.Name = "comboBox_language";
            this.comboBox_language.SelectedIndexChanged += new System.EventHandler(this.comboBox_language_SelectedIndexChanged);
            this.comboBox_language.TextChanged += new System.EventHandler(this.comboBox_language_TextChanged);
            // 
            // gradientTable1
            // 
            this.gradientTable1.ColorBottom = System.Drawing.SystemColors.ControlLight;
            this.gradientTable1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(70)))), ((int)(((byte)(79)))));
            resources.ApplyResources(this.gradientTable1, "gradientTable1");
            this.gradientTable1.Controls.Add(this.label3, 0, 1);
            this.gradientTable1.Controls.Add(this.label2, 0, 0);
            this.gradientTable1.Name = "gradientTable1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.gradientTable1);
            this.Controls.Add(this.tableLayoutPanel7);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsername)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShowPassword)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gradientTable1.ResumeLayout(false);
            this.gradientTable1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblForgotPassword;
        private System.Windows.Forms.Label lblSignup;
        private System.Windows.Forms.PictureBox picShowPassword;
        private System.Windows.Forms.PictureBox picUsername;
        private System.Windows.Forms.PictureBox picPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private GradientTable gradientTable1;
        private System.Windows.Forms.ComboBox comboBox_language;
    }
}


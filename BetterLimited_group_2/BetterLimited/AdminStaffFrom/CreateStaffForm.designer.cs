namespace BetterLimited
{
    partial class CreateStaffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateStaffForm));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Position = new System.Windows.Forms.ComboBox();
            this.comboBox_Depart = new System.Windows.Forms.ComboBox();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_Create = new System.Windows.Forms.Button();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_StaffID = new System.Windows.Forms.Label();
            this.label_DateOfBirth = new System.Windows.Forms.Label();
            this.label_UserAccountID = new System.Windows.Forms.Label();
            this.textBox_StaffName = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox_Tel = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Gender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Salary = new System.Windows.Forms.TextBox();
            this.dateTimePicker_DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.comboBox_Store = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // comboBox_Position
            // 
            resources.ApplyResources(this.comboBox_Position, "comboBox_Position");
            this.comboBox_Position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Position.FormattingEnabled = true;
            this.comboBox_Position.Items.AddRange(new object[] {
            resources.GetString("comboBox_Position.Items"),
            resources.GetString("comboBox_Position.Items1"),
            resources.GetString("comboBox_Position.Items2"),
            resources.GetString("comboBox_Position.Items3"),
            resources.GetString("comboBox_Position.Items4"),
            resources.GetString("comboBox_Position.Items5"),
            resources.GetString("comboBox_Position.Items6"),
            resources.GetString("comboBox_Position.Items7"),
            resources.GetString("comboBox_Position.Items8"),
            resources.GetString("comboBox_Position.Items9"),
            resources.GetString("comboBox_Position.Items10"),
            resources.GetString("comboBox_Position.Items11")});
            this.comboBox_Position.Name = "comboBox_Position";
            // 
            // comboBox_Depart
            // 
            resources.ApplyResources(this.comboBox_Depart, "comboBox_Depart");
            this.comboBox_Depart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Depart.FormattingEnabled = true;
            this.comboBox_Depart.Items.AddRange(new object[] {
            resources.GetString("comboBox_Depart.Items"),
            resources.GetString("comboBox_Depart.Items1"),
            resources.GetString("comboBox_Depart.Items2"),
            resources.GetString("comboBox_Depart.Items3"),
            resources.GetString("comboBox_Depart.Items4"),
            resources.GetString("comboBox_Depart.Items5"),
            resources.GetString("comboBox_Depart.Items6")});
            this.comboBox_Depart.Name = "comboBox_Depart";
            this.comboBox_Depart.SelectedIndexChanged += new System.EventHandler(this.comboBox_Depart_SelectedIndexChanged);
            // 
            // button_Close
            // 
            resources.ApplyResources(this.button_Close, "button_Close");
            this.button_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_Close.Name = "button_Close";
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_Create
            // 
            resources.ApplyResources(this.button_Create, "button_Create");
            this.button_Create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_Create.Name = "button_Create";
            this.button_Create.UseVisualStyleBackColor = false;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // label_Email
            // 
            resources.ApplyResources(this.label_Email, "label_Email");
            this.label_Email.Name = "label_Email";
            // 
            // label_Password
            // 
            resources.ApplyResources(this.label_Password, "label_Password");
            this.label_Password.Name = "label_Password";
            // 
            // label_StaffID
            // 
            resources.ApplyResources(this.label_StaffID, "label_StaffID");
            this.label_StaffID.Name = "label_StaffID";
            // 
            // label_DateOfBirth
            // 
            resources.ApplyResources(this.label_DateOfBirth, "label_DateOfBirth");
            this.label_DateOfBirth.Name = "label_DateOfBirth";
            // 
            // label_UserAccountID
            // 
            resources.ApplyResources(this.label_UserAccountID, "label_UserAccountID");
            this.label_UserAccountID.Name = "label_UserAccountID";
            // 
            // textBox_StaffName
            // 
            resources.ApplyResources(this.textBox_StaffName, "textBox_StaffName");
            this.textBox_StaffName.Name = "textBox_StaffName";
            // 
            // textBox_Email
            // 
            resources.ApplyResources(this.textBox_Email, "textBox_Email");
            this.textBox_Email.Name = "textBox_Email";
            // 
            // textBox_Tel
            // 
            resources.ApplyResources(this.textBox_Tel, "textBox_Tel");
            this.textBox_Tel.Name = "textBox_Tel";
            this.textBox_Tel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Password_KeyPress);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Name = "panel1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Name = "label2";
            // 
            // comboBox_Gender
            // 
            resources.ApplyResources(this.comboBox_Gender, "comboBox_Gender");
            this.comboBox_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Gender.FormattingEnabled = true;
            this.comboBox_Gender.Items.AddRange(new object[] {
            resources.GetString("comboBox_Gender.Items"),
            resources.GetString("comboBox_Gender.Items1")});
            this.comboBox_Gender.Name = "comboBox_Gender";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // textBox_Salary
            // 
            resources.ApplyResources(this.textBox_Salary, "textBox_Salary");
            this.textBox_Salary.Name = "textBox_Salary";
            this.textBox_Salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Salary_KeyPress);
            // 
            // dateTimePicker_DateOfBirth
            // 
            resources.ApplyResources(this.dateTimePicker_DateOfBirth, "dateTimePicker_DateOfBirth");
            this.dateTimePicker_DateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_DateOfBirth.Name = "dateTimePicker_DateOfBirth";
            this.dateTimePicker_DateOfBirth.Value = new System.DateTime(2022, 6, 2, 0, 0, 0, 0);
            // 
            // comboBox_Store
            // 
            resources.ApplyResources(this.comboBox_Store, "comboBox_Store");
            this.comboBox_Store.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Store.FormattingEnabled = true;
            this.comboBox_Store.Items.AddRange(new object[] {
            resources.GetString("comboBox_Store.Items"),
            resources.GetString("comboBox_Store.Items1")});
            this.comboBox_Store.Name = "comboBox_Store";
            // 
            // CreateStaffForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox_Store);
            this.Controls.Add(this.dateTimePicker_DateOfBirth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Salary);
            this.Controls.Add(this.comboBox_Gender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Position);
            this.Controls.Add(this.comboBox_Depart);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_Create);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_StaffID);
            this.Controls.Add(this.label_DateOfBirth);
            this.Controls.Add(this.label_UserAccountID);
            this.Controls.Add(this.textBox_StaffName);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.textBox_Tel);
            this.Controls.Add(this.panel1);
            this.Name = "CreateStaffForm";
            this.Load += new System.EventHandler(this.CreateStaffForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Position;
        private System.Windows.Forms.ComboBox comboBox_Depart;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_StaffID;
        private System.Windows.Forms.Label label_DateOfBirth;
        private System.Windows.Forms.Label label_UserAccountID;
        private System.Windows.Forms.TextBox textBox_StaffName;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.TextBox textBox_Tel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Gender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Salary;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DateOfBirth;
        private System.Windows.Forms.ComboBox comboBox_Store;
    }
}
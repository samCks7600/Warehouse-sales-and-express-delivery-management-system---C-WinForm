namespace BetterLimited
{
    partial class UpdateInstallationStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateInstallationStatus));
            this.button_cacel = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.label_InstallationID = new System.Windows.Forms.Label();
            this.textBox_InstallationID = new System.Windows.Forms.TextBox();
            this.label_InstallationStatus = new System.Windows.Forms.Label();
            this.comboBox_InstallationStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_cacel
            // 
            resources.ApplyResources(this.button_cacel, "button_cacel");
            this.button_cacel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_cacel.Name = "button_cacel";
            this.button_cacel.UseVisualStyleBackColor = false;
            this.button_cacel.Click += new System.EventHandler(this.button_cacel_Click);
            // 
            // button_Update
            // 
            resources.ApplyResources(this.button_Update, "button_Update");
            this.button_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_Update.Name = "button_Update";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // label_InstallationID
            // 
            resources.ApplyResources(this.label_InstallationID, "label_InstallationID");
            this.label_InstallationID.Name = "label_InstallationID";
            // 
            // textBox_InstallationID
            // 
            resources.ApplyResources(this.textBox_InstallationID, "textBox_InstallationID");
            this.textBox_InstallationID.Name = "textBox_InstallationID";
            // 
            // label_InstallationStatus
            // 
            resources.ApplyResources(this.label_InstallationStatus, "label_InstallationStatus");
            this.label_InstallationStatus.Name = "label_InstallationStatus";
            // 
            // comboBox_InstallationStatus
            // 
            resources.ApplyResources(this.comboBox_InstallationStatus, "comboBox_InstallationStatus");
            this.comboBox_InstallationStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_InstallationStatus.FormattingEnabled = true;
            this.comboBox_InstallationStatus.Items.AddRange(new object[] {
            resources.GetString("comboBox_InstallationStatus.Items"),
            resources.GetString("comboBox_InstallationStatus.Items1")});
            this.comboBox_InstallationStatus.Name = "comboBox_InstallationStatus";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Name = "label2";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Name = "panel1";
            // 
            // UpdateInstallationStatus
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_cacel);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.label_InstallationID);
            this.Controls.Add(this.textBox_InstallationID);
            this.Controls.Add(this.label_InstallationStatus);
            this.Controls.Add(this.comboBox_InstallationStatus);
            this.Controls.Add(this.panel1);
            this.Name = "UpdateInstallationStatus";
            this.Load += new System.EventHandler(this.UpdateInstallationStatus_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_cacel;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Label label_InstallationID;
        private System.Windows.Forms.TextBox textBox_InstallationID;
        private System.Windows.Forms.Label label_InstallationStatus;
        private System.Windows.Forms.ComboBox comboBox_InstallationStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}
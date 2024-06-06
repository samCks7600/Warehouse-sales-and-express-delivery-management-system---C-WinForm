namespace BetterLimited
{
    partial class UpdateDeliveryStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateDeliveryStatus));
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_DeliveryStatus = new System.Windows.Forms.Label();
            this.comboBox_DeliveryStatus = new System.Windows.Forms.ComboBox();
            this.label_DeliveryID = new System.Windows.Forms.Label();
            this.textBox_DeliveryID = new System.Windows.Forms.TextBox();
            this.button_cacel = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // label_DeliveryStatus
            // 
            resources.ApplyResources(this.label_DeliveryStatus, "label_DeliveryStatus");
            this.label_DeliveryStatus.Name = "label_DeliveryStatus";
            // 
            // comboBox_DeliveryStatus
            // 
            resources.ApplyResources(this.comboBox_DeliveryStatus, "comboBox_DeliveryStatus");
            this.comboBox_DeliveryStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_DeliveryStatus.FormattingEnabled = true;
            this.comboBox_DeliveryStatus.Items.AddRange(new object[] {
            resources.GetString("comboBox_DeliveryStatus.Items"),
            resources.GetString("comboBox_DeliveryStatus.Items1"),
            resources.GetString("comboBox_DeliveryStatus.Items2")});
            this.comboBox_DeliveryStatus.Name = "comboBox_DeliveryStatus";
            // 
            // label_DeliveryID
            // 
            resources.ApplyResources(this.label_DeliveryID, "label_DeliveryID");
            this.label_DeliveryID.Name = "label_DeliveryID";
            // 
            // textBox_DeliveryID
            // 
            resources.ApplyResources(this.textBox_DeliveryID, "textBox_DeliveryID");
            this.textBox_DeliveryID.Name = "textBox_DeliveryID";
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
            // UpdateDeliveryStatus
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_cacel);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.label_DeliveryID);
            this.Controls.Add(this.textBox_DeliveryID);
            this.Controls.Add(this.label_DeliveryStatus);
            this.Controls.Add(this.comboBox_DeliveryStatus);
            this.Controls.Add(this.panel1);
            this.Name = "UpdateDeliveryStatus";
            this.Load += new System.EventHandler(this.UpdateInstallStatus_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_DeliveryStatus;
        private System.Windows.Forms.ComboBox comboBox_DeliveryStatus;
        private System.Windows.Forms.Label label_DeliveryID;
        private System.Windows.Forms.TextBox textBox_DeliveryID;
        private System.Windows.Forms.Button button_cacel;
        private System.Windows.Forms.Button button_Update;
    }
}
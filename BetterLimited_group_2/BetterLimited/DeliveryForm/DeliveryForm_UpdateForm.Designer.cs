
namespace BetterLimited
{
    partial class DeliveryForm_UpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryForm_UpdateForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_cacel = new System.Windows.Forms.Button();
            this.label_DeliveryTime = new System.Windows.Forms.Label();
            this.label_DeliveryDate = new System.Windows.Forms.Label();
            this.label_deliveryStatus = new System.Windows.Forms.Label();
            this.label_SalesOrderID = new System.Windows.Forms.Label();
            this.label_DeliveryID = new System.Windows.Forms.Label();
            this.textBox_DeliveryID = new System.Windows.Forms.TextBox();
            this.button_Update = new System.Windows.Forms.Button();
            this.textBox_SalesOrderID = new System.Windows.Forms.TextBox();
            this.comboBox_deliveryStatus = new System.Windows.Forms.ComboBox();
            this.dateTimePicker__DeliveryTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker__DeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Name = "label1";
            // 
            // button_cacel
            // 
            resources.ApplyResources(this.button_cacel, "button_cacel");
            this.button_cacel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_cacel.Name = "button_cacel";
            this.button_cacel.UseVisualStyleBackColor = false;
            this.button_cacel.Click += new System.EventHandler(this.button_cacel_Click);
            // 
            // label_DeliveryTime
            // 
            resources.ApplyResources(this.label_DeliveryTime, "label_DeliveryTime");
            this.label_DeliveryTime.Name = "label_DeliveryTime";
            // 
            // label_DeliveryDate
            // 
            resources.ApplyResources(this.label_DeliveryDate, "label_DeliveryDate");
            this.label_DeliveryDate.Name = "label_DeliveryDate";
            // 
            // label_deliveryStatus
            // 
            resources.ApplyResources(this.label_deliveryStatus, "label_deliveryStatus");
            this.label_deliveryStatus.Name = "label_deliveryStatus";
            // 
            // label_SalesOrderID
            // 
            resources.ApplyResources(this.label_SalesOrderID, "label_SalesOrderID");
            this.label_SalesOrderID.Name = "label_SalesOrderID";
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
            // button_Update
            // 
            resources.ApplyResources(this.button_Update, "button_Update");
            this.button_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_Update.Name = "button_Update";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // textBox_SalesOrderID
            // 
            resources.ApplyResources(this.textBox_SalesOrderID, "textBox_SalesOrderID");
            this.textBox_SalesOrderID.Name = "textBox_SalesOrderID";
            // 
            // comboBox_deliveryStatus
            // 
            resources.ApplyResources(this.comboBox_deliveryStatus, "comboBox_deliveryStatus");
            this.comboBox_deliveryStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_deliveryStatus.FormattingEnabled = true;
            this.comboBox_deliveryStatus.Items.AddRange(new object[] {
            resources.GetString("comboBox_deliveryStatus.Items"),
            resources.GetString("comboBox_deliveryStatus.Items1"),
            resources.GetString("comboBox_deliveryStatus.Items2")});
            this.comboBox_deliveryStatus.Name = "comboBox_deliveryStatus";
            // 
            // dateTimePicker__DeliveryTime
            // 
            resources.ApplyResources(this.dateTimePicker__DeliveryTime, "dateTimePicker__DeliveryTime");
            this.dateTimePicker__DeliveryTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker__DeliveryTime.Name = "dateTimePicker__DeliveryTime";
            // 
            // dateTimePicker__DeliveryDate
            // 
            resources.ApplyResources(this.dateTimePicker__DeliveryDate, "dateTimePicker__DeliveryDate");
            this.dateTimePicker__DeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker__DeliveryDate.Name = "dateTimePicker__DeliveryDate";
            this.dateTimePicker__DeliveryDate.Value = new System.DateTime(2022, 6, 2, 0, 0, 0, 0);
            this.dateTimePicker__DeliveryDate.ValueChanged += new System.EventHandler(this.dateTimePicker__DeliveryDate_ValueChanged);
            // 
            // DeliveryForm_UpdateForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePicker__DeliveryTime);
            this.Controls.Add(this.dateTimePicker__DeliveryDate);
            this.Controls.Add(this.button_cacel);
            this.Controls.Add(this.label_DeliveryTime);
            this.Controls.Add(this.label_DeliveryDate);
            this.Controls.Add(this.label_deliveryStatus);
            this.Controls.Add(this.label_SalesOrderID);
            this.Controls.Add(this.label_DeliveryID);
            this.Controls.Add(this.textBox_DeliveryID);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.textBox_SalesOrderID);
            this.Controls.Add(this.comboBox_deliveryStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DeliveryForm_UpdateForm";
            this.Load += new System.EventHandler(this.DeliveryForm_UpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_cacel;
        private System.Windows.Forms.Label label_DeliveryTime;
        private System.Windows.Forms.Label label_DeliveryDate;
        private System.Windows.Forms.Label label_deliveryStatus;
        private System.Windows.Forms.Label label_SalesOrderID;
        private System.Windows.Forms.Label label_DeliveryID;
        private System.Windows.Forms.TextBox textBox_DeliveryID;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.TextBox textBox_SalesOrderID;
        private System.Windows.Forms.ComboBox comboBox_deliveryStatus;
        private System.Windows.Forms.DateTimePicker dateTimePicker__DeliveryTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker__DeliveryDate;
    }
}
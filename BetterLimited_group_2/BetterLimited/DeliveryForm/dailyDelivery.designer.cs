
namespace BetterLimited
{
    partial class dailyDelivery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dailyDelivery));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_dealiyDelivery = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label_Date = new System.Windows.Forms.Label();
            this.textBox_Nowdate = new System.Windows.Forms.TextBox();
            this.dateTimePicker__DeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.label_DeliveryDate = new System.Windows.Forms.Label();
            this.button_Search = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblTimeSlot = new System.Windows.Forms.Label();
            this.label_Noduty = new System.Windows.Forms.Label();
            this.textBox_WorkmanID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dealiyDelivery)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Name = "panel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // dataGridView_dealiyDelivery
            // 
            resources.ApplyResources(this.dataGridView_dealiyDelivery, "dataGridView_dealiyDelivery");
            this.dataGridView_dealiyDelivery.AllowUserToAddRows = false;
            this.dataGridView_dealiyDelivery.AllowUserToDeleteRows = false;
            this.dataGridView_dealiyDelivery.AllowUserToResizeRows = false;
            this.dataGridView_dealiyDelivery.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_dealiyDelivery.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_dealiyDelivery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_dealiyDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_dealiyDelivery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column6});
            this.dataGridView_dealiyDelivery.GridColor = System.Drawing.Color.White;
            this.dataGridView_dealiyDelivery.Name = "dataGridView_dealiyDelivery";
            this.dataGridView_dealiyDelivery.ReadOnly = true;
            this.dataGridView_dealiyDelivery.RowHeadersVisible = false;
            this.dataGridView_dealiyDelivery.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_dealiyDelivery.RowTemplate.Height = 27;
            this.dataGridView_dealiyDelivery.ShowEditingIcon = false;
            this.dataGridView_dealiyDelivery.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_dealiyDelivery_CellClick);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label_Date
            // 
            resources.ApplyResources(this.label_Date, "label_Date");
            this.label_Date.Name = "label_Date";
            // 
            // textBox_Nowdate
            // 
            resources.ApplyResources(this.textBox_Nowdate, "textBox_Nowdate");
            this.textBox_Nowdate.Name = "textBox_Nowdate";
            // 
            // dateTimePicker__DeliveryDate
            // 
            resources.ApplyResources(this.dateTimePicker__DeliveryDate, "dateTimePicker__DeliveryDate");
            this.dateTimePicker__DeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker__DeliveryDate.Name = "dateTimePicker__DeliveryDate";
            this.dateTimePicker__DeliveryDate.Value = new System.DateTime(2022, 6, 2, 0, 0, 0, 0);
            // 
            // label_DeliveryDate
            // 
            resources.ApplyResources(this.label_DeliveryDate, "label_DeliveryDate");
            this.label_DeliveryDate.Name = "label_DeliveryDate";
            // 
            // button_Search
            // 
            resources.ApplyResources(this.button_Search, "button_Search");
            this.button_Search.Name = "button_Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblTimeSlot
            // 
            resources.ApplyResources(this.lblTimeSlot, "lblTimeSlot");
            this.lblTimeSlot.Name = "lblTimeSlot";
            // 
            // label_Noduty
            // 
            resources.ApplyResources(this.label_Noduty, "label_Noduty");
            this.label_Noduty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label_Noduty.Name = "label_Noduty";
            // 
            // textBox_WorkmanID
            // 
            resources.ApplyResources(this.textBox_WorkmanID, "textBox_WorkmanID");
            this.textBox_WorkmanID.Name = "textBox_WorkmanID";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "DeliveryID";
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "SalesOrderID";
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DeliveryDate";
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DeliveryTime";
            resources.ApplyResources(this.Column4, "Column4");
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DeliveryStatus";
            resources.ApplyResources(this.Column5, "Column5");
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "WorkmanID";
            resources.ApplyResources(this.Column7, "Column7");
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column6
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.Column6, "Column6");
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Text = "Update Status";
            this.Column6.UseColumnTextForButtonValue = true;
            // 
            // dailyDelivery
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.textBox_WorkmanID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_Noduty);
            this.Controls.Add(this.lblTimeSlot);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.dateTimePicker__DeliveryDate);
            this.Controls.Add(this.label_DeliveryDate);
            this.Controls.Add(this.textBox_Nowdate);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView_dealiyDelivery);
            this.Controls.Add(this.panel1);
            this.Name = "dailyDelivery";
            this.Load += new System.EventHandler(this.dailyDelivery_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dealiyDelivery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.DataGridView dataGridView_dealiyDelivery;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox_Nowdate;
        private System.Windows.Forms.DateTimePicker dateTimePicker__DeliveryDate;
        private System.Windows.Forms.Label label_DeliveryDate;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblTimeSlot;
        private System.Windows.Forms.Label label_Noduty;
        private System.Windows.Forms.TextBox textBox_WorkmanID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
    }
}
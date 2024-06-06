namespace BetterLimited
{
    partial class ViewDeliveryWorkmanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewDeliveryWorkmanForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_DeliveryTable = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_Search = new System.Windows.Forms.Button();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.label_DeliveryTime = new System.Windows.Forms.Label();
            this.label_DeliveryDate = new System.Windows.Forms.Label();
            this.label_deliveryStatus = new System.Windows.Forms.Label();
            this.label_SalesOrderID = new System.Windows.Forms.Label();
            this.label_DeliveryID = new System.Windows.Forms.Label();
            this.textBox_DeliveryID = new System.Windows.Forms.TextBox();
            this.textBox_SalesOrderID = new System.Windows.Forms.TextBox();
            this.button_Update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_WorkmanID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_DeliveryTime = new System.Windows.Forms.TextBox();
            this.textBox_DeliveryDate = new System.Windows.Forms.TextBox();
            this.textBox_DeliveryStatus = new System.Windows.Forms.TextBox();
            this.button_clearWorkmanID = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DeliveryTable)).BeginInit();
            this.SuspendLayout();
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
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Name = "label2";
            // 
            // dataGridView_DeliveryTable
            // 
            resources.ApplyResources(this.dataGridView_DeliveryTable, "dataGridView_DeliveryTable");
            this.dataGridView_DeliveryTable.AllowUserToAddRows = false;
            this.dataGridView_DeliveryTable.AllowUserToDeleteRows = false;
            this.dataGridView_DeliveryTable.AllowUserToResizeColumns = false;
            this.dataGridView_DeliveryTable.AllowUserToResizeRows = false;
            this.dataGridView_DeliveryTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_DeliveryTable.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_DeliveryTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_DeliveryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DeliveryTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column12,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.dataGridViewButtonColumn2});
            this.dataGridView_DeliveryTable.GridColor = System.Drawing.Color.White;
            this.dataGridView_DeliveryTable.MultiSelect = false;
            this.dataGridView_DeliveryTable.Name = "dataGridView_DeliveryTable";
            this.dataGridView_DeliveryTable.RowHeadersVisible = false;
            this.dataGridView_DeliveryTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_DeliveryTable.RowTemplate.Height = 27;
            this.dataGridView_DeliveryTable.ShowEditingIcon = false;
            this.dataGridView_DeliveryTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DeliveryTable_CellClick);
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "DeliveryID";
            resources.ApplyResources(this.Column7, "Column7");
            this.Column7.Name = "Column7";
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "SalesOrderID";
            resources.ApplyResources(this.Column12, "Column12");
            this.Column12.Name = "Column12";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "DeliveryDate";
            resources.ApplyResources(this.Column8, "Column8");
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "DeliveryTime";
            resources.ApplyResources(this.Column9, "Column9");
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "DeliveryStatus";
            resources.ApplyResources(this.Column10, "Column10");
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "WorkmanID";
            resources.ApplyResources(this.Column11, "Column11");
            this.Column11.Name = "Column11";
            // 
            // dataGridViewButtonColumn2
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("PMingLiU-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewButtonColumn2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewButtonColumn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.dataGridViewButtonColumn2, "dataGridViewButtonColumn2");
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.Text = "Select";
            this.dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // button_clear
            // 
            resources.ApplyResources(this.button_clear, "button_clear");
            this.button_clear.Name = "button_clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_Search
            // 
            resources.ApplyResources(this.button_Search, "button_Search");
            this.button_Search.Name = "button_Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // textBox_Search
            // 
            resources.ApplyResources(this.textBox_Search, "textBox_Search");
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Search_KeyPress);
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
            // textBox_SalesOrderID
            // 
            resources.ApplyResources(this.textBox_SalesOrderID, "textBox_SalesOrderID");
            this.textBox_SalesOrderID.Name = "textBox_SalesOrderID";
            // 
            // button_Update
            // 
            resources.ApplyResources(this.button_Update, "button_Update");
            this.button_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_Update.Name = "button_Update";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textBox_WorkmanID
            // 
            resources.ApplyResources(this.textBox_WorkmanID, "textBox_WorkmanID");
            this.textBox_WorkmanID.Name = "textBox_WorkmanID";
            this.textBox_WorkmanID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_WorkmanID_KeyPress);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_DeliveryTime
            // 
            resources.ApplyResources(this.textBox_DeliveryTime, "textBox_DeliveryTime");
            this.textBox_DeliveryTime.Name = "textBox_DeliveryTime";
            // 
            // textBox_DeliveryDate
            // 
            resources.ApplyResources(this.textBox_DeliveryDate, "textBox_DeliveryDate");
            this.textBox_DeliveryDate.Name = "textBox_DeliveryDate";
            // 
            // textBox_DeliveryStatus
            // 
            resources.ApplyResources(this.textBox_DeliveryStatus, "textBox_DeliveryStatus");
            this.textBox_DeliveryStatus.Name = "textBox_DeliveryStatus";
            // 
            // button_clearWorkmanID
            // 
            resources.ApplyResources(this.button_clearWorkmanID, "button_clearWorkmanID");
            this.button_clearWorkmanID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_clearWorkmanID.Name = "button_clearWorkmanID";
            this.button_clearWorkmanID.UseVisualStyleBackColor = false;
            this.button_clearWorkmanID.Click += new System.EventHandler(this.button_clearWorkmanID_Click);
            // 
            // ViewDeliveryWorkmanForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.button_clearWorkmanID);
            this.Controls.Add(this.textBox_DeliveryStatus);
            this.Controls.Add(this.textBox_DeliveryDate);
            this.Controls.Add(this.textBox_DeliveryTime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_WorkmanID);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.label_DeliveryTime);
            this.Controls.Add(this.label_DeliveryDate);
            this.Controls.Add(this.label_deliveryStatus);
            this.Controls.Add(this.label_SalesOrderID);
            this.Controls.Add(this.label_DeliveryID);
            this.Controls.Add(this.textBox_DeliveryID);
            this.Controls.Add(this.textBox_SalesOrderID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.dataGridView_DeliveryTable);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewDeliveryWorkmanForm";
            this.Load += new System.EventHandler(this.ViewEditDeliveryWorkmanForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DeliveryTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_DeliveryTable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Label label_DeliveryTime;
        private System.Windows.Forms.Label label_DeliveryDate;
        private System.Windows.Forms.Label label_deliveryStatus;
        private System.Windows.Forms.Label label_SalesOrderID;
        private System.Windows.Forms.Label label_DeliveryID;
        private System.Windows.Forms.TextBox textBox_DeliveryID;
        private System.Windows.Forms.TextBox textBox_SalesOrderID;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_WorkmanID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_DeliveryTime;
        private System.Windows.Forms.TextBox textBox_DeliveryDate;
        private System.Windows.Forms.TextBox textBox_DeliveryStatus;
        private System.Windows.Forms.Button button_clearWorkmanID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
    }
}
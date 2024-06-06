namespace BetterLimited
{
    partial class SalesOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesOrder));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_SalesOrderTable = new System.Windows.Forms.DataGridView();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button_clear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaidAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SalesOrderTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_SalesOrderTable
            // 
            this.dataGridView_SalesOrderTable.AllowUserToAddRows = false;
            this.dataGridView_SalesOrderTable.AllowUserToDeleteRows = false;
            this.dataGridView_SalesOrderTable.AllowUserToResizeRows = false;
            resources.ApplyResources(this.dataGridView_SalesOrderTable, "dataGridView_SalesOrderTable");
            this.dataGridView_SalesOrderTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_SalesOrderTable.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_SalesOrderTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_SalesOrderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SalesOrderTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.StoreID,
            this.Column2,
            this.PaymentStatus,
            this.PaidAmt,
            this.Date,
            this.Time,
            this.ExpDate,
            this.CustomerID,
            this.EditButton,
            this.DeleteButton});
            this.dataGridView_SalesOrderTable.GridColor = System.Drawing.Color.White;
            this.dataGridView_SalesOrderTable.Name = "dataGridView_SalesOrderTable";
            this.dataGridView_SalesOrderTable.ReadOnly = true;
            this.dataGridView_SalesOrderTable.RowHeadersVisible = false;
            this.dataGridView_SalesOrderTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_SalesOrderTable.RowTemplate.Height = 27;
            this.dataGridView_SalesOrderTable.ShowEditingIcon = false;
            this.dataGridView_SalesOrderTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_SalesOrderTable_CellClick);
            this.dataGridView_SalesOrderTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_SalesOrderTable_CellContentClick);
            this.dataGridView_SalesOrderTable.SelectionChanged += new System.EventHandler(this.dataGridView_SalesOrderTable_SelectionChanged);
            // 
            // textBox_Search
            // 
            resources.ApplyResources(this.textBox_Search, "textBox_Search");
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.TextChanged += new System.EventHandler(this.textBox_Search_TextChanged);
            this.textBox_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Search_KeyPress);
            // 
            // button_Search
            // 
            resources.ApplyResources(this.button_Search, "button_Search");
            this.button_Search.Name = "button_Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkTurquoise;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Name = "label2";
            // 
            // button_clear
            // 
            resources.ApplyResources(this.button_clear, "button_clear");
            this.button_clear.Name = "button_clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "SalesOrderID";
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // StoreID
            // 
            this.StoreID.DataPropertyName = "StoreID";
            this.StoreID.FillWeight = 70F;
            resources.ApplyResources(this.StoreID, "StoreID");
            this.StoreID.Name = "StoreID";
            this.StoreID.ReadOnly = true;
            this.StoreID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "StaffID";
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PaymentStatus
            // 
            this.PaymentStatus.DataPropertyName = "PaymentStatus";
            resources.ApplyResources(this.PaymentStatus, "PaymentStatus");
            this.PaymentStatus.Name = "PaymentStatus";
            this.PaymentStatus.ReadOnly = true;
            this.PaymentStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PaidAmt
            // 
            this.PaidAmt.DataPropertyName = "PaidAmt";
            resources.ApplyResources(this.PaidAmt, "PaidAmt");
            this.PaidAmt.Name = "PaidAmt";
            this.PaidAmt.ReadOnly = true;
            this.PaidAmt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            resources.ApplyResources(this.Date, "Date");
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Time
            // 
            this.Time.DataPropertyName = "Time";
            resources.ApplyResources(this.Time, "Time");
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ExpDate
            // 
            this.ExpDate.DataPropertyName = "ExpDate";
            resources.ApplyResources(this.ExpDate, "ExpDate");
            this.ExpDate.Name = "ExpDate";
            this.ExpDate.ReadOnly = true;
            this.ExpDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            resources.ApplyResources(this.CustomerID, "CustomerID");
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // EditButton
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("PMingLiU-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.EditButton.DefaultCellStyle = dataGridViewCellStyle3;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.EditButton, "EditButton");
            this.EditButton.Name = "EditButton";
            this.EditButton.ReadOnly = true;
            this.EditButton.Text = "Edit";
            this.EditButton.UseColumnTextForButtonValue = true;
            // 
            // DeleteButton
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("PMingLiU-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.DeleteButton.DefaultCellStyle = dataGridViewCellStyle4;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.DeleteButton, "DeleteButton");
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.ReadOnly = true;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseColumnTextForButtonValue = true;
            // 
            // SalesOrder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.dataGridView_SalesOrderTable);
            this.Name = "SalesOrder";
            this.Load += new System.EventHandler(this.SalesOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SalesOrderTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_SalesOrderTable;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewButtonColumn EditButton;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteButton;
    }
}
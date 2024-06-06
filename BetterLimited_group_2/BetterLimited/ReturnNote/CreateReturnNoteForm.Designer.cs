namespace BetterLimited
{
    partial class CreateReturnNoteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateReturnNoteForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox_NowTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Nowdate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_SalesOrderTable = new System.Windows.Forms.DataGridView();
            this.SalesOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaidAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_Search = new System.Windows.Forms.Button();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.dataGridView_OrderItemTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label_SelectedOrderID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_ReturnNote = new System.Windows.Forms.DataGridView();
            this.button_Create = new System.Windows.Forms.Button();
            this.cbxStore = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_TotalReturnAmount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textbox_StaffID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removeQty = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddQTY = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SalesOrderTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OrderItemTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ReturnNote)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_NowTime
            // 
            resources.ApplyResources(this.textBox_NowTime, "textBox_NowTime");
            this.textBox_NowTime.Name = "textBox_NowTime";
            this.textBox_NowTime.ReadOnly = true;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // textBox_Nowdate
            // 
            resources.ApplyResources(this.textBox_Nowdate, "textBox_Nowdate");
            this.textBox_Nowdate.Name = "textBox_Nowdate";
            this.textBox_Nowdate.ReadOnly = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Controls.Add(this.label2);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Name = "label2";
            // 
            // dataGridView_SalesOrderTable
            // 
            this.dataGridView_SalesOrderTable.AllowUserToAddRows = false;
            this.dataGridView_SalesOrderTable.AllowUserToDeleteRows = false;
            this.dataGridView_SalesOrderTable.AllowUserToResizeRows = false;
            this.dataGridView_SalesOrderTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_SalesOrderTable.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_SalesOrderTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_SalesOrderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SalesOrderTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SalesOrderID,
            this.PaymentStatus,
            this.PaidAmt,
            this.Date,
            this.Time,
            this.ExpDate,
            this.CustomerID,
            this.EditButton});
            this.dataGridView_SalesOrderTable.GridColor = System.Drawing.Color.White;
            resources.ApplyResources(this.dataGridView_SalesOrderTable, "dataGridView_SalesOrderTable");
            this.dataGridView_SalesOrderTable.Name = "dataGridView_SalesOrderTable";
            this.dataGridView_SalesOrderTable.ReadOnly = true;
            this.dataGridView_SalesOrderTable.RowHeadersVisible = false;
            this.dataGridView_SalesOrderTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_SalesOrderTable.RowTemplate.Height = 27;
            this.dataGridView_SalesOrderTable.ShowEditingIcon = false;
            this.dataGridView_SalesOrderTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_SalesOrderTable_CellClick);
            // 
            // SalesOrderID
            // 
            this.SalesOrderID.DataPropertyName = "SalesOrderID";
            resources.ApplyResources(this.SalesOrderID, "SalesOrderID");
            this.SalesOrderID.Name = "SalesOrderID";
            this.SalesOrderID.ReadOnly = true;
            this.SalesOrderID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("PMingLiU-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.EditButton.DefaultCellStyle = dataGridViewCellStyle1;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.EditButton, "EditButton");
            this.EditButton.Name = "EditButton";
            this.EditButton.ReadOnly = true;
            this.EditButton.Text = "Select";
            this.EditButton.UseColumnTextForButtonValue = true;
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
            // dataGridView_OrderItemTable
            // 
            this.dataGridView_OrderItemTable.AllowUserToAddRows = false;
            this.dataGridView_OrderItemTable.AllowUserToDeleteRows = false;
            this.dataGridView_OrderItemTable.AllowUserToResizeRows = false;
            this.dataGridView_OrderItemTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_OrderItemTable.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_OrderItemTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_OrderItemTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_OrderItemTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewButtonColumn2});
            this.dataGridView_OrderItemTable.GridColor = System.Drawing.Color.White;
            resources.ApplyResources(this.dataGridView_OrderItemTable, "dataGridView_OrderItemTable");
            this.dataGridView_OrderItemTable.Name = "dataGridView_OrderItemTable";
            this.dataGridView_OrderItemTable.ReadOnly = true;
            this.dataGridView_OrderItemTable.RowHeadersVisible = false;
            this.dataGridView_OrderItemTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_OrderItemTable.RowTemplate.Height = 27;
            this.dataGridView_OrderItemTable.ShowEditingIcon = false;
            this.dataGridView_OrderItemTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_OrderItemTable_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ItemID";
            this.dataGridViewTextBoxColumn1.FillWeight = 65.65144F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SalePrice";
            this.dataGridViewTextBoxColumn2.FillWeight = 40F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Qty";
            this.dataGridViewTextBoxColumn3.FillWeight = 40F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewButtonColumn2
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewButtonColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewButtonColumn2.FillWeight = 65.65144F;
            this.dataGridViewButtonColumn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.dataGridViewButtonColumn2, "dataGridViewButtonColumn2");
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.ReadOnly = true;
            this.dataGridViewButtonColumn2.Text = "Add to return Note";
            this.dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
            // 
            // label_SelectedOrderID
            // 
            this.label_SelectedOrderID.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.label_SelectedOrderID, "label_SelectedOrderID");
            this.label_SelectedOrderID.Name = "label_SelectedOrderID";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // dataGridView_ReturnNote
            // 
            this.dataGridView_ReturnNote.AllowUserToAddRows = false;
            this.dataGridView_ReturnNote.AllowUserToDeleteRows = false;
            this.dataGridView_ReturnNote.AllowUserToResizeColumns = false;
            this.dataGridView_ReturnNote.AllowUserToResizeRows = false;
            this.dataGridView_ReturnNote.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ReturnNote.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_ReturnNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_ReturnNote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ReturnNote.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.removeQty,
            this.Column2,
            this.AddQTY,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewButtonColumn1});
            this.dataGridView_ReturnNote.GridColor = System.Drawing.Color.White;
            resources.ApplyResources(this.dataGridView_ReturnNote, "dataGridView_ReturnNote");
            this.dataGridView_ReturnNote.MultiSelect = false;
            this.dataGridView_ReturnNote.Name = "dataGridView_ReturnNote";
            this.dataGridView_ReturnNote.RowHeadersVisible = false;
            this.dataGridView_ReturnNote.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_ReturnNote.RowTemplate.Height = 27;
            this.dataGridView_ReturnNote.ShowEditingIcon = false;
            this.dataGridView_ReturnNote.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ReturnNote_CellClick);
            // 
            // button_Create
            // 
            this.button_Create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.button_Create, "button_Create");
            this.button_Create.Name = "button_Create";
            this.button_Create.UseVisualStyleBackColor = false;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // cbxStore
            // 
            this.cbxStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStore.FormattingEnabled = true;
            this.cbxStore.Items.AddRange(new object[] {
            resources.GetString("cbxStore.Items"),
            resources.GetString("cbxStore.Items1")});
            resources.ApplyResources(this.cbxStore, "cbxStore");
            this.cbxStore.Name = "cbxStore";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label_TotalReturnAmount
            // 
            resources.ApplyResources(this.label_TotalReturnAmount, "label_TotalReturnAmount");
            this.label_TotalReturnAmount.Name = "label_TotalReturnAmount";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // textbox_StaffID
            // 
            resources.ApplyResources(this.textbox_StaffID, "textbox_StaffID");
            this.textbox_StaffID.Name = "textbox_StaffID";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ItemID";
            this.dataGridViewTextBoxColumn4.FillWeight = 60F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn4, "dataGridViewTextBoxColumn4");
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SalePrice";
            this.dataGridViewTextBoxColumn5.FillWeight = 75.21151F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn5, "dataGridViewTextBoxColumn5");
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // removeQty
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.removeQty.DefaultCellStyle = dataGridViewCellStyle3;
            this.removeQty.FillWeight = 30F;
            this.removeQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.removeQty, "removeQty");
            this.removeQty.Name = "removeQty";
            this.removeQty.Text = "+";
            this.removeQty.UseColumnTextForButtonValue = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 60F;
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AddQTY
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.AddQTY.DefaultCellStyle = dataGridViewCellStyle4;
            this.AddQTY.FillWeight = 30F;
            this.AddQTY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.AddQTY, "AddQTY");
            this.AddQTY.Name = "AddQTY";
            this.AddQTY.Text = "-";
            this.AddQTY.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Total Price";
            this.dataGridViewTextBoxColumn6.FillWeight = 75.21151F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn6, "dataGridViewTextBoxColumn6");
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("PMingLiU-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewButtonColumn1.FillWeight = 60F;
            this.dataGridViewButtonColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.dataGridViewButtonColumn1, "dataGridViewButtonColumn1");
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Text = "Delete";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // CreateReturnNoteForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textbox_StaffID);
            this.Controls.Add(this.label_TotalReturnAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxStore);
            this.Controls.Add(this.button_Create);
            this.Controls.Add(this.dataGridView_ReturnNote);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_SelectedOrderID);
            this.Controls.Add(this.dataGridView_OrderItemTable);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.dataGridView_SalesOrderTable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox_NowTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Nowdate);
            this.Controls.Add(this.label4);
            this.Name = "CreateReturnNoteForm";
            this.Load += new System.EventHandler(this.CreateReturnNoteForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SalesOrderTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OrderItemTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ReturnNote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_NowTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Nowdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_SalesOrderTable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.DataGridView dataGridView_OrderItemTable;
        private System.Windows.Forms.Label label_SelectedOrderID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_ReturnNote;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.ComboBox cbxStore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_TotalReturnAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textbox_StaffID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewButtonColumn EditButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewButtonColumn removeQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn AddQTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
    }
}
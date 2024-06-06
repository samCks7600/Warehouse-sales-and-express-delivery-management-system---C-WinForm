
namespace BetterLimited
{
    partial class DeliveryWorkerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryWorkerForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_WorkerTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.button_clear_Worker = new System.Windows.Forms.Button();
            this.button_Search_Worker = new System.Windows.Forms.Button();
            this.textBox_Search_Worker = new System.Windows.Forms.TextBox();
            this.dataGridView_arrengeTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_WorkID = new System.Windows.Forms.TextBox();
            this.dataGridView_DeliveryTable = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_clearAll_arrangeList = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_WorkerTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_arrengeTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DeliveryTable)).BeginInit();
            this.SuspendLayout();
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
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Name = "label2";
            // 
            // dataGridView_WorkerTable
            // 
            this.dataGridView_WorkerTable.AllowUserToAddRows = false;
            this.dataGridView_WorkerTable.AllowUserToDeleteRows = false;
            this.dataGridView_WorkerTable.AllowUserToResizeRows = false;
            this.dataGridView_WorkerTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_WorkerTable.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_WorkerTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_WorkerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_WorkerTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.EditButton});
            this.dataGridView_WorkerTable.GridColor = System.Drawing.Color.White;
            resources.ApplyResources(this.dataGridView_WorkerTable, "dataGridView_WorkerTable");
            this.dataGridView_WorkerTable.Name = "dataGridView_WorkerTable";
            this.dataGridView_WorkerTable.ReadOnly = true;
            this.dataGridView_WorkerTable.RowHeadersVisible = false;
            this.dataGridView_WorkerTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_WorkerTable.RowTemplate.Height = 27;
            this.dataGridView_WorkerTable.ShowEditingIcon = false;
            this.dataGridView_WorkerTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_WorkerTable_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "StaffID";
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "StaffName";
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Gender";
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Tel";
            resources.ApplyResources(this.Column4, "Column4");
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Email";
            resources.ApplyResources(this.Column5, "Column5");
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
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
            // button_clear_Worker
            // 
            resources.ApplyResources(this.button_clear_Worker, "button_clear_Worker");
            this.button_clear_Worker.Name = "button_clear_Worker";
            this.button_clear_Worker.UseVisualStyleBackColor = true;
            this.button_clear_Worker.Click += new System.EventHandler(this.button_clear_Worker_Click);
            // 
            // button_Search_Worker
            // 
            resources.ApplyResources(this.button_Search_Worker, "button_Search_Worker");
            this.button_Search_Worker.Name = "button_Search_Worker";
            this.button_Search_Worker.UseVisualStyleBackColor = true;
            this.button_Search_Worker.Click += new System.EventHandler(this.button_Search_Worker_Click);
            // 
            // textBox_Search_Worker
            // 
            resources.ApplyResources(this.textBox_Search_Worker, "textBox_Search_Worker");
            this.textBox_Search_Worker.Name = "textBox_Search_Worker";
            this.textBox_Search_Worker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Search_Worker_KeyPress);
            // 
            // dataGridView_arrengeTable
            // 
            this.dataGridView_arrengeTable.AllowUserToAddRows = false;
            this.dataGridView_arrengeTable.AllowUserToDeleteRows = false;
            this.dataGridView_arrengeTable.AllowUserToResizeRows = false;
            this.dataGridView_arrengeTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_arrengeTable.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_arrengeTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_arrengeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_arrengeTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.dataGridViewButtonColumn1});
            this.dataGridView_arrengeTable.GridColor = System.Drawing.Color.White;
            resources.ApplyResources(this.dataGridView_arrengeTable, "dataGridView_arrengeTable");
            this.dataGridView_arrengeTable.Name = "dataGridView_arrengeTable";
            this.dataGridView_arrengeTable.ReadOnly = true;
            this.dataGridView_arrengeTable.RowHeadersVisible = false;
            this.dataGridView_arrengeTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_arrengeTable.RowTemplate.Height = 27;
            this.dataGridView_arrengeTable.ShowEditingIcon = false;
            this.dataGridView_arrengeTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_arrengeTable_CellClick);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textBox_WorkID
            // 
            resources.ApplyResources(this.textBox_WorkID, "textBox_WorkID");
            this.textBox_WorkID.Name = "textBox_WorkID";
            this.textBox_WorkID.ReadOnly = true;
            // 
            // dataGridView_DeliveryTable
            // 
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
            this.dataGridViewButtonColumn2});
            this.dataGridView_DeliveryTable.GridColor = System.Drawing.Color.White;
            resources.ApplyResources(this.dataGridView_DeliveryTable, "dataGridView_DeliveryTable");
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
            // dataGridViewButtonColumn2
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("PMingLiU-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewButtonColumn2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewButtonColumn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.dataGridViewButtonColumn2, "dataGridViewButtonColumn2");
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.Text = "Select";
            this.dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
            // 
            // button_Update
            // 
            this.button_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.button_Update, "button_Update");
            this.button_Update.Name = "button_Update";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_clearAll_arrangeList
            // 
            this.button_clearAll_arrangeList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.button_clearAll_arrangeList, "button_clearAll_arrangeList");
            this.button_clearAll_arrangeList.Name = "button_clearAll_arrangeList";
            this.button_clearAll_arrangeList.UseVisualStyleBackColor = false;
            this.button_clearAll_arrangeList.Click += new System.EventHandler(this.button_clearAll_arrangeList_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.button_refresh, "button_refresh");
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.UseVisualStyleBackColor = false;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // Column6
            // 
            resources.ApplyResources(this.Column6, "Column6");
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("PMingLiU-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewButtonColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.dataGridViewButtonColumn1, "dataGridViewButtonColumn1");
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Text = "Delete";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // DeliveryWorkerForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.button_clearAll_arrangeList);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.dataGridView_DeliveryTable);
            this.Controls.Add(this.textBox_WorkID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_arrengeTable);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_clear_Worker);
            this.Controls.Add(this.button_Search_Worker);
            this.Controls.Add(this.textBox_Search_Worker);
            this.Controls.Add(this.dataGridView_WorkerTable);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeliveryWorkerForm";
            this.Load += new System.EventHandler(this.DeliveryWorkerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_WorkerTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_arrengeTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DeliveryTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_WorkerTable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_clear_Worker;
        private System.Windows.Forms.Button button_Search_Worker;
        private System.Windows.Forms.TextBox textBox_Search_Worker;
        private System.Windows.Forms.DataGridView dataGridView_arrengeTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_WorkID;
        private System.Windows.Forms.DataGridView dataGridView_DeliveryTable;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_clearAll_arrangeList;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn EditButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
    }
}

namespace BetterLimited
{
    partial class InstallationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstallationForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_InstallationOrder_item_Table = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.dataGridView_InstallationOrder_Table = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EditButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DelectButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_InstallationOrder_item_Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_InstallationOrder_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_InstallationOrder_item_Table
            // 
            resources.ApplyResources(this.dataGridView_InstallationOrder_item_Table, "dataGridView_InstallationOrder_item_Table");
            this.dataGridView_InstallationOrder_item_Table.AllowUserToAddRows = false;
            this.dataGridView_InstallationOrder_item_Table.AllowUserToDeleteRows = false;
            this.dataGridView_InstallationOrder_item_Table.AllowUserToResizeRows = false;
            this.dataGridView_InstallationOrder_item_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_InstallationOrder_item_Table.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_InstallationOrder_item_Table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_InstallationOrder_item_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_InstallationOrder_item_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dataGridView_InstallationOrder_item_Table.GridColor = System.Drawing.Color.White;
            this.dataGridView_InstallationOrder_item_Table.Name = "dataGridView_InstallationOrder_item_Table";
            this.dataGridView_InstallationOrder_item_Table.ReadOnly = true;
            this.dataGridView_InstallationOrder_item_Table.RowHeadersVisible = false;
            this.dataGridView_InstallationOrder_item_Table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_InstallationOrder_item_Table.RowTemplate.Height = 27;
            this.dataGridView_InstallationOrder_item_Table.ShowEditingIcon = false;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "SalesOrderID";
            resources.ApplyResources(this.Column7, "Column7");
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "ItemID";
            resources.ApplyResources(this.Column8, "Column8");
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "SalePrice";
            resources.ApplyResources(this.Column9, "Column9");
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Qty";
            resources.ApplyResources(this.Column10, "Column10");
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "WarrantyMouth";
            resources.ApplyResources(this.Column11, "Column11");
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "SerialNo";
            resources.ApplyResources(this.Column12, "Column12");
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Name = "label1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // textBox_Search
            // 
            resources.ApplyResources(this.textBox_Search, "textBox_Search");
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Search_KeyPress);
            // 
            // dataGridView_InstallationOrder_Table
            // 
            resources.ApplyResources(this.dataGridView_InstallationOrder_Table, "dataGridView_InstallationOrder_Table");
            this.dataGridView_InstallationOrder_Table.AllowUserToAddRows = false;
            this.dataGridView_InstallationOrder_Table.AllowUserToDeleteRows = false;
            this.dataGridView_InstallationOrder_Table.AllowUserToResizeRows = false;
            this.dataGridView_InstallationOrder_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_InstallationOrder_Table.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_InstallationOrder_Table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_InstallationOrder_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_InstallationOrder_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column13,
            this.EditButton,
            this.DelectButton});
            this.dataGridView_InstallationOrder_Table.GridColor = System.Drawing.Color.White;
            this.dataGridView_InstallationOrder_Table.Name = "dataGridView_InstallationOrder_Table";
            this.dataGridView_InstallationOrder_Table.ReadOnly = true;
            this.dataGridView_InstallationOrder_Table.RowHeadersVisible = false;
            this.dataGridView_InstallationOrder_Table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_InstallationOrder_Table.RowTemplate.Height = 27;
            this.dataGridView_InstallationOrder_Table.ShowEditingIcon = false;
            this.dataGridView_InstallationOrder_Table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_InstallationOrder_Table_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "InstallationID";
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
            // Column4
            // 
            this.Column4.DataPropertyName = "InstallationDate";
            resources.ApplyResources(this.Column4, "Column4");
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "InstallationTime";
            resources.ApplyResources(this.Column5, "Column5");
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "InstallationStatus";
            resources.ApplyResources(this.Column6, "Column6");
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column13
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("PMingLiU-ExtB", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.Column13.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.Column13, "Column13");
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column13.Text = "Search item";
            this.Column13.UseColumnTextForButtonValue = true;
            // 
            // EditButton
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("PMingLiU-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.EditButton.DefaultCellStyle = dataGridViewCellStyle2;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.EditButton, "EditButton");
            this.EditButton.Name = "EditButton";
            this.EditButton.ReadOnly = true;
            this.EditButton.Text = "Edit";
            this.EditButton.UseColumnTextForButtonValue = true;
            // 
            // DelectButton
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("PMingLiU-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.DelectButton.DefaultCellStyle = dataGridViewCellStyle3;
            this.DelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.DelectButton, "DelectButton");
            this.DelectButton.Name = "DelectButton";
            this.DelectButton.ReadOnly = true;
            this.DelectButton.Text = "Delect";
            this.DelectButton.UseColumnTextForButtonValue = true;
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
            // InstallationForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.dataGridView_InstallationOrder_item_Table);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.dataGridView_InstallationOrder_Table);
            this.Name = "InstallationForm";
            this.Load += new System.EventHandler(this.InstallationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_InstallationOrder_item_Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_InstallationOrder_Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_InstallationOrder_item_Table;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.DataGridView dataGridView_InstallationOrder_Table;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn Column13;
        private System.Windows.Forms.DataGridViewButtonColumn EditButton;
        private System.Windows.Forms.DataGridViewButtonColumn DelectButton;
    }
}
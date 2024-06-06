
namespace BetterLimited
{
    partial class ReOrderRequestRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReOrderRequestRecord));
            this.lblReOrderRecord = new System.Windows.Forms.Label();
            this.txtReOrderRecord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvReOrderRecord = new System.Windows.Forms.DataGridView();
            this.cbxIDSearch = new System.Windows.Forms.ComboBox();
            this.dgvReOrderDetails = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Accept = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReOrderRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReOrderDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReOrderRecord
            // 
            resources.ApplyResources(this.lblReOrderRecord, "lblReOrderRecord");
            this.lblReOrderRecord.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblReOrderRecord.Name = "lblReOrderRecord";
            // 
            // txtReOrderRecord
            // 
            resources.ApplyResources(this.txtReOrderRecord, "txtReOrderRecord");
            this.txtReOrderRecord.Name = "txtReOrderRecord";
            this.txtReOrderRecord.TextChanged += new System.EventHandler(this.txtReOrderRecord_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Name = "label1";
            // 
            // dgvReOrderRecord
            // 
            resources.ApplyResources(this.dgvReOrderRecord, "dgvReOrderRecord");
            this.dgvReOrderRecord.AllowUserToAddRows = false;
            this.dgvReOrderRecord.AllowUserToDeleteRows = false;
            this.dgvReOrderRecord.AllowUserToResizeRows = false;
            this.dgvReOrderRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReOrderRecord.BackgroundColor = System.Drawing.Color.White;
            this.dgvReOrderRecord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReOrderRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReOrderRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Status,
            this.Details,
            this.Accept});
            this.dgvReOrderRecord.GridColor = System.Drawing.Color.White;
            this.dgvReOrderRecord.Name = "dgvReOrderRecord";
            this.dgvReOrderRecord.ReadOnly = true;
            this.dgvReOrderRecord.RowHeadersVisible = false;
            this.dgvReOrderRecord.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvReOrderRecord.RowTemplate.Height = 27;
            this.dgvReOrderRecord.ShowEditingIcon = false;
            this.dgvReOrderRecord.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReOrderRecord_CellClick);
            this.dgvReOrderRecord.SelectionChanged += new System.EventHandler(this.dgvReOrderRecord_SelectionChanged);
            // 
            // cbxIDSearch
            // 
            resources.ApplyResources(this.cbxIDSearch, "cbxIDSearch");
            this.cbxIDSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIDSearch.Items.AddRange(new object[] {
            resources.GetString("cbxIDSearch.Items"),
            resources.GetString("cbxIDSearch.Items1")});
            this.cbxIDSearch.Name = "cbxIDSearch";
            this.cbxIDSearch.SelectedIndexChanged += new System.EventHandler(this.cbxIDSearch_SelectedIndexChanged);
            // 
            // dgvReOrderDetails
            // 
            resources.ApplyResources(this.dgvReOrderDetails, "dgvReOrderDetails");
            this.dgvReOrderDetails.AllowUserToAddRows = false;
            this.dgvReOrderDetails.AllowUserToDeleteRows = false;
            this.dgvReOrderDetails.AllowUserToResizeRows = false;
            this.dgvReOrderDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReOrderDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvReOrderDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReOrderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.Column2,
            this.Column1,
            this.Column3});
            this.dgvReOrderDetails.GridColor = System.Drawing.Color.White;
            this.dgvReOrderDetails.Name = "dgvReOrderDetails";
            this.dgvReOrderDetails.ReadOnly = true;
            this.dgvReOrderDetails.RowHeadersVisible = false;
            this.dgvReOrderDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvReOrderDetails.RowTemplate.Height = 27;
            this.dgvReOrderDetails.ShowEditingIcon = false;
            this.dgvReOrderDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReOrderDetails_CellClick);
            this.dgvReOrderDetails.SelectionChanged += new System.EventHandler(this.dgvReOrderDetails_SelectionChanged);
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::BetterLimited.Properties.Resources.search;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ReorderRequestID";
            this.dataGridViewTextBoxColumn1.Frozen = true;
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "StaffID";
            this.dataGridViewTextBoxColumn2.Frozen = true;
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "RequestDate";
            this.dataGridViewTextBoxColumn3.Frozen = true;
            resources.ApplyResources(this.dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "RequestTime";
            this.dataGridViewTextBoxColumn4.Frozen = true;
            resources.ApplyResources(this.dataGridViewTextBoxColumn4, "dataGridViewTextBoxColumn4");
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "RequestStatus";
            resources.ApplyResources(this.Status, "Status");
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Details
            // 
            resources.ApplyResources(this.Details, "Details");
            this.Details.Name = "Details";
            this.Details.ReadOnly = true;
            this.Details.Text = "Details";
            this.Details.UseColumnTextForButtonValue = true;
            // 
            // Accept
            // 
            resources.ApplyResources(this.Accept, "Accept");
            this.Accept.Name = "Accept";
            this.Accept.ReadOnly = true;
            this.Accept.Text = "Accept";
            this.Accept.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ItemID";
            this.dataGridViewTextBoxColumn5.Frozen = true;
            resources.ApplyResources(this.dataGridViewTextBoxColumn5, "dataGridViewTextBoxColumn5");
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ItemName";
            this.dataGridViewTextBoxColumn6.FillWeight = 180F;
            this.dataGridViewTextBoxColumn6.Frozen = true;
            resources.ApplyResources(this.dataGridViewTextBoxColumn6, "dataGridViewTextBoxColumn6");
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Qty";
            this.Column2.FillWeight = 70F;
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 70F;
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "Edit";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 70F;
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Text = "Delete";
            this.Column3.UseColumnTextForButtonValue = true;
            // 
            // ReOrderRequestRecord
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvReOrderDetails);
            this.Controls.Add(this.cbxIDSearch);
            this.Controls.Add(this.dgvReOrderRecord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblReOrderRecord);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtReOrderRecord);
            this.Name = "ReOrderRequestRecord";
            this.Load += new System.EventHandler(this.ReOrderRequestRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReOrderRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReOrderDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReOrderRecord;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtReOrderRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvReOrderRecord;
        private System.Windows.Forms.ComboBox cbxIDSearch;
        private System.Windows.Forms.DataGridView dgvReOrderDetails;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewButtonColumn Details;
        private System.Windows.Forms.DataGridViewButtonColumn Accept;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
    }
}

namespace BetterLimited {
    partial class PurchaseOrderRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseOrderRecord));
            this.dgvPurchaseDetails = new System.Windows.Forms.DataGridView();
            this.cbxIDSearch = new System.Windows.Forms.ComboBox();
            this.dgvPurchaseRecord = new System.Windows.Forms.DataGridView();
            this.txtPurchaseRecord = new System.Windows.Forms.TextBox();
            this.lblReOrderRecord = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPurchaseDetails
            // 
            resources.ApplyResources(this.dgvPurchaseDetails, "dgvPurchaseDetails");
            this.dgvPurchaseDetails.AllowUserToAddRows = false;
            this.dgvPurchaseDetails.AllowUserToDeleteRows = false;
            this.dgvPurchaseDetails.AllowUserToResizeRows = false;
            this.dgvPurchaseDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPurchaseDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvPurchaseDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPurchaseDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.Column2});
            this.dgvPurchaseDetails.GridColor = System.Drawing.Color.White;
            this.dgvPurchaseDetails.Name = "dgvPurchaseDetails";
            this.dgvPurchaseDetails.ReadOnly = true;
            this.dgvPurchaseDetails.RowHeadersVisible = false;
            this.dgvPurchaseDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPurchaseDetails.RowTemplate.Height = 27;
            this.dgvPurchaseDetails.ShowEditingIcon = false;
            this.dgvPurchaseDetails.SelectionChanged += new System.EventHandler(this.dgvPurchaseDetails_SelectionChanged);
            // 
            // cbxIDSearch
            // 
            resources.ApplyResources(this.cbxIDSearch, "cbxIDSearch");
            this.cbxIDSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIDSearch.Items.AddRange(new object[] {
            resources.GetString("cbxIDSearch.Items"),
            resources.GetString("cbxIDSearch.Items1"),
            resources.GetString("cbxIDSearch.Items2")});
            this.cbxIDSearch.Name = "cbxIDSearch";
            this.cbxIDSearch.SelectedIndexChanged += new System.EventHandler(this.cbxIDSearch_SelectedIndexChanged);
            // 
            // dgvPurchaseRecord
            // 
            resources.ApplyResources(this.dgvPurchaseRecord, "dgvPurchaseRecord");
            this.dgvPurchaseRecord.AllowUserToAddRows = false;
            this.dgvPurchaseRecord.AllowUserToDeleteRows = false;
            this.dgvPurchaseRecord.AllowUserToResizeRows = false;
            this.dgvPurchaseRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPurchaseRecord.BackgroundColor = System.Drawing.Color.White;
            this.dgvPurchaseRecord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPurchaseRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Status,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Column1,
            this.Column3});
            this.dgvPurchaseRecord.GridColor = System.Drawing.Color.White;
            this.dgvPurchaseRecord.Name = "dgvPurchaseRecord";
            this.dgvPurchaseRecord.ReadOnly = true;
            this.dgvPurchaseRecord.RowHeadersVisible = false;
            this.dgvPurchaseRecord.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPurchaseRecord.RowTemplate.Height = 27;
            this.dgvPurchaseRecord.ShowEditingIcon = false;
            this.dgvPurchaseRecord.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchaseRecord_CellClick_1);
            this.dgvPurchaseRecord.SelectionChanged += new System.EventHandler(this.dgvPurchaseRecord_SelectionChanged);
            // 
            // txtPurchaseRecord
            // 
            resources.ApplyResources(this.txtPurchaseRecord, "txtPurchaseRecord");
            this.txtPurchaseRecord.Name = "txtPurchaseRecord";
            this.txtPurchaseRecord.TextChanged += new System.EventHandler(this.txtReOrderRecord_TextChanged);
            // 
            // lblReOrderRecord
            // 
            resources.ApplyResources(this.lblReOrderRecord, "lblReOrderRecord");
            this.lblReOrderRecord.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblReOrderRecord.Name = "lblReOrderRecord";
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Name = "label2";
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
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PurchaseOrderID";
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
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "SupplierID";
            this.Status.FillWeight = 125F;
            resources.ApplyResources(this.Status, "Status");
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "OrderDate";
            resources.ApplyResources(this.dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "OrderTime";
            resources.ApplyResources(this.dataGridViewTextBoxColumn4, "dataGridViewTextBoxColumn4");
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "OrderStatus";
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Text = "Details";
            this.Column3.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ItemID";
            this.dataGridViewTextBoxColumn5.FillWeight = 150F;
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
            this.dataGridViewTextBoxColumn6.FillWeight = 250F;
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
            // PurchaseOrderRecord
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvPurchaseDetails);
            this.Controls.Add(this.cbxIDSearch);
            this.Controls.Add(this.dgvPurchaseRecord);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPurchaseRecord);
            this.Controls.Add(this.lblReOrderRecord);
            this.Name = "PurchaseOrderRecord";
            this.Load += new System.EventHandler(this.PurchaseOrderRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPurchaseDetails;
        private System.Windows.Forms.ComboBox cbxIDSearch;
        private System.Windows.Forms.DataGridView dgvPurchaseRecord;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPurchaseRecord;
        private System.Windows.Forms.Label lblReOrderRecord;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
    }
}
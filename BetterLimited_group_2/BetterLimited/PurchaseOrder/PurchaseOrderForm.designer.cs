
namespace BetterLimited
{
    partial class PurchaseOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseOrderForm));
            this.btnReOrderRecor = new System.Windows.Forms.Button();
            this.dgvSelectItem = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchase = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSendRequest = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxItemSearch = new System.Windows.Forms.ComboBox();
            this.txtItemSearch = new System.Windows.Forms.TextBox();
            this.dgvPurchaseOrder = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.llb1 = new System.Windows.Forms.Label();
            this.RRID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReOrderRecor
            // 
            resources.ApplyResources(this.btnReOrderRecor, "btnReOrderRecor");
            this.btnReOrderRecor.BackColor = System.Drawing.SystemColors.Control;
            this.btnReOrderRecor.ForeColor = System.Drawing.Color.Black;
            this.btnReOrderRecor.Name = "btnReOrderRecor";
            this.btnReOrderRecor.UseVisualStyleBackColor = false;
            this.btnReOrderRecor.Click += new System.EventHandler(this.btnReOrderRecor_Click);
            // 
            // dgvSelectItem
            // 
            this.dgvSelectItem.AllowUserToAddRows = false;
            this.dgvSelectItem.AllowUserToDeleteRows = false;
            this.dgvSelectItem.AllowUserToResizeRows = false;
            resources.ApplyResources(this.dgvSelectItem, "dgvSelectItem");
            this.dgvSelectItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSelectItem.BackgroundColor = System.Drawing.Color.White;
            this.dgvSelectItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSelectItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.purchase});
            this.dgvSelectItem.GridColor = System.Drawing.Color.White;
            this.dgvSelectItem.MultiSelect = false;
            this.dgvSelectItem.Name = "dgvSelectItem";
            this.dgvSelectItem.ReadOnly = true;
            this.dgvSelectItem.RowHeadersVisible = false;
            this.dgvSelectItem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSelectItem.RowTemplate.Height = 27;
            this.dgvSelectItem.ShowEditingIcon = false;
            this.dgvSelectItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelectItem_CellClick);
            this.dgvSelectItem.SelectionChanged += new System.EventHandler(this.dgvSelectItem_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ReorderRequestID";
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "StaffID";
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "RequestDate";
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "RequestTime";
            resources.ApplyResources(this.dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // purchase
            // 
            this.purchase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            resources.ApplyResources(this.purchase, "purchase");
            this.purchase.Name = "purchase";
            this.purchase.ReadOnly = true;
            this.purchase.Text = "Add";
            this.purchase.UseColumnTextForButtonValue = true;
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSendRequest
            // 
            resources.ApplyResources(this.btnSendRequest, "btnSendRequest");
            this.btnSendRequest.BackColor = System.Drawing.SystemColors.Control;
            this.btnSendRequest.ForeColor = System.Drawing.Color.Black;
            this.btnSendRequest.Name = "btnSendRequest";
            this.btnSendRequest.UseVisualStyleBackColor = false;
            this.btnSendRequest.Click += new System.EventHandler(this.btnSendRequest_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Name = "label3";
            // 
            // cbxItemSearch
            // 
            this.cbxItemSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxItemSearch.Items.AddRange(new object[] {
            resources.GetString("cbxItemSearch.Items"),
            resources.GetString("cbxItemSearch.Items1")});
            resources.ApplyResources(this.cbxItemSearch, "cbxItemSearch");
            this.cbxItemSearch.Name = "cbxItemSearch";
            this.cbxItemSearch.SelectedIndexChanged += new System.EventHandler(this.cbxItemSearch_SelectedIndexChanged);
            // 
            // txtItemSearch
            // 
            resources.ApplyResources(this.txtItemSearch, "txtItemSearch");
            this.txtItemSearch.Name = "txtItemSearch";
            this.txtItemSearch.TextChanged += new System.EventHandler(this.txtItemSearch_TextChanged);
            // 
            // dgvPurchaseOrder
            // 
            this.dgvPurchaseOrder.AllowUserToAddRows = false;
            this.dgvPurchaseOrder.AllowUserToDeleteRows = false;
            this.dgvPurchaseOrder.AllowUserToResizeRows = false;
            resources.ApplyResources(this.dgvPurchaseOrder, "dgvPurchaseOrder");
            this.dgvPurchaseOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPurchaseOrder.BackgroundColor = System.Drawing.Color.White;
            this.dgvPurchaseOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPurchaseOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column2,
            this.Column3});
            this.dgvPurchaseOrder.GridColor = System.Drawing.Color.White;
            this.dgvPurchaseOrder.Name = "dgvPurchaseOrder";
            this.dgvPurchaseOrder.ReadOnly = true;
            this.dgvPurchaseOrder.RowHeadersVisible = false;
            this.dgvPurchaseOrder.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPurchaseOrder.RowTemplate.Height = 27;
            this.dgvPurchaseOrder.ShowEditingIcon = false;
            this.dgvPurchaseOrder.SelectionChanged += new System.EventHandler(this.dgvPurchaseOrder_SelectionChanged);
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SupplierID";
            resources.ApplyResources(this.Column4, "Column4");
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "itemID";
            resources.ApplyResources(this.Column5, "Column5");
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ItemName";
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Qty";
            this.Column3.FillWeight = 60F;
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkTurquoise;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // llb1
            // 
            resources.ApplyResources(this.llb1, "llb1");
            this.llb1.Name = "llb1";
            // 
            // RRID
            // 
            resources.ApplyResources(this.RRID, "RRID");
            this.RRID.Name = "RRID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BetterLimited.Properties.Resources.search;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // PurchaseOrderForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.RRID);
            this.Controls.Add(this.llb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReOrderRecor);
            this.Controls.Add(this.dgvSelectItem);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSendRequest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxItemSearch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtItemSearch);
            this.Controls.Add(this.dgvPurchaseOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PurchaseOrderForm";
            this.Load += new System.EventHandler(this.PurchaseOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReOrderRecor;
        private System.Windows.Forms.DataGridView dgvSelectItem;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSendRequest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxItemSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtItemSearch;
        private System.Windows.Forms.DataGridView dgvPurchaseOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label llb1;
        private System.Windows.Forms.Label RRID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn purchase;
    }
}
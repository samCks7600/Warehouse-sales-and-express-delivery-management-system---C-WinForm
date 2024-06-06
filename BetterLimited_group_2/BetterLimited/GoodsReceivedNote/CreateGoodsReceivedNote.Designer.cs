
namespace BetterLimited
{
    partial class CreateGoodsReceivedNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateGoodsReceivedNote));
            this.label3 = new System.Windows.Forms.Label();
            this.cbxPOSearch = new System.Windows.Forms.ComboBox();
            this.txtPOSearch = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvPurchaseOrder = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Receive = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblDetails = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dgvPurchaseOrderItem = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemReceived = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseOrderItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Name = "label3";
            // 
            // cbxPOSearch
            // 
            this.cbxPOSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPOSearch.Items.AddRange(new object[] {
            resources.GetString("cbxPOSearch.Items"),
            resources.GetString("cbxPOSearch.Items1"),
            resources.GetString("cbxPOSearch.Items2")});
            resources.ApplyResources(this.cbxPOSearch, "cbxPOSearch");
            this.cbxPOSearch.Name = "cbxPOSearch";
            this.cbxPOSearch.SelectedIndexChanged += new System.EventHandler(this.cbxPOSearch_SelectedIndexChanged);
            // 
            // txtPOSearch
            // 
            resources.ApplyResources(this.txtPOSearch, "txtPOSearch");
            this.txtPOSearch.Name = "txtPOSearch";
            this.txtPOSearch.TextChanged += new System.EventHandler(this.txtPOSearch_TextChanged);
            this.txtPOSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPOSearch_KeyPress);
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
            this.Column1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Receive});
            this.dgvPurchaseOrder.GridColor = System.Drawing.Color.White;
            this.dgvPurchaseOrder.Name = "dgvPurchaseOrder";
            this.dgvPurchaseOrder.ReadOnly = true;
            this.dgvPurchaseOrder.RowHeadersVisible = false;
            this.dgvPurchaseOrder.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPurchaseOrder.RowTemplate.Height = 27;
            this.dgvPurchaseOrder.ShowEditingIcon = false;
            this.dgvPurchaseOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchaseOrder_CellClick);
            this.dgvPurchaseOrder.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPurchaseOrder_CellFormatting);
            this.dgvPurchaseOrder.SelectionChanged += new System.EventHandler(this.dgvPurchaseOrder_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PurchaseOrderID";
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "StaffID";
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SupplierID";
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "OrderDate";
            resources.ApplyResources(this.Column6, "Column6");
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "OrderTime";
            resources.ApplyResources(this.Column7, "Column7");
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "OrderStatus";
            this.Column8.FillWeight = 80F;
            resources.ApplyResources(this.Column8, "Column8");
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Receive
            // 
            this.Receive.FillWeight = 70F;
            resources.ApplyResources(this.Receive, "Receive");
            this.Receive.Name = "Receive";
            this.Receive.ReadOnly = true;
            this.Receive.Text = "Receive";
            this.Receive.UseColumnTextForButtonValue = true;
            // 
            // lblDetails
            // 
            resources.ApplyResources(this.lblDetails, "lblDetails");
            this.lblDetails.ForeColor = System.Drawing.Color.Black;
            this.lblDetails.Name = "lblDetails";
            // 
            // btnCreate
            // 
            resources.ApplyResources(this.btnCreate, "btnCreate");
            this.btnCreate.BackColor = System.Drawing.SystemColors.Control;
            this.btnCreate.ForeColor = System.Drawing.Color.Black;
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // dgvPurchaseOrderItem
            // 
            this.dgvPurchaseOrderItem.AllowUserToAddRows = false;
            this.dgvPurchaseOrderItem.AllowUserToDeleteRows = false;
            this.dgvPurchaseOrderItem.AllowUserToResizeRows = false;
            resources.ApplyResources(this.dgvPurchaseOrderItem, "dgvPurchaseOrderItem");
            this.dgvPurchaseOrderItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPurchaseOrderItem.BackgroundColor = System.Drawing.Color.White;
            this.dgvPurchaseOrderItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPurchaseOrderItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseOrderItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn9,
            this.ItemReceived});
            this.dgvPurchaseOrderItem.GridColor = System.Drawing.Color.White;
            this.dgvPurchaseOrderItem.Name = "dgvPurchaseOrderItem";
            this.dgvPurchaseOrderItem.RowHeadersVisible = false;
            this.dgvPurchaseOrderItem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPurchaseOrderItem.RowTemplate.Height = 27;
            this.dgvPurchaseOrderItem.ShowEditingIcon = false;
            this.dgvPurchaseOrderItem.SelectionChanged += new System.EventHandler(this.dgvPurchaseOrderItem_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ItemID";
            this.dataGridViewTextBoxColumn5.FillWeight = 50F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn5, "dataGridViewTextBoxColumn5");
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ItemName";
            this.dataGridViewTextBoxColumn3.FillWeight = 150F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Qty";
            this.dataGridViewTextBoxColumn9.FillWeight = 80F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn9, "dataGridViewTextBoxColumn9");
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ItemReceived
            // 
            this.ItemReceived.FalseValue = "false";
            this.ItemReceived.FillWeight = 30F;
            resources.ApplyResources(this.ItemReceived, "ItemReceived");
            this.ItemReceived.Name = "ItemReceived";
            this.ItemReceived.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemReceived.TrueValue = "true";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BetterLimited.Properties.Resources.search;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // CreateGoodsReceivedNote
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.dgvPurchaseOrderItem);
            this.Controls.Add(this.dgvPurchaseOrder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.cbxPOSearch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPOSearch);
            this.Name = "CreateGoodsReceivedNote";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.CreateGoodsReceivedNote_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseOrderItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxPOSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPOSearch;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvPurchaseOrder;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataGridView dgvPurchaseOrderItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewButtonColumn Receive;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ItemReceived;
    }
}
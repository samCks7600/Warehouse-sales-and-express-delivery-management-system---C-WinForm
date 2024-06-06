
namespace BetterLimited
{
    partial class ReOrderRequestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReOrderRequestForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvReOrderRequest = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cbxItemSearch = new System.Windows.Forms.ComboBox();
            this.txtItemSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSendRequest = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnReOrderRecor = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvSelect = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReOrder = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReOrderRequest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelect)).BeginInit();
            this.SuspendLayout();
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
            this.label1.BackColor = System.Drawing.Color.DarkTurquoise;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // dgvReOrderRequest
            // 
            this.dgvReOrderRequest.AllowUserToAddRows = false;
            this.dgvReOrderRequest.AllowUserToDeleteRows = false;
            this.dgvReOrderRequest.AllowUserToResizeRows = false;
            resources.ApplyResources(this.dgvReOrderRequest, "dgvReOrderRequest");
            this.dgvReOrderRequest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReOrderRequest.BackgroundColor = System.Drawing.Color.White;
            this.dgvReOrderRequest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReOrderRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReOrderRequest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column2,
            this.minus,
            this.Column3,
            this.add});
            this.dgvReOrderRequest.GridColor = System.Drawing.Color.White;
            this.dgvReOrderRequest.Name = "dgvReOrderRequest";
            this.dgvReOrderRequest.ReadOnly = true;
            this.dgvReOrderRequest.RowHeadersVisible = false;
            this.dgvReOrderRequest.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvReOrderRequest.RowTemplate.Height = 27;
            this.dgvReOrderRequest.ShowEditingIcon = false;
            this.dgvReOrderRequest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReOrderRequest_CellClick);
            this.dgvReOrderRequest.SelectionChanged += new System.EventHandler(this.dgvInventoryStockLevel_SelectionChanged);
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
            // minus
            // 
            this.minus.FillWeight = 80F;
            resources.ApplyResources(this.minus, "minus");
            this.minus.Name = "minus";
            this.minus.ReadOnly = true;
            this.minus.Text = "-";
            this.minus.UseColumnTextForButtonValue = true;
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
            // add
            // 
            this.add.FillWeight = 80F;
            resources.ApplyResources(this.add, "add");
            this.add.Name = "add";
            this.add.ReadOnly = true;
            this.add.Text = "+";
            this.add.UseColumnTextForButtonValue = true;
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
            this.txtItemSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemSearch_KeyPress);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Name = "label4";
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
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnReOrderRecor
            // 
            resources.ApplyResources(this.btnReOrderRecor, "btnReOrderRecor");
            this.btnReOrderRecor.BackColor = System.Drawing.SystemColors.Control;
            this.btnReOrderRecor.ForeColor = System.Drawing.Color.Black;
            this.btnReOrderRecor.Name = "btnReOrderRecor";
            this.btnReOrderRecor.UseVisualStyleBackColor = false;
            this.btnReOrderRecor.Click += new System.EventHandler(this.btnReOrderRecord_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BetterLimited.Properties.Resources.search;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // dgvSelect
            // 
            this.dgvSelect.AllowUserToAddRows = false;
            this.dgvSelect.AllowUserToDeleteRows = false;
            this.dgvSelect.AllowUserToResizeRows = false;
            resources.ApplyResources(this.dgvSelect, "dgvSelect");
            this.dgvSelect.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSelect.BackgroundColor = System.Drawing.Color.White;
            this.dgvSelect.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelect.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.Column4,
            this.ReOrder});
            this.dgvSelect.GridColor = System.Drawing.Color.White;
            this.dgvSelect.Name = "dgvSelect";
            this.dgvSelect.ReadOnly = true;
            this.dgvSelect.RowHeadersVisible = false;
            this.dgvSelect.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSelect.RowTemplate.Height = 27;
            this.dgvSelect.ShowEditingIcon = false;
            this.dgvSelect.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelect_CellClick);
            this.dgvSelect.SelectionChanged += new System.EventHandler(this.dgvSelect_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "itemID";
            this.Column1.FillWeight = 70F;
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "itemName";
            this.dataGridViewTextBoxColumn5.FillWeight = 180F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn5, "dataGridViewTextBoxColumn5");
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn6.FillWeight = 80F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn6, "dataGridViewTextBoxColumn6");
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "LowLevelQty";
            this.Column4.FillWeight = 80F;
            resources.ApplyResources(this.Column4, "Column4");
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ReOrder
            // 
            this.ReOrder.FillWeight = 70F;
            resources.ApplyResources(this.ReOrder, "ReOrder");
            this.ReOrder.Name = "ReOrder";
            this.ReOrder.ReadOnly = true;
            this.ReOrder.Text = "Re-order";
            this.ReOrder.UseColumnTextForButtonValue = true;
            // 
            // ReOrderRequestForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.dgvSelect);
            this.Controls.Add(this.btnReOrderRecor);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSendRequest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxItemSearch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtItemSearch);
            this.Controls.Add(this.dgvReOrderRequest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReOrderRequestForm";
            this.Load += new System.EventHandler(this.ReOrderRequestForm_Load);
            this.Shown += new System.EventHandler(this.InventoryStockLevelForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReOrderRequest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvReOrderRequest;
        private System.Windows.Forms.ComboBox cbxItemSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtItemSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSendRequest;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnReOrderRecor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn minus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn add;
        private System.Windows.Forms.DataGridView dgvSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn ReOrder;
    }
}

namespace BetterLimited
{
    partial class PurchaseInvoiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseInvoiceForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvPurchaseInvoice = new System.Windows.Forms.DataGridView();
            this.cbxItemSearch = new System.Windows.Forms.ComboBox();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
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
            // txtSearch
            // 
            resources.ApplyResources(this.txtSearch, "txtSearch");
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // dgvPurchaseInvoice
            // 
            this.dgvPurchaseInvoice.AllowUserToAddRows = false;
            this.dgvPurchaseInvoice.AllowUserToDeleteRows = false;
            this.dgvPurchaseInvoice.AllowUserToResizeRows = false;
            resources.ApplyResources(this.dgvPurchaseInvoice, "dgvPurchaseInvoice");
            this.dgvPurchaseInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPurchaseInvoice.BackgroundColor = System.Drawing.Color.White;
            this.dgvPurchaseInvoice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPurchaseInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Details});
            this.dgvPurchaseInvoice.GridColor = System.Drawing.Color.White;
            this.dgvPurchaseInvoice.Name = "dgvPurchaseInvoice";
            this.dgvPurchaseInvoice.ReadOnly = true;
            this.dgvPurchaseInvoice.RowHeadersVisible = false;
            this.dgvPurchaseInvoice.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPurchaseInvoice.RowTemplate.Height = 27;
            this.dgvPurchaseInvoice.ShowEditingIcon = false;
            this.dgvPurchaseInvoice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchaseInvoice_CellClick);
            this.dgvPurchaseInvoice.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPurchaseInvoice_CellFormatting);
            this.dgvPurchaseInvoice.SelectionChanged += new System.EventHandler(this.dgvPurchaseInvoice_SelectionChanged);
            // 
            // cbxItemSearch
            // 
            this.cbxItemSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxItemSearch.Items.AddRange(new object[] {
            resources.GetString("cbxItemSearch.Items")});
            resources.ApplyResources(this.cbxItemSearch, "cbxItemSearch");
            this.cbxItemSearch.Name = "cbxItemSearch";
            // 
            // picSearch
            // 
            this.picSearch.Image = global::BetterLimited.Properties.Resources.search;
            resources.ApplyResources(this.picSearch, "picSearch");
            this.picSearch.Name = "picSearch";
            this.picSearch.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "purchaseorderID";
            this.Column1.FillWeight = 70F;
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "supplierID";
            this.Column2.FillWeight = 70F;
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "OrderDate";
            this.Column3.FillWeight = 120F;
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Total";
            this.Column4.FillWeight = 120F;
            resources.ApplyResources(this.Column4, "Column4");
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Details
            // 
            resources.ApplyResources(this.Details, "Details");
            this.Details.Name = "Details";
            this.Details.ReadOnly = true;
            this.Details.Text = "Details";
            this.Details.UseColumnTextForButtonValue = true;
            // 
            // PurchaseInvoiceForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.cbxItemSearch);
            this.Controls.Add(this.dgvPurchaseInvoice);
            this.Controls.Add(this.picSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PurchaseInvoiceForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.InventoryStockLevelForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.DataGridView dgvPurchaseInvoice;
        private System.Windows.Forms.ComboBox cbxItemSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Details;
    }
}
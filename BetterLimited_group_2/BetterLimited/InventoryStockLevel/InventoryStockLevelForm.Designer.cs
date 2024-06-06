
namespace BetterLimited
{
    partial class InventoryStockLevelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryStockLevelForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvInventoryStockLevel = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateLowLevel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ReOrder = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cbxItemSearch = new System.Windows.Forms.ComboBox();
            this.picSearch = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryStockLevel)).BeginInit();
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
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Name = "label1";
            // 
            // txtSearch
            // 
            resources.ApplyResources(this.txtSearch, "txtSearch");
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // dgvInventoryStockLevel
            // 
            resources.ApplyResources(this.dgvInventoryStockLevel, "dgvInventoryStockLevel");
            this.dgvInventoryStockLevel.AllowUserToAddRows = false;
            this.dgvInventoryStockLevel.AllowUserToDeleteRows = false;
            this.dgvInventoryStockLevel.AllowUserToResizeRows = false;
            this.dgvInventoryStockLevel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventoryStockLevel.BackgroundColor = System.Drawing.Color.White;
            this.dgvInventoryStockLevel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInventoryStockLevel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventoryStockLevel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.UpdateLowLevel,
            this.ReOrder});
            this.dgvInventoryStockLevel.GridColor = System.Drawing.Color.White;
            this.dgvInventoryStockLevel.Name = "dgvInventoryStockLevel";
            this.dgvInventoryStockLevel.ReadOnly = true;
            this.dgvInventoryStockLevel.RowHeadersVisible = false;
            this.dgvInventoryStockLevel.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvInventoryStockLevel.RowTemplate.Height = 27;
            this.dgvInventoryStockLevel.ShowEditingIcon = false;
            this.dgvInventoryStockLevel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventoryStockLevel_CellClick);
            this.dgvInventoryStockLevel.SelectionChanged += new System.EventHandler(this.dgvInventoryStockLevel_SelectionChanged);
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
            // Column2
            // 
            this.Column2.DataPropertyName = "itemName";
            this.Column2.FillWeight = 180F;
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Quantity";
            this.Column3.FillWeight = 80F;
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // UpdateLowLevel
            // 
            resources.ApplyResources(this.UpdateLowLevel, "UpdateLowLevel");
            this.UpdateLowLevel.Name = "UpdateLowLevel";
            this.UpdateLowLevel.ReadOnly = true;
            this.UpdateLowLevel.Text = "Update Low Level";
            this.UpdateLowLevel.UseColumnTextForButtonValue = true;
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
            // cbxItemSearch
            // 
            resources.ApplyResources(this.cbxItemSearch, "cbxItemSearch");
            this.cbxItemSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxItemSearch.Items.AddRange(new object[] {
            resources.GetString("cbxItemSearch.Items"),
            resources.GetString("cbxItemSearch.Items1")});
            this.cbxItemSearch.Name = "cbxItemSearch";
            this.cbxItemSearch.SelectedIndexChanged += new System.EventHandler(this.cbxItemSearch_SelectedIndexChanged);
            // 
            // picSearch
            // 
            resources.ApplyResources(this.picSearch, "picSearch");
            this.picSearch.Image = global::BetterLimited.Properties.Resources.search;
            this.picSearch.Name = "picSearch";
            this.picSearch.TabStop = false;
            // 
            // InventoryStockLevelForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.cbxItemSearch);
            this.Controls.Add(this.dgvInventoryStockLevel);
            this.Controls.Add(this.picSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InventoryStockLevelForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.InventoryStockLevelForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryStockLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.DataGridView dgvInventoryStockLevel;
        private System.Windows.Forms.ComboBox cbxItemSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn UpdateLowLevel;
        private System.Windows.Forms.DataGridViewButtonColumn ReOrder;
    }
}
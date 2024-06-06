
namespace BetterLimited
{
    partial class RetailStockLevelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RetailStockLevelForm));
            this.dgvRetailStockLevel = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxItemSearch = new System.Windows.Forms.ComboBox();
            this.btnTW = new System.Windows.Forms.Button();
            this.btnKB = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateLowLevel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Restock = new System.Windows.Forms.DataGridViewButtonColumn();
            this.picSearch = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRetailStockLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRetailStockLevel
            // 
            resources.ApplyResources(this.dgvRetailStockLevel, "dgvRetailStockLevel");
            this.dgvRetailStockLevel.AllowUserToAddRows = false;
            this.dgvRetailStockLevel.AllowUserToDeleteRows = false;
            this.dgvRetailStockLevel.AllowUserToResizeRows = false;
            this.dgvRetailStockLevel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRetailStockLevel.BackgroundColor = System.Drawing.Color.White;
            this.dgvRetailStockLevel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRetailStockLevel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRetailStockLevel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.UpdateLowLevel,
            this.Restock});
            this.dgvRetailStockLevel.GridColor = System.Drawing.Color.White;
            this.dgvRetailStockLevel.Name = "dgvRetailStockLevel";
            this.dgvRetailStockLevel.ReadOnly = true;
            this.dgvRetailStockLevel.RowHeadersVisible = false;
            this.dgvRetailStockLevel.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvRetailStockLevel.RowTemplate.Height = 27;
            this.dgvRetailStockLevel.ShowEditingIcon = false;
            this.dgvRetailStockLevel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRetailStockLevel_CellClick);
            this.dgvRetailStockLevel.SelectionChanged += new System.EventHandler(this.dgvRetailStockLevel_SelectionChanged);
            // 
            // txtSearch
            // 
            resources.ApplyResources(this.txtSearch, "txtSearch");
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
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
            // btnTW
            // 
            resources.ApplyResources(this.btnTW, "btnTW");
            this.btnTW.Name = "btnTW";
            this.btnTW.UseVisualStyleBackColor = true;
            this.btnTW.Click += new System.EventHandler(this.btnTW_Click);
            // 
            // btnKB
            // 
            resources.ApplyResources(this.btnKB, "btnKB");
            this.btnKB.Name = "btnKB";
            this.btnKB.UseVisualStyleBackColor = true;
            this.btnKB.Click += new System.EventHandler(this.btnKB_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
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
            this.Column3.FillWeight = 70F;
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
            // Restock
            // 
            this.Restock.FillWeight = 80F;
            resources.ApplyResources(this.Restock, "Restock");
            this.Restock.Name = "Restock";
            this.Restock.ReadOnly = true;
            this.Restock.Text = "Re-stock";
            this.Restock.UseColumnTextForButtonValue = true;
            // 
            // picSearch
            // 
            resources.ApplyResources(this.picSearch, "picSearch");
            this.picSearch.Image = global::BetterLimited.Properties.Resources.search;
            this.picSearch.Name = "picSearch";
            this.picSearch.TabStop = false;
            // 
            // RetailStockLevelForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnKB);
            this.Controls.Add(this.btnTW);
            this.Controls.Add(this.dgvRetailStockLevel);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxItemSearch);
            this.Controls.Add(this.picSearch);
            this.Name = "RetailStockLevelForm";
            this.Load += new System.EventHandler(this.RetailStockLevelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRetailStockLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRetailStockLevel;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxItemSearch;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.Button btnTW;
        private System.Windows.Forms.Button btnKB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn UpdateLowLevel;
        private System.Windows.Forms.DataGridViewButtonColumn Restock;
    }
}

namespace BetterLimited
{
    partial class RestockRequestDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestockRequestDetail));
            this.RRRLbl = new System.Windows.Forms.Label();
            this.backBtm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RestockRequestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // RRRLbl
            // 
            resources.ApplyResources(this.RRRLbl, "RRRLbl");
            this.RRRLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RRRLbl.Name = "RRRLbl";
            // 
            // backBtm
            // 
            resources.ApplyResources(this.backBtm, "backBtm");
            this.backBtm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backBtm.Name = "backBtm";
            this.backBtm.UseVisualStyleBackColor = false;
            this.backBtm.Click += new System.EventHandler(this.backBtm_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RestockRequestID,
            this.itemID,
            this.Quantity});
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.ShowEditingIcon = false;
            // 
            // RestockRequestID
            // 
            this.RestockRequestID.DataPropertyName = "RestockRequestID";
            resources.ApplyResources(this.RestockRequestID, "RestockRequestID");
            this.RestockRequestID.Name = "RestockRequestID";
            // 
            // itemID
            // 
            this.itemID.DataPropertyName = "itemID";
            resources.ApplyResources(this.itemID, "itemID");
            this.itemID.Name = "itemID";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            resources.ApplyResources(this.Quantity, "Quantity");
            this.Quantity.Name = "Quantity";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // RestockRequestDetail
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backBtm);
            this.Controls.Add(this.RRRLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RestockRequestDetail";
            this.Load += new System.EventHandler(this.RestockRequestDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RRRLbl;
        private System.Windows.Forms.Button backBtm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn RestockRequestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}
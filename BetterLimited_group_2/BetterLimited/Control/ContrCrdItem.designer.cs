
namespace BetterLimited
{
    partial class ContrCrdItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDisItemID = new System.Windows.Forms.Label();
            this.lblDisItemName = new System.Windows.Forms.Label();
            this.lblDisItemPrice = new System.Windows.Forms.Label();
            this.picItem = new System.Windows.Forms.PictureBox();
            this.btnAddToLst = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDisItemID
            // 
            this.lblDisItemID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDisItemID.AutoSize = true;
            this.lblDisItemID.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisItemID.ForeColor = System.Drawing.Color.Gray;
            this.lblDisItemID.Location = new System.Drawing.Point(0, 26);
            this.lblDisItemID.Margin = new System.Windows.Forms.Padding(0);
            this.lblDisItemID.Name = "lblDisItemID";
            this.lblDisItemID.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblDisItemID.Size = new System.Drawing.Size(200, 13);
            this.lblDisItemID.TabIndex = 6;
            this.lblDisItemID.Text = "[ itemId ]";
            // 
            // lblDisItemName
            // 
            this.lblDisItemName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDisItemName.AutoSize = true;
            this.lblDisItemName.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisItemName.Location = new System.Drawing.Point(0, 10);
            this.lblDisItemName.Margin = new System.Windows.Forms.Padding(0);
            this.lblDisItemName.Name = "lblDisItemName";
            this.lblDisItemName.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblDisItemName.Size = new System.Drawing.Size(200, 16);
            this.lblDisItemName.TabIndex = 7;
            this.lblDisItemName.Text = "[ itemName ]";
            // 
            // lblDisItemPrice
            // 
            this.lblDisItemPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDisItemPrice.AutoSize = true;
            this.lblDisItemPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisItemPrice.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblDisItemPrice.Location = new System.Drawing.Point(0, 46);
            this.lblDisItemPrice.Margin = new System.Windows.Forms.Padding(0);
            this.lblDisItemPrice.Name = "lblDisItemPrice";
            this.lblDisItemPrice.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblDisItemPrice.Size = new System.Drawing.Size(200, 21);
            this.lblDisItemPrice.TabIndex = 8;
            this.lblDisItemPrice.Text = "[ itemPrice ]";
            // 
            // picItem
            // 
            this.picItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picItem.Location = new System.Drawing.Point(0, 50);
            this.picItem.Margin = new System.Windows.Forms.Padding(0);
            this.picItem.Name = "picItem";
            this.picItem.Size = new System.Drawing.Size(200, 150);
            this.picItem.TabIndex = 14;
            this.picItem.TabStop = false;
            // 
            // btnAddToLst
            // 
            this.btnAddToLst.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddToLst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToLst.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddToLst.FlatAppearance.BorderSize = 0;
            this.btnAddToLst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToLst.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToLst.ForeColor = System.Drawing.Color.White;
            this.btnAddToLst.Location = new System.Drawing.Point(0, 0);
            this.btnAddToLst.Name = "btnAddToLst";
            this.btnAddToLst.Size = new System.Drawing.Size(200, 50);
            this.btnAddToLst.TabIndex = 15;
            this.btnAddToLst.Text = "Add to Order List\r\n";
            this.btnAddToLst.UseVisualStyleBackColor = false;
            this.btnAddToLst.Click += new System.EventHandler(this.btnAddToLst_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightGray;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblDisItemName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDisItemID, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDisItemPrice, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 200);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 80);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // ContrCrdItem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnAddToLst);
            this.Controls.Add(this.picItem);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "ContrCrdItem";
            this.Size = new System.Drawing.Size(200, 280);
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblDisItemID;
        private System.Windows.Forms.Label lblDisItemName;
        private System.Windows.Forms.Label lblDisItemPrice;
        private System.Windows.Forms.PictureBox picItem;
        private System.Windows.Forms.Button btnAddToLst;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

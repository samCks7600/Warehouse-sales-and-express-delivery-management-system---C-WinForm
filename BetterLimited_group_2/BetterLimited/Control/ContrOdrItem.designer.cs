
namespace BetterLimited
{
    partial class ContrOdrItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContrOdrItem));
            this.tlpOdrLst = new System.Windows.Forms.TableLayoutPanel();
            this.lblOdrItemId = new System.Windows.Forms.Label();
            this.lblOdrItemName = new System.Windows.Forms.Label();
            this.btnDeleteOdrItem = new System.Windows.Forms.Button();
            this.lblOdrItemPrice = new System.Windows.Forms.Label();
            this.btnQtyReduction = new System.Windows.Forms.Button();
            this.btnQtyIncrement = new System.Windows.Forms.Button();
            this.lblDisQty = new System.Windows.Forms.Label();
            this.pnlLine = new System.Windows.Forms.Panel();
            this.tlpOdrLst.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpOdrLst
            // 
            this.tlpOdrLst.BackColor = System.Drawing.Color.Transparent;
            this.tlpOdrLst.ColumnCount = 7;
            this.tlpOdrLst.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpOdrLst.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOdrLst.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpOdrLst.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpOdrLst.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpOdrLst.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpOdrLst.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpOdrLst.Controls.Add(this.lblOdrItemId, 0, 0);
            this.tlpOdrLst.Controls.Add(this.lblOdrItemName, 1, 0);
            this.tlpOdrLst.Controls.Add(this.btnDeleteOdrItem, 6, 0);
            this.tlpOdrLst.Controls.Add(this.lblOdrItemPrice, 5, 0);
            this.tlpOdrLst.Controls.Add(this.btnQtyReduction, 2, 0);
            this.tlpOdrLst.Controls.Add(this.btnQtyIncrement, 4, 0);
            this.tlpOdrLst.Controls.Add(this.lblDisQty, 3, 0);
            this.tlpOdrLst.Location = new System.Drawing.Point(0, 0);
            this.tlpOdrLst.Name = "tlpOdrLst";
            this.tlpOdrLst.RowCount = 1;
            this.tlpOdrLst.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOdrLst.Size = new System.Drawing.Size(400, 33);
            this.tlpOdrLst.TabIndex = 0;
            // 
            // lblOdrItemId
            // 
            this.lblOdrItemId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOdrItemId.AutoSize = true;
            this.lblOdrItemId.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdrItemId.ForeColor = System.Drawing.Color.Gray;
            this.lblOdrItemId.Location = new System.Drawing.Point(15, 10);
            this.lblOdrItemId.Name = "lblOdrItemId";
            this.lblOdrItemId.Size = new System.Drawing.Size(29, 13);
            this.lblOdrItemId.TabIndex = 0;
            this.lblOdrItemId.Text = "[ id ]";
            // 
            // lblOdrItemName
            // 
            this.lblOdrItemName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOdrItemName.AutoSize = true;
            this.lblOdrItemName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdrItemName.Location = new System.Drawing.Point(63, 10);
            this.lblOdrItemName.Name = "lblOdrItemName";
            this.lblOdrItemName.Size = new System.Drawing.Size(134, 13);
            this.lblOdrItemName.TabIndex = 1;
            this.lblOdrItemName.Text = "[ itemName ]";
            // 
            // btnDeleteOdrItem
            // 
            this.btnDeleteOdrItem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDeleteOdrItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteOdrItem.BackgroundImage")));
            this.btnDeleteOdrItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteOdrItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteOdrItem.FlatAppearance.BorderSize = 0;
            this.btnDeleteOdrItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteOdrItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteOdrItem.Location = new System.Drawing.Point(363, 6);
            this.btnDeleteOdrItem.Name = "btnDeleteOdrItem";
            this.btnDeleteOdrItem.Size = new System.Drawing.Size(20, 20);
            this.btnDeleteOdrItem.TabIndex = 6;
            this.btnDeleteOdrItem.UseVisualStyleBackColor = true;
            this.btnDeleteOdrItem.Click += new System.EventHandler(this.btnDeleteOdrItem_Click);
            // 
            // lblOdrItemPrice
            // 
            this.lblOdrItemPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOdrItemPrice.AutoSize = true;
            this.lblOdrItemPrice.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdrItemPrice.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblOdrItemPrice.Location = new System.Drawing.Point(308, 10);
            this.lblOdrItemPrice.Name = "lblOdrItemPrice";
            this.lblOdrItemPrice.Size = new System.Drawing.Size(44, 13);
            this.lblOdrItemPrice.TabIndex = 7;
            this.lblOdrItemPrice.Text = "[ price ]";
            // 
            // btnQtyReduction
            // 
            this.btnQtyReduction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQtyReduction.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnQtyReduction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQtyReduction.FlatAppearance.BorderSize = 0;
            this.btnQtyReduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQtyReduction.Location = new System.Drawing.Point(200, 4);
            this.btnQtyReduction.Margin = new System.Windows.Forms.Padding(0);
            this.btnQtyReduction.Name = "btnQtyReduction";
            this.btnQtyReduction.Size = new System.Drawing.Size(30, 24);
            this.btnQtyReduction.TabIndex = 9;
            this.btnQtyReduction.Text = "-";
            this.btnQtyReduction.UseVisualStyleBackColor = false;
            this.btnQtyReduction.Click += new System.EventHandler(this.btnQtyReduction_Click);
            // 
            // btnQtyIncrement
            // 
            this.btnQtyIncrement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQtyIncrement.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnQtyIncrement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQtyIncrement.FlatAppearance.BorderSize = 0;
            this.btnQtyIncrement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQtyIncrement.Location = new System.Drawing.Point(270, 4);
            this.btnQtyIncrement.Margin = new System.Windows.Forms.Padding(0);
            this.btnQtyIncrement.Name = "btnQtyIncrement";
            this.btnQtyIncrement.Size = new System.Drawing.Size(30, 24);
            this.btnQtyIncrement.TabIndex = 10;
            this.btnQtyIncrement.Text = "+";
            this.btnQtyIncrement.UseVisualStyleBackColor = false;
            this.btnQtyIncrement.Click += new System.EventHandler(this.btnQtyIncrement_Click);
            // 
            // lblDisQty
            // 
            this.lblDisQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDisQty.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblDisQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDisQty.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisQty.Location = new System.Drawing.Point(230, 4);
            this.lblDisQty.Margin = new System.Windows.Forms.Padding(0);
            this.lblDisQty.Name = "lblDisQty";
            this.lblDisQty.Size = new System.Drawing.Size(40, 24);
            this.lblDisQty.TabIndex = 11;
            this.lblDisQty.Text = "XX";
            this.lblDisQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLine
            // 
            this.pnlLine.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlLine.Location = new System.Drawing.Point(5, 33);
            this.pnlLine.Name = "pnlLine";
            this.pnlLine.Size = new System.Drawing.Size(390, 1);
            this.pnlLine.TabIndex = 1;
            // 
            // ContrOdrItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlLine);
            this.Controls.Add(this.tlpOdrLst);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ContrOdrItem";
            this.Size = new System.Drawing.Size(400, 34);
            this.tlpOdrLst.ResumeLayout(false);
            this.tlpOdrLst.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpOdrLst;
        private System.Windows.Forms.Label lblOdrItemId;
        private System.Windows.Forms.Label lblOdrItemName;
        private System.Windows.Forms.Button btnDeleteOdrItem;
        private System.Windows.Forms.Label lblOdrItemPrice;
        private System.Windows.Forms.Button btnQtyReduction;
        private System.Windows.Forms.Button btnQtyIncrement;
        private System.Windows.Forms.Label lblDisQty;
        private System.Windows.Forms.Panel pnlLine;
    }
}

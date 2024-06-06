
namespace BetterLimited
{
    partial class ContrDlvrItem
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
            this.tlpDlvrItemHeader = new System.Windows.Forms.TableLayoutPanel();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblDescr = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblAmt = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tlpDlvrItemHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpDlvrItemHeader
            // 
            this.tlpDlvrItemHeader.BackColor = System.Drawing.Color.Transparent;
            this.tlpDlvrItemHeader.ColumnCount = 4;
            this.tlpDlvrItemHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpDlvrItemHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDlvrItemHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tlpDlvrItemHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tlpDlvrItemHeader.Controls.Add(this.lblQty, 0, 0);
            this.tlpDlvrItemHeader.Controls.Add(this.lblDescr, 1, 0);
            this.tlpDlvrItemHeader.Controls.Add(this.lblUnitPrice, 2, 0);
            this.tlpDlvrItemHeader.Controls.Add(this.lblAmt, 3, 0);
            this.tlpDlvrItemHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpDlvrItemHeader.Location = new System.Drawing.Point(0, 0);
            this.tlpDlvrItemHeader.Margin = new System.Windows.Forms.Padding(0);
            this.tlpDlvrItemHeader.Name = "tlpDlvrItemHeader";
            this.tlpDlvrItemHeader.RowCount = 1;
            this.tlpDlvrItemHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDlvrItemHeader.Size = new System.Drawing.Size(744, 40);
            this.tlpDlvrItemHeader.TabIndex = 1;
            // 
            // lblQty
            // 
            this.lblQty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(31, 10);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(18, 20);
            this.lblQty.TabIndex = 0;
            this.lblQty.Text = "X";
            // 
            // lblDescr
            // 
            this.lblDescr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescr.AutoSize = true;
            this.lblDescr.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescr.Location = new System.Drawing.Point(266, 10);
            this.lblDescr.Name = "lblDescr";
            this.lblDescr.Size = new System.Drawing.Size(36, 20);
            this.lblDescr.TabIndex = 1;
            this.lblDescr.Text = "XXX";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice.Location = new System.Drawing.Point(542, 10);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(18, 20);
            this.lblUnitPrice.TabIndex = 2;
            this.lblUnitPrice.Text = "X";
            // 
            // lblAmt
            // 
            this.lblAmt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAmt.AutoSize = true;
            this.lblAmt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmt.Location = new System.Drawing.Point(670, 10);
            this.lblAmt.Name = "lblAmt";
            this.lblAmt.Size = new System.Drawing.Size(18, 20);
            this.lblAmt.TabIndex = 3;
            this.lblAmt.Text = "X";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 1);
            this.panel1.TabIndex = 2;
            // 
            // contrDlvrItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tlpDlvrItemHeader);
            this.Name = "contrDlvrItem";
            this.Size = new System.Drawing.Size(744, 40);
            this.tlpDlvrItemHeader.ResumeLayout(false);
            this.tlpDlvrItemHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpDlvrItemHeader;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblDescr;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblAmt;
        private System.Windows.Forms.Panel panel1;
    }
}


namespace BetterLimited
{
    partial class frmOdrReceipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOdrReceipt));
            this.tlpLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblStoreAddress = new System.Windows.Forms.Label();
            this.lblStoreTel = new System.Windows.Forms.Label();
            this.tlpSubLayout1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblOdrId = new System.Windows.Forms.Label();
            this.tlpPayment = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDisTotal = new System.Windows.Forms.Label();
            this.lblDisCash = new System.Windows.Forms.Label();
            this.lblDisChange = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tlpItemHeader = new System.Windows.Forms.TableLayoutPanel();
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.flpOdrItems = new System.Windows.Forms.FlowLayoutPanel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.lblThx = new System.Windows.Forms.Label();
            this.tlpLayout.SuspendLayout();
            this.tlpSubLayout1.SuspendLayout();
            this.tlpPayment.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tlpItemHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpLayout
            // 
            this.tlpLayout.ColumnCount = 1;
            this.tlpLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLayout.Controls.Add(this.lblTitle, 0, 0);
            this.tlpLayout.Controls.Add(this.lblSubtitle, 0, 1);
            this.tlpLayout.Controls.Add(this.lblStoreAddress, 0, 2);
            this.tlpLayout.Controls.Add(this.lblStoreTel, 0, 3);
            this.tlpLayout.Controls.Add(this.tlpSubLayout1, 0, 4);
            this.tlpLayout.Controls.Add(this.tlpPayment, 0, 6);
            this.tlpLayout.Controls.Add(this.panel1, 0, 5);
            this.tlpLayout.Controls.Add(this.lblThx, 0, 7);
            this.tlpLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLayout.Location = new System.Drawing.Point(0, 0);
            this.tlpLayout.Margin = new System.Windows.Forms.Padding(0);
            this.tlpLayout.Name = "tlpLayout";
            this.tlpLayout.RowCount = 8;
            this.tlpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.98907F));
            this.tlpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.6776F));
            this.tlpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpLayout.Size = new System.Drawing.Size(350, 550);
            this.tlpLayout.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bauhaus 93", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(86, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(178, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Better Limited";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.Location = new System.Drawing.Point(129, 50);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(92, 16);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = " Order Receipt";
            // 
            // lblStoreAddress
            // 
            this.lblStoreAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStoreAddress.AutoSize = true;
            this.lblStoreAddress.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoreAddress.ForeColor = System.Drawing.Color.DimGray;
            this.lblStoreAddress.Location = new System.Drawing.Point(142, 72);
            this.lblStoreAddress.Name = "lblStoreAddress";
            this.lblStoreAddress.Size = new System.Drawing.Size(65, 15);
            this.lblStoreAddress.TabIndex = 3;
            this.lblStoreAddress.Text = "Address: XXX";
            // 
            // lblStoreTel
            // 
            this.lblStoreTel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStoreTel.AutoSize = true;
            this.lblStoreTel.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoreTel.ForeColor = System.Drawing.Color.DimGray;
            this.lblStoreTel.Location = new System.Drawing.Point(139, 92);
            this.lblStoreTel.Name = "lblStoreTel";
            this.lblStoreTel.Size = new System.Drawing.Size(72, 15);
            this.lblStoreTel.TabIndex = 4;
            this.lblStoreTel.Text = "Tel.: 0000 0000";
            // 
            // tlpSubLayout1
            // 
            this.tlpSubLayout1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tlpSubLayout1.ColumnCount = 2;
            this.tlpSubLayout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tlpSubLayout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.33333F));
            this.tlpSubLayout1.Controls.Add(this.lblDateTime, 1, 0);
            this.tlpSubLayout1.Controls.Add(this.lblOdrId, 0, 0);
            this.tlpSubLayout1.Location = new System.Drawing.Point(9, 120);
            this.tlpSubLayout1.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSubLayout1.Name = "tlpSubLayout1";
            this.tlpSubLayout1.RowCount = 1;
            this.tlpSubLayout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSubLayout1.Size = new System.Drawing.Size(331, 30);
            this.tlpSubLayout1.TabIndex = 0;
            // 
            // lblDateTime
            // 
            this.lblDateTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Location = new System.Drawing.Point(146, 7);
            this.lblDateTime.Margin = new System.Windows.Forms.Padding(0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblDateTime.Size = new System.Drawing.Size(185, 16);
            this.lblDateTime.TabIndex = 1;
            this.lblDateTime.Text = "Date / Time: yyyy/MM/dd hh:mm:ss";
            // 
            // lblOdrId
            // 
            this.lblOdrId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOdrId.AutoSize = true;
            this.lblOdrId.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdrId.Location = new System.Drawing.Point(0, 7);
            this.lblOdrId.Margin = new System.Windows.Forms.Padding(0);
            this.lblOdrId.Name = "lblOdrId";
            this.lblOdrId.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblOdrId.Size = new System.Drawing.Size(91, 16);
            this.lblOdrId.TabIndex = 0;
            this.lblOdrId.Text = "Odr ID: XXXXX";
            // 
            // tlpPayment
            // 
            this.tlpPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpPayment.ColumnCount = 2;
            this.tlpPayment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPayment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPayment.Controls.Add(this.lblTotal, 0, 0);
            this.tlpPayment.Controls.Add(this.label2, 0, 1);
            this.tlpPayment.Controls.Add(this.label3, 0, 2);
            this.tlpPayment.Controls.Add(this.lblDisTotal, 1, 0);
            this.tlpPayment.Controls.Add(this.lblDisCash, 1, 1);
            this.tlpPayment.Controls.Add(this.lblDisChange, 1, 2);
            this.tlpPayment.Location = new System.Drawing.Point(10, 349);
            this.tlpPayment.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tlpPayment.Name = "tlpPayment";
            this.tlpPayment.RowCount = 3;
            this.tlpPayment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpPayment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpPayment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpPayment.Size = new System.Drawing.Size(330, 80);
            this.tlpPayment.TabIndex = 5;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(3, 4);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(53, 23);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cash:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Change:";
            // 
            // lblDisTotal
            // 
            this.lblDisTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDisTotal.AutoSize = true;
            this.lblDisTotal.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisTotal.Location = new System.Drawing.Point(277, 4);
            this.lblDisTotal.Name = "lblDisTotal";
            this.lblDisTotal.Size = new System.Drawing.Size(50, 23);
            this.lblDisTotal.TabIndex = 3;
            this.lblDisTotal.Text = "$0.00";
            // 
            // lblDisCash
            // 
            this.lblDisCash.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDisCash.AutoSize = true;
            this.lblDisCash.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisCash.Location = new System.Drawing.Point(292, 36);
            this.lblDisCash.Name = "lblDisCash";
            this.lblDisCash.Size = new System.Drawing.Size(35, 16);
            this.lblDisCash.TabIndex = 4;
            this.lblDisCash.Text = "$0.00";
            // 
            // lblDisChange
            // 
            this.lblDisChange.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDisChange.AutoSize = true;
            this.lblDisChange.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisChange.Location = new System.Drawing.Point(292, 60);
            this.lblDisChange.Name = "lblDisChange";
            this.lblDisChange.Size = new System.Drawing.Size(35, 16);
            this.lblDisChange.TabIndex = 5;
            this.lblDisChange.Text = "$0.00";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tlpItemHeader);
            this.panel1.Controls.Add(this.flpOdrItems);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 160);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel1.Size = new System.Drawing.Size(350, 189);
            this.panel1.TabIndex = 6;
            // 
            // tlpItemHeader
            // 
            this.tlpItemHeader.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tlpItemHeader.ColumnCount = 4;
            this.tlpItemHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpItemHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpItemHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpItemHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpItemHeader.Controls.Add(this.lblId, 0, 0);
            this.tlpItemHeader.Controls.Add(this.lblName, 1, 0);
            this.tlpItemHeader.Controls.Add(this.lblQty, 2, 0);
            this.tlpItemHeader.Controls.Add(this.lblPrice, 3, 0);
            this.tlpItemHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpItemHeader.Location = new System.Drawing.Point(10, 0);
            this.tlpItemHeader.Margin = new System.Windows.Forms.Padding(0);
            this.tlpItemHeader.Name = "tlpItemHeader";
            this.tlpItemHeader.RowCount = 1;
            this.tlpItemHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpItemHeader.Size = new System.Drawing.Size(330, 28);
            this.tlpItemHeader.TabIndex = 4;
            // 
            // lblId
            // 
            this.lblId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(3, 6);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(54, 16);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(63, 6);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(164, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "NAME";
            // 
            // lblQty
            // 
            this.lblQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(233, 6);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(34, 16);
            this.lblQty.TabIndex = 2;
            this.lblQty.Text = "QTY";
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(273, 6);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(54, 16);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "PRICE";
            // 
            // flpOdrItems
            // 
            this.flpOdrItems.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpOdrItems.Location = new System.Drawing.Point(10, 28);
            this.flpOdrItems.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.flpOdrItems.Name = "flpOdrItems";
            this.flpOdrItems.Size = new System.Drawing.Size(330, 161);
            this.flpOdrItems.TabIndex = 3;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // lblThx
            // 
            this.lblThx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblThx.AutoSize = true;
            this.lblThx.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThx.Location = new System.Drawing.Point(115, 454);
            this.lblThx.Margin = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.lblThx.Name = "lblThx";
            this.lblThx.Size = new System.Drawing.Size(120, 29);
            this.lblThx.TabIndex = 7;
            this.lblThx.Text = "Thank You!";
            // 
            // frmOdrReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(350, 550);
            this.Controls.Add(this.tlpLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOdrReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.tlpLayout.ResumeLayout(false);
            this.tlpLayout.PerformLayout();
            this.tlpSubLayout1.ResumeLayout(false);
            this.tlpSubLayout1.PerformLayout();
            this.tlpPayment.ResumeLayout(false);
            this.tlpPayment.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tlpItemHeader.ResumeLayout(false);
            this.tlpItemHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpLayout;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblStoreAddress;
        private System.Windows.Forms.Label lblStoreTel;
        private System.Windows.Forms.TableLayoutPanel tlpSubLayout1;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblOdrId;
        private System.Windows.Forms.TableLayoutPanel tlpPayment;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDisTotal;
        private System.Windows.Forms.Label lblDisCash;
        private System.Windows.Forms.Label lblDisChange;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flpOdrItems;
        private System.Windows.Forms.TableLayoutPanel tlpItemHeader;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblPrice;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label lblThx;
    }
}

namespace BetterLimited
{
    partial class frmPOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPOS));
            this.flpCrdItems = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.flpOdrLst = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClearOdrLst = new System.Windows.Forms.Button();
            this.tlpSearchBar = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCash = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblDisTotal = new System.Windows.Forms.Label();
            this.lblDisChange = new System.Windows.Forms.Label();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpSearchBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpCrdItems
            // 
            resources.ApplyResources(this.flpCrdItems, "flpCrdItems");
            this.flpCrdItems.BackColor = System.Drawing.Color.Transparent;
            this.flpCrdItems.Name = "flpCrdItems";
            // 
            // txtSearch
            // 
            resources.ApplyResources(this.txtSearch, "txtSearch");
            this.txtSearch.Name = "txtSearch";
            // 
            // btnSearch
            // 
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // flpOdrLst
            // 
            resources.ApplyResources(this.flpOdrLst, "flpOdrLst");
            this.flpOdrLst.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flpOdrLst.Name = "flpOdrLst";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Name = "label1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Name = "label4";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Name = "label2";
            // 
            // btnClearOdrLst
            // 
            resources.ApplyResources(this.btnClearOdrLst, "btnClearOdrLst");
            this.btnClearOdrLst.BackColor = System.Drawing.Color.Orange;
            this.btnClearOdrLst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearOdrLst.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btnClearOdrLst.Name = "btnClearOdrLst";
            this.btnClearOdrLst.UseVisualStyleBackColor = false;
            this.btnClearOdrLst.Click += new System.EventHandler(this.btnClearOdrLst_Click);
            // 
            // tlpSearchBar
            // 
            resources.ApplyResources(this.tlpSearchBar, "tlpSearchBar");
            this.tlpSearchBar.BackColor = System.Drawing.Color.Transparent;
            this.tlpSearchBar.Controls.Add(this.btnSearch, 1, 0);
            this.tlpSearchBar.Controls.Add(this.txtSearch, 0, 0);
            this.tlpSearchBar.Name = "tlpSearchBar";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.tlpSearchBar);
            this.panel1.Controls.Add(this.flpCrdItems);
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Controls.Add(this.btnCheckout);
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Controls.Add(this.flpOdrLst);
            this.panel2.Controls.Add(this.btnClearOdrLst);
            this.panel2.Name = "panel2";
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Gainsboro;
            this.tableLayoutPanel3.Controls.Add(this.lblTotal, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblCash, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblChange, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblDisTotal, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblDisChange, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtCash, 1, 1);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // lblTotal
            // 
            resources.ApplyResources(this.lblTotal, "lblTotal");
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotal.Name = "lblTotal";
            // 
            // lblCash
            // 
            resources.ApplyResources(this.lblCash, "lblCash");
            this.lblCash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCash.Name = "lblCash";
            // 
            // lblChange
            // 
            resources.ApplyResources(this.lblChange, "lblChange");
            this.lblChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblChange.Name = "lblChange";
            // 
            // lblDisTotal
            // 
            resources.ApplyResources(this.lblDisTotal, "lblDisTotal");
            this.lblDisTotal.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblDisTotal.Name = "lblDisTotal";
            // 
            // lblDisChange
            // 
            resources.ApplyResources(this.lblDisChange, "lblDisChange");
            this.lblDisChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDisChange.Name = "lblDisChange";
            // 
            // txtCash
            // 
            resources.ApplyResources(this.txtCash, "txtCash");
            this.txtCash.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCash.Name = "txtCash";
            this.txtCash.Tag = "";
            this.txtCash.TextChanged += new System.EventHandler(this.txtCash_TextChanged);
            this.txtCash.Enter += new System.EventHandler(this.txtCash_Enter);
            // 
            // btnCheckout
            // 
            resources.ApplyResources(this.btnCheckout, "btnCheckout");
            this.btnCheckout.BackColor = System.Drawing.Color.Teal;
            this.btnCheckout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckout.FlatAppearance.BorderSize = 0;
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Name = "label5";
            // 
            // frmPOS
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPOS";
            this.Load += new System.EventHandler(this.frmPOS_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tlpSearchBar.ResumeLayout(false);
            this.tlpSearchBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpCrdItems;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.FlowLayoutPanel flpOdrLst;
        private System.Windows.Forms.Button btnClearOdrLst;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tlpSearchBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblDisTotal;
        private System.Windows.Forms.Label lblDisChange;
        private System.Windows.Forms.TextBox txtCash;
    }
}


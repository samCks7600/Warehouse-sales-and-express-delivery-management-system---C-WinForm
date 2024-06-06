
namespace BetterLimited
{
    partial class frmDlvrOdr
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dtpInstall = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.txtCustTel = new System.Windows.Forms.TextBox();
            this.txtCustAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDlvr = new System.Windows.Forms.DateTimePicker();
            this.cklDlvrTimeOpt = new System.Windows.Forms.CheckedListBox();
            this.lblInstallDateTime = new System.Windows.Forms.Label();
            this.chkInstall = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dtpInstall, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtCustName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCustTel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtCustAddress, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.dtpDlvr, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.cklDlvrTimeOpt, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblInstallDateTime, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.chkInstall, 0, 9);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 14);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(413, 522);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dtpInstall
            // 
            this.dtpInstall.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.dtpInstall.Enabled = false;
            this.dtpInstall.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInstall.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInstall.Location = new System.Drawing.Point(4, 486);
            this.dtpInstall.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpInstall.Name = "dtpInstall";
            this.dtpInstall.Size = new System.Drawing.Size(216, 30);
            this.dtpInstall.TabIndex = 11;
            this.dtpInstall.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(405, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telephone No.";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(405, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // txtCustName
            // 
            this.txtCustName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustName.Location = new System.Drawing.Point(4, 31);
            this.txtCustName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(405, 30);
            this.txtCustName.TabIndex = 3;
            // 
            // txtCustTel
            // 
            this.txtCustTel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustTel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustTel.Location = new System.Drawing.Point(4, 94);
            this.txtCustTel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCustTel.Name = "txtCustTel";
            this.txtCustTel.Size = new System.Drawing.Size(405, 30);
            this.txtCustTel.TabIndex = 4;
            // 
            // txtCustAddress
            // 
            this.txtCustAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustAddress.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustAddress.Location = new System.Drawing.Point(4, 157);
            this.txtCustAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCustAddress.Multiline = true;
            this.txtCustAddress.Name = "txtCustAddress";
            this.txtCustAddress.Size = new System.Drawing.Size(405, 99);
            this.txtCustAddress.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 263);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(405, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Delivery Date / Time";
            // 
            // dtpDlvr
            // 
            this.dtpDlvr.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.dtpDlvr.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDlvr.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDlvr.Location = new System.Drawing.Point(4, 382);
            this.dtpDlvr.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpDlvr.Name = "dtpDlvr";
            this.dtpDlvr.Size = new System.Drawing.Size(216, 30);
            this.dtpDlvr.TabIndex = 7;
            // 
            // cklDlvrTimeOpt
            // 
            this.cklDlvrTimeOpt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cklDlvrTimeOpt.BackColor = System.Drawing.SystemColors.Control;
            this.cklDlvrTimeOpt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cklDlvrTimeOpt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cklDlvrTimeOpt.FormattingEnabled = true;
            this.cklDlvrTimeOpt.Items.AddRange(new object[] {
            "Morning ( 9:00 a.m. - 12:00 p.m. )",
            "Afternoon ( 1:00 p.m. - 5:00 p.m. )",
            "Evening ( 6:00 p.m. - 10:00 p.m. )"});
            this.cklDlvrTimeOpt.Location = new System.Drawing.Point(4, 308);
            this.cklDlvrTimeOpt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cklDlvrTimeOpt.Name = "cklDlvrTimeOpt";
            this.cklDlvrTimeOpt.Size = new System.Drawing.Size(405, 50);
            this.cklDlvrTimeOpt.TabIndex = 8;
            this.cklDlvrTimeOpt.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cklDlvrTimeOpt_ItemCheck);
            // 
            // lblInstallDateTime
            // 
            this.lblInstallDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInstallDateTime.AutoSize = true;
            this.lblInstallDateTime.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstallDateTime.Location = new System.Drawing.Point(4, 459);
            this.lblInstallDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstallDateTime.Name = "lblInstallDateTime";
            this.lblInstallDateTime.Size = new System.Drawing.Size(405, 24);
            this.lblInstallDateTime.TabIndex = 9;
            this.lblInstallDateTime.Text = "Installation Date / Time";
            this.lblInstallDateTime.Visible = false;
            // 
            // chkInstall
            // 
            this.chkInstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkInstall.AutoSize = true;
            this.chkInstall.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInstall.Location = new System.Drawing.Point(4, 422);
            this.chkInstall.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkInstall.Name = "chkInstall";
            this.chkInstall.Size = new System.Drawing.Size(405, 28);
            this.chkInstall.TabIndex = 10;
            this.chkInstall.Text = "Installation";
            this.chkInstall.UseVisualStyleBackColor = true;
            this.chkInstall.CheckedChanged += new System.EventHandler(this.chkInstall_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(217, 578);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 38);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(89, 578);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(120, 38);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmDlvrOdr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 648);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmDlvrOdr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Delivery Form";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.TextBox txtCustTel;
        private System.Windows.Forms.TextBox txtCustAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDlvr;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.CheckedListBox cklDlvrTimeOpt;
        private System.Windows.Forms.Label lblInstallDateTime;
        private System.Windows.Forms.CheckBox chkInstall;
        private System.Windows.Forms.DateTimePicker dtpInstall;
    }
}
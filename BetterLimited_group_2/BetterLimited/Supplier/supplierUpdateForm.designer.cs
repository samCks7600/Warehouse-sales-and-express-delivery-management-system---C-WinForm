
namespace BetterLimited
{
    partial class supplierUpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(supplierUpdateForm));
            this.RRRLbl = new System.Windows.Forms.Label();
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.label_tel = new System.Windows.Forms.Label();
            this.label_address = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RRRLbl
            // 
            resources.ApplyResources(this.RRRLbl, "RRRLbl");
            this.RRRLbl.BackColor = System.Drawing.Color.DarkTurquoise;
            this.RRRLbl.Name = "RRRLbl";
            // 
            // txtSupplierID
            // 
            resources.ApplyResources(this.txtSupplierID, "txtSupplierID");
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.ReadOnly = true;
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
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtAddress
            // 
            resources.ApplyResources(this.txtAddress, "txtAddress");
            this.txtAddress.Name = "txtAddress";
            // 
            // txtName
            // 
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.Name = "txtName";
            // 
            // txtTel
            // 
            resources.ApplyResources(this.txtTel, "txtTel");
            this.txtTel.Name = "txtTel";
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // button_clear
            // 
            resources.ApplyResources(this.button_clear, "button_clear");
            this.button_clear.BackColor = System.Drawing.SystemColors.Info;
            this.button_clear.Name = "button_clear";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_cancel
            // 
            resources.ApplyResources(this.button_cancel, "button_cancel");
            this.button_cancel.BackColor = System.Drawing.Color.Silver;
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_update
            // 
            resources.ApplyResources(this.button_update, "button_update");
            this.button_update.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_update.Name = "button_update";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // label_tel
            // 
            resources.ApplyResources(this.label_tel, "label_tel");
            this.label_tel.ForeColor = System.Drawing.Color.Red;
            this.label_tel.Name = "label_tel";
            // 
            // label_address
            // 
            resources.ApplyResources(this.label_address, "label_address");
            this.label_address.ForeColor = System.Drawing.Color.Red;
            this.label_address.Name = "label_address";
            // 
            // label_name
            // 
            resources.ApplyResources(this.label_name, "label_name");
            this.label_name.ForeColor = System.Drawing.Color.Red;
            this.label_name.Name = "label_name";
            // 
            // supplierUpdateForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_tel);
            this.Controls.Add(this.label_address);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSupplierID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RRRLbl);
            this.Name = "supplierUpdateForm";
            this.Load += new System.EventHandler(this.supplierUpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RRRLbl;
        private System.Windows.Forms.TextBox txtSupplierID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Label label_tel;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.Label label_name;
    }
}
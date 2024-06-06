
namespace BetterLimited
{
    partial class supplierNewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(supplierNewForm));
            this.RRRLbl = new System.Windows.Forms.Label();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_address = new System.Windows.Forms.Label();
            this.label_tel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RRRLbl
            // 
            resources.ApplyResources(this.RRRLbl, "RRRLbl");
            this.RRRLbl.BackColor = System.Drawing.Color.DarkTurquoise;
            this.RRRLbl.Name = "RRRLbl";
            // 
            // button_Clear
            // 
            resources.ApplyResources(this.button_Clear, "button_Clear");
            this.button_Clear.BackColor = System.Drawing.SystemColors.Info;
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_cancel
            // 
            resources.ApplyResources(this.button_cancel, "button_cancel");
            this.button_cancel.BackColor = System.Drawing.Color.Gainsboro;
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_save
            // 
            resources.ApplyResources(this.button_save, "button_save");
            this.button_save.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_save.Name = "button_save";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // txtTel
            // 
            resources.ApplyResources(this.txtTel, "txtTel");
            this.txtTel.Name = "txtTel";
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // txtName
            // 
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.Name = "txtName";
            // 
            // txtAddress
            // 
            resources.ApplyResources(this.txtAddress, "txtAddress");
            this.txtAddress.Name = "txtAddress";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtSupplierID
            // 
            resources.ApplyResources(this.txtSupplierID, "txtSupplierID");
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.ReadOnly = true;
            // 
            // label_name
            // 
            resources.ApplyResources(this.label_name, "label_name");
            this.label_name.ForeColor = System.Drawing.Color.Red;
            this.label_name.Name = "label_name";
            // 
            // label_address
            // 
            resources.ApplyResources(this.label_address, "label_address");
            this.label_address.ForeColor = System.Drawing.Color.Red;
            this.label_address.Name = "label_address";
            // 
            // label_tel
            // 
            resources.ApplyResources(this.label_tel, "label_tel");
            this.label_tel.ForeColor = System.Drawing.Color.Red;
            this.label_tel.Name = "label_tel";
            // 
            // supplierNewForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_tel);
            this.Controls.Add(this.label_address);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSupplierID);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.RRRLbl);
            this.Name = "supplierNewForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RRRLbl;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSupplierID;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.Label label_tel;
    }
}
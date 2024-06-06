
namespace BetterLimited
{
    partial class UpdateRetailLowLevelQty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateRetailLowLevelQty));
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtLowLevelQty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.lblItemID = new System.Windows.Forms.Label();
            this.txtStore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWarning
            // 
            resources.ApplyResources(this.lblWarning, "lblWarning");
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Name = "lblWarning";
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            resources.ApplyResources(this.btnUpdate, "btnUpdate");
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtLowLevelQty
            // 
            resources.ApplyResources(this.txtLowLevelQty, "txtLowLevelQty");
            this.txtLowLevelQty.Name = "txtLowLevelQty";
            this.txtLowLevelQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLowLevelQty_KeyPress);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Name = "label3";
            // 
            // txtQuantity
            // 
            resources.ApplyResources(this.txtQuantity, "txtQuantity");
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.ReadOnly = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Name = "label2";
            // 
            // txtItemName
            // 
            resources.ApplyResources(this.txtItemName, "txtItemName");
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.ReadOnly = true;
            // 
            // lblItemName
            // 
            resources.ApplyResources(this.lblItemName, "lblItemName");
            this.lblItemName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblItemName.Name = "lblItemName";
            // 
            // txtItemID
            // 
            resources.ApplyResources(this.txtItemID, "txtItemID");
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.ReadOnly = true;
            // 
            // lblItemID
            // 
            resources.ApplyResources(this.lblItemID, "lblItemID");
            this.lblItemID.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblItemID.Name = "lblItemID";
            // 
            // txtStore
            // 
            resources.ApplyResources(this.txtStore, "txtStore");
            this.txtStore.Name = "txtStore";
            this.txtStore.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Name = "label1";
            // 
            // UpdateRetailLowLevelQty
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtStore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtLowLevelQty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.txtItemID);
            this.Controls.Add(this.lblItemID);
            this.Name = "UpdateRetailLowLevelQty";
            this.Load += new System.EventHandler(this.UpdateRetailLowLevelQty_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtLowLevelQty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.TextBox txtStore;
        private System.Windows.Forms.Label label1;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterLimited
{
    public partial class frmOdrCust : Form
    {
        public frmOdrCust()
        {
            InitializeComponent();
        }

        private customer cust = new customer();
        public customer Cust
        {
            get { return cust; }

            set
            {
                cust = value;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtCustName.Text) == true || String.IsNullOrWhiteSpace(txtCustTel.Text) == true) {
                MessageBox.Show("Please fill in all the information.");
            }
            else {
                this.DialogResult = DialogResult.OK;

                cust.Name = txtCustName.Text.Trim();
                cust.Tel = int.Parse(txtCustTel.Text.Trim());

                using (dbEntities db = new dbEntities())
                {
                    db.customers.Add(cust);
                    db.SaveChanges();
                }
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

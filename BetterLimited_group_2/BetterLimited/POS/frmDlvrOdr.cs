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
    public partial class frmDlvrOdr : Form
    {
        public DateTime dtDlvr;
        public DateTime dtInstall;
        public bool instl = false;
        public frmDlvrOdr()
        {
            InitializeComponent();
            dtDlvr = new DateTime();
            dtInstall = new DateTime();
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

        /*
        Morning( 9:00 a.m. - 12:00 p.m. )
        Afternoon( 1:00 a.m. - 5:00 p.m. )
        Evening( 6:00 a.m. - 10:00 p.m. )
        */
        private void cklDlvrTimeOpt_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < cklDlvrTimeOpt.Items.Count; ++i)
            {
                if (i != e.Index) cklDlvrTimeOpt.SetItemChecked(i, false);
            }
        }

        private void chkInstall_CheckedChanged(object sender, EventArgs e)
        {
            dtInstall = DateTime.Parse(dtpDlvr.Text).AddHours(2);
            dtpInstall.Value = dtInstall;

            if (chkInstall.Checked == true)
            {
                instl = true;
                Console.WriteLine(instl);
                lblInstallDateTime.Visible = true;
                dtpInstall.Visible = true;
            }
            else
            {
                instl = false;
                lblInstallDateTime.Visible = false;
                dtpInstall.Visible = false;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // DEBUG
            Console.WriteLine($"{String.IsNullOrWhiteSpace(txtCustName.Text)} {String.IsNullOrWhiteSpace(txtCustTel.Text)} {String.IsNullOrWhiteSpace(txtCustAddress.Text)}");

            if (String.IsNullOrWhiteSpace(txtCustName.Text) == true || String.IsNullOrWhiteSpace(txtCustTel.Text) == true || String.IsNullOrWhiteSpace(txtCustAddress.Text) == true) {
                MessageBox.Show("Please fill in all the information and select a delivery data / time.");
            }
            else if (cklDlvrTimeOpt.CheckedItems.Contains(cklDlvrTimeOpt.SelectedItem))
            {
                int lowerBound = 0;
                int upperBound = 0;

                if (cklDlvrTimeOpt.SelectedIndex == 0)
                {
                    // DEBUG
                    Console.WriteLine(cklDlvrTimeOpt.SelectedItem);
                    Console.WriteLine(dtpDlvr.Value.Hour);

                    lowerBound = 9;
                    upperBound = 12;

                }
                else if (cklDlvrTimeOpt.SelectedIndex == 1)
                {
                    lowerBound = 13;
                    upperBound = 17;
                }
                else if (cklDlvrTimeOpt.SelectedIndex == 2)
                {
                    lowerBound = 18;
                    upperBound = 22;
                }

                if (dtpDlvr.Value.Hour < lowerBound || dtpDlvr.Value.Hour > upperBound)
                {
                    MessageBox.Show("Delivery time out of bound.");
                    return;
                }
                else
                {
                    this.DialogResult = DialogResult.OK;

                    cust.Name = txtCustName.Text.Trim();
                    cust.Tel = int.Parse(txtCustTel.Text.Trim());
                    cust.Address = txtCustAddress.Text.Trim();
                    dtDlvr = dtpDlvr.Value;

                    using (dbEntities db = new dbEntities())
                    {
                        db.customers.Add(cust);
                        db.SaveChanges();
                    }
                    this.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

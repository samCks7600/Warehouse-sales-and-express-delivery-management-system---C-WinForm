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
    public partial class ContrOdrItem : UserControl
    {
        public salesorder_item odrItem;
        public bool podr = false;

        public event EventHandler<ContrOdrItem> BtnOdrItemDeleted;
        public event EventHandler<ContrOdrItem> OdrItemIncremented;

        public ContrOdrItem(item _itm)
        {
            InitializeComponent();
            Item = _itm;
            lblDisQty.Text = (odrItem.Qty = 1).ToString();

            // [TEMP] Disable due to bug
            btnQtyIncrement.Visible = false;
            btnQtyReduction.Visible = false;
        }

        private item itm;
        public item Item
        {
            get { return itm; }

            set
            {
                itm = value;
                odrItem = new salesorder_item();

                odrItem.ItemID = itm.ItemID;
                odrItem.SalePrice = itm.SalePrice;
                    
                lblOdrItemId.Text = "#" + itm.ItemID.ToString();
                lblOdrItemName.Text = itm.ItemName;
                lblOdrItemPrice.Text = itm.SalePrice.ToString("C0");
            }
        }

        public void UpdataData()
        {
            lblDisQty.Text = odrItem.Qty.ToString();
            lblOdrItemPrice.Text = (odrItem.SalePrice * odrItem.Qty).ToString("C0");
        }

        public bool CheckStockEmpty()
        {
            bool value;
            using (dbEntities db = new dbEntities())
            {
                value = db.retailstocklevels.Where(i => i.itemID == this.odrItem.ItemID && i.Quantity == 0).Any();
            }
            return value;
        }

        private void btnDeleteOdrItem_Click(object sender, EventArgs e)
        {
            BtnOdrItemDeleted?.Invoke(sender, this);
        }

        private void btnQtyIncrement_Click(object sender, EventArgs e)
        {
            OdrItemIncremented?.Invoke(1, this);
        }

        private void btnQtyReduction_Click(object sender, EventArgs e)
        {
            OdrItemIncremented?.Invoke(-1, this);
        }
    }
}

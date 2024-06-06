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
    public partial class ContrGdsRtnItem : UserControl
    {
        int itemPrice;

        public ContrGdsRtnItem(goodreturnnote_item _item)
        {
            InitializeComponent();
            Item = _item;
        }

        private goodreturnnote_item itm;

        public goodreturnnote_item Item
        {
            set
            {
                itm = value;
                lblSupId.Text = "#" + itm.item.SupplierID.ToString();
                lblSupName.Text = itm.item.supplier.SupplierName;
                lblQty.Text = itm.Qty.ToString();
                lblDescr.Text = itm.item.ItemName;
                lblUnitPrice.Text = itm.item.SalePrice.ToString("C2");
                lblAmt.Text = (itm.item.SalePrice * (int)itm.Qty).ToString("C2");
            }
        }
    }
}

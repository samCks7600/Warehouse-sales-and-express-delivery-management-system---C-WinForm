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
    public partial class ContrReceiptItem : UserControl
    {
        public ContrReceiptItem(salesorder_item _item)
        {
            InitializeComponent();
            Item = _item;
        }

        private salesorder_item itm;
        public salesorder_item Item
        {
            set 
            {
                itm = value;
                lblId.Text = itm.ItemID.ToString();
                lblName.Text = itm.item.ItemName;
                lblQty.Text = itm.Qty.ToString();
                lblPrice.Text = itm.SalePrice.ToString("C0");
            }
        }
    }
}

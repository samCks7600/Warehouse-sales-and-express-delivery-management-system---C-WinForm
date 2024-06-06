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
    public partial class ContrDlvrItem : UserControl
    {
        public ContrDlvrItem(salesorder_item _item)
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
                lblQty.Text = itm.Qty.ToString();
                lblDescr.Text = itm.item.ItemName;
                lblUnitPrice.Text = itm.SalePrice.ToString("C2");
                lblAmt.Text = (itm.SalePrice * itm.Qty).ToString("C2");
            }
        }
    }
}

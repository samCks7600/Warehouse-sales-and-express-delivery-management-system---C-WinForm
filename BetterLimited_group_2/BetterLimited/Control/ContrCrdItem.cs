using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BetterLimited
{
    public partial class ContrCrdItem : UserControl
    {
        private item itm;
        public int qty;
        private int lowerQtyBound;
        public event EventHandler<item> BtnAddToLstClicked;

        public ContrCrdItem(item _item)
        {
            InitializeComponent();
            CrdItem = _item;
            using (dbEntities db = new dbEntities())
            {
                var item = db.retailstocklevels.FirstOrDefault(i => i.itemID == _item.ItemID);
                qty = item.Quantity;
                lowerQtyBound = item.LowLevelQty;
            }
            CheckQty();
        }

        public item CrdItem
        {
            get { return itm; }

            set
            {
                itm = value;
                picItem.BackgroundImage = ByteArrayToImage(itm.ItemImg.ToArray());
                lblDisItemID.Text = $"#{itm.ItemID}";
                lblDisItemName.Text = itm.ItemName;
                lblDisItemPrice.Text = itm.SalePrice.ToString("C0");
            }
        }

        // Translate byte data into an image
        public Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }

        public void CheckQty()
        {
            if (qty <= 0)
            {
                btnAddToLst.Text = "[ Out of Stock ]\nAdd to Pre-order";
                btnAddToLst.BackColor = Color.Brown;
            }
            else if (qty <= lowerQtyBound)
            {
                btnAddToLst.Text = "[ Low in Stock ]\nAdd to Order List";
                btnAddToLst.BackColor = Color.Goldenrod;
            }
            else
            {
                btnAddToLst.Text = "Add to Order List";
                btnAddToLst.BackColor = Color.SeaGreen;
            }
        }

        private void btnAddToLst_Click(object sender, EventArgs e)
        {
            // Raise the event
            // if (BtnAddToLstClicked != null) BtnAddToLstClicked(sender, itm);
            BtnAddToLstClicked?.Invoke(sender, itm);
            qty -= 1;
            CheckQty();
        }
    }
}

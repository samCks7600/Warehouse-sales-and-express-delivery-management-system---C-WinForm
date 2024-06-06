using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterLimited
{
    class PurchaseItem
    {
        public string supplierID;
        public string itemID;
        public string purchaseOrderID;
        public string qty;

        public PurchaseItem(string supplierID, string itemID, string purchaseOrderID, string qty)
        {
            this.supplierID = supplierID;
            this.itemID = itemID;
            this.purchaseOrderID = purchaseOrderID;
            this.qty = qty;
        }
    }
}

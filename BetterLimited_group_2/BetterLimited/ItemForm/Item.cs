using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterLimited.ItemForm
{
    class Item
    {
        public string ID { get; set; }
        public string Cat { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public object Img { get; set; }
        public string SalePrice { get; set; }
        public string SID { get; set; }
        public string SPrice { get; set; }
        public string WarrantyMonth { get; set; }
        public string AllowDelivery { get; set; }

        public Item(string ItemID, string ItemCat, string ItemName, string ItemDesc, object ItemImg, string SalePrice, string SupplierID, string SupplierPrice, string WarrantyMonth, string AllowDelivery)
        {
            this.ID = ItemID;
            this.Cat = ItemCat;
            this.Name = ItemName;
            this.Desc = ItemDesc;
            this.Img = ItemImg;
            this.SalePrice = SalePrice;
            this.SID = SupplierID;
            this.SPrice = SupplierPrice;
            this.WarrantyMonth = WarrantyMonth;
            this.AllowDelivery = AllowDelivery;
        }

    }
}

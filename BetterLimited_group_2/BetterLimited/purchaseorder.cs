//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BetterLimited
{
    using System;
    using System.Collections.Generic;
    
    public partial class purchaseorder
    {
        public purchaseorder()
        {
            this.goodsreceivednotes = new HashSet<goodsreceivednote>();
            this.purchaseorder_item = new HashSet<purchaseorder_item>();
        }
    
        public int PurchaseOrderID { get; set; }
        public int StaffID { get; set; }
        public int SupplierID { get; set; }
        public System.DateTime OrderDate { get; set; }
        public System.TimeSpan OrderTime { get; set; }
        public string OrderStatus { get; set; }
    
        public virtual ICollection<goodsreceivednote> goodsreceivednotes { get; set; }
        public virtual staff staff { get; set; }
        public virtual ICollection<purchaseorder_item> purchaseorder_item { get; set; }
        public virtual supplier supplier { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Objects.SqlClient;
using System.Threading;

// 1. Analysis & clean my code (Adding comments etc.)
// 2. Improve the structure (Modulize etc.)
// 3. Adding new features

namespace BetterLimited
{
    public partial class frmPOS : Form
    {
        public decimal grandTotal;
        public decimal odrTotal;
        public decimal podrTotal;

        public int paidAmt = 0;

        //public int storeID = 1;
        //public int staffID = 10001;
        string staff;
        int staffID, storeID;

        List<ContrCrdItem> lstCrdItems = new List<ContrCrdItem>();
        List<ContrOdrItem> lstOdrItems = new List<ContrOdrItem>();
        List<ContrOdrItem> lstPodrItems = new List<ContrOdrItem>();

        public frmPOS()
        {
            InitializeComponent();
            txtCash.Enabled = false;
        }

        public string StaffID
        {
            get { return staff; }
            set { staff = value; }
        }

        public int StoreID
        {
            get { return storeID; }
            set { storeID = value; }
        }

        // Methods
        void LoadCatalog(List<item> _item)
        {
            flpCrdItems.Controls.Clear();
            for (int i = 0; i < _item.Count(); i++)
            {
                var crdItem = new ContrCrdItem(_item[i]);
                crdItem.BtnAddToLstClicked += OnBtnAddToLstClicked; // Subscribe Event

                lstCrdItems.Add(crdItem);
                flpCrdItems.Controls.Add(lstCrdItems[i]);
            }
        }

        void CreateOdrItem(item _item)
        {
            var ordItem = new ContrOdrItem(_item);              // Create instance (Subscriber)
            ordItem.BtnOdrItemDeleted += OnBtnOdrItemDeleted;   // Subscribe to event "BtnOdrItemDeleted"
            ordItem.OdrItemIncremented += OnOdrItemIncrement;   // Subscribe to event "OdrItemIncremented"

            lstOdrItems.Add(ordItem);
            flpOdrLst.Controls.Add(ordItem);
            ordItem.BringToFront();
        }

        void CreatePodrItem(item _item)
        {
            var podrItem = new ContrOdrItem(_item);              // Create instance (Subscriber)
            podrItem.podr = true;
            podrItem.BtnOdrItemDeleted += OnBtnOdrItemDeleted;   // Subscribe to event "BtnOdrItemDeleted"
            podrItem.OdrItemIncremented += OnOdrItemIncrement;   // Subscribe to event "OdrItemIncremented"
            podrItem.BackColor = Color.FromArgb(255, 192, 192);

            lstPodrItems.Add(podrItem);
            flpOdrLst.Controls.Add(podrItem);
        }

        void CreateOdr()
        {
            using (dbEntities db = new dbEntities())
            {
                if (lstOdrItems.Any(i => i.Item.AllowDelivery.Contains("True")))
                {
                    if (lstOdrItems.Count(i => i.Item.AllowDelivery.Contains("False")) == 0)
                    {
                        // Create Delivery Order
                        salesorder dodr = new salesorder();
                        deliveryorder dlvrOdr = new deliveryorder();

                        frmDlvrOdr dlvrFrm = new frmDlvrOdr();
                        if (dlvrFrm.ShowDialog(this) == DialogResult.OK)
                        {
                            dodr.StoreID = storeID;  // TEMP
                            dodr.StaffID = staffID;  // TEMP
                            dodr.PaidAmt = paidAmt;
                            dodr.Date = DateTime.UtcNow.Date;
                            dodr.Time = DateTime.Now.TimeOfDay;
                            dodr.PaymentStatus = "settled";
                            dodr.CustomerID = dlvrFrm.Cust.CustomerID;

                            foreach (var i in lstOdrItems.Where(j => j.Item.AllowDelivery.Contains("True")))
                            {
                                dodr.salesorder_item.Add(i.odrItem);
                            }

                            // Deduct Qty
                            var dodrItems = dodr.salesorder_item.ToList();
                            foreach (var i in dodrItems)
                            {
                                // DEBUG
                                Console.WriteLine(i.Qty);
                                var item = db.retailstocklevels.FirstOrDefault(j => j.itemID == i.ItemID);

                                // DEBUG
                                //Console.WriteLine(item.itemName);
                                item.Quantity -= i.Qty;
                            }

                            db.salesorders.Add(dodr);
                            db.SaveChanges();

                            dlvrOdr.SalesOrderID = dodr.SalesOrderID;
                            dlvrOdr.DeliveryStatus = "pending";
                            dlvrOdr.DeliveryDate = dlvrFrm.dtDlvr.Date;
                            dlvrOdr.DeliveryTime = dlvrFrm.dtDlvr.TimeOfDay;
                            db.deliveryorders.Add(dlvrOdr);
                            db.SaveChanges();

                            // Create Delivery Note
                            frmDlvrNote dlvrNote = new frmDlvrNote(dlvrOdr.DeliveryID);
                            dlvrNote.Print();

                            if (dlvrFrm.instl == true)
                            {
                                // Create Installaion Order
                                installationorder instlOdr = new installationorder();
                                instlOdr.SalesOrderID = dodr.SalesOrderID;
                                instlOdr.InstallationDate = dlvrFrm.dtInstall.Date;
                                instlOdr.InstallationTime = dlvrFrm.dtInstall.TimeOfDay;
                                instlOdr.InstallationStatus = "pending";

                                db.installationorders.Add(instlOdr);
                                db.SaveChanges();

                                // Print Installation Note???
                            }
                        }
                    }
                    else
                    {
                        // Create Delivery Order
                        salesorder dodr = new salesorder();
                        deliveryorder dlvrOdr = new deliveryorder();

                        frmDlvrOdr dlvrFrm = new frmDlvrOdr();
                        if (dlvrFrm.ShowDialog(this) == DialogResult.OK)
                        {
                            dodr.StoreID = storeID;  // TEMP
                            dodr.StaffID = staffID;  // TEMP
                            dodr.PaidAmt = paidAmt;
                            dodr.Date = DateTime.UtcNow.Date;
                            dodr.Time = DateTime.Now.TimeOfDay;
                            dodr.PaymentStatus = "settled";
                            dodr.CustomerID = dlvrFrm.Cust.CustomerID;

                            foreach (var i in lstOdrItems.Where(j => j.Item.AllowDelivery.Contains("True")))
                            {
                                dodr.salesorder_item.Add(i.odrItem);
                            }

                            // Deduct Qty
                            var dodrItems = dodr.salesorder_item.ToList();
                            foreach (var i in dodrItems)
                            {
                                // DEBUG
                                Console.WriteLine(i.Qty);
                                var item = db.retailstocklevels.FirstOrDefault(j => j.itemID == i.ItemID);

                                // DEBUG
                                //Console.WriteLine(item.itemName);
                                item.Quantity -= i.Qty;
                            }

                            db.salesorders.Add(dodr);
                            db.SaveChanges();

                            dlvrOdr.SalesOrderID = dodr.SalesOrderID;
                            dlvrOdr.DeliveryStatus = "pending";
                            dlvrOdr.DeliveryDate = dlvrFrm.dtDlvr.Date;
                            dlvrOdr.DeliveryTime = dlvrFrm.dtDlvr.TimeOfDay;
                            db.deliveryorders.Add(dlvrOdr);
                            db.SaveChanges();

                            // Create Delivery Note
                            frmDlvrNote dlvrNote = new frmDlvrNote(dlvrOdr.DeliveryID);
                            dlvrNote.Print();

                            if (dlvrFrm.instl == true)
                            {
                                // Create Installaion Order
                                installationorder instlOdr = new installationorder();
                                instlOdr.SalesOrderID = dodr.SalesOrderID;
                                instlOdr.InstallationDate = dlvrFrm.dtInstall.Date;
                                instlOdr.InstallationTime = dlvrFrm.dtInstall.TimeOfDay;
                                instlOdr.InstallationStatus = "pending";

                                db.installationorders.Add(instlOdr);
                                db.SaveChanges();

                                // Print Installation Note???
                            }

                            // Create Salesorder
                            salesorder odr = new salesorder();

                            odr.StoreID = storeID;  // TEMP
                            odr.StaffID = staffID;  // TEMP
                            odr.PaidAmt = paidAmt;
                            odr.Date = DateTime.UtcNow.Date;
                            odr.Time = DateTime.Now.TimeOfDay;
                            odr.PaymentStatus = "settled";

                            foreach (var i in lstOdrItems.Where(j => j.Item.AllowDelivery.Contains("False")))
                            {
                                odr.salesorder_item.Add(i.odrItem);
                            }

                            // Deduct Qty
                            var odrItems = odr.salesorder_item.ToList();
                            foreach (var i in odrItems)
                            {
                                // DEBUG
                                Console.WriteLine(i.Qty);
                                var item = db.retailstocklevels.FirstOrDefault(j => j.itemID == i.ItemID);

                                // DEBUG
                                //Console.WriteLine(item.itemName);
                                item.Quantity -= i.Qty;
                            }

                            db.salesorders.Add(odr);
                            db.SaveChanges();

                            // Create Receipt
                            frmOdrReceipt receipt = new frmOdrReceipt(odr.SalesOrderID);
                            receipt.Print();
                        }
                    }
                }
                else
                {
                    // Create Salesorder
                    salesorder odr = new salesorder();

                    odr.StoreID = storeID;  // TEMP
                    odr.StaffID = staffID;  // TEMP
                    odr.PaidAmt = paidAmt;
                    odr.Date = DateTime.UtcNow.Date;
                    odr.Time = DateTime.Now.TimeOfDay;
                    odr.PaymentStatus = "settled";

                    lstOdrItems.ForEach(i => { odr.salesorder_item.Add(i.odrItem); });

                    // Deduct Qty
                    var odrItems = odr.salesorder_item.ToList();
                    foreach (var i in odrItems)
                    {
                        // DEBUG
                        Console.WriteLine(i.Qty);
                        var item = db.retailstocklevels.FirstOrDefault(j => j.itemID == i.ItemID);

                        // DEBUG
                        //Console.WriteLine(item.itemName);
                        item.Quantity -= i.Qty;
                    }

                    db.salesorders.Add(odr);
                    db.SaveChanges();

                    // Create Receipt
                    frmOdrReceipt receipt = new frmOdrReceipt(odr.SalesOrderID);
                    receipt.Print();
                }
            }
        }

        void CreatePodr()
        {
            using (dbEntities db = new dbEntities())
            {
                if (lstPodrItems.Any(i => i.Item.AllowDelivery.Contains("True")))
                {
                    if (lstPodrItems.Count(i => i.Item.AllowDelivery.Contains("False")) == 0)
                    {
                        // Create Delivery Order
                        salesorder dodr = new salesorder();
                        deliveryorder dlvrOdr = new deliveryorder();

                        frmDlvrOdr dlvrFrm = new frmDlvrOdr();
                        if (dlvrFrm.ShowDialog(this) == DialogResult.OK)
                        {
                            dodr.StoreID = storeID;  // TEMP
                            dodr.StaffID = staffID;  // TEMP
                            dodr.PaidAmt = paidAmt;
                            dodr.Date = DateTime.UtcNow.Date;
                            dodr.Time = DateTime.Now.TimeOfDay;
                            dodr.PaymentStatus = "settled";
                            dodr.CustomerID = dlvrFrm.Cust.CustomerID;

                            foreach (var i in lstOdrItems.Where(j => j.Item.AllowDelivery.Contains("True")))
                            {
                                dodr.salesorder_item.Add(i.odrItem);
                            }

                            db.salesorders.Add(dodr);
                            db.SaveChanges();

                            dlvrOdr.SalesOrderID = dodr.SalesOrderID;
                            dlvrOdr.DeliveryStatus = "pending";
                            dlvrOdr.DeliveryDate = dlvrFrm.dtDlvr.Date;
                            dlvrOdr.DeliveryTime = dlvrFrm.dtDlvr.TimeOfDay;
                            db.deliveryorders.Add(dlvrOdr);
                            db.SaveChanges();

                            // Create Delivery Note
                            frmDlvrNote dlvrNote = new frmDlvrNote(dlvrOdr.DeliveryID);
                            dlvrNote.Print();

                            if (dlvrFrm.instl == true)
                            {
                                // Create Installaion Order
                                installationorder instlOdr = new installationorder();
                                instlOdr.SalesOrderID = dodr.SalesOrderID;
                                instlOdr.InstallationDate = dlvrFrm.dtInstall.Date;
                                instlOdr.InstallationTime = dlvrFrm.dtInstall.TimeOfDay;
                                instlOdr.InstallationStatus = "pending";

                                db.installationorders.Add(instlOdr);
                                db.SaveChanges();

                                // Print Installation Note???
                            }
                        }
                    }
                    else
                    {
                        // Create Delivery Order
                        salesorder dodr = new salesorder();
                        deliveryorder dlvrOdr = new deliveryorder();

                        frmDlvrOdr dlvrFrm = new frmDlvrOdr();
                        if (dlvrFrm.ShowDialog(this) == DialogResult.OK)
                        {
                            dodr.StoreID = storeID;  // TEMP
                            dodr.StaffID = staffID;  // TEMP
                            dodr.PaidAmt = paidAmt;
                            dodr.Date = DateTime.UtcNow.Date;
                            dodr.Time = DateTime.Now.TimeOfDay;
                            dodr.PaymentStatus = "settled";
                            dodr.CustomerID = dlvrFrm.Cust.CustomerID;

                            foreach (var i in lstOdrItems.Where(j => j.Item.AllowDelivery.Contains("True")))
                            {
                                dodr.salesorder_item.Add(i.odrItem);
                            }

                            db.salesorders.Add(dodr);
                            db.SaveChanges();

                            dlvrOdr.SalesOrderID = dodr.SalesOrderID;
                            dlvrOdr.DeliveryStatus = "pending";
                            dlvrOdr.DeliveryDate = dlvrFrm.dtDlvr.Date;
                            dlvrOdr.DeliveryTime = dlvrFrm.dtDlvr.TimeOfDay;
                            db.deliveryorders.Add(dlvrOdr);
                            db.SaveChanges();

                            if (dlvrFrm.instl == true)
                            {
                                // Create Installaion Order
                                installationorder instlOdr = new installationorder();
                                instlOdr.SalesOrderID = dodr.SalesOrderID;
                                instlOdr.InstallationDate = dlvrFrm.dtInstall.Date;
                                instlOdr.InstallationTime = dlvrFrm.dtInstall.TimeOfDay;
                                instlOdr.InstallationStatus = "pending";

                                db.installationorders.Add(instlOdr);
                                db.SaveChanges();

                                // Print Installation Note???
                            }

                            // Create Delivery Note
                            frmDlvrNote dlvrNote = new frmDlvrNote(dlvrOdr.DeliveryID);
                            dlvrNote.Print();

                            //Create Pre-order
                            salesorder podr = new salesorder();
                            Console.WriteLine(podr.CustomerID + "W");
                            frmOdrCust custInfo = new frmOdrCust();

                            if (custInfo.ShowDialog(this) == DialogResult.OK)
                            {
                                podr.StoreID = storeID;  // TEMP
                                podr.StaffID = staffID;  // TEMP
                                podr.PaidAmt = paidAmt;
                                podr.Date = DateTime.UtcNow.Date;
                                podr.Time = DateTime.Now.TimeOfDay;
                                podr.PaymentStatus = "ordered";
                                podr.CustomerID = custInfo.Cust.CustomerID;

                                lstPodrItems.ForEach(i => { podr.salesorder_item.Add(i.odrItem); });

                                // Deduct Qty
                                var podrItems = podr.salesorder_item.ToList();
                                foreach (var i in podrItems)
                                {
                                    // DEBUG
                                    Console.WriteLine(i.Qty);
                                    var item = db.retailstocklevels.FirstOrDefault(j => j.itemID == i.ItemID);

                                    // DEBUG
                                    //Console.WriteLine(item.itemName);
                                    item.Quantity -= i.Qty;
                                }

                                db.salesorders.Add(podr);
                                db.SaveChanges();

                                // Create Receipt
                                frmOdrReceipt receipt = new frmOdrReceipt(podr.SalesOrderID);
                                receipt.Print();
                            }
                        }
                    }
                }
                else
                {
                    //Create Pre-order
                    salesorder podr = new salesorder();
                    Console.WriteLine(podr.CustomerID + "W");
                    frmOdrCust custInfo = new frmOdrCust();

                    if (custInfo.ShowDialog(this) == DialogResult.OK)
                    {
                        podr.StoreID = storeID;  // TEMP
                        podr.StaffID = staffID;  // TEMP
                        podr.PaidAmt = paidAmt;
                        podr.Date = DateTime.UtcNow.Date;
                        podr.Time = DateTime.Now.TimeOfDay;
                        podr.PaymentStatus = "ordered";
                        podr.CustomerID = custInfo.Cust.CustomerID;

                        lstPodrItems.ForEach(i => { podr.salesorder_item.Add(i.odrItem); });

                        db.salesorders.Add(podr);
                        db.SaveChanges();

                        // Create Receipt
                        frmOdrReceipt receipt = new frmOdrReceipt(podr.SalesOrderID);
                        receipt.Print();
                    }
                }
            }
        }

        decimal CalOdrTotal()
        {
            odrTotal = 0;
            lstOdrItems.ForEach(i => { odrTotal += i.odrItem.SalePrice; });
            return odrTotal;
        }

        decimal CalPodrTotal()
        {
            podrTotal = 0;
            lstPodrItems.ForEach(i => { podrTotal += i.odrItem.SalePrice; });
            return podrTotal;
        }

        void CalGrandTotal()
        {
            grandTotal = 0;
            grandTotal = CalOdrTotal() + CalPodrTotal();
            lblDisTotal.Text = grandTotal.ToString("C0");
        }

        // Event Handlings
        // From - On Load
        private void frmPOS_Load(object sender, EventArgs e)
        {
            staffID = Int32.Parse(staff);

            // DEBUG
            Console.WriteLine("Store ID: " + storeID);

            using (dbEntities db = new dbEntities())
            {
                var item = db.retailstocklevels.Where(i => i.storeID == storeID).Select(j => j.item).ToList();
                // var item = db.items.ToList();
                LoadCatalog(item);
            }
            // DEBUG
            Console.WriteLine($"Item(s):\t{lstCrdItems.Count()}\n");
        }

        // Button "Search" --- On Click
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                frmPOS_Load(this, EventArgs.Empty);
                return;
            }
            lstCrdItems.Clear();
            using (dbEntities db = new dbEntities())
            {
                var item = db.items
                    .Where(s => s.ItemName.Contains(txtSearch.Text))
                    .ToList();

                LoadCatalog(item);
            }
        }

        // Button "Add to Order List" --- On Click
        public void OnBtnAddToLstClicked(object sender, item _item)
        {
            if (txtCash.Enabled == false)
                txtCash.Enabled = true;

            using (dbEntities db = new dbEntities())
            {
                int qty = db.retailstocklevels.FirstOrDefault(i => i.itemID == _item.ItemID).Quantity;

                // Check Pre-order w/ same itemID
                if (lstPodrItems.Any(i => i.odrItem.ItemID == _item.ItemID))
                {
                    // Get Pre-order w/ same itemID
                    var _odrItem = lstPodrItems.FirstOrDefault(i => i.odrItem.ItemID == _item.ItemID);

                    OnOdrItemIncrement(1, _odrItem);
                }
                // Check qty w/ same itemID
                else if (db.retailstocklevels.Where(i => i.itemID == _item.ItemID && i.Quantity <= 0).Any())
                {
                    // Get Pre-order w/ same itemID
                    var _odrItem = lstPodrItems.FirstOrDefault(i => i.odrItem.ItemID == _item.ItemID);

                    CreatePodrItem(_item);
                    CalGrandTotal();
                }
                else
                {
                    // Check whether the current the "Order List" got the same item added
                    var _odrItem = lstOdrItems.FirstOrDefault(i => i.odrItem.ItemID == _item.ItemID);

                    if (_odrItem == null) // if there isn't
                    {
                        CreateOdrItem(_item);
                        CalGrandTotal();
                    }
                    else // if there is
                    {
                        if (_odrItem.odrItem.Qty >= qty)
                        {
                            CreatePodrItem(_item);
                            CalGrandTotal();
                        }
                        else
                        {
                            OnOdrItemIncrement(1, _odrItem);
                        }
                    }
                }
            }
            txtCash_TextChanged(this, EventArgs.Empty);

            Console.WriteLine($"=== On Increment ===\n" +
                                    $"Added:\t#{_item.ItemID}\t${_item.SalePrice}\n" +
                                    $"Odr:\t{lstOdrItems.Count()}\n" +
                                    $"P-odr:\t{lstPodrItems.Count()}\n" +
                                    $"Total:\t{lblDisTotal.Text}\n");
        }

        // Button "Delete Item" --- On Click
        public void OnBtnOdrItemDeleted(object sender, ContrOdrItem _item)
        {
            // [TEMP] Check Qty
            if (_item.podr == false)
            {
                var crdItem = lstCrdItems.FirstOrDefault(i => i.CrdItem.ItemID == _item.odrItem.ItemID);
                using (dbEntities db = new dbEntities())
                {
                    var stockItem = db.retailstocklevels.FirstOrDefault(i => i.itemID == _item.odrItem.ItemID);
                    crdItem.qty = stockItem.Quantity;
                    crdItem.CheckQty();
                    crdItem.qty = stockItem.Quantity;
                }
            }

            if (lstOdrItems.Any(i => i.odrItem.ItemID == _item.odrItem.ItemID))
            {
                lblDisTotal.Text = (grandTotal -= _item.odrItem.SalePrice * lstOdrItems.Count(i => i.odrItem.ItemID == _item.odrItem.ItemID)).ToString("C2");

                if (txtCash != null)
                    txtCash_TextChanged(this, EventArgs.Empty);

                // DEBUG
                Console.WriteLine($"Odr Del:\t{lstOdrItems.Count(i => i.odrItem.ItemID == _item.odrItem.ItemID)}");

                lstOdrItems.RemoveAll(i => i.odrItem.ItemID == _item.odrItem.ItemID);
                flpOdrLst.Controls.Remove(_item);
                _item.Dispose();

                // DEBUG
                Console.WriteLine($"P-odr:\t{lstOdrItems.Count()}\n");
            }
            else
            {
                lblDisTotal.Text = (grandTotal -= _item.odrItem.SalePrice * lstPodrItems.Count(i => i.odrItem.ItemID == _item.odrItem.ItemID)).ToString("C2");

                if (txtCash != null)
                    txtCash_TextChanged(this, EventArgs.Empty);

                // DEBUG
                Console.WriteLine($"P-odr Del:\t{lstPodrItems.Count(i => i.odrItem.ItemID == _item.odrItem.ItemID)}");

                lstPodrItems.RemoveAll(i => i.odrItem.ItemID == _item.odrItem.ItemID);
                flpOdrLst.Controls.Remove(_item);
                _item.Dispose();

                // DEBUG
                Console.WriteLine($"P-odr:\t{lstPodrItems.Count()}\n");
            }

            if (lstOdrItems.Count == 0 && lstPodrItems.Count == 0)
            {
                txtCash.Enabled = false;
                txtCash.Text = 0.ToString("C2");
                lblDisChange.Text = 0.ToString("C2");
            }

            Console.WriteLine($"=== On Increment ===\n" +
                                    $"Added:\t#{_item.odrItem.ItemID}\t${_item.odrItem.SalePrice}\n" +
                                    $"Odr:\t{lstOdrItems.Count()}\n" +
                                    $"P-odr:\t{lstPodrItems.Count()}\n" +
                                    $"Total:\t{lblDisTotal.Text}\n");
        }

        // Button "+" & "-" --- On Click
        public void OnOdrItemIncrement(object sender, ContrOdrItem _item)
        {
            if (lstOdrItems.Any(i => i.odrItem.ItemID == _item.odrItem.ItemID) && !lstPodrItems.Any(i => i.odrItem.ItemID == _item.odrItem.ItemID))
            {
                if ((int)sender < 1)
                    lstOdrItems.Remove(_item);
                else
                    lstOdrItems.Add(_item);

                _item.odrItem.Qty += Convert.ToInt32(sender);
                if (_item.odrItem.Qty < 1)
                {
                    lstOdrItems.Remove(_item);
                    _item.Dispose();
                }
                else
                {
                    _item.UpdataData();
                }
                CalGrandTotal();

                if (txtCash.Text != null) txtCash_TextChanged(this, EventArgs.Empty);

                Console.WriteLine($"=== On Increment ===\n" +
                                    $"Added:\t#{_item.odrItem.ItemID}\t${_item.odrItem.SalePrice}\n" +
                                    $"Odr:\t{lstOdrItems.Count()}\n" +
                                    $"P-odr:\t{lstPodrItems.Count()}\n" +
                                    $"Total:\t{lblDisTotal.Text}\n");
            }
            else
            {
                if ((int)sender < 1)
                    lstPodrItems.Remove(_item);
                else
                    lstPodrItems.Add(_item);

                _item.odrItem.Qty += Convert.ToInt32(sender);
                if (_item.odrItem.Qty < 1)
                {
                    lstPodrItems.Remove(_item);
                    _item.Dispose();
                }
                else
                {
                    _item.UpdataData();
                }
                CalGrandTotal();

                if (txtCash.Text != null) txtCash_TextChanged(this, EventArgs.Empty);

                Console.WriteLine($"=== On Increment ===\n" +
                                    $"Added:\t#{_item.odrItem.ItemID}\t${_item.odrItem.SalePrice}\n" +
                                    $"Odr:\t{lstOdrItems.Count()}\n" +
                                    $"P-odr:\t{lstPodrItems.Count()}\n" +
                                    $"Total:\t{lblDisTotal.Text}\n");
            }
        }

        // Button "Cancel" --- On Click
        private void btnClearOdrLst_Click(object sender, EventArgs e)
        {
            lblDisTotal.Text = txtCash.Text = lblDisChange.Text = (grandTotal = 0).ToString("C2");
            lstOdrItems.Clear();
            lstPodrItems.Clear();
            flpOdrLst.Controls.Clear();

            lstCrdItems.Clear();
            frmPOS_Load(this, EventArgs.Empty);
        }

        // Text Box "Payment Amount" --- On Text Changed
        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            try
            {
                paidAmt = Int32.Parse(txtCash.Text);
                if (paidAmt < grandTotal)
                {
                    lblDisChange.Text = 0.ToString("C2");
                }
                else
                {
                    lblDisChange.Text = (paidAmt - grandTotal).ToString("C2");
                }
            }
            catch (FormatException error)
            {
                return;
            }
        }

        // Button "Checkout" --- On Click
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (!lstOdrItems.Any() && !lstPodrItems.Any())
            {
                if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                {
                    MessageBox.Show("No item(s) added.");
                }
                else
                {
                    MessageBox.Show(Properties.Settings.Default.NoItemZh);
                }
            }
            else if (!int.TryParse(txtCash.Text, out paidAmt))
            {
                if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                {
                    MessageBox.Show("Please input the payment amount.");
                }
                else
                {
                    MessageBox.Show(Properties.Settings.Default.AmountZh);
                }
            }
            else if (paidAmt < grandTotal)
            {
                if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                {
                    MessageBox.Show("Please input a sufficient payment amount.");
                }
                else
                {
                    MessageBox.Show(Properties.Settings.Default.SAmountZh);
                }
            }
            else if (lstOdrItems.Any() && !lstPodrItems.Any())
            {
                CreateOdr();
                btnClearOdrLst_Click(this, EventArgs.Empty);

            }
            else if (!lstOdrItems.Any() && lstPodrItems.Any())
            {
                CreatePodr();
                btnClearOdrLst_Click(this, EventArgs.Empty);
            }
            else
            {
                CreateOdr();
                CreatePodr();
                btnClearOdrLst_Click(this, EventArgs.Empty);
            }
        }

        private void txtCash_Enter(object sender, EventArgs e)
        {
            txtCash.Text = "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Globalization;
using System.Threading;

namespace BetterLimited
{
    public partial class MenuForm : Form
    {
        // Setting for MySql Database.
        MySqlConnection conn = new MySqlConnection("server=localhost;user id =root;password=;database=betterlimited");
        MySqlCommand command;
        string department, position;
        string staffID = "10001"; //admin account
        int storeID;
        //get set StaffID
        public string getStaffID
        {
            get
            {
                return staffID;
            }
        }

        public string setStaffID
        {
            set
            {
                staffID = value;
            }
        }
        public int getStoreID
        {
            get
            {
                return storeID;
            }
        }

        public int setStoreID
        {
            set
            {
                storeID = value;
            }
        }

        public string getDepartment
        {
            get
            {
                return department;
            }
        }

        public string setDepartment
        {
            set
            {
                department = value;
            }
        }

        public string getPosition
        {
            get
            {
                return position;
            }
        }

        public string setPosition
        {
            set
            {
                position = value;
            }
        }

        public void openConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void closeConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public bool selectQuery(string sql)
        {
            command = conn.CreateCommand();
            command.CommandText = sql;
            try
            {
                openConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                closeConnection();
                return true;
            }
            else
            {
                closeConnection();
                return false;
            }
        }

        public MenuForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        public void HiddenAllButton()
        {
            button_AccountingDepart.Visible = false;
            button_PurchaseDepart.Visible = false;
            button_SalesDepart.Visible = false;
            button_TechnicalDepart.Visible = false;
            button_InventoryDepart.Visible = false;
            btnAdmin.Visible = false;
        }

        public void HiddenAllModule()
        {
            flPanel_AccountDepart.Visible = false;
            flPanel_PurchaseDepart.Visible = false;
            flPanel_SalesDepart.Visible = false;
            flPanel_TechnicalDepart.Visible = false;
            flPanel_InventoryDepart.Visible = false;
            flowLayoutPanel_Admin.Visible = false;
        }

        // Department
        private void button_AccountingDepart_Click(object sender, EventArgs e)
        {

            if (flPanel_AccountDepart.Visible == true)
            {
                flPanel_AccountDepart.Visible = false;
            }
            else
            {
                HiddenAllModule();
                flPanel_AccountDepart.Visible = true;
            }
        }

        private void button_PurchaseDepart_Click(object sender, EventArgs e)
        {

            if (flPanel_PurchaseDepart.Visible == false)
            {
                HiddenAllModule();
                flPanel_PurchaseDepart.Visible = true;
            }
            else
            {
                flPanel_PurchaseDepart.Visible = false;
            }
        }

        private void button_SalesDepart_Click(object sender, EventArgs e)
        {

            if (flPanel_SalesDepart.Visible == false)
            {
                HiddenAllModule();
                flPanel_SalesDepart.Visible = true;
            }
            else
            {
                flPanel_SalesDepart.Visible = false;
            }
        }

        private void button_TechnicalDepart_Click(object sender, EventArgs e)
        {

            if (flPanel_TechnicalDepart.Visible == false)
            {
                HiddenAllModule();
                flPanel_TechnicalDepart.Visible = true;
            }
            else
            {
                flPanel_TechnicalDepart.Visible = false;
            }
        }

        private void button_InventoryDepart_Click(object sender, EventArgs e)
        {


            switch (position)
            {
                case "Delivery Workman":
                    button_ISMM_Inventory.Visible = false;
                    button_RSMM_Inventory.Visible = false;
                    button_RIM_Inventory.Visible = false;
                    button_AAM_Inventory.Visible = false;

                    button_Inventory_DIM_DeliveryArrangement.Visible = false;
                    button_Inventory_DIM_WorkmenInfoRecord.Visible = false;
                    button_Inventory_DIM_DeliveryWorkmanManagement.Visible = false;
                    break;

                default:

                    break;

            }


            if (flPanel_InventoryDepart.Visible == false)
            {
                HiddenAllModule();
                flPanel_InventoryDepart.Visible = true;
            }
            else
            {
                flPanel_InventoryDepart.Visible = false;
            }
        }

        public void HiddenAllFunction()
        {
            flowLayoutPanel_Account_RIM.Visible = false;
            flowLayoutPanel_Account_ISMM.Visible = false;
            flowLayoutPanel_Account_PMM.Visible = false;
            flowLayoutPanel_Account_AAM.Visible = false;

            flowLayoutPanel_Sales_POS.Visible = false;
            flowLayoutPanel_Sales_AAM.Visible = false;
            flowLayoutPanel_Sales_RIM.Visible = false;
            flowLayoutPanel_Sales_PMM.Visible = false;
            flowLayoutPanel_Sales_RSMM.Visible = false;

            flowLayoutPanel_Purchase_AAM.Visible = false;
            flowLayoutPanel_Purchase_ISMM.Visible = false;
            flowLayoutPanel_Purchase_PMM.Visible = false;

            flowLayoutPanel_Inventory_RSMM.Visible = false;
            flowLayoutPanel_Inventory_DIM.Visible = false;
            flowLayoutPanel_Inventory_AAM.Visible = false;
            flowLayoutPanel_Inventory_RIM.Visible = false;
            flowLayoutPanel_Inventory_ISMM.Visible = false;

            flowLayoutPanel_Technical_AAM.Visible = false;
            flowLayoutPanel_Technical_DIM.Visible = false;

            flowLayoutPanel_Admin.Visible = false;
        }

        //Accounting Module
        private void button_PMM_Accounting_Click(object sender, EventArgs e)
        {
            HiddenAllFunction();
            flowLayoutPanel_Account_PMM.Visible = true;
        }

        private void button_AAM_Accounting_Click(object sender, EventArgs e)
        {
            HiddenAllFunction();
            flowLayoutPanel_Account_AAM.Visible = true;
        }

        private void button_ISMM_Account_Click(object sender, EventArgs e)
        {
            HiddenAllFunction();
            flowLayoutPanel_Account_ISMM.Visible = true;
        }

        private void button_RIM_Account_Click(object sender, EventArgs e)
        {
            HiddenAllFunction();
            flowLayoutPanel_Account_RIM.Visible = true;
        }


        //Purchase Module
        private void button_ISMM_Purchase_Click(object sender, EventArgs e)
        {
            HiddenAllFunction();
            flowLayoutPanel_Purchase_ISMM.Visible = true;
        }

        private void button_AAM_Purchase_Click(object sender, EventArgs e)
        {
            HiddenAllFunction();
            flowLayoutPanel_Purchase_AAM.Visible = true;
        }

        private void button_PMM_Purchase_Click(object sender, EventArgs e)
        {
            HiddenAllFunction();
            flowLayoutPanel_Purchase_PMM.Visible = true;
        }


        //Sales Module
        private void button_PMM_Sales_Click(object sender, EventArgs e)
        {
            HiddenAllFunction();
            flowLayoutPanel_Sales_PMM.Visible = true;
        }

        private void button_AAM_Sales_Click(object sender, EventArgs e)
        {
            HiddenAllFunction();
            flowLayoutPanel_Sales_AAM.Visible = true;

        }

        private void button_RSMM_Sales_Click(object sender, EventArgs e)
        {
            HiddenAllFunction();
            flowLayoutPanel_Sales_RSMM.Visible = true;

        }

        private void button_POSM_Sales_Click(object sender, EventArgs e)
        {
            HiddenAllFunction();
            flowLayoutPanel_Sales_POS.Visible = true;

        }

        private void button_RIM_Sales_Click(object sender, EventArgs e)
        {
            HiddenAllFunction();
            flowLayoutPanel_Sales_RIM.Visible = true;

        }

        //Technical Module
        private void button_AAM_Technical_Click(object sender, EventArgs e)
        {
            HiddenAllFunction();
            flowLayoutPanel_Technical_AAM.Visible = true;
        }

        private void button_DIM_Technical_Click(object sender, EventArgs e)
        {
            HiddenAllFunction();
            flowLayoutPanel_Technical_DIM.Visible = true;

            switch (position)
            {
                case "Installation Workman":
                    button_Technical_DIM_WorkmenInfoRecord.Visible = false;
                    button_Technical_DIM_InstallationWorkmanManagement.Visible = false;
                    button_Technical_DIM_InstallationArrangement.Visible = false;
                    break;

                default:
                    button_Inventory_DIM_DeliveryWorkmanManagement.Visible = true;
                    button_Inventory_DIM_DeliveryArrangement.Visible = true;
                    button_Inventory_DIM_WorkmenInfoRecord.Visible = true;
                    break;
            }

        }


        //Inventory Module
        private void button_DIM_Inventory_Click(object sender, EventArgs e)
        {
            HiddenAllFunction();
            flowLayoutPanel_Inventory_DIM.Visible = true;
        }

        private void button_AAM_Inventory_Click(object sender, EventArgs e)
        {
            HiddenAllFunction();
            flowLayoutPanel_Inventory_AAM.Visible = true;

        }

        private void button_ISMM_Inventory_Click(object sender, EventArgs e)
        {
            HiddenAllFunction();
            flowLayoutPanel_Inventory_ISMM.Visible = true;

        }

        private void button_RSMM_Inventory_Click(object sender, EventArgs e)
        {
            HiddenAllFunction();
            flowLayoutPanel_Inventory_RSMM.Visible = true;
        }

        private void button_RIM_Inventory_Click(object sender, EventArgs e)
        {
            HiddenAllFunction();
            flowLayoutPanel_Inventory_RIM.Visible = true;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            checkPermission(staffID);
            HiddenAllButton();
            HiddenAllModule();
            HiddenAllFunction();
            switch (department)
            {
                case "Accounting":
                    button_AccountingDepart.Visible = true;
                    break;

                case "Purchase":
                    button_PurchaseDepart.Visible = true;
                    break;

                case "Sales":
                    button_SalesDepart.Visible = true;
                    break;

                case "Technical Support":
                    button_TechnicalDepart.Visible = true;
                    break;

                case "Inventory":
                    button_InventoryDepart.Visible = true;
                    break;

                case "Technical Support Clerk":
                    button_TechnicalDepart.Visible = true;
                    break;
                default:
                    button_AccountingDepart.Visible = true;
                    button_PurchaseDepart.Visible = true;
                    button_SalesDepart.Visible = true;
                    button_TechnicalDepart.Visible = true;
                    button_InventoryDepart.Visible = true;
                    btnAdmin.Visible = true;
                    break;
            }
        }

        public void checkPermission(string staffID)
        {
            openConnection();
            command = new MySqlCommand("SELECT StaffID, StaffName,Position,Depart, storeID FROM staff WHERE StaffID=@staffID;", conn);
            command.Parameters.AddWithValue("staffID", staffID);
            MySqlDataReader reader;
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                department = reader["Depart"].ToString();
                position = reader["Position"].ToString();
                if (reader["storeID"].ToString() == "1" || reader["storeID"].ToString() == "2")
                {
                    storeID = Int32.Parse(reader["storeID"].ToString());
                }

                if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                {
                    Label_UserDepartment.Text = department;
                    Label_UserPosition.Text = position;
                    switch (department)
                    {
                        case "Accounting":
                            button_AccountingDepart.Visible = true;
                            break;
                        case "Purchase":
                            button_PurchaseDepart.Visible = true;
                            break;
                        case "Sales":
                            button_SalesDepart.Visible = true;
                            break;
                        case "Technical Support":
                            button_TechnicalDepart.Visible = true;
                            break;
                        case "Inventory":
                            button_InventoryDepart.Visible = true;
                            break;
                        default:
                            button_AccountingDepart.Visible = true;
                            button_PurchaseDepart.Visible = true;
                            button_SalesDepart.Visible = true;
                            button_TechnicalDepart.Visible = true;
                            button_InventoryDepart.Visible = true;
                            btnAdmin.Visible = true;
                            break;
                    }
                }
                else
                {
                    switch (department) {
                        case "CEO":
                            Label_UserDepartment.Text = Properties.Settings.Default.CEOZh;
                            button_AccountingDepart.Visible = true;
                            button_PurchaseDepart.Visible = true;
                            button_SalesDepart.Visible = true;
                            button_TechnicalDepart.Visible = true;
                            button_InventoryDepart.Visible = true;
                            btnAdmin.Visible = true;
                            break;
                        case "Admin":
                            Label_UserDepartment.Text = Properties.Settings.Default.AdminZh;
                            button_AccountingDepart.Visible = true;
                            button_PurchaseDepart.Visible = true;
                            button_SalesDepart.Visible = true;
                            button_TechnicalDepart.Visible = true;
                            button_InventoryDepart.Visible = true;
                            btnAdmin.Visible = true;
                            break;
                        case "Accounting":
                            Label_UserDepartment.Text = Properties.Settings.Default.AccountZh;
                            button_AccountingDepart.Visible = true;
                            break;
                        case "Inventory":
                            Label_UserDepartment.Text = Properties.Settings.Default.InventoryZh;
                            button_InventoryDepart.Visible = true;
                            break;
                        case "Purchase":
                            Label_UserDepartment.Text = Properties.Settings.Default.PurchaseZh;
                            button_PurchaseDepart.Visible = true;
                            break;
                        case "Sales":
                            Label_UserDepartment.Text = Properties.Settings.Default.SalesDZh;
                            button_SalesDepart.Visible = true;
                            break;
                        case "Technical Support":
                            Label_UserDepartment.Text = Properties.Settings.Default.TSZh;
                            button_TechnicalDepart.Visible = true;
                            break;

                    }
                    switch (position)
                    {
                        case "CEO":
                            Label_UserPosition.Text = Properties.Settings.Default.CEOZh;
                            button_AccountingDepart.Visible = true;
                            button_PurchaseDepart.Visible = true;
                            button_SalesDepart.Visible = true;
                            button_TechnicalDepart.Visible = true;
                            button_InventoryDepart.Visible = true;
                            btnAdmin.Visible = true;
                            break;
                        case "Admin":
                            Label_UserPosition.Text = Properties.Settings.Default.AdminZh;
                            button_AccountingDepart.Visible = true;
                            button_PurchaseDepart.Visible = true;
                            button_SalesDepart.Visible = true;
                            button_TechnicalDepart.Visible = true;
                            button_InventoryDepart.Visible = true;
                            btnAdmin.Visible = true;
                            break;
                        case "Accounting Clerk":
                            Label_UserPosition.Text = Properties.Settings.Default.ACZh;
                            break;
                        case "Accounting Manager":
                            Label_UserPosition.Text = Properties.Settings.Default.AMZh;
                            break;
                        case "Goods Inwards Clerk":
                            Label_UserPosition.Text = Properties.Settings.Default.GICZh;
                            break;
                        case "Inventory Clerk":
                            Label_UserPosition.Text = Properties.Settings.Default.ICZh;
                            break;
                        case "Delivery Workman":
                            Label_UserPosition.Text = Properties.Settings.Default.DelZh;
                            break;
                        case "Inventory Manager":
                            Label_UserPosition.Text = Properties.Settings.Default.IMZh;
                            break;
                        case "Purchase Manager":
                            Label_UserPosition.Text = Properties.Settings.Default.PMZh;
                            break;
                        case "Purchase Officer":
                            Label_UserPosition.Text = Properties.Settings.Default.POZh;
                            break;
                        case "Sales Representative":
                            Label_UserPosition.Text = Properties.Settings.Default.SRZh;
                            break;
                        case "Sales Manager":
                            Label_UserPosition.Text = Properties.Settings.Default.SMZh;
                            break;
                        case "Installation Workman":
                            Label_UserPosition.Text = Properties.Settings.Default.IMZh;
                            break;
                    }
                }
                
                Label_UserName.Text = reader["StaffName"].ToString();
                Label_UserID.Text = reader["StaffID"].ToString();
            }
            else
            {
                MessageBox.Show("Dedug: code in MenuForm.cs, Error : Staff Not Data Found");
            }
            closeConnection();
        }

        public void addReOrderItem(string itemID, string itemName)
        {
            ReOrderRequestForm rorform = new ReOrderRequestForm();
            rorform.setStaffID = getStaffID;
            rorform.setDepartment = getDepartment;
            rorform.setPosition = getPosition;
            rorform.addReOrderItem(itemID, itemName);
            loadform(rorform);
        }

        public void addPurchaseOrder(string orderID)
        {
            PurchaseOrderForm poform = new PurchaseOrderForm();
            poform.setStaffID = getStaffID;
            poform.setDepartment = getDepartment;
            poform.setPosition = getPosition;
            poform.addPurchaseOrder(orderID);
            loadform(poform);
        }

        public void createRestock()
        {
            CreateRestockRequestForm crrform = new CreateRestockRequestForm();
            crrform.setStaffID = getStaffID;
            crrform.setDepartment = getDepartment;
            crrform.setPosition = getPosition;
            loadform(crrform);
        }

        public void addReStockItem(string itemID, string itemName, string supplierID, string storeID)
        {
            CreateRestockRequestForm crrform = new CreateRestockRequestForm();
            crrform.addReStockItem(itemID, itemName, supplierID, storeID);
            crrform.setStaffID = getStaffID;
            crrform.setDepartment = getDepartment;
            crrform.setPosition = getPosition;
            loadform(crrform);
        }

        public void goodsReceivedNoteRecord()
        {
            GoodsReceivedNoteRecord grnrform = new GoodsReceivedNoteRecord();
            grnrform.setStaffID = getStaffID;
            grnrform.setDepartment = getDepartment;
            grnrform.setPosition = getPosition;
            loadform(grnrform);
        }

        private void button_LogOut_Click(object sender, EventArgs e)
        {
            LoginForm menuform = new LoginForm();
            this.Hide();
            menuform.Show();
        }

        private void button_Sales_PMM_SalesItemList_Click(object sender, EventArgs e)
        {
            ItemList itemlist = new ItemList();
            itemlist.setStaffID = getStaffID;
            itemlist.setDepartment = getDepartment;
            itemlist.setPosition = getPosition;
            loadform(itemlist);
        }

        private void button_Inventory_DIM_DeliveryArrangement_Click(object sender, EventArgs e)
        {
            loadform(new DeliveryForm());
            DeliveryForm deliveryform = new DeliveryForm();
            deliveryform.setStaffID = getStaffID;
            deliveryform.setDepartment = getDepartment;
            deliveryform.setPosition = getPosition;
            loadform(deliveryform);
        }

        private void button_Technical_DIM_InstallationArrangement_Click(object sender, EventArgs e)
        {
            InstallationForm installationform = new InstallationForm();
            installationform.setStaffID = getStaffID;
            installationform.setDepartment = getDepartment;
            installationform.setPosition = getPosition;
            loadform(installationform);
        }

        private void button_Technical_DIM_dailyInstallation_Click(object sender, EventArgs e)
        {
            dailyInstallationForm dailyInstallationform = new dailyInstallationForm();
            dailyInstallationform.setStaffID = getStaffID;
            dailyInstallationform.setDepartment = getDepartment;
            dailyInstallationform.setPosition = getPosition;
            loadform(dailyInstallationform);

        }

        private void button_Purchase_ISMM_ReorderRequest_Click(object sender, EventArgs e)
        {
            ReOrderRequestForm rorform = new ReOrderRequestForm();
            rorform.setStaffID = getStaffID;
            rorform.setDepartment = getDepartment;
            rorform.setPosition = getPosition;
            loadform(rorform);
        }

        private void button_Inventory_RSMM_RetailStockLevel_Click(object sender, EventArgs e)
        {
            RetailStockLevelForm rslform = new RetailStockLevelForm();
            rslform.setStaffID = getStaffID;
            rslform.setDepartment = getDepartment;
            rslform.setPosition = getPosition;
            loadform(rslform);
        }

        private void button_Sales_RSMM_ReRestockRequest_Click(object sender, EventArgs e)
        {
            RestockRequestRecord rsrrform = new RestockRequestRecord();
            rsrrform.setStaffID = getStaffID;
            rsrrform.setDepartment = getDepartment;
            rsrrform.setPosition = getPosition;
            loadform(rsrrform);
        }

        private void button_Inventory_ISMM_InventoryStorckLevel_Click(object sender, EventArgs e)
        {
            InventoryStockLevelForm islfrm = new InventoryStockLevelForm();
            islfrm.setStaffID = getStaffID;
            islfrm.setDepartment = getDepartment;
            islfrm.setPosition = getPosition;
            loadform(islfrm);
        }

        private void button_Sales_RSMM_SalesItemList_Click(object sender, EventArgs e)
        {
            ItemList itemlist = new ItemList();
            itemlist.setStaffID = getStaffID;
            itemlist.setDepartment = getDepartment;
            itemlist.setPosition = getPosition;
            loadform(itemlist);
        }

        private void button_Sales_RSMM_InventoryStockLevel_Click(object sender, EventArgs e)
        {
            InventoryStockLevelForm islfrm = new InventoryStockLevelForm();
            islfrm.setStaffID = getStaffID;
            islfrm.setDepartment = getDepartment;
            islfrm.setPosition = getPosition;
            loadform(islfrm);
        }

        private void button_Function_Account__PMM_ItemList_Click(object sender, EventArgs e)
        {
            ItemList itemlist = new ItemList();
            itemlist.setStaffID = getStaffID;
            itemlist.setDepartment = getDepartment;
            itemlist.setPosition = getPosition;
            loadform(itemlist);
        }

        private void button_Purchase_PMM_PurchaseItemList_Click(object sender, EventArgs e)
        {
            ItemList itemlist = new ItemList();
            itemlist.setStaffID = getStaffID;
            itemlist.setDepartment = getDepartment;
            itemlist.setPosition = getPosition;
            loadform(itemlist);
        }

        private void btnSalesOrder_Click(object sender, EventArgs e)
        {
            SalesOrder soform = new SalesOrder();
            soform.setStaffID = getStaffID;
            soform.setDepartment = getDepartment;
            soform.setPosition = getPosition;
            loadform(soform);
        }

        private void btnDailyDelivery_Click(object sender, EventArgs e)
        {
            dailyDelivery dailydeliveryform = new dailyDelivery();
            dailydeliveryform.setStaffID = getStaffID;
            dailydeliveryform.setDepartment = getDepartment;
            dailydeliveryform.setPosition = getPosition;
            loadform(dailydeliveryform);
        }


        private void button_Sales_RSMM_SalesStorckLevel_Click(object sender, EventArgs e)
        {
            RetailStockLevelForm rslform = new RetailStockLevelForm();
            rslform.setStaffID = getStaffID;
            rslform.setDepartment = getDepartment;
            rslform.setPosition = getPosition;
            loadform(rslform);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel_Admin.Visible == false)
            {
                HiddenAllFunction();
                HiddenAllModule();
                flowLayoutPanel_Admin.Visible = true;
            }
            //else
            //{
            //    flowLayoutPanel_Admin.Visible = false;
            //}
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            AccountManagementForm amform = new AccountManagementForm();
            amform.setStaffID = getStaffID;
            amform.setDepartment = getDepartment;
            amform.setPosition = getPosition;
            loadform(amform);
        }

        private void button_Sales_posMod_POS_Click(object sender, EventArgs e)
        {
            frmPOS pos = new frmPOS();
            pos.StaffID = getStaffID;
            pos.StoreID = getStoreID;
            loadform(pos);
        }

        private void button__Sales_PMM_SupplierList_Click(object sender, EventArgs e)
        {
            SupplierList slform = new SupplierList();
            slform.setStaffID = getStaffID;
            slform.setDepartment = getDepartment;
            slform.setPosition = getPosition;
            loadform(slform);
        }

        private void button_Inventory_ISMM_SupplierList_Click(object sender, EventArgs e)
        {
            SupplierList slform = new SupplierList();
            slform.setStaffID = getStaffID;
            slform.setDepartment = getDepartment;
            slform.setPosition = getPosition;
            loadform(slform);
        }

        private void button_Purchase_PMM_SupplierList_Click(object sender, EventArgs e)
        {
            SupplierList slform = new SupplierList();
            slform.setStaffID = getStaffID;
            slform.setDepartment = getDepartment;
            slform.setPosition = getPosition;
            loadform(slform);
        }

        private void button_Account__AAM_SupplierList_Click(object sender, EventArgs e)
        {
            SupplierList slform = new SupplierList();
            slform.setStaffID = getStaffID;
            slform.setDepartment = getDepartment;
            slform.setPosition = getPosition;
            loadform(slform);
        }

        private void button_Inventory_DIM_WorkmenInfoRecord_Click(object sender, EventArgs e)
        {
            ViewDeliveryWorkmanForm vdwform = new ViewDeliveryWorkmanForm();
            loadform(vdwform);
        }

        private void button_Inventory_DIM_DeliveryWorkmanManagement_Click(object sender, EventArgs e)
        {
            DeliveryWorkerForm dwform = new DeliveryWorkerForm();
            loadform(dwform);
        }

        private void button_Technical_DIM_WorkmenInfoRecord_Click(object sender, EventArgs e)
        {
            ViewInstallationWorkmanForm viwform = new ViewInstallationWorkmanForm();
            loadform(viwform);
        }

        private void button_Technical_DIM_InstallationWorkmanManagement_Click(object sender, EventArgs e)
        {
            InstallationWorkerForm iwform = new InstallationWorkerForm();
            loadform(iwform);
        }

        private void btnStaffList_Click(object sender, EventArgs e)
        {
            ViewStaffForm iwform = new ViewStaffForm();
            loadform(iwform);
        }

        private void button_Function_Account__PMM_SupplierList_Click(object sender, EventArgs e)
        {
            SupplierList slform = new SupplierList();
            slform.setStaffID = getStaffID;
            slform.setDepartment = getDepartment;
            slform.setPosition = getPosition;
            loadform(slform);
        }

        private void button_Inventory_ISMM_GoodsReceivedNote_Click(object sender, EventArgs e)
        {
            GoodsReceivedNoteRecord grnrform = new GoodsReceivedNoteRecord();
            grnrform.setStaffID = getStaffID;
            grnrform.setDepartment = getDepartment;
            grnrform.setPosition = getPosition;
            loadform(grnrform);
        }

        private void button_Purchase_ISMM_GoodsReceivedNote_Click(object sender, EventArgs e)
        {
            GoodsReceivedNoteRecord grnrform = new GoodsReceivedNoteRecord();
            grnrform.setStaffID = getStaffID;
            grnrform.setDepartment = getDepartment;
            grnrform.setPosition = getPosition;
            loadform(grnrform);
        }

        private void button_Account__AAM_GoodsReceivedNote_Click(object sender, EventArgs e)
        {
            GoodsReceivedNoteRecord grnrform = new GoodsReceivedNoteRecord();
            grnrform.setStaffID = getStaffID;
            grnrform.setDepartment = getDepartment;
            grnrform.setPosition = getPosition;
            loadform(grnrform);
        }

        private void button_Account__AAM_SalesOrder_Click(object sender, EventArgs e)
        {
            SalesOrder soform = new SalesOrder();
            soform.setStaffID = getStaffID;
            soform.setDepartment = getDepartment;
            soform.setPosition = getPosition;
            loadform(soform);
        }

        private void button_Account__AAM_ItemList_Click(object sender, EventArgs e)
        {
            ItemList itemlist = new ItemList();
            itemlist.setStaffID = getStaffID;
            itemlist.setDepartment = getDepartment;
            itemlist.setPosition = getPosition;
            loadform(itemlist);
        }

        private void button_Account__AAM_GoodsReturnedNote_Click(object sender, EventArgs e)
        {
            ReturnNoteForm rnform = new ReturnNoteForm();
            rnform.setStaffID = getStaffID;
            rnform.setDepartment = getDepartment;
            rnform.setPosition = getPosition;
            loadform(rnform);
        }

        private void button_Account_ISMM_GoodsReceivedNote_Click(object sender, EventArgs e)
        {
            GoodsReceivedNoteRecord grnrform = new GoodsReceivedNoteRecord();
            grnrform.setStaffID = getStaffID;
            grnrform.setDepartment = getDepartment;
            grnrform.setPosition = getPosition;
            loadform(grnrform);
        }

        private void button_Inventory_RIM_GoodsReturnedRecord_Click(object sender, EventArgs e)
        {
            ReturnNoteForm rnform = new ReturnNoteForm();
            rnform.setStaffID = getStaffID;
            rnform.setDepartment = getDepartment;
            rnform.setPosition = getPosition;
            loadform(rnform);
        }

        private void button_Account__RIM_GoodsReturnedRecord_Click(object sender, EventArgs e)
        {
            ReturnNoteForm rnform = new ReturnNoteForm();
            rnform.setStaffID = getStaffID;
            rnform.setDepartment = getDepartment;
            rnform.setPosition = getPosition;
            loadform(rnform);
        }

        private void button_Function_Sales_RIM_GoodsReturnedRecord_Click(object sender, EventArgs e)
        {
            ReturnNoteForm rnform = new ReturnNoteForm();
            rnform.setStaffID = getStaffID;
            rnform.setDepartment = getDepartment;
            rnform.setPosition = getPosition;
            loadform(rnform);
        }

        private void button_Account__AAM_PurchaseOrder_Click(object sender, EventArgs e)
        {
            PurchaseOrderForm poform = new PurchaseOrderForm();
            poform.setStaffID = getStaffID;
            poform.setDepartment = getDepartment;
            poform.setPosition = getPosition;
            loadform(poform);
        }

        private void button_Account_ISMM_PurchaseOrder_Click(object sender, EventArgs e)
        {
            PurchaseOrderForm poform = new PurchaseOrderForm();
            poform.setStaffID = getStaffID;
            poform.setDepartment = getDepartment;
            poform.setPosition = getPosition;
            loadform(poform);
        }

        private void button_Purchase_ISMM_PurchaseOrder_Click(object sender, EventArgs e)
        {
            PurchaseOrderForm poform = new PurchaseOrderForm();
            poform.setStaffID = getStaffID;
            poform.setDepartment = getDepartment;
            poform.setPosition = getPosition;
            loadform(poform);
        }

        private void button_Inventory_ISMM_PurchaseOrder_Click(object sender, EventArgs e)
        {
            PurchaseOrderForm poform = new PurchaseOrderForm();
            poform.setStaffID = getStaffID;
            poform.setDepartment = getDepartment;
            poform.setPosition = getPosition;
            loadform(poform);
        }

        public void button_Inventory_ISMM_ReorderRequest_Click(object sender, EventArgs e)
        {
            ReOrderRequestForm rorform = new ReOrderRequestForm();
            rorform.setStaffID = getStaffID;
            rorform.setDepartment = getDepartment;
            rorform.setPosition = getPosition;
            loadform(rorform);
        }

        private void button_Language_Click(object sender, EventArgs e)
        {
            if (panel_Language.Visible)
            {
                panel_Language.Visible = false;
            }
            else
            {
                panel_Language.Visible = true;
            }
        }

        

        private void button_Purchase_ISMM_PurchaseInvoice_Click(object sender, EventArgs e)
        {
            PurchaseInvoiceForm poiform = new PurchaseInvoiceForm();
            poiform.setStaffID = getStaffID;
            poiform.setDepartment = getDepartment;
            poiform.setPosition = getPosition;
            loadform(poiform);
        }

        private void button_Account__AAM_PurchaseInvoice_Click(object sender, EventArgs e)
        {
            PurchaseInvoiceForm poiform = new PurchaseInvoiceForm();
            poiform.setStaffID = getStaffID;
            poiform.setDepartment = getDepartment;
            poiform.setPosition = getPosition;
            loadform(poiform);
        }

        private void button_Account_ISMM_PurchaseInvoice_Click(object sender, EventArgs e)
        {
            PurchaseInvoiceForm poiform = new PurchaseInvoiceForm();
            poiform.setStaffID = getStaffID;
            poiform.setDepartment = getDepartment;
            poiform.setPosition = getPosition;
            loadform(poiform);
        }

        private void button_Account__AAM_AnalysisReport_Click(object sender, EventArgs e)
        {
            AnalysisReportForm arform = new AnalysisReportForm();
            arform.setStaffID = getStaffID;
            arform.setDepartment = getDepartment;
            arform.setPosition = getPosition;
            loadform(arform);
        }

        private void button_Inventory_AAM_AnalysisReport_Click(object sender, EventArgs e)
        {
            AnalysisReportForm arform = new AnalysisReportForm();
            arform.setStaffID = getStaffID;
            arform.setDepartment = getDepartment;
            arform.setPosition = getPosition;
            loadform(arform);
        }

        private void button_Function_Sales_AAM_AnalysisReport_Click(object sender, EventArgs e)
        {
            AnalysisReportForm arform = new AnalysisReportForm();
            arform.setStaffID = getStaffID;
            arform.setDepartment = getDepartment;
            arform.setPosition = getPosition;
            loadform(arform);
        }

        private void button_Purchase_AAM_AnalysisReport_Click(object sender, EventArgs e)
        {
            AnalysisReportForm arform = new AnalysisReportForm();
            arform.setStaffID = getStaffID;
            arform.setDepartment = getDepartment;
            arform.setPosition = getPosition;
            loadform(arform);
        }

        private void button_en_Click_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            this.Controls.Clear();
            InitializeComponent();
            HiddenAllModule();
            HiddenAllButton();
            HiddenAllFunction();
            checkPermission(staffID);
        }



        private void button_zh_Click_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("zh");
            this.Controls.Clear();
            InitializeComponent();
            HiddenAllModule();
            HiddenAllButton();
            HiddenAllFunction();
            checkPermission(staffID);
        }
    }
}

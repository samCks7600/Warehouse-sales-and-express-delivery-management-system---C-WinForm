using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterLimited
{
    public partial class UpdateRetailLowLevelQty : Form
    {
        // Setting for MySql Database.
        MySqlConnection conn = new MySqlConnection("server=localhost;user id =root;password=;database=betterlimited");
        MySqlCommand command;
        string itemID, storeID;
        private RetailStockLevelForm _rslfrm;

        public string setItemID
        {
            set
            {
                txtItemID.Text = value;
                itemID = txtItemID.Text;
            }
        }

        public string getItemID
        {
            get
            {
                return itemID;
            }
        }
        public string setStoreID
        {
            set
            {

                storeID = value;
                if (storeID == "1")
                {
                    if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                    {
                        txtStore.Text = "Tsuen Wan";
                    }
                    else
                    {
                        txtStore.Text = Properties.Settings.Default.TWZh;
                    }
                }
                else
                {
                    if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                    {
                        txtStore.Text = "Kowloon Bay";
                    }
                    else
                    {
                        txtStore.Text = Properties.Settings.Default.KLBZh;
                    }
                }
            }
        }

        public string getStoreName
        {
            get
            {
                return storeID;
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

        public UpdateRetailLowLevelQty(RetailStockLevelForm rslfrm)
        {
            InitializeComponent();
            _rslfrm = rslfrm;
            this.ActiveControl = txtLowLevelQty;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql;
            try
            {
                openConnection();
                sql = "UPDATE retailstocklevel SET LowLevelQty = '" + txtLowLevelQty.Text + "' WHERE storeID = '" + storeID + "' AND itemID = '" + txtItemID.Text + "';";
                command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
                if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                {
                    MessageBox.Show("Update Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(Properties.Settings.Default.UpdateSucZh, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                {
                    MessageBox.Show("Update Unsuccessful.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(Properties.Settings.Default.UpdateUnsucZh + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            closeConnection();
            this.Close();
            sql = "SELECT rsl.itemID, i.itemName, rsl.Quantity, rsl.LowLevelQty FROM retailstocklevel rsl, item i WHERE rsl.itemID = i.itemID AND storeID = " + storeID;
            _rslfrm.showData(sql);
        }

        private void UpdateRetailLowLevelQty_Load(object sender, EventArgs e)
        {
            try
            {
                openConnection();
                string sql = "SELECT storeName,  rsl.itemID, i.itemName, Quantity, LowLevelQty FROM store, retailstocklevel rsl, item i WHERE rsl.itemID = i.itemID AND rsl.itemID = '" + txtItemID.Text + "' AND store.storeID = rsl.storeID;";
                command = new MySqlCommand(sql, conn);
                MySqlDataReader reader;
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    txtStore.Text = reader["storeName"].ToString();
                    txtItemName.Text = reader["ItemName"].ToString();
                    txtQuantity.Text = reader["Quantity"].ToString();
                    txtLowLevelQty.Text = reader["LowLevelQty"].ToString();
                    closeConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                closeConnection();
            }
        }

        private void txtLowLevelQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == Convert.ToChar(8)) //represents a backspace
            {
                e.Handled = false; //Accept the input.
                lblWarning.Text = "";
            }
            else
            {
                e.Handled = true; //Reject the input.
                if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                {
                    lblWarning.Text = "Low level quantity should be numeric";
                }
                else
                {
                    lblWarning.Text = Properties.Settings.Default.LowLevelQtyZh;
                }
            }
        }
    }
}

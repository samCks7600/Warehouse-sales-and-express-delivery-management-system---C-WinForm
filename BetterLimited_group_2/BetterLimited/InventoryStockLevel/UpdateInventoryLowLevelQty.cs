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
    public partial class UpdateInventoryLowLevelQty : Form
    {
        // Setting for MySql Database.
        MySqlConnection conn = new MySqlConnection("server=localhost;user id =root;password=;database=betterlimited");
        MySqlCommand command;
        string itemID;
        private InventoryStockLevelForm _islfrm;

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

        public UpdateInventoryLowLevelQty(InventoryStockLevelForm islfrm)
        {
            InitializeComponent();
            _islfrm = islfrm;
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
                sql = "UPDATE inventorystocklevel SET LowLevelQty = '" + txtLowLevelQty.Text + "' WHERE itemID = '" + txtItemID.Text + "';";
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
            sql = "SELECT isl.ItemID, i.ItemName, isl.Quantity, isl.LowLevelQty FROM inventorystocklevel isl, item i WHERE isl.itemID = i.itemID";
            _islfrm.showData(sql);
        }

        private void UpdateInventoryLowLevelQty_Load(object sender, EventArgs e)
        {
            try
            {
                openConnection();
                string sql = "SELECT isl.ItemID, i.ItemName, isl.Quantity, isl.LowLevelQty FROM inventorystocklevel isl, item i WHERE isl.itemID = i.itemID AND i.itemID = '" + txtItemID.Text + "';";
                command = new MySqlCommand(sql, conn);
                MySqlDataReader reader;
                reader = command.ExecuteReader();
                if (reader.Read())
                {
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
                lblWarning.Text = "Low level quantity should be numeric";

            }
        }
    }
}

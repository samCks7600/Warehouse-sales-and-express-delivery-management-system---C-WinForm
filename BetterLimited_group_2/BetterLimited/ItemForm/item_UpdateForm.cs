using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterLimited.ItemForm
{
    public partial class item_UpdateForm : Form
    {
        //Database 
        static string conString = "Server=localhost; Database=betterlimited; user id=root; Password=;";
        MySqlConnection con = new MySqlConnection(conString);
        MySqlCommand cmd;
        string ItemID;
        string SupplierID;
        private ItemList _itemListfrm;

        public void openConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void closeConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        //get set Supplier ID
        public string setItemID
        {
            set
            {
                ItemID = value;
            }
        }
        public string getItemID
        {
            get
            {
                return ItemID;
            }
        }

        //get set Supplier ID
        public string setSupplierID
        {
            set
            {
                SupplierID = value;
            }
        }
        public string getSupplierID
        {
            get
            {
                return SupplierID;
            }
        }

        public item_UpdateForm(ItemList itemListfrm)
        {
            InitializeComponent();
            _itemListfrm = itemListfrm;
        }


        private void item_UpdateForm_Load(object sender, EventArgs e)
        {
            cmd = new MySqlCommand("SELECT * FROM item WHERE itemID= " + getItemID + ";", con);
            pictureBox.Image = Properties.Resources.DefaultPicture;

            openConnection();
            MySqlDataReader reader = cmd.ExecuteReader();


            if (reader.Read())
            {
                txtItemID.Text = reader["ItemID"].ToString();
                txtCat.Text = reader["ItemCat"].ToString();
                txtName.Text = reader["ItemName"].ToString();
                txtDesc.Text = reader["ItemDesc"].ToString();
                byte[] byteBLOBData = (byte[])reader["ItemImg"];
                pictureBox.Image = ToImage(byteBLOBData);
                txtSalesPrice.Text = reader["SalePrice"].ToString();
                comboBox_SupplierID.Text = reader["SupplierID"].ToString();
                txtSupplierPrice.Text = reader["SupplierPrice"].ToString();
                txtWm.Text = reader["WarrantyMonth"].ToString();
                comboBox_allowDly.Text = reader["AllowDelivery"].ToString();

            }
            closeConnection();

            comboBox_allowDly.Items.Add("True");
            comboBox_allowDly.Items.Add("False");


            try
            {
                openConnection();
                string sql = "SELECT SupplierID FROM supplier;";
                cmd = new MySqlCommand(sql, con);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string supplierID = reader["SupplierID"].ToString();
                    comboBox_SupplierID.ValueMember = supplierID;
                    comboBox_SupplierID.Items.Add(supplierID);
                }


                closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public static Image ToImage(byte[] data)
        {
            if (data == null)
            {
                return null;
            }
            Image img;
            using (MemoryStream stream = new MemoryStream(data))
            {
                using (Image temp = Image.FromStream(stream))
                {
                    img = new Bitmap(temp);
                }
            }
            return img;
        }

        //Update
        private void UpdateItem(Item item, string id)
        {
            string sql = "UPDATE item SET ItemCat = @ItemCat, " +
                         "ItemName = @ItemName, " +
                        "ItemDesc = @ItemDesc, " +
                        "ItemImg = @ItemImg, " +
                        "SalePrice = @ItemSalePrice," +
                        " SupplierID = @ItemSID, " +
                        "SupplierPrice = @ItemSupplierPrice, " +
                        "WarrantyMonth = @ItemWarrantyMonth,  " +
                        "AllowDelivery = @AllowDelivery " +
                        "WHERE ItemID = @ItemID; ";
            openConnection();
            cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ItemID", MySqlDbType.VarChar).Value = item.ID;
            cmd.Parameters.Add("@ItemCat", MySqlDbType.VarChar).Value = item.Cat;
            cmd.Parameters.Add("@ItemName", MySqlDbType.VarChar).Value = item.Name;
            cmd.Parameters.Add("@ItemDesc", MySqlDbType.VarChar).Value = item.Desc;
            cmd.Parameters.Add("@ItemImg", MySqlDbType.Blob).Value = item.Img;
            cmd.Parameters.Add("@ItemSalePrice", MySqlDbType.VarChar).Value = item.SalePrice;
            cmd.Parameters.Add("@ItemSID", MySqlDbType.VarChar).Value = item.SID;
            cmd.Parameters.Add("@ItemSupplierPrice", MySqlDbType.VarChar).Value = item.SPrice;
            cmd.Parameters.Add("@ItemWarrantyMonth", MySqlDbType.VarChar).Value = item.WarrantyMonth;
            cmd.Parameters.Add("@AllowDelivery", MySqlDbType.VarChar).Value = item.AllowDelivery;
            try
            {
                cmd.ExecuteNonQuery();
                if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                {
                    MessageBox.Show("Update Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(Properties.Settings.Default.UpdateSucZh, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
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
        }

        //Cancel button
        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void txtSalesPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                {
                    label_SalesPrice.Text = "Please Enter Numerically.";
                }
                else
                {
                    label_SalesPrice.Text = Properties.Settings.Default.label_SalesPriceZh;
                }
            }
        }

        private void txtWm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                {
                    label_WM.Text = "Please Enter Numerically.";
                }
                else
                {
                    label_WM.Text = Properties.Settings.Default.label_SalesPriceZh;
                }
            }
        }



        private void txtSupplierPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                {
                    label_SuPrice.Text = "Please Enter Numerically.";
                }
                else
                {
                    label_SuPrice.Text = Properties.Settings.Default.label_SalesPriceZh;
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif)";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(opf.FileName);
            }
        }

        //Clear button
        private void button_clear_Click(object sender, EventArgs e)
        {
            cmd = new MySqlCommand("SELECT * FROM item WHERE itemID= " + getItemID + ";", con);
            pictureBox.Image = Properties.Resources.DefaultPicture;
            label_Cat.Text = label_Des.Text = label_Name.Text = label_SalesPrice.Text = label_SuPrice.Text = label_WM.Text = "";
            openConnection();
            MySqlDataReader reader = cmd.ExecuteReader();


            if (reader.Read())
            {
                txtItemID.Text = reader["ItemID"].ToString();
                txtCat.Text = reader["ItemCat"].ToString();
                txtName.Text = reader["ItemName"].ToString();
                txtDesc.Text = reader["ItemDesc"].ToString();
                byte[] byteBLOBData = (byte[])reader["ItemImg"];
                pictureBox.Image = ToImage(byteBLOBData);
                txtSalesPrice.Text = reader["SalePrice"].ToString();
                comboBox_SupplierID.Text = reader["SupplierID"].ToString();
                txtSupplierPrice.Text = reader["SupplierPrice"].ToString();
                txtWm.Text = reader["WarrantyMonth"].ToString();
                comboBox_allowDly.Text = reader["AllowDelivery"].ToString();

            }
            closeConnection();
        }


        //Update button
        private void button_update_Click(object sender, EventArgs e)
        {
            if (txtCat.Text.Trim().Length < 1 ||
               txtName.Text.Trim().Length < 1 ||
               txtDesc.Text.Trim().Length < 1 ||
               txtSalesPrice.Text.Trim().Length < 1 ||
               txtSupplierPrice.Text.Trim().Length < 1 ||
               txtWm.Text.Trim().Length < 1
               // comboBox_SupplierID.SelectedItem == null
               )
            {
                if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                {
                    MessageBox.Show("All information should be filled \n (besides item image)");
                }
                else
                {
                    MessageBox.Show(Properties.Settings.Default.MsgBoxFillZh);
                }
                label_Cat.Text = label_Des.Text = label_Name.Text = label_SalesPrice.Text = label_SuPrice.Text = label_WM.Text = "";


                if (txtName.Text.Trim().Length < 1)
                {
                    if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                    {
                        label_Name.Text = "Please Enter Item Name";
                    }
                    else
                    {
                        label_Name.Text = Properties.Settings.Default.ItemNameZh;
                    }
                }
                else
                {
                    label_Name.Text = "";
                }

                if (txtCat.Text.Trim().Length < 1)
                {
                    if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                    {
                        label_Cat.Text = "Please Enter Category";
                    }
                    else
                    {
                        label_Cat.Text = Properties.Settings.Default.CategoryZh;
                    }
                }
                else
                {
                    label_Cat.Text = "";
                }

                if (txtDesc.Text.Trim().Length < 1)
                {
                    if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                    {
                        label_Des.Text = "Please Enter Description";
                    }
                    else
                    {
                        label_Des.Text = Properties.Settings.Default.DescZh;
                    }
                }
                else
                {
                    label_Des.Text = "";
                }

                if (txtSalesPrice.Text.Trim().Length < 1)
                {
                    if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                    {
                        label_SalesPrice.Text = "Please Enter Sales Price";
                    }
                    else
                    {
                        label_SalesPrice.Text = Properties.Settings.Default.SaleZh;
                    }
                }
                else
                {
                    label_SalesPrice.Text = "";
                }

                if (txtSupplierPrice.Text.Trim().Length < 1)
                {
                    if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                    {
                        label_SuPrice.Text = "Please Enter Supplier Price";
                    }
                    else
                    {
                        label_SuPrice.Text = Properties.Settings.Default.SupZh;
                    }
                }
                else
                {
                    label_SuPrice.Text = "";
                }


                if (txtWm.Text.Trim().Length < 1)
                {
                    if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                    {
                        label_WM.Text = "Please Enter Supplier Price";
                    }
                    else
                    {
                        label_WM.Text = Properties.Settings.Default.WarZh;
                    }
                }
                else
                {
                    label_WM.Text = "";
                }

                return;
            }
            else if (txtWm.Text.Trim().Length >= 4)
            {
                if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                {
                    MessageBox.Show("Invalild Warranty Month");
                    label_WM.Text = "Please Enter Valid Warranty Month";
                }
                else
                {
                    MessageBox.Show(Properties.Settings.Default.InvalidWMZh);
                    label_WM.Text = Properties.Settings.Default.ValidWMZh;
                }
                return;
            }
            else
            {
                Image pimg = pictureBox.Image;
                ImageConverter Converter = new ImageConverter();
                var ItemImg = Converter.ConvertTo(pimg, typeof(byte[]));
                Item item = new Item(txtItemID.Text.Trim(), txtCat.Text.Trim(), txtName.Text.Trim(), txtDesc.Text.Trim(), ItemImg, txtSalesPrice.Text.Trim(), comboBox_SupplierID.Text.Trim(), txtSupplierPrice.Text.Trim(), txtWm.Text.Trim(), comboBox_allowDly.Text.Trim());
                UpdateItem(item, getItemID);
                Close();
                _itemListfrm.DisplayTable();
            }
        }
    }
}



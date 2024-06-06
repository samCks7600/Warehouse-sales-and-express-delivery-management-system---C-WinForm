using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Reflection;

namespace BetterLimited
{
    public partial class frmDlvrNote : Form
    {
        public frmDlvrNote(int id)
        {
            InitializeComponent();
            using (dbEntities db = new dbEntities()) 
            {
                var dodr = db.deliveryorders.FirstOrDefault(i => i.DeliveryID == id);

                lblDisStoId.Text = "#" + dodr.salesorder.StoreID.ToString();
                lblDisStoAddress.Text = dodr.salesorder.store.Address;
                lblDisAddress.Text = dodr.salesorder.customer.Address;

                lblDisDlvrId.Text = dodr.DeliveryID.ToString();
                lblDisCreateDateTime.Text = (dodr.salesorder.Date + dodr.salesorder.Time).ToString("MM/dd/yyyy hh:mm tt");
                lblDisDueDateTime.Text = (dodr.DeliveryDate + dodr.DeliveryTime).ToString("MM/dd/yyyy hh:mm tt");

                decimal total = 0;
                foreach (var i in dodr.salesorder.salesorder_item)
                {
                    ContrDlvrItem cdi = new ContrDlvrItem(i);
                    flpDlvrItems.Controls.Add(cdi);
                    total += i.SalePrice * i.Qty;
                }
                lblDisTotal.Text = total.ToString("C0");
            }
        }

        Bitmap bmp;
        public void Print()
        {
            var createControl = this.GetType().GetMethod("CreateControl", BindingFlags.Instance | BindingFlags.NonPublic);
            createControl.Invoke(this, new object[] { true });

            Graphics myGraphics = this.CreateGraphics();
            bmp = new Bitmap(this.Width, this.Height, myGraphics);
            this.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));

            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Custom", this.Width, this.Height);
            printPreviewDialog1.Size = new Size(500, 500);
            printPreviewDialog1.ShowDialog();

            // DEBUG
            Console.WriteLine($"{this.Width}\t{this.Height}");
            Console.WriteLine($"{bmp.Width}\t{bmp.Height}");
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}

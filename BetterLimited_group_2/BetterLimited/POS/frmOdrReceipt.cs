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
    public partial class frmOdrReceipt : Form
    {
        public frmOdrReceipt(int id)
        {
            InitializeComponent();
            using (dbEntities db = new dbEntities())
            {
                var odr = db.salesorders.FirstOrDefault(i => i.SalesOrderID == id);
                

                if (odr.PaymentStatus == "ordered")
                    lblSubtitle.Text = "Pre-order Receipt";

                lblStoreAddress.Text = $"Address: {odr.store.Address}";
                lblStoreTel.Text = $"Tel: {odr.store.Tel.ToString("#### ####")}";
                lblOdrId.Text = $"Odr ID: #{id}";
                lblDateTime.Text = $"Date / Time: {(odr.Date + odr.Time).ToString("MM/dd/yyyy hh:mm tt")}";

                decimal total = 0;
                foreach (var i in odr.salesorder_item)
                {
                    ContrReceiptItem cri = new ContrReceiptItem(i);
                    flpOdrItems.Controls.Add(cri);
                    total += i.SalePrice * i.Qty;
                }
                lblDisTotal.Text = total.ToString("C2");
                lblDisCash.Text = odr.PaidAmt.ToString("C2");
                lblDisChange.Text = (odr.PaidAmt - total).ToString("C2");
            }
        }
        Bitmap bmp;
        public void Print()
        {
            // Generate from without opening
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

        /* [OLD]
        Bitmap memoryImage;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            s.Width = 350;
            s.Height = 500;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);

            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);

            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Custom", this.Width, this.Height);
            printDocument1.DefaultPageSettings.PaperSize.RawKind = 119;
            printDocument1.PrinterSettings.DefaultPageSettings.PaperSize.RawKind = 119; 
            printDocument1.DefaultPageSettings.Landscape = false;

            // printPreviewDialog1.Size = new Size(350, 500);
            // printPreviewDialog1.ShowDialog();
            
            printDocument1.Print();
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }*/
    }
}

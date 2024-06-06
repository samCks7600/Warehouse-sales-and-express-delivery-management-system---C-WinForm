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
    public partial class frmGdsRtnNote : Form
    {
        public frmGdsRtnNote(int id)
        {
            InitializeComponent();
            using (dbEntities db = new dbEntities())
            {
                var rtnNote = db.goodreturnnotes.FirstOrDefault(i => i.ReturnNoteID == id);

                lblDisStoId.Text = "#" + rtnNote.store.StoreID.ToString();
                lblDisStoAddress.Text = rtnNote.store.Address;

                lblDisPurStoID.Text = "#" + rtnNote.salesorder.StoreID.ToString();
                lblDisPurStoAddress.Text = rtnNote.salesorder.store.Address;

                lblDisGdsRtnId.Text = "#" + rtnNote.ReturnNoteID.ToString();
                lblDisCreateDateTime.Text = (rtnNote.Date + rtnNote.Time).ToString("MM/dd/yyyy hh:mm tt");

                lblDisOdrID.Text = "#" + rtnNote.SalesOrderID.ToString();
                lblDisOdrDateTime.Text = (rtnNote.salesorder.Date + rtnNote.salesorder.Time).ToString("MM/dd/yyyy hh:mm tt");
                lblDisWtyDateTime.Text = rtnNote.salesorder.ExpDate.ToString();

                decimal total = 0;
                foreach (var i in rtnNote.goodreturnnote_item)
                {
                    ContrGdsRtnItem gri = new ContrGdsRtnItem(i);
                    flpRtnItems.Controls.Add(gri);
                    total += i.item.SalePrice * (int)i.Qty;
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

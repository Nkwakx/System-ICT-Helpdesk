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
using DataAccessLayer;
using BusinessLogicLayer;

namespace System_ICT_Helpdesk
{
    public partial class rptInspectionDetails : Form
    {
        public rptInspectionDetails()
        {
            InitializeComponent();
        }
        DAL dal = new DAL();
        BLL bll = new BLL();
        private void rptInspectionDetails_Load(object sender, EventArgs e)
        {
            cmbSelectInspec.DataSource = bll.GetInspection();
            cmbSelectInspec.DisplayMember = "InspectionID";
            cmbSelectInspec.ValueMember = "InspectionID";
        }

        private void cmbSelectInspec_SelectedIndexChanged(object sender, EventArgs e)
        {
            int v;
            Int32.TryParse(cmbSelectInspec.SelectedValue.ToString(), out v);
            dgvSearch.DataSource = bll.GetInspDetailByInspID(v);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();
            printDialog.Document = printDocument;
            printDocument.PrintPage += printDocument_PrintPage;
            printDocument.PrintPage += printDocument_PrintPages;
            DialogResult result = printDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument.Print();
            }
        }
        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dgvSearch.Width, this.dgvSearch.Height);

            dgvSearch.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvSearch.Width, this.dgvSearch.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
        private void printDocument_PrintPages(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int height = dgvSearch.Height;
            dgvSearch.Height = dgvSearch.RowCount * dgvSearch.RowTemplate.Height;
            Bitmap bm = new Bitmap(this.dgvSearch.Width, this.dgvSearch.Height);

            dgvSearch.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvSearch.Width, this.dgvSearch.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            dgvSearch.Height = height;
        }

        private void btnPrint_MouseHover(object sender, EventArgs e)
        {
            lblPrinter.Visible = true;
            lblPrinter.Text = "Print";
        }
    }
}

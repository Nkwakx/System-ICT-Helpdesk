using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using DataAccessLayer;
using System.Drawing.Printing;


namespace System_ICT_Helpdesk
{
    public partial class rptTutorRequest : Form
    {
        public rptTutorRequest()
        {
            InitializeComponent();
        }
        BLL bll = new BLL();
        private void frmTutorReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            int c;
            Int32.TryParse(cmbVenue.SelectedValue.ToString(), out c);
            dgvTutorReports.DataSource = bll.GetTutorRequestByVenue(c);
        }

        private void frmTutorRequestSearch_Load(object sender, EventArgs e)
        {
            cmbVenue.DataSource = bll.GetVenue();
            cmbVenue.ValueMember = "VenueID";
            cmbVenue.DisplayMember = "VenueCode";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvTutorReports.DataSource = bll.GetByModule(txtSearch.Text);
        }

        private void txtSearch_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                errorProvider1.SetError(txtSearch, "Please Put Some Text To Search");
            }
        }

        private void btnPrint_MouseHover(object sender, EventArgs e)
        {
            lblPrinter.Visible = true;
            lblPrinter.Text = "Print";
        }

        private void btnPrint_MouseLeave(object sender, EventArgs e)
        {
            lblPrinter.Visible = false;
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
            Bitmap bm = new Bitmap(this.dgvTutorReports.Width, this.dgvTutorReports.Height);

            dgvTutorReports.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvTutorReports.Width, this.dgvTutorReports.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
        private void printDocument_PrintPages(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int height = dgvTutorReports.Height;
            dgvTutorReports.Height = dgvTutorReports.RowCount * dgvTutorReports.RowTemplate.Height;
            Bitmap bm = new Bitmap(this.dgvTutorReports.Width, this.dgvTutorReports.Height);

            dgvTutorReports.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvTutorReports.Width, this.dgvTutorReports.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            dgvTutorReports.Height = height;
        }

        private void dteEndDate_CloseUp(object sender, EventArgs e)
        {
            DateTime fromDate = Convert.ToDateTime(dteStartDate.Text);
            DateTime toDate = Convert.ToDateTime(dteEndDate.Text);
            if (fromDate <= toDate)
            {
                TimeSpan tSpan = toDate.Subtract(fromDate);
                int days = Convert.ToInt16(tSpan.Days);
                lblTimeDisplay.Text = "Days Between are : " + days;
                lblTimeDisplay.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblTimeDisplay.Text = "Enter Less Start Date Than End Date";
                lblTimeDisplay.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btnSelectEquip_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btnDateTime_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void btnFind_MouseEnter(object sender, EventArgs e)
        {
            lblSelectVenue.Visible = false;
            lblSearch.Visible = false;
            cmbVenue.Visible = false;
            txtSearch.Visible = false;
            btnSearch.Visible = false;

            btnSelectEquip.Visible = true;
        }

        private void dteStartDate_MouseEnter(object sender, EventArgs e)
        {
            lblSelectVenue.Visible = false;
            lblSearch.Visible = false;
            cmbVenue.Visible = false;
            txtSearch.Visible = false;
            btnSearch.Visible = false;

            btnSelectEquip.Visible = true;
        }

        private void cmbVenue_MouseEnter(object sender, EventArgs e)
        {
            lblStartDate.Visible = false;
            lblEndDate.Visible = false;
            btnFind.Visible = false;
            dteEndDate.Visible = false;
            dteStartDate.Visible = false;
            lblTimeDisplay.Visible = false;

            btnDateTime.Visible = true;
            btnSelectEquip.Visible = false;
        }

        private void txtSearch_MouseEnter(object sender, EventArgs e)
        {
            lblStartDate.Visible = false;
            lblEndDate.Visible = false;
            btnFind.Visible = false;
            dteEndDate.Visible = false;
            dteStartDate.Visible = false;
            lblTimeDisplay.Visible = false;

            btnDateTime.Visible = true;
            btnSelectEquip.Visible = false;
        }

        private void btnSearch_MouseEnter(object sender, EventArgs e)
        {
            lblStartDate.Visible = false;
            lblEndDate.Visible = false;
            btnFind.Visible = false;
            dteEndDate.Visible = false;
            dteStartDate.Visible = false;
            lblTimeDisplay.Visible = false;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgvTutorReports.DataSource = bll.GetRequestDetailsByDate(dteStartDate.Text, dteEndDate.Text);
        }

        private void btnSelectEquip_Click(object sender, EventArgs e)
        {
            lblSelectVenue.Visible = true;
            lblSearch.Visible = true;
            cmbVenue.Visible = true;
            txtSearch.Visible = true;
            btnSearch.Visible = true;

            lblStartDate.Visible = false;
            lblEndDate.Visible = false;
            btnFind.Visible = false;
            dteEndDate.Visible = false;
            dteStartDate.Visible = false;
            lblTimeDisplay.Visible = false;

            btnDateTime.Visible = true;
            btnSelectEquip.Visible = false;
        }

        private void btnDateTime_Click(object sender, EventArgs e)
        {
            lblStartDate.Visible = true;
            lblEndDate.Visible = true;
            btnFind.Visible = true;
            dteEndDate.Visible = true;
            dteStartDate.Visible = true;
            lblTimeDisplay.Visible = true;

            lblSelectVenue.Visible = false;
            lblSearch.Visible = false;
            cmbVenue.Visible = false;
            txtSearch.Visible = false;
            btnSearch.Visible = false;

            btnSelectEquip.Visible = true;
            btnDateTime.Visible = false;
        }
    }
}

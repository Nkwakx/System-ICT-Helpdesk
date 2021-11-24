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
    public partial class rptEquipmentHistoryReport : Form
    {
        public rptEquipmentHistoryReport()
        {
            InitializeComponent();
            lblTotals.Text = " ";
        }
        BLL bl = new BLL();
        DataTable dt = new DataTable();
        private void cmbSelectFromEquipment_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt = bl.GetEquipmentByDescription(cmbSelectFromEquipment.Text);
            dgvSearch.DataSource = bl.GetEquipmentByDescription(cmbSelectFromEquipment.Text);

            if (dt.Rows.Count > 0)
            {
                dgvSearch.DataSource = dt;
                lblTotals.Text = dt.Rows.Count.ToString();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dt= bl.GetEquipmentByType(txtSearch.Text);
            dgvSearch.DataSource = bl.GetEquipmentByType(txtSearch.Text);
            lblTotals.Text = dt.Rows.Count.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvSearch.DataSource = bl.GetEquipmentByType(txtSearch.Text);
            dt = bl.GetEquipmentByType(txtSearch.Text);
            lblTotals.Text = dt.Rows.Count.ToString();
        }

        private void frmEquipmentHistorySearch_Load(object sender, EventArgs e)
        {
            dt = bl.GetEquipmentByRepairs();
            cmbSelectFromEquipment.DataSource = bl.GetEquipmentByRepairs();
            cmbSelectFromEquipment.DisplayMember = "HistoryDescription";

            if (dt.Rows.Count > 0)
            {
                lblTotals.Text = dt.Rows.Count.ToString();
                dgvSearch.DataSource = dt;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dt = bl.GetEquipmentDetailsByDate(dteStartDate.Text, dteEndDate.Text);
            dgvSearch.DataSource = bl.GetEquipmentDetailsByDate(dteStartDate.Text, dteEndDate.Text);
            lblTotals.Text = dt.Rows.Count.ToString();
        }

        private void btnPrint_MouseHover(object sender, EventArgs e)
        {
            lblPrinter.Visible = true;
            lblPrinter.Text = "Print";
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

        private void dteEndDate_CloseUp(object sender, EventArgs e)
        {
            DateTime fromDate = Convert.ToDateTime(dteStartDate.Text);
            DateTime toDate = Convert.ToDateTime(dteEndDate.Text);
            if(fromDate <= toDate)
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

        private void cmbSelectFromEquipment_MouseEnter(object sender, EventArgs e)
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

        private void dteStartDate_MouseEnter(object sender, EventArgs e)
        {
            lblEquipSelect.Visible = false;
            lblSearch.Visible = false;
            cmbSelectFromEquipment.Visible = false;
            txtSearch.Visible = false;
            btnSearch.Visible = false;
            lblTimeDisplay.Visible = true;

            btnSelectEquip.Visible = true;
        }

        private void dteEndDate_MouseEnter(object sender, EventArgs e)
        {
            lblEquipSelect.Visible = false;
            lblSearch.Visible = false;
            cmbSelectFromEquipment.Visible = false;
            txtSearch.Visible = false;
            btnSearch.Visible = false;
            lblTimeDisplay.Visible = true;

            btnSelectEquip.Visible = true;
        }

        private void btnFind_MouseEnter(object sender, EventArgs e)
        {
            lblEquipSelect.Visible = false;
            lblSearch.Visible = false;
            cmbSelectFromEquipment.Visible = false;
            txtSearch.Visible = false;
            btnSearch.Visible = false;
            lblTimeDisplay.Visible = true;

            btnSelectEquip.Visible = true;
        }

        private void btnDateTime_Click(object sender, EventArgs e)
        {
            lblStartDate.Visible = true;
            lblEndDate.Visible = true;
            btnFind.Visible = true;
            dteEndDate.Visible = true;
            dteStartDate.Visible = true;
            lblTimeDisplay.Visible = true;

            lblEquipSelect.Visible = false;
            lblSearch.Visible = false;
            cmbSelectFromEquipment.Visible = false;
            txtSearch.Visible = false;
            btnSearch.Visible = false;

            btnSelectEquip.Visible = true;
            btnDateTime.Visible = false;
        }

        private void btnSelectEquip_Click(object sender, EventArgs e)
        {
            lblEquipSelect.Visible = true;
            lblSearch.Visible = true;
            cmbSelectFromEquipment.Visible = true;
            txtSearch.Visible = true;
            btnSearch.Visible = true;
            lblTimeDisplay.Visible = true;

            lblStartDate.Visible = false;
            lblEndDate.Visible = false;
            btnFind.Visible = false;
            dteEndDate.Visible = false;
            dteStartDate.Visible = false;

            btnDateTime.Visible = true;
            btnSelectEquip.Visible = false;
        }
    }
}

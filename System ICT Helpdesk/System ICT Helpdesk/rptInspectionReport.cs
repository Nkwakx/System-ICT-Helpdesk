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
    public partial class rptInspectionReport : Form
    {
        public rptInspectionReport()
        {
            InitializeComponent();
        }
        BLL mbll = new BLL();
        EquipmentHistory eqH = new EquipmentHistory();
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
            Bitmap bm = new Bitmap(this.dgvSearchEquipment.Width, this.dgvSearchEquipment.Height);

            dgvSearchEquipment.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvSearchEquipment.Width, this.dgvSearchEquipment.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
        private void printDocument_PrintPages(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int height = dgvSearchEquipment.Height;
            dgvSearchEquipment.Height = dgvSearchEquipment.RowCount * dgvSearchEquipment.RowTemplate.Height;
            Bitmap bm = new Bitmap(this.dgvSearchEquipment.Width, this.dgvSearchEquipment.Height);

            dgvSearchEquipment.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvSearchEquipment.Width, this.dgvSearchEquipment.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            dgvSearchEquipment.Height = height;
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

        private void btnBetween_Click(object sender, EventArgs e)
        {
            lblVenue.Visible = false;
            lblStaffMember.Visible = false;
            lblStartDate.Visible = true;
            lblEndDate.Visible = true;
            txtSearchByLab.Visible = false;
            txtStaffMember.Visible = false;
            dteStartDate.Visible = true;
            dteEndDate.Visible = true;
            btnDisplayBetween.Visible = true;
            btnFind.Visible = false;
            btnDispalyStaff.Visible = false;
        }

        private void btnStaffMember_Click(object sender, EventArgs e)
        {
            lblVenue.Visible = false;
            lblStaffMember.Visible = true;
            lblStartDate.Visible = true;
            lblEndDate.Visible = true;
            txtSearchByLab.Visible = false;
            txtStaffMember.Visible = true;
            dteStartDate.Visible = true;
            dteEndDate.Visible = true;
            btnDispalyStaff.Visible = true;
            btnFind.Visible = false;
            btnDisplayBetween.Visible = false;
        }

        private void btnSingleLab_Click(object sender, EventArgs e)
        {
            lblVenue.Visible = true;
            lblStaffMember.Visible = false;
            lblStartDate.Visible = true;
            lblEndDate.Visible = true;
            txtSearchByLab.Visible = true;
            txtStaffMember.Visible = false;
            dteStartDate.Visible = true;
            dteEndDate.Visible = true;
            btnFind.Visible = true;
            btnDispalyStaff.Visible = false;
            btnDisplayBetween.Visible = false;
        }

        private void btnBetween_MouseHover(object sender, EventArgs e)
        {
            btnBetween.BackColor = Color.Gold;
        }

        private void btnStaffMember_MouseHover(object sender, EventArgs e)
        {
            btnStaffMember.BackColor = Color.Gold;
        }

        private void btnSingleLab_MouseEnter(object sender, EventArgs e)
        {
            btnSingleLab.BackColor = Color.Gold;
        }

        private void btnSingleLab_MouseLeave(object sender, EventArgs e)
        {
            btnSingleLab.BackColor = Color.Transparent;
        }

        private void btnStaffMember_MouseLeave(object sender, EventArgs e)
        {
            btnStaffMember.BackColor = Color.Transparent;
        }

        private void btnBetween_MouseLeave(object sender, EventArgs e)
        {
            btnBetween.BackColor = Color.Transparent;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgvSearchEquipment.DataSource = mbll.GetInspectReportByVenue(txtSearchByLab.Text, dteStartDate.Text, dteEndDate.Text);
        }

        private void btnDisplayBetween_Click(object sender, EventArgs e)
        {
            dgvSearchEquipment.DataSource = mbll.GetInspectReportByDate(dteStartDate.Text, dteEndDate.Text);
        }

        private void btnDispalyStaff_Click(object sender, EventArgs e)
        {
            dgvSearchEquipment.DataSource = mbll.GetInspectReportByStaff(txtStaffMember.Text, dteStartDate.Text, dteEndDate.Text);
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
    }
}

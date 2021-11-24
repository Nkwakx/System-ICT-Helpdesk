using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_ICT_Helpdesk
{
    public partial class rptMainForm : Form
    {
        public rptMainForm()
        {
            InitializeComponent();
        }

        private void btnEquipReport_MouseEnter(object sender, EventArgs e)
        {
            btnEquipReport.BackColor = Color.Gold;
            pnlMain.Controls.Clear();
            rptEquipmentHistoryReport rep = new rptEquipmentHistoryReport();
            rep.TopLevel = false;
            pnlMain.Controls.Add(rep);
            rep.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            rep.Dock = DockStyle.Fill;
            rep.Visible = true;
        }

        private void btnInspectionReport_MouseEnter(object sender, EventArgs e)
        {
            btnInspectionReport.BackColor = Color.Gold;
            pnlMain.Controls.Clear();
            rptInspectionReport rpIn = new rptInspectionReport();
            rpIn.TopLevel = false;
            pnlMain.Controls.Add(rpIn);
            rpIn.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            rpIn.Dock = DockStyle.Fill;
            rpIn.Visible = true;
        }

        private void btnRequestReport_MouseEnter(object sender, EventArgs e)
        {
            btnRequestReport.BackColor = Color.Gold;
            pnlMain.Controls.Clear();
            rptRequestSearch repR = new rptRequestSearch();
            repR.TopLevel = false;
            pnlMain.Controls.Add(repR);
            repR.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            repR.Dock = DockStyle.Fill;
            repR.Visible = true;
        }

        private void btnTutorReport_MouseEnter(object sender, EventArgs e)
        {
            btnTutorReport.BackColor = Color.Gold;
            pnlMain.Controls.Clear();
            rptTutorRequest rpT = new rptTutorRequest();
            rpT.TopLevel = false;
            pnlMain.Controls.Add(rpT);
            rpT.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            rpT.Dock = DockStyle.Fill;
            rpT.Visible = true;
        }

        private void btnStudentSearch_MouseEnter(object sender, EventArgs e)
        {
            btnStudentSearch.BackColor = Color.Gold;
            pnlMain.Controls.Clear();
            rptForStudent rpS = new rptForStudent();
            rpS.TopLevel = false;
            pnlMain.Controls.Add(rpS);
            rpS.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            rpS.Dock = DockStyle.Fill;
            rpS.Visible = true;
        }

        private void btnEquipReport_MouseLeave(object sender, EventArgs e)
        {
            btnEquipReport.BackColor = Color.Transparent;
        }

        private void btnInspectionReport_MouseLeave(object sender, EventArgs e)
        {
            btnInspectionReport.BackColor = Color.Transparent;
        }

        private void btnRequestReport_MouseLeave(object sender, EventArgs e)
        {
            btnRequestReport.BackColor = Color.Transparent;
        }

        private void btnTutorReport_MouseLeave(object sender, EventArgs e)
        {
            btnTutorReport.BackColor = Color.Transparent;
        }

        private void btnStudentSearch_MouseLeave(object sender, EventArgs e)
        {
            btnStudentSearch.BackColor = Color.Transparent;
        }

        private void btnInspecDetailsReport_MouseEnter(object sender, EventArgs e)
        {
            btnInspecDetailsReport.BackColor = Color.Gold;
            pnlMain.Controls.Clear();
            rptInspectionDetails rpS = new rptInspectionDetails();
            rpS.TopLevel = false;
            pnlMain.Controls.Add(rpS);
            rpS.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            rpS.Dock = DockStyle.Fill;
            rpS.Visible = true;
        }

        private void btnInspecDetailsReport_MouseLeave(object sender, EventArgs e)
        {
            btnInspecDetailsReport.BackColor = Color.Transparent;
        }
    }
}

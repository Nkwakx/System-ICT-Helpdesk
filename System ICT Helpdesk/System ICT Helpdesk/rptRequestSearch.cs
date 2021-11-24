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
    public partial class rptRequestSearch : Form
    {
        public rptRequestSearch()
        {
            InitializeComponent();
        }
        BLL bll = new BLL();
        private void btnStaffMember_Click(object sender, EventArgs e)
        {
            lblSelectTask.Visible = false;
            cmbRequestByTask.Visible = false;
            lblStaffMember.Visible = true;
            txtStaffMember.Visible = true;
            lblStartDate.Visible = true;
            lblEndDate.Visible = true;
            dteStartDate.Visible = true;
            dteEndDate.Visible = true;
            btnReqTaskType.Visible = true;
        }

        private void btnRequestByTask_Click(object sender, EventArgs e)
        {
            lblSelectTask.Visible = true;
            cmbRequestByTask.Visible = true;
            lblStaffMember.Visible = false;
            lblStartDate.Visible = false;
            lblEndDate.Visible = false;
            txtStaffMember.Visible = false;
            dteStartDate.Visible = false;
            dteEndDate.Visible = false;
        }

        private void btnStaffMember_MouseEnter(object sender, EventArgs e)
        {
            btnStaffMember.BackColor = Color.Gold;
        }

        private void btnRequestByTask_MouseEnter(object sender, EventArgs e)
        {
            btnReqTaskType.BackColor = Color.Gold;
        }

        private void btnRequestByTask_MouseLeave(object sender, EventArgs e)
        {
            btnReqTaskType.BackColor = Color.Transparent;
        }

        private void btnStaffMember_MouseLeave(object sender, EventArgs e)
        {
            btnStaffMember.BackColor = Color.Transparent;
        }

        private void cmbRequestByTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            int c;
            Int32.TryParse(cmbRequestByTask.SelectedValue.ToString(), out c);
            dgvSearch.DataSource = bll.GetRequestByTaskType(c);
        }

        private void btnReqTaskType_Click(object sender, EventArgs e)
        {
            dgvSearch.DataSource = bll.GetRequestReportByStaff(txtStaffMember.Text, dteStartDate.Text, dteEndDate.Text);
        }

        private void rptRequestSearch_Load(object sender, EventArgs e)
        {
            cmbRequestByTask.DataSource = bll.GetTask();
            cmbRequestByTask.DisplayMember = "TaskDescription";
            cmbRequestByTask.ValueMember = "TaskID";
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

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
    public partial class frmRequest : Form
    {
        private bool mouseInPanel;
        private Timer hideTimer;
        public frmRequest()
        {
            DateTime time = DateTime.Today;
            InitializeComponent();
            hideTimer = new Timer { Interval = 100 };
            hideTimer.Tick += hidePanel;
            for (DateTime _time = time.AddHours(07); _time < time.AddHours(18); _time = _time.AddMinutes(01))
            {
                cmbStartTime.Items.Add(_time.ToShortTimeString());
            }
        }
        BLL bll = new BLL();
        Request req = new Request();
        private void hidePanel(object sender, EventArgs e)
        {
            hideTimer.Stop();
            if (!mouseInPanel) this.pnlDasshBard.Visible = true;
        }
        private void btnOpenCotrols_MouseEnter(object sender, EventArgs e)
        {
            btnOpenCotrols.BackColor = Color.Gold;
            mouseInPanel = true;
            pnlControl.Visible = true;
            pnlBtn.Visible = true;
        }

        private void btnOpenCotrols_MouseLeave(object sender, EventArgs e)
        {
            btnOpenCotrols.BackColor = Color.Transparent;
            mouseInPanel = false;
            hideTimer.Start();
        }

        private void btnList_MouseEnter(object sender, EventArgs e)
        {
            btnList.BackColor = Color.Transparent;
            mouseInPanel = false;
            hideTimer.Start();
        }

        private void btnList_MouseLeave(object sender, EventArgs e)
        {
            btnList.BackColor = Color.Gold;
            dgvRequest.Visible = true;
            mouseInPanel = true;
            Display();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            req.RequestDescription = txtReqDesc.Text;
            req.StaffID = int.Parse(cmbStaffType.SelectedValue.ToString());
            req.StudentID = int.Parse(cmbStudNo.SelectedValue.ToString());
            req.TaskID = int.Parse(cmbTaskDesc.SelectedValue.ToString());
            req.Date = dteRequestDate.Value.ToString("yyyy-MM-dd");
            req.Time = cmbStartTime.Text;
            req.StaffAssigned = cmbStaffAssign.Text;
            req.RequestStatus = "Active";

            if (string.IsNullOrEmpty(txtReqDesc.Text) || string.IsNullOrEmpty(cmbStaffType.SelectedValue.ToString()) ||
                string.IsNullOrEmpty(cmbStartTime.Text) || string.IsNullOrEmpty(cmbStudNo.SelectedValue.ToString()) ||
                string.IsNullOrEmpty(cmbTaskDesc.SelectedValue.ToString()) || string.IsNullOrEmpty(cmbStartTime.Text))
            {
                MessageBox.Show("All Field Required, Double Check If There's No Empty Fields", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int x = bll.InsertRequest(req);
                if (x > 0)
                {
                    MessageBox.Show("Your Data Successfully Added", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Display();
                    txtReqDesc.Clear();
                }
                else
                {
                    MessageBox.Show("unfortunately Data Wasn't Successful");
                }
            }
        }
        public void Display()
        {
            dgvRequest.DataSource = bll.GetRequest();
        }

        private void cmbStartTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strTime_Time = cmbStartTime.SelectedItem.ToString();
            string strTime_End = "18:00";
            DateTime dateTime_Start = Convert.ToDateTime(strTime_Time);
            DateTime dateTime_End = Convert.ToDateTime(strTime_End);
        }

        private void frmRequest_Load(object sender, EventArgs e)
        {
            cmbStaffType.DataSource = bll.GetStaffLabManager();
            cmbStaffType.DisplayMember = "FirstName";
            cmbStaffType.ValueMember = "StaffID";

            cmbStudNo.DataSource = bll.GetStudent();
            cmbStudNo.DisplayMember = "StudentName";
            cmbStudNo.ValueMember = "StudentID";

            cmbTaskDesc.DataSource = bll.GetTask();
            cmbTaskDesc.DisplayMember = "TaskDescription";
            cmbTaskDesc.ValueMember = "TaskID";

            cmbStaffAssign.DataSource = bll.GetStaffInspection();
            cmbStaffAssign.DisplayMember = "FirstName";
            cmbStaffAssign.ValueMember = "StaffID";
        }

        private void btnSoftDeleteReq_Click(object sender, EventArgs e)
        {
            Request req = new Request();
            req.RequestID = int.Parse(lblRequestCode.Text);
            req.RequestStatus = "In-Active";
            bll.UpdateRequest(req);
            dgvRequest.DataSource = bll.GetRequest();

            dgvRequest.Visible = true;
        }

        private void btnHardDeleteReq_Click(object sender, EventArgs e)
        {
            Request requ = new Request();
            requ.RequestID = int.Parse(lblRequestCode.Text);
            bll.DeleteFromRequest(requ.RequestID);
            dgvRequest.DataSource = bll.GetRequest();
        }

        private void dgvRequest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                pnlRequestDetails.Visible = true;
                pnlControl.Visible = false;
                if (dgvRequest.SelectedRows.Count > 0)
                {
                    dt = bll.GetRequestByRequestID(int.Parse(dgvRequest.SelectedRows[0].Cells["RequestID"].Value.ToString()));

                    lblRequestCode.Text = dt.Rows[0]["RequestID"].ToString();
                    lblDescr.Text = dt.Rows[0]["RequestDescription"].ToString();
                    lblRequestStatus.Text = dt.Rows[0]["RequestStatus"].ToString();

                    if (dt.Columns.Contains("Address"))
                    {
                        //lblTaskDesc.Text = dt.Rows[0]["TaskID"].ToString();
                    }
                }

            }
            catch
            {
                MessageBox.Show("Invalid Selection");
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
            Bitmap bm = new Bitmap(this.dgvRequest.Width, this.dgvRequest.Height);

            dgvRequest.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvRequest.Width, this.dgvRequest.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
        private void printDocument_PrintPages(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int height = dgvRequest.Height;
            dgvRequest.Height = dgvRequest.RowCount * dgvRequest.RowTemplate.Height;
            Bitmap bm = new Bitmap(this.dgvRequest.Width, this.dgvRequest.Height);

            dgvRequest.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvRequest.Width, this.dgvRequest.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            dgvRequest.Height = height;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using BusinessLogicLayer;
using System.Drawing.Printing;

namespace System_ICT_Helpdesk
{
    public partial class frmInspection : Form
    {
        private bool mouseInPanel;
        private Timer hideTimer;
        public frmInspection()
        {
            DateTime time = DateTime.Today;

            InitializeComponent();
            hideTimer = new Timer { Interval = 100 };
            hideTimer.Tick += hidePanel;
            for (DateTime _time = time.AddHours(07); _time < time.AddHours(18); _time = _time.AddMinutes(01))
            {
                cmbDteStart.Items.Add(_time.ToShortTimeString());
                cmbDteEnd.Items.Add(_time.ToShortTimeString());
            }
        }
        BLL bll = new BLL();
        Inspection myIn = new Inspection();
        private void hidePanel(object sender, EventArgs e)
        {
            hideTimer.Stop();
            if (!mouseInPanel) this.pnlButtons.Visible = true;
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
            dgvInspection.Visible = true;
            mouseInPanel = true;
            Display();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtComment.Text)))
            {
                myIn.VenueID = int.Parse(cmbVenueName.SelectedValue.ToString());
                myIn.StaffID = int.Parse(cmbStaffType.SelectedValue.ToString());
                myIn.InspectionDate = dteDate.Text;
                myIn.StartTime = cmbDteStart.Text;
                myIn.EndTime = cmbDteEnd.Text;
                myIn.Comment = txtComment.Text;

                int c = bll.InsertInspection(myIn);
                if (c > 0)
                {
                    MessageBox.Show("Your Data Successfully Added");
                    Display();
                    txtComment.Clear();
                }
                else
                {
                    MessageBox.Show("unfortunately Data Wasn't Successful");
                }
            }
            else
            {
                MessageBox.Show("All Field Required, Double Check If There's No Empty Fields", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Display()
        {
            dgvInspection.DataSource = bll.GetInspection();
        }

        private void cmbDteStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strTime_Time = cmbDteStart.SelectedItem.ToString();
            string strTime_End = "18:00";
            DateTime dateTime_Start = Convert.ToDateTime(strTime_Time);
            DateTime dateTime_End = Convert.ToDateTime(strTime_End);
        }

        private void cmbDteEnd_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strTime_Time = cmbDteEnd.SelectedItem.ToString();
            string strTime_End = "18:00";
            DateTime dateTime_Start = Convert.ToDateTime(strTime_Time);
            DateTime dateTime_End = Convert.ToDateTime(strTime_End);
        }
        private void frmInspection_Load(object sender, EventArgs e)
        {
            cmbVenueName.DataSource = bll.GetVenue();
            cmbVenueName.DisplayMember = "VenueCode";
            cmbVenueName.ValueMember = "VenueID";

            cmbStaffType.DataSource = bll.GetStaffInspection();
            cmbStaffType.DisplayMember = "LastName";
            cmbStaffType.ValueMember = "StaffID";
        }

        private void btnPrint_MouseEnter(object sender, EventArgs e)
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
            Bitmap bm = new Bitmap(this.dgvInspection.Width, this.dgvInspection.Height);

            dgvInspection.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvInspection.Width, this.dgvInspection.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
        private void printDocument_PrintPages(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int height = dgvInspection.Height;
            dgvInspection.Height = dgvInspection.RowCount * dgvInspection.RowTemplate.Height;
            Bitmap bm = new Bitmap(this.dgvInspection.Width, this.dgvInspection.Height);

            dgvInspection.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvInspection.Width, this.dgvInspection.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            dgvInspection.Height = height;
        }

        private void dgvInspection_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                if (dgvInspection.SelectedRows.Count > 0)
                {
                    dt = bll.GetInspectionByInspectionID(int.Parse(dgvInspection.SelectedRows[0].Cells["InspectionID"].Value.ToString()));

                    //if (dt.Columns.Contains("VenueID"))
                    //{
                    //    cmbVenueName.SelectedValue = int.Parse(dt.Rows[0]["VenueID"].ToString());
                    //    cmbStaffType.SelectedValue = int.Parse(dt.Rows[0]["StaffID"].ToString());
                    //}

                    dteDate.Text = dt.Rows[0]["InspectionDate"].ToString();
                    cmbDteStart.Text = dt.Rows[0]["StartTime"].ToString();
                    cmbDteEnd.Text = dt.Rows[0]["EndTime"].ToString();
                    txtComment.Text = dt.Rows[0]["Comment"].ToString();
                }
            }
            catch
            {
                MessageBox.Show("Invalid Selection");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (dgvInspection.SelectedRows.Count > 0)
            {
                Inspection myS = new Inspection(int.Parse(dgvInspection.SelectedRows[0].Cells["InspectionID"].Value.ToString()), int.Parse(cmbVenueName.SelectedValue.ToString()), int.Parse(cmbStaffType.SelectedValue.ToString()), 
                    dteDate.Text, cmbDteStart.Text, cmbDteEnd.Text, txtComment.Text);
                int x = bll.UpdateInspection(myS);

                Display();
                txtComment.Clear();
            }
        }
    }
}

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
    public partial class frmTutor : Form
    {
        private bool mouseInPanel;
        private Timer hideTimer;
        public frmTutor()
        {
            DateTime time = DateTime.Today;
            InitializeComponent();
            hideTimer = new Timer { Interval = 100 };
            hideTimer.Tick += hidePanel;
            for (DateTime _time = time.AddHours(07); _time < time.AddHours(18); _time = _time.AddMinutes(01))
            {
                cmbStartTime.Items.Add(_time.ToShortTimeString());
                cmbEndTime.Items.Add(_time.ToShortTimeString());
            }
        }
        BLL bll = new BLL();
        Tutor tu = new Tutor();

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
            dgvTutor.Visible = true;
            mouseInPanel = true;
            Display();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            tu.RequestID = int.Parse(cmbRequestID.SelectedValue.ToString());
            tu.ModuleID = int.Parse(cmbModule.SelectedValue.ToString());
            tu.VenueID = int.Parse(cmbVenue.SelectedValue.ToString());
            tu.TutorDate = dteTutor.Value.ToString("yyy-MM-dd");
            tu.StartTime = cmbStartTime.Text;
            tu.EndTime = cmbEndTime.Text;

            if (string.IsNullOrEmpty(cmbStartTime.Text) || string.IsNullOrEmpty(cmbEndTime.Text))
            {
                MessageBox.Show("All Field Required, Double Check If There's No Empty Fields", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int x = bll.InsertTutor(tu);
                if (x > 0)
                {
                    MessageBox.Show("Your Data Successfully Added", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Display();
                }
                else
                {
                    MessageBox.Show("unfortunately Data Wasn't Successful", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public void Display()
        {
            dgvTutor.DataSource = bll.GetTutor();
        }

        private void frmTutor_Load(object sender, EventArgs e)
        {
            cmbModule.DataSource = bll.GetModule();
            cmbModule.DisplayMember = "ModuleCode";
            cmbModule.ValueMember = "ModuleID";

           
            cmbVenue.DataSource = bll.GetVenue();
            cmbVenue.DisplayMember = "VenueCode";
            cmbVenue.ValueMember = "VenueID";

            cmbRequestID.DataSource = bll.GetRequestTutor();
            cmbRequestID.DisplayMember = "RequestDescription";
            cmbRequestID.ValueMember = "RequestID";
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
            Bitmap bm = new Bitmap(this.dgvTutor.Width, this.dgvTutor.Height);

            dgvTutor.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvTutor.Width, this.dgvTutor.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
        private void printDocument_PrintPages(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int height = dgvTutor.Height;
            dgvTutor.Height = dgvTutor.RowCount * dgvTutor.RowTemplate.Height;
            Bitmap bm = new Bitmap(this.dgvTutor.Width, this.dgvTutor.Height);

            dgvTutor.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvTutor.Width, this.dgvTutor.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            dgvTutor.Height = height;
        }

        private void cmbStartTime_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string strTime_Time = cmbStartTime.SelectedItem.ToString();
            string strTime_End = "18:00";
            DateTime dateTime_Start = Convert.ToDateTime(strTime_Time);
            DateTime dateTime_End = Convert.ToDateTime(strTime_End);
        }

        private void cmbEndTime_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string strTime_Time = cmbStartTime.SelectedItem.ToString();
            string strTime_End = "18:00";
            DateTime dateTime_Start = Convert.ToDateTime(strTime_Time);
            DateTime dateTime_End = Convert.ToDateTime(strTime_End);
        }
    }
}


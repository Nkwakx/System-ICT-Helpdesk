using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace System_ICT_Helpdesk
{
    public partial class frmDashboardM : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private const int cGrip = 16;

        private bool mouseInPanel;
        private Timer hideTimer;
        public frmDashboardM(string referenc)
        {
            InitializeComponent();
            lblReference.Text = referenc;
            hideTimer = new Timer { Interval = 100 };
            hideTimer.Tick += hidePanel;
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
        }
        private void hidePanel(object sender, EventArgs e)
        {
            hideTimer.Stop();
            if (!mouseInPanel) this.pnlReview.Visible = true;
            if (!mouseInPanel) this.pnlFooter.Visible = false;
            if (!mouseInPanel) this.pnlForms.Visible = false;
            if (!mouseInPanel) this.pnlInstruction.Visible = false;
            
        }
        private void frmDashboardM_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnInspect_Click(object sender, EventArgs e)
        {

        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbxMax_Click(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void pbxMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClick_MouseEnter(object sender, EventArgs e)
        {
            btnClick.BackColor = Color.Gold;
            pnlInstruction.Visible = true;
            pnlForms.Visible = true;
            pnlFooter.Visible = true;
            pnlReview.Visible = false;
        }

        private void btnClick_MouseHover(object sender, EventArgs e)
        {
            btnClick.BackColor = Color.Gold;
            pnlInstruction.Visible = true;
            pnlForms.Visible = true;
            pnlFooter.Visible = true;
            pnlReview.Visible = false;
        }

        private void btnClick_MouseLeave(object sender, EventArgs e)
        {
            btnClick.BackColor = Color.Gold;
            hideTimer.Start();
        }
       
        private void btnEquipment_Click_1(object sender, EventArgs e)
        {
            pnlReview.Controls.Clear();
            frmEquipment myEquip = new frmEquipment();
            myEquip.TopLevel = false;
            pnlReview.Controls.Add(myEquip);
            myEquip.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            myEquip.Dock = DockStyle.Fill;
            myEquip.Show();
            pnlFooter.Visible = false;
            pnlForms.Visible = false;
            pnlInstruction.Visible = false;
            pnlReview.Visible = true;
        }

        private void pnlForms_MouseEnter_1(object sender, EventArgs e)
        {
            btnClick.BackColor = Color.Gold;
            mouseInPanel = true;
            pnlForms.Visible = true;
            pnlReview.Visible = false;
        }

        private void pnlForms_MouseLeave_1(object sender, EventArgs e)
        {
            btnClick.BackColor = Color.Transparent;
            mouseInPanel = false;
            hideTimer.Start();
        }

        private void btnEquipment_MouseEnter_1(object sender, EventArgs e)
        {
            btnClick.BackColor = Color.Gold;
            btnEquipment.BackColor = Color.Gold;
            mouseInPanel = true;
            this.pnlForms.Visible = true;
        }

        private void btnEquipment_MouseLeave_1(object sender, EventArgs e)
        {
            btnEquipment.BackColor = Color.Transparent;
        }

        private void btnEquipmentType_MouseEnter_1(object sender, EventArgs e)
        {
            btnClick.BackColor = Color.Gold;
            btnEquipmentType.BackColor = Color.Gold;
            mouseInPanel = true;
            this.pnlForms.Visible = true;
        }

        private void btnEquipmentType_MouseLeave_1(object sender, EventArgs e)
        {
            btnEquipmentType.BackColor = Color.Transparent;
        }

        private void btnEquipmentHistory_MouseEnter_1(object sender, EventArgs e)
        {
            btnClick.BackColor = Color.Gold;
            btnEquipmentHistory.BackColor = Color.Gold;
            mouseInPanel = true;
            this.pnlForms.Visible = true;
        }

        private void btnEquipmentHistory_MouseLeave_1(object sender, EventArgs e)
        {
            btnEquipmentHistory.BackColor = Color.Transparent;
        }

        private void btnCourses_MouseEnter_1(object sender, EventArgs e)
        {
            btnClick.BackColor = Color.Gold;
            btnCourses.BackColor = Color.Gold;
            mouseInPanel = true;
            this.pnlForms.Visible = true;
        }

        private void btnCourses_MouseLeave_1(object sender, EventArgs e)
        {
            btnCourses.BackColor = Color.Transparent;
        }

        private void btnModules_MouseEnter_1(object sender, EventArgs e)
        {
            btnClick.BackColor = Color.Gold;
            btnModules.BackColor = Color.Gold;
            mouseInPanel = true;
            this.pnlForms.Visible = true;
        }

        private void btnModules_MouseLeave_1(object sender, EventArgs e)
        {
            btnModules.BackColor = Color.Transparent;
        }

        private void btnTutorRequests_MouseEnter_1(object sender, EventArgs e)
        {
            btnClick.BackColor = Color.Gold;
            btnTutorRequests.BackColor = Color.Gold;
            mouseInPanel = true;
            this.pnlForms.Visible = true;
        }

        private void btnTutorRequests_MouseLeave_1(object sender, EventArgs e)
        {
            btnTutorRequests.BackColor = Color.Transparent;
        }

        private void btnRequestForm_MouseEnter_1(object sender, EventArgs e)
        {
            btnClick.BackColor = Color.Gold;
            btnRequestForm.BackColor = Color.Gold;
            mouseInPanel = true;
            this.pnlForms.Visible = true;
        }

        private void btnRequestForm_MouseLeave_1(object sender, EventArgs e)
        {
            btnRequestForm.BackColor = Color.Transparent;
        }

        private void btnTasks_MouseEnter_1(object sender, EventArgs e)
        {
            btnClick.BackColor = Color.Gold;
            btnTasks.BackColor = Color.Gold;
            mouseInPanel = true;
            this.pnlForms.Visible = true;
        }

        private void btnTasks_MouseLeave_1(object sender, EventArgs e)
        {
            btnTasks.BackColor = Color.Transparent;
        }

        private void btnStud_MouseEnter_1(object sender, EventArgs e)
        {
            btnClick.BackColor = Color.Gold;
            btnStud.BackColor = Color.Gold;
            mouseInPanel = true;
            this.pnlForms.Visible = true;
        }

        private void btnStud_MouseLeave_1(object sender, EventArgs e)
        {
            btnStud.BackColor = Color.Transparent;
        }

        private void btnBuilding_MouseEnter_1(object sender, EventArgs e)
        {
            btnClick.BackColor = Color.Gold;
            btnBuilding.BackColor = Color.Gold;
            mouseInPanel = true;
            this.pnlForms.Visible = true;
        }

        private void btnBuilding_MouseLeave_1(object sender, EventArgs e)
        {
            btnBuilding.BackColor = Color.Transparent;
        }

        private void btnDept_MouseEnter_1(object sender, EventArgs e)
        {
            btnClick.BackColor = Color.Gold;
            btnDept.BackColor = Color.Gold;
            mouseInPanel = true;
            this.pnlForms.Visible = true;
        }

        private void btnDept_MouseLeave_1(object sender, EventArgs e)
        {
            btnDept.BackColor = Color.Transparent;
        }

        private void btnFloors_MouseEnter_1(object sender, EventArgs e)
        {
            btnClick.BackColor = Color.Gold;
            btnFloors.BackColor = Color.Gold;
            mouseInPanel = true;
            this.pnlForms.Visible = true;
        }

        private void btnFloors_MouseLeave_1(object sender, EventArgs e)
        {
            btnFloors.BackColor = Color.Transparent;
        }

        private void btnVenues_MouseEnter_1(object sender, EventArgs e)
        {
            btnClick.BackColor = Color.Gold;
            btnVenues.BackColor = Color.Gold;
            mouseInPanel = true;
            this.pnlForms.Visible = true;
        }

        private void btnVenues_MouseLeave_1(object sender, EventArgs e)
        {
            btnVenues.BackColor = Color.Transparent;
        }

        private void btnStaffs_MouseEnter_1(object sender, EventArgs e)
        {
            btnClick.BackColor = Color.FloralWhite;
            btnStaffs.BackColor = Color.Gold;
            mouseInPanel = true;
            this.pnlForms.Visible = true;
        }

        private void btnStaffs_MouseLeave_1(object sender, EventArgs e)
        {
            btnStaffs.BackColor = Color.Transparent;
        }

        private void btnInspect_MouseEnter_1(object sender, EventArgs e)
        {
           
            btnClick.BackColor = Color.Gold;
            btnInspect.BackColor = Color.Gold;
            mouseInPanel = true;
            this.pnlForms.Visible = true;
        }

        private void btnInspect_MouseLeave_1(object sender, EventArgs e)
        {
            btnInspect.BackColor = Color.Transparent;
        }

        private void btnInspectDetails_MouseEnter_1(object sender, EventArgs e)
        {
            btnClick.BackColor = Color.Gold;
            btnInspectDetails.BackColor = Color.Gold;
            mouseInPanel = true;
            this.pnlForms.Visible = true;

        }

        private void btnInspectDetails_MouseLeave(object sender, EventArgs e)
        {
            btnInspectDetails.BackColor = Color.Transparent;
        }

        private void btnEquipmentType_Click_1(object sender, EventArgs e)
        {
            pnlReview.Controls.Clear();
            frmEquipmentType myEquip = new frmEquipmentType();
            myEquip.TopLevel = false;
            pnlReview.Controls.Add(myEquip);
            myEquip.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            myEquip.Dock = DockStyle.Fill;
            myEquip.Show();
            pnlFooter.Visible = false;
            pnlForms.Visible = false;
            pnlInstruction.Visible = false;
            pnlReview.Visible = true;
        }

        private void btnEquipmentHistory_Click(object sender, EventArgs e)
        {
            pnlReview.Controls.Clear();
            frmEquipmentRepairs myEquip = new frmEquipmentRepairs();
            myEquip.TopLevel = false;
            pnlReview.Controls.Add(myEquip);
            myEquip.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            myEquip.Dock = DockStyle.Fill;
            myEquip.Show();
            pnlFooter.Visible = false;
            pnlForms.Visible = false;
            pnlInstruction.Visible = false;
            pnlReview.Visible = true;
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            pnlReview.Controls.Clear();
            frmCourse mC = new frmCourse();
            mC.TopLevel = false;
            pnlReview.Controls.Add(mC);
            mC.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            mC.Dock = DockStyle.Fill;
            mC.Show();
            pnlFooter.Visible = false;
            pnlForms.Visible = false;
            pnlInstruction.Visible = false;
            pnlReview.Visible = true;
        }

        private void btnModules_Click(object sender, EventArgs e)
        {
            pnlReview.Controls.Clear();
            frmModule mForm = new frmModule();
            mForm.TopLevel = false;
            pnlReview.Controls.Add(mForm);
            mForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            mForm.Dock = DockStyle.Fill;
            mForm.Show();
            pnlFooter.Visible = false;
            pnlForms.Visible = false;
            pnlInstruction.Visible = false;
            pnlReview.Visible = true;
        }

        private void btnTutorRequests_Click(object sender, EventArgs e)
        {
            pnlReview.Controls.Clear();
            frmTutor reqT = new frmTutor();
            reqT.TopLevel = false;
            pnlReview.Controls.Add(reqT);
            reqT.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            reqT.Dock = DockStyle.Fill;
            reqT.Show();
            pnlFooter.Visible = false;
            pnlForms.Visible = false;
            pnlInstruction.Visible = false;
            pnlReview.Visible = true;
        }

        private void btnTutorReports_Click(object sender, EventArgs e)
        {
            pnlReview.Controls.Clear();
            rptTutorRequest reqT = new rptTutorRequest();
            reqT.TopLevel = false;
            pnlReview.Controls.Add(reqT);
            reqT.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            reqT.Dock = DockStyle.Fill;
            reqT.Show();
            pnlFooter.Visible = false;
            pnlForms.Visible = false;
            pnlInstruction.Visible = false;
            pnlReview.Visible = true;
        }

        private void btnRequestForm_Click(object sender, EventArgs e)
        {
            pnlReview.Controls.Clear();
            frmRequest req = new frmRequest();
            req.TopLevel = false;
            pnlReview.Controls.Add(req);
            req.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            req.Dock = DockStyle.Fill;
            req.Show();
            pnlFooter.Visible = false;
            pnlForms.Visible = false;
            pnlInstruction.Visible = false;
            pnlReview.Visible = true;
        }

        private void btnTasks_Click(object sender, EventArgs e)
        {
            pnlReview.Controls.Clear();
            frmTask myTask = new frmTask();
            myTask.TopLevel = false;
            pnlReview.Controls.Add(myTask);
            myTask.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            myTask.Dock = DockStyle.Fill;
            myTask.Show();
            pnlFooter.Visible = false;
            pnlForms.Visible = false;
            pnlInstruction.Visible = false;
            pnlReview.Visible = true;
        }

        private void btnStud_Click(object sender, EventArgs e)
        {
            pnlReview.Controls.Clear();
            frmStudent stud = new frmStudent();
            stud.TopLevel = false;
            pnlReview.Controls.Add(stud);
            stud.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            stud.Dock = DockStyle.Fill;
            stud.Show();
            pnlFooter.Visible = false;
            pnlForms.Visible = false;
            pnlInstruction.Visible = false;
            pnlReview.Visible = true;
        }

        private void btnBuilding_Click(object sender, EventArgs e)
        {
            pnlReview.Controls.Clear();
            frmBuilding build = new frmBuilding();
            build.TopLevel = false;
            pnlReview.Controls.Add(build);
            build.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            build.Dock = DockStyle.Fill;
            build.Show();
            pnlFooter.Visible = false;
            pnlForms.Visible = false;
            pnlInstruction.Visible = false;
            pnlReview.Visible = true;
        }

        private void btnDept_Click(object sender, EventArgs e)
        {
            pnlReview.Controls.Clear();
            frmDepartment Dep = new frmDepartment();
            Dep.TopLevel = false;
            pnlReview.Controls.Add(Dep);
            Dep.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Dep.Dock = DockStyle.Fill;
            Dep.Show();
            pnlFooter.Visible = false;
            pnlForms.Visible = false;
            pnlInstruction.Visible = false;
            pnlReview.Visible = true;
        }

        private void btnFloors_Click(object sender, EventArgs e)
        {
            pnlReview.Controls.Clear();
            frmFloor floor = new frmFloor();
            floor.TopLevel = false;
            pnlReview.Controls.Add(floor);
            floor.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            floor.Dock = DockStyle.Fill;
            floor.Show();
            pnlFooter.Visible = false;
            pnlForms.Visible = false;
            pnlInstruction.Visible = false;
            pnlReview.Visible = true;
        }

        private void btnVenues_Click(object sender, EventArgs e)
        {
            pnlReview.Controls.Clear();
            frmVenue mV = new frmVenue();
            mV.TopLevel = false;
            pnlReview.Controls.Add(mV);
            mV.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            mV.Dock = DockStyle.Fill;
            mV.Show();
            pnlFooter.Visible = false;
            pnlForms.Visible = false;
            pnlInstruction.Visible = false;
            pnlReview.Visible = true;
        }

        private void btnStaffs_Click(object sender, EventArgs e)
        {
            pnlReview.Controls.Clear();
            frmStaff staff = new frmStaff();
            staff.TopLevel = false;
            pnlReview.Controls.Add(staff);
            staff.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            staff.Dock = DockStyle.Fill;
            staff.Show();
            pnlFooter.Visible = false;
            pnlForms.Visible = false;
            pnlInstruction.Visible = false;
            pnlReview.Visible = true;
        }

        private void btnInspect_Click_1(object sender, EventArgs e)
        {
            pnlReview.Controls.Clear();
            frmInspection insp = new frmInspection();
            insp.TopLevel = false;
            pnlReview.Controls.Add(insp);
            insp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            insp.Dock = DockStyle.Fill;
            insp.Show();
            pnlFooter.Visible = false;
            pnlForms.Visible = false;
            pnlInstruction.Visible = false;
            pnlReview.Visible = true;
        }

        private void btnInspectDetails_Click(object sender, EventArgs e)
        {
            pnlReview.Controls.Clear();
            frmInspectionDetails inspD = new frmInspectionDetails();
            inspD.TopLevel = false;
            pnlReview.Controls.Add(inspD);
            inspD.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            inspD.Dock = DockStyle.Fill;
            inspD.Show();
            pnlFooter.Visible = false;
            pnlForms.Visible = false;
            pnlInstruction.Visible = false;
            pnlReview.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            pnlReview.Controls.Clear();
            rptForStudent search = new rptForStudent();
            search.TopLevel = false;
            pnlReview.Controls.Add(search);
            search.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            search.Dock = DockStyle.Fill;
            search.Show();
            pnlFooter.Visible = false;
            pnlForms.Visible = false;
            pnlInstruction.Visible = false;
            pnlReview.Visible = true;
        }

        private void btnSearchEquipment_Click(object sender, EventArgs e)
        {
            pnlReview.Controls.Clear();
            rptInspectionReport myEquip = new rptInspectionReport();
            myEquip.TopLevel = false;
            pnlReview.Controls.Add(myEquip);
            myEquip.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            myEquip.Dock = DockStyle.Fill;
            myEquip.Show();
            pnlFooter.Visible = false;
            pnlForms.Visible = false;
            pnlInstruction.Visible = false;
            pnlReview.Visible = true;
        }

        private void pnlFooter_MouseEnter(object sender, EventArgs e)
        {
            btnClick.BackColor = Color.Gold;
            mouseInPanel = true;
            pnlForms.Visible = true;
            pnlFooter.Visible = true;
            pnlInstruction.Visible = true;
            pnlReview.Visible = false;
        }

        private void pnlFooter_MouseLeave(object sender, EventArgs e)
        {
            btnClick.BackColor = Color.Transparent;
            mouseInPanel = false;
            hideTimer.Start();
        }

        private void pnlInstruction_MouseEnter(object sender, EventArgs e)
        {
            btnClick.BackColor = Color.Gold;
            mouseInPanel = true;
            pnlForms.Visible = true;
            pnlFooter.Visible = true;
            pnlInstruction.Visible = true;
            pnlReview.Visible = false;
        }

        private void pnlInstruction_MouseLeave(object sender, EventArgs e)
        {
            btnClick.BackColor = Color.Transparent;
            mouseInPanel = false;
            hideTimer.Start();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin.dtLog = null;
            frmLogin log = new frmLogin();
            log.Show();
            this.Hide();
        }

        private void pnlHeaderLogo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(ClientSize.Width - cGrip, ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, BackColor, rc);
        }
        protected override void WndProc(ref Message m)
        {
            if(m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToScreen(pos);
                if(pos.X >= ClientSize.Width - cGrip && pos.Y >= ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }
        private void btn1_MouseEnter(object sender, EventArgs e)
        {
            btn1.BackColor = Color.Gold;
            btn1.ForeColor = Color.White;
        }

        private void btn2_MouseEnter(object sender, EventArgs e)
        {
            btn2.BackColor = Color.Gold;
            btn2.ForeColor = Color.White;
        }

        private void btn3_MouseEnter(object sender, EventArgs e)
        {
            btn3.BackColor = Color.Gold;
            btn3.ForeColor = Color.White;
        }

        private void btn3_MouseLeave(object sender, EventArgs e)
        {
            btn3.BackColor = Color.Tan;
        }

        private void btn2_MouseLeave(object sender, EventArgs e)
        {
            btn2.BackColor = Color.Tan;
        }

        private void btn1_MouseLeave(object sender, EventArgs e)
        {
            btn1.BackColor = Color.Tan;
        }

        private void btnLogout_MouseHover(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.Transparent;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pnlReview.Controls.Clear();
            rptEquipmentHistoryReport inspD = new rptEquipmentHistoryReport();
            inspD.TopLevel = false;
            pnlReview.Controls.Add(inspD);
            inspD.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            inspD.Dock = DockStyle.Fill;
            inspD.Show();
            pnlFooter.Visible = false;
            pnlForms.Visible = false;
            pnlInstruction.Visible = false;
            pnlReview.Visible = true;
        }

        private void btnReports_MouseEnter(object sender, EventArgs e)
        {
            btnClick.BackColor = Color.Gold;
            btnReports.BackColor = Color.Transparent;
            mouseInPanel = true;
            this.pnlForms.Visible = true;
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            pnlReview.Controls.Clear();
            rptMainForm reportMain = new rptMainForm();
            reportMain.TopLevel = false;
            pnlReview.Controls.Add(reportMain);
            reportMain.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            reportMain.Dock = DockStyle.Fill;
            reportMain.Show();
            pnlFooter.Visible = false;
            pnlForms.Visible = false;
            pnlInstruction.Visible = false;
            pnlReview.Visible = true;
        }

        private void btnReports_MouseLeave(object sender, EventArgs e)
        {
            btnReports.BackColor = Color.Gold;
        }
    }
}

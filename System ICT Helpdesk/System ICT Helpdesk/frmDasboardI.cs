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
    public partial class frmDasboardI : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private const int cGrip = 16;

        private Timer hideTimer;
        private bool mouseInPanel;
        public frmDasboardI(string referenc)
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
        }
        private void frmDasboardI_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
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
        private void btnEquipment_MouseEnter(object sender, EventArgs e)
        {
            btnEquipment.BackColor = Color.Gold;
            pnlReview.Controls.Clear();
            frmEquipment myEquip = new frmEquipment();
            myEquip.TopLevel = false;
            pnlReview.Controls.Add(myEquip);
            myEquip.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            myEquip.Dock = DockStyle.Fill;
            myEquip.Visible = true;
        }
        private void btnEquipment_MouseLeave(object sender, EventArgs e)
        {
            btnEquipment.BackColor = Color.Transparent;
            hideTimer.Start();
        }

        private void btnEquipmentType_MouseEnter(object sender, EventArgs e)
        {
            btnEquipmentType.BackColor = Color.Gold;
            pnlReview.Controls.Clear();
            frmEquipmentType myEquip = new frmEquipmentType();
            myEquip.TopLevel = false;
            pnlReview.Controls.Add(myEquip);
            myEquip.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            myEquip.Dock = DockStyle.Fill;
            myEquip.Visible = true;
        }

        private void btnEquipmentType_MouseLeave(object sender, EventArgs e)
        {
            btnEquipmentType.BackColor = Color.Transparent;
            hideTimer.Start();
        }

        private void btnEquipmentHistory_MouseEnter(object sender, EventArgs e)
        {
            btnEquipmentHistory.BackColor = Color.Gold;
            pnlReview.Controls.Clear();
            frmEquipmentRepairs myEquip = new frmEquipmentRepairs();
            myEquip.TopLevel = false;
            pnlReview.Controls.Add(myEquip);
            myEquip.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            myEquip.Dock = DockStyle.Fill;
            myEquip.Visible = true;
        }

        private void btnEquipmentHistory_MouseLeave(object sender, EventArgs e)
        {
            btnEquipmentHistory.BackColor = Color.Transparent;
            hideTimer.Start();
        }

        private void btnTasks_MouseEnter(object sender, EventArgs e)
        {
            btnTasks.BackColor = Color.Gold;
            pnlReview.Controls.Clear();
            frmTask task = new frmTask();
            task.TopLevel = false;
            pnlReview.Controls.Add(task);
            task.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            task.Dock = DockStyle.Fill;
            task.Visible = true;
        }

        private void btnInspect_MouseEnter(object sender, EventArgs e)
        {
            btnInspect.BackColor = Color.Gold;
            pnlReview.Controls.Clear();
            frmInspection inspect = new frmInspection();
            inspect.TopLevel = false;
            pnlReview.Controls.Add(inspect);
            inspect.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            inspect.Dock = DockStyle.Fill;
            inspect.Visible = true;
        }

        private void btnInspectDetails_MouseHover(object sender, EventArgs e)
        {
            btnInspectDetails.BackColor = Color.Gold;
            pnlReview.Controls.Clear();
            frmInspectionDetails inspect = new frmInspectionDetails();
            inspect.TopLevel = false;
            pnlReview.Controls.Add(inspect);
            inspect.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            inspect.Dock = DockStyle.Fill;
            inspect.Visible = true;
        }
        private void btnTasks_MouseLeave(object sender, EventArgs e)
        {
            btnTasks.BackColor = Color.Transparent;
            hideTimer.Start();
        }

        private void btnInspect_MouseLeave(object sender, EventArgs e)
        {
            btnInspect.BackColor = Color.Transparent;
            hideTimer.Start();
        }

        private void btnInspectDetails_MouseLeave(object sender, EventArgs e)
        {
            btnInspectDetails.BackColor = Color.Transparent;
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
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToScreen(pos);
                if (pos.X >= ClientSize.Width - cGrip && pos.Y >= ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }
    }
}

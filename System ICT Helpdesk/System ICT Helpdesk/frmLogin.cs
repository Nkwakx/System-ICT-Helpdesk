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
using System.Runtime.InteropServices;

namespace System_ICT_Helpdesk
{
    public partial class frmLogin : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public static DataTable dtLog = null;

        private const int cGrip = 16;
        public frmLogin()
        {
            InitializeComponent();
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
        }
        BLL bll = new BLL();
        Staff mS = new Staff();

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = frmLogin.dtLog;

            mS.StaffNumber = txtUserName.Text;
            mS.Password = txtPassword.Text;

            dt = bll.LoginDetails(txtUserName.Text, txtPassword.Text);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["StaffType"].ToString() == "Lab Manager")
                    {

                        this.Hide();
                        frmDashboardM myDashBx = new frmDashboardM(dt.Rows[0]["FirstName"].ToString() + ", " + dt.Rows[0]["LastName"].ToString() + "(" + dt.Rows[0]["StaffType"].ToString() + ")");
                        myDashBx.Show();
                    }
                    else if (dt.Rows[i]["StaffType"].ToString() == "Intern")
                    {
                        this.Hide();
                        frmDasboardI myDashB = new frmDasboardI(dt.Rows[0]["FirstName"].ToString() + ", " + dt.Rows[0]["LastName"].ToString() + "(" + dt.Rows[0]["StaffType"].ToString() + ")");
                        myDashB.Show();
                    }
                    else
                    {
                        MessageBox.Show("Your Username And Password Doesn't Correspond With This Type", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (txtUserName.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Username To Login", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtPassword.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Password To Login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Your Username or Password is incorrect", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void chkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPassword ps = new frmPassword();
            ps.Show();
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbxMax_Click(object sender, EventArgs e)
        {
            if(WindowState != FormWindowState.Maximized)
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

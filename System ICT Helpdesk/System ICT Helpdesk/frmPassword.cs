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

namespace System_ICT_Helpdesk
{
    public partial class frmPassword : Form
    {
        public frmPassword()
        {
            InitializeComponent();
        }
        BLL bll = new BLL();
        Staff pin = new Staff();
        private void btnSend_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            pin.UserName = txtUsername.Text;
            pin.IDNumber = txtIDNumber.Text;
            dt = bll.Login(txtUsername.Text, txtIDNumber.Text);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    MessageBox.Show("You Password is " + dt.Rows[i]["Password"].ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    frmLogin log = new frmLogin();
                    log.Show();
                }
            }
            else
            {
                if (txtUsername.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Username You Are Registered With", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtIDNumber.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your ID Number", "Empty ID Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Your Username or ID Number is incorrect, Make Sure You Are Registered", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

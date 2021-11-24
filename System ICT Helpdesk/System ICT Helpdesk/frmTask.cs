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
    public partial class frmTask : Form
    {
        private bool mouseInPanel;
        private Timer hideTimer;
        public frmTask()
        {
            InitializeComponent();
            hideTimer = new Timer { Interval = 100 };
            hideTimer.Tick += hidePanel;
        }
        BLL myB = new BLL();
        Tasks myT = new Tasks();

        private void hidePanel(object sender, EventArgs e)
        {
            hideTimer.Stop();
            if (!mouseInPanel) this.pnlButtons.Visible = true;
        }
        private void frmTask_Load(object sender, EventArgs e)
        {
            
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
            dgvTask.Visible = true;
            mouseInPanel = true;
            Display();
        }
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtTaskDesc.Text)))
            {
                myT.TaskDescription = txtTaskDesc.Text;

                myB.InsertTask(myT);
                Display();
                txtTaskDesc.Clear();
            }
            else
            {
                MessageBox.Show("All Field Required, Double Check If There's No Empty Fields", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Display()
        {
            dgvTask.DataSource = myB.GetTask();
        }

        private void txtTaskDesc_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTaskDesc.Text))
            {
                errorProvider1.SetError(txtTaskDesc, "Task Description Required");
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
            Bitmap bm = new Bitmap(this.dgvTask.Width, this.dgvTask.Height);

            dgvTask.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvTask.Width, this.dgvTask.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
        private void printDocument_PrintPages(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int height = dgvTask.Height;
            dgvTask.Height = dgvTask.RowCount * dgvTask.RowTemplate.Height;
            Bitmap bm = new Bitmap(this.dgvTask.Width, this.dgvTask.Height);

            dgvTask.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvTask.Width, this.dgvTask.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            dgvTask.Height = height;
        }
    }
}

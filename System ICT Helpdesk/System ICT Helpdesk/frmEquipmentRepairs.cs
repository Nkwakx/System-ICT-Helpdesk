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
    public partial class frmEquipmentRepairs : Form
    {
        private bool mouseInPanel;
        private Timer hideTimer;
        public frmEquipmentRepairs()
        {
            InitializeComponent();

            hideTimer = new Timer { Interval = 100 };
            hideTimer.Tick += hidePanel;
        }
        BLL bll = new BLL();
        EquipmentHistory myEqH = new EquipmentHistory();
        private void hidePanel(object sender, EventArgs e)
        {
            hideTimer.Stop();
            if (!mouseInPanel) this.pnlButtons.Visible = true;
        }
        private void BbtnAddEquipmentHostory_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(cmbRepairDesc.Text)) || string.IsNullOrEmpty(dteFixedDate.Text) ||
               string.IsNullOrEmpty(cmbEquipName.SelectedValue.ToString()))
            {
                myEqH.EquipHistoryDate = dteFixedDate.Text;
                myEqH.HistoryDescription = cmbRepairDesc.Text;
                myEqH.EquipmentID = int.Parse(cmbEquipName.SelectedValue.ToString());

                int x = bll.InsertEquipmentHistory(myEqH);
                if (x > 0)
                {
                    MessageBox.Show("Your Data Successfully Added");
                    Display();
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
            dgvEquipHistory.DataSource = bll.GetEquipmentHistory();
        }

        private void btnList_MouseEnter(object sender, EventArgs e)
        {
            btnList.BackColor = Color.Gold;
            dgvEquipHistory.Visible = true;
            Display();
            mouseInPanel = true;
        }

        private void btnList_MouseLeave(object sender, EventArgs e)
        {
            btnList.BackColor = Color.Transparent;
            mouseInPanel = false;
            hideTimer.Start();
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.Gold;
            mouseInPanel = true;
            pnlBtn.Visible = true;
            pnlAdd.Visible = true;
            dgvEquipHistory.Visible = true;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.Transparent;
            mouseInPanel = false;
            hideTimer.Start();
        }

        private void frmEquipmentHistory_Load(object sender, EventArgs e)
        {
            cmbEquipName.DataSource = bll.GetEquipment();
            cmbEquipName.DisplayMember = "EquipmentDescription";
            cmbEquipName.ValueMember = "EquipmentID";

            
            cmbRepairDesc.Items.Add("Broken");
            cmbRepairDesc.Items.Add("In For Repair");
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
            Bitmap bm = new Bitmap(this.dgvEquipHistory.Width, this.dgvEquipHistory.Height);

            dgvEquipHistory.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvEquipHistory.Width, this.dgvEquipHistory.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
        private void printDocument_PrintPages(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int height = dgvEquipHistory.Height;
            dgvEquipHistory.Height = dgvEquipHistory.RowCount * dgvEquipHistory.RowTemplate.Height;
            Bitmap bm = new Bitmap(this.dgvEquipHistory.Width, this.dgvEquipHistory.Height);

            dgvEquipHistory.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvEquipHistory.Width, this.dgvEquipHistory.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            dgvEquipHistory.Height = height;
        }
    }
}

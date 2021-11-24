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
    public partial class frmFloor : Form
    {
        private bool mouseInPanel;
        private Timer hideTimer;
        public frmFloor()
        {
            InitializeComponent();
            hideTimer = new Timer { Interval = 100 };
            hideTimer.Tick += hidePanel;
        }
        BLL myBll = new BLL();
        Floor myF = new Floor();

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
            dgvFloor.Visible = true;
            mouseInPanel = true;
            Display();
        }
        private void btnAddFloor_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtFloor.Text) || string.IsNullOrEmpty(cmbBuilding.Text)))
            {
                myF.FloorName = txtFloor.Text;
                myF.BuildingID = int.Parse(cmbBuilding.SelectedValue.ToString());

                int x = myBll.InsertFloor(myF);
                if (x > 0)
                {
                    MessageBox.Show("Your Data Successfully Added");
                    Display();
                    txtFloor.Clear();
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
            dgvFloor.DataSource = myBll.GetFloor();
        }

        private void frmFloor_Load(object sender, EventArgs e)
        {
            cmbBuilding.DataSource = myBll.GetBuilding();
            cmbBuilding.ValueMember = "BuildingID";
            cmbBuilding.DisplayMember = "BuildingName";
        }

        private void txtFloor_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFloor.Text))
            {
                errorProvider1.SetError(txtFloor, "Please Enter A Floor Name/Number");
            }
        }

        private void cmbBuilding_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmbBuilding.Text))
            {
                errorProvider1.SetError(cmbBuilding, "Please Select From The Combobox");
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
            Bitmap bm = new Bitmap(this.dgvFloor.Width, this.dgvFloor.Height);

            dgvFloor.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvFloor.Width, this.dgvFloor.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
        private void printDocument_PrintPages(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int height = dgvFloor.Height;
            dgvFloor.Height = dgvFloor.RowCount * dgvFloor.RowTemplate.Height;
            Bitmap bm = new Bitmap(this.dgvFloor.Width, this.dgvFloor.Height);

            dgvFloor.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvFloor.Width, this.dgvFloor.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            dgvFloor.Height = height;
        }
    }
}

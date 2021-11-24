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
    public partial class frmVenue : Form
    {
        private bool mouseInPanel;
        private Timer hideTimer;
        public frmVenue()
        {
            InitializeComponent();
            hideTimer = new Timer { Interval = 100 };
            hideTimer.Tick += hidePanel;
        }
        BLL myBll = new BLL();
        Venue myV = new Venue();


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

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            btnList.BackColor = Color.Transparent;
            mouseInPanel = false;
            hideTimer.Start();
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            btnList.BackColor = Color.Gold;
            dgvVenue.Visible = true;
            mouseInPanel = true;
            Display();
        }
        private void btnAddVenue_Click(object sender, EventArgs e)
        {
            myV.VenueCode = txtVenueCode.Text;
            myV.VenueCapacity = int.Parse(txtVenueCapacity.Text.ToString());
            myV.FloorID = int.Parse(cmbFloorName.SelectedValue.ToString());
            myV.BuildingID = int.Parse(cmbBuildingName.SelectedValue.ToString());

            if (string.IsNullOrEmpty(txtVenueCapacity.Text) || string.IsNullOrEmpty(cmbBuildingName.SelectedValue.ToString()) || string.IsNullOrEmpty(cmbFloorName.SelectedValue.ToString()))
            {
                MessageBox.Show("All Field Required, Double Check If There's No Empty Fields", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int x = myBll.InsertVenue(myV);
                if (x > 0)
                {
                    MessageBox.Show("Your Data Successfully Added", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Display();
                    txtVenueCode.Clear();
                    txtVenueCapacity.Clear();
                }
                else
                {
                    MessageBox.Show("unfortunately Data Wasn't Successful", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public void Display()
        {
            dgvVenue.DataSource = myBll.GetVenue();
        }

        private void frmVenue_Load(object sender, EventArgs e)
        {
            cmbFloorName.DataSource = myBll.GetFloor();
            cmbFloorName.DisplayMember = "FloorName";
            cmbFloorName.ValueMember = "FloorID";

            cmbBuildingName.DataSource = myBll.GetBuilding();
            cmbBuildingName.DisplayMember = "BuildingName";
            cmbBuildingName.ValueMember = "BuildingID";
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void txtVenueCode_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtVenueCode.Text))
            {
                errorProvider1.SetError(txtVenueCode, "Please Enter Venue Code");
            }
        }

        private void txtVenueCapacity_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtVenueCapacity.Text))
            {
                errorProvider1.SetError(txtVenueCapacity, "Require Valid Capacity Number");
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
            Bitmap bm = new Bitmap(this.dgvVenue.Width, this.dgvVenue.Height);

            dgvVenue.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvVenue.Width, this.dgvVenue.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
        private void printDocument_PrintPages(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int height = dgvVenue.Height;
            dgvVenue.Height = dgvVenue.RowCount * dgvVenue.RowTemplate.Height;
            Bitmap bm = new Bitmap(this.dgvVenue.Width, this.dgvVenue.Height);

            dgvVenue.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvVenue.Width, this.dgvVenue.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            dgvVenue.Height = height;
        }
    }
}

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
using DataAccessLayer;
using BusinessLogicLayer;
using System.Drawing.Printing;

namespace System_ICT_Helpdesk
{
    public partial class frmEquipment : Form
    {
        private bool mouseInPanel;
        private Timer hideTimer;
        public frmEquipment()
        {
            InitializeComponent();
            hideTimer = new Timer { Interval = 100 };
            hideTimer.Tick += hidePanel;
        }
        BLL myBll = new BLL();
        Equipment equip = new Equipment();
        private void hidePanel(object sender, EventArgs e)
        {
            hideTimer.Stop();
            if (!mouseInPanel) this.pnlMidDisplay.Visible = true;
        }
        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            pnlMidDisplay.Visible = true;
            pnlAddEqui.Visible = true;
            pnlDeletes.Visible = false;
        }
        private void btnAddEquipmentInfo_Click_1(object sender, EventArgs e)
        {

            if (!(string.IsNullOrEmpty(txtBarcode.Text) || string.IsNullOrEmpty(txtEquipDesc.Text) || string.IsNullOrEmpty(cmbVenueCode.SelectedValue.ToString())
                    || string.IsNullOrEmpty(dteDateR.Text)))
            {

                equip.Barcode = txtBarcode.Text;
                equip.EquipmentDescription = txtEquipDesc.Text;
                equip.DateRecieved = dteDateR.Text;
                equip.EquipmentTypeID = int.Parse(cmbEquipType.SelectedValue.ToString());
                equip.VenueID = int.Parse(cmbVenueCode.SelectedValue.ToString());
                equip.EquipmentStatus = "Active";
                equip.YearsValid = int.Parse(txtValidYear.Text);

                int x = myBll.InsertEquipment(equip);
                if (x > 0)
                {
                    MessageBox.Show("Your Data Successfully Added");
                    dgvEquipment.Visible = true;
                    Display();
                    txtBarcode.Clear();
                    txtEquipDesc.Clear();
                    txtEquipDesc.Clear();
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
            dgvEquipment.DataSource = myBll.GetEquipment();
        }

        private void btnListEquipment_Click(object sender, EventArgs e)
        {
            dgvEquipment.Visible = true;
            Display();
        }
        private void dgvEquipment_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = new DataTable();
            pnlDeletes.Visible = true;
            pnlMidDisplay.Visible = true;
            pnlAddEqui.Visible = false;
            try
            {
                if (dgvEquipment.SelectedRows.Count > 0)
                {
                    dt = myBll.GetEquipmentByEquipmentID(int.Parse(dgvEquipment.SelectedRows[0].Cells["EquipmentID"].Value.ToString()));
                    
                    lblEquipCode.Text = dt.Rows[0]["EquipmentID"].ToString();
                    lblEquipDescription.Text = dt.Rows[0]["EquipmentDescription"].ToString();
                    lblVenueCode.Text = dt.Rows[0]["VenueCode"].ToString();
                    lblEquipmentStatus.Text = dt.Rows[0]["EquipmentStatus"].ToString();
                    lblYearsVALID.Text = dt.Rows[0]["YearsValid"].ToString();
                }
            }
            catch
            {
                MessageBox.Show("Invalid Selection");
            }
        }

        private void btnSoftDeleteEquip_Click(object sender, EventArgs e)
        {
            Equipment equip = new Equipment();
            equip.EquipmentID = int.Parse(lblEquipCode.Text);
            equip.EquipmentStatus = "In-Active";

            int x = myBll.UpdateEquipment(equip);
            if (x > 0)
            {
                MessageBox.Show("Update Was Successful");
                Display();
                dgvEquipment.Visible = true;
                pnlDeletes.Visible = false;
            }
            else
            {
                MessageBox.Show("Update Wasn't Successful");
            }
        }

        private void btnHardDeleteEquip_Click(object sender, EventArgs e)
        {
            Equipment equip = new Equipment();
            equip.EquipmentID = int.Parse(lblEquipCode.Text);
            myBll.GetDeleteEquip(equip.EquipmentID);
            dgvEquipment.DataSource = myBll.GetEquipment();
        }

        private void btnAddEquipment_MouseHover(object sender, EventArgs e)
        {
            btnAddEquipment.BackColor = Color.Violet;
            mouseInPanel = true;
            pnlMidDisplay.Visible = true;
            pnlAddEqui.Visible = true;
            pnlDeletes.Visible = false;
        }

        private void btnAddEquipment_MouseLeave(object sender, EventArgs e)
        {
            btnAddEquipment.BackColor = Color.Transparent;
            mouseInPanel = false;
            hideTimer.Start();
        }

        private void btnListEquipment_MouseLeave(object sender, EventArgs e)
        {
            btnListEquipment.BackColor = Color.Transparent;
            mouseInPanel = false;
            hideTimer.Start();
        }
        
        private void btnListEquipment_MouseEnter(object sender, EventArgs e)
        {
            btnListEquipment.BackColor = Color.Violet;
            dgvEquipment.Visible = true;
            Display();
            mouseInPanel = true;
        }

        private void frmEquipment_Load(object sender, EventArgs e)
        {
            cmbVenueCode.DataSource = myBll.GetVenue();
            cmbVenueCode.DisplayMember = "VenueCode";
            cmbVenueCode.ValueMember = "VenueID";

            cmbEquipType.DataSource = myBll.GetEquipmentType();
            cmbEquipType.DisplayMember = "EquipmentTypeName";
            cmbEquipType.ValueMember = "EquipmentTypeID";
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
            Bitmap bm = new Bitmap(this.dgvEquipment.Width, this.dgvEquipment.Height);

            dgvEquipment.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvEquipment.Width, this.dgvEquipment.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
        private void printDocument_PrintPages(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int height = dgvEquipment.Height;
            dgvEquipment.Height = dgvEquipment.RowCount * dgvEquipment.RowTemplate.Height;
            Bitmap bm = new Bitmap(this.dgvEquipment.Width, this.dgvEquipment.Height);

            dgvEquipment.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvEquipment.Width, this.dgvEquipment.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            dgvEquipment.Height = height;
        }
    }
}

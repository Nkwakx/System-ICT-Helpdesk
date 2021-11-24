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
    public partial class frmInspectionDetails : Form
    {
        private bool mouseInPanel;
        private Timer hideTimer;
        public frmInspectionDetails()
        {
            InitializeComponent();
            hideTimer = new Timer { Interval = 100 };
            hideTimer.Tick += hidePanel;
        }
        BLL bll = new BLL();
        InspectionDetails mIn = new InspectionDetails();

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
            pnlControl.Visible = true;
            pnlUpdate.Visible = false;
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
            dgvInspectionDetails.Visible = true;
            mouseInPanel = true;
            Display();
        }
        private void addInspectionDetails_Click(object sender, EventArgs e)
        {
            mIn.InspectionID = int.Parse(cmbInspectionCode.SelectedValue.ToString());
            mIn.StaffID = int.Parse(cmbStaffType.SelectedValue.ToString());
            mIn.EquipmentID = int.Parse(cmbEquipment.SelectedValue.ToString());
            mIn.InspecDate = dteDate.Text;
            mIn.FaultComment = txtFaultComment.Text;
            mIn.Status = "Open";

            if (string.IsNullOrEmpty(txtFaultComment.Text))
            {
                MessageBox.Show("All Field Required, Double Check If There's No Empty Fields", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int x = bll.InsertInspectionDetails(mIn);
                MessageBox.Show("Your Data Successfully Added");
                if (x > 0)
                {
                    Display();
                    txtFaultComment.Clear();
                    txtStatus.Clear();
                }
                else
                {
                    MessageBox.Show("unfortunately Data Wasn't Successful");
                }
            }
        }
        public void Display()
        {
            dgvInspectionDetails.DataSource = bll.GetInspectionDetails();
        }

        private void frmInspectionDetails_Load(object sender, EventArgs e)
        {
            cmbStaffType.DataSource = bll.GetStaffInspection();
            cmbStaffType.DisplayMember = "LastName";
            cmbStaffType.ValueMember = "StaffID";
            
            cmbInspectionCode.DataSource = bll.GetInspection();
            cmbInspectionCode.ValueMember = "InspectionID";
            
            cmbEquipment.DataSource = bll.GetEquipment();
            cmbEquipment.DisplayMember = "EquipmentDescription";
            cmbEquipment.ValueMember = "EquipmentID";
        }
        private void dgvInspectionDetails_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {

                pnlControl.Visible = false;
                pnlUpdate.Visible = true;
                if (dgvInspectionDetails.SelectedRows.Count > 0)
                {
                    dt = bll.GetInspectionDetailsByInspectionDetailsID(int.Parse(dgvInspectionDetails.SelectedRows[0].Cells["InspectionDetailsID"].Value.ToString()));
                    if (dt.Columns.Contains("Address"))
                    {
                        cmbEquipment.SelectedValue = int.Parse(dt.Rows[0]["InspectionID"].ToString());
                        cmbInspectionCode.SelectedValue = int.Parse(dt.Rows[0]["EquipmentID"].ToString());
                        cmbStaffType.SelectedValue = int.Parse(dt.Rows[0]["StaffID"].ToString());
                    }
                    lblStatuss.Text = dt.Rows[0]["Status"].ToString();
                    lblFaultComment.Text = dt.Rows[0]["FaultComment"].ToString();

                }
            }
            catch
            {
                MessageBox.Show("Invalid Selection");
            }
        }
        private void btnSoftDelete_Click(object sender, EventArgs e)
        {

            InspectionDetails inspD = new InspectionDetails();
            inspD.InspectionDetailsID = int.Parse(dgvInspectionDetails.SelectedRows[0].Cells["InspectionDetailsID"].Value.ToString());
            inspD.Status = "Closed";
            int x = bll.UpdateInspectionDetails(inspD);

            if (x > 0)
            {
                MessageBox.Show("Update Was Successful");
                Display();
                dgvInspectionDetails.Visible = true;
                pnlUpdate.Visible = false;
            }
            else
            {
                MessageBox.Show("Update Wasn't Successful");
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
            Bitmap bm = new Bitmap(this.dgvInspectionDetails.Width, this.dgvInspectionDetails.Height);

            dgvInspectionDetails.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvInspectionDetails.Width, this.dgvInspectionDetails.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
        private void printDocument_PrintPages(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int height = dgvInspectionDetails.Height;
            dgvInspectionDetails.Height = dgvInspectionDetails.RowCount * dgvInspectionDetails.RowTemplate.Height;
            Bitmap bm = new Bitmap(this.dgvInspectionDetails.Width, this.dgvInspectionDetails.Height);

            dgvInspectionDetails.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvInspectionDetails.Width, this.dgvInspectionDetails.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            dgvInspectionDetails.Height = height;
        }
    }
}

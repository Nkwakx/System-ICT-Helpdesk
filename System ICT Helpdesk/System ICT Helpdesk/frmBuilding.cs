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
using System.Data.SqlClient;
using System.Drawing.Printing;

namespace System_ICT_Helpdesk
{
    public partial class frmBuilding : Form
    {
        private bool mouseInPanel;
        private Timer hideTimer;
        public frmBuilding()
        {
            InitializeComponent();
            hideTimer = new Timer { Interval = 100 };
            hideTimer.Tick += hidePanel;
        }
        BLL myBll = new BLL();
        Building myBd = new Building();
        DataTable dt = new DataTable();

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
            dgvBuilding.Visible = true;
            mouseInPanel = true;
            Display();
        }
        private void btnAddBuilding_Click(object sender, EventArgs e)
        {
            try
            {
                dt = myBll.ValidationCheckBuilding(txtBuildingName.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show(txtBuildingName.Text + " Already Exist, Please Enter A Unique Building Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    myBd.BuildingName = txtBuildingName.Text;
                    if (!(string.IsNullOrEmpty(txtBuildingName.Text)))
                    {
                        int x = myBll.InsertBuilding(myBd);
                        if (x > 0)
                        {
                            MessageBox.Show("Your Data Successfully Added");

                            Display();
                            txtBuildingName.Clear();
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
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }
        public void Display()
        {
            dgvBuilding.DataSource = myBll.GetBuilding();
        }

        private void txtBuildingName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuildingName.Text))
            {
                errorProvider1.SetError(txtBuildingName, "Please Enter Your Staff Number To Continnue");
            }
        }
        
        private void dgvBuilding_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPrint_MouseHover(object sender, EventArgs e)
        {
            lblPrinter.Visible = true;
            lblPrinter.Text = "Print";
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
            Bitmap bm = new Bitmap(this.dgvBuilding.Width, this.dgvBuilding.Height);

            dgvBuilding.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvBuilding.Width, this.dgvBuilding.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
        private void printDocument_PrintPages(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int height = dgvBuilding.Height;
            dgvBuilding.Height = dgvBuilding.RowCount * dgvBuilding.RowTemplate.Height;
            Bitmap bm = new Bitmap(this.dgvBuilding.Width, this.dgvBuilding.Height);

            dgvBuilding.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvBuilding.Width, this.dgvBuilding.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            dgvBuilding.Height = height;
        }

        private void btnPrint_MouseLeave(object sender, EventArgs e)
        {
            lblPrinter.Visible = false;
        }

        private void lblPrinter_Click(object sender, EventArgs e)
        {

        }
    }
}

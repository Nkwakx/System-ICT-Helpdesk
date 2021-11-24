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
    public partial class frmEquipmentType : Form
    {
        private bool mouseInPanel;
        private Timer hideTimer;
        public frmEquipmentType()
        {
            InitializeComponent();
            hideTimer = new Timer { Interval = 100 };
            hideTimer.Tick += hidePanel;
        }
        BLL myBll = new BLL();
        EquipmentType eq = new EquipmentType();
        private void hidePanel(object sender, EventArgs e)
        {
            hideTimer.Stop();
            if (!mouseInPanel) this.pnlAddEquipType.Visible = true;
        }
        private void btnAddEquipType_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtEquipType.Text)))
            {
                eq.EquipmentTypeName = txtEquipType.Text;

                int c = myBll.InsertEquipmentType(eq);
                if (c > 0)
                {
                    MessageBox.Show("Your Data Successfully Added");
                    Display();
                    txtEquipType.Clear();
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
            dgvEquipmentType.DataSource = myBll.GetEquipmentType();
        }

        private void btnAddEquipmentType_MouseEnter(object sender, EventArgs e)
        {
            btnAddEquipmentType.BackColor = Color.Gold;
            mouseInPanel = true;
            pnlAddEquipType.Visible = true;
            dgvEquipmentType.Visible = true;
        }

        private void btnAddEquipmentType_MouseLeave(object sender, EventArgs e)
        {
            btnAddEquipmentType.BackColor = Color.Transparent;
            mouseInPanel = false;
            hideTimer.Start();
        }

        private void btnListEquipment_MouseEnter(object sender, EventArgs e)
        {
            btnListEquipment.BackColor = Color.Gold;
            dgvEquipmentType.Visible = true;
            Display();
            mouseInPanel = true;
        }

        private void btnListEquipment_MouseLeave(object sender, EventArgs e)
        {
            btnListEquipment.BackColor = Color.Transparent;
            mouseInPanel = false;
            hideTimer.Start();
        }

        private void frmEquipmentType_Load(object sender, EventArgs e)
        {
           
        }

        private void btnUpdateEqupmentType_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            EquipmentType eq = new EquipmentType(int.Parse(dgvEquipmentType.SelectedRows[0].Cells["EquipmentTypeID"].Value.ToString()), txtEquipType.Text);
            int x = myBll.UpdateEquipmentType(eq);
            if (x > 0)
            {
                MessageBox.Show("Update Was Successful");
                Display();
                txtEquipType.Clear();
            }
            else
            {
                MessageBox.Show("Update Wasn't Successful");
            }
        }

        private void dgvEquipType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvEquipmentType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = new DataTable();
            try
            { 
                if (dgvEquipmentType.SelectedRows.Count > 0)
                {
                    dt = myBll.GetEquipTypeByEquipmentTypeID(int.Parse(dgvEquipmentType.SelectedRows[0].Cells["EquipmentTypeID"].Value.ToString()));

                    txtEquipType.Text = dt.Rows[0]["EquipmentTypeName"].ToString();
                }
            }
            catch
            {
                MessageBox.Show("Invalid Selection");
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
            Bitmap bm = new Bitmap(this.dgvEquipmentType.Width, this.dgvEquipmentType.Height);

            dgvEquipmentType.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvEquipmentType.Width, this.dgvEquipmentType.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
        private void printDocument_PrintPages(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int height = dgvEquipmentType.Height;
            dgvEquipmentType.Height = dgvEquipmentType.RowCount * dgvEquipmentType.RowTemplate.Height;
            Bitmap bm = new Bitmap(this.dgvEquipmentType.Width, this.dgvEquipmentType.Height);

            dgvEquipmentType.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvEquipmentType.Width, this.dgvEquipmentType.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            dgvEquipmentType.Height = height;
        }
    }
}

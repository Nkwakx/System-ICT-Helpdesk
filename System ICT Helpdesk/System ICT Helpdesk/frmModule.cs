using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DataAccessLayer;
using BusinessLogicLayer;
using System.Drawing.Printing;


namespace System_ICT_Helpdesk
{
    public partial class frmModule : Form
    {
        private bool mouseInPanel;
        private Timer hideTimer;
        public frmModule()
        {
            InitializeComponent();
            hideTimer = new Timer { Interval = 100 };
            hideTimer.Tick += hidePanel;
        }
        BLL bll = new BLL();
        Module md = new Module();

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
            dgvModule.Visible = true;
            mouseInPanel = true;
            Display();
        }
        private void btnAddModule_Click_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = bll.ValidationCheckModule(txtModuleCode.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show(txtModuleCode.Text + " Already Exist, Please Enter A Unique Module Code", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (string.IsNullOrEmpty(txtModuleCode.Text) || string.IsNullOrEmpty(txtModuleDesc.Text))
                    {
                        MessageBox.Show("All Field Required, Double Check If There's No Empty Fields", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        md.ModuleCode = txtModuleCode.Text;
                        md.ModuleDescription = txtModuleDesc.Text;
                        md.CourseCode = int.Parse(cmbCourseDesc.SelectedValue.ToString());

                        int c = bll.InsertModule(md);

                        Display();
                        txtModuleDesc.Clear();
                        txtModuleCode.Clear();

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
            dgvModule.DataSource = bll.GetModule();
        }

        private void frmModule_Load(object sender, EventArgs e)
        {
            Display();
            cmbCourseDesc.DataSource = bll.GetCourse();
            cmbCourseDesc.DisplayMember = "CourseDescription";
            cmbCourseDesc.ValueMember = "CourseCode";
        }

        private void txtModuleCode_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtModuleCode.Text))
            {
                errorProvider1.SetError(txtModuleCode, "Please Enter A Module Code");
            }
        }

        private void txtModuleDesc_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmbCourseDesc.Text))
            {
                errorProvider1.SetError(cmbCourseDesc, "Please Select From The Combobox");
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
            Bitmap bm = new Bitmap(this.dgvModule.Width, this.dgvModule.Height);

            dgvModule.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvModule.Width, this.dgvModule.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
        private void printDocument_PrintPages(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int height = dgvModule.Height;
            dgvModule.Height = dgvModule.RowCount * dgvModule.RowTemplate.Height;
            Bitmap bm = new Bitmap(this.dgvModule.Width, this.dgvModule.Height);

            dgvModule.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvModule.Width, this.dgvModule.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            dgvModule.Height = height;
        }
    }
}

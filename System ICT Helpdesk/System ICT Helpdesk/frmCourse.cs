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
using BusinessLogicLayer;
using DataAccessLayer;
using System.Drawing.Printing;

namespace System_ICT_Helpdesk
{
    public partial class frmCourse : Form
    {
        private bool mouseInPanel;
        private Timer hideTimer;
        public frmCourse()
        {
            InitializeComponent();
            hideTimer = new Timer { Interval = 100 };
            hideTimer.Tick += hidePanel;
        }
        BLL bl = new BLL();
        Course myC = new Course();
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
            dgvCourse.Visible = true;
            mouseInPanel = true;
            Display();
        }
        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            try
            {
                dt = bl.ValidationCheckCourse(txtCourseDesc.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show(txtCourseDesc.Text + " Already Exist, Please Enter A Unique Course Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    myC.CourseDescription = txtCourseDesc.Text;
                    if (!(string.IsNullOrEmpty(txtCourseDesc.Text)))
                    {
                        int x = bl.InsertCourse(myC);
                        if (x > 0)
                        {
                            MessageBox.Show("Your Data Successfully Added", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Display();
                            txtCourseDesc.Clear();
                        }
                        else
                        {
                            MessageBox.Show("unfortunately Data Wasn't Successful", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            dgvCourse.DataSource = bl.GetCourse();
        }

        private void txtCourseDesc_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCourseDesc.Text))
            {
                errorProvider1.SetError(txtCourseDesc, "Please check if you don't repeat the description");
            }
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
            Bitmap bm = new Bitmap(this.dgvCourse.Width, this.dgvCourse.Height);

            dgvCourse.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvCourse.Width, this.dgvCourse.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
        private void printDocument_PrintPages(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int height = dgvCourse.Height;
            dgvCourse.Height = dgvCourse.RowCount * dgvCourse.RowTemplate.Height;
            Bitmap bm = new Bitmap(this.dgvCourse.Width, this.dgvCourse.Height);

            dgvCourse.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvCourse.Width, this.dgvCourse.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            dgvCourse.Height = height;
        }

        private void btnPrint_MouseLeave(object sender, EventArgs e)
        {
            lblPrinter.Visible = false;
        }

        private void btnPrint_MouseHover(object sender, EventArgs e)
        {
            lblPrinter.Visible = true;
            lblPrinter.Text = "Print";
        }
    }
    
}

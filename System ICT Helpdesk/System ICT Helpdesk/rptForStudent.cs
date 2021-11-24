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
    public partial class rptForStudent : Form
    {
        public rptForStudent()
        {
            InitializeComponent();
        }
        BLL bl = new BLL();
        Student stud = new Student();
        Course co = new Course();
        private void cmbSelectFromStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x;
            Int32.TryParse(cmbSelectFromStudent.SelectedValue.ToString(), out x);
            dgvSearch.DataSource = bl.GetStudentByCourse(x);
        }
        
        private void frmStudentSearch_Load(object sender, EventArgs e)
        {
            cmbSelectFromStudent.DataSource = bl.GetCourse();
            cmbSelectFromStudent.DisplayMember = "CourseDescription";
            cmbSelectFromStudent.ValueMember = "CourseCode";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvSearch.DataSource = bl.GetSearchedStudent(txtSearch.Text);
        }

        private void txtSearch_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                errorProvider1.SetError(txtSearch, "Please Enter Some Text To Search");
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
            Bitmap bm = new Bitmap(this.dgvSearch.Width, this.dgvSearch.Height);

            dgvSearch.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvSearch.Width, this.dgvSearch.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
        private void printDocument_PrintPages(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int height = dgvSearch.Height;
            dgvSearch.Height = dgvSearch.RowCount * dgvSearch.RowTemplate.Height;
            Bitmap bm = new Bitmap(this.dgvSearch.Width, this.dgvSearch.Height);

            dgvSearch.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvSearch.Width, this.dgvSearch.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            dgvSearch.Height = height;
        }
    }
}

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
using System.Text.RegularExpressions;
using BusinessLogicLayer;
using DataAccessLayer;
using System.Drawing.Printing;

namespace System_ICT_Helpdesk
{
    public partial class frmStudent : Form
    {
        private bool mouseInPanel;
        private Timer hideTimer;
        public frmStudent()
        {
            InitializeComponent();
            hideTimer = new Timer { Interval = 100 };
            hideTimer.Tick += hidePanel;
        }
        BLL myBLL = new BLL();
        Student stud = new Student();
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
            pnlAddBtn.Visible = true;
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
            dgvStudent.Visible = true;
            mouseInPanel = true;
            Display();
        }
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                dt = myBLL.ValidationCheckStudent(txtStudNumber.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show(txtStudNumber.Text + " Already Exist, Please Enter A Unique Student Number", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    stud.StudentNumber = txtStudNumber.Text;
                    stud.StudentName = txtStudName.Text;
                    stud.StudentSurname = txtStudSurname.Text;
                    stud.IDNumber = txtIDNumber.Text;
                    txtStudEmailAd.Text = txtStudNumber.Text + "@mandela.ac.za";
                    stud.StudentEmailAddress = txtStudEmailAd.Text;
                    stud.StudentContactNo = txtStudContact.Text;
                    stud.CourseCode = int.Parse(cmbCourseCode.SelectedValue.ToString());

                    if (string.IsNullOrEmpty(txtStudNumber.Text) || string.IsNullOrEmpty(txtStudName.Text) || string.IsNullOrEmpty(txtStudSurname.Text) ||
                        string.IsNullOrEmpty(txtIDNumber.Text) || string.IsNullOrEmpty(txtStudEmailAd.Text) || string.IsNullOrEmpty(txtStudContact.Text))
                    {
                        MessageBox.Show("All Field Required, Double Check If There's No Empty Fields", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        int c = myBLL.InsertStudent(stud);
                        if (c > 0)
                        {
                            MessageBox.Show("Your Data Successfully Added", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MessageBox.Show("Your EmailAddress is " + txtStudEmailAd.Text, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Display();
                            txtIDNumber.Clear();
                            txtStudContact.Clear();
                            txtStudEmailAd.Clear();
                            txtStudName.Clear();
                            txtStudNumber.Clear();
                            txtStudSurname.Clear();
                        }
                        else
                        {
                            MessageBox.Show("unfortunately Data Wasn't Successful", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
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
            dgvStudent.DataSource = myBLL.GetStudent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student student = new Student(int.Parse(dgvStudent.SelectedRows[0].Cells["StudentID"].Value.ToString()), txtStudNumber.Text, txtStudName.Text,
                txtStudSurname.Text, txtIDNumber.Text, txtStudEmailAd.Text, txtStudContact.Text, int.Parse(cmbCourseCode.SelectedValue.ToString()));
            int x = myBLL.UpdateStudent(student);

            Display();
            txtIDNumber.Clear();
            txtStudContact.Clear();
            txtStudEmailAd.Clear();
            txtStudName.Clear();
            txtStudNumber.Clear();
            txtStudSurname.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (dgvStudent.SelectedRows.Count > 0)
            {
                dt = myBLL.DeleteFromStudent(int.Parse(dgvStudent.SelectedRows[0].Cells["StudentID"].Value.ToString()));
                Display();
            }
        }
        private void dgvStudent_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                if (dgvStudent.SelectedRows.Count > 0)
                {
                    dt = myBLL.GetStudentByStudentNumber(int.Parse(dgvStudent.SelectedRows[0].Cells["StudentID"].Value.ToString()));

                    txtStudNumber.Text = dt.Rows[0]["StudentNumber"].ToString();
                    txtStudName.Text = dt.Rows[0]["StudentName"].ToString();
                    txtStudSurname.Text = dt.Rows[0]["StudentSurname"].ToString();
                    txtIDNumber.Text = dt.Rows[0]["IDNumber"].ToString();
                    txtStudEmailAd.Text = dt.Rows[0]["StudentEmailAddress"].ToString();
                    txtStudContact.Text = dt.Rows[0]["StudentContactNo"].ToString();
                }
            }
            catch
            {
                MessageBox.Show("Invalid Selection");
            }
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            cmbCourseCode.DataSource = myBLL.GetCourse();
            cmbCourseCode.DisplayMember = "CourseDescription";
            cmbCourseCode.ValueMember = "CourseCode";
        }

        private void txtStudNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtStudNumber.Text))
            {
                errorProvider1.SetError(txtStudNumber, "Student Number Required");
            }
        }

        private void txtStudName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtStudName.Text))
            {
                errorProvider1.SetError(txtStudName, "Please enter student name");
            }
        }

        private void txtStudSurname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtStudSurname.Text))
            {
                errorProvider1.SetError(txtStudName, "Please enter student surname");
            }
        }

        private void txtIDNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDNumber.Text) || (!Regex.IsMatch(txtIDNumber.Text, @"^(\d{13})?$")))
            {
                errorProvider1.SetError(txtIDNumber, "Please enter an ID number");
            }
        }

        private void txtStudEmailAd_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtStudEmailAd.Text) || (!Regex.IsMatch(txtStudEmailAd.Text, @"^([\w]+)@([\w]+)\.([\w]+)$")))
            {
                errorProvider1.SetError(txtStudEmailAd, "Please enter an email address");
            }
        }

        private void txtStudContact_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtStudContact.Text) || (!Regex.IsMatch(txtStudContact.Text, @"^(\+?\d{0,3}\s?\(?\d{3}\)?\d{3}[-.\s]?\d{4})?$")))
            {
                errorProvider1.SetError(txtStudContact, "Please enter an Cellphone number");
            }
        }

        private void cmbCourseCode_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmbCourseCode.Text))
            {
                errorProvider1.SetError(cmbCourseCode, "Please Select From Valid Courses");
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
            Bitmap bm = new Bitmap(this.dgvStudent.Width, this.dgvStudent.Height);

            dgvStudent.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvStudent.Width, this.dgvStudent.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
        private void printDocument_PrintPages(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int height = dgvStudent.Height;
            dgvStudent.Height = dgvStudent.RowCount * dgvStudent.RowTemplate.Height;
            Bitmap bm = new Bitmap(this.dgvStudent.Width, this.dgvStudent.Height);

            dgvStudent.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvStudent.Width, this.dgvStudent.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            dgvStudent.Height = height;
        }
    }
}

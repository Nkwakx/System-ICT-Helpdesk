using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using BusinessLogicLayer;
using DataAccessLayer;
using System.Drawing.Printing;
using System.Security.Cryptography;


namespace System_ICT_Helpdesk
{
    public partial class frmStaff : Form
    {
        private bool mouseInPanel;
        private Timer hideTimer;
        public frmStaff()
        {
            InitializeComponent();
            hideTimer = new Timer { Interval = 100 };
            hideTimer.Tick += hidePanel;
        }
        BLL myBll = new BLL();
        Staff myStaff = new Staff();
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
            dgvStaff.Visible = true;
            mouseInPanel = true;
            Display();
        }
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            try
            {
                dt = myBll.ValidationCheckStaff(txtStaffNo.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show(txtStaffNo.Text + " Already Exist, Please Enter A Unique Staff Number", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    myStaff.StaffNumber = txtStaffNo.Text;
                    myStaff.FirstName = txtFName.Text;
                    myStaff.LastName = txtLName.Text;
                    txtUserName.Text = txtStaffNo.Text;
                    myStaff.UserName = txtUserName.Text;
                    myStaff.IDNumber = txtIDNumber.Text;
                    myStaff.Password = RandomPassword.Generate(8, 10);
                    txtEmailAd.Text = txtFName.Text.ToLower() + "." + txtLName.Text.ToLower() + "@mandela.ac.za";
                    myStaff.EmailAddress = txtEmailAd.Text;
                    myStaff.ContactNo = txtContactNo.Text;
                    myStaff.StaffType = txtStaff.Text;
                    myStaff.Active = "Yes";

                    if (string.IsNullOrEmpty(txtStaffNo.Text) || string.IsNullOrEmpty(txtFName.Text) || string.IsNullOrEmpty(txtLName.Text) ||
                        string.IsNullOrEmpty(txtIDNumber.Text) || string.IsNullOrEmpty(txtContactNo.Text) ||
                        string.IsNullOrEmpty(txtStaff.Text))
                    {
                        MessageBox.Show("All Field Required, Double Check If There's No Empty Fields", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        int x = myBll.InsertStaff(myStaff);
                        if (x > 0)
                        {
                            MessageBox.Show("Your Username is " + txtUserName.Text + "\n\nYour EmailAddress is " + txtEmailAd.Text, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Display();
                            txtStaffNo.Clear();
                            txtFName.Clear();
                            txtLName.Clear();
                            txtUserName.Clear();
                            txtContactNo.Clear();
                            txtEmailAd.Clear();
                            txtStaff.Clear();
                            txtActive.Clear();
                            txtIDNumber.Clear();
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
            dgvStaff.DataSource = myBll.GetStaff();
        }

        private void btnUpdateStaff_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (dgvStaff.SelectedRows.Count > 0)
            {
                Staff myS = new Staff(int.Parse(dgvStaff.SelectedRows[0].Cells["StaffID"].Value.ToString()), txtStaffNo.Text, txtFName.Text, txtLName.Text, txtUserName.Text, txtIDNumber.Text, txtEmailAd.Text, txtContactNo.Text, txtStaff.Text, txtActive.Text);
                int x = myBll.UpdateStaff(myS);

                Display();
                txtStaffNo.Clear();
                txtFName.Clear();
                txtLName.Clear();
                txtUserName.Clear();
                txtEmailAd.Clear();
                txtStaff.Clear();
                txtActive.Clear();
                txtContactNo.Clear();
                txtIDNumber.Clear();
                txtUserName.Visible = false;
                txtEmailAd.Visible = false;
                lblUsername.Visible = false;
                lblEmailAddress.Visible = false;
            }
        }

        private void dgvStaff_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {

                if (dgvStaff.SelectedRows.Count > 0)
                {
                    txtUserName.Visible = true;
                    txtEmailAd.Visible = true;
                    lblUsername.Visible = true;
                    lblEmailAddress.Visible = true;
                    txtActive.Visible = true;
                    lblActive.Visible = true;

                    txtUserName.Enabled = false;
                    txtEmailAd.Enabled = false;
                    lblUsername.Enabled = false;
                    lblEmailAddress.Enabled = false;
                    txtActive.Enabled = false;
                    lblActive.Enabled = false;
                    lblActive.BackColor = Color.Gold;
                    lblEmailAddress.BackColor = Color.Gold;
                    lblUsername.BackColor = Color.Gold;
                    dt = myBll.GetStaffByStaffID(int.Parse(dgvStaff.SelectedRows[0].Cells["StaffID"].Value.ToString()));

                    txtStaffNo.Text = dt.Rows[0]["StaffNumber"].ToString();
                    txtFName.Text = dt.Rows[0]["FirstName"].ToString();
                    txtLName.Text = dt.Rows[0]["LastName"].ToString();
                    txtIDNumber.Text = dt.Rows[0]["IDNumber"].ToString();
                    txtUserName.Text = dt.Rows[0]["UserName"].ToString();
                    txtEmailAd.Text = dt.Rows[0]["EmailAddress"].ToString();
                    txtContactNo.Text = dt.Rows[0]["ContactNo"].ToString();
                    txtStaff.Text = dt.Rows[0]["StaffType"].ToString();
                    txtActive.Text = dt.Rows[0]["Active"].ToString();
                }
            }
            catch
            {
                MessageBox.Show("Invalid Selection");
            }
        }
        private void btnInActive_Click(object sender, EventArgs e)
        {
            Staff myS = new Staff();
            myS.StaffID = int.Parse(dgvStaff.SelectedRows[0].Cells["StaffID"].Value.ToString());
            myS.Active = "No";
            myBll.GetStaffDisabled(myS.StaffID);
            Display();
            txtFName.Clear();
            txtLName.Clear();
            txtUserName.Clear();
            txtEmailAd.Clear();
            txtStaff.Clear();
            txtActive.Clear();
            txtContactNo.Clear();
            txtIDNumber.Clear();
            txtStaffNo.Clear();
            txtActive.Visible = false;
            lblActive.Visible = false;
            txtUserName.Visible = false;
            txtEmailAd.Visible = false;
            lblUsername.Visible = false;
            lblEmailAddress.Visible = false;
        }
        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (dgvStaff.SelectedRows.Count > 0)
            {
                dt = myBll.DeleteFromStaff(int.Parse(dgvStaff.SelectedRows[0].Cells["StaffID"].Value.ToString()));

                Display();
                txtFName.Clear();
                txtLName.Clear();
                txtUserName.Clear();
                txtEmailAd.Clear();
                txtStaff.Clear();
                txtActive.Clear();
                txtContactNo.Clear();
                txtIDNumber.Clear();
                txtStaffNo.Clear();
                txtUserName.Visible = false;
                txtEmailAd.Visible = false;
                lblUsername.Visible = false;
                lblEmailAddress.Visible = false;
                txtActive.Visible = false;
                lblActive.Visible = false;
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void txtStaffNo_TextChanged(object sender, EventArgs e)
        {
            txtUserName.Text = txtStaffNo.Text;
        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {
            txtEmailAd.Text = txtFName.Text;
        }

        private void txtLName_TextChanged(object sender, EventArgs e)
        {
            txtEmailAd.Text = txtEmailAd.Text + "." + txtLName.Text;
        }

        private void txtStaffNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtStaffNo.Text))
            {
                errorProvider1.SetError(txtStaffNo, "Please Enter Staff Number");
            }
        }

        private void txtFName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFName.Text))
            {
                errorProvider1.SetError(txtFName, "Please enter student name");
            }
        }

        private void txtLName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLName.Text))
            {
                errorProvider1.SetError(txtLName, "Please enter student surname");
            }
        }

        private void txtIDNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtActive.Text))
            {
                errorProvider1.SetError(txtActive, "Please enter student name");
            }
        }

        private void txtContactNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                errorProvider1.SetError(txtUserName, "Please enter student Username");
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmailAd.Text) || (!Regex.IsMatch(txtEmailAd.Text, @"^([\w]+)@([\w]+)\.([\w]+)$")))
            {
                errorProvider1.SetError(txtEmailAd, "Please enter an email address");
            }
        }

        private void txtStaff_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtContactNo.Text) || (!Regex.IsMatch(txtContactNo.Text, @"^(\+?\d{0,3}\s?\(?\d{3}\)?\d{3}[-.\s]?\d{4})?$")))
            {
                errorProvider1.SetError(txtContactNo, "Please enter an phone number");
            }
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtStaff.Text))
            {
                errorProvider1.SetError(txtStaff, "Staff Type Required");
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
            Bitmap bm = new Bitmap(this.dgvStaff.Width, this.dgvStaff.Height);

            dgvStaff.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvStaff.Width, this.dgvStaff.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
        private void printDocument_PrintPages(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int height = dgvStaff.Height;
            dgvStaff.Height = dgvStaff.RowCount * dgvStaff.RowTemplate.Height;
            Bitmap bm = new Bitmap(this.dgvStaff.Width, this.dgvStaff.Height);

            dgvStaff.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvStaff.Width, this.dgvStaff.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            dgvStaff.Height = height;
        }
        public class RandomPassword
        {
            
            private static int DEFAULT_MIN_PASSWORD_LENGTH = 8;
            private static int DEFAULT_MAX_PASSWORD_LENGTH = 10;

            
            private static string PASSWORD_CHARS_LCASE = "abcdefgijkmnopqrstwxyz";
            private static string PASSWORD_CHARS_UCASE = "ABCDEFGHJKLMNPQRSTWXYZ";
            private static string PASSWORD_CHARS_NUMERIC = "0123456789";
            private static string PASSWORD_CHARS_SPECIAL = "*$-+?_&=!%{}/";

            
            public static string Generate()
            {
                return Generate(DEFAULT_MIN_PASSWORD_LENGTH,
                                DEFAULT_MAX_PASSWORD_LENGTH);
            }
            public static string Generate(int length)
            {
                return Generate(length, length);
            }
            
            public static string Generate(int minLength, int maxLength)
            {
                
                if (minLength <= 0 || maxLength <= 0 || minLength > maxLength)
                    return null;

                char[][] charGroups = new char[][]
                {
                        PASSWORD_CHARS_LCASE.ToCharArray(),
                        PASSWORD_CHARS_UCASE.ToCharArray(),     
                        PASSWORD_CHARS_NUMERIC.ToCharArray(),
                        PASSWORD_CHARS_SPECIAL.ToCharArray()
                };

                
                int[] charsLeftInGroup = new int[charGroups.Length];

                for (int i = 0; i < charsLeftInGroup.Length; i++)
                    charsLeftInGroup[i] = charGroups[i].Length;
                
                int[] leftGroupsOrder = new int[charGroups.Length];

                for (int i = 0; i < leftGroupsOrder.Length; i++)
                    leftGroupsOrder[i] = i;

                byte[] randomBytes = new byte[4];

                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                rng.GetBytes(randomBytes);

                int seed = BitConverter.ToInt32(randomBytes, 0);

                Random random = new Random(seed);

                char[] password = null;

                if (minLength < maxLength)
                    password = new char[random.Next(minLength, maxLength + 1)];
                else
                    password = new char[minLength];

                int nextCharIdx;

                int nextGroupIdx;

                int nextLeftGroupsOrderIdx;

                int lastCharIdx;

                int lastLeftGroupsOrderIdx = leftGroupsOrder.Length - 1;

                for (int i = 0; i < password.Length; i++)
                {
         
                    if (lastLeftGroupsOrderIdx == 0)
                        nextLeftGroupsOrderIdx = 0;
                    else
                        nextLeftGroupsOrderIdx = random.Next(0, lastLeftGroupsOrderIdx);

                    nextGroupIdx = leftGroupsOrder[nextLeftGroupsOrderIdx];

                    lastCharIdx = charsLeftInGroup[nextGroupIdx] - 1;

                    if (lastCharIdx == 0)
                        nextCharIdx = 0;
                    else
                        nextCharIdx = random.Next(0, lastCharIdx + 1);

                    password[i] = charGroups[nextGroupIdx][nextCharIdx];

                    if (lastCharIdx == 0)
                        charsLeftInGroup[nextGroupIdx] =  charGroups[nextGroupIdx].Length;
                   
                    else
                    {
                        if (lastCharIdx != nextCharIdx)
                        {
                            char temp = charGroups[nextGroupIdx][lastCharIdx];
                            charGroups[nextGroupIdx][lastCharIdx] =
                                        charGroups[nextGroupIdx][nextCharIdx];
                            charGroups[nextGroupIdx][nextCharIdx] = temp;
                        }
                        charsLeftInGroup[nextGroupIdx]--;
                    }
                    if (lastLeftGroupsOrderIdx == 0)
                        lastLeftGroupsOrderIdx = leftGroupsOrder.Length - 1;
                    else
                    {
                        if (lastLeftGroupsOrderIdx != nextLeftGroupsOrderIdx)
                        {
                            int temp = leftGroupsOrder[lastLeftGroupsOrderIdx];
                            leftGroupsOrder[lastLeftGroupsOrderIdx] =
                                        leftGroupsOrder[nextLeftGroupsOrderIdx];
                            leftGroupsOrder[nextLeftGroupsOrderIdx] = temp;
                        }
                        lastLeftGroupsOrderIdx--;
                    }
                }
                return new string(password);
            }
        }
    }
}

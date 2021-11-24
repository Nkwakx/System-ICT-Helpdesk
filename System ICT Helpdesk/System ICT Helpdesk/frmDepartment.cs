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
using DataAccessLayer;
using BusinessLogicLayer;

namespace System_ICT_Helpdesk
{
    public partial class frmDepartment : Form
    {

        private bool mouseInPanel;
        private Timer hideTimer;
        public frmDepartment()
        {
            InitializeComponent();

            hideTimer = new Timer { Interval = 100 };
            hideTimer.Tick += hidePanel;
        }
        BLL myBll = new BLL();
        Department myDerpartment = new Department();
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


        private void btnList_MouseEnter(object sender, EventArgs e)
        {
            btnList.BackColor = Color.Transparent;
            mouseInPanel = false;
            hideTimer.Start();
        }

        private void btnOpenCotrols_MouseLeave(object sender, EventArgs e)
        {
            btnOpenCotrols.BackColor = Color.Transparent;
            mouseInPanel = false;
            hideTimer.Start();
        }

        private void btnList_MouseLeave(object sender, EventArgs e)
        {
            btnList.BackColor = Color.Gold;
            dgvDepartment.Visible = true;
            mouseInPanel = true;
            Display();
        }
        private void btnAddDep_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = myBll.ValidationCheckDepart(txtDepName.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show(txtDepName.Text + " Already Exist, Please Enter A Unique Department Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    myDerpartment.DepName = txtDepName.Text;
                    myDerpartment.BuildingID = int.Parse(cmbBuildingName.SelectedValue.ToString());
                    myDerpartment.DepContactNumber = txtDepContactNo.Text;
                    myDerpartment.DepEmailAddress = txtDepEmail.Text;

                    if (string.IsNullOrEmpty(txtDepName.Text) || string.IsNullOrEmpty(txtDepContactNo.Text) ||
                   string.IsNullOrEmpty(txtDepEmail.Text) || string.IsNullOrEmpty(cmbBuildingName.SelectedValue.ToString()))
                    {
                        MessageBox.Show("All Field Required, Double Check If There's No Empty Fields", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        int x = myBll.InsertDepart(myDerpartment);
                        if (x > 0)
                        {
                            MessageBox.Show("Your Data Successfully Added");
                            Display();
                            txtDepEmail.Clear();
                            txtDepName.Clear();
                            txtDepContactNo.Clear();
                        }
                        else
                        {
                            MessageBox.Show("unfortunately Data Wasn't Successful");
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
            dgvDepartment.DataSource = myBll.GetDepart();
        }

        private void btnDeleteFromDep_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (dgvDepartment.SelectedRows.Count > 0)
            {
                dt = myBll.DeleteFromDep(int.Parse(dgvDepartment.SelectedRows[0].Cells["DepartmentID"].Value.ToString()));

                Display();
            }
        }

        private void btnUpdateDep_Click(object sender, EventArgs e)
        {
            Department newDep = new Department(int.Parse(dgvDepartment.SelectedRows[0].Cells["DepartmentID"].Value.ToString()), txtDepName.Text, int.Parse(cmbBuildingName.SelectedValue.ToString()), txtDepContactNo.Text, txtDepEmail.Text);
            int x = myBll.UpdateDepart(newDep);

            Display();
            txtDepEmail.Clear();
            txtDepName.Clear();
            txtDepContactNo.Clear();
        }

        private void cmbBuildingName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDepName.Text))
            {
                errorProvider1.SetError(txtDepName, "Please Enter A Department Name");
            }
        }

        private void txtDepContactNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDepContactNo.Text) || (!Regex.IsMatch(txtDepContactNo.Text, @"^(\+?\d{0,3}\s?\(?\d{3}\)?\d{3}[-.\s]?\d{4})?$")))
            {
                errorProvider1.SetError(txtDepContactNo, "Please enter an Cellphone number");
            }
        }

        private void txtDepEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDepEmail.Text) || (!Regex.IsMatch(txtDepEmail.Text, @"^([\w]+)@([\w]+)\.([\w]+)$")))
            {
                errorProvider1.SetError(txtDepEmail, "Please enter an email address");
            }
        }

        private void frmDepartment_Load(object sender, EventArgs e)
        {
            cmbBuildingName.DataSource = myBll.GetBuilding();
            cmbBuildingName.DisplayMember = "BuildingName";
            cmbBuildingName.ValueMember = "BuildingID";
        }

        private void dgvDepartment_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                if (dgvDepartment.SelectedRows.Count > 0)
                {
                    dt = myBll.GetDepartmentByDepId(int.Parse(dgvDepartment.SelectedRows[0].Cells["DepartmentID"].Value.ToString()));

                    txtDepName.Text = dt.Rows[0]["DepName"].ToString();
                    txtDepContactNo.Text = dt.Rows[0]["DepContactNumber"].ToString();
                    txtDepEmail.Text = dt.Rows[0]["DepEmailAddress"].ToString();
                }
            }
            catch
            {
                MessageBox.Show("Invalid Selection");
            }
        }
    }
}

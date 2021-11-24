namespace System_ICT_Helpdesk
{
    partial class frmRequest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRequest));
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.cmbStaffAssign = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dteRequestDate = new System.Windows.Forms.DateTimePicker();
            this.cmbStudNo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTaskDesc = new System.Windows.Forms.ComboBox();
            this.cmbStartTime = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbStaffType = new System.Windows.Forms.ComboBox();
            this.txtReqDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlDasshBard = new System.Windows.Forms.Panel();
            this.pnlBtn = new System.Windows.Forms.Panel();
            this.btnList = new System.Windows.Forms.Button();
            this.btnOpenCotrols = new System.Windows.Forms.Button();
            this.dgvRequest = new System.Windows.Forms.DataGridView();
            this.pnlRequestDetails = new System.Windows.Forms.Panel();
            this.lblRequestStatus = new System.Windows.Forms.Label();
            this.lblDescr = new System.Windows.Forms.Label();
            this.lblRequestCode = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnHardDeleteReq = new System.Windows.Forms.Button();
            this.btnSoftDeleteReq = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlSoftDelete = new System.Windows.Forms.Panel();
            this.lblPrinter = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.pnlControl.SuspendLayout();
            this.pnlDasshBard.SuspendLayout();
            this.pnlBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequest)).BeginInit();
            this.pnlRequestDetails.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlSoftDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackColor = System.Drawing.Color.Gold;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Location = new System.Drawing.Point(143, 260);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(183, 43);
            this.panel4.TabIndex = 22;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnAdd.BackColor = System.Drawing.Color.Tan;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(31, 15);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 26);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(346, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 34);
            this.label7.TabIndex = 17;
            this.label7.Text = "Request Details";
            // 
            // pnlControl
            // 
            this.pnlControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.pnlControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControl.Controls.Add(this.cmbStaffAssign);
            this.pnlControl.Controls.Add(this.label12);
            this.pnlControl.Controls.Add(this.panel4);
            this.pnlControl.Controls.Add(this.dteRequestDate);
            this.pnlControl.Controls.Add(this.cmbStudNo);
            this.pnlControl.Controls.Add(this.label1);
            this.pnlControl.Controls.Add(this.cmbTaskDesc);
            this.pnlControl.Controls.Add(this.cmbStartTime);
            this.pnlControl.Controls.Add(this.label2);
            this.pnlControl.Controls.Add(this.cmbStaffType);
            this.pnlControl.Controls.Add(this.txtReqDesc);
            this.pnlControl.Controls.Add(this.label3);
            this.pnlControl.Controls.Add(this.label6);
            this.pnlControl.Controls.Add(this.label5);
            this.pnlControl.Controls.Add(this.label4);
            this.pnlControl.ForeColor = System.Drawing.Color.White;
            this.pnlControl.Location = new System.Drawing.Point(0, 63);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(347, 333);
            this.pnlControl.TabIndex = 23;
            this.pnlControl.Visible = false;
            // 
            // cmbStaffAssign
            // 
            this.cmbStaffAssign.FormattingEnabled = true;
            this.cmbStaffAssign.Location = new System.Drawing.Point(150, 219);
            this.cmbStaffAssign.Name = "cmbStaffAssign";
            this.cmbStaffAssign.Size = new System.Drawing.Size(176, 24);
            this.cmbStaffAssign.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 221);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "StaffType(Intern)";
            // 
            // dteRequestDate
            // 
            this.dteRequestDate.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteRequestDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteRequestDate.Location = new System.Drawing.Point(150, 154);
            this.dteRequestDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dteRequestDate.Name = "dteRequestDate";
            this.dteRequestDate.Size = new System.Drawing.Size(176, 22);
            this.dteRequestDate.TabIndex = 9;
            // 
            // cmbStudNo
            // 
            this.cmbStudNo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStudNo.FormattingEnabled = true;
            this.cmbStudNo.Location = new System.Drawing.Point(150, 94);
            this.cmbStudNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbStudNo.Name = "cmbStudNo";
            this.cmbStudNo.Size = new System.Drawing.Size(176, 24);
            this.cmbStudNo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Request Description";
            // 
            // cmbTaskDesc
            // 
            this.cmbTaskDesc.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTaskDesc.FormattingEnabled = true;
            this.cmbTaskDesc.Location = new System.Drawing.Point(150, 124);
            this.cmbTaskDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTaskDesc.Name = "cmbTaskDesc";
            this.cmbTaskDesc.Size = new System.Drawing.Size(176, 24);
            this.cmbTaskDesc.TabIndex = 8;
            // 
            // cmbStartTime
            // 
            this.cmbStartTime.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStartTime.FormattingEnabled = true;
            this.cmbStartTime.Location = new System.Drawing.Point(150, 184);
            this.cmbStartTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbStartTime.Name = "cmbStartTime";
            this.cmbStartTime.Size = new System.Drawing.Size(176, 24);
            this.cmbStartTime.TabIndex = 10;
            this.cmbStartTime.SelectedIndexChanged += new System.EventHandler(this.cmbStartTime_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "StaffType(Manager)";
            // 
            // cmbStaffType
            // 
            this.cmbStaffType.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStaffType.FormattingEnabled = true;
            this.cmbStaffType.Location = new System.Drawing.Point(150, 64);
            this.cmbStaffType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbStaffType.Name = "cmbStaffType";
            this.cmbStaffType.Size = new System.Drawing.Size(176, 24);
            this.cmbStaffType.TabIndex = 6;
            // 
            // txtReqDesc
            // 
            this.txtReqDesc.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReqDesc.Location = new System.Drawing.Point(150, 34);
            this.txtReqDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReqDesc.Name = "txtReqDesc";
            this.txtReqDesc.Size = new System.Drawing.Size(176, 22);
            this.txtReqDesc.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Student Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Task Description";
            // 
            // pnlDasshBard
            // 
            this.pnlDasshBard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.pnlDasshBard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDasshBard.Controls.Add(this.label7);
            this.pnlDasshBard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDasshBard.ForeColor = System.Drawing.Color.White;
            this.pnlDasshBard.Location = new System.Drawing.Point(0, 0);
            this.pnlDasshBard.Name = "pnlDasshBard";
            this.pnlDasshBard.Size = new System.Drawing.Size(1048, 64);
            this.pnlDasshBard.TabIndex = 37;
            // 
            // pnlBtn
            // 
            this.pnlBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlBtn.BackColor = System.Drawing.Color.Gold;
            this.pnlBtn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBtn.Controls.Add(this.btnList);
            this.pnlBtn.Controls.Add(this.btnOpenCotrols);
            this.pnlBtn.ForeColor = System.Drawing.Color.White;
            this.pnlBtn.Location = new System.Drawing.Point(0, 384);
            this.pnlBtn.Name = "pnlBtn";
            this.pnlBtn.Size = new System.Drawing.Size(347, 57);
            this.pnlBtn.TabIndex = 58;
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.Tan;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.Location = new System.Drawing.Point(155, 16);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(173, 39);
            this.btnList.TabIndex = 53;
            this.btnList.Text = "List Request";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.MouseEnter += new System.EventHandler(this.btnList_MouseEnter);
            this.btnList.MouseLeave += new System.EventHandler(this.btnList_MouseLeave);
            // 
            // btnOpenCotrols
            // 
            this.btnOpenCotrols.BackColor = System.Drawing.Color.Tan;
            this.btnOpenCotrols.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenCotrols.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenCotrols.Location = new System.Drawing.Point(-2, 16);
            this.btnOpenCotrols.Name = "btnOpenCotrols";
            this.btnOpenCotrols.Size = new System.Drawing.Size(157, 39);
            this.btnOpenCotrols.TabIndex = 54;
            this.btnOpenCotrols.Text = "Open Controls";
            this.btnOpenCotrols.UseVisualStyleBackColor = false;
            this.btnOpenCotrols.MouseEnter += new System.EventHandler(this.btnOpenCotrols_MouseEnter);
            this.btnOpenCotrols.MouseLeave += new System.EventHandler(this.btnOpenCotrols_MouseLeave);
            // 
            // dgvRequest
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dgvRequest.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRequest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRequest.BackgroundColor = System.Drawing.Color.White;
            this.dgvRequest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRequest.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRequest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRequest.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRequest.Location = new System.Drawing.Point(353, 71);
            this.dgvRequest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvRequest.Name = "dgvRequest";
            this.dgvRequest.RowTemplate.DividerHeight = 3;
            this.dgvRequest.Size = new System.Drawing.Size(683, 162);
            this.dgvRequest.TabIndex = 67;
            this.dgvRequest.Visible = false;
            this.dgvRequest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequest_CellClick);
            // 
            // pnlRequestDetails
            // 
            this.pnlRequestDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlRequestDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.pnlRequestDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRequestDetails.Controls.Add(this.lblRequestStatus);
            this.pnlRequestDetails.Controls.Add(this.lblDescr);
            this.pnlRequestDetails.Controls.Add(this.lblRequestCode);
            this.pnlRequestDetails.Controls.Add(this.panel3);
            this.pnlRequestDetails.Controls.Add(this.label11);
            this.pnlRequestDetails.Controls.Add(this.label9);
            this.pnlRequestDetails.Controls.Add(this.label8);
            this.pnlRequestDetails.ForeColor = System.Drawing.Color.White;
            this.pnlRequestDetails.Location = new System.Drawing.Point(353, 240);
            this.pnlRequestDetails.Name = "pnlRequestDetails";
            this.pnlRequestDetails.Size = new System.Drawing.Size(401, 201);
            this.pnlRequestDetails.TabIndex = 68;
            this.pnlRequestDetails.Visible = false;
            // 
            // lblRequestStatus
            // 
            this.lblRequestStatus.AutoSize = true;
            this.lblRequestStatus.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestStatus.Location = new System.Drawing.Point(222, 70);
            this.lblRequestStatus.Name = "lblRequestStatus";
            this.lblRequestStatus.Size = new System.Drawing.Size(0, 20);
            this.lblRequestStatus.TabIndex = 17;
            // 
            // lblDescr
            // 
            this.lblDescr.AutoSize = true;
            this.lblDescr.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescr.Location = new System.Drawing.Point(222, 38);
            this.lblDescr.Name = "lblDescr";
            this.lblDescr.Size = new System.Drawing.Size(0, 20);
            this.lblDescr.TabIndex = 15;
            // 
            // lblRequestCode
            // 
            this.lblRequestCode.AutoSize = true;
            this.lblRequestCode.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestCode.Location = new System.Drawing.Point(222, 10);
            this.lblRequestCode.Name = "lblRequestCode";
            this.lblRequestCode.Size = new System.Drawing.Size(0, 20);
            this.lblRequestCode.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.Gold;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnHardDeleteReq);
            this.panel3.Controls.Add(this.btnSoftDeleteReq);
            this.panel3.Location = new System.Drawing.Point(38, 134);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(338, 64);
            this.panel3.TabIndex = 13;
            // 
            // btnHardDeleteReq
            // 
            this.btnHardDeleteReq.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnHardDeleteReq.BackColor = System.Drawing.Color.Tan;
            this.btnHardDeleteReq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHardDeleteReq.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHardDeleteReq.ForeColor = System.Drawing.Color.White;
            this.btnHardDeleteReq.Location = new System.Drawing.Point(160, 15);
            this.btnHardDeleteReq.Name = "btnHardDeleteReq";
            this.btnHardDeleteReq.Size = new System.Drawing.Size(142, 47);
            this.btnHardDeleteReq.TabIndex = 11;
            this.btnHardDeleteReq.Text = "Hard Delete Request";
            this.btnHardDeleteReq.UseVisualStyleBackColor = false;
            this.btnHardDeleteReq.Click += new System.EventHandler(this.btnHardDeleteReq_Click);
            // 
            // btnSoftDeleteReq
            // 
            this.btnSoftDeleteReq.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSoftDeleteReq.BackColor = System.Drawing.Color.Tan;
            this.btnSoftDeleteReq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoftDeleteReq.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoftDeleteReq.ForeColor = System.Drawing.Color.White;
            this.btnSoftDeleteReq.Location = new System.Drawing.Point(26, 15);
            this.btnSoftDeleteReq.Name = "btnSoftDeleteReq";
            this.btnSoftDeleteReq.Size = new System.Drawing.Size(140, 47);
            this.btnSoftDeleteReq.TabIndex = 10;
            this.btnSoftDeleteReq.Text = "Soft Delete Request";
            this.btnSoftDeleteReq.UseVisualStyleBackColor = false;
            this.btnSoftDeleteReq.Click += new System.EventHandler(this.btnSoftDeleteReq_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Request Status:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Request Description:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Request Code:";
            // 
            // pnlSoftDelete
            // 
            this.pnlSoftDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSoftDelete.BackColor = System.Drawing.Color.Tan;
            this.pnlSoftDelete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSoftDelete.Controls.Add(this.lblPrinter);
            this.pnlSoftDelete.Controls.Add(this.btnPrint);
            this.pnlSoftDelete.ForeColor = System.Drawing.Color.White;
            this.pnlSoftDelete.Location = new System.Drawing.Point(747, 240);
            this.pnlSoftDelete.Name = "pnlSoftDelete";
            this.pnlSoftDelete.Size = new System.Drawing.Size(301, 201);
            this.pnlSoftDelete.TabIndex = 69;
            // 
            // lblPrinter
            // 
            this.lblPrinter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrinter.AutoSize = true;
            this.lblPrinter.BackColor = System.Drawing.Color.Red;
            this.lblPrinter.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrinter.ForeColor = System.Drawing.Color.White;
            this.lblPrinter.Location = new System.Drawing.Point(155, 0);
            this.lblPrinter.Name = "lblPrinter";
            this.lblPrinter.Size = new System.Drawing.Size(0, 22);
            this.lblPrinter.TabIndex = 69;
            this.lblPrinter.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.BackgroundImage")));
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrint.Location = new System.Drawing.Point(217, -1);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(83, 55);
            this.btnPrint.TabIndex = 68;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            this.btnPrint.MouseLeave += new System.EventHandler(this.btnPrint_MouseLeave);
            this.btnPrint.MouseHover += new System.EventHandler(this.btnPrint_MouseHover);
            // 
            // frmRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1048, 440);
            this.Controls.Add(this.pnlSoftDelete);
            this.Controls.Add(this.pnlBtn);
            this.Controls.Add(this.pnlRequestDetails);
            this.Controls.Add(this.dgvRequest);
            this.Controls.Add(this.pnlDasshBard);
            this.Controls.Add(this.pnlControl);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1048, 440);
            this.Name = "frmRequest";
            this.Text = "frmRequest";
            this.Load += new System.EventHandler(this.frmRequest_Load);
            this.panel4.ResumeLayout(false);
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            this.pnlDasshBard.ResumeLayout(false);
            this.pnlDasshBard.PerformLayout();
            this.pnlBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequest)).EndInit();
            this.pnlRequestDetails.ResumeLayout(false);
            this.pnlRequestDetails.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.pnlSoftDelete.ResumeLayout(false);
            this.pnlSoftDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.DateTimePicker dteRequestDate;
        private System.Windows.Forms.ComboBox cmbStudNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTaskDesc;
        private System.Windows.Forms.ComboBox cmbStartTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbStaffType;
        private System.Windows.Forms.TextBox txtReqDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlDasshBard;
        private System.Windows.Forms.Panel pnlBtn;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnOpenCotrols;
        private System.Windows.Forms.DataGridView dgvRequest;
        private System.Windows.Forms.Panel pnlRequestDetails;
        private System.Windows.Forms.Panel pnlSoftDelete;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblRequestStatus;
        private System.Windows.Forms.Label lblDescr;
        private System.Windows.Forms.Label lblRequestCode;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnHardDeleteReq;
        private System.Windows.Forms.Button btnSoftDeleteReq;
        private System.Windows.Forms.ComboBox cmbStaffAssign;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblPrinter;
        private System.Windows.Forms.Button btnPrint;
    }
}
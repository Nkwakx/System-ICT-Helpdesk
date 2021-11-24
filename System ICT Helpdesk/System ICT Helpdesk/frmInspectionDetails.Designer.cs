namespace System_ICT_Helpdesk
{
    partial class frmInspectionDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInspectionDetails));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.addInspectionDetails = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblPrinter = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dteDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbInspectionCode = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbEquipment = new System.Windows.Forms.ComboBox();
            this.txtFaultComment = new System.Windows.Forms.TextBox();
            this.cmbStaffType = new System.Windows.Forms.ComboBox();
            this.pnlUpdate = new System.Windows.Forms.Panel();
            this.lblFaultComment = new System.Windows.Forms.Label();
            this.lblStatuss = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSoftDelete = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pnlBtn = new System.Windows.Forms.Panel();
            this.btnList = new System.Windows.Forms.Button();
            this.btnOpenCotrols = new System.Windows.Forms.Button();
            this.dgvInspectionDetails = new System.Windows.Forms.DataGridView();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnlControl.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInspectionDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackColor = System.Drawing.Color.Gold;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.addInspectionDetails);
            this.panel4.Location = new System.Drawing.Point(188, 248);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(192, 47);
            this.panel4.TabIndex = 21;
            // 
            // addInspectionDetails
            // 
            this.addInspectionDetails.BackColor = System.Drawing.Color.Tan;
            this.addInspectionDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addInspectionDetails.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInspectionDetails.ForeColor = System.Drawing.Color.White;
            this.addInspectionDetails.Location = new System.Drawing.Point(56, 16);
            this.addInspectionDetails.Name = "addInspectionDetails";
            this.addInspectionDetails.Size = new System.Drawing.Size(84, 29);
            this.addInspectionDetails.TabIndex = 18;
            this.addInspectionDetails.Text = "ADD";
            this.addInspectionDetails.UseVisualStyleBackColor = false;
            this.addInspectionDetails.Click += new System.EventHandler(this.addInspectionDetails_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1048, 77);
            this.panel2.TabIndex = 33;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.Gold;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lblPrinter);
            this.panel5.Controls.Add(this.btnPrint);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(-1, 24);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1048, 52);
            this.panel5.TabIndex = 11;
            // 
            // lblPrinter
            // 
            this.lblPrinter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrinter.AutoSize = true;
            this.lblPrinter.BackColor = System.Drawing.Color.Red;
            this.lblPrinter.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrinter.ForeColor = System.Drawing.Color.White;
            this.lblPrinter.Location = new System.Drawing.Point(904, 0);
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
            this.btnPrint.Location = new System.Drawing.Point(964, -1);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(83, 52);
            this.btnPrint.TabIndex = 68;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            this.btnPrint.MouseLeave += new System.EventHandler(this.btnPrint_MouseLeave);
            this.btnPrint.MouseHover += new System.EventHandler(this.btnPrint_MouseHover);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(416, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(250, 34);
            this.label7.TabIndex = 1;
            this.label7.Text = "Inspection Details";
            // 
            // pnlControl
            // 
            this.pnlControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.pnlControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControl.Controls.Add(this.panel4);
            this.pnlControl.Controls.Add(this.txtStatus);
            this.pnlControl.Controls.Add(this.label1);
            this.pnlControl.Controls.Add(this.label2);
            this.pnlControl.Controls.Add(this.label3);
            this.pnlControl.Controls.Add(this.label4);
            this.pnlControl.Controls.Add(this.dteDate);
            this.pnlControl.Controls.Add(this.label5);
            this.pnlControl.Controls.Add(this.cmbInspectionCode);
            this.pnlControl.Controls.Add(this.lblStatus);
            this.pnlControl.Controls.Add(this.cmbEquipment);
            this.pnlControl.Controls.Add(this.txtFaultComment);
            this.pnlControl.Controls.Add(this.cmbStaffType);
            this.pnlControl.ForeColor = System.Drawing.Color.White;
            this.pnlControl.Location = new System.Drawing.Point(0, 77);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(381, 313);
            this.pnlControl.TabIndex = 32;
            this.pnlControl.Visible = false;
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(186, 195);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(144, 22);
            this.txtStatus.TabIndex = 6;
            this.txtStatus.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inspection Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Equipment Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Staff(Assigned)";
            // 
            // dteDate
            // 
            this.dteDate.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteDate.Location = new System.Drawing.Point(186, 95);
            this.dteDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dteDate.Name = "dteDate";
            this.dteDate.Size = new System.Drawing.Size(144, 22);
            this.dteDate.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fault Comment";
            // 
            // cmbInspectionCode
            // 
            this.cmbInspectionCode.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbInspectionCode.FormattingEnabled = true;
            this.cmbInspectionCode.Location = new System.Drawing.Point(186, 27);
            this.cmbInspectionCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbInspectionCode.Name = "cmbInspectionCode";
            this.cmbInspectionCode.Size = new System.Drawing.Size(144, 24);
            this.cmbInspectionCode.TabIndex = 10;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(3, 191);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(91, 18);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status[O/C]";
            this.lblStatus.Visible = false;
            // 
            // cmbEquipment
            // 
            this.cmbEquipment.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEquipment.FormattingEnabled = true;
            this.cmbEquipment.Location = new System.Drawing.Point(186, 61);
            this.cmbEquipment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbEquipment.Name = "cmbEquipment";
            this.cmbEquipment.Size = new System.Drawing.Size(144, 24);
            this.cmbEquipment.TabIndex = 9;
            // 
            // txtFaultComment
            // 
            this.txtFaultComment.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFaultComment.Location = new System.Drawing.Point(186, 162);
            this.txtFaultComment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFaultComment.Name = "txtFaultComment";
            this.txtFaultComment.Size = new System.Drawing.Size(144, 22);
            this.txtFaultComment.TabIndex = 7;
            // 
            // cmbStaffType
            // 
            this.cmbStaffType.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStaffType.FormattingEnabled = true;
            this.cmbStaffType.Location = new System.Drawing.Point(186, 128);
            this.cmbStaffType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbStaffType.Name = "cmbStaffType";
            this.cmbStaffType.Size = new System.Drawing.Size(144, 24);
            this.cmbStaffType.TabIndex = 8;
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlUpdate.BackColor = System.Drawing.Color.Tan;
            this.pnlUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUpdate.Controls.Add(this.lblFaultComment);
            this.pnlUpdate.Controls.Add(this.lblStatuss);
            this.pnlUpdate.Controls.Add(this.panel3);
            this.pnlUpdate.Controls.Add(this.label11);
            this.pnlUpdate.Controls.Add(this.label12);
            this.pnlUpdate.ForeColor = System.Drawing.Color.White;
            this.pnlUpdate.Location = new System.Drawing.Point(387, 239);
            this.pnlUpdate.Name = "pnlUpdate";
            this.pnlUpdate.Size = new System.Drawing.Size(379, 199);
            this.pnlUpdate.TabIndex = 68;
            this.pnlUpdate.Visible = false;
            // 
            // lblFaultComment
            // 
            this.lblFaultComment.AutoSize = true;
            this.lblFaultComment.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaultComment.Location = new System.Drawing.Point(203, 50);
            this.lblFaultComment.Name = "lblFaultComment";
            this.lblFaultComment.Size = new System.Drawing.Size(0, 20);
            this.lblFaultComment.TabIndex = 27;
            // 
            // lblStatuss
            // 
            this.lblStatuss.AutoSize = true;
            this.lblStatuss.BackColor = System.Drawing.Color.Red;
            this.lblStatuss.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatuss.Location = new System.Drawing.Point(203, 74);
            this.lblStatuss.Name = "lblStatuss";
            this.lblStatuss.Size = new System.Drawing.Size(0, 20);
            this.lblStatuss.TabIndex = 26;
            this.lblStatuss.UseMnemonic = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.Gold;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnSoftDelete);
            this.panel3.Location = new System.Drawing.Point(62, 151);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(280, 47);
            this.panel3.TabIndex = 21;
            // 
            // btnSoftDelete
            // 
            this.btnSoftDelete.BackColor = System.Drawing.Color.Tan;
            this.btnSoftDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoftDelete.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoftDelete.Location = new System.Drawing.Point(53, 15);
            this.btnSoftDelete.Name = "btnSoftDelete";
            this.btnSoftDelete.Size = new System.Drawing.Size(164, 30);
            this.btnSoftDelete.TabIndex = 19;
            this.btnSoftDelete.Text = "Closed Inspection";
            this.btnSoftDelete.UseVisualStyleBackColor = false;
            this.btnSoftDelete.Click += new System.EventHandler(this.btnSoftDelete_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "Fault Comment";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "Status[O/C]";
            // 
            // pnlButtons
            // 
            this.pnlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.pnlButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlButtons.Controls.Add(this.pnlBtn);
            this.pnlButtons.ForeColor = System.Drawing.Color.White;
            this.pnlButtons.Location = new System.Drawing.Point(0, 378);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(1060, 61);
            this.pnlButtons.TabIndex = 34;
            // 
            // pnlBtn
            // 
            this.pnlBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlBtn.BackColor = System.Drawing.Color.Gold;
            this.pnlBtn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBtn.Controls.Add(this.btnList);
            this.pnlBtn.Controls.Add(this.btnOpenCotrols);
            this.pnlBtn.ForeColor = System.Drawing.Color.White;
            this.pnlBtn.Location = new System.Drawing.Point(-1, 3);
            this.pnlBtn.Name = "pnlBtn";
            this.pnlBtn.Size = new System.Drawing.Size(381, 57);
            this.pnlBtn.TabIndex = 57;
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.Tan;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.Location = new System.Drawing.Point(155, 12);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(224, 39);
            this.btnList.TabIndex = 53;
            this.btnList.Text = "List InspectionDetails";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.MouseEnter += new System.EventHandler(this.btnList_MouseEnter);
            this.btnList.MouseLeave += new System.EventHandler(this.btnList_MouseLeave);
            // 
            // btnOpenCotrols
            // 
            this.btnOpenCotrols.BackColor = System.Drawing.Color.Tan;
            this.btnOpenCotrols.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenCotrols.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenCotrols.Location = new System.Drawing.Point(14, 12);
            this.btnOpenCotrols.Name = "btnOpenCotrols";
            this.btnOpenCotrols.Size = new System.Drawing.Size(157, 39);
            this.btnOpenCotrols.TabIndex = 54;
            this.btnOpenCotrols.Text = "Open Controls";
            this.btnOpenCotrols.UseVisualStyleBackColor = false;
            this.btnOpenCotrols.MouseEnter += new System.EventHandler(this.btnOpenCotrols_MouseEnter);
            this.btnOpenCotrols.MouseLeave += new System.EventHandler(this.btnOpenCotrols_MouseLeave);
            // 
            // dgvInspectionDetails
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            this.dgvInspectionDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvInspectionDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInspectionDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInspectionDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvInspectionDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInspectionDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInspectionDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvInspectionDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInspectionDetails.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvInspectionDetails.Location = new System.Drawing.Point(387, 84);
            this.dgvInspectionDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvInspectionDetails.Name = "dgvInspectionDetails";
            this.dgvInspectionDetails.RowTemplate.DividerHeight = 3;
            this.dgvInspectionDetails.Size = new System.Drawing.Size(649, 149);
            this.dgvInspectionDetails.TabIndex = 67;
            this.dgvInspectionDetails.Visible = false;
            this.dgvInspectionDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInspectionDetails_CellClick_1);
            // 
            // frmInspectionDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1048, 440);
            this.Controls.Add(this.pnlUpdate);
            this.Controls.Add(this.dgvInspectionDetails);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1048, 440);
            this.Name = "frmInspectionDetails";
            this.Text = "frmInspectionDetails";
            this.Load += new System.EventHandler(this.frmInspectionDetails_Load);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            this.pnlUpdate.ResumeLayout(false);
            this.pnlUpdate.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.pnlBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInspectionDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button addInspectionDetails;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dteDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbInspectionCode;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbEquipment;
        private System.Windows.Forms.TextBox txtFaultComment;
        private System.Windows.Forms.ComboBox cmbStaffType;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Panel pnlBtn;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnOpenCotrols;
        private System.Windows.Forms.DataGridView dgvInspectionDetails;
        private System.Windows.Forms.Label lblPrinter;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel pnlUpdate;
        private System.Windows.Forms.Label lblStatuss;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSoftDelete;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblFaultComment;
    }
}
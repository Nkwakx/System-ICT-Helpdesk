namespace System_ICT_Helpdesk
{
    partial class frmEquipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEquipment));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMidDisplay = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPrinter = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnListEquipment = new System.Windows.Forms.Button();
            this.btnAddEquipment = new System.Windows.Forms.Button();
            this.dgvEquipment = new System.Windows.Forms.DataGridView();
            this.pnlDeletes = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHardDeleteEquip = new System.Windows.Forms.Button();
            this.btnSoftDeleteEquip = new System.Windows.Forms.Button();
            this.lblEquipmentStatus = new System.Windows.Forms.Label();
            this.lblVenueCode = new System.Windows.Forms.Label();
            this.lblYearsVALID = new System.Windows.Forms.Label();
            this.lblEquipDescription = new System.Windows.Forms.Label();
            this.lblEquipCode = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlAddEqui = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAddEquipmentInfo = new System.Windows.Forms.Button();
            this.dteDateR = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEquipDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbVenueCode = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlDasshBard = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbEquipType = new System.Windows.Forms.ComboBox();
            this.txtValidYear = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlMidDisplay.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipment)).BeginInit();
            this.pnlDeletes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlAddEqui.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlDasshBard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMidDisplay
            // 
            this.pnlMidDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMidDisplay.BackColor = System.Drawing.Color.White;
            this.pnlMidDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMidDisplay.Controls.Add(this.panel2);
            this.pnlMidDisplay.Controls.Add(this.panel3);
            this.pnlMidDisplay.Controls.Add(this.dgvEquipment);
            this.pnlMidDisplay.Controls.Add(this.pnlDeletes);
            this.pnlMidDisplay.Controls.Add(this.pnlAddEqui);
            this.pnlMidDisplay.ForeColor = System.Drawing.Color.Black;
            this.pnlMidDisplay.Location = new System.Drawing.Point(0, 57);
            this.pnlMidDisplay.Name = "pnlMidDisplay";
            this.pnlMidDisplay.Size = new System.Drawing.Size(1044, 382);
            this.pnlMidDisplay.TabIndex = 35;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Tan;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblPrinter);
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Location = new System.Drawing.Point(742, 174);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 207);
            this.panel2.TabIndex = 64;
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
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.Gold;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnListEquipment);
            this.panel3.Controls.Add(this.btnAddEquipment);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(-1, 324);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(315, 60);
            this.panel3.TabIndex = 13;
            // 
            // btnListEquipment
            // 
            this.btnListEquipment.BackColor = System.Drawing.Color.Tan;
            this.btnListEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListEquipment.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListEquipment.Location = new System.Drawing.Point(-2, 17);
            this.btnListEquipment.Name = "btnListEquipment";
            this.btnListEquipment.Size = new System.Drawing.Size(158, 41);
            this.btnListEquipment.TabIndex = 0;
            this.btnListEquipment.Text = "List Equipment Details";
            this.btnListEquipment.UseVisualStyleBackColor = false;
            this.btnListEquipment.Click += new System.EventHandler(this.btnListEquipment_Click);
            this.btnListEquipment.MouseEnter += new System.EventHandler(this.btnListEquipment_MouseEnter);
            this.btnListEquipment.MouseLeave += new System.EventHandler(this.btnListEquipment_MouseLeave);
            // 
            // btnAddEquipment
            // 
            this.btnAddEquipment.BackColor = System.Drawing.Color.Tan;
            this.btnAddEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEquipment.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEquipment.Location = new System.Drawing.Point(150, 17);
            this.btnAddEquipment.Name = "btnAddEquipment";
            this.btnAddEquipment.Size = new System.Drawing.Size(163, 41);
            this.btnAddEquipment.TabIndex = 0;
            this.btnAddEquipment.Text = "Open Controls";
            this.btnAddEquipment.UseVisualStyleBackColor = false;
            this.btnAddEquipment.Click += new System.EventHandler(this.btnAddEquipment_Click);
            this.btnAddEquipment.MouseLeave += new System.EventHandler(this.btnAddEquipment_MouseLeave);
            this.btnAddEquipment.MouseHover += new System.EventHandler(this.btnAddEquipment_MouseHover);
            // 
            // dgvEquipment
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dgvEquipment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEquipment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEquipment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEquipment.BackgroundColor = System.Drawing.Color.White;
            this.dgvEquipment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEquipment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEquipment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEquipment.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEquipment.Location = new System.Drawing.Point(320, 16);
            this.dgvEquipment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvEquipment.Name = "dgvEquipment";
            this.dgvEquipment.RowTemplate.DividerHeight = 3;
            this.dgvEquipment.Size = new System.Drawing.Size(707, 151);
            this.dgvEquipment.TabIndex = 63;
            this.dgvEquipment.Visible = false;
            this.dgvEquipment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquipment_CellClick_1);
            // 
            // pnlDeletes
            // 
            this.pnlDeletes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlDeletes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.pnlDeletes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDeletes.Controls.Add(this.panel1);
            this.pnlDeletes.Controls.Add(this.lblEquipmentStatus);
            this.pnlDeletes.Controls.Add(this.label10);
            this.pnlDeletes.Controls.Add(this.lblYearsVALID);
            this.pnlDeletes.Controls.Add(this.lblVenueCode);
            this.pnlDeletes.Controls.Add(this.lblEquipDescription);
            this.pnlDeletes.Controls.Add(this.lblEquipCode);
            this.pnlDeletes.Controls.Add(this.label12);
            this.pnlDeletes.Controls.Add(this.label11);
            this.pnlDeletes.Controls.Add(this.label9);
            this.pnlDeletes.Controls.Add(this.label7);
            this.pnlDeletes.ForeColor = System.Drawing.Color.White;
            this.pnlDeletes.Location = new System.Drawing.Point(320, 174);
            this.pnlDeletes.Name = "pnlDeletes";
            this.pnlDeletes.Size = new System.Drawing.Size(423, 210);
            this.pnlDeletes.TabIndex = 57;
            this.pnlDeletes.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnHardDeleteEquip);
            this.panel1.Controls.Add(this.btnSoftDeleteEquip);
            this.panel1.Location = new System.Drawing.Point(57, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 64);
            this.panel1.TabIndex = 12;
            // 
            // btnHardDeleteEquip
            // 
            this.btnHardDeleteEquip.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnHardDeleteEquip.BackColor = System.Drawing.Color.Tan;
            this.btnHardDeleteEquip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHardDeleteEquip.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHardDeleteEquip.Location = new System.Drawing.Point(160, 15);
            this.btnHardDeleteEquip.Name = "btnHardDeleteEquip";
            this.btnHardDeleteEquip.Size = new System.Drawing.Size(142, 47);
            this.btnHardDeleteEquip.TabIndex = 11;
            this.btnHardDeleteEquip.Text = "Hard Delete Equipment";
            this.btnHardDeleteEquip.UseVisualStyleBackColor = false;
            this.btnHardDeleteEquip.Click += new System.EventHandler(this.btnHardDeleteEquip_Click);
            // 
            // btnSoftDeleteEquip
            // 
            this.btnSoftDeleteEquip.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSoftDeleteEquip.BackColor = System.Drawing.Color.Tan;
            this.btnSoftDeleteEquip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoftDeleteEquip.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoftDeleteEquip.Location = new System.Drawing.Point(26, 15);
            this.btnSoftDeleteEquip.Name = "btnSoftDeleteEquip";
            this.btnSoftDeleteEquip.Size = new System.Drawing.Size(140, 47);
            this.btnSoftDeleteEquip.TabIndex = 10;
            this.btnSoftDeleteEquip.Text = "Soft Delete Equipment";
            this.btnSoftDeleteEquip.UseVisualStyleBackColor = false;
            this.btnSoftDeleteEquip.Click += new System.EventHandler(this.btnSoftDeleteEquip_Click);
            // 
            // lblEquipmentStatus
            // 
            this.lblEquipmentStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEquipmentStatus.AutoSize = true;
            this.lblEquipmentStatus.Location = new System.Drawing.Point(248, 94);
            this.lblEquipmentStatus.Name = "lblEquipmentStatus";
            this.lblEquipmentStatus.Size = new System.Drawing.Size(0, 16);
            this.lblEquipmentStatus.TabIndex = 9;
            // 
            // lblVenueCode
            // 
            this.lblVenueCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblVenueCode.AutoSize = true;
            this.lblVenueCode.Location = new System.Drawing.Point(248, 66);
            this.lblVenueCode.Name = "lblVenueCode";
            this.lblVenueCode.Size = new System.Drawing.Size(0, 16);
            this.lblVenueCode.TabIndex = 8;
            // 
            // lblYearsVALID
            // 
            this.lblYearsVALID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblYearsVALID.AutoSize = true;
            this.lblYearsVALID.Location = new System.Drawing.Point(251, 114);
            this.lblYearsVALID.Name = "lblYearsVALID";
            this.lblYearsVALID.Size = new System.Drawing.Size(0, 16);
            this.lblYearsVALID.TabIndex = 7;
            // 
            // lblEquipDescription
            // 
            this.lblEquipDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEquipDescription.AutoSize = true;
            this.lblEquipDescription.Location = new System.Drawing.Point(248, 35);
            this.lblEquipDescription.Name = "lblEquipDescription";
            this.lblEquipDescription.Size = new System.Drawing.Size(0, 16);
            this.lblEquipDescription.TabIndex = 6;
            // 
            // lblEquipCode
            // 
            this.lblEquipCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEquipCode.AutoSize = true;
            this.lblEquipCode.Location = new System.Drawing.Point(248, 12);
            this.lblEquipCode.Name = "lblEquipCode";
            this.lblEquipCode.Size = new System.Drawing.Size(0, 16);
            this.lblEquipCode.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 16);
            this.label12.TabIndex = 4;
            this.label12.Text = "Equipment Status:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "Venue Code:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Years Valid:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Equipment Description:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Equipment Code:";
            // 
            // pnlAddEqui
            // 
            this.pnlAddEqui.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlAddEqui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.pnlAddEqui.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddEqui.Controls.Add(this.txtValidYear);
            this.pnlAddEqui.Controls.Add(this.label6);
            this.pnlAddEqui.Controls.Add(this.cmbEquipType);
            this.pnlAddEqui.Controls.Add(this.panel4);
            this.pnlAddEqui.Controls.Add(this.dteDateR);
            this.pnlAddEqui.Controls.Add(this.label1);
            this.pnlAddEqui.Controls.Add(this.label2);
            this.pnlAddEqui.Controls.Add(this.txtEquipDesc);
            this.pnlAddEqui.Controls.Add(this.label3);
            this.pnlAddEqui.Controls.Add(this.txtBarcode);
            this.pnlAddEqui.Controls.Add(this.label4);
            this.pnlAddEqui.Controls.Add(this.cmbVenueCode);
            this.pnlAddEqui.Controls.Add(this.label5);
            this.pnlAddEqui.ForeColor = System.Drawing.Color.White;
            this.pnlAddEqui.Location = new System.Drawing.Point(-1, 3);
            this.pnlAddEqui.Name = "pnlAddEqui";
            this.pnlAddEqui.Size = new System.Drawing.Size(315, 334);
            this.pnlAddEqui.TabIndex = 55;
            this.pnlAddEqui.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackColor = System.Drawing.Color.Gold;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.btnAddEquipmentInfo);
            this.panel4.Location = new System.Drawing.Point(16, 234);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(285, 70);
            this.panel4.TabIndex = 78;
            // 
            // btnAddEquipmentInfo
            // 
            this.btnAddEquipmentInfo.BackColor = System.Drawing.Color.Tan;
            this.btnAddEquipmentInfo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEquipmentInfo.ForeColor = System.Drawing.Color.White;
            this.btnAddEquipmentInfo.Location = new System.Drawing.Point(64, 20);
            this.btnAddEquipmentInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddEquipmentInfo.Name = "btnAddEquipmentInfo";
            this.btnAddEquipmentInfo.Size = new System.Drawing.Size(151, 49);
            this.btnAddEquipmentInfo.TabIndex = 50;
            this.btnAddEquipmentInfo.Text = "ADD EQUIPMENT";
            this.btnAddEquipmentInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddEquipmentInfo.UseVisualStyleBackColor = false;
            this.btnAddEquipmentInfo.Click += new System.EventHandler(this.btnAddEquipmentInfo_Click_1);
            // 
            // dteDateR
            // 
            this.dteDateR.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteDateR.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteDateR.Location = new System.Drawing.Point(151, 97);
            this.dteDateR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dteDateR.Name = "dteDateR";
            this.dteDateR.Size = new System.Drawing.Size(151, 22);
            this.dteDateR.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 71;
            this.label1.Text = "Equipment Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 68;
            this.label2.Text = "Barcode";
            // 
            // txtEquipDesc
            // 
            this.txtEquipDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEquipDesc.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipDesc.Location = new System.Drawing.Point(151, 60);
            this.txtEquipDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEquipDesc.Multiline = true;
            this.txtEquipDesc.Name = "txtEquipDesc";
            this.txtEquipDesc.Size = new System.Drawing.Size(151, 24);
            this.txtEquipDesc.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 69;
            this.label3.Text = "Equipment Description";
            // 
            // txtBarcode
            // 
            this.txtBarcode.BackColor = System.Drawing.SystemColors.Window;
            this.txtBarcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBarcode.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(151, 28);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBarcode.Multiline = true;
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(151, 24);
            this.txtBarcode.TabIndex = 73;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 70;
            this.label4.Text = "Date Recieved";
            // 
            // cmbVenueCode
            // 
            this.cmbVenueCode.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVenueCode.FormattingEnabled = true;
            this.cmbVenueCode.Location = new System.Drawing.Point(148, 163);
            this.cmbVenueCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbVenueCode.Name = "cmbVenueCode";
            this.cmbVenueCode.Size = new System.Drawing.Size(154, 24);
            this.cmbVenueCode.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 72;
            this.label5.Text = "Venue Code";
            // 
            // pnlDasshBard
            // 
            this.pnlDasshBard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.pnlDasshBard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDasshBard.Controls.Add(this.label8);
            this.pnlDasshBard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDasshBard.ForeColor = System.Drawing.Color.White;
            this.pnlDasshBard.Location = new System.Drawing.Point(0, 0);
            this.pnlDasshBard.Name = "pnlDasshBard";
            this.pnlDasshBard.Size = new System.Drawing.Size(1048, 67);
            this.pnlDasshBard.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(372, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(260, 34);
            this.label8.TabIndex = 36;
            this.label8.Text = "Equipment Details";
            // 
            // cmbEquipType
            // 
            this.cmbEquipType.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEquipType.FormattingEnabled = true;
            this.cmbEquipType.Location = new System.Drawing.Point(148, 131);
            this.cmbEquipType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbEquipType.Name = "cmbEquipType";
            this.cmbEquipType.Size = new System.Drawing.Size(154, 24);
            this.cmbEquipType.TabIndex = 79;
            // 
            // txtValidYear
            // 
            this.txtValidYear.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValidYear.Location = new System.Drawing.Point(148, 200);
            this.txtValidYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtValidYear.Name = "txtValidYear";
            this.txtValidYear.Size = new System.Drawing.Size(154, 22);
            this.txtValidYear.TabIndex = 81;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 80;
            this.label6.Text = "Valid Year";
            // 
            // frmEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1048, 440);
            this.Controls.Add(this.pnlDasshBard);
            this.Controls.Add(this.pnlMidDisplay);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1048, 440);
            this.Name = "frmEquipment";
            this.Text = "frmEquipment";
            this.Load += new System.EventHandler(this.frmEquipment_Load);
            this.pnlMidDisplay.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipment)).EndInit();
            this.pnlDeletes.ResumeLayout(false);
            this.pnlDeletes.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlAddEqui.ResumeLayout(false);
            this.pnlAddEqui.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.pnlDasshBard.ResumeLayout(false);
            this.pnlDasshBard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMidDisplay;
        private System.Windows.Forms.Panel pnlDeletes;
        private System.Windows.Forms.Button btnHardDeleteEquip;
        private System.Windows.Forms.Button btnSoftDeleteEquip;
        private System.Windows.Forms.Label lblEquipmentStatus;
        private System.Windows.Forms.Label lblVenueCode;
        private System.Windows.Forms.Label lblYearsVALID;
        private System.Windows.Forms.Label lblEquipDescription;
        private System.Windows.Forms.Label lblEquipCode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlAddEqui;
        private System.Windows.Forms.Panel pnlDasshBard;
        private System.Windows.Forms.Button btnListEquipment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddEquipment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvEquipment;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAddEquipmentInfo;
        private System.Windows.Forms.DateTimePicker dteDateR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEquipDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbVenueCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPrinter;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ComboBox cmbEquipType;
        private System.Windows.Forms.TextBox txtValidYear;
        private System.Windows.Forms.Label label6;
    }
}
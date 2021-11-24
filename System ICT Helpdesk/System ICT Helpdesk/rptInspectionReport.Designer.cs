namespace System_ICT_Helpdesk
{
    partial class rptInspectionReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptInspectionReport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSingleLab = new System.Windows.Forms.Button();
            this.btnStaffMember = new System.Windows.Forms.Button();
            this.btnBetween = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDispalyStaff = new System.Windows.Forms.Button();
            this.btnDisplayBetween = new System.Windows.Forms.Button();
            this.lblStaffMember = new System.Windows.Forms.Label();
            this.txtStaffMember = new System.Windows.Forms.TextBox();
            this.lblVenue = new System.Windows.Forms.Label();
            this.txtSearchByLab = new System.Windows.Forms.TextBox();
            this.lblTimeDisplay = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dteStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dteEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblPrinter = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dgvSearchEquipment = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchEquipment)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSingleLab);
            this.panel1.Controls.Add(this.btnStaffMember);
            this.panel1.Controls.Add(this.btnBetween);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 59);
            this.panel1.TabIndex = 14;
            // 
            // btnSingleLab
            // 
            this.btnSingleLab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSingleLab.Location = new System.Drawing.Point(211, 24);
            this.btnSingleLab.Name = "btnSingleLab";
            this.btnSingleLab.Size = new System.Drawing.Size(88, 34);
            this.btnSingleLab.TabIndex = 2;
            this.btnSingleLab.Text = "Single Lab";
            this.btnSingleLab.UseVisualStyleBackColor = true;
            this.btnSingleLab.Click += new System.EventHandler(this.btnSingleLab_Click);
            this.btnSingleLab.MouseEnter += new System.EventHandler(this.btnSingleLab_MouseEnter);
            this.btnSingleLab.MouseLeave += new System.EventHandler(this.btnSingleLab_MouseLeave);
            // 
            // btnStaffMember
            // 
            this.btnStaffMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffMember.Location = new System.Drawing.Point(109, 24);
            this.btnStaffMember.Name = "btnStaffMember";
            this.btnStaffMember.Size = new System.Drawing.Size(109, 34);
            this.btnStaffMember.TabIndex = 1;
            this.btnStaffMember.Text = "Staff Member";
            this.btnStaffMember.UseVisualStyleBackColor = true;
            this.btnStaffMember.Click += new System.EventHandler(this.btnStaffMember_Click);
            this.btnStaffMember.MouseLeave += new System.EventHandler(this.btnStaffMember_MouseLeave);
            this.btnStaffMember.MouseHover += new System.EventHandler(this.btnStaffMember_MouseHover);
            // 
            // btnBetween
            // 
            this.btnBetween.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBetween.Location = new System.Drawing.Point(3, 24);
            this.btnBetween.Name = "btnBetween";
            this.btnBetween.Size = new System.Drawing.Size(109, 34);
            this.btnBetween.TabIndex = 0;
            this.btnBetween.Text = "Between Dates";
            this.btnBetween.UseVisualStyleBackColor = true;
            this.btnBetween.Click += new System.EventHandler(this.btnBetween_Click);
            this.btnBetween.MouseLeave += new System.EventHandler(this.btnBetween_MouseLeave);
            this.btnBetween.MouseHover += new System.EventHandler(this.btnBetween_MouseHover);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(946, 65);
            this.panel2.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gold;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(285, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 38);
            this.label3.TabIndex = 12;
            this.label3.Text = "Inspection Report";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnDispalyStaff);
            this.panel3.Controls.Add(this.btnDisplayBetween);
            this.panel3.Controls.Add(this.lblStaffMember);
            this.panel3.Controls.Add(this.txtStaffMember);
            this.panel3.Controls.Add(this.lblVenue);
            this.panel3.Controls.Add(this.txtSearchByLab);
            this.panel3.Controls.Add(this.lblTimeDisplay);
            this.panel3.Controls.Add(this.btnFind);
            this.panel3.Controls.Add(this.lblEndDate);
            this.panel3.Controls.Add(this.dteStartDate);
            this.panel3.Controls.Add(this.lblStartDate);
            this.panel3.Controls.Add(this.dteEndDate);
            this.panel3.Controls.Add(this.lblPrinter);
            this.panel3.Controls.Add(this.btnPrint);
            this.panel3.Location = new System.Drawing.Point(0, 121);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(946, 110);
            this.panel3.TabIndex = 16;
            // 
            // btnDispalyStaff
            // 
            this.btnDispalyStaff.BackColor = System.Drawing.Color.Gold;
            this.btnDispalyStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDispalyStaff.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispalyStaff.ForeColor = System.Drawing.Color.White;
            this.btnDispalyStaff.Location = new System.Drawing.Point(633, 71);
            this.btnDispalyStaff.Name = "btnDispalyStaff";
            this.btnDispalyStaff.Size = new System.Drawing.Size(75, 27);
            this.btnDispalyStaff.TabIndex = 88;
            this.btnDispalyStaff.Text = "Find";
            this.btnDispalyStaff.UseVisualStyleBackColor = false;
            this.btnDispalyStaff.Visible = false;
            this.btnDispalyStaff.Click += new System.EventHandler(this.btnDispalyStaff_Click);
            // 
            // btnDisplayBetween
            // 
            this.btnDisplayBetween.BackColor = System.Drawing.Color.Gold;
            this.btnDisplayBetween.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayBetween.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayBetween.ForeColor = System.Drawing.Color.White;
            this.btnDisplayBetween.Location = new System.Drawing.Point(633, 71);
            this.btnDisplayBetween.Name = "btnDisplayBetween";
            this.btnDisplayBetween.Size = new System.Drawing.Size(75, 27);
            this.btnDisplayBetween.TabIndex = 87;
            this.btnDisplayBetween.Text = "Find";
            this.btnDisplayBetween.UseVisualStyleBackColor = false;
            this.btnDisplayBetween.Visible = false;
            this.btnDisplayBetween.Click += new System.EventHandler(this.btnDisplayBetween_Click);
            // 
            // lblStaffMember
            // 
            this.lblStaffMember.AutoSize = true;
            this.lblStaffMember.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffMember.ForeColor = System.Drawing.Color.White;
            this.lblStaffMember.Location = new System.Drawing.Point(3, 36);
            this.lblStaffMember.Name = "lblStaffMember";
            this.lblStaffMember.Size = new System.Drawing.Size(114, 18);
            this.lblStaffMember.TabIndex = 86;
            this.lblStaffMember.Text = "Staff Member:";
            this.lblStaffMember.Visible = false;
            // 
            // txtStaffMember
            // 
            this.txtStaffMember.Location = new System.Drawing.Point(123, 32);
            this.txtStaffMember.Name = "txtStaffMember";
            this.txtStaffMember.Size = new System.Drawing.Size(145, 22);
            this.txtStaffMember.TabIndex = 85;
            this.txtStaffMember.Visible = false;
            // 
            // lblVenue
            // 
            this.lblVenue.AutoSize = true;
            this.lblVenue.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenue.ForeColor = System.Drawing.Color.White;
            this.lblVenue.Location = new System.Drawing.Point(3, 37);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(106, 18);
            this.lblVenue.TabIndex = 84;
            this.lblVenue.Text = "Enter Venue:";
            this.lblVenue.Visible = false;
            // 
            // txtSearchByLab
            // 
            this.txtSearchByLab.Location = new System.Drawing.Point(123, 32);
            this.txtSearchByLab.Name = "txtSearchByLab";
            this.txtSearchByLab.Size = new System.Drawing.Size(145, 22);
            this.txtSearchByLab.TabIndex = 82;
            this.txtSearchByLab.Visible = false;
            // 
            // lblTimeDisplay
            // 
            this.lblTimeDisplay.AutoSize = true;
            this.lblTimeDisplay.BackColor = System.Drawing.Color.White;
            this.lblTimeDisplay.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeDisplay.ForeColor = System.Drawing.Color.Black;
            this.lblTimeDisplay.Location = new System.Drawing.Point(386, 80);
            this.lblTimeDisplay.Name = "lblTimeDisplay";
            this.lblTimeDisplay.Size = new System.Drawing.Size(0, 18);
            this.lblTimeDisplay.TabIndex = 81;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Gold;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(633, 71);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 27);
            this.btnFind.TabIndex = 80;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Visible = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.ForeColor = System.Drawing.Color.White;
            this.lblEndDate.Location = new System.Drawing.Point(518, 38);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(84, 18);
            this.lblEndDate.TabIndex = 79;
            this.lblEndDate.Text = "End Date:";
            this.lblEndDate.Visible = false;
            // 
            // dteStartDate
            // 
            this.dteStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteStartDate.Location = new System.Drawing.Point(389, 34);
            this.dteStartDate.Name = "dteStartDate";
            this.dteStartDate.Size = new System.Drawing.Size(92, 22);
            this.dteStartDate.TabIndex = 76;
            this.dteStartDate.Visible = false;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.Color.White;
            this.lblStartDate.Location = new System.Drawing.Point(294, 34);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(89, 18);
            this.lblStartDate.TabIndex = 78;
            this.lblStartDate.Text = "Start Date:";
            this.lblStartDate.Visible = false;
            // 
            // dteEndDate
            // 
            this.dteEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteEndDate.Location = new System.Drawing.Point(608, 37);
            this.dteEndDate.Name = "dteEndDate";
            this.dteEndDate.Size = new System.Drawing.Size(100, 22);
            this.dteEndDate.TabIndex = 77;
            this.dteEndDate.Visible = false;
            this.dteEndDate.CloseUp += new System.EventHandler(this.dteEndDate_CloseUp);
            // 
            // lblPrinter
            // 
            this.lblPrinter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrinter.AutoSize = true;
            this.lblPrinter.BackColor = System.Drawing.Color.Red;
            this.lblPrinter.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrinter.ForeColor = System.Drawing.Color.White;
            this.lblPrinter.Location = new System.Drawing.Point(800, 2);
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
            this.btnPrint.Location = new System.Drawing.Point(862, -1);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(83, 110);
            this.btnPrint.TabIndex = 68;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            this.btnPrint.MouseLeave += new System.EventHandler(this.btnPrint_MouseLeave);
            this.btnPrint.MouseHover += new System.EventHandler(this.btnPrint_MouseHover);
            // 
            // dgvSearchEquipment
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dgvSearchEquipment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSearchEquipment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSearchEquipment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSearchEquipment.BackgroundColor = System.Drawing.Color.White;
            this.dgvSearchEquipment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSearchEquipment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSearchEquipment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSearchEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSearchEquipment.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSearchEquipment.Location = new System.Drawing.Point(4, 238);
            this.dgvSearchEquipment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvSearchEquipment.Name = "dgvSearchEquipment";
            this.dgvSearchEquipment.RowTemplate.DividerHeight = 3;
            this.dgvSearchEquipment.Size = new System.Drawing.Size(942, 121);
            this.dgvSearchEquipment.TabIndex = 67;
            // 
            // rptInspectionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(946, 362);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvSearchEquipment);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(946, 362);
            this.Name = "rptInspectionReport";
            this.Text = "frmSearchEquipment";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchEquipment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvSearchEquipment;
        private System.Windows.Forms.Label lblPrinter;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblVenue;
        private System.Windows.Forms.TextBox txtSearchByLab;
        private System.Windows.Forms.Label lblTimeDisplay;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dteStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dteEndDate;
        private System.Windows.Forms.Button btnSingleLab;
        private System.Windows.Forms.Button btnStaffMember;
        private System.Windows.Forms.Button btnBetween;
        private System.Windows.Forms.Label lblStaffMember;
        private System.Windows.Forms.TextBox txtStaffMember;
        private System.Windows.Forms.Button btnDispalyStaff;
        private System.Windows.Forms.Button btnDisplayBetween;
    }
}
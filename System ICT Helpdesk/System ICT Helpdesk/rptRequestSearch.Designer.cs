namespace System_ICT_Helpdesk
{
    partial class rptRequestSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptRequestSearch));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSelectTask = new System.Windows.Forms.Label();
            this.btnRequestByTask = new System.Windows.Forms.Button();
            this.cmbRequestByTask = new System.Windows.Forms.ComboBox();
            this.btnStaffMember = new System.Windows.Forms.Button();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnReqTaskType = new System.Windows.Forms.Button();
            this.lblStaffMember = new System.Windows.Forms.Label();
            this.txtStaffMember = new System.Windows.Forms.TextBox();
            this.lblTimeDisplay = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dteStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dteEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblPrinter = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblSelectTask);
            this.panel1.Controls.Add(this.btnRequestByTask);
            this.panel1.Controls.Add(this.cmbRequestByTask);
            this.panel1.Controls.Add(this.btnStaffMember);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(-2, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 66);
            this.panel1.TabIndex = 68;
            // 
            // lblSelectTask
            // 
            this.lblSelectTask.AutoSize = true;
            this.lblSelectTask.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectTask.ForeColor = System.Drawing.Color.White;
            this.lblSelectTask.Location = new System.Drawing.Point(391, 41);
            this.lblSelectTask.Name = "lblSelectTask";
            this.lblSelectTask.Size = new System.Drawing.Size(137, 18);
            this.lblSelectTask.TabIndex = 79;
            this.lblSelectTask.Text = "Select Task Type:";
            this.lblSelectTask.Visible = false;
            // 
            // btnRequestByTask
            // 
            this.btnRequestByTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequestByTask.Location = new System.Drawing.Point(107, 31);
            this.btnRequestByTask.Name = "btnRequestByTask";
            this.btnRequestByTask.Size = new System.Drawing.Size(113, 34);
            this.btnRequestByTask.TabIndex = 2;
            this.btnRequestByTask.Text = "Request By Task";
            this.btnRequestByTask.UseVisualStyleBackColor = true;
            this.btnRequestByTask.Click += new System.EventHandler(this.btnRequestByTask_Click);
            this.btnRequestByTask.MouseEnter += new System.EventHandler(this.btnRequestByTask_MouseEnter);
            this.btnRequestByTask.MouseLeave += new System.EventHandler(this.btnRequestByTask_MouseLeave);
            // 
            // cmbRequestByTask
            // 
            this.cmbRequestByTask.FormattingEnabled = true;
            this.cmbRequestByTask.Location = new System.Drawing.Point(534, 41);
            this.cmbRequestByTask.Name = "cmbRequestByTask";
            this.cmbRequestByTask.Size = new System.Drawing.Size(177, 24);
            this.cmbRequestByTask.TabIndex = 89;
            this.cmbRequestByTask.Visible = false;
            this.cmbRequestByTask.SelectedIndexChanged += new System.EventHandler(this.cmbRequestByTask_SelectedIndexChanged);
            // 
            // btnStaffMember
            // 
            this.btnStaffMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffMember.Location = new System.Drawing.Point(5, 31);
            this.btnStaffMember.Name = "btnStaffMember";
            this.btnStaffMember.Size = new System.Drawing.Size(109, 34);
            this.btnStaffMember.TabIndex = 1;
            this.btnStaffMember.Text = "Staff Member";
            this.btnStaffMember.UseVisualStyleBackColor = true;
            this.btnStaffMember.Click += new System.EventHandler(this.btnStaffMember_Click);
            this.btnStaffMember.MouseEnter += new System.EventHandler(this.btnStaffMember_MouseEnter);
            this.btnStaffMember.MouseLeave += new System.EventHandler(this.btnStaffMember_MouseLeave);
            // 
            // dgvSearch
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dgvSearch.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSearch.BackgroundColor = System.Drawing.Color.White;
            this.dgvSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSearch.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSearch.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSearch.Location = new System.Drawing.Point(2, 245);
            this.dgvSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.RowTemplate.DividerHeight = 3;
            this.dgvSearch.Size = new System.Drawing.Size(942, 111);
            this.dgvSearch.TabIndex = 71;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnReqTaskType);
            this.panel3.Controls.Add(this.lblStaffMember);
            this.panel3.Controls.Add(this.txtStaffMember);
            this.panel3.Controls.Add(this.lblTimeDisplay);
            this.panel3.Controls.Add(this.lblEndDate);
            this.panel3.Controls.Add(this.dteStartDate);
            this.panel3.Controls.Add(this.lblStartDate);
            this.panel3.Controls.Add(this.dteEndDate);
            this.panel3.Controls.Add(this.lblPrinter);
            this.panel3.Controls.Add(this.btnPrint);
            this.panel3.Location = new System.Drawing.Point(-2, 128);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(948, 110);
            this.panel3.TabIndex = 70;
            // 
            // btnReqTaskType
            // 
            this.btnReqTaskType.BackColor = System.Drawing.Color.Gold;
            this.btnReqTaskType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReqTaskType.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReqTaskType.ForeColor = System.Drawing.Color.White;
            this.btnReqTaskType.Location = new System.Drawing.Point(569, 50);
            this.btnReqTaskType.Name = "btnReqTaskType";
            this.btnReqTaskType.Size = new System.Drawing.Size(75, 27);
            this.btnReqTaskType.TabIndex = 87;
            this.btnReqTaskType.Text = "Find";
            this.btnReqTaskType.UseVisualStyleBackColor = false;
            this.btnReqTaskType.Visible = false;
            this.btnReqTaskType.Click += new System.EventHandler(this.btnReqTaskType_Click);
            // 
            // lblStaffMember
            // 
            this.lblStaffMember.AutoSize = true;
            this.lblStaffMember.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffMember.ForeColor = System.Drawing.Color.White;
            this.lblStaffMember.Location = new System.Drawing.Point(10, 36);
            this.lblStaffMember.Name = "lblStaffMember";
            this.lblStaffMember.Size = new System.Drawing.Size(114, 18);
            this.lblStaffMember.TabIndex = 86;
            this.lblStaffMember.Text = "Staff Member:";
            this.lblStaffMember.Visible = false;
            // 
            // txtStaffMember
            // 
            this.txtStaffMember.Location = new System.Drawing.Point(130, 32);
            this.txtStaffMember.Name = "txtStaffMember";
            this.txtStaffMember.Size = new System.Drawing.Size(145, 22);
            this.txtStaffMember.TabIndex = 85;
            this.txtStaffMember.Visible = false;
            // 
            // lblTimeDisplay
            // 
            this.lblTimeDisplay.AutoSize = true;
            this.lblTimeDisplay.BackColor = System.Drawing.Color.White;
            this.lblTimeDisplay.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeDisplay.ForeColor = System.Drawing.Color.Black;
            this.lblTimeDisplay.Location = new System.Drawing.Point(659, 80);
            this.lblTimeDisplay.Name = "lblTimeDisplay";
            this.lblTimeDisplay.Size = new System.Drawing.Size(0, 18);
            this.lblTimeDisplay.TabIndex = 81;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.ForeColor = System.Drawing.Color.White;
            this.lblEndDate.Location = new System.Drawing.Point(294, 80);
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
            this.dteStartDate.Size = new System.Drawing.Size(144, 22);
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
            this.dteEndDate.Location = new System.Drawing.Point(389, 76);
            this.dteEndDate.Name = "dteEndDate";
            this.dteEndDate.Size = new System.Drawing.Size(145, 22);
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
            this.lblPrinter.Location = new System.Drawing.Point(802, 2);
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
            this.btnPrint.Location = new System.Drawing.Point(864, -1);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(83, 110);
            this.btnPrint.TabIndex = 68;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(946, 65);
            this.panel2.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gold;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(298, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 38);
            this.label3.TabIndex = 12;
            this.label3.Text = "Request Report";
            // 
            // rptRequestSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(946, 362);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvSearch);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(946, 362);
            this.Name = "rptRequestSearch";
            this.Text = "frmRequestSearch";
            this.Load += new System.EventHandler(this.rptRequestSearch_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRequestByTask;
        private System.Windows.Forms.Button btnStaffMember;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnReqTaskType;
        private System.Windows.Forms.Label lblStaffMember;
        private System.Windows.Forms.TextBox txtStaffMember;
        private System.Windows.Forms.Label lblTimeDisplay;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dteStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dteEndDate;
        private System.Windows.Forms.Label lblPrinter;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSelectTask;
        private System.Windows.Forms.ComboBox cmbRequestByTask;
    }
}
namespace System_ICT_Helpdesk
{
    partial class rptTutorRequest
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptTutorRequest));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTimeDisplay = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblPrinter = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dteStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dteEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbVenue = new System.Windows.Forms.ComboBox();
            this.lblSelectVenue = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvTutorReports = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSelectEquip = new System.Windows.Forms.Button();
            this.btnDateTime = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutorReports)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblTimeDisplay);
            this.panel3.Controls.Add(this.btnFind);
            this.panel3.Controls.Add(this.lblPrinter);
            this.panel3.Controls.Add(this.lblEndDate);
            this.panel3.Controls.Add(this.dteStartDate);
            this.panel3.Controls.Add(this.lblStartDate);
            this.panel3.Controls.Add(this.dteEndDate);
            this.panel3.Controls.Add(this.btnPrint);
            this.panel3.Location = new System.Drawing.Point(0, 150);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(946, 78);
            this.panel3.TabIndex = 24;
            // 
            // lblTimeDisplay
            // 
            this.lblTimeDisplay.AutoSize = true;
            this.lblTimeDisplay.BackColor = System.Drawing.Color.White;
            this.lblTimeDisplay.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeDisplay.ForeColor = System.Drawing.Color.Black;
            this.lblTimeDisplay.Location = new System.Drawing.Point(584, 58);
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
            this.btnFind.Location = new System.Drawing.Point(483, 24);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 27);
            this.btnFind.TabIndex = 80;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            this.btnFind.MouseEnter += new System.EventHandler(this.btnFind_MouseEnter);
            // 
            // lblPrinter
            // 
            this.lblPrinter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrinter.AutoSize = true;
            this.lblPrinter.BackColor = System.Drawing.Color.Red;
            this.lblPrinter.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrinter.ForeColor = System.Drawing.Color.White;
            this.lblPrinter.Location = new System.Drawing.Point(818, 6);
            this.lblPrinter.Name = "lblPrinter";
            this.lblPrinter.Size = new System.Drawing.Size(0, 22);
            this.lblPrinter.TabIndex = 69;
            this.lblPrinter.Visible = false;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.ForeColor = System.Drawing.Color.White;
            this.lblEndDate.Location = new System.Drawing.Point(237, 30);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(84, 18);
            this.lblEndDate.TabIndex = 79;
            this.lblEndDate.Text = "End Date:";
            // 
            // dteStartDate
            // 
            this.dteStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteStartDate.Location = new System.Drawing.Point(98, 25);
            this.dteStartDate.Name = "dteStartDate";
            this.dteStartDate.Size = new System.Drawing.Size(100, 22);
            this.dteStartDate.TabIndex = 76;
            this.dteStartDate.MouseEnter += new System.EventHandler(this.dteStartDate_MouseEnter);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.Color.White;
            this.lblStartDate.Location = new System.Drawing.Point(3, 29);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(89, 18);
            this.lblStartDate.TabIndex = 78;
            this.lblStartDate.Text = "Start Date:";
            // 
            // dteEndDate
            // 
            this.dteEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteEndDate.Location = new System.Drawing.Point(349, 27);
            this.dteEndDate.Name = "dteEndDate";
            this.dteEndDate.Size = new System.Drawing.Size(100, 22);
            this.dteEndDate.TabIndex = 77;
            this.dteEndDate.CloseUp += new System.EventHandler(this.dteEndDate_CloseUp);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.BackgroundImage")));
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrint.Location = new System.Drawing.Point(862, -1);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(83, 78);
            this.btnPrint.TabIndex = 68;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            this.btnPrint.MouseLeave += new System.EventHandler(this.btnPrint_MouseLeave);
            this.btnPrint.MouseHover += new System.EventHandler(this.btnPrint_MouseHover);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.Gold;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(822, 28);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(67, 29);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.MouseEnter += new System.EventHandler(this.btnSearch_MouseEnter);
            // 
            // cmbVenue
            // 
            this.cmbVenue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmbVenue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVenue.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbVenue.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVenue.FormattingEnabled = true;
            this.cmbVenue.Location = new System.Drawing.Point(119, 31);
            this.cmbVenue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbVenue.Name = "cmbVenue";
            this.cmbVenue.Size = new System.Drawing.Size(202, 26);
            this.cmbVenue.TabIndex = 0;
            this.cmbVenue.SelectedIndexChanged += new System.EventHandler(this.frmTutorReport_SelectedIndexChanged);
            this.cmbVenue.MouseEnter += new System.EventHandler(this.cmbVenue_MouseEnter);
            // 
            // lblSelectVenue
            // 
            this.lblSelectVenue.AutoSize = true;
            this.lblSelectVenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.lblSelectVenue.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectVenue.Location = new System.Drawing.Point(1, 39);
            this.lblSelectVenue.Name = "lblSelectVenue";
            this.lblSelectVenue.Size = new System.Drawing.Size(106, 18);
            this.lblSelectVenue.TabIndex = 1;
            this.lblSelectVenue.Text = "Select Venue:";
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.lblSearch.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(584, 14);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(147, 18);
            this.lblSearch.TabIndex = 5;
            this.lblSearch.Text = "Search By Module:";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(582, 39);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(214, 18);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.MouseEnter += new System.EventHandler(this.txtSearch_MouseEnter);
            this.txtSearch.Validating += new System.ComponentModel.CancelEventHandler(this.txtSearch_Validating);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(946, 48);
            this.panel2.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gold;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(285, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(377, 38);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tutor Requests Report";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dgvTutorReports
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dgvTutorReports.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTutorReports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTutorReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTutorReports.BackgroundColor = System.Drawing.Color.White;
            this.dgvTutorReports.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTutorReports.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTutorReports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTutorReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTutorReports.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTutorReports.Location = new System.Drawing.Point(0, 235);
            this.dgvTutorReports.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvTutorReports.Name = "dgvTutorReports";
            this.dgvTutorReports.RowTemplate.DividerHeight = 3;
            this.dgvTutorReports.Size = new System.Drawing.Size(946, 125);
            this.dgvTutorReports.TabIndex = 67;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.lblSearch);
            this.panel1.Controls.Add(this.cmbVenue);
            this.panel1.Controls.Add(this.lblSelectVenue);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 80);
            this.panel1.TabIndex = 73;
            // 
            // btnSelectEquip
            // 
            this.btnSelectEquip.BackColor = System.Drawing.Color.Gold;
            this.btnSelectEquip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectEquip.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectEquip.Location = new System.Drawing.Point(212, 121);
            this.btnSelectEquip.Name = "btnSelectEquip";
            this.btnSelectEquip.Size = new System.Drawing.Size(92, 30);
            this.btnSelectEquip.TabIndex = 79;
            this.btnSelectEquip.Text = "By Name";
            this.btnSelectEquip.UseVisualStyleBackColor = false;
            this.btnSelectEquip.Visible = false;
            this.btnSelectEquip.Click += new System.EventHandler(this.btnSelectEquip_Click);
            this.btnSelectEquip.MouseEnter += new System.EventHandler(this.btnSelectEquip_MouseEnter);
            // 
            // btnDateTime
            // 
            this.btnDateTime.BackColor = System.Drawing.Color.Gold;
            this.btnDateTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDateTime.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDateTime.Location = new System.Drawing.Point(136, 121);
            this.btnDateTime.Name = "btnDateTime";
            this.btnDateTime.Size = new System.Drawing.Size(79, 30);
            this.btnDateTime.TabIndex = 78;
            this.btnDateTime.Text = "By Date";
            this.btnDateTime.UseVisualStyleBackColor = false;
            this.btnDateTime.Visible = false;
            this.btnDateTime.Click += new System.EventHandler(this.btnDateTime_Click);
            this.btnDateTime.MouseEnter += new System.EventHandler(this.btnDateTime_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 80;
            this.label1.Text = "Search:";
            // 
            // rptTutorRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(946, 362);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectEquip);
            this.Controls.Add(this.btnDateTime);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvTutorReports);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(946, 362);
            this.Name = "rptTutorRequest";
            this.Text = "frmTutorRequestSearch";
            this.Load += new System.EventHandler(this.frmTutorRequestSearch_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutorReports)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbVenue;
        private System.Windows.Forms.Label lblSelectVenue;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dgvTutorReports;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPrinter;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSelectEquip;
        private System.Windows.Forms.Button btnDateTime;
        private System.Windows.Forms.Label lblTimeDisplay;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dteStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dteEndDate;
        private System.Windows.Forms.Label label1;
    }
}
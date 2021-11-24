namespace System_ICT_Helpdesk
{
    partial class frmTutor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTutor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.cmbRequestID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStartTime = new System.Windows.Forms.ComboBox();
            this.cmbModule = new System.Windows.Forms.ComboBox();
            this.cmbVenue = new System.Windows.Forms.ComboBox();
            this.cmbEndTime = new System.Windows.Forms.ComboBox();
            this.dteTutor = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblPrinter = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pnlBtn = new System.Windows.Forms.Panel();
            this.btnList = new System.Windows.Forms.Button();
            this.btnOpenCotrols = new System.Windows.Forms.Button();
            this.dgvTutor = new System.Windows.Forms.DataGridView();
            this.panel5.SuspendLayout();
            this.pnlControl.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutor)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(326, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(300, 34);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tutor Request Details";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel5.BackColor = System.Drawing.Color.Gold;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.btnAdd);
            this.panel5.Location = new System.Drawing.Point(61, 301);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(197, 50);
            this.panel5.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(47, 20);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 28);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlControl
            // 
            this.pnlControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.pnlControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControl.Controls.Add(this.cmbRequestID);
            this.pnlControl.Controls.Add(this.label1);
            this.pnlControl.Controls.Add(this.panel5);
            this.pnlControl.Controls.Add(this.cmbStartTime);
            this.pnlControl.Controls.Add(this.cmbModule);
            this.pnlControl.Controls.Add(this.cmbVenue);
            this.pnlControl.Controls.Add(this.cmbEndTime);
            this.pnlControl.Controls.Add(this.dteTutor);
            this.pnlControl.Controls.Add(this.label5);
            this.pnlControl.Controls.Add(this.label2);
            this.pnlControl.Controls.Add(this.label3);
            this.pnlControl.Controls.Add(this.label4);
            this.pnlControl.Controls.Add(this.label6);
            this.pnlControl.ForeColor = System.Drawing.Color.White;
            this.pnlControl.Location = new System.Drawing.Point(0, 89);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(333, 351);
            this.pnlControl.TabIndex = 24;
            this.pnlControl.Visible = false;
            // 
            // cmbRequestID
            // 
            this.cmbRequestID.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRequestID.FormattingEnabled = true;
            this.cmbRequestID.Location = new System.Drawing.Point(151, 43);
            this.cmbRequestID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbRequestID.Name = "cmbRequestID";
            this.cmbRequestID.Size = new System.Drawing.Size(161, 26);
            this.cmbRequestID.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Request Description";
            // 
            // cmbStartTime
            // 
            this.cmbStartTime.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStartTime.FormattingEnabled = true;
            this.cmbStartTime.Location = new System.Drawing.Point(151, 178);
            this.cmbStartTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbStartTime.Name = "cmbStartTime";
            this.cmbStartTime.Size = new System.Drawing.Size(161, 26);
            this.cmbStartTime.TabIndex = 16;
            this.cmbStartTime.SelectedIndexChanged += new System.EventHandler(this.cmbStartTime_SelectedIndexChanged_1);
            // 
            // cmbModule
            // 
            this.cmbModule.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModule.FormattingEnabled = true;
            this.cmbModule.Location = new System.Drawing.Point(151, 77);
            this.cmbModule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbModule.Name = "cmbModule";
            this.cmbModule.Size = new System.Drawing.Size(161, 26);
            this.cmbModule.TabIndex = 14;
            // 
            // cmbVenue
            // 
            this.cmbVenue.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVenue.FormattingEnabled = true;
            this.cmbVenue.Location = new System.Drawing.Point(151, 109);
            this.cmbVenue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbVenue.Name = "cmbVenue";
            this.cmbVenue.Size = new System.Drawing.Size(161, 26);
            this.cmbVenue.TabIndex = 15;
            // 
            // cmbEndTime
            // 
            this.cmbEndTime.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEndTime.FormattingEnabled = true;
            this.cmbEndTime.Location = new System.Drawing.Point(151, 212);
            this.cmbEndTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbEndTime.Name = "cmbEndTime";
            this.cmbEndTime.Size = new System.Drawing.Size(161, 26);
            this.cmbEndTime.TabIndex = 17;
            this.cmbEndTime.SelectedIndexChanged += new System.EventHandler(this.cmbEndTime_SelectedIndexChanged_1);
            // 
            // dteTutor
            // 
            this.dteTutor.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteTutor.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteTutor.Location = new System.Drawing.Point(151, 143);
            this.dteTutor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dteTutor.Name = "dteTutor";
            this.dteTutor.Size = new System.Drawing.Size(161, 25);
            this.dteTutor.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Start Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Module Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Venue Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "End Time";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1048, 97);
            this.panel4.TabIndex = 27;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.Gold;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.lblPrinter);
            this.panel6.Controls.Add(this.btnPrint);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Location = new System.Drawing.Point(-1, 41);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1048, 55);
            this.panel6.TabIndex = 10;
            // 
            // lblPrinter
            // 
            this.lblPrinter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrinter.AutoSize = true;
            this.lblPrinter.BackColor = System.Drawing.Color.Red;
            this.lblPrinter.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrinter.ForeColor = System.Drawing.Color.White;
            this.lblPrinter.Location = new System.Drawing.Point(902, 0);
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
            this.btnPrint.Size = new System.Drawing.Size(83, 55);
            this.btnPrint.TabIndex = 68;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            this.btnPrint.MouseLeave += new System.EventHandler(this.btnPrint_MouseLeave);
            this.btnPrint.MouseHover += new System.EventHandler(this.btnPrint_MouseHover);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.pnlButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlButtons.Controls.Add(this.pnlBtn);
            this.pnlButtons.ForeColor = System.Drawing.Color.White;
            this.pnlButtons.Location = new System.Drawing.Point(333, 302);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(715, 139);
            this.pnlButtons.TabIndex = 28;
            // 
            // pnlBtn
            // 
            this.pnlBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlBtn.BackColor = System.Drawing.Color.Gold;
            this.pnlBtn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBtn.Controls.Add(this.btnList);
            this.pnlBtn.Controls.Add(this.btnOpenCotrols);
            this.pnlBtn.ForeColor = System.Drawing.Color.White;
            this.pnlBtn.Location = new System.Drawing.Point(3, 6);
            this.pnlBtn.Name = "pnlBtn";
            this.pnlBtn.Size = new System.Drawing.Size(389, 68);
            this.pnlBtn.TabIndex = 57;
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.Tan;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.Location = new System.Drawing.Point(179, 22);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(185, 39);
            this.btnList.TabIndex = 53;
            this.btnList.Text = "List Tutor Request";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.MouseEnter += new System.EventHandler(this.btnList_MouseEnter);
            this.btnList.MouseLeave += new System.EventHandler(this.btnList_MouseLeave);
            // 
            // btnOpenCotrols
            // 
            this.btnOpenCotrols.BackColor = System.Drawing.Color.Tan;
            this.btnOpenCotrols.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenCotrols.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenCotrols.Location = new System.Drawing.Point(22, 22);
            this.btnOpenCotrols.Name = "btnOpenCotrols";
            this.btnOpenCotrols.Size = new System.Drawing.Size(157, 39);
            this.btnOpenCotrols.TabIndex = 54;
            this.btnOpenCotrols.Text = "Open Controls";
            this.btnOpenCotrols.UseVisualStyleBackColor = false;
            this.btnOpenCotrols.MouseEnter += new System.EventHandler(this.btnOpenCotrols_MouseEnter);
            this.btnOpenCotrols.MouseLeave += new System.EventHandler(this.btnOpenCotrols_MouseLeave);
            // 
            // dgvTutor
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dgvTutor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTutor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTutor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTutor.BackgroundColor = System.Drawing.Color.White;
            this.dgvTutor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTutor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTutor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTutor.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTutor.Location = new System.Drawing.Point(339, 104);
            this.dgvTutor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvTutor.Name = "dgvTutor";
            this.dgvTutor.RowTemplate.DividerHeight = 3;
            this.dgvTutor.Size = new System.Drawing.Size(697, 191);
            this.dgvTutor.TabIndex = 67;
            this.dgvTutor.Visible = false;
            // 
            // frmTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1048, 440);
            this.Controls.Add(this.dgvTutor);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnlControl);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1048, 440);
            this.Name = "frmTutor";
            this.Text = "frmTutor";
            this.Load += new System.EventHandler(this.frmTutor_Load);
            this.panel5.ResumeLayout(false);
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbStartTime;
        private System.Windows.Forms.ComboBox cmbModule;
        private System.Windows.Forms.ComboBox cmbVenue;
        private System.Windows.Forms.ComboBox cmbEndTime;
        private System.Windows.Forms.DateTimePicker dteTutor;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Panel pnlBtn;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnOpenCotrols;
        private System.Windows.Forms.DataGridView dgvTutor;
        private System.Windows.Forms.Label lblPrinter;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ComboBox cmbRequestID;
        private System.Windows.Forms.Label label1;
    }
}
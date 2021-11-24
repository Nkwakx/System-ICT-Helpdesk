namespace System_ICT_Helpdesk
{
    partial class frmDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartment));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnList = new System.Windows.Forms.Button();
            this.btnOpenCotrols = new System.Windows.Forms.Button();
            this.pnlBtn = new System.Windows.Forms.Panel();
            this.btnDeleteFromDep = new System.Windows.Forms.Button();
            this.btnAddDep = new System.Windows.Forms.Button();
            this.btnUpdateDep = new System.Windows.Forms.Button();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.txtDepEmail = new System.Windows.Forms.TextBox();
            this.txtDepName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDepContactNo = new System.Windows.Forms.TextBox();
            this.lblReferenc = new System.Windows.Forms.Label();
            this.cmbBuildingName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvDepartment = new System.Windows.Forms.DataGridView();
            this.pnlButtons.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlBtn.SuspendLayout();
            this.pnlControl.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButtons
            // 
            this.pnlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.pnlButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlButtons.Controls.Add(this.panel2);
            this.pnlButtons.Controls.Add(this.pnlBtn);
            this.pnlButtons.Location = new System.Drawing.Point(0, 315);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(1048, 125);
            this.pnlButtons.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnList);
            this.panel2.Controls.Add(this.btnOpenCotrols);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(415, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(377, 64);
            this.panel2.TabIndex = 56;
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.Tan;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.Location = new System.Drawing.Point(179, 22);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(173, 39);
            this.btnList.TabIndex = 53;
            this.btnList.Text = "List Department";
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
            // pnlBtn
            // 
            this.pnlBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlBtn.BackColor = System.Drawing.Color.Gold;
            this.pnlBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBtn.Controls.Add(this.btnDeleteFromDep);
            this.pnlBtn.Controls.Add(this.btnAddDep);
            this.pnlBtn.Controls.Add(this.btnUpdateDep);
            this.pnlBtn.Location = new System.Drawing.Point(0, -1);
            this.pnlBtn.Name = "pnlBtn";
            this.pnlBtn.Size = new System.Drawing.Size(373, 65);
            this.pnlBtn.TabIndex = 17;
            this.pnlBtn.Visible = false;
            // 
            // btnDeleteFromDep
            // 
            this.btnDeleteFromDep.BackColor = System.Drawing.Color.Tan;
            this.btnDeleteFromDep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteFromDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteFromDep.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFromDep.ForeColor = System.Drawing.Color.White;
            this.btnDeleteFromDep.Location = new System.Drawing.Point(133, 24);
            this.btnDeleteFromDep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteFromDep.Name = "btnDeleteFromDep";
            this.btnDeleteFromDep.Size = new System.Drawing.Size(114, 40);
            this.btnDeleteFromDep.TabIndex = 12;
            this.btnDeleteFromDep.Text = "DELETE";
            this.btnDeleteFromDep.UseVisualStyleBackColor = false;
            this.btnDeleteFromDep.Click += new System.EventHandler(this.btnDeleteFromDep_Click);
            // 
            // btnAddDep
            // 
            this.btnAddDep.BackColor = System.Drawing.Color.Tan;
            this.btnAddDep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDep.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDep.ForeColor = System.Drawing.Color.White;
            this.btnAddDep.Location = new System.Drawing.Point(28, 24);
            this.btnAddDep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddDep.Name = "btnAddDep";
            this.btnAddDep.Size = new System.Drawing.Size(111, 40);
            this.btnAddDep.TabIndex = 10;
            this.btnAddDep.Text = "ADD INFO";
            this.btnAddDep.UseVisualStyleBackColor = false;
            this.btnAddDep.Click += new System.EventHandler(this.btnAddDep_Click);
            // 
            // btnUpdateDep
            // 
            this.btnUpdateDep.BackColor = System.Drawing.Color.Tan;
            this.btnUpdateDep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateDep.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDep.ForeColor = System.Drawing.Color.White;
            this.btnUpdateDep.Location = new System.Drawing.Point(242, 24);
            this.btnUpdateDep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdateDep.Name = "btnUpdateDep";
            this.btnUpdateDep.Size = new System.Drawing.Size(95, 40);
            this.btnUpdateDep.TabIndex = 11;
            this.btnUpdateDep.Text = "UPDATE";
            this.btnUpdateDep.UseVisualStyleBackColor = false;
            this.btnUpdateDep.Click += new System.EventHandler(this.btnUpdateDep_Click);
            // 
            // pnlControl
            // 
            this.pnlControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.pnlControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControl.Controls.Add(this.txtDepEmail);
            this.pnlControl.Controls.Add(this.txtDepName);
            this.pnlControl.Controls.Add(this.label4);
            this.pnlControl.Controls.Add(this.txtDepContactNo);
            this.pnlControl.Controls.Add(this.lblReferenc);
            this.pnlControl.Controls.Add(this.cmbBuildingName);
            this.pnlControl.Controls.Add(this.label1);
            this.pnlControl.Controls.Add(this.label2);
            this.pnlControl.Controls.Add(this.label3);
            this.pnlControl.Location = new System.Drawing.Point(0, 101);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(374, 208);
            this.pnlControl.TabIndex = 21;
            this.pnlControl.Visible = false;
            // 
            // txtDepEmail
            // 
            this.txtDepEmail.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepEmail.ForeColor = System.Drawing.Color.Black;
            this.txtDepEmail.Location = new System.Drawing.Point(134, 132);
            this.txtDepEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDepEmail.Name = "txtDepEmail";
            this.txtDepEmail.Size = new System.Drawing.Size(211, 22);
            this.txtDepEmail.TabIndex = 7;
            this.txtDepEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtDepEmail_Validating);
            // 
            // txtDepName
            // 
            this.txtDepName.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepName.ForeColor = System.Drawing.Color.Black;
            this.txtDepName.Location = new System.Drawing.Point(134, 32);
            this.txtDepName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDepName.Name = "txtDepName";
            this.txtDepName.Size = new System.Drawing.Size(211, 22);
            this.txtDepName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email Address";
            // 
            // txtDepContactNo
            // 
            this.txtDepContactNo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepContactNo.ForeColor = System.Drawing.Color.Black;
            this.txtDepContactNo.Location = new System.Drawing.Point(134, 99);
            this.txtDepContactNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDepContactNo.Name = "txtDepContactNo";
            this.txtDepContactNo.Size = new System.Drawing.Size(211, 22);
            this.txtDepContactNo.TabIndex = 6;
            this.txtDepContactNo.Validating += new System.ComponentModel.CancelEventHandler(this.txtDepContactNo_Validating);
            // 
            // lblReferenc
            // 
            this.lblReferenc.AutoSize = true;
            this.lblReferenc.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferenc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblReferenc.Image = ((System.Drawing.Image)(resources.GetObject("lblReferenc.Image")));
            this.lblReferenc.Location = new System.Drawing.Point(46, -53);
            this.lblReferenc.Name = "lblReferenc";
            this.lblReferenc.Size = new System.Drawing.Size(0, 18);
            this.lblReferenc.TabIndex = 14;
            // 
            // cmbBuildingName
            // 
            this.cmbBuildingName.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBuildingName.ForeColor = System.Drawing.Color.Black;
            this.cmbBuildingName.FormattingEnabled = true;
            this.cmbBuildingName.Location = new System.Drawing.Point(134, 65);
            this.cmbBuildingName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbBuildingName.Name = "cmbBuildingName";
            this.cmbBuildingName.Size = new System.Drawing.Size(211, 24);
            this.cmbBuildingName.TabIndex = 9;
            this.cmbBuildingName.Validating += new System.ComponentModel.CancelEventHandler(this.cmbBuildingName_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Department Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Building Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact Number";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1048, 95);
            this.panel4.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(-1, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 53);
            this.panel1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(372, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 31);
            this.label5.TabIndex = 14;
            this.label5.Text = "Department Details";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dgvDepartment
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dgvDepartment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDepartment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepartment.BackgroundColor = System.Drawing.Color.White;
            this.dgvDepartment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDepartment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDepartment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDepartment.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDepartment.Location = new System.Drawing.Point(380, 102);
            this.dgvDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDepartment.Name = "dgvDepartment";
            this.dgvDepartment.RowTemplate.DividerHeight = 3;
            this.dgvDepartment.Size = new System.Drawing.Size(656, 207);
            this.dgvDepartment.TabIndex = 65;
            this.dgvDepartment.Visible = false;
            this.dgvDepartment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepartment_CellClick_1);
            // 
            // frmDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1048, 440);
            this.Controls.Add(this.dgvDepartment);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnlControl);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1048, 440);
            this.Name = "frmDepartment";
            this.Text = "frmDepartment";
            this.Load += new System.EventHandler(this.frmDepartment_Load);
            this.pnlButtons.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlBtn.ResumeLayout(false);
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Panel pnlBtn;
        private System.Windows.Forms.Button btnDeleteFromDep;
        private System.Windows.Forms.Button btnAddDep;
        private System.Windows.Forms.Button btnUpdateDep;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblReferenc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtDepEmail;
        private System.Windows.Forms.TextBox txtDepName;
        private System.Windows.Forms.TextBox txtDepContactNo;
        private System.Windows.Forms.ComboBox cmbBuildingName;
        private System.Windows.Forms.DataGridView dgvDepartment;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnOpenCotrols;
        private System.Windows.Forms.Panel panel1;
    }
}
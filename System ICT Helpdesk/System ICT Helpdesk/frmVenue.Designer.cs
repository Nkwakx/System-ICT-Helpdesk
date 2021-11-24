namespace System_ICT_Helpdesk
{
    partial class frmVenue
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenue));
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAddVenue = new System.Windows.Forms.Button();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.cmbBuildingName = new System.Windows.Forms.ComboBox();
            this.cmbFloorName = new System.Windows.Forms.ComboBox();
            this.txtVenueCode = new System.Windows.Forms.TextBox();
            this.txtVenueCapacity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pnlBtn = new System.Windows.Forms.Panel();
            this.btnList = new System.Windows.Forms.Button();
            this.btnOpenCotrols = new System.Windows.Forms.Button();
            this.dgvVenue = new System.Windows.Forms.DataGridView();
            this.lblPrinter = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenue)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackColor = System.Drawing.Color.Gold;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.btnAddVenue);
            this.panel4.Location = new System.Drawing.Point(89, 203);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(205, 53);
            this.panel4.TabIndex = 18;
            // 
            // btnAddVenue
            // 
            this.btnAddVenue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnAddVenue.BackColor = System.Drawing.Color.Tan;
            this.btnAddVenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddVenue.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVenue.Location = new System.Drawing.Point(42, 14);
            this.btnAddVenue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddVenue.Name = "btnAddVenue";
            this.btnAddVenue.Size = new System.Drawing.Size(101, 37);
            this.btnAddVenue.TabIndex = 9;
            this.btnAddVenue.Text = "ADD";
            this.btnAddVenue.UseVisualStyleBackColor = false;
            this.btnAddVenue.Click += new System.EventHandler(this.btnAddVenue_Click);
            // 
            // pnlControl
            // 
            this.pnlControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.pnlControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControl.Controls.Add(this.panel4);
            this.pnlControl.Controls.Add(this.cmbBuildingName);
            this.pnlControl.Controls.Add(this.cmbFloorName);
            this.pnlControl.Controls.Add(this.txtVenueCode);
            this.pnlControl.Controls.Add(this.txtVenueCapacity);
            this.pnlControl.Controls.Add(this.label3);
            this.pnlControl.Controls.Add(this.label4);
            this.pnlControl.Controls.Add(this.label2);
            this.pnlControl.Controls.Add(this.label1);
            this.pnlControl.ForeColor = System.Drawing.Color.White;
            this.pnlControl.Location = new System.Drawing.Point(0, 91);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(379, 261);
            this.pnlControl.TabIndex = 19;
            this.pnlControl.Visible = false;
            // 
            // cmbBuildingName
            // 
            this.cmbBuildingName.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBuildingName.FormattingEnabled = true;
            this.cmbBuildingName.Location = new System.Drawing.Point(167, 127);
            this.cmbBuildingName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbBuildingName.Name = "cmbBuildingName";
            this.cmbBuildingName.Size = new System.Drawing.Size(185, 26);
            this.cmbBuildingName.TabIndex = 15;
            // 
            // cmbFloorName
            // 
            this.cmbFloorName.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFloorName.FormattingEnabled = true;
            this.cmbFloorName.Location = new System.Drawing.Point(167, 93);
            this.cmbFloorName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbFloorName.Name = "cmbFloorName";
            this.cmbFloorName.Size = new System.Drawing.Size(185, 26);
            this.cmbFloorName.TabIndex = 16;
            // 
            // txtVenueCode
            // 
            this.txtVenueCode.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVenueCode.Location = new System.Drawing.Point(167, 27);
            this.txtVenueCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVenueCode.Name = "txtVenueCode";
            this.txtVenueCode.Size = new System.Drawing.Size(185, 25);
            this.txtVenueCode.TabIndex = 13;
            // 
            // txtVenueCapacity
            // 
            this.txtVenueCapacity.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVenueCapacity.Location = new System.Drawing.Point(167, 60);
            this.txtVenueCapacity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVenueCapacity.Name = "txtVenueCapacity";
            this.txtVenueCapacity.Size = new System.Drawing.Size(185, 25);
            this.txtVenueCapacity.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Floor Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Building Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Venue Capacity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Venue Code";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gold;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(373, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 34);
            this.label6.TabIndex = 15;
            this.label6.Text = "Venue Details";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1048, 97);
            this.panel2.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Gold;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblPrinter);
            this.panel3.Controls.Add(this.btnPrint);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(-1, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1048, 55);
            this.panel3.TabIndex = 10;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.pnlButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlButtons.Controls.Add(this.pnlBtn);
            this.pnlButtons.ForeColor = System.Drawing.Color.White;
            this.pnlButtons.Location = new System.Drawing.Point(0, 348);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(1048, 93);
            this.pnlButtons.TabIndex = 21;
            // 
            // pnlBtn
            // 
            this.pnlBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlBtn.BackColor = System.Drawing.Color.Gold;
            this.pnlBtn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBtn.Controls.Add(this.btnList);
            this.pnlBtn.Controls.Add(this.btnOpenCotrols);
            this.pnlBtn.ForeColor = System.Drawing.Color.White;
            this.pnlBtn.Location = new System.Drawing.Point(379, -1);
            this.pnlBtn.Name = "pnlBtn";
            this.pnlBtn.Size = new System.Drawing.Size(403, 72);
            this.pnlBtn.TabIndex = 57;
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.Tan;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.Location = new System.Drawing.Point(179, 22);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(191, 39);
            this.btnList.TabIndex = 53;
            this.btnList.Text = "List Venue Names";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.btnList.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
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
            // dgvVenue
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            this.dgvVenue.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVenue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVenue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVenue.BackgroundColor = System.Drawing.Color.White;
            this.dgvVenue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVenue.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVenue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvVenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVenue.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvVenue.Location = new System.Drawing.Point(385, 104);
            this.dgvVenue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvVenue.Name = "dgvVenue";
            this.dgvVenue.RowTemplate.DividerHeight = 3;
            this.dgvVenue.Size = new System.Drawing.Size(654, 237);
            this.dgvVenue.TabIndex = 67;
            this.dgvVenue.Visible = false;
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
            // frmVenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1048, 440);
            this.Controls.Add(this.dgvVenue);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlControl);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1048, 440);
            this.Name = "frmVenue";
            this.Text = "frmVenue";
            this.Load += new System.EventHandler(this.frmVenue_Load);
            this.panel4.ResumeLayout(false);
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAddVenue;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbBuildingName;
        private System.Windows.Forms.ComboBox cmbFloorName;
        private System.Windows.Forms.TextBox txtVenueCode;
        private System.Windows.Forms.TextBox txtVenueCapacity;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Panel pnlBtn;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnOpenCotrols;
        private System.Windows.Forms.DataGridView dgvVenue;
        private System.Windows.Forms.Label lblPrinter;
        private System.Windows.Forms.Button btnPrint;
    }
}
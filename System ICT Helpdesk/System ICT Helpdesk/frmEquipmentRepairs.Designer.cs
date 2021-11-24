namespace System_ICT_Helpdesk
{
    partial class frmEquipmentRepairs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEquipmentRepairs));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPrinter = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.cmbRepairDesc = new System.Windows.Forms.ComboBox();
            this.cmbEquipName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dteFixedDate = new System.Windows.Forms.DateTimePicker();
            this.dgvEquipHistory = new System.Windows.Forms.DataGridView();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pnlBtn = new System.Windows.Forms.Panel();
            this.btnList = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BbtnAddEquipmentHostory = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.pnlAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipHistory)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.pnlBtn.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblPrinter);
            this.panel3.Controls.Add(this.btnPrint);
            this.panel3.Controls.Add(this.label5);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1111, 102);
            this.panel3.TabIndex = 60;
            // 
            // lblPrinter
            // 
            this.lblPrinter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrinter.AutoSize = true;
            this.lblPrinter.BackColor = System.Drawing.Color.Red;
            this.lblPrinter.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrinter.ForeColor = System.Drawing.Color.White;
            this.lblPrinter.Location = new System.Drawing.Point(902, 47);
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
            this.btnPrint.Location = new System.Drawing.Point(964, 46);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(83, 55);
            this.btnPrint.TabIndex = 68;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            this.btnPrint.MouseLeave += new System.EventHandler(this.btnPrint_MouseLeave);
            this.btnPrint.MouseHover += new System.EventHandler(this.btnPrint_MouseHover);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(356, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(358, 34);
            this.label5.TabIndex = 56;
            this.label5.Text = "Equipment Repair Details";
            // 
            // pnlAdd
            // 
            this.pnlAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.pnlAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAdd.Controls.Add(this.cmbRepairDesc);
            this.pnlAdd.Controls.Add(this.cmbEquipName);
            this.pnlAdd.Controls.Add(this.label1);
            this.pnlAdd.Controls.Add(this.label4);
            this.pnlAdd.Controls.Add(this.label2);
            this.pnlAdd.Controls.Add(this.dteFixedDate);
            this.pnlAdd.ForeColor = System.Drawing.Color.White;
            this.pnlAdd.Location = new System.Drawing.Point(0, 109);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(357, 196);
            this.pnlAdd.TabIndex = 61;
            this.pnlAdd.Visible = false;
            // 
            // cmbRepairDesc
            // 
            this.cmbRepairDesc.FormattingEnabled = true;
            this.cmbRepairDesc.Location = new System.Drawing.Point(145, 85);
            this.cmbRepairDesc.Name = "cmbRepairDesc";
            this.cmbRepairDesc.Size = new System.Drawing.Size(187, 24);
            this.cmbRepairDesc.TabIndex = 56;
            // 
            // cmbEquipName
            // 
            this.cmbEquipName.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEquipName.FormattingEnabled = true;
            this.cmbEquipName.Location = new System.Drawing.Point(145, 128);
            this.cmbEquipName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbEquipName.Name = "cmbEquipName";
            this.cmbEquipName.Size = new System.Drawing.Size(187, 24);
            this.cmbEquipName.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 52;
            this.label1.Text = "Fixed Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 55;
            this.label4.Text = "Equipment Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 53;
            this.label2.Text = "Fixed Description";
            // 
            // dteFixedDate
            // 
            this.dteFixedDate.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteFixedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteFixedDate.Location = new System.Drawing.Point(145, 43);
            this.dteFixedDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dteFixedDate.Name = "dteFixedDate";
            this.dteFixedDate.Size = new System.Drawing.Size(187, 22);
            this.dteFixedDate.TabIndex = 45;
            // 
            // dgvEquipHistory
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dgvEquipHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEquipHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEquipHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEquipHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvEquipHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEquipHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEquipHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEquipHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEquipHistory.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEquipHistory.Location = new System.Drawing.Point(363, 109);
            this.dgvEquipHistory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvEquipHistory.Name = "dgvEquipHistory";
            this.dgvEquipHistory.RowTemplate.DividerHeight = 3;
            this.dgvEquipHistory.Size = new System.Drawing.Size(673, 196);
            this.dgvEquipHistory.TabIndex = 62;
            this.dgvEquipHistory.Visible = false;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.pnlButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlButtons.Controls.Add(this.pnlBtn);
            this.pnlButtons.Location = new System.Drawing.Point(0, 331);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(1048, 109);
            this.pnlButtons.TabIndex = 63;
            // 
            // pnlBtn
            // 
            this.pnlBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlBtn.BackColor = System.Drawing.Color.Gold;
            this.pnlBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBtn.Controls.Add(this.btnList);
            this.pnlBtn.Controls.Add(this.button4);
            this.pnlBtn.Controls.Add(this.panel5);
            this.pnlBtn.Location = new System.Drawing.Point(-1, 22);
            this.pnlBtn.Name = "pnlBtn";
            this.pnlBtn.Size = new System.Drawing.Size(515, 86);
            this.pnlBtn.TabIndex = 64;
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.Tan;
            this.btnList.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.ForeColor = System.Drawing.Color.White;
            this.btnList.Location = new System.Drawing.Point(340, 37);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(171, 48);
            this.btnList.TabIndex = 0;
            this.btnList.Text = "List History Info ";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.MouseEnter += new System.EventHandler(this.btnList_MouseEnter);
            this.btnList.MouseLeave += new System.EventHandler(this.btnList_MouseLeave);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Tan;
            this.button4.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(2, 37);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 48);
            this.button4.TabIndex = 1;
            this.button4.Text = "Open Controls";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.MouseEnter += new System.EventHandler(this.button4_MouseEnter);
            this.button4.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FloralWhite;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.BbtnAddEquipmentHostory);
            this.panel5.Location = new System.Drawing.Point(145, 24);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(198, 61);
            this.panel5.TabIndex = 0;
            // 
            // BbtnAddEquipmentHostory
            // 
            this.BbtnAddEquipmentHostory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BbtnAddEquipmentHostory.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BbtnAddEquipmentHostory.Location = new System.Drawing.Point(33, 18);
            this.BbtnAddEquipmentHostory.Name = "BbtnAddEquipmentHostory";
            this.BbtnAddEquipmentHostory.Size = new System.Drawing.Size(142, 41);
            this.BbtnAddEquipmentHostory.TabIndex = 0;
            this.BbtnAddEquipmentHostory.Text = "ADD DETAILS";
            this.BbtnAddEquipmentHostory.UseVisualStyleBackColor = true;
            this.BbtnAddEquipmentHostory.Click += new System.EventHandler(this.BbtnAddEquipmentHostory_Click);
            // 
            // frmEquipmentRepairs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1048, 440);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.dgvEquipHistory);
            this.Controls.Add(this.pnlAdd);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1048, 440);
            this.Name = "frmEquipmentRepairs";
            this.Text = "frmEquipmentHistory";
            this.Load += new System.EventHandler(this.frmEquipmentHistory_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipHistory)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.pnlBtn.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.ComboBox cmbEquipName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dteFixedDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEquipHistory;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Panel pnlBtn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BbtnAddEquipmentHostory;
        private System.Windows.Forms.Label lblPrinter;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ComboBox cmbRepairDesc;
    }
}
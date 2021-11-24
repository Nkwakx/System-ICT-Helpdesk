namespace System_ICT_Helpdesk
{
    partial class frmEquipmentType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEquipmentType));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPrinter = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnAddEquipmentType = new System.Windows.Forms.Button();
            this.btnListEquipment = new System.Windows.Forms.Button();
            this.pnlAddEquipType = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnUpdateEqupmentType = new System.Windows.Forms.Button();
            this.btnAddEquipType = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlBtn = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvEquipmentType = new System.Windows.Forms.DataGridView();
            this.txtEquipType = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.pnlAddEquipType.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlBtn.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipmentType)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblPrinter);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnPrint);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1048, 80);
            this.panel3.TabIndex = 56;
            // 
            // lblPrinter
            // 
            this.lblPrinter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrinter.AutoSize = true;
            this.lblPrinter.BackColor = System.Drawing.Color.Red;
            this.lblPrinter.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrinter.ForeColor = System.Drawing.Color.White;
            this.lblPrinter.Location = new System.Drawing.Point(902, 25);
            this.lblPrinter.Name = "lblPrinter";
            this.lblPrinter.Size = new System.Drawing.Size(0, 22);
            this.lblPrinter.TabIndex = 69;
            this.lblPrinter.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(300, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 34);
            this.label3.TabIndex = 52;
            this.label3.Text = "Equipment Type Details";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.BackgroundImage")));
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrint.Location = new System.Drawing.Point(964, 24);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(83, 55);
            this.btnPrint.TabIndex = 68;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            this.btnPrint.MouseLeave += new System.EventHandler(this.btnPrint_MouseLeave);
            this.btnPrint.MouseHover += new System.EventHandler(this.btnPrint_MouseHover);
            // 
            // btnAddEquipmentType
            // 
            this.btnAddEquipmentType.BackColor = System.Drawing.Color.Tan;
            this.btnAddEquipmentType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEquipmentType.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEquipmentType.Location = new System.Drawing.Point(22, 22);
            this.btnAddEquipmentType.Name = "btnAddEquipmentType";
            this.btnAddEquipmentType.Size = new System.Drawing.Size(157, 39);
            this.btnAddEquipmentType.TabIndex = 54;
            this.btnAddEquipmentType.Text = "Open Controls";
            this.btnAddEquipmentType.UseVisualStyleBackColor = false;
            this.btnAddEquipmentType.MouseEnter += new System.EventHandler(this.btnAddEquipmentType_MouseEnter);
            this.btnAddEquipmentType.MouseLeave += new System.EventHandler(this.btnAddEquipmentType_MouseLeave);
            // 
            // btnListEquipment
            // 
            this.btnListEquipment.BackColor = System.Drawing.Color.Tan;
            this.btnListEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListEquipment.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListEquipment.Location = new System.Drawing.Point(179, 22);
            this.btnListEquipment.Name = "btnListEquipment";
            this.btnListEquipment.Size = new System.Drawing.Size(158, 39);
            this.btnListEquipment.TabIndex = 53;
            this.btnListEquipment.Text = "List Equipment";
            this.btnListEquipment.UseVisualStyleBackColor = false;
            this.btnListEquipment.MouseEnter += new System.EventHandler(this.btnListEquipment_MouseEnter);
            this.btnListEquipment.MouseLeave += new System.EventHandler(this.btnListEquipment_MouseLeave);
            // 
            // pnlAddEquipType
            // 
            this.pnlAddEquipType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlAddEquipType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.pnlAddEquipType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddEquipType.Controls.Add(this.txtEquipType);
            this.pnlAddEquipType.Controls.Add(this.pnlButtons);
            this.pnlAddEquipType.Controls.Add(this.label6);
            this.pnlAddEquipType.ForeColor = System.Drawing.Color.White;
            this.pnlAddEquipType.Location = new System.Drawing.Point(0, 84);
            this.pnlAddEquipType.Name = "pnlAddEquipType";
            this.pnlAddEquipType.Size = new System.Drawing.Size(302, 210);
            this.pnlAddEquipType.TabIndex = 57;
            this.pnlAddEquipType.Visible = false;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlButtons.BackColor = System.Drawing.Color.White;
            this.pnlButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlButtons.Controls.Add(this.btnUpdateEqupmentType);
            this.pnlButtons.Controls.Add(this.btnAddEquipType);
            this.pnlButtons.ForeColor = System.Drawing.Color.White;
            this.pnlButtons.Location = new System.Drawing.Point(73, 157);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(207, 52);
            this.pnlButtons.TabIndex = 45;
            // 
            // btnUpdateEqupmentType
            // 
            this.btnUpdateEqupmentType.BackColor = System.Drawing.Color.Gold;
            this.btnUpdateEqupmentType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateEqupmentType.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEqupmentType.Location = new System.Drawing.Point(93, 19);
            this.btnUpdateEqupmentType.Name = "btnUpdateEqupmentType";
            this.btnUpdateEqupmentType.Size = new System.Drawing.Size(107, 27);
            this.btnUpdateEqupmentType.TabIndex = 48;
            this.btnUpdateEqupmentType.Text = "UPDATE";
            this.btnUpdateEqupmentType.UseVisualStyleBackColor = false;
            this.btnUpdateEqupmentType.Click += new System.EventHandler(this.btnUpdateEqupmentType_Click);
            // 
            // btnAddEquipType
            // 
            this.btnAddEquipType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnAddEquipType.BackColor = System.Drawing.Color.Gold;
            this.btnAddEquipType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEquipType.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEquipType.ForeColor = System.Drawing.Color.White;
            this.btnAddEquipType.Location = new System.Drawing.Point(16, 19);
            this.btnAddEquipType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddEquipType.Name = "btnAddEquipType";
            this.btnAddEquipType.Size = new System.Drawing.Size(84, 27);
            this.btnAddEquipType.TabIndex = 47;
            this.btnAddEquipType.Text = "ADD";
            this.btnAddEquipType.UseVisualStyleBackColor = false;
            this.btnAddEquipType.Click += new System.EventHandler(this.btnAddEquipType_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(10, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 39;
            this.label6.Text = "Equipment Name";
            // 
            // pnlBtn
            // 
            this.pnlBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.pnlBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBtn.Controls.Add(this.panel1);
            this.pnlBtn.ForeColor = System.Drawing.Color.White;
            this.pnlBtn.Location = new System.Drawing.Point(0, 300);
            this.pnlBtn.Name = "pnlBtn";
            this.pnlBtn.Size = new System.Drawing.Size(1048, 140);
            this.pnlBtn.TabIndex = 59;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnListEquipment);
            this.panel1.Controls.Add(this.btnAddEquipmentType);
            this.panel1.Location = new System.Drawing.Point(307, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 64);
            this.panel1.TabIndex = 55;
            // 
            // dgvEquipmentType
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dgvEquipmentType.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEquipmentType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEquipmentType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEquipmentType.BackgroundColor = System.Drawing.Color.White;
            this.dgvEquipmentType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEquipmentType.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEquipmentType.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEquipmentType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEquipmentType.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEquipmentType.Location = new System.Drawing.Point(308, 87);
            this.dgvEquipmentType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvEquipmentType.Name = "dgvEquipmentType";
            this.dgvEquipmentType.RowTemplate.DividerHeight = 3;
            this.dgvEquipmentType.Size = new System.Drawing.Size(728, 207);
            this.dgvEquipmentType.TabIndex = 64;
            this.dgvEquipmentType.Visible = false;
            this.dgvEquipmentType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquipmentType_CellClick);
            // 
            // txtEquipType
            // 
            this.txtEquipType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEquipType.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipType.Location = new System.Drawing.Point(129, 61);
            this.txtEquipType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEquipType.Multiline = true;
            this.txtEquipType.Name = "txtEquipType";
            this.txtEquipType.Size = new System.Drawing.Size(151, 25);
            this.txtEquipType.TabIndex = 78;
            // 
            // frmEquipmentType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1048, 440);
            this.Controls.Add(this.dgvEquipmentType);
            this.Controls.Add(this.pnlBtn);
            this.Controls.Add(this.pnlAddEquipType);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1048, 440);
            this.Name = "frmEquipmentType";
            this.Text = "frmEquipmentType";
            this.Load += new System.EventHandler(this.frmEquipmentType_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlAddEquipType.ResumeLayout(false);
            this.pnlAddEquipType.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlBtn.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipmentType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAddEquipmentType;
        private System.Windows.Forms.Button btnListEquipment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlAddEquipType;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnUpdateEqupmentType;
        private System.Windows.Forms.Button btnAddEquipType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlBtn;
        private System.Windows.Forms.DataGridView dgvEquipmentType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPrinter;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtEquipType;
    }
}
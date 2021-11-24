namespace System_ICT_Helpdesk
{
    partial class frmBuilding
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuilding));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddBuilding = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuildingName = new System.Windows.Forms.TextBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pnlBtn = new System.Windows.Forms.Panel();
            this.btnList = new System.Windows.Forms.Button();
            this.btnOpenCotrols = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvBuilding = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblPrinter = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlControl.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuilding)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 97);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblPrinter);
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(-1, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1048, 55);
            this.panel2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(394, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "Building Details..........";
            // 
            // pnlControl
            // 
            this.pnlControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.pnlControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControl.Controls.Add(this.panel3);
            this.pnlControl.Controls.Add(this.label1);
            this.pnlControl.Controls.Add(this.txtBuildingName);
            this.pnlControl.Location = new System.Drawing.Point(0, 103);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(393, 196);
            this.pnlControl.TabIndex = 12;
            this.pnlControl.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gold;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnAddBuilding);
            this.panel3.Location = new System.Drawing.Point(143, 141);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 54);
            this.panel3.TabIndex = 6;
            // 
            // btnAddBuilding
            // 
            this.btnAddBuilding.BackColor = System.Drawing.Color.Tan;
            this.btnAddBuilding.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBuilding.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBuilding.ForeColor = System.Drawing.Color.White;
            this.btnAddBuilding.Location = new System.Drawing.Point(43, 19);
            this.btnAddBuilding.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddBuilding.Name = "btnAddBuilding";
            this.btnAddBuilding.Size = new System.Drawing.Size(98, 33);
            this.btnAddBuilding.TabIndex = 6;
            this.btnAddBuilding.Text = "ADD";
            this.btnAddBuilding.UseVisualStyleBackColor = false;
            this.btnAddBuilding.Click += new System.EventHandler(this.btnAddBuilding_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(21, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Building Name";
            // 
            // txtBuildingName
            // 
            this.txtBuildingName.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuildingName.Location = new System.Drawing.Point(147, 45);
            this.txtBuildingName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBuildingName.Name = "txtBuildingName";
            this.txtBuildingName.Size = new System.Drawing.Size(196, 22);
            this.txtBuildingName.TabIndex = 5;
            this.txtBuildingName.Validating += new System.ComponentModel.CancelEventHandler(this.txtBuildingName_Validating);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.pnlButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlButtons.Controls.Add(this.pnlBtn);
            this.pnlButtons.ForeColor = System.Drawing.Color.White;
            this.pnlButtons.Location = new System.Drawing.Point(0, 305);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(1048, 136);
            this.pnlButtons.TabIndex = 14;
            // 
            // pnlBtn
            // 
            this.pnlBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlBtn.BackColor = System.Drawing.Color.Gold;
            this.pnlBtn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBtn.Controls.Add(this.btnList);
            this.pnlBtn.Controls.Add(this.btnOpenCotrols);
            this.pnlBtn.ForeColor = System.Drawing.Color.White;
            this.pnlBtn.Location = new System.Drawing.Point(400, -1);
            this.pnlBtn.Name = "pnlBtn";
            this.pnlBtn.Size = new System.Drawing.Size(377, 68);
            this.pnlBtn.TabIndex = 57;
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
            this.btnList.Text = "List Building";
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dgvBuilding
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Silver;
            this.dgvBuilding.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvBuilding.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBuilding.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBuilding.BackgroundColor = System.Drawing.Color.White;
            this.dgvBuilding.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBuilding.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBuilding.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvBuilding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBuilding.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvBuilding.Location = new System.Drawing.Point(401, 104);
            this.dgvBuilding.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvBuilding.Name = "dgvBuilding";
            this.dgvBuilding.RowTemplate.DividerHeight = 3;
            this.dgvBuilding.Size = new System.Drawing.Size(635, 195);
            this.dgvBuilding.TabIndex = 66;
            this.dgvBuilding.Visible = false;
            this.dgvBuilding.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuilding_CellClick);
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
            this.btnPrint.TabIndex = 10;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            this.btnPrint.MouseLeave += new System.EventHandler(this.btnPrint_MouseLeave);
            this.btnPrint.MouseHover += new System.EventHandler(this.btnPrint_MouseHover);
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
            this.lblPrinter.TabIndex = 67;
            this.lblPrinter.Visible = false;
            this.lblPrinter.Click += new System.EventHandler(this.lblPrinter_Click);
            this.lblPrinter.MouseLeave += new System.EventHandler(this.btnPrint_MouseLeave);
            // 
            // frmBuilding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1048, 440);
            this.Controls.Add(this.dgvBuilding);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1048, 440);
            this.Name = "frmBuilding";
            this.Text = "frmBuilding";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.pnlBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuilding)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAddBuilding;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuildingName;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlBtn;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnOpenCotrols;
        private System.Windows.Forms.DataGridView dgvBuilding;
        private System.Windows.Forms.Label lblPrinter;
        private System.Windows.Forms.Button btnPrint;
    }
}
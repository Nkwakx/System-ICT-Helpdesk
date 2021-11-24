namespace System_ICT_Helpdesk
{
    partial class rptMainForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStudentSearch = new System.Windows.Forms.Button();
            this.btnTutorReport = new System.Windows.Forms.Button();
            this.btnRequestReport = new System.Windows.Forms.Button();
            this.btnInspectionReport = new System.Windows.Forms.Button();
            this.btnEquipReport = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnInspecDetailsReport = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnInspecDetailsReport);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnStudentSearch);
            this.panel2.Controls.Add(this.btnTutorReport);
            this.panel2.Controls.Add(this.btnRequestReport);
            this.panel2.Controls.Add(this.btnInspectionReport);
            this.panel2.Controls.Add(this.btnEquipReport);
            this.panel2.Location = new System.Drawing.Point(100, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(946, 77);
            this.panel2.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(336, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "REPORT BUTTONS";
            // 
            // btnStudentSearch
            // 
            this.btnStudentSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnStudentSearch.Location = new System.Drawing.Point(553, 37);
            this.btnStudentSearch.Name = "btnStudentSearch";
            this.btnStudentSearch.Size = new System.Drawing.Size(118, 39);
            this.btnStudentSearch.TabIndex = 4;
            this.btnStudentSearch.Text = "Student Search";
            this.btnStudentSearch.UseVisualStyleBackColor = true;
            this.btnStudentSearch.MouseEnter += new System.EventHandler(this.btnStudentSearch_MouseEnter);
            this.btnStudentSearch.MouseLeave += new System.EventHandler(this.btnStudentSearch_MouseLeave);
            // 
            // btnTutorReport
            // 
            this.btnTutorReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnTutorReport.Location = new System.Drawing.Point(421, 37);
            this.btnTutorReport.Name = "btnTutorReport";
            this.btnTutorReport.Size = new System.Drawing.Size(141, 39);
            this.btnTutorReport.TabIndex = 3;
            this.btnTutorReport.Text = "Tutor Request Report";
            this.btnTutorReport.UseVisualStyleBackColor = true;
            this.btnTutorReport.MouseEnter += new System.EventHandler(this.btnTutorReport_MouseEnter);
            this.btnTutorReport.MouseLeave += new System.EventHandler(this.btnTutorReport_MouseLeave);
            // 
            // btnRequestReport
            // 
            this.btnRequestReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnRequestReport.Location = new System.Drawing.Point(311, 37);
            this.btnRequestReport.Name = "btnRequestReport";
            this.btnRequestReport.Size = new System.Drawing.Size(117, 39);
            this.btnRequestReport.TabIndex = 2;
            this.btnRequestReport.Text = "Request Report";
            this.btnRequestReport.UseVisualStyleBackColor = true;
            this.btnRequestReport.MouseEnter += new System.EventHandler(this.btnRequestReport_MouseEnter);
            this.btnRequestReport.MouseLeave += new System.EventHandler(this.btnRequestReport_MouseLeave);
            // 
            // btnInspectionReport
            // 
            this.btnInspectionReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnInspectionReport.Location = new System.Drawing.Point(197, 37);
            this.btnInspectionReport.Name = "btnInspectionReport";
            this.btnInspectionReport.Size = new System.Drawing.Size(122, 39);
            this.btnInspectionReport.TabIndex = 1;
            this.btnInspectionReport.Text = "Inspection Report";
            this.btnInspectionReport.UseVisualStyleBackColor = true;
            this.btnInspectionReport.MouseEnter += new System.EventHandler(this.btnInspectionReport_MouseEnter);
            this.btnInspectionReport.MouseLeave += new System.EventHandler(this.btnInspectionReport_MouseLeave);
            // 
            // btnEquipReport
            // 
            this.btnEquipReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnEquipReport.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquipReport.Location = new System.Drawing.Point(72, 37);
            this.btnEquipReport.Name = "btnEquipReport";
            this.btnEquipReport.Size = new System.Drawing.Size(131, 39);
            this.btnEquipReport.TabIndex = 0;
            this.btnEquipReport.Text = "Equipment Report";
            this.btnEquipReport.UseVisualStyleBackColor = true;
            this.btnEquipReport.MouseEnter += new System.EventHandler(this.btnEquipReport_MouseEnter);
            this.btnEquipReport.MouseLeave += new System.EventHandler(this.btnEquipReport_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(101, 440);
            this.panel1.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 432);
            this.label1.TabIndex = 0;
            this.label1.Text = "A\r\nL\r\nL\r\n\r\nR\r\nE\r\nP\r\nO\r\nR\r\nT\r\n\r\nD\r\nE\r\nT\r\nA\r\nI\r\nL\r\nS";
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Location = new System.Drawing.Point(100, 74);
            this.pnlMain.MaximumSize = new System.Drawing.Size(946, 362);
            this.pnlMain.MinimumSize = new System.Drawing.Size(946, 362);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(946, 362);
            this.pnlMain.TabIndex = 72;
            // 
            // btnInspecDetailsReport
            // 
            this.btnInspecDetailsReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnInspecDetailsReport.Location = new System.Drawing.Point(665, 37);
            this.btnInspecDetailsReport.Name = "btnInspecDetailsReport";
            this.btnInspecDetailsReport.Size = new System.Drawing.Size(151, 39);
            this.btnInspecDetailsReport.TabIndex = 11;
            this.btnInspecDetailsReport.Text = "Inspection Details Report";
            this.btnInspecDetailsReport.UseVisualStyleBackColor = true;
            this.btnInspecDetailsReport.MouseEnter += new System.EventHandler(this.btnInspecDetailsReport_MouseEnter);
            this.btnInspecDetailsReport.MouseLeave += new System.EventHandler(this.btnInspecDetailsReport_MouseLeave);
            // 
            // rptMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1047, 440);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1047, 440);
            this.Name = "rptMainForm";
            this.Text = "rptMainForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnStudentSearch;
        private System.Windows.Forms.Button btnTutorReport;
        private System.Windows.Forms.Button btnRequestReport;
        private System.Windows.Forms.Button btnInspectionReport;
        private System.Windows.Forms.Button btnEquipReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInspecDetailsReport;
    }
}
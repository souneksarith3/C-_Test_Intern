namespace C__Test
{
    partial class Form1
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
            this.pnlReport = new System.Windows.Forms.Panel();
            this.dcvReport = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpSdate = new System.Windows.Forms.DateTimePicker();
            this.dtpEdate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlReport
            // 
            this.pnlReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlReport.Controls.Add(this.dcvReport);
            this.pnlReport.Location = new System.Drawing.Point(13, 78);
            this.pnlReport.Name = "pnlReport";
            this.pnlReport.Size = new System.Drawing.Size(1227, 738);
            this.pnlReport.TabIndex = 0;
            // 
            // dcvReport
            // 
            this.dcvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dcvReport.IsMetric = false;
            this.dcvReport.Location = new System.Drawing.Point(0, 0);
            this.dcvReport.Name = "dcvReport";
            this.dcvReport.Size = new System.Drawing.Size(1227, 738);
            this.dcvReport.TabIndex = 0;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnGenerate.Font = new System.Drawing.Font("Kh Siemreap", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(1121, 35);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(119, 37);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kh Siemreap", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start date";
            // 
            // dtpSdate
            // 
            this.dtpSdate.CustomFormat = "dd-MMM-yyyy";
            this.dtpSdate.Font = new System.Drawing.Font("Kh Siemreap", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSdate.Location = new System.Drawing.Point(112, 35);
            this.dtpSdate.Name = "dtpSdate";
            this.dtpSdate.Size = new System.Drawing.Size(200, 37);
            this.dtpSdate.TabIndex = 3;
            // 
            // dtpEdate
            // 
            this.dtpEdate.CustomFormat = "dd-MMM-yyyy";
            this.dtpEdate.Font = new System.Drawing.Font("Kh Siemreap", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEdate.Location = new System.Drawing.Point(468, 35);
            this.dtpEdate.Name = "dtpEdate";
            this.dtpEdate.Size = new System.Drawing.Size(200, 37);
            this.dtpEdate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kh Siemreap", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(378, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "End date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 828);
            this.Controls.Add(this.dtpEdate);
            this.Controls.Add(this.dtpSdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.pnlReport);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlReport.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlReport;
        private DevExpress.XtraPrinting.Preview.DocumentViewer dcvReport;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpSdate;
        private System.Windows.Forms.DateTimePicker dtpEdate;
        private System.Windows.Forms.Label label2;
    }
}


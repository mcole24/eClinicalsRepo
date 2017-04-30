namespace eClinicals.View
{
    partial class frmAdminReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.lblNoReportFound = new System.Windows.Forms.Label();
            this.btnGetReport = new System.Windows.Forms.Button();
            this.ReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer
            // 
            reportDataSource1.Name = "dsReport";
            reportDataSource1.Value = this.ReportBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "eClinicals.View.Report1.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(21, 125);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.Size = new System.Drawing.Size(895, 295);
            this.reportViewer.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(607, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "End Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(470, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Start Date";
            // 
            // dtEnd
            // 
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEnd.Location = new System.Drawing.Point(610, 74);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(104, 20);
            this.dtEnd.TabIndex = 2;
            // 
            // dtStart
            // 
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStart.Location = new System.Drawing.Point(470, 74);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(104, 20);
            this.dtStart.TabIndex = 1;
            // 
            // lblNoReportFound
            // 
            this.lblNoReportFound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNoReportFound.Image = global::eClinicals.Properties.Resources.NoReport;
            this.lblNoReportFound.Location = new System.Drawing.Point(21, 125);
            this.lblNoReportFound.Name = "lblNoReportFound";
            this.lblNoReportFound.Size = new System.Drawing.Size(895, 295);
            this.lblNoReportFound.TabIndex = 7;
            this.lblNoReportFound.Visible = false;
            // 
            // btnGetReport
            // 
            this.btnGetReport.BackgroundImage = global::eClinicals.Properties.Resources.reports;
            this.btnGetReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGetReport.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetReport.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnGetReport.Location = new System.Drawing.Point(749, 23);
            this.btnGetReport.Name = "btnGetReport";
            this.btnGetReport.Size = new System.Drawing.Size(167, 96);
            this.btnGetReport.TabIndex = 3;
            this.btnGetReport.Text = "Get";
            this.btnGetReport.UseVisualStyleBackColor = true;
            this.btnGetReport.Click += new System.EventHandler(this.btnGetReport_Click);
            // 
            // ReportBindingSource
            // 
            this.ReportBindingSource.DataSource = typeof(eClinicals.Model.Report);
            // 
            // frmAdminReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 513);
            this.Controls.Add(this.lblNoReportFound);
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGetReport);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dtStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminReport";
            this.Text = "frmAdminReport";
            this.Load += new System.EventHandler(this.frmAdminReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DateTimePicker dtEnd;
        public System.Windows.Forms.Button btnGetReport;
        public System.Windows.Forms.DateTimePicker dtStart;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource ReportBindingSource;
        private System.Windows.Forms.Label lblNoReportFound;
    }
}
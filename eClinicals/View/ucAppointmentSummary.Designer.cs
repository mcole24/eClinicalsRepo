namespace eClinicals.View
{
    partial class ucAppointmentSummary
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.dgCheckupResults = new System.Windows.Forms.DataGridView();
            this.gbCheckUp = new System.Windows.Forms.GroupBox();
            this.gbSymptoms = new System.Windows.Forms.GroupBox();
            this.dgSymptoms = new System.Windows.Forms.DataGridView();
            this.gbVisitDetails = new System.Windows.Forms.GroupBox();
            this.dgVisitDetails = new System.Windows.Forms.DataGridView();
            this.gbTestResults = new System.Windows.Forms.GroupBox();
            this.dgTestResults = new System.Windows.Forms.DataGridView();
            this.gbDiagnosisResults = new System.Windows.Forms.GroupBox();
            this.dgDiagnosisResults = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCheckupResults)).BeginInit();
            this.gbCheckUp.SuspendLayout();
            this.gbSymptoms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSymptoms)).BeginInit();
            this.gbVisitDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVisitDetails)).BeginInit();
            this.gbTestResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTestResults)).BeginInit();
            this.gbDiagnosisResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDiagnosisResults)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::eClinicals.Properties.Resources.backAppointments;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1083, 568);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(174, 65);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(515, 57);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Appointment Summary";
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.Transparent;
            this.btnDone.BackgroundImage = global::eClinicals.Properties.Resources.Done;
            this.btnDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.Color.Sienna;
            this.btnDone.Location = new System.Drawing.Point(8, 3);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(106, 85);
            this.btnDone.TabIndex = 9;
            this.btnDone.Text = "DONE";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // dgCheckupResults
            // 
            this.dgCheckupResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCheckupResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCheckupResults.Location = new System.Drawing.Point(3, 22);
            this.dgCheckupResults.Name = "dgCheckupResults";
            this.dgCheckupResults.Size = new System.Drawing.Size(424, 79);
            this.dgCheckupResults.TabIndex = 10;
            // 
            // gbCheckUp
            // 
            this.gbCheckUp.BackColor = System.Drawing.Color.Transparent;
            this.gbCheckUp.BackgroundImage = global::eClinicals.Properties.Resources.footer_image;
            this.gbCheckUp.Controls.Add(this.dgCheckupResults);
            this.gbCheckUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCheckUp.Location = new System.Drawing.Point(25, 140);
            this.gbCheckUp.Name = "gbCheckUp";
            this.gbCheckUp.Size = new System.Drawing.Size(430, 104);
            this.gbCheckUp.TabIndex = 12;
            this.gbCheckUp.TabStop = false;
            this.gbCheckUp.Text = "Check-Up Summary";
            // 
            // gbSymptoms
            // 
            this.gbSymptoms.BackColor = System.Drawing.Color.Transparent;
            this.gbSymptoms.BackgroundImage = global::eClinicals.Properties.Resources.footer_image;
            this.gbSymptoms.Controls.Add(this.dgSymptoms);
            this.gbSymptoms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSymptoms.Location = new System.Drawing.Point(471, 140);
            this.gbSymptoms.Name = "gbSymptoms";
            this.gbSymptoms.Size = new System.Drawing.Size(366, 104);
            this.gbSymptoms.TabIndex = 13;
            this.gbSymptoms.TabStop = false;
            this.gbSymptoms.Text = "Symptoms Summary";
            // 
            // dgSymptoms
            // 
            this.dgSymptoms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSymptoms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSymptoms.Location = new System.Drawing.Point(3, 22);
            this.dgSymptoms.Name = "dgSymptoms";
            this.dgSymptoms.Size = new System.Drawing.Size(360, 79);
            this.dgSymptoms.TabIndex = 10;
            // 
            // gbVisitDetails
            // 
            this.gbVisitDetails.BackColor = System.Drawing.Color.Transparent;
            this.gbVisitDetails.BackgroundImage = global::eClinicals.Properties.Resources.footer_image;
            this.gbVisitDetails.Controls.Add(this.dgVisitDetails);
            this.gbVisitDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVisitDetails.Location = new System.Drawing.Point(28, 278);
            this.gbVisitDetails.Name = "gbVisitDetails";
            this.gbVisitDetails.Size = new System.Drawing.Size(430, 104);
            this.gbVisitDetails.TabIndex = 14;
            this.gbVisitDetails.TabStop = false;
            this.gbVisitDetails.Text = "Visit Details  Summary";
            // 
            // dgVisitDetails
            // 
            this.dgVisitDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVisitDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgVisitDetails.Location = new System.Drawing.Point(3, 22);
            this.dgVisitDetails.Name = "dgVisitDetails";
            this.dgVisitDetails.Size = new System.Drawing.Size(424, 79);
            this.dgVisitDetails.TabIndex = 10;
            // 
            // gbTestResults
            // 
            this.gbTestResults.BackColor = System.Drawing.Color.Transparent;
            this.gbTestResults.BackgroundImage = global::eClinicals.Properties.Resources.footer_image;
            this.gbTestResults.Controls.Add(this.dgTestResults);
            this.gbTestResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTestResults.Location = new System.Drawing.Point(31, 403);
            this.gbTestResults.Name = "gbTestResults";
            this.gbTestResults.Size = new System.Drawing.Size(427, 104);
            this.gbTestResults.TabIndex = 15;
            this.gbTestResults.TabStop = false;
            this.gbTestResults.Text = "Test Results  Summary";
            // 
            // dgTestResults
            // 
            this.dgTestResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTestResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgTestResults.Location = new System.Drawing.Point(3, 22);
            this.dgTestResults.Name = "dgTestResults";
            this.dgTestResults.Size = new System.Drawing.Size(421, 79);
            this.dgTestResults.TabIndex = 10;
            // 
            // gbDiagnosisResults
            // 
            this.gbDiagnosisResults.BackColor = System.Drawing.Color.Transparent;
            this.gbDiagnosisResults.BackgroundImage = global::eClinicals.Properties.Resources.footer_image;
            this.gbDiagnosisResults.Controls.Add(this.dgDiagnosisResults);
            this.gbDiagnosisResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDiagnosisResults.Location = new System.Drawing.Point(474, 278);
            this.gbDiagnosisResults.Name = "gbDiagnosisResults";
            this.gbDiagnosisResults.Size = new System.Drawing.Size(363, 104);
            this.gbDiagnosisResults.TabIndex = 15;
            this.gbDiagnosisResults.TabStop = false;
            this.gbDiagnosisResults.Text = "Diagnosis Results  Summary";
            // 
            // dgDiagnosisResults
            // 
            this.dgDiagnosisResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDiagnosisResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDiagnosisResults.Location = new System.Drawing.Point(3, 22);
            this.dgDiagnosisResults.Name = "dgDiagnosisResults";
            this.dgDiagnosisResults.Size = new System.Drawing.Size(357, 79);
            this.dgDiagnosisResults.TabIndex = 10;
            // 
            // ucAppointmentSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbDiagnosisResults);
            this.Controls.Add(this.gbTestResults);
            this.Controls.Add(this.gbVisitDetails);
            this.Controls.Add(this.gbSymptoms);
            this.Controls.Add(this.gbCheckUp);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ucAppointmentSummary";
            this.Size = new System.Drawing.Size(1083, 568);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCheckupResults)).EndInit();
            this.gbCheckUp.ResumeLayout(false);
            this.gbSymptoms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSymptoms)).EndInit();
            this.gbVisitDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgVisitDetails)).EndInit();
            this.gbTestResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTestResults)).EndInit();
            this.gbDiagnosisResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDiagnosisResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btnDone;
        public System.Windows.Forms.DataGridView dgCheckupResults;
        public System.Windows.Forms.GroupBox gbCheckUp;
        public System.Windows.Forms.GroupBox gbSymptoms;
        public System.Windows.Forms.DataGridView dgSymptoms;
        public System.Windows.Forms.GroupBox gbVisitDetails;
        public System.Windows.Forms.DataGridView dgVisitDetails;
        public System.Windows.Forms.GroupBox gbTestResults;
        public System.Windows.Forms.DataGridView dgTestResults;
        public System.Windows.Forms.GroupBox gbDiagnosisResults;
        public System.Windows.Forms.DataGridView dgDiagnosisResults;
    }
}

namespace eClinicals.View
{
    partial class frmPatientRecordTabs
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
            this.tabPatientRecord = new System.Windows.Forms.TabControl();
            this.tabPersonal = new System.Windows.Forms.TabPage();
            this.tabSetAppointments = new System.Windows.Forms.TabPage();
            this.tabViewAppointments = new System.Windows.Forms.TabPage();
            this.tabRoutineCheck = new System.Windows.Forms.TabPage();
            this.tabOrderTests = new System.Windows.Forms.TabPage();
            this.tabTestsResults = new System.Windows.Forms.TabPage();
            this.tabPatientRecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPatientRecord
            // 
            this.tabPatientRecord.Controls.Add(this.tabPersonal);
            this.tabPatientRecord.Controls.Add(this.tabSetAppointments);
            this.tabPatientRecord.Controls.Add(this.tabViewAppointments);
            this.tabPatientRecord.Controls.Add(this.tabRoutineCheck);
            this.tabPatientRecord.Controls.Add(this.tabOrderTests);
            this.tabPatientRecord.Controls.Add(this.tabTestsResults);
            this.tabPatientRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPatientRecord.ItemSize = new System.Drawing.Size(100, 30);
            this.tabPatientRecord.Location = new System.Drawing.Point(0, 0);
            this.tabPatientRecord.Name = "tabPatientRecord";
            this.tabPatientRecord.SelectedIndex = 0;
            this.tabPatientRecord.Size = new System.Drawing.Size(1091, 647);
            this.tabPatientRecord.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabPatientRecord.TabIndex = 0;
            // 
            // tabPersonal
            // 
            this.tabPersonal.Location = new System.Drawing.Point(4, 34);
            this.tabPersonal.Name = "tabPersonal";
            this.tabPersonal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonal.Size = new System.Drawing.Size(1083, 609);
            this.tabPersonal.TabIndex = 0;
            this.tabPersonal.Text = "Personal";
            this.tabPersonal.UseVisualStyleBackColor = true;
            // 
            // tabSetAppointments
            // 
            this.tabSetAppointments.Location = new System.Drawing.Point(4, 34);
            this.tabSetAppointments.Name = "tabSetAppointments";
            this.tabSetAppointments.Padding = new System.Windows.Forms.Padding(3);
            this.tabSetAppointments.Size = new System.Drawing.Size(1083, 609);
            this.tabSetAppointments.TabIndex = 1;
            this.tabSetAppointments.Text = "Sety Appointment";
            this.tabSetAppointments.UseVisualStyleBackColor = true;
            // 
            // tabViewAppointments
            // 
            this.tabViewAppointments.Location = new System.Drawing.Point(4, 34);
            this.tabViewAppointments.Name = "tabViewAppointments";
            this.tabViewAppointments.Padding = new System.Windows.Forms.Padding(3);
            this.tabViewAppointments.Size = new System.Drawing.Size(1083, 609);
            this.tabViewAppointments.TabIndex = 2;
            this.tabViewAppointments.Text = "View Appointment";
            this.tabViewAppointments.UseVisualStyleBackColor = true;
            // 
            // tabRoutineCheck
            // 
            this.tabRoutineCheck.Location = new System.Drawing.Point(4, 34);
            this.tabRoutineCheck.Name = "tabRoutineCheck";
            this.tabRoutineCheck.Padding = new System.Windows.Forms.Padding(3);
            this.tabRoutineCheck.Size = new System.Drawing.Size(1083, 609);
            this.tabRoutineCheck.TabIndex = 3;
            this.tabRoutineCheck.Text = "Routine Check";
            this.tabRoutineCheck.UseVisualStyleBackColor = true;
            // 
            // tabOrderTests
            // 
            this.tabOrderTests.Location = new System.Drawing.Point(4, 34);
            this.tabOrderTests.Name = "tabOrderTests";
            this.tabOrderTests.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrderTests.Size = new System.Drawing.Size(1083, 609);
            this.tabOrderTests.TabIndex = 4;
            this.tabOrderTests.Text = "Order Tests";
            this.tabOrderTests.UseVisualStyleBackColor = true;
            // 
            // tabTestsResults
            // 
            this.tabTestsResults.Location = new System.Drawing.Point(4, 34);
            this.tabTestsResults.Name = "tabTestsResults";
            this.tabTestsResults.Padding = new System.Windows.Forms.Padding(3);
            this.tabTestsResults.Size = new System.Drawing.Size(1083, 609);
            this.tabTestsResults.TabIndex = 5;
            this.tabTestsResults.Text = "Test Results";
            this.tabTestsResults.UseVisualStyleBackColor = true;
            // 
            // frmPatientRecordTabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 647);
            this.Controls.Add(this.tabPatientRecord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPatientRecordTabs";
            this.Text = "frmPatientRecordTabs";
            this.tabPatientRecord.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabPatientRecord;
        public System.Windows.Forms.TabPage tabPersonal;
        public System.Windows.Forms.TabPage tabSetAppointments;
        public System.Windows.Forms.TabPage tabViewAppointments;
        public System.Windows.Forms.TabPage tabRoutineCheck;
        public System.Windows.Forms.TabPage tabOrderTests;
        public System.Windows.Forms.TabPage tabTestsResults;
    }
}
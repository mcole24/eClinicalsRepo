﻿namespace eClinicals.View
{
    partial class frmNurseMenuSelectView
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
            this.btnFindPatientRecord = new System.Windows.Forms.Button();
            this.btnRegisterAPatient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFindPatientRecord
            // 
            this.btnFindPatientRecord.Font = new System.Drawing.Font("Miriam", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindPatientRecord.Location = new System.Drawing.Point(296, 62);
            this.btnFindPatientRecord.Name = "btnFindPatientRecord";
            this.btnFindPatientRecord.Size = new System.Drawing.Size(342, 151);
            this.btnFindPatientRecord.TabIndex = 0;
            this.btnFindPatientRecord.Text = "Find Patient Record";
            this.btnFindPatientRecord.UseVisualStyleBackColor = true;
            this.btnFindPatientRecord.Click += new System.EventHandler(this.btnFindPatientRecord_Click);
            // 
            // btnRegisterAPatient
            // 
            this.btnRegisterAPatient.Font = new System.Drawing.Font("Miriam", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterAPatient.Location = new System.Drawing.Point(296, 232);
            this.btnRegisterAPatient.Name = "btnRegisterAPatient";
            this.btnRegisterAPatient.Size = new System.Drawing.Size(342, 151);
            this.btnRegisterAPatient.TabIndex = 1;
            this.btnRegisterAPatient.Text = "Registration";
            this.btnRegisterAPatient.UseVisualStyleBackColor = true;
            // 
            // frmNurseMenuSelectView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 468);
            this.Controls.Add(this.btnRegisterAPatient);
            this.Controls.Add(this.btnFindPatientRecord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNurseMenuSelectView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nurse Logged In View";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNurseMenuSelectView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnFindPatientRecord;
        public System.Windows.Forms.Button btnRegisterAPatient;
    }
}
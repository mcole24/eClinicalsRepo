namespace eClinicals.View
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
            this.btnFindPatientRecord.Location = new System.Drawing.Point(296, 144);
            this.btnFindPatientRecord.Name = "btnFindPatientRecord";
            this.btnFindPatientRecord.Size = new System.Drawing.Size(342, 151);
            this.btnFindPatientRecord.TabIndex = 0;
            this.btnFindPatientRecord.Text = "Find Patient Record";
            this.btnFindPatientRecord.UseVisualStyleBackColor = true;
            // 
            // btnRegisterAPatient
            // 
            this.btnRegisterAPatient.Font = new System.Drawing.Font("Miriam", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterAPatient.Location = new System.Drawing.Point(296, 326);
            this.btnRegisterAPatient.Name = "btnRegisterAPatient";
            this.btnRegisterAPatient.Size = new System.Drawing.Size(342, 151);
            this.btnRegisterAPatient.TabIndex = 1;
            this.btnRegisterAPatient.Text = "Register A Patient";
            this.btnRegisterAPatient.UseVisualStyleBackColor = true;
            // 
            // frmNurseMenuSelectView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 614);
            this.Controls.Add(this.btnRegisterAPatient);
            this.Controls.Add(this.btnFindPatientRecord);
            this.Name = "frmNurseMenuSelectView";
            this.Text = "Nurse Logged In View";
            this.Load += new System.EventHandler(this.frmNurseLoggedInView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFindPatientRecord;
        private System.Windows.Forms.Button btnRegisterAPatient;
    }
}
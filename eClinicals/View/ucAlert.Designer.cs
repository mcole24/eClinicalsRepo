namespace eClinicals.View
{
    partial class ucAlert
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
            this.bgAlert = new System.Windows.Forms.GroupBox();
            this.lblAlert = new System.Windows.Forms.Label();
            this.pbAlert = new System.Windows.Forms.PictureBox();
            this.bgAlert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlert)).BeginInit();
            this.SuspendLayout();
            // 
            // bgAlert
            // 
            this.bgAlert.Controls.Add(this.lblAlert);
            this.bgAlert.Controls.Add(this.pbAlert);
            this.bgAlert.Location = new System.Drawing.Point(16, 18);
            this.bgAlert.Name = "bgAlert";
            this.bgAlert.Size = new System.Drawing.Size(788, 423);
            this.bgAlert.TabIndex = 66;
            this.bgAlert.TabStop = false;
            // 
            // lblAlert
            // 
            this.lblAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlert.ForeColor = System.Drawing.Color.LightCoral;
            this.lblAlert.Location = new System.Drawing.Point(31, 277);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(751, 77);
            this.lblAlert.TabIndex = 67;
            this.lblAlert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbAlert
            // 
            this.pbAlert.Image = global::eClinicals.Properties.Resources.Alert;
            this.pbAlert.Location = new System.Drawing.Point(180, 10);
            this.pbAlert.Name = "pbAlert";
            this.pbAlert.Size = new System.Drawing.Size(416, 248);
            this.pbAlert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAlert.TabIndex = 66;
            this.pbAlert.TabStop = false;
            // 
            // ucAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.bgAlert);
            this.Name = "ucAlert";
            this.Size = new System.Drawing.Size(812, 456);
            this.bgAlert.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAlert)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox bgAlert;
        public System.Windows.Forms.Label lblAlert;
        public System.Windows.Forms.PictureBox pbAlert;
    }
}

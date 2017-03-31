namespace eClinicals.View
{
    partial class frmRibbon
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
            this.pbUserImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbUserImage
            // 
            this.pbUserImage.BackColor = System.Drawing.Color.Transparent;
            this.pbUserImage.BackgroundImage = global::eClinicals.Properties.Resources.user;
            this.pbUserImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbUserImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbUserImage.Location = new System.Drawing.Point(0, 0);
            this.pbUserImage.Name = "pbUserImage";
            this.pbUserImage.Size = new System.Drawing.Size(99, 105);
            this.pbUserImage.TabIndex = 1;
            this.pbUserImage.TabStop = false;
            // 
            // frmRibbon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::eClinicals.Properties.Resources.footer_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1047, 105);
            this.Controls.Add(this.pbUserImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmRibbon";
            this.Text = "frmRibbon";
            this.Load += new System.EventHandler(this.frmRibbon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbUserImage;
    }
}
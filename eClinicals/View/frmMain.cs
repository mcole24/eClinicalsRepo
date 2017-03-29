using System.Windows.Forms;

namespace eClinicals
{
    internal class frmLoginPage : Form
    {
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLoginPage
            // 
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::eClinicals.Properties.Resources.eclinicalLogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(941, 462);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmLoginPage";
            this.Text = "eClinicals Login";
            this.ResumeLayout(false);

        }
    }
}
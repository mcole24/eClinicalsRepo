using eClinicals.Controllers;
using System.Windows.Forms;

namespace eClinicals.View
{

    public class frmBaseView : Form
    {

        public ControllerBase controller { get; set; }
        internal eClinicalsController eController { get; set; }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBaseView
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "frmBaseView";
            this.Load += new System.EventHandler(this.frmBaseView_Load);
            this.ResumeLayout(false);

        }

        private void frmBaseView_Load(object sender, System.EventArgs e)
        {

        }


        // public abstract string AbstractProperty { get; set; }

    }
}

using eClinicals.View;

namespace eClinicals.Controllers
{
   public abstract class ControllerBase : IController
    {
        public frmMain mainForm { get; set; }
        public frmBaseView thisView { get; set; }

        public string status { get; set; }

        public ControllerBase(frmMain mainForm, frmBaseView thisView)
        {
            if (mainForm == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", "mainForm");
            }
            if (thisView == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", "thisView");
            }                      
            this.GetView(thisView);

            this.mainForm = mainForm;

            this.thisView = thisView;
            thisView.MdiParent = this.mainForm;
            thisView.FormClosed += ThisView_FormClosed;
           // this.thisView.Show();
        }
      
        private void GetView(frmBaseView thisView) {

            if (thisView is frmLogin)
            {
                thisView = new frmLogin();
            }
            if (thisView is frmNurseMenuSelectView)
            {
                thisView = new frmNurseMenuSelectView();
            }
            if (thisView is frmRibbon)
            {
                thisView = new frmRibbon();
            }
            if (thisView is frmPatientSearch)
            {
                thisView = new frmPatientSearch();
            }
        }

        public void Show()
        {
           
            string message = "";
            // After Connection to database
            if (thisView == null) {               

                thisView.MdiParent = this.mainForm;
                thisView.FormClosed += ThisView_FormClosed;
              //  thisView.Height = thisView.MdiParent.Height;               
                thisView.Show();
                thisView.BringToFront();
                mainForm.lblStatus.Text = message;
            }
            else
            {
                thisView.Show();
                thisView.Activate();
                message = "Message: Login form  is active. ";
            }
            mainForm.lblStatus.Text = message;
        }

        private void ThisView_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            frmBaseView frm = (frmBaseView)sender;
            thisView = null;         
            mainForm.lblStatus.Text = frm.Text + " has been closed. Use the menu above to reopen the form. ";
        }



    }

}

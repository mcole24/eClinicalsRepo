using eClinicals.View;
using eClinicals.Controllers;
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
        }
      
        private void GetView(frmBaseView thisView) {
          

            if (thisView is frmLogin)
            {
                this.thisView = new frmLogin();
            }
            if (thisView is frmNurseMenuSelectView)
            {
                this.thisView = new frmNurseMenuSelectView();
            }
            if (thisView is frmAdminMenuSelectView)
            {
                this.thisView = new frmAdminMenuSelectView();
            }
            if (thisView is frmRibbon)
            {
                this.thisView = new frmRibbon();
            }
            if (thisView is frmPatientSearch)
            {
                this.thisView = new frmPatientSearch();
            }
            if (thisView is frmPatientRecordTabs)
            {
                this.thisView = new frmPatientRecordTabs();
            }
        }

        public void Show()
        {
           
            string message = "";
            // After Connection to database
            if (thisView == null) {               

                mainForm.lblStatus.Text = "ALL ready active";
            }
            else
            {
                thisView.FormClosed += ThisView_FormClosed;
                thisView.Show();
                thisView.Activate();
                message = "Message: Login form  is active. ";
            }
            mainForm.lblStatus.Text = message;
        }

        private void ThisView_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            frmBaseView frm = (frmBaseView)sender;
            
           
        }



    }

}

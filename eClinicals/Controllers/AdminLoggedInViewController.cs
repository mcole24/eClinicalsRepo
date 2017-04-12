using eClinicals.View;
using System;
using System.Windows.Forms;

namespace eClinicals.Controllers
{
    class AdminLoggedInViewController : ControllerBase
    {

        public frmAdminMenuSelectView frmAdminMenuSelectView;
        public AdminLoggedInViewController(frmMain mainForm, frmBaseView thisView) :
            base(mainForm, thisView)
        {

            frmAdminMenuSelectView = (frmAdminMenuSelectView)base.thisView; 

            mainForm.lblStatus.Text = "Select a menu option . . .";
        }  

    }

}
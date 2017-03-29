using eClinicals.View;
using System;

namespace eClinicals.Controllers
{
    class NurseLoggedInViewController : ControllerBase
    {
    
        public NurseLoggedInViewController(frmMain mainForm, frmBaseView thisView) :
            base(mainForm, thisView)
        {
                 
           frmNurseMenuSelectView frmLoginView = (frmNurseMenuSelectView)base.thisView; 

            mainForm.lblStatus.Text = "Select a menu option . . .";
        }  

    }

}
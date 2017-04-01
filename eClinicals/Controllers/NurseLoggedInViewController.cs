using eClinicals.View;
using System;
using System.Windows.Forms;

namespace eClinicals.Controllers
{
    class NurseLoggedInViewController : ControllerBase
    {

        public frmNurseMenuSelectView frmNurseMenuSelectView;
        public NurseLoggedInViewController(frmMain mainForm, frmBaseView thisView) :
            base(mainForm, thisView)
        {         

            frmNurseMenuSelectView = (frmNurseMenuSelectView)base.thisView; 

            mainForm.lblStatus.Text = "Select a menu option . . .";
        }  

    }

}
using eClinicals.View;

namespace eClinicals.Controllers
{
    class RegistrationViewController : ControllerBase
    {

        public frmRegistration frmRegistration;

        public RegistrationViewController(frmMain mainForm, frmBaseView thisView) :
            base(mainForm, thisView)
        {

            frmRegistration = (frmRegistration)base.thisView;

            mainForm.lblStatus.Text = "Registration View Active . . .";
        }
    }
}

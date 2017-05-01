using eClinicals.View;

namespace eClinicals.Controllers
{
    class PatientSearchViewController : ControllerBase
    {
        eClinicalsController eClinicalsController { get; set; }

        public frmPatientSearch frmPatientSearch;
        public PatientSearchViewController(frmMain mainForm, frmBaseView thisView) : base(mainForm, thisView)
        {
            frmPatientSearch = (frmPatientSearch)base.thisView;
            mainForm.lblStatus.Text = "Patient Search active . . .";


        }


    }
}

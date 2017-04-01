using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eClinicals.View;

namespace eClinicals.Controllers
{
    class PatientSearchViewController : ControllerBase
    {
        public PatientSearchViewController(frmMain mainForm, frmBaseView thisView) : base(mainForm, thisView)
        {

            frmPatientSearch frmPatientSearch = (frmPatientSearch)base.thisView;

            mainForm.lblStatus.Text = "Patient Search active . . .";

        }
    }
}

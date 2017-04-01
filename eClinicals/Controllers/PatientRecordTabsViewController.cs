using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eClinicals.View;

namespace eClinicals.Controllers
{
    class PatientRecordTabsViewController : ControllerBase
    {
        public frmPatientRecordTabs frmPatientRecordTabs;
        public PatientRecordTabsViewController(frmMain mainForm, frmBaseView thisView) : base(mainForm, thisView)
        {

            frmPatientRecordTabs = (frmPatientRecordTabs)base.thisView;

            mainForm.lblStatus.Text = "Patient Record Tabs active . . .";

        }
    }
}

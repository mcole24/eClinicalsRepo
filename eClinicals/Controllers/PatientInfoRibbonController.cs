using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eClinicals.View;

namespace eClinicals.Controllers
{
    class PatientInfoRibbonController : ControllerBase
    {
        frmPatientInfoRibbon ribbon;
        public PatientInfoRibbonController(frmMain mainForm, frmBaseView thisView) : base(mainForm, thisView)
        {
            ribbon = (frmPatientInfoRibbon)base.thisView;
            mainForm.lblStatus.Text = "Patient Ribbon Active";
        }
        public void AddUserInfo(string age, string gender, string id) {

           ribbon.lblGender.Text = gender;
           ribbon.lblId.Text = id;
            ribbon.lblAge.Text = age;

        }

        public void AddContactInfo(string phone, string Address)
        {
          ribbon.lblPhone.Text = phone;
          ribbon.lblAddress.Text = Address;
        }

        public void AddAppointmentInfo(string reason, string symptoms) {
            ribbon.lblReason.Text = reason;
            ribbon.lblSymptom.Text = symptoms;
        }



        public void AddStatusInfo(string status)
        {

          //  ribbon.lblStatus.Text = status;
          

        }
    }
}

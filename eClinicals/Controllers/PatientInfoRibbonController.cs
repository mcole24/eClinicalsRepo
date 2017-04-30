using eClinicals.View;
using System;

namespace eClinicals.Controllers
{
    class PatientInfoRibbonController : ControllerBase
    {
        public frmPatientInfoRibbon ribbon;
        public PatientInfoRibbonController(frmMain mainForm, frmBaseView thisView) : base(mainForm, thisView)
        {
            ribbon = (frmPatientInfoRibbon)base.thisView;
            mainForm.lblStatus.Text = "Patient Ribbon Active";
        }
        public void AddUserInfo(string age, string gender, string id)
        {

            ribbon.lblGender.Text = gender;
            ribbon.lblId.Text = id;
            ribbon.lblAge.Text = age;
        }
        public void AddUserInfoTopInfo(string firstName, string lastName)
        {
            ribbon.lblUserName.Text = lastName + "," + firstName;
        }

        public void AddContactInfo(string phone, string Address)
        {
            ribbon.lblPhone.Text = phone;
            ribbon.lblAddress.Text = Address;
        }

        public void AddContactInfoFull(string phone, string address, string city, string state, string zip)
        {
            ribbon.lblPhone.Text = phone;
            ribbon.lblAddress.Text = address + "\n" + city + ", " + state + " " + zip;
        }
        public void AddAppointmentInfo(string reason, string symptoms)
        {
            ribbon.lblReason.Text = reason;
            ribbon.lblSymptom.Text = symptoms;
        }

        public string getAge(DateTime year)
        {
            return (DateTime.Now.Year - year.Year).ToString();

        }



    }
}

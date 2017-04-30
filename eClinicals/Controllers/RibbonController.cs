using eClinicals.View;
using System;

namespace eClinicals.Controllers
{
    class RibbonController : ControllerBase
    {
        frmRibbon ribbon;
        public RibbonController(frmMain mainForm, frmBaseView thisView) : base(mainForm, thisView)
        {
            ribbon = (frmRibbon)base.thisView;
            ribbon.btnLogout.Click += new EventHandler(this.LogoutBtn_Click);


            mainForm.lblStatus.Text = "Ribbon Active";
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            OnLoggedOut();
            this.mainForm.isLoggedIn = false;
            //  ClearUserInfo();
            ribbon = null;
         

        }

        private void ClearUserInfo()
        {

            ribbon.lblUserName.Text = "";
            ribbon.lblId.Text = "";
            ribbon.lblUserType.Text = "";


        }

        public void AddUserInfo(string name, int uid, int userType)
        {
            String typeToString = getUidString(userType);
            ribbon.lblUserName.Text = name;
            ribbon.lblId.Text = uid.ToString();
            ribbon.lblUserType.Text = typeToString;

            //userType = -1;
        }

        private string getUidString(int uid)
        {
            /*
userType definitions -- 
1. Doctor
2. Clinic Administrator
3. Nurse
4. Patient
*/          string userType = "";
            switch (uid)
            {
                case (int)UserType.Doctor:
                    userType = "Doctor";
                    break;
                case (int)UserType.Administrator:
                    userType = "Administrator";
                    break;
                case (int)UserType.Nurse:
                    userType = "Nurse";
                    break;
                case (int)UserType.Patient:
                    userType = "Patient";
                    break;
                default:
                    break;
            }
            return userType;
        }

        public void AddContactInfo(string phone, string Address)
        {
            ribbon.lblPhone.Text = phone;
            ribbon.lblAddress.Text = Address;

        }
        public void AddStatusInfo(string status)
        {
            ribbon.lblStatus.Text = status;
        }
        //define delegate
        public delegate void LogOutEventHandler(object sender, EventArgs e);
        // Define event
        public event LogOutEventHandler LoggedOut;
        //raise event : Event publisher methods
        protected virtual void OnLoggedOut()
        {
            if (LoggedOut != null)
            {
                this.mainForm.status = "logged Out";
                this.mainForm.isLoggedIn = false;
                this.mainForm.currentUser = null;
                this.mainForm.currentNurse = null;

                LoggedOut(this, EventArgs.Empty);

            }
        }
    }
}

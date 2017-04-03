using eClinicals.Events;
using eClinicals.Model;
using eClinicals.View;
using System;

namespace eClinicals.Controllers
{

    class LoginController : ControllerBase
    {     

        eClinicalsController eClinicalsController;
        public bool isLoggedIn { get; set; }
        frmLogin frmLoginView;
        public LoginController(frmMain mainForm, frmBaseView thisView) :
            base(mainForm, thisView)
        {
            //CREAT NEW DATABASE CONNECTION OBJECT
            //send status to main window
            // isLoggedIn = false;
            this.mainForm.status = "logged Out";
            
            frmLoginView = (frmLogin)base.thisView;
            frmLoginView.btnOk.Click += new EventHandler(this.OkBtn_Click);
            mainForm.lblStatus.Text = "You must login to us this application . . .";
            eClinicalsController = new eClinicalsController();
        }

        void OkBtn_Click(Object sender, EventArgs e)
        {

            frmLoginView.username = frmLoginView.txtUserName.Text;
            frmLoginView.password = frmLoginView.txtPassword.Text;

            LogIn(frmLoginView.username, frmLoginView.password);
        


        }
        //define delegate
        public delegate void LogInEventHandler(object sender, UserLoggedInArgs args);
        // Define event
        public event LogInEventHandler LoggedIn;
        //raise event : Event publisher methods'''

        public void LogIn(String username, string password) {
            isLoggedIn = eClinicalsController.CheckPassword(frmLoginView.username, frmLoginView.password);
            if (isLoggedIn)
            {
                //raise the event OnLOggedIn
                //  Person newUser = eClinicalsController.GetLoggedInUserDetails(username, password);
//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!  TEST
                Person newUser = new Person();
                newUser.FirstName = "Fake";
                newUser.LastName = "Jane";
                newUser.ContactID =12345;
                newUser.UserType = 1;
                newUser.Phone = "999-999-99999";
                OnLoggedIn(newUser); // OnLogIn(Nurse); Needed GetA  Nurse by Username and Password
                thisView.Close();
                this.mainForm.isLoggedIn = true;
            }
            else
            {
                this.mainForm.status = "logged Out";
                mainForm.lblStatus.BackColor = System.Drawing.Color.Red;
                mainForm.lblStatus.Text = "There seems to be a problem with your User Name or Password. Please try again.";
                frmLoginView.lblError.Text = "Login failed :\n Check your username and password.";
            }

        }



        protected virtual void OnLoggedIn(Person person)
        {
            if (LoggedIn != null)
            {
                this.mainForm.status = "logged In";
                this.mainForm.isLoggedIn = true;
                LoggedIn(this, new UserLoggedInArgs() {Person = person });               
            }


        }



    }
   

}

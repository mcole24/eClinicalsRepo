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
            isLoggedIn = false;
            this.status = "loggedOut";
            frmLoginView = (frmLogin)base.thisView;
            frmLoginView.btnOk.Click += new EventHandler(this.OkBtn_Click);
            mainForm.lblStatus.Text = "You must login to us this application . . .";
            eClinicalsController = new eClinicalsController();
        }

        void OkBtn_Click(Object sender, EventArgs e)
        {

            frmLoginView.username = frmLoginView.txtUserName.Text;
            frmLoginView.password = frmLoginView.txtPassword.Text;
            //Database access Here USER ID
            //CHECK PASSWORD
            //If logged in returns true
            isLoggedIn = eClinicalsController.CheckPassword("cwoods6", "testpassword123");

            // ======================== !!!!!  for now TRUE TESTING !!!!!!!!!!!!!!!! 
            // isLoggedIn = true;
            if (isLoggedIn)
            {
               //raise the event OnLOggedIn
                OnLogIn();
                thisView.Close();
                this.status = "loggedIn";
            }
            else
            {
                this.status = "loggedOut";
                //Incorrect login please check your user Id and Password
                mainForm.lblStatus.BackColor = System.Drawing.Color.Red;
                mainForm.lblStatus.Text = "There seems to be a problem with your User Name or Password. Please try again.";
                frmLoginView.lblError.Text = "Login failed :\n Check your username and password.";
           
            }
        }
        //define delegate
        public delegate void LogInEventHandler(object sender, EventArgs e);
        // Define event
        public event LogInEventHandler LoggedIn;
        //raise event : Event publisher methods
        protected virtual void OnLogIn()
        {
            if (LoggedIn != null)
            {
                LoggedIn(this, EventArgs.Empty);

            }


        }



    }

}
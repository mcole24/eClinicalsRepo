using eClinicals.View;
using System;

namespace eClinicals.Controllers
{
    class LoginController : ControllerBase
    {
        public bool isLoggedIn { get; set; }
        public LoginController(frmMain mainForm, frmBaseView thisView) :
            base(mainForm, thisView)
        {
            //CREAT NEW DATABASE CONNECTION OBJECT
            //send status to main window
            isLoggedIn = false;
            frmLogin frmLoginView = (frmLogin)base.thisView;
            frmLoginView.btnOk.Click += new EventHandler(this.OkBtn_Click);

            mainForm.lblStatus.Text = "You must login to us this application . . .";
        }

        void OkBtn_Click(Object sender, EventArgs e)
        {
            //Database access Here USER ID
            //CHECK PASSWORD
            //If logged in returns true
            isLoggedIn = true;

            if (isLoggedIn)
            {
                OnLogIn();
                thisView.Close();
            }
            else
            {

                //Incorrct login please check your user Id and Password
                mainForm.lblStatus.Text = "Incorrct login please check your user Id and Password.";
            }
        }
        //define delegate
        public delegate void LogInEventHandler(object sender, EventArgs e);
        // Define event
        public event LogInEventHandler LoggedIn;
        //define event
        protected virtual void OnLogIn()
        {
            if (LoggedIn != null)
            {
                LoggedIn(this, EventArgs.Empty);

            }


        }



    }

}
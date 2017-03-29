using eClinicals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eClinicals.View;
using System.Windows.Forms;

namespace eClinicals.Controllers
{
    class LoginController : ControllerBase
    {

        public LoginController(frmMain mainForm, Form frmLogin) :
            base(mainForm, frmLogin)
        {
            // Manually register the event-handling method for
            // the Click event of the Button control.
            // base.mainForm.t   .btnOK.Click += new EventHandler(this.GreetingBtn_Click);


            //CREAT NEW DATABASE CONNECTION OBJECT
            //Give status to main window
            base.mainForm.lblStatus.Text = "You must login to us this application . . .";
        }

  
    }
}
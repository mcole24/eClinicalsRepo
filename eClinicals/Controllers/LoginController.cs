using eClinicals.Events;
using eClinicals.Model;
using eClinicals.View;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

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
            // nurse : cwoods6 - testpassword123
            //admin : jwynn1 - 123testpassword
            //TODO: PASSWORD - replace this with commented area below
            // frmLoginView.username = "jwynn1";

            //frmLoginView.username = "jwynn1";
            //frmLoginView.password = "123testpassword";


            frmLoginView.username = "cwoods6";
            frmLoginView.password = "testpassword123";



            // frmLoginView.username = frmLoginView.txtUserName.Text;
            //   frmLoginView.password = frmLoginView.txtPassword.Text;
            //   frmLoginView.username = frmLoginView.txtUserName.Text;
            LogIn(frmLoginView.username, frmLoginView.password);
        }
        //define delegate
        public delegate void LogInEventHandler(object sender, UserLoggedInArgs args);
        // Define event
        public event LogInEventHandler LoggedIn;
        //raise event : Event publisher methods'''

        public void LogIn(String username, string password)
        {

            string userPasswordEncrypted = EncryptPassword(frmLoginView.password);
            isLoggedIn = eClinicalsController.CheckPassword(frmLoginView.username, userPasswordEncrypted);
            if (isLoggedIn)
            {
                //raise the event OnLOggedIn
                Person newUser = eClinicalsController.GetLoggedInUserDetails(username, userPasswordEncrypted);
                OnLoggedIn(newUser);
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

        private string EncryptPassword(string passwordEntered)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes(passwordEntered);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    passwordEntered = Convert.ToBase64String(ms.ToArray());
                }
            }
            return passwordEntered;
        }

        protected virtual void OnLoggedIn(Person person)
        {
            if (LoggedIn != null)
            {
                this.mainForm.status = "logged In";
                this.mainForm.isLoggedIn = true;
                LoggedIn(this, new UserLoggedInArgs() { Person = person });
            }


        }



    }


}

using eClinicals.Controllers;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace eClinicals.View
{
    public partial class frmMain : Form
    {

        const int MIDDLE =0;
        const int TOP = 1;
        const int BOTTOM = 2;
        LoginController loginController;
        RibbonController ribbonController;      
        NurseLoggedInViewController nurseLoggedInViewController;
        PatientSearchViewController patientSearchViewController;
        RegistrationViewController registrationViewController;
        public frmMain()
        {
            InitializeComponent();           
        }

        private void frmMain_Load(object sender, EventArgs e)
        {


            loginController = new LoginController(this, new frmLogin());
            loginController.LoggedIn += this.OnLoggedIn;
            AddToContainer(loginController, MIDDLE);
        }


        public void OnLoggedIn(object source, EventArgs e) {
            nurseLoggedInViewController = new NurseLoggedInViewController(this, new frmNurseMenuSelectView());
            AddToContainer(nurseLoggedInViewController,MIDDLE);

            nurseLoggedInViewController.frmNurseMenuSelectView.btnFindPatientRecord.Click += new EventHandler(btnFindPatientRecord_Click);
            nurseLoggedInViewController.frmNurseMenuSelectView.btnRegisterAPatient.Click += new EventHandler(btnRegisterAPatient_Click);

            ribbonController = new RibbonController(this, new frmRibbon());
            AddToContainer(ribbonController, TOP);
            this.pTop.Visible = true;
            
            
            // This will Come from Database ////
            ribbonController.AddUserInfo("Stalbert, Malik", "12548", "Admin");
            ribbonController.AddContactInfo("9404-388-3729", "25 Ashley Circle \n Norcross, GA 30029");
            ribbonController.AddStatusInfo("Looged in");
            //===============================================
        }

        private void btnRegisterAPatient_Click(object sender, EventArgs e)
        {
            registrationViewController = new RegistrationViewController(this, new frmRegistration());
            AddToContainer(registrationViewController, MIDDLE);
            nurseLoggedInViewController.thisView.Close();

        }

        private void btnFindPatientRecord_Click(object sender, EventArgs e)
        {
            patientSearchViewController = new PatientSearchViewController(this, new frmPatientSearch());
            AddToContainer(patientSearchViewController, MIDDLE);
            this.lblStatus.Text = ("Patient Appointment Search View");
           

        }

        private void  AddToContainer(ControllerBase thisController, int level) {
            switch (level)
            {
                case MIDDLE :
                    thisController.mainForm.pMiddle.Controls.Add(thisController.thisView);
                    thisController.Show();    
                    break;
                case TOP:
                    thisController.mainForm.pTop.Controls.Add(thisController.thisView);
                    thisController.Show();              
                    break;
            }

        }
    }
}

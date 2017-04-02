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
        const int RIGHT = 3;
        eClinicalsController eClinicalsController;
        LoginController loginController;
        RibbonController ribbonController;
        PatientInfoRibbonController patientInfoRibbonController;
        NurseLoggedInViewController nurseLoggedInViewController;
        PatientSearchViewController patientSearchViewController;
        RegistrationViewController registrationViewController;
        PatientRecordTabsViewController patientRecordTabsViewController;
        frmBaseView currentViewOpened;
        public string status { get; set; }
        public bool isLoggedIn { get; set; }
        public frmMain()
        {
            InitializeComponent();
            pRight.Visible = false;
            eClinicalsController = new eClinicalsController();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            OpenLoginView();
        }       

        public void OnLoggedIn(object source, EventArgs e)
        {
            lblStatus.BackColor = System.Drawing.Color.Transparent;
            lblStatus.Text = "Logged in successfully.";
            OpenStartMenuView();

            ribbonController = new RibbonController(this, new frmRibbon());

            //register the handler for logged on event
            ribbonController.LoggedOut += this.OnLoggedOut;

            AddToContainer(ribbonController, TOP);
            this.pTop.Visible = true;
          

            // This will Come from datasource ////
            ribbonController.AddUserInfo("Last Name, First Name", "12548", "Nurse");
            ribbonController.AddContactInfo("9404-388-3729", "25 Ashley Circle \n Norcross, GA 30029");
            ribbonController.AddStatusInfo(this.status);
            //===============================================
            this.menuStripMain.Enabled = true;

            currentViewOpened = nurseLoggedInViewController.thisView;
        }
        public void OnLoggedOut(object source, EventArgs e)
        {
            lblStatus.Text = "LoogedOut in successfully.";
            CloseCurrentOpenView(currentViewOpened);
            this.pTop.Visible = false;
           
            lblStatus.Text = "Logged out successfully.";
            OpenLoginView();

        }
        private void btnRegisterAPatient_Click(object sender, EventArgs e)
        {

            OpenRegistrationView();
        }     

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Add Patient to database
            //Open Patient Record          
            this.lblStatus.Text = ("Open Patient Record : With Registered Patient");
        }
        private void btnFindPatientRecord_Click(object sender, EventArgs e)
        {            
            OpenPatientSearch();
        }       

        private void btnOpen_Click(object sender, EventArgs e)
        {

            CloseCurrentOpenView(currentViewOpened);
            //TODO:   Open Patient Record
            this.lblStatus.Text = "  Open Patient Record";
            patientInfoRibbonController = new PatientInfoRibbonController(this, new frmPatientInfoRibbon());
            patientRecordTabsViewController = new PatientRecordTabsViewController(this, new frmPatientRecordTabs());
            
            AddToContainer(patientRecordTabsViewController, MIDDLE);

            AddToContainer(patientInfoRibbonController, RIGHT);
            patientInfoRibbonController.AddContactInfo("909-656-6589","100 pine street \n Colton Ca 92324");
            patientInfoRibbonController.AddAppointmentInfo("Annual Visit","Headache \n Cough");
            patientInfoRibbonController.AddUserInfo("35", "M", "12546");
           // patientSearchViewController.frmPatientSearch.Close();
            

        }
       // ===========================OPEN VIEWS

        private void OpenPatientSearch()
        {
            CloseCurrentOpenView(currentViewOpened);
            patientSearchViewController = new PatientSearchViewController(this, new frmPatientSearch());
            AddToContainer(patientSearchViewController, MIDDLE);

            this.lblStatus.Text = ("Patient Appointment Search View");
            patientSearchViewController.frmPatientSearch.btnOpen.Click += new EventHandler(btnOpen_Click);         
          
        }
      

        private void OpenRegistrationView()
        {
            CloseCurrentOpenView(currentViewOpened);
            registrationViewController = new RegistrationViewController(this, new frmRegistration());
            AddToContainer(registrationViewController, MIDDLE);        
          
            registrationViewController.frmRegistration.btnRegister.Click += new EventHandler(btnRegister_Click);  
        }


        private void OpenLoginView()
        {
            loginController = new LoginController(this, new frmLogin());

            //register the handler for logged on event
            loginController.LoggedIn += this.OnLoggedIn;

            AddToContainer(loginController, MIDDLE);
            currentViewOpened = null;
        }
        // ===========================
        private void startMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenStartMenuView();
        }
        private void OpenStartMenuView()
        {
            CloseCurrentOpenView(currentViewOpened);
            nurseLoggedInViewController = new NurseLoggedInViewController(this, new frmNurseMenuSelectView());
            AddToContainer(nurseLoggedInViewController, MIDDLE);

            nurseLoggedInViewController.frmNurseMenuSelectView.btnFindPatientRecord.Click += new EventHandler(btnFindPatientRecord_Click);
            nurseLoggedInViewController.frmNurseMenuSelectView.btnRegisterAPatient.Click += new EventHandler(btnRegisterAPatient_Click);
        }

        private void AddToContainer(ControllerBase thisController, int level)
        {
           
            switch (level)
            {
                case MIDDLE:
                    thisController.mainForm.pMiddle.Controls.Add(thisController.thisView);
                    currentViewOpened = thisController.thisView;
                    thisController.Show();
                    break;
                case TOP:
                    thisController.mainForm.pTop.Controls.Add(thisController.thisView);
                    thisController.Show();
                    break;
                case RIGHT:
                    thisController.mainForm.pRight.Controls.Add(thisController.thisView);
                    pRight.Visible = true;
                    thisController.Show();
                    break;
            }           
        }
        private void CloseCurrentOpenView(frmBaseView currentViewOpenToClose)
        {
            if (currentViewOpenToClose != null)
            {
                currentViewOpenToClose.Close();
            }
           
        }
    }
}

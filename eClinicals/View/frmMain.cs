using eClinicals.Controllers;
using eClinicals.Events;
using eClinicals.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static eClinicals.Controllers.LoginController;

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
  
        private const int BY_DOB_NAME = 0;
        private const int BY_DOB = 1;
        private const int BY_NAME = 2;
        frmBaseView currentViewOpened;
        public string status { get; set; }
        public bool isLoggedIn { get; set; }      
        private Patient selectedPatient;
        private Person selectedUser;
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
       
        public void OnLoggedIn(object source, UserLoggedInArgs e)
        {
            lblStatus.BackColor = System.Drawing.Color.Transparent;
            lblStatus.Text = "Logged in successfully.";
            OpenStartMenuView();

            ribbonController = new RibbonController(this, new frmRibbon());

            //register the handler for logged on event
            ribbonController.LoggedOut += this.OnLoggedOut;

            AddToContainer(ribbonController, TOP);
            this.pTop.Visible = true;


            // !!!!!!!!!!!!!!!!!!!!!!!!!NEED NURSE  METHOD
           
            selectedUser = e.Person;          
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!   USER INFO

            ribbonController.AddUserInfo(selectedUser.LastName + ", "+ selectedUser.FirstName , selectedUser.ContactID, selectedUser.UserType);
            ribbonController.AddContactInfo("9404-388-3729", "25 Ashley Circle \n Norcross, GA 30029");
            ribbonController.AddStatusInfo(this.status);
            //===============================================
            this.menuStripMain.Enabled = true;
            currentViewOpened = nurseLoggedInViewController.thisView;
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
        public void OnLoggedOut(object source, EventArgs e)
        {
            Status("LoggedOut in successfully.", Color.Transparent);
           
            CloseCurrentOpenView(currentViewOpened);
            this.pTop.Visible = false;
            this.pRight.Visible = false;
          
            selectedPatient = null;
            selectedUser = null;
            OpenLoginView();
        }

        private void btnRegisterAPatient_Click(object sender, EventArgs e)
        {

            OpenRegistrationView();
        }           
        private void btnFindPatientRecord_Click(object sender, EventArgs e)
        {            
            OpenPatientSearch();
        }            
       // ===========================OPEN VIEWS

        private void OpenPatientSearch()
        {
            CloseCurrentOpenView(currentViewOpened);
            patientSearchViewController = new PatientSearchViewController(this, new frmPatientSearch());
            AddToContainer(patientSearchViewController, MIDDLE);
            this.lblStatus.Text = ("Patient Appointment Search View");
            patientSearchViewController.frmPatientSearch.btnOpen.Click += new EventHandler(btnOpen_Click);
            patientSearchViewController.frmPatientSearch.btnSearch.Click += new EventHandler(btnSearch_Click);
            patientSearchViewController.frmPatientSearch.dgvSearchResults.CellClick += new  DataGridViewCellEventHandler(dgvSearchResults_CellClick);
        }
        // Open Patient information
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (selectedPatient != null)
            {
                CloseCurrentOpenView(currentViewOpened);
                //TODO:   Open Patient Record !!!!!!!!!!!!!!!!!!!!!!!!!NEED VISIT METHOD
                string message = selectedPatient.FirstName + selectedPatient.LastName + " Record is now open.";
                Status(message, Color.Transparent);
                patientInfoRibbonController = new PatientInfoRibbonController(this, new frmPatientInfoRibbon());
                patientRecordTabsViewController = new PatientRecordTabsViewController(this, new frmPatientRecordTabs());

                AddToContainer(patientRecordTabsViewController, MIDDLE);
                AddToContainer(patientInfoRibbonController, RIGHT);
                frmPatientInfoRibbon patienRibbon = patientInfoRibbonController.ribbon;
                frmPatientRecordTabs frmPatientTabs = patientRecordTabsViewController.frmPatientRecordTabs;
                AddPatientRibonInfo(selectedPatient);
               int selectedPatientID = selectedPatient.PatientID;// selectedPatient.id NEEDED
                patienRibbon.btnSearchPatient.Click  += new EventHandler(btnSearchPatient_Click);

                //returns a routine check
                frmPatientTabs.dgPreviousReadings__RoutineCheck.DataSource = eClinicalsController.GetPreviousReadings(selectedPatientID);

                //  public bool CreateAppointment(DateTime appointmentDate, int patientID, int doctorID)
                string reason = frmPatientTabs.cbReason_SetAppointment.Text;

                //  !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
               // Doctor doctor = frmPatientTabs.cbSelectDoctor_OrderTest.Text;


                DateTime dateOnly = frmPatientTabs.dtpAppointmentDate_SetAppointment.Value;
                DateTime timeOnly = frmPatientTabs.dtpAppointmentDate_SetAppointment.Value;
                DateTime dateAndTime = dateOnly.Date.Add(timeOnly.TimeOfDay);
                //  !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                //  !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
           // FIX   // eClinicalsController.CreateAppointment(dateAndTime, selectedPatient.PatientID, Doctor); !!!!!!!!!!!!!!!!!!!! NEED Doctor  ID

               //  !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            }
            else {               
                Status("No Patient Selected", Color.Yellow);
            }         
        }

        private void btnSearchPatient_Click(object sender, EventArgs e)
        {
           //when a view is opened it automatically closes the previous view in center panel
            OpenPatientSearch();
        }

        private void AddPatientRibonInfo(Person selectedPatient)
        {
            // ADD Patient Side bar
            string mailingAddres = selectedPatient.Address + "\n" + selectedPatient.City +
                                " , " + selectedPatient.State + " " + selectedPatient.Zip;
            patientInfoRibbonController.AddContactInfo(selectedPatient.Phone, mailingAddres);

            patientInfoRibbonController.AddAppointmentInfo("Annual Visit", "Headache \n Cough");
            patientInfoRibbonController.AddUserInfo((DateTime.Now.Year - selectedPatient.Dob.Year).ToString(),
                                        selectedPatient.Gender, selectedPatient.ContactID.ToString());
        }

        //Select a patient from grid
        private void dgvSearchResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {         
            try
            {
                if (e.RowIndex >= 0)
                {
                    selectedPatient = (Patient)patientSearchViewController.frmPatientSearch.dgvSearchResults.CurrentRow.DataBoundItem;
                    string message  = "|Patient Selected: " + selectedPatient.FirstName +
                        "  " + selectedPatient.LastName +
                        "...Pressing the open Button will open the patient's record.";    
                    Status(message, Color.Transparent);
                }
                else
                {
                    Status("No records are listed for selection.",Color.Yellow);
                }
            }
            catch (Exception)
            {
                throw;
            }   
        }    
        // Search for patient  
        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblStatus.BackColor = Color.Transparent;
            List<Patient> myPatientsList = null;
            DateTime DOB = DateTime.Parse(patientSearchViewController.frmPatientSearch.dtpDate.Value.ToShortDateString());         
            string FirstName = patientSearchViewController.frmPatientSearch.txtFirstName.Text;
            string LastName = patientSearchViewController.frmPatientSearch.txtLastName.Text;
            switch (patientSearchViewController.frmPatientSearch.cbSearch.SelectedIndex)
            {              

                case BY_DOB_NAME:                                               
                    myPatientsList =  eClinicalsController.SearchPatientByLastNameAndDOB(LastName, DOB);                   
                     lblStatus.Text = "DOB and Last Name Selected for search"; 
                    break;
                case BY_DOB:                            
                    lblStatus.Text = "DOB Selected for search";
                    myPatientsList = eClinicalsController.SearchPatientByDOB(DOB);                 
                    break;
                case BY_NAME:
                    lblStatus.Text = "First and Last name Selected for search";
                    myPatientsList = eClinicalsController.SearchPatientByFirstAndLastName(FirstName, LastName);                  
                    break;
                default:
                    break;
            }  
            patientSearchViewController.frmPatientSearch.dgvSearchResults.DataSource = myPatientsList;
        }

        private void OpenRegistrationView()
        {

            CloseCurrentOpenView(currentViewOpened);
            registrationViewController = new RegistrationViewController(this, new frmRegistration());
            AddToContainer(registrationViewController, MIDDLE);                  
            registrationViewController.frmRegistration.btnRegister.Click += new EventHandler(btnRegister_Click);
            registrationViewController.frmRegistration.btnCancel.Click += new EventHandler(btnRegisterCancel_Click);

        }

        private void btnRegisterCancel_Click(object sender, EventArgs e)
        {
            registrationViewController.frmRegistration.Close();
            OpenStartMenuView();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            string lastName = registrationViewController.frmRegistration.txtLastName.Text;
            string firstName = registrationViewController.frmRegistration.txtFirstName.Text;
            DateTime dob = registrationViewController.frmRegistration.dtpDOB.Value;
            string streetAddress = registrationViewController.frmRegistration.txtAddress.Text;
            string city = registrationViewController.frmRegistration.txtCity.Text;
            string state = registrationViewController.frmRegistration.cbState.Text;
            string zip = registrationViewController.frmRegistration.txtZipcode.Text;
            string phone = registrationViewController.frmRegistration.txtPhone.Text;
            string gender = registrationViewController.frmRegistration.cbGender.Text;
            string ssn = registrationViewController.frmRegistration.txtSSN.Text;
            int userType = registrationViewController.frmRegistration.cbUserType.SelectedIndex + 1;

           // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! NEED FIX !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            try
            {
                if (lastName != "" & firstName != "" & dob != null & streetAddress != "" & city != "" & state != "" & zip != "" & phone != "" & gender != "" & ssn != "" & userType > -1)
                {
                    eClinicalsController.CreateContactInfo(lastName, firstName, dob, streetAddress, city, state, zip, phone, gender, ssn, userType);

                }
                else
                {

                    Status("Form has an error please check that all fields are filled in : ", Color.Red);
                    return;
                }
            }
            catch (Exception)
            {
             
               
            }

            lblStatus.BackColor = Color.Transparent;


            this.lblStatus.Text = ("Open Patient Record : With Registered Patient");
            registrationViewController.frmRegistration.Close();
            OpenStartMenuView();
            Status(lastName+ ","+ firstName + " is now registered", Color.Yellow);
        }




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

        private void Status(string message, Color color)
        {
            lblStatus.BackColor = color;
            lblStatus.Text = message;
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

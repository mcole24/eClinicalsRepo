using eClinicals.Controllers;
using eClinicals.Events;
using eClinicals.Model;
using eClinicals.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static eClinicals.Controllers.LoginController;

namespace eClinicals.View
{
    public enum UserType {Doctor = 1, Administrator = 2, Nurse = 3, Patient = 4 };

    public partial class frmMain : Form
    {

        const int MIDDLE = 0;
        const int TOP = 1;
        const int BOTTOM = 2;
        const int RIGHT = 3;
        eClinicalsController eClinicalsController;
        LoginController loginController;
        RibbonController ribbonController;
        PatientInfoRibbonController patientInfoRibbonController;
        NurseLoggedInViewController nurseLoggedInViewController;
        PatientSearchViewController patientSearchViewController;
        AdminReportController adminReportController;
        RegistrationViewController registrationViewController;
        PatientRecordTabsViewController patientRecordTabsViewController;
        frmPatientInfoRibbon patienRibbon;
        frmPatientRecordTabs frmPatientTabs;


        private const int BY_DOB_NAME = 0;
        private const int BY_DOB = 1;
        private const int BY_NAME = 2;
        frmBaseView currentViewOpened;
        public string status { get; set; }
        public bool isLoggedIn { get; set; }
        private List<Appointment> selectedPatientAppointments;
        private Patient selectedPatient;
        private Appointment selectedAppointment;
        public int selectedPatientID;
        public Person currentUser;
        
        private AdminLoggedInViewController adminLoggedInViewController;
      

        public int currentPatientID
        {
            get { return this.selectedPatient.PatientID; }

        }
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
            Status("Logged in successfully.", Color.Green);    
            ribbonController = new RibbonController(this, new frmRibbon());
            //register the handler for logged on event
            ribbonController.LoggedOut += this.OnLoggedOut;
            AddToContainer(ribbonController, TOP);
            this.pTop.Visible = true;
            // !!!!!!!!!!!!!!!!!!!!!!!!!NEED NURSE  METHOD       
                
            currentUser = e.Person;     
           
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!   USER INFO
            ribbonController.AddUserInfo(currentUser.LastName + ", " + currentUser.FirstName, currentUser.ContactID, currentUser.UserType);
            ribbonController.AddContactInfo(currentUser.Phone, currentUser.Address + " " + currentUser.City + " ," + currentUser.State + "  " + currentUser.Zip);
            ribbonController.AddStatusInfo(this.status);
            //===============================================
            this.menuStripMain.Enabled = true;
            OpenStartMenuView();
        }     

        private void OpenLoginView()
        {
            loginController = new LoginController(this, new frmLogin());

            //register the handler for logged on event
            loginController.LoggedIn += this.OnLoggedIn;
            AddToContainer(loginController, MIDDLE);
            currentViewOpened = null;
            selectedPatient = null;
            currentUser = null;
        }
        public void OnLoggedOut(object source, EventArgs e)
        {
            Status("LoggedOut in successfully.", Color.Transparent);

            CloseCurrentOpenView(currentViewOpened);
            this.pTop.Visible = false;
            this.pRight.Visible = false;
            selectedPatient = null;
            currentUser = null;
            OpenLoginView();
        }

        private void btnRegisterAPatient_Click(object sender, EventArgs e)
        {

            OpenRegistrationView();
        }
      
        // Open Patient information
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (selectedPatient != null)
            {
                CloseCurrentOpenView(currentViewOpened);
                //TODO:   Open Patient Record !!!!!!!!!!!!!!!!!!!!!!!!!NEED VISIT METHOD
                string message = selectedPatient.FirstName + selectedPatient.LastName + " Record is now open. ID : " + selectedPatient.PatientID;
                Status(message, Color.Transparent);
                patientInfoRibbonController = new PatientInfoRibbonController(this, new frmPatientInfoRibbon());
                patientRecordTabsViewController = new PatientRecordTabsViewController(this, new frmPatientRecordTabs());

                AddToContainer(patientRecordTabsViewController, MIDDLE);
                AddToContainer(patientInfoRibbonController, RIGHT);
                patienRibbon = patientInfoRibbonController.ribbon;
                frmPatientTabs = patientRecordTabsViewController.frmPatientRecordTabs;             
                //add patient ribbon
                AddPatientRibonInfo(selectedPatient);//       
                patienRibbon.btnSearchPatient.Click += new EventHandler(btnSearchPatient_Click);
                // add nurse
              //  patientRecordTabsViewController.selectedNurse = currentNurse;
                //Fill View appointments
                selectedPatientAppointments = eClinicalsController.GetAppointmentsByPatientID(selectedPatientID);               
                frmPatientTabs.dgViewAppointments_ViewAppointments.DataSource = selectedPatientAppointments;

               // NEED FIX :: frmPatientTabs.dgTestResults_TestResults.DataSource = eClinicalsController.GetTestResults(selectedPatient.PatientID);

                patientRecordTabsViewController.fillPatientInfo(selectedPatient);
             
            }
            else
            {
                Status("No Patient Selected", Color.Yellow);
            }
        }

        private void btnOrderTest_Click(object sender, EventArgs e)
        {
            if (frmPatientTabs.cbSelectTest_OrderTest.SelectedIndex > -1 & frmPatientTabs.cbSelectDoctor_OrderTest.SelectedIndex > -1)
            {
                Status("Routine CheckUp Added : ", Color.Yellow);
            }
            else
            {
                Status("Please fill out all form elements : ", Color.Red);
            }
        } 

        private void btnSelectAppointment_Click(object sender, EventArgs e)
        {
            // "shows" tab page 2
            if (selectedAppointment != null)
            {
                frmPatientTabs.tabPatientRecord.TabPages.Add(frmPatientTabs.tabRoutineCheck);
                frmPatientTabs.tabPatientRecord.SelectedTab = frmPatientTabs.tabRoutineCheck;
            }
            else
            {
                Status("No Appointment has been selected ", Color.Yellow);

            }

        }
        private void dgViewAppointments_ViewAppointments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    selectedAppointment = (Appointment)frmPatientTabs.dgViewAppointments_ViewAppointments.CurrentRow.DataBoundItem;
                    string message = "|Appointment Selected: " + selectedAppointment.AppointmentDoctor +
                        "  " + selectedAppointment.AppointmentDate + " ID:" + selectedAppointment.AppointmentID +
                        "...Pressing the start routine checkup Button will select the appointment for checkup.";
                    Status(message, Color.Transparent);
                    selectedPatientID = selectedPatient.PatientID;
                }
                else
                {
                    Status("No appointment has been selection.", Color.Yellow);
                }
            }
            catch (Exception)
            {
                throw;
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
            patientInfoRibbonController.ribbon.lblUserName.Text = (selectedPatient.LastName + " ," + selectedPatient.FirstName);
            string mailingAddres = selectedPatient.Address + "\n" + selectedPatient.City +
                                " , " + selectedPatient.State + " " + selectedPatient.Zip;
            patientInfoRibbonController.AddContactInfo(selectedPatient.Phone, mailingAddres);

            patientInfoRibbonController.AddAppointmentInfo("Annual Visit", "Headache \n Cough");
            patientInfoRibbonController.AddUserInfo((DateTime.Now.Year - selectedPatient.Dob.Year).ToString(),
                                        selectedPatient.Gender, selectedPatient.ContactID.ToString());
        }

        //*************************************************************************************   Select a patient from grid
        private void dgvSearchResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    selectedPatient = (Patient)patientSearchViewController.frmPatientSearch.dgvSearchResults.CurrentRow.DataBoundItem;
                    string message = "|Patient Selected: " + selectedPatient.FirstName +
                        "  " + selectedPatient.LastName + " ID:" + selectedPatient.PatientID +
                        "...Pressing the open Button will open the patient's record.";
                    Status(message, Color.Transparent);
                    selectedPatientID = selectedPatient.PatientID;
                }
                else
                {
                    Status("No records are listed for selection.", Color.Yellow);
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
                    myPatientsList = eClinicalsController.SearchPatientByLastNameAndDOB(LastName, DOB);
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
            ExtensionGridView.RemoveEmptyColumns(patientSearchViewController.frmPatientSearch.dgvSearchResults);
        }

        private void OpenRegistrationView()
        {
            frmRegistration frmReg = new frmRegistration();
            CloseCurrentOpenView(currentViewOpened);
            registrationViewController = new RegistrationViewController(this, frmReg);
            AddToContainer(registrationViewController, MIDDLE);
            frmReg.mainForm = this;

        }
        private void startMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenStartMenuView();
        }

        public void OpenStartMenuView()
        {
            setUserViewByType(currentUser.UserType);           
        }

        private void setUserViewByType(int userType)
        {                  
          
            switch (userType)
            {
                case (int)UserType.Administrator:                 

                    adminLoggedInViewController = new AdminLoggedInViewController(this, new frmAdminMenuSelectView());
                    //currentAdmin = eClinicalsController.GetAdminByID(currentUser.ContactID);
                    CloseCurrentOpenView(currentViewOpened);
                    currentViewOpened = adminLoggedInViewController.thisView;             
                    AddToContainer(adminLoggedInViewController, MIDDLE);
                    adminLoggedInViewController.frmAdminMenuSelectView.btnGenerateReport.Click += new EventHandler(btnGenerateReport_Click);
                    Status("Admin View Open", Color.Yellow);
                    break;

                case (int)UserType.Nurse:
                  // currentNurse = eClinicalsController.GetNurseByID(currentUser.ContactID); 
                    nurseLoggedInViewController = new NurseLoggedInViewController(this, new frmNurseMenuSelectView());
                    CloseCurrentOpenView(currentViewOpened);
                    currentViewOpened = nurseLoggedInViewController.thisView;   
                    AddToContainer(nurseLoggedInViewController, MIDDLE);
                    nurseLoggedInViewController.frmNurseMenuSelectView.btnFindPatientRecord.Click += new EventHandler(btnFindPatientRecord_Click);
                    nurseLoggedInViewController.frmNurseMenuSelectView.btnRegisterAPatient.Click += new EventHandler(btnRegisterAPatient_Click);
                    Status("Nurses View Open", Color.Yellow);
                    break;

                case (int)UserType.Doctor:
                    MessageBox.Show("There is no view for user type : Doctor");
                    Status("There is no view for user type : Doctor", Color.Red);
                    break;

                default:
                    break;
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            OpenReport();
        }      
        private void btnFindPatientRecord_Click(object sender, EventArgs e)
        {
            OpenPatientSearch();
        }
        private void OpenReport()
        {
            CloseCurrentOpenView(currentViewOpened);
           adminReportController = new AdminReportController(this, new frmAdminReport());
            AddToContainer(adminReportController, MIDDLE);
            this.lblStatus.Text = ("Admin Report View");
           // adminReportController.frmAdminReport.btnOpen.Click += new EventHandler(btnOpen_Click);           /
           // adminReportController.frmPatientSearch.dgvSearchResults.CellClick += new DataGridViewCellEventHandler(dgvSearchResults_CellClick);

        }

        private void OpenPatientSearch()
        {
            CloseCurrentOpenView(currentViewOpened);
            patientSearchViewController = new PatientSearchViewController(this, new frmPatientSearch());
            AddToContainer(patientSearchViewController, MIDDLE);
            this.lblStatus.Text = ("Patient Appointment Search View");
            patientSearchViewController.frmPatientSearch.btnOpen.Click += new EventHandler(btnOpen_Click);
            patientSearchViewController.frmPatientSearch.btnSearch.Click += new EventHandler(btnSearch_Click);
            patientSearchViewController.frmPatientSearch.dgvSearchResults.CellClick += new DataGridViewCellEventHandler(dgvSearchResults_CellClick);
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

        public void Status(string message, Color color)
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
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

﻿using eClinicals.Controllers;
using eClinicals.Events;
using eClinicals.Model;
using eClinicals.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Threading;

namespace eClinicals.View
{
    public enum UserType { Doctor = 1, Administrator = 2, Nurse = 3, Patient = 4 };
    public enum NoticeType { Administrator = 1, Nurse = 2 };

    public partial class frmMain : Form
    {

        const int MIDDLE = 0;
        const int TOP = 1;
        const int BOTTOM = 2;
        const int RIGHT = 3;


        eClinicalsController eClinicalsController;
        LoginController loginController;
        RibbonController ribbonController;
        internal PatientInfoRibbonController patientInfoRibbonController;
        NurseLoggedInViewController nurseLoggedInViewController;
        PatientSearchViewController patientSearchViewController;
        AdminReportController adminReportController;
        RegistrationViewController registrationViewController;
        PatientRecordTabsViewController patientRecordTabsViewController;
        frmPatientInfoRibbon patienRibbon;
        frmPatientRecordTabs frmPatientTabs;
        frmRibbon frmUserRibbon;
        DispatcherTimer noUser;
        private const int BY_DOB_NAME = 0;
        private const int BY_DOB = 1;
        private const int BY_NAME = 2;
        frmBaseView currentViewOpened;
        public string status { get; set; }
        public bool isLoggedIn { get; set; }
        internal List<Appointment> selectedPatientAppointments;
        internal Patient selectedPatient;
        internal Appointment selectedAppointment;
        public int selectedPatientID;
        public Person currentUser;

        private AdminLoggedInViewController adminLoggedInViewController;
        internal Nurse currentNurse;

        public int currentPatientID
        {
            get { return this.selectedPatient.PatientID; }

        }
        public frmMain()
        {
            InitializeComponent();
            pRight.Visible = false;
            eClinicalsController = new eClinicalsController();
            frmUserRibbon = new frmRibbon();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            OpenLoginView();
        }

        public void OnLoggedIn(object source, UserLoggedInArgs e)
        {
            lblStatus.BackColor = System.Drawing.Color.Transparent;
            Status("Logged in successfully.", Color.Green);

            //register the handler for logged on event         
            currentUser = null;
            currentUser = e.Person;


            ribbonController = new RibbonController(this, frmUserRibbon);
            ribbonController.LoggedOut += this.OnLoggedOut;
            AddToContainer(ribbonController, TOP);
            this.pTop.Visible = true;

            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!   USER INFO
            SetUserInfo();
            ribbonController.AddStatusInfo(this.status);
            //===============================================
            this.menuStripMain.Enabled = true;
            OpenStartMenuView();
        }

        private void SetUserInfo()
        {
            ribbonController.AddUserInfo(currentUser.LastName + ", " +
                currentUser.FirstName, currentUser.ContactID, currentUser.UserType);


            ribbonController.AddContactInfo(currentUser.Phone, currentUser.Address +
                " " + currentUser.City + " ," + currentUser.State + "  " + currentUser.Zip);
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
            CloseCurrentOpenView(currentViewOpened);
            this.pTop.Visible = false;
            this.pRight.Visible = false;
            selectedPatient = null;
            currentUser = null;
            currentNurse = null;
            OpenLoginView();

            Status("LoggedOut in successfully.", Color.Transparent);
        }

        private void btnRegisterAPatient_Click(object sender, EventArgs e)
        {

            OpenRegistrationView();
        }
        // Open Patient information
        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedPatient != null)
                {
                    CloseCurrentOpenView(currentViewOpened);
                    string message = selectedPatient.FirstName + selectedPatient.LastName + " Record is now open. ID : " + selectedPatient.PatientID;
                    Status(message, Color.Transparent);
                    patientInfoRibbonController = new PatientInfoRibbonController(this, new frmPatientInfoRibbon());
                    patientRecordTabsViewController = new PatientRecordTabsViewController(this, new frmPatientRecordTabs());
                    AddToContainer(patientRecordTabsViewController, MIDDLE);
                    AddToContainer(patientInfoRibbonController, RIGHT);
                    patienRibbon = patientInfoRibbonController.ribbon;
                    frmPatientTabs = patientRecordTabsViewController.frmPatientRecordTabs;
                    // Disable Tabs
                    frmPatientTabs.tabPatientRecord.TabPages.Remove(frmPatientTabs.tabOrderTests);
                    frmPatientTabs.tabPatientRecord.TabPages.Remove(frmPatientTabs.tabDiagnosis);

                    //add patient ribbon
                    AddPatientRibonInfo(selectedPatient);
                    patienRibbon.btnSearchPatient.Click += new EventHandler(btnSearchPatient_Click);

                    //Fill View appointments
                    selectedPatientAppointments = eClinicalsController.GetAllAppointmentsByPatientID(selectedPatientID);
                    frmPatientTabs.dgViewAppointments_ViewAppointments.DataSource = selectedPatientAppointments;

                    patientRecordTabsViewController.fillPatientInfo(selectedPatient);
                    frmPatientTabs.dgTestResults_TestResults.DataSource = eClinicalsController.GetTestResults(selectedPatientID);


                    ExtensionGridView.RemoveAppointmentIdColumns(frmPatientTabs.dgViewAppointments_ViewAppointments);







                }
                else
                {
                    Status("No Patient Selected", Color.Yellow);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Error in  : " + ex.TargetSite);
                Status(ex.Message + " Error in  : " + ex.TargetSite, Color.Red);
            }


            try
            {

                currentNurse = eClinicalsController.GetNurseByID(currentUser.ContactID);
                Status("Current Nures: " + currentNurse.FirstName, Color.Yellow);
            }
            catch (Exception ex)
            {
                Status(ex.Message + " Error in  : " + ex.TargetSite, Color.Red);
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

            if (selectedAppointment != null)
            {
                frmPatientTabs.tabPatientRecord.TabPages.Remove(frmPatientTabs.tabRoutineCheck);
                frmPatientTabs.tabPatientRecord.TabPages.Add(frmPatientTabs.tabRoutineCheck);
                frmPatientTabs.tabPatientRecord.SelectedTab = frmPatientTabs.tabRoutineCheck;
            }
            else
            {
                Status("No Appointment has been selected ", Color.Yellow);

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

        //******************************************  Select a patient from grid
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
            catch (Exception ex)
            {
                Status(ex.Message, Color.Red);
            }
        }
        // Search for patient  
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
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
                if (myPatientsList.Count < 1)
                {

                    string title = "No Patient Found";
                    string message = "\n+ Check your search parameters for mistakes. \n";
                    message += "+ You may have to register a new patient.";
                    title.ToUpper();



                    noUser = new DispatcherTimer();
                    noUser.Interval = TimeSpan.FromSeconds(3);
                    noUser.Tick += new EventHandler(noUser_Tick);
                    noUser.Start();
                    patientSearchViewController.frmPatientSearch.NoPatientFound(true, title, message);

                }


                patientSearchViewController.frmPatientSearch.dgvSearchResults.DataSource = myPatientsList;
                ExtensionGridView.RemoveEmptyColumns(patientSearchViewController.frmPatientSearch.dgvSearchResults);
            }
            catch (Exception ex)
            {

                Status(ex.Message, Color.Red);
            }
        }

        private void noUser_Tick(object sender, EventArgs e)
        {
            patientSearchViewController.frmPatientSearch.NoPatientFound(false);
            noUser.Stop();
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
                    setNotification(2000, "Important notice", "eClinicals Login status: Admin", ToolTipIcon.Info, NoticeType.Administrator);
                    Status("Admin View Open", Color.Yellow);
                    break;

                case (int)UserType.Nurse:
                    currentNurse = eClinicalsController.GetNurseByID(currentUser.ContactID);
                    nurseLoggedInViewController = new NurseLoggedInViewController(this, new frmNurseMenuSelectView());
                    CloseCurrentOpenView(currentViewOpened);
                    currentViewOpened = nurseLoggedInViewController.thisView;
                    AddToContainer(nurseLoggedInViewController, MIDDLE);
                    nurseLoggedInViewController.frmNurseMenuSelectView.btnFindPatientRecord.Click += new EventHandler(btnFindPatientRecord_Click);
                    nurseLoggedInViewController.frmNurseMenuSelectView.btnRegisterAPatient.Click += new EventHandler(btnRegisterAPatient_Click);
                    setNotification(2000, "Important notice", "eClinicals Login status: Nurse", ToolTipIcon.Info, NoticeType.Nurse);

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

            adminReportController.frmAdminReport.controller = adminReportController;
            adminReportController.frmAdminReport.eController = eClinicalsController;

            AddToContainer(adminReportController, MIDDLE);
            this.lblStatus.Text = ("Ready...");
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
        private void setNotification(int time, string title, string description, ToolTipIcon info, NoticeType nt)
        {
            if (nt == NoticeType.Administrator)
            {
                adminNotification.ShowBalloonTip(time, title, description, info);
            }
            if (nt == NoticeType.Nurse)
            {
                nurseNotification.ShowBalloonTip(time, title, description, info);
            }

        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenRegistrationView();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
        }

        private void menuStripMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenPatientSearch();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void generateReporToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenReport();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using eClinicals.Model;
using eClinicals.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace eClinicals.Controllers
{
    enum CURRENT_APP_VIEW { ALL = 0, FUTURE = 1, PAST = 3, CURRENT = 4 };
    enum SELECTED_INITIAL_DIAGNOSIS { TRUE = 1, FALSE = 0 };
    enum TAB { PERSONAL = 0, SET_APPONTMENT = 1, VIEW_APPOINTMENT = 2, ROUTINE_CHECK = 3, ORDER_TEST = 4, TEST_RESULTS = 5, DIAGNOSIS = 6 };
    //Current view is used to determin which buttons and ui elements should be active

    class PatientRecordTabsViewController : ControllerBase
    {
        public frmPatientRecordTabs frmPatientRecordTabs;
        eClinicalsController eClinicalsController;
        private Patient patient;
        private Appointment selectedAppointment;
        private List<Appointment> selectedPatientAppointments;
        internal Nurse currentNurse;

        internal frmMain mainForm;
        private List<Appointment> selectedFuturePatientAppointments;
        CURRENT_APP_VIEW CURRENT_APP_VIEW;
        private List<Appointment> selectedPastPatientAppointments;
        private List<Appointment> selectedCurrentPatientAppointments;
        public bool result;
        public bool isRoutineCheckOpen;
        private bool initDiagnosis;
        private bool finalDiagnosis;
        private bool isOrderTestOpen;
        private Dictionary<int, string> results;
        private string selectedTestResultId;
        private DateTime selectedTestResultPerformedDate;
        private int selectedTestResultResult;
        private string selectedTestResultName;
        private int selectedTestResultCode;
        private int selectedVisitID;
        private int selectedDiagnosisID;
        private Visit selectedVisit;
        private Diagnosis selectedDiagnosis;
        private int testID;
        private bool routineCheckCompleted;
        private Appointment reason;

        public LabTest selectedTestResult { get; private set; }
        public PatientRecordTabsViewController(frmMain mainForm, frmBaseView thisView) : base(mainForm, thisView)
        {
            eClinicalsController = new eClinicalsController();

            frmPatientRecordTabs = (frmPatientRecordTabs)base.thisView;
            this.mainForm = (frmMain)base.mainForm;
            mainForm.lblStatus.Text = "Patient Record Tabs active . . .";
            setEventHandlers();
            currentNurse = this.mainForm.currentNurse;
            isRoutineCheckOpen = false;
            isOrderTestOpen = false;
            // frmPatientRecordTabs.dgTestResults_TestResults.DataSource = eClinicalsController.GetTestResults(1);
            results = new Dictionary<int, string>();
            results.Add(1, "positive");
            results.Add(0, "negative");
            routineCheckCompleted = false;

        }
        public void fillPatientInfo(Patient patient)
        {
            // *** pateint comes from frmMain ***
            if (patient != null)
            {
                this.patient = patient;

            }
            else
            {
                mainForm.Status("Patient cannot be null.", Color.Red);
            }
            frmPatientRecordTabs.txtFirstName.Text = patient.FirstName;
            frmPatientRecordTabs.txtLastName.Text = patient.LastName;
            frmPatientRecordTabs.txtSSN.Text = patient.Ssn;
            frmPatientRecordTabs.cbGender.Text = patient.Gender;
            frmPatientRecordTabs.dtpDOB.Text = patient.Dob.ToShortDateString();
            frmPatientRecordTabs.txtAddress.Text = patient.Address;
            frmPatientRecordTabs.txtCity.Text = patient.City;
            frmPatientRecordTabs.cbState.Text = patient.State;
            frmPatientRecordTabs.txtZipcode.Text = patient.Zip;
            frmPatientRecordTabs.txtPhone.Text = patient.Phone;
            List<Symptom> allSymptoms = eClinicalsController.GetAllSymptoms();
            // frmPatientRecordTabs.clbSymptoms_RoutineCheck.DataSource = allSymptoms;
            frmPatientRecordTabs.cbSelectDoctor_OrderTest.DataSource = eClinicalsController.GetAllDoctorNames();
            frmPatientRecordTabs.cbSelectTest_OrderTest.DataSource = eClinicalsController.GetAllTests();

            // ?? Hide panel
            frmPatientRecordTabs.tabPatientRecord.TabPages.Remove(frmPatientRecordTabs.tabRoutineCheck);

            //returns a routine check
            frmPatientRecordTabs.dgPreviousReadings__RoutineCheck.DataSource =
                eClinicalsController.GetPreviousReadings(patient.PatientID);
        }
        // DataGrid
        private void dgViewAppointments_ViewAppointments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    selectedAppointment = (Appointment)frmPatientRecordTabs.dgViewAppointments_ViewAppointments.CurrentRow.DataBoundItem;
                    string message = "|Appointment Selected: " + selectedAppointment.AppointmentDoctor +
                        "  " + selectedAppointment.AppointmentDate + " ID:" + selectedAppointment.AppointmentID +
                        "...Pressing the start routine checkup Button will select the appointment for checkup.";
                    this.mainForm.Status(message, Color.Transparent);
                    frmPatientRecordTabs.txtAppID.Text = selectedAppointment.AppointmentID.ToString();
                    frmPatientRecordTabs.dtpAppDate.Value = selectedAppointment.AppointmentDate;
                    frmPatientRecordTabs.cbAppDoctor.Text = selectedAppointment.AppointmentDoctor;
                    frmPatientRecordTabs.cbAppReason.Text = selectedAppointment.AppointmentReason;

                    checkAppointmentCurrentDate();
                    checkAppointmentFutureDate();
                    checkAppointmentPastDate();
                }
                else
                {
                    this.mainForm.Status("No appointment has been selected.", Color.Yellow);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void dgTestResults_TestResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //TODO Test Results Data grid selected Test Result
            try
            {
                if (e.RowIndex >= 0)
                {
                    selectedTestResult = (LabTest)frmPatientRecordTabs.dgTestResults_TestResults.CurrentRow.DataBoundItem;
                    selectedTestResultId = selectedTestResult.TestID.ToString();
                    selectedTestResultPerformedDate = selectedTestResult.PerformedDate;
                    selectedTestResultName = selectedTestResult.TestName;
                    selectedTestResultCode = selectedTestResult.TestCode;

                    string resultText = CheckResults(selectedTestResult.TestResult);



                    string message = "Selected Test: " + selectedTestResultName + "  Code: " + selectedTestResultCode + "  Results: " + resultText +
                        "  " + selectedTestResultPerformedDate + "  Test ID:" + selectedTestResultId +
                        "...Pressing the start routine checkup Button will select the appointment for checkup.";
                    frmPatientRecordTabs.txtTestId.Text = selectedTestResultId;
                    frmPatientRecordTabs.dtPerformedDate.Value = selectedTestResultPerformedDate;
                    this.mainForm.Status(message, Color.Transparent);
                }
                else
                {
                    this.mainForm.Status("No Test Result has been selected.", Color.Yellow);
                }
            }
            catch (Exception)
            {
                throw;
            }

        }
        private void btnSummary_Click(object sender, EventArgs e)
        {
            try
            {
                // mainForm.ucAppointmentSummary.dgVisitDetails.DataSource = eClinicalsController.GetAppointmentSummaryVisitDetails(selectedAppointment.AppointmentID);
                mainForm.ucAppointmentSummary.dgSymptoms.DataSource = eClinicalsController.GetAppointmentSummarySymptoms(selectedAppointment.AppointmentID);
                // mainForm.ucAppointmentSummary.dgCheckupResults.DataSource = eClinicalsController.GetAppointmentSummaryCheckupResults(selectedAppointment.AppointmentID);
                mainForm.ucAppointmentSummary.dgDiagnosisResults.DataSource = eClinicalsController.GetAppointmentSummaryDiagnosisResults(selectedAppointment.AppointmentID);
                mainForm.ucAppointmentSummary.dgTestResults.DataSource = eClinicalsController.GetAppointmentSummaryTestResults(selectedAppointment.AppointmentID);

            }
            catch (Exception ex)
            {

                mainForm.Status(ex.Message, Color.Red);
            }


            // mainForm.ucAppointmentSummary.lblDoctor.Text = selectedAppointment.AppointmentDoctor;
            // mainForm.ucAppointmentSummary.lblDate.Text = selectedAppointment.AppointmentDate.ToShortDateString();
            // mainForm.ucAppointmentSummary.lblReason.Text = selectedAppointment.AppointmentReason;
            mainForm.ucAppointmentSummary.Visible = true;
        }
        // End Datagrids
        private void checkAppointmentPastDate()
        {
            if (selectedAppointment.AppointmentDate.Date < DateTime.Now.Date)
            {
                showSummaryButton(true);
            }
            else
            {
                showSummaryButton(false);
                mainForm.Status("NOTE:  Only selected past date us viewed as summary....", Color.Yellow);
            }
        }
        private void checkAppointmentFutureDate()
        {
            if (selectedAppointment.AppointmentDate.Date > DateTime.Now.Date)
            {
                frmPatientRecordTabs.gbSelectEditApp.Enabled = true;
            }
            else
            {
                frmPatientRecordTabs.gbSelectEditApp.Enabled = false;
                mainForm.Status("NOTE:  Only selected future date can be edited....", Color.Yellow);
            }
        }
        private void checkAppointmentCurrentDate()
        {
            if (selectedAppointment.AppointmentDate.Date == DateTime.Now.Date)
            {
                frmPatientRecordTabs.gbBeginRoutineCheck.Enabled = true;
            }
            else
            {
                frmPatientRecordTabs.gbBeginRoutineCheck.Enabled = false;
                mainForm.Status("NOTE:  Only selected current date can begin routine check....", Color.Yellow);
            }
        }
        private void btnEditAppointment_Click(object sender, EventArgs e)
        {
            enableDisableEditAppointment("on");
        }
        private void enableDisableEditAppointment(string state)
        {
            switch (state)
            {
                case "on":
                    if (selectedAppointment != null)
                    {
                        frmPatientRecordTabs.gbShowAppontment.Enabled = false;
                        frmPatientRecordTabs.gbBeginRoutineCheck.Enabled = false;
                        frmPatientRecordTabs.gbViewAppointments.Enabled = false;
                        frmPatientRecordTabs.gbSelectEditApp.Enabled = false;
                        frmPatientRecordTabs.gbEditAppointment.Visible = true;
                    }
                    else
                    {
                        this.mainForm.Status("No appointment has been selection for edit.", Color.Yellow);
                    }
                    break;
                case "off":
                    frmPatientRecordTabs.gbShowAppontment.Enabled = true;
                    frmPatientRecordTabs.gbBeginRoutineCheck.Enabled = false;
                    frmPatientRecordTabs.gbViewAppointments.Enabled = true;
                    frmPatientRecordTabs.gbSelectEditApp.Enabled = false;
                    frmPatientRecordTabs.gbEditAppointment.Visible = false;
                    frmPatientRecordTabs.gbViewAppointments.BackColor = System.Drawing.Color.Transparent;
                    break;
                default:
                    break;
            }
        }
        private void btnCommitEdit_Click(object sender, EventArgs e)
        {
            try
            {

                Doctor doc = (Doctor)frmPatientRecordTabs.cbAppDoctor.SelectedItem;
                Appointment reason = (Appointment)frmPatientRecordTabs.cbAppReason.SelectedItem;
                DateTime dateOnly = frmPatientRecordTabs.dtpAppDate.Value;
                DateTime timeOnly = frmPatientRecordTabs.dtAppTime.Value;
                DateTime dateAndTime = dateOnly.Date.Add(timeOnly.TimeOfDay);


                //need to put last parameter as the appointment ID
                if (eClinicalsController.UpdateAppointment(dateAndTime, doc.DoctorID, reason.AppointmentReasonID, selectedAppointment.AppointmentID))
                {

                    enableDisableEditAppointment("off");
                    switch (CURRENT_APP_VIEW)
                    {
                        case CURRENT_APP_VIEW.ALL:
                            selectedPatientAppointments = eClinicalsController.GetAllAppointmentsByPatientID(patient.PatientID);
                            frmPatientRecordTabs.dgViewAppointments_ViewAppointments.DataSource = selectedPatientAppointments;
                            break;
                        case CURRENT_APP_VIEW.FUTURE:
                            selectedFuturePatientAppointments = eClinicalsController.GetAllFutureAppointmentsByPatientID(patient.PatientID);
                            frmPatientRecordTabs.dgViewAppointments_ViewAppointments.DataSource = selectedFuturePatientAppointments;
                            break;
                        case CURRENT_APP_VIEW.PAST:
                            selectedPastPatientAppointments = eClinicalsController.GetAllPastAppointmentsByPatientID(patient.PatientID);
                            frmPatientRecordTabs.dgViewAppointments_ViewAppointments.DataSource = selectedPastPatientAppointments;
                            break;
                        case CURRENT_APP_VIEW.CURRENT:
                            selectedCurrentPatientAppointments = eClinicalsController.GetAllCurrentDateAppointmentsByPatientID(patient.PatientID);
                            frmPatientRecordTabs.dgViewAppointments_ViewAppointments.DataSource = selectedCurrentPatientAppointments;
                            break;
                        default:
                            break;
                    }
                    base.mainForm.Status("Appointment has been updated", Color.Yellow);
                }
                else
                {
                    this.mainForm.Status("Appointment was not Set : Patient has another appointment at that time.", Color.Red);
                }

            }
            catch (Exception ex)
            {

                mainForm.Status(ex.Message, Color.Red);
            }
        }
        private void btnAppEditCancel_Click(object sender, EventArgs e)
        {
            enableDisableEditAppointment("off");
            base.mainForm.Status("Appointment edit canceled", Color.Yellow);
        }
        private void btnShowAllAppointments_Click(object sender, EventArgs e)
        {
            CURRENT_APP_VIEW = CURRENT_APP_VIEW.ALL;
            selectedPatientAppointments = eClinicalsController.GetAllAppointmentsByPatientID(patient.PatientID);
            frmPatientRecordTabs.dgViewAppointments_ViewAppointments.DataSource = selectedPatientAppointments;

        }
        private void btnShowFutureAppointments_Click(object sender, EventArgs e)
        {
            CURRENT_APP_VIEW = CURRENT_APP_VIEW.FUTURE;
            try
            {
                selectedFuturePatientAppointments = eClinicalsController.GetAllFutureAppointmentsByPatientID(patient.PatientID);
                frmPatientRecordTabs.dgViewAppointments_ViewAppointments.DataSource = selectedFuturePatientAppointments;
            }
            catch (Exception ex)
            {

                Status(ex.Message + " Select  future Appoinitment", Color.Red);
            }
            showSummaryButton(false);

        }
        private void btnShowCurrentAppointments_Click(object sender, EventArgs e)
        {
            CURRENT_APP_VIEW = CURRENT_APP_VIEW.CURRENT;
            try
            {
                selectedCurrentPatientAppointments = eClinicalsController.GetAllCurrentDateAppointmentsByPatientID(patient.PatientID);
                frmPatientRecordTabs.dgViewAppointments_ViewAppointments.DataSource = selectedCurrentPatientAppointments;
            }
            catch (Exception ex)
            {

                Status(ex.Message + " Select  Current Appoinitment", Color.Red);
            }
            showSummaryButton(false);

        }
        private void btnShowPastAppointments_Click(object sender, EventArgs e)
        {
            selectedPastPatientAppointments = eClinicalsController.GetAllPastAppointmentsByPatientID(patient.PatientID);
            frmPatientRecordTabs.dgViewAppointments_ViewAppointments.DataSource = selectedPastPatientAppointments;
            showSummaryButton(true);
        }
        private void btnCancel_RoutineCheck_Click(object sender, EventArgs e)
        {
            isRoutineCheckOpen = false;

            frmPatientRecordTabs.tabPatientRecord.TabPages.Remove(frmPatientRecordTabs.tabRoutineCheck);
            frmPatientRecordTabs.tabPatientRecord.SelectedTab = frmPatientRecordTabs.tabViewAppointments;
            string message = "";
            // EnableTab(frmPatientRecordTabs.tabRoutineCheck, false);
            EnableTabAlert(frmPatientRecordTabs.tabViewAppointments, true, message);
            EnableTabAlert(frmPatientRecordTabs.tabOrderTests, true, message);
            EnableTabAlert(frmPatientRecordTabs.tabTestsResults, true, message);
            EnableTabAlert(frmPatientRecordTabs.tabSetAppointments, true, message);
            EnableTabAlert(frmPatientRecordTabs.tabPersonal, true, message);
            enableDisableEditAppointment("off");

        }
        private void btnCancel_OrderTest_Click(object sender, EventArgs e)
        {
            isOrderTestOpen = false;
            string message = "";
            frmPatientRecordTabs.tabPatientRecord.TabPages.Remove(frmPatientRecordTabs.tabOrderTests);
            frmPatientRecordTabs.tabPatientRecord.SelectedTab = frmPatientRecordTabs.tabTestsResults;

            // EnableTab(frmPatientRecordTabs.tabRoutineCheck, false);
            EnableTabAlert(frmPatientRecordTabs.tabViewAppointments, true, message);
            EnableTabAlert(frmPatientRecordTabs.tabOrderTests, true, message);
            EnableTabAlert(frmPatientRecordTabs.tabTestsResults, true, message);
            EnableTabAlert(frmPatientRecordTabs.tabSetAppointments, true, message);
            EnableTabAlert(frmPatientRecordTabs.tabPersonal, true, message);
            enableDisableEditAppointment("off");
        }
        private void btnEditPerson_Click(object sender, EventArgs e)
        {
            EnableEdit();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DisableEdit();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                patient.LastName = frmPatientRecordTabs.lastName = frmPatientRecordTabs.txtLastName.Text;
                patient.FirstName = frmPatientRecordTabs.firstName = frmPatientRecordTabs.txtFirstName.Text;
                patient.Dob = frmPatientRecordTabs.dob = (DateTime)frmPatientRecordTabs.dtpDOB.Value;
                patient.Address = frmPatientRecordTabs.streetAddress = frmPatientRecordTabs.txtAddress.Text;
                patient.City = frmPatientRecordTabs.city = frmPatientRecordTabs.txtCity.Text;
                patient.State = frmPatientRecordTabs.state = frmPatientRecordTabs.cbState.Text;
                patient.Zip = frmPatientRecordTabs.zip = frmPatientRecordTabs.txtZipcode.Text;
                patient.Phone = frmPatientRecordTabs.phone = frmPatientRecordTabs.txtPhone.Text;
                patient.Gender = frmPatientRecordTabs.gender = frmPatientRecordTabs.cbGender.Text;
                frmPatientRecordTabs.ssn = frmPatientRecordTabs.txtSSN.Text;

                if (ValidateFields.patientFields(frmPatientRecordTabs))
                {
                    bool isUpdate = false;


                    isUpdate = eClinicalsController.UpdatePatient(patient.ContactID, patient.LastName,
                       patient.FirstName, patient.Dob, patient.Address, patient.City, patient.State,
                   patient.Zip, patient.Phone, patient.Gender);

                    //refresh later        
                    mainForm.patientInfoRibbonController.AddUserInfoTopInfo(patient.FirstName, patient.LastName);
                    string age = (patient.Dob.Year - DateTime.Now.Year).ToString();
                    mainForm.patientInfoRibbonController.AddUserInfo(age, patient.Gender, patient.PatientID.ToString());
                    mainForm.patientInfoRibbonController.AddAppointmentInfo(reason.AppointmentReason, "Headache \n Cough");


                    if (isUpdate)
                    {
                        DisableEdit();
                    }
                }
            }
            catch (Exception ex)
            {
                this.mainForm.Status(ex.Message, Color.Red);
            }
            mainForm.patientInfoRibbonController.AddContactInfoFull(patient.Phone, patient.Address, patient.City, patient.State, patient.Zip);
            mainForm.patientInfoRibbonController.AddUserInfo(mainForm.patientInfoRibbonController.getAge(patient.Dob).ToString(), patient.Gender, patient.PatientID.ToString());

            mainForm.patientInfoRibbonController.AddUserInfoTopInfo(patient.FirstName, patient.LastName);


        }
        private void btnOrderTest_Click(object sender, EventArgs e)
        {


            TestOrder testOrder = (TestOrder)frmPatientRecordTabs.cbSelectTest_OrderTest.SelectedItem;
            if (testOrder.TestID < 1)
            {
                this.mainForm.Status("TestID is 0: ", Color.Red);
                return;
            }

            if (frmPatientRecordTabs.cbSelectTest_OrderTest.SelectedIndex > -1 & frmPatientRecordTabs.cbSelectDoctor_OrderTest.SelectedIndex > -1)
            {

                //testID is used to get test by id
                testID = eClinicalsController.OrderTest(testOrder, selectedVisit.VisitID);

                frmPatientRecordTabs.tabPatientRecord.SelectedTab = frmPatientRecordTabs.tabTestsResults;
                this.mainForm.Status(testOrder.TestCode + " Ordered: ", Color.Yellow);

            }
            else
            {
                this.mainForm.Status("Please fill out all form elements : ", Color.Red);
            }
        }
        private void btnOk_SetAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                Doctor doc = (Doctor)frmPatientRecordTabs.cbDoctor_SetAppointment.SelectedItem;
                reason = (Appointment)frmPatientRecordTabs.cbReason_SetAppointment.SelectedItem;
                DateTime dateOnly = frmPatientRecordTabs.dtpAppointmentDate_SetAppointment.Value;
                DateTime timeOnly = frmPatientRecordTabs.dtpAppointmentTime_SetAppointment.Value;
                DateTime dateAndTime = dateOnly.Date.Add(timeOnly.TimeOfDay);
                selectedPatientAppointments = eClinicalsController.GetAllAppointmentsByPatientID(patient.PatientID);

                //CHECK CUrrent DateTime for patient making same appointment time and day

                foreach (Appointment app in selectedPatientAppointments)
                {
                    if (DateTime.Compare(dateAndTime.Date, app.AppointmentDate.Date) == 0 & TimeSpan.Compare(dateAndTime.TimeOfDay, app.AppointmentDate.TimeOfDay) == 0 & doc.DoctorID == app.DoctorID)
                    {
                        mainForm.Status("Patient is already scheduled for that time.", Color.Red);
                        return;
                    }
                }

                if (eClinicalsController.CreateAppointment(dateAndTime, patient.PatientID, doc.DoctorID, reason.AppointmentReasonID))
                {
                    this.mainForm.Status("Appointment Set on : " + dateAndTime + "  With Doctor " + doc.DoctorName, Color.Yellow);
                    selectedPatientAppointments = eClinicalsController.GetAllAppointmentsByPatientID(patient.PatientID);
                    frmPatientRecordTabs.dgViewAppointments_ViewAppointments.DataSource = selectedPatientAppointments;
                }
                else
                {
                    this.mainForm.Status("Appointment was not Set : Please check the form was properly filled in", Color.Red);
                }
            }
            catch (Exception ex)
            {
                this.mainForm.Status(ex.Message, Color.Red);
            }
        }
        private void btnOk_RoutineCheck_Click(object sender, EventArgs e)
        {

            Button button = sender as Button;
            if (button.Name == "btnRight")
            {
                string message = "Must Complete Diagnosis...";
                //If Alert is False all others are off
                frmPatientRecordTabs.tabPatientRecord.TabPages.Remove(frmPatientRecordTabs.tabRoutineCheck);
                frmPatientRecordTabs.tabPatientRecord.TabPages.Remove(frmPatientRecordTabs.tabDiagnosis);

                frmPatientRecordTabs.tabPatientRecord.TabPages.Add(frmPatientRecordTabs.tabDiagnosis);
                frmPatientRecordTabs.tabPatientRecord.SelectedTab = frmPatientRecordTabs.tabDiagnosis;

                AllAlertsOnExceptOne(TAB.DIAGNOSIS, message);
                isRoutineCheckOpen = false;
                mainForm.Status("You must complete the Diagnosis before any other action can be performed.", Color.Yellow);
                return;
            }


            try
            {
                //routione checkup        
                // CheckBox symptoms
                // frmPatientTabs.clbSymptoms_RoutineCheck.ItemCheck
                string systolicS = frmPatientRecordTabs.txtSystolic.Text;
                string diastolicS = frmPatientRecordTabs.txtDiastolic.Text;
                string bodyTempS = frmPatientRecordTabs.txtBodyTemp.Text;
                string pulseS = frmPatientRecordTabs.txtPulse.Text;
                int symptom = frmPatientRecordTabs.cbSymptoms_RoutineCheck.SelectedIndex;

                if (currentNurse == null)
                {
                    this.mainForm.Status("Nurse Object is not set. . . ", Color.Red);
                }

                if (selectedAppointment != null & systolicS != "" & diastolicS != "" & bodyTempS != "" & pulseS != "")
                {

                    List<int> symptomList = new List<int>();
                    symptomList.Add(symptom);

                    int systolic = Int32.Parse(systolicS);
                    int diastolic = Int32.Parse(diastolicS);
                    decimal bodyTemp = Decimal.Parse(bodyTempS);
                    int pulse = Int32.Parse(pulseS);
                    DateTime visitTime = frmPatientRecordTabs.dtpDatePerformed_RoutineCheck.Value;


                    selectedVisit = eClinicalsController.CreateCheckup(selectedAppointment.AppointmentID, currentNurse.NurseID, systolic, diastolic, bodyTemp, pulse, symptomList);

                    if (selectedVisit.VisitID > 0)
                    {
                        string message = "Must Complete Diagnosis...";
                        //If Alert is False all others are off
                        frmPatientRecordTabs.tabPatientRecord.TabPages.Remove(frmPatientRecordTabs.tabRoutineCheck);
                        frmPatientRecordTabs.tabPatientRecord.TabPages.Add(frmPatientRecordTabs.tabDiagnosis);
                        frmPatientRecordTabs.tabPatientRecord.SelectedTab = frmPatientRecordTabs.tabDiagnosis;

                        AllAlertsOnExceptOne(TAB.DIAGNOSIS, message);
                        isRoutineCheckOpen = false;
                        mainForm.Status("You must complete the Diagnosis before any other action can be performed.", Color.Yellow);
                        routineCheckCompleted = true;
                    }
                    else
                    {
                        this.mainForm.Status("error 1 : Setting diagnosis. Please fill out all form elements : ", Color.Red);
                    }
                }
                else
                {
                    this.mainForm.Status("error 2: Please fill out all form empty elements : ", Color.Red);
                }
            }
            catch (Exception ex)
            {

                Status(ex.Message, Color.Red);
            }
        }
        private void btnCancelDiagnosis_Click(object sender, EventArgs e)
        {

            frmPatientRecordTabs.tabPatientRecord.TabPages.Remove(frmPatientRecordTabs.tabDiagnosis);
            frmPatientRecordTabs.tabPatientRecord.SelectedTab = frmPatientRecordTabs.tabViewAppointments;
            string message = "";
            // EnableTab(frmPatientRecordTabs.tabRoutineCheck, false);
            EnableTabAlert(frmPatientRecordTabs.tabViewAppointments, true, message);
            EnableTabAlert(frmPatientRecordTabs.tabOrderTests, true, message);
            EnableTabAlert(frmPatientRecordTabs.tabTestsResults, true, message);
            EnableTabAlert(frmPatientRecordTabs.tabSetAppointments, true, message);
            EnableTabAlert(frmPatientRecordTabs.tabPersonal, true, message);
            enableDisableEditAppointment("off");



        }
        private void btnSelectAppointment_Click(object sender, EventArgs e)
        {//btnBegin Routine Check
         // "shows" tab page 2 : start routine check
            string message = "Must complete the routine check.";


            if (!isRoutineCheckOpen)
            {
                if (selectedAppointment != null)
                {

                    frmPatientRecordTabs.tabPatientRecord.TabPages.Add(frmPatientRecordTabs.tabRoutineCheck);
                    frmPatientRecordTabs.tabPatientRecord.SelectedTab = frmPatientRecordTabs.tabRoutineCheck;
                    AllAlertsOnExceptOne(TAB.ROUTINE_CHECK, message);
                    mainForm.Status("You must complete the routine check before any other action can be performed.", Color.Yellow);

                }
                else
                {
                    this.mainForm.Status("No Appointment has been selected ", Color.Yellow);

                }
            }
            isRoutineCheckOpen = true;


            if (routineCheckCompleted)
            {
                message = "You already completed a check. Continue? \n Or would you like to begin a diagnosis.";
                AllAlertsOFFExceptOne(TAB.ROUTINE_CHECK, message);

                Button btnContinue = frmPatientRecordTabs.ucAlertRoutineCheck.btnLeft;
                Button btnDiagnosis = frmPatientRecordTabs.ucAlertRoutineCheck.btnRight;

                btnContinue.Text = "Continue";
                btnContinue.Visible = true;
                btnContinue.Click += new EventHandler(btnAlert_Click);

                btnDiagnosis.Text = "Go to Diagnosis";
                btnDiagnosis.Visible = true;
                btnDiagnosis.Click += new EventHandler(btnOk_RoutineCheck_Click);

                frmPatientRecordTabs.ucAlertRoutineCheck.Enabled = true;

            }

        }
        private void btnAlert_Click(object sender, EventArgs e)
        {
            frmPatientRecordTabs.ucAlertRoutineCheck.btnLeft.Visible = false;
            frmPatientRecordTabs.ucAlertRoutineCheck.Enabled = false;
            string message = "Must complete the routine check.";
            AllAlertsOnExceptOne(TAB.ROUTINE_CHECK, message);

        }
        private void AllAlertsOnExceptOne(TAB tab, string message)
        {
            bool visibleOn = false;
            bool visibleOff = true;
            EnableTabAlert(frmPatientRecordTabs.tabRoutineCheck, visibleOn, message);
            EnableTabAlert(frmPatientRecordTabs.tabViewAppointments, visibleOn, message);
            EnableTabAlert(frmPatientRecordTabs.tabOrderTests, visibleOn, message);
            EnableTabAlert(frmPatientRecordTabs.tabTestsResults, visibleOn, message);
            EnableTabAlert(frmPatientRecordTabs.tabSetAppointments, visibleOn, message);
            EnableTabAlert(frmPatientRecordTabs.tabPersonal, visibleOn, message);
            EnableTabAlert(frmPatientRecordTabs.tabDiagnosis, visibleOn, message);
            switch (tab)
            {
                case TAB.PERSONAL:
                    EnableTabAlert(frmPatientRecordTabs.tabPersonal, visibleOff, message);
                    break;
                case TAB.SET_APPONTMENT:
                    EnableTabAlert(frmPatientRecordTabs.tabSetAppointments, visibleOff, message);
                    break;
                case TAB.VIEW_APPOINTMENT:
                    EnableTabAlert(frmPatientRecordTabs.tabViewAppointments, visibleOff, message);
                    break;
                case TAB.ROUTINE_CHECK:
                    EnableTabAlert(frmPatientRecordTabs.tabRoutineCheck, visibleOff, message);
                    break;
                case TAB.ORDER_TEST:
                    EnableTabAlert(frmPatientRecordTabs.tabOrderTests, visibleOff, message);
                    break;
                case TAB.TEST_RESULTS:
                    EnableTabAlert(frmPatientRecordTabs.tabTestsResults, visibleOff, message);
                    break;
                case TAB.DIAGNOSIS:
                    EnableTabAlert(frmPatientRecordTabs.tabDiagnosis, visibleOff, message);
                    break;
                default:
                    break;
            }

        }
        private void AllAlertsOFFExceptOne(TAB tab, string message)
        {

            bool visibleOn = false;
            bool visibleOff = true;

            EnableTabAlert(frmPatientRecordTabs.tabRoutineCheck, visibleOff, message);
            EnableTabAlert(frmPatientRecordTabs.tabViewAppointments, visibleOff, message);
            EnableTabAlert(frmPatientRecordTabs.tabOrderTests, visibleOff, message);
            EnableTabAlert(frmPatientRecordTabs.tabTestsResults, visibleOff, message);
            EnableTabAlert(frmPatientRecordTabs.tabSetAppointments, visibleOff, message);
            EnableTabAlert(frmPatientRecordTabs.tabPersonal, visibleOff, message);
            EnableTabAlert(frmPatientRecordTabs.tabDiagnosis, visibleOff, message);
            switch (tab)
            {
                case TAB.PERSONAL:
                    EnableTabAlert(frmPatientRecordTabs.tabPersonal, visibleOn, message);
                    break;
                case TAB.SET_APPONTMENT:
                    EnableTabAlert(frmPatientRecordTabs.tabSetAppointments, visibleOn, message);
                    break;
                case TAB.VIEW_APPOINTMENT:
                    EnableTabAlert(frmPatientRecordTabs.tabViewAppointments, visibleOn, message);
                    break;
                case TAB.ROUTINE_CHECK:
                    EnableTabAlert(frmPatientRecordTabs.tabRoutineCheck, visibleOn, message);
                    break;
                case TAB.ORDER_TEST:
                    EnableTabAlert(frmPatientRecordTabs.tabOrderTests, visibleOn, message);
                    break;
                case TAB.TEST_RESULTS:
                    EnableTabAlert(frmPatientRecordTabs.tabTestsResults, visibleOn, message);
                    break;
                case TAB.DIAGNOSIS:
                    EnableTabAlert(frmPatientRecordTabs.tabDiagnosis, visibleOn, message);
                    break;
                default:
                    break;
            }

        }
        private void btnCommitTest_Click(object sender, EventArgs e)
        {
            try
            {

                //TODO: Add Init and Final diagnosis
                Console.WriteLine("InitialDiagnosis : " + selectedVisit.InitialDiagnosis);
                // Console.WriteLine("Init test : " + frmPatientRecordTabs.rbInitialDiagnosis.Checked);
                // Console.WriteLine("Final  test: " + frmPatientRecordTabs.rbFinalDiagnosis.Checked);

                selectedDiagnosis = (Diagnosis)frmPatientRecordTabs.cbDiagnosis_TestResults.SelectedItem;
                selectedDiagnosisID = selectedDiagnosis.DiagnosisID;

                selectedVisitID = selectedVisit.VisitID;
                if (selectedVisit.InitialDiagnosis == "False" || selectedVisit.InitialDiagnosis == null)
                {
                    if (eClinicalsController.addInitialDiagnosis(selectedVisitID, selectedDiagnosisID, (int)SELECTED_INITIAL_DIAGNOSIS.TRUE))
                    {
                        initDiagnosis = true;
                        selectedVisit.InitialDiagnosis = "True";
                        frmPatientRecordTabs.rbFinalDiagnosis.Enabled = true;
                        frmPatientRecordTabs.rbInitialDiagnosis.Enabled = false;
                        mainForm.Status("Initial Diagnosis Added . . .", Color.Green);
                        // order test 
                        frmPatientRecordTabs.tabPatientRecord.TabPages.Add(frmPatientRecordTabs.tabOrderTests);
                        frmPatientRecordTabs.tabPatientRecord.SelectedTab = frmPatientRecordTabs.tabOrderTests;

                    }
                    else
                    {
                        Console.WriteLine("No Init Diagnosis Completed");

                    }


                }
                else if (selectedVisit.FinalDiagnosis == "False" || selectedVisit.FinalDiagnosis == null)
                {


                    if (eClinicalsController.addFinalDiagnosis(selectedVisitID, selectedDiagnosisID, (int)SELECTED_INITIAL_DIAGNOSIS.TRUE))
                    {
                        initDiagnosis = true;
                        finalDiagnosis = true;
                        selectedVisit.InitialDiagnosis = "True";
                        selectedVisit.FinalDiagnosis = "True";
                        frmPatientRecordTabs.rbFinalDiagnosis.Enabled = false;
                        frmPatientRecordTabs.rbInitialDiagnosis.Enabled = false;
                        mainForm.Status("Final Diagnosis Added . . .", Color.Green);
                        // order test 
                        frmPatientRecordTabs.tabPatientRecord.TabPages.Add(frmPatientRecordTabs.tabOrderTests);
                        frmPatientRecordTabs.tabPatientRecord.SelectedTab = frmPatientRecordTabs.tabOrderTests;

                    }
                    else
                    {
                        Console.WriteLine("No Final Diagnosis Completed");

                    }




                }


                // order test 
                // frmPatientRecordTabs.tabPatientRecord.TabPages.Add(frmPatientRecordTabs.tabOrderTests);
                //  frmPatientRecordTabs.tabPatientRecord.SelectedTab = frmPatientRecordTabs.tabOrderTests;

            }
            catch (Exception ex)
            {

                mainForm.Status(ex.Message, Color.Red);
            }

        }
        private void btnUpdateTestResults_Click(object sender, EventArgs e)
        {

            try
            {

                selectedTestResultResult = GetResultsAsInt(frmPatientRecordTabs.rbNegative.Checked, frmPatientRecordTabs.rbPositive.Checked);

                selectedTestResultPerformedDate = frmPatientRecordTabs.dtPerformedDate.Value;

                int rID = Int32.Parse(selectedTestResultId);
                if (eClinicalsController.UpdateResult(rID, selectedTestResultPerformedDate, selectedTestResultResult))
                {

                    mainForm.Status("Result Updated", Color.Green);
                }
                else
                {
                    mainForm.Status("Result was not Updated", Color.Red);

                }

            }
            catch (Exception ex)
            {

                mainForm.Status("You must select a record." + ex.Message, Color.Red);
            }
            frmPatientRecordTabs.dgTestResults_TestResults.DataSource = eClinicalsController.GetTestResults(mainForm.selectedPatientID);

        }
        private int GetResultsAsInt(bool negative, bool positive)
        {

            if (negative)
            {
                return 0;

            }
            if (positive)
            {

                return 1;
            }
            return -1;
        }
        //Setup
        private string CheckResults(string result)


        {
            if (result == "positive")
            {
                frmPatientRecordTabs.rbPositive.Checked = true;
                selectedTestResultResult = 1;
                return "positive";

            }
            if (result == "negative")
            {
                frmPatientRecordTabs.rbNegative.Checked = true;
                selectedTestResultResult = 0;
                return "negative";
            }
            return "";
        }
        private void showSummaryButton(bool status)
        {
            frmPatientRecordTabs.btnSummary.Visible = status;
            frmPatientRecordTabs.lblSummary.Visible = status;
        }
        public void DisableEdit()
        {
            frmPatientRecordTabs.txtLastName.Text = this.patient.LastName;
            frmPatientRecordTabs.txtFirstName.Text = this.patient.FirstName;
            frmPatientRecordTabs.dtpDOB.Value = this.patient.Dob;
            frmPatientRecordTabs.txtAddress.Text = this.patient.Address;
            frmPatientRecordTabs.txtCity.Text = this.patient.City;
            frmPatientRecordTabs.cbState.Text = this.patient.State;
            frmPatientRecordTabs.txtZipcode.Text = this.patient.Zip;
            frmPatientRecordTabs.txtPhone.Text = this.patient.Phone;
            frmPatientRecordTabs.cbGender.Text = this.patient.Gender;
            frmPatientRecordTabs.txtSSN.Text = this.patient.Ssn;

            frmPatientRecordTabs.btnUpdate.Enabled = false;
            frmPatientRecordTabs.btnCancel.Enabled = false;
            frmPatientRecordTabs.btnEditPerson.Enabled = true;
            frmPatientRecordTabs.btnUpdate.Visible = false;
            frmPatientRecordTabs.btnCancel.Visible = false;
            frmPatientRecordTabs.btnEditPerson.Visible = true;

            frmPatientRecordTabs.txtLastName.Enabled = false;
            frmPatientRecordTabs.txtFirstName.Enabled = false;
            frmPatientRecordTabs.dtpDOB.Enabled = false;
            frmPatientRecordTabs.txtAddress.Enabled = false;
            frmPatientRecordTabs.txtCity.Enabled = false;
            frmPatientRecordTabs.cbState.Enabled = false;
            frmPatientRecordTabs.txtZipcode.Enabled = false;
            frmPatientRecordTabs.txtPhone.Enabled = false;
            frmPatientRecordTabs.cbGender.Enabled = false;
            frmPatientRecordTabs.txtSSN.Enabled = false;

        }

        public void EnableEdit()
        {
            frmPatientRecordTabs.btnUpdate.Enabled = true;
            frmPatientRecordTabs.btnCancel.Enabled = true;
            frmPatientRecordTabs.btnUpdate.Visible = true;
            frmPatientRecordTabs.btnCancel.Visible = true;
            frmPatientRecordTabs.btnEditPerson.Enabled = false;
            frmPatientRecordTabs.btnEditPerson.Visible = false;
            frmPatientRecordTabs.txtLastName.Enabled = true;
            frmPatientRecordTabs.txtFirstName.Enabled = true;
            frmPatientRecordTabs.dtpDOB.Enabled = true;
            frmPatientRecordTabs.txtAddress.Enabled = true;
            frmPatientRecordTabs.txtCity.Enabled = true;
            frmPatientRecordTabs.cbState.Enabled = true;
            frmPatientRecordTabs.txtZipcode.Enabled = true;
            frmPatientRecordTabs.txtPhone.Enabled = true;
            frmPatientRecordTabs.cbGender.Enabled = true;
            frmPatientRecordTabs.txtSSN.Enabled = false;
        }

        public void EnableTabAlert(TabPage page, bool enable, string newMessage)
        {
            string message = newMessage;
            foreach (Control ctl in page.Controls)
            {

                ctl.Enabled = enable;
                if (enable)
                {
                    message = "";
                    switch (page.Name)
                    {
                        case "tabViewAppointments":
                            frmPatientRecordTabs.ucAlertViewApp.Visible = false;
                            frmPatientRecordTabs.ucAlertViewApp.lblAlert.Text = message;
                            break;
                        case "tabOrderTests":
                            frmPatientRecordTabs.ucAlertOrderTest.Visible = false;
                            frmPatientRecordTabs.ucAlertOrderTest.lblAlert.Text = message;
                            break;
                        case "tabSetAppointments":
                            frmPatientRecordTabs.ucAlertSetApp.Visible = false;
                            frmPatientRecordTabs.ucAlertSetApp.lblAlert.Text = message;
                            break;
                        case "tabPersonal":
                            frmPatientRecordTabs.ucAlertPersonal.Visible = false;
                            frmPatientRecordTabs.ucAlertPersonal.lblAlert.Text = message;
                            break;
                        case "tabTestsResults":
                            frmPatientRecordTabs.ucAlertTestResults.Visible = false;
                            frmPatientRecordTabs.ucAlertTestResults.lblAlert.Text = message;
                            break;
                        case "tabRoutineCheck":
                            frmPatientRecordTabs.ucAlertRoutineCheck.Visible = false;
                            frmPatientRecordTabs.ucAlertRoutineCheck.lblAlert.Text = message;
                            break;
                        default:
                            break;
                    }
                }
                else
                {

                    switch (page.Name)
                    {
                        case "tabViewAppointments":
                            frmPatientRecordTabs.ucAlertViewApp.Visible = true;
                            frmPatientRecordTabs.ucAlertViewApp.lblAlert.Text = message;
                            break;
                        case "tabOrderTests":
                            frmPatientRecordTabs.ucAlertOrderTest.Visible = true;
                            frmPatientRecordTabs.ucAlertOrderTest.lblAlert.Text = message;
                            break;
                        case "tabSetAppointments":
                            frmPatientRecordTabs.ucAlertSetApp.Visible = true;
                            frmPatientRecordTabs.ucAlertSetApp.lblAlert.Text = message;
                            break;
                        case "tabPersonal":
                            frmPatientRecordTabs.ucAlertPersonal.Visible = true;
                            frmPatientRecordTabs.ucAlertPersonal.lblAlert.Text = message;
                            break;
                        case "tabTestsResults":
                            frmPatientRecordTabs.ucAlertTestResults.Visible = true;
                            frmPatientRecordTabs.ucAlertTestResults.lblAlert.Text = message;
                            break;
                        case "tabRoutineCheck":
                            frmPatientRecordTabs.ucAlertRoutineCheck.Visible = true;
                            frmPatientRecordTabs.ucAlertRoutineCheck.lblAlert.Text = message;
                            break;
                        default:
                            break;
                    }

                }
            }

        }

        private void setEventHandlers()
        {
            frmPatientRecordTabs.btnEditPerson.Click += new EventHandler(btnEditPerson_Click);
            frmPatientRecordTabs.btnCancel.Click += new EventHandler(btnCancel_Click);
            frmPatientRecordTabs.btnUpdate.Click += new EventHandler(btnUpdate_Click);
            frmPatientRecordTabs.btnOk_SetAppointment.Click += new EventHandler(btnOk_SetAppointment_Click);
            frmPatientRecordTabs.btnAppEditCancel.Click += new System.EventHandler(this.btnAppEditCancel_Click);
            frmPatientRecordTabs.dgViewAppointments_ViewAppointments.CellClick +=
                         new DataGridViewCellEventHandler(dgViewAppointments_ViewAppointments_CellClick);

            frmPatientRecordTabs.dgTestResults_TestResults.CellClick +=
                         new DataGridViewCellEventHandler(dgTestResults_TestResults_CellClick);
            frmPatientRecordTabs.btnCancelDiagnosis.Click += new System.EventHandler(this.btnCancelDiagnosis_Click);
            frmPatientRecordTabs.btnUpdateTestResults.Click += new EventHandler(btnUpdateTestResults_Click);
            frmPatientRecordTabs.btnSelectAppointment.Click += new EventHandler(btnSelectAppointment_Click);
            frmPatientRecordTabs.btnOk_RoutineCheck.Click += new EventHandler(btnOk_RoutineCheck_Click);
            frmPatientRecordTabs.btnOrderTest.Click += new EventHandler(btnOrderTest_Click);
            frmPatientRecordTabs.btnEditAppointment.Click += new EventHandler(this.btnEditAppointment_Click);
            frmPatientRecordTabs.btnCommitEdit.Click += new System.EventHandler(this.btnCommitEdit_Click);
            frmPatientRecordTabs.btnCancel_RoutineCheck.Click += new EventHandler(btnCancel_RoutineCheck_Click);
            frmPatientRecordTabs.btnShowAllAppointments.Click += new System.EventHandler(this.btnShowAllAppointments_Click);
            frmPatientRecordTabs.btnShowFutureAppointments.Click += new System.EventHandler(this.btnShowFutureAppointments_Click);
            frmPatientRecordTabs.btnShowCurrentAppointments.Click += new System.EventHandler(this.btnShowCurrentAppointments_Click);
            frmPatientRecordTabs.btnShowPastAppointments.Click += new System.EventHandler(this.btnShowPastAppointments_Click);
            frmPatientRecordTabs.btnCommitTest.Click += new System.EventHandler(this.btnCommitTest_Click);
            frmPatientRecordTabs.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);

        }


    }

}

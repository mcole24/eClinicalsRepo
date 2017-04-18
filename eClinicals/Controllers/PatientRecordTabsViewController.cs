using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eClinicals.View;
using eClinicals.Model;
using System.Drawing;
using System.Windows.Forms;
using eClinicals.Controllers;

namespace eClinicals.Controllers
{
    enum CURRENT_APP_VIEW { ALL = 0, FUTURE = 1, PAST = 3, CURRENT = 4};
   

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

        public Boolean isRoutineCheckOpen;
        private Boolean initDiagnosis;
        private Boolean finalDiagnosis;
        private Boolean isOrderTestOpen;

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

        }
        public void fillPatientInfo(Patient patient) {
            // *** pateint comes from frmMain ***
            if (patient != null)
            {
                this.patient = patient;
               
            }
            else {
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

        private void btnSummary_Click(object sender, EventArgs e)
        {
            try
            {
           
               mainForm.ucAppointmentSummary.dgDiagnosisResults.DataSource = eClinicalsController.GetAppointmentSummaryDiagnosisResults(selectedAppointment.AppointmentID);
               mainForm.ucAppointmentSummary.dgTestResults.DataSource = eClinicalsController.GetAppointmentSummaryTestResults(selectedAppointment.AppointmentID);
               mainForm.ucAppointmentSummary.dgVisitDetails.DataSource = eClinicalsController.GetAppointmentSummaryVisitDetails(selectedAppointment.AppointmentID);
               mainForm.ucAppointmentSummary.dgSymptoms.DataSource = eClinicalsController.GetAppointmentSummarySymptoms(selectedAppointment.AppointmentID);
               mainForm.ucAppointmentSummary.dgCheckupResults.DataSource = eClinicalsController.GetAppointmentSummaryCheckupResults(selectedAppointment.AppointmentID);

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
                foreach (Appointment app in selectedPatientAppointments)
                {
                    if (reason.AppointmentDate == app.AppointmentDate) {
                        mainForm.Status("Patient is already scheduled for that time.", Color.Red);
                        return;
                    }
                }


                if (eClinicalsController.UpdateAppointment(dateAndTime,doc.DoctorID, reason.AppointmentReasonID, selectedAppointment.AppointmentID)) {

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
            }
            catch (Exception ex)
            {
                base.mainForm.Status(ex.Message, Color.Red);
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
          
            // EnableTab(frmPatientRecordTabs.tabRoutineCheck, false);
            EnableTabAlert(frmPatientRecordTabs.tabViewAppointments, true);
            EnableTabAlert(frmPatientRecordTabs.tabOrderTests, true);
            EnableTabAlert(frmPatientRecordTabs.tabTestsResults, true);
            EnableTabAlert(frmPatientRecordTabs.tabSetAppointments, true);
            EnableTabAlert(frmPatientRecordTabs.tabPersonal, true);
            enableDisableEditAppointment("off");

        }
        private void btnCancel_OrderTest_Click(object sender, EventArgs e)
        {
            isOrderTestOpen = false;

            frmPatientRecordTabs.tabPatientRecord.TabPages.Remove(frmPatientRecordTabs.tabOrderTests);
            frmPatientRecordTabs.tabPatientRecord.SelectedTab = frmPatientRecordTabs.tabTestsResults;

            // EnableTab(frmPatientRecordTabs.tabRoutineCheck, false);
            EnableTabAlert(frmPatientRecordTabs.tabViewAppointments, true);
            EnableTabAlert(frmPatientRecordTabs.tabOrderTests, true);
            EnableTabAlert(frmPatientRecordTabs.tabTestsResults, true);
            EnableTabAlert(frmPatientRecordTabs.tabSetAppointments, true);
            EnableTabAlert(frmPatientRecordTabs.tabPersonal, true);
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
                patient.LastName =  frmPatientRecordTabs.lastName = frmPatientRecordTabs.txtLastName.Text;
                patient.FirstName = frmPatientRecordTabs.firstName = frmPatientRecordTabs.txtFirstName.Text;
                patient.Dob = frmPatientRecordTabs.dob = (DateTime)frmPatientRecordTabs.dtpDOB.Value;
                patient.Address = frmPatientRecordTabs.streetAddress = frmPatientRecordTabs.txtAddress.Text;
                patient.City =  frmPatientRecordTabs.city = frmPatientRecordTabs.txtCity.Text;
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

                    isUpdate = eClinicalsController.UpdatePatient(patient.ContactID, patient.LastName,
                       patient.FirstName, patient.Dob, patient.Address, patient.City, patient.State,
                patient.Zip, patient.Phone, patient.Gender);


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
        }
        private void btnOrderTest_Click(object sender, EventArgs e)
        {

            if (frmPatientRecordTabs.cbSelectTest_OrderTest.SelectedIndex > -1 & frmPatientRecordTabs.cbSelectDoctor_OrderTest.SelectedIndex > -1)
            {
                frmPatientRecordTabs.tabPatientRecord.SelectedTab = frmPatientRecordTabs.tabTestsResults;
                this.mainForm.Status("Routine CheckUp Added : ", Color.Yellow);

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
                Appointment reason = (Appointment)frmPatientRecordTabs.cbReason_SetAppointment.SelectedItem;
                DateTime dateOnly = frmPatientRecordTabs.dtpAppointmentDate_SetAppointment.Value;
                DateTime timeOnly = frmPatientRecordTabs.dtpAppointmentTime_SetAppointment.Value;
                DateTime dateAndTime = dateOnly.Date.Add(timeOnly.TimeOfDay);
                selectedPatientAppointments = eClinicalsController.GetAllAppointmentsByPatientID(patient.PatientID);

                //CHECK CUrrent DateTime for patient making same appointment time and day

                foreach (Appointment app in selectedPatientAppointments)
                {
                    if (DateTime.Compare(dateAndTime.Date, app.AppointmentDate.Date) == 0 & TimeSpan.Compare(dateAndTime.TimeOfDay, app.AppointmentDate.TimeOfDay) == 0)
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
            try
            {
                //routione checkup        
                // CheckBox symptoms
                // frmPatientTabs.clbSymptoms_RoutineCheck.ItemCheck
                string systolicS = frmPatientRecordTabs.txtSystolic.Text;
                string diastolicS = frmPatientRecordTabs.txtDiastolic.Text;
                string bodyTempS = frmPatientRecordTabs.txtBodyTemp.Text;
                string pulseS = frmPatientRecordTabs.txtPulse.Text;
                string symptom = frmPatientRecordTabs.cbSymptoms_RoutineCheck.Text;

                if (currentNurse == null)
                {
                    this.mainForm.Status("Nurse Object is not set. . . ", Color.Red);
                }

                if (selectedAppointment != null & systolicS != "" & diastolicS != "" & bodyTempS != "" & pulseS != "")
                {

                    int systolic = Int32.Parse(systolicS);
                    int diastolic = Int32.Parse(diastolicS);
                    decimal bodyTemp = Decimal.Parse(bodyTempS);
                    int pulse = Int32.Parse(pulseS);
                    DateTime visitTime = frmPatientRecordTabs.dtpDatePerformed_RoutineCheck.Value;
                    if (eClinicalsController.CreateCheckup(selectedAppointment.AppointmentID, currentNurse.NurseID, systolic, diastolic, bodyTemp, pulse))
                    {

                        frmPatientRecordTabs.tabPatientRecord.TabPages.Remove(frmPatientRecordTabs.tabRoutineCheck);
                        frmPatientRecordTabs.tabPatientRecord.TabPages.Add(frmPatientRecordTabs.tabDiagnosis);
                        frmPatientRecordTabs.tabPatientRecord.TabPages.Add(frmPatientRecordTabs.tabOrderTests);
                        frmPatientRecordTabs.tabPatientRecord.SelectedTab = frmPatientRecordTabs.tabTestsResults;


                        EnableTabAlert(frmPatientRecordTabs.tabRoutineCheck, false);
                        EnableTabAlert(frmPatientRecordTabs.tabViewAppointments, true);
                        EnableTabAlert(frmPatientRecordTabs.tabOrderTests, true);
                        EnableTabAlert(frmPatientRecordTabs.tabTestsResults, true);
                        EnableTabAlert(frmPatientRecordTabs.tabSetAppointments, true);
                        EnableTabAlert(frmPatientRecordTabs.tabPersonal, true);
                        isRoutineCheckOpen = false;
                        this.mainForm.Status("Routine CheckUp Added : ", Color.Yellow);

                     
                    }
                    else
                    {
                        this.mainForm.Status("No Checkup was added. Please fill out all form elements : ", Color.Red);
                    }
                }
                else
                {
                    this.mainForm.Status("Please fill out all form elements : ", Color.Red);
                }
            }
            catch (Exception ex)
            {

                Status(ex.Message + "Object [Nurse] was not retrieved from DAL", Color.Red);
            }
        }
        private void btnSelectAppointment_Click(object sender, EventArgs e)
        {//btnBegin Routine Check
            // "shows" tab page 2 : start routine check
            if (!isRoutineCheckOpen)
            {
                if (selectedAppointment != null)
                {
                    frmPatientRecordTabs.tabPatientRecord.TabPages.Add(frmPatientRecordTabs.tabRoutineCheck);
                    frmPatientRecordTabs.tabPatientRecord.SelectedTab = frmPatientRecordTabs.tabRoutineCheck;
                    EnableTabAlert(frmPatientRecordTabs.tabRoutineCheck, true);
                    EnableTabAlert(frmPatientRecordTabs.tabViewAppointments, false);
                    EnableTabAlert(frmPatientRecordTabs.tabOrderTests, false);
                    EnableTabAlert(frmPatientRecordTabs.tabTestsResults, false);
                    EnableTabAlert(frmPatientRecordTabs.tabSetAppointments, false);
                    EnableTabAlert(frmPatientRecordTabs.tabPersonal, false);
                    mainForm.Status("You must complete the routine check before any other action can be performed.", Color.Yellow);

                }
                else
                {
                    this.mainForm.Status("No Appointment has been selected ", Color.Yellow);

                }
            }
            isRoutineCheckOpen = true;
        }
        private void btnCommitTest_Click(object sender, EventArgs e)
        {

            Console.WriteLine("Test  : " + frmPatientRecordTabs.cbTest_TestResults.Text);
            Console.WriteLine("Diagnosis : " + frmPatientRecordTabs.cbDiagnosis_TestResults.Text);
            Console.WriteLine("Init test : " + frmPatientRecordTabs.rbInitialDiagnosis.Checked);
            Console.WriteLine("Final  test: " + frmPatientRecordTabs.rbFinalDiagnosis.Checked );
            Console.WriteLine("Time : " + frmPatientRecordTabs.dtpTestTime_TestResults.Value.TimeOfDay);
            Console.WriteLine("Date : " + frmPatientRecordTabs.dtpTestDate_TestResults.Value.ToShortDateString());


            // if  eClinicalsController.addInitialDiagnosis() then

        
            if (initDiagnosis) {
                frmPatientRecordTabs.rbFinalDiagnosis.Enabled = true;

            }


            // order test 
            // frmPatientRecordTabs.tabPatientRecord.TabPages.Add(frmPatientRecordTabs.tabOrderTests);
            //  frmPatientRecordTabs.tabPatientRecord.SelectedTab = frmPatientRecordTabs.tabOrderTests;

          
            // order test 
           // frmPatientRecordTabs.tabPatientRecord.TabPages.Add(frmPatientRecordTabs.tabOrderTests);
          //  frmPatientRecordTabs.tabPatientRecord.SelectedTab = frmPatientRecordTabs.tabOrderTests;


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
            frmPatientRecordTabs.txtSSN.Enabled = true;
        }
        public void EnableTabAlert(TabPage page, bool enable)
        {
            string message = "";
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
                        default:
                            break;
                    }
                }
                else
                {
                    message = "Must complete routine check.";
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

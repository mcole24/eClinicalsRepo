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
    enum CURRENT_APP_VIEW { ALL = 0, FUTURE = 1, PAST = 3};

    class PatientRecordTabsViewController : ControllerBase
    {
        public frmPatientRecordTabs frmPatientRecordTabs;
        eClinicalsController eClinicalsController;
        private Patient patient;     
        private Appointment selectedAppointment;
        private List<Appointment> selectedPatientAppointments;
        internal Nurse currentNurse;
        public Boolean routineCheckOpen;
        internal frmMain mainForm;
        private List<Appointment> selectedFuturePatientAppointments;
        CURRENT_APP_VIEW CURRENT_APP_VIEW;
        private List<Appointment> selectedPastPatientAppointments;

        public PatientRecordTabsViewController(frmMain mainForm, frmBaseView thisView) : base(mainForm, thisView)
        {
             eClinicalsController = new eClinicalsController();

            frmPatientRecordTabs = (frmPatientRecordTabs)base.thisView;
             this.mainForm = (frmMain)base.mainForm;           
            mainForm.lblStatus.Text = "Patient Record Tabs active . . .";
            setEventHandlers();
            currentNurse = this.mainForm.currentNurse;
            routineCheckOpen = false;
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
            frmPatientRecordTabs.clbSymptoms_RoutineCheck.DataSource = allSymptoms;
            frmPatientRecordTabs.cbSelectDoctor_OrderTest.DataSource = eClinicalsController.GetAllDoctorNames();
            frmPatientRecordTabs.cbSelectTest_OrderTest.DataSource = eClinicalsController.GetAllTests();

            // ?? Hide panel
            frmPatientRecordTabs.tabPatientRecord.TabPages.Remove(frmPatientRecordTabs.tabRoutineCheck);

            //returns a routine check
            frmPatientRecordTabs.dgPreviousReadings__RoutineCheck.DataSource =
                eClinicalsController.GetPreviousReadings(patient.PatientID);
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
                frmPatientRecordTabs.lastName = frmPatientRecordTabs.txtLastName.Text;
                frmPatientRecordTabs.firstName = frmPatientRecordTabs.txtFirstName.Text;
                frmPatientRecordTabs.dob = (DateTime)frmPatientRecordTabs.dtpDOB.Value;
                frmPatientRecordTabs.streetAddress = frmPatientRecordTabs.txtAddress.Text;
                frmPatientRecordTabs.city = frmPatientRecordTabs.txtCity.Text;
                frmPatientRecordTabs.state = frmPatientRecordTabs.cbState.Text;
                frmPatientRecordTabs.zip = frmPatientRecordTabs.txtZipcode.Text;
                frmPatientRecordTabs.phone = frmPatientRecordTabs.txtPhone.Text;
                frmPatientRecordTabs.gender = frmPatientRecordTabs.cbGender.Text;
                frmPatientRecordTabs.ssn = frmPatientRecordTabs.txtSSN.Text;

                if (ValidateFields.patientFields(frmPatientRecordTabs))
                {
                    bool isUpdate = false;

                    isUpdate = eClinicalsController.UpdatePatient(patient.PatientID, patient.LastName,
                       patient.FirstName, patient.Dob, patient.Address, patient.City, patient.State,
                patient.Zip, patient.Phone, patient.Gender, patient.Ssn);

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
                DateTime timeOnly = frmPatientRecordTabs.dtpAppointmentDate_SetAppointment.Value;
                DateTime dateAndTime = dateOnly.Date.Add(timeOnly.TimeOfDay);

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

                if (currentNurse == null) {

                    this.mainForm.Status("Nurse Object is not set. . . ", Color.Red);

                }

            if (selectedAppointment != null & systolicS != "" & diastolicS != "" & bodyTempS != "" & pulseS != "")
            {

                int systolic = Int32.Parse(systolicS);
                int diastolic = Int32.Parse(diastolicS);
                decimal bodyTemp = Decimal.Parse(bodyTempS);
                int pulse = Int32.Parse(pulseS);

                    if (eClinicalsController.CreateCheckup(selectedAppointment.AppointmentID, currentNurse.NurseID, DateTime.Now, systolic, diastolic, bodyTemp, pulse))
                    {

                        this.mainForm.Status("Routine CheckUp Added : ", Color.Yellow);
                        frmPatientRecordTabs.tabPatientRecord.TabPages.Remove(frmPatientRecordTabs.tabRoutineCheck);
                    }
                    else {          
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
        {
            // "shows" tab page 2 : start routine check
            if (!routineCheckOpen)
            {
               
                if (selectedAppointment != null)
                {
                    frmPatientRecordTabs.tabPatientRecord.TabPages.Add(frmPatientRecordTabs.tabRoutineCheck);
                    frmPatientRecordTabs.tabPatientRecord.SelectedTab = frmPatientRecordTabs.tabRoutineCheck;                    
                    EnableTab(frmPatientRecordTabs.tabRoutineCheck, true);
                    EnableTab(frmPatientRecordTabs.tabViewAppointments, false);
                    EnableTab(frmPatientRecordTabs.tabOrderTests, false);
                    EnableTab(frmPatientRecordTabs.tabTestsResults, false);
                    EnableTab(frmPatientRecordTabs.tabSetAppointments, false);
                    EnableTab(frmPatientRecordTabs.tabPersonal, false);
                }
                else
                {
                    this.mainForm.Status("No Appointment has been selected ", Color.Yellow);
                }

            }
            routineCheckOpen = true;
        }
        public void EnableTab(TabPage page, bool enable)
        {
            string message = "";
            foreach (Control ctl in page.Controls) {  

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
                else {
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
                  
                    mainForm.Status("You must complete the routine check before any other action can be performed.",Color.Yellow);
                }             
            }
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
                    frmPatientRecordTabs.gbBeginRoutineCheck.Enabled = true;
                    frmPatientRecordTabs.gbViewAppointments.Enabled = true;
                    frmPatientRecordTabs.gbSelectEditApp.Enabled = true;
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
            selectedFuturePatientAppointments = eClinicalsController.GetAllFutureAppointmentsByPatientID(patient.PatientID);
            frmPatientRecordTabs.dgViewAppointments_ViewAppointments.DataSource = selectedFuturePatientAppointments;
        }
        private void btnShowCurrentAppointments_Click(object sender, EventArgs e)
        {
            CURRENT_APP_VIEW = CURRENT_APP_VIEW.PAST;
            selectedPastPatientAppointments = eClinicalsController.GetAllPastAppointmentsByPatientID(patient.PatientID);
            frmPatientRecordTabs.dgViewAppointments_ViewAppointments.DataSource = selectedPastPatientAppointments;
        }
        private void btnCancel_RoutineCheck_Click(object sender, EventArgs e)
        {
            routineCheckOpen = false;
            enableDisableEditAppointment("off");
            frmPatientRecordTabs.tabPatientRecord.TabPages.Remove(frmPatientRecordTabs.tabRoutineCheck);
            frmPatientRecordTabs.tabPatientRecord.SelectedTab = frmPatientRecordTabs.tabViewAppointments;
           // EnableTab(frmPatientRecordTabs.tabRoutineCheck, false);
            EnableTab(frmPatientRecordTabs.tabViewAppointments, true);
            EnableTab(frmPatientRecordTabs.tabOrderTests, true);
            EnableTab(frmPatientRecordTabs.tabTestsResults, true);
            EnableTab(frmPatientRecordTabs.tabSetAppointments, true);
            EnableTab(frmPatientRecordTabs.tabPersonal, true);
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
        }



    }

}

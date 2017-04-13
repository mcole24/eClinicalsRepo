using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eClinicals.View;
using eClinicals.Model;
using System.Drawing;
using System.Windows.Forms;

namespace eClinicals.Controllers
{
    class PatientRecordTabsViewController : ControllerBase
    {
        public frmPatientRecordTabs frmPatientRecordTabs;
        eClinicalsController eClinicalsController;
        private Patient patient;     
        private Appointment selectedAppointment;
        private List<Appointment> selectedPatientAppointments;
        internal Nurse currentNurse;
        public PatientRecordTabsViewController(frmMain mainForm, frmBaseView thisView) : base(mainForm, thisView)
        {
             eClinicalsController = new eClinicalsController();

            frmPatientRecordTabs = (frmPatientRecordTabs)base.thisView;
            frmMain main = (frmMain)base.mainForm;           
            mainForm.lblStatus.Text = "Patient Record Tabs active . . .";
            setEventHandlers();
            currentNurse = this.mainForm.currentNurse;
            // frmPatientRecordTabs.dgTestResults_TestResults.DataSource = eClinicalsController.GetTestResults(1);

        }
        public void fillPatientInfo(Patient patient) {
            // *** pateint comes from frmMain ***
            this.patient = patient;
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
                else
                {
                }
                this.mainForm.Status("No Checkup was added. Please fill out all form elements : ", Color.Red);

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
            // "shows" tab page 2
            if (selectedAppointment != null)
            {
                frmPatientRecordTabs.tabPatientRecord.TabPages.Add(frmPatientRecordTabs.tabRoutineCheck);
                frmPatientRecordTabs.tabPatientRecord.SelectedTab = frmPatientRecordTabs.tabRoutineCheck;
            }
            else
            {
                this.mainForm.Status("No Appointment has been selected ", Color.Yellow);
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
                    frmPatientRecordTabs.dtpAppDateDate.Value = selectedAppointment.AppointmentDate;
                    frmPatientRecordTabs.txtAppDoctor.Text = selectedAppointment.AppointmentDoctor;
                    frmPatientRecordTabs.txtAppReasonID.Text = selectedAppointment.AppointmentReasonID.ToString();
                    frmPatientRecordTabs.txtAppReason.Text = selectedAppointment.AppointmentReason;

                    //  *********************************************************************************************** WORKING ON 
                    //send selected patient to controller
                    // patientRecordTabsViewController.fillPatientInfo(selectedPatient);
                    //   frmPatientTabs.txtFirstName.Text = selectedPatient.FirstName;

                }
                else
                {
                    this.mainForm.Status("No appointment has been selection.", Color.Yellow);
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
                        frmPatientRecordTabs.gbViewAppointments.BackColor = System.Drawing.Color.DarkCyan;
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

            DateTime dateAndTime = frmPatientRecordTabs.dtpAppDateDate.Value;

               int docID= Int32.Parse(frmPatientRecordTabs.txtAppDoctor.Text);
            int appReasonID = Int32.Parse(frmPatientRecordTabs.txtAppReasonID.Text);

            if (eClinicalsController.UpdateAppointment(dateAndTime,docID, appReasonID,mainForm.currentPatientID)) {

                enableDisableEditAppointment("off");
                mainForm.Status("Appointment has been updated", Color.Yellow);
            }

            }
            catch (Exception ex)
            {

                mainForm.Status(ex.Message, Color.Red);
            }


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

            frmPatientRecordTabs.dgViewAppointments_ViewAppointments.CellClick +=
                         new DataGridViewCellEventHandler(dgViewAppointments_ViewAppointments_CellClick);
            frmPatientRecordTabs.btnSelectAppointment.Click += new EventHandler(btnSelectAppointment_Click);

            frmPatientRecordTabs.btnOk_RoutineCheck.Click += new EventHandler(btnOk_RoutineCheck_Click);
            frmPatientRecordTabs.btnOrderTest.Click += new EventHandler(btnOrderTest_Click);
            frmPatientRecordTabs.btnEditAppointment.Click += new EventHandler(this.btnEditAppointment_Click);
            frmPatientRecordTabs.btnCommitEdit.Click += new System.EventHandler(this.btnCommitEdit_Click);
        }



    }

}

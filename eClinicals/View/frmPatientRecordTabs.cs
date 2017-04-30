using eClinicals.Controllers;
using eClinicals.Model;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace eClinicals.View
{

    public partial class frmPatientRecordTabs : frmBaseView
    {
        List<Doctor> listDocs;
        List<Diagnosis> listDiagnosis;
        List<LabTest> listTestOrder;
        List<Appointment> listReasons;
        List<Symptom> listSymptoms;
        eClinicalsController eClinicalsController;
        // Personal Tab
        public string lastName;
        public string firstName;
        public DateTime dob;
        public string streetAddress;
        public string city;
        public string state;
        public string zip;
        public string phone;
        public string gender;
        public string ssn;
        public string errorMessage;
        // Set Appointment Tab
        public string reason;
        public string doctor;
        public DateTime appointmentDate;
        public DateTime appointmentTime;

        const int ALERT_LOCATION_X = 8;
        private int ALERT_LOCATION_Y = 45;

        public frmPatientRecordTabs()
        {

            InitializeComponent();
            eClinicalsController = new eClinicalsController();
            fillListBoxElements();
            fillSetAppointmentTab();
            gbEditAppointment.Visible = false;
            SetUIElementPosition();


        }
        private void fillListBoxElements()
        {
            listDocs = eClinicalsController.GetAllDoctorNames();

            foreach (Doctor doc in listDocs)
            {
                cbDoctor_SetAppointment.Items.Add(doc);
                cbSelectDoctor_OrderTest.Items.Add(doc);
                cbAppDoctor.Items.Add(doc);
            }
            listReasons = eClinicalsController.GetAllAppointmentReasons();

            foreach (Appointment reason in listReasons)
            {
                cbReason_SetAppointment.Items.Add(reason);
                cbAppReason.Items.Add(reason);
            }

            listSymptoms = eClinicalsController.GetAllSymptoms();
            foreach (Symptom symptom in listSymptoms)
            {
                cbSymptoms_RoutineCheck.Items.Add(symptom);

            }

            listDiagnosis = eClinicalsController.GetAllDiagnosis();

            foreach (Diagnosis diagnosis in listDiagnosis)
            {
                cbDiagnosis_TestResults.Items.Add(diagnosis);

            }
            listTestOrder = eClinicalsController.GetAllTests();

            foreach (LabTest test in listTestOrder)
            {

                cbSelectTest_OrderTest.Items.Add(test);
            }


        }

        private void fillSetAppointmentTab()
        {
            // Selects the member name of the object in the listBox
            cbReason_SetAppointment.DisplayMember = "AppointmentReason";
            cbSymptoms_RoutineCheck.DisplayMember = "SymptomType";
            cbDoctor_SetAppointment.DisplayMember = "DoctorName";
            cbSelectDoctor_OrderTest.DisplayMember = "DoctorName";
            cbSelectTest_OrderTest.DisplayMember = "TestName";

            cbAppReason.DisplayMember = "AppointmentReason";
            cbAppDoctor.DisplayMember = "DoctorName";
            cbDiagnosis_TestResults.DisplayMember = "DiagnosisName";

            // Selects the index of the object in the listBox
            cbReason_SetAppointment.SelectedIndex = 0;
            cbDoctor_SetAppointment.SelectedIndex = 0;
            cbSelectDoctor_OrderTest.SelectedIndex = 0;
            cbSelectTest_OrderTest.SelectedIndex = 0;
            cbDiagnosis_TestResults.SelectedIndex = 0;
            cbAppReason.SelectedIndex = 0;
            cbAppDoctor.SelectedIndex = 0;
            cbSymptoms_RoutineCheck.SelectedIndex = 0;
        }
        private void SetUIElementPosition()
        {
            this.ucAlertPersonal.Location = new Point(ALERT_LOCATION_X, ALERT_LOCATION_Y);
            this.ucAlertSetApp.Location = new Point(ALERT_LOCATION_X, ALERT_LOCATION_Y);
            this.ucAlertViewApp.Location = new Point(ALERT_LOCATION_X, ALERT_LOCATION_Y);
            this.ucAlertRoutineCheck.Location = new Point(ALERT_LOCATION_X, ALERT_LOCATION_Y);
            this.ucAlertOrderTest.Location = new Point(ALERT_LOCATION_X, ALERT_LOCATION_Y);
            this.ucAlertTestResults.Location = new Point(ALERT_LOCATION_X, ALERT_LOCATION_Y);


        }

        private void btnUpdateTestResults_Click(object sender, EventArgs e)
        {

        }

        private void btnDoneTestResultUpdate_Click(object sender, EventArgs e)
        {
            gUpdateSelectedTestResult.Visible = false;
            gUpdateSelectedTestResult.Enabled = false;
            btnUpdateSelectedTestResult.Visible = true;
        }

        private void btnUpdateSelectedTestResult_Click(object sender, EventArgs e)
        {
            gUpdateSelectedTestResult.Visible = true;
            gUpdateSelectedTestResult.Enabled = true;
            btnUpdateSelectedTestResult.Visible = false;
        }


    }
}

using eClinicals.Controllers;
using eClinicals.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace eClinicals.View
{
    public partial class frmPatientRecordTabs : frmBaseView
    {
        List<Doctor> listDocs;
        List<Diagnosis> listDiagnosis;
        List<LabTest> listTestOrder;
        List<Appointment> listReasons;
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

      

        public frmPatientRecordTabs()
        {
            InitializeComponent();
            eClinicalsController = new eClinicalsController();
            fillListBoxElements();
            fillSetAppointmentTab();
            editAppointment();
            gbEditAppointment.Visible = false;
        }

        private void editAppointment()
        {
          
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

            listDiagnosis = eClinicalsController.GetAllDiagnosis();

            foreach (Diagnosis diagnosis in listDiagnosis)
            {
               cbDiagnosis_TestResults.Items.Add(diagnosis);              
           
            }
            listTestOrder = eClinicalsController.GetAllTests();

            foreach (LabTest test in listTestOrder)
            {
                cbTest_TestResults.Items.Add(test);
               cbSelectTest_OrderTest.Items.Add(test);
            }


        }

        private void fillSetAppointmentTab()
        {           
            // Selects the member name of the object in the listBox
            cbReason_SetAppointment.DisplayMember = "AppointmentReason";
            cbDoctor_SetAppointment.DisplayMember = "DoctorName";
            cbSelectDoctor_OrderTest.DisplayMember = "DoctorName";
            cbSelectTest_OrderTest.DisplayMember = "TestName";

            cbAppReason.DisplayMember = "AppointmentReason";
            cbAppDoctor.DisplayMember = "DoctorName";
            cbDiagnosis_TestResults.DisplayMember = "DiagnosisName";
            cbTest_TestResults.DisplayMember = "TestName";

            // Selects the index of the object in the listBox
            cbReason_SetAppointment.SelectedIndex = 0;
            cbDoctor_SetAppointment.SelectedIndex = 0;
            cbSelectDoctor_OrderTest.SelectedIndex = 0;
            cbSelectTest_OrderTest.SelectedIndex = 0;
            cbDiagnosis_TestResults.SelectedIndex = 0;
            cbTest_TestResults.SelectedIndex = 0;
            cbAppReason.SelectedIndex = 0;
            cbAppDoctor.SelectedIndex = 0;
        

        }
    }
}

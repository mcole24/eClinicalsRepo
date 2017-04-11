using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eClinicals.View;
using eClinicals.Model;

namespace eClinicals.Controllers
{
    class PatientRecordTabsViewController : ControllerBase
    {
        public frmPatientRecordTabs frmPatientRecordTabs;
        eClinicalsController eClinicalsController;
        private Patient patient;

        public PatientRecordTabsViewController(frmMain mainForm, frmBaseView thisView) : base(mainForm, thisView)
        {
             eClinicalsController = new eClinicalsController();

            frmPatientRecordTabs = (frmPatientRecordTabs)base.thisView;
            frmMain main = (frmMain)base.mainForm;
            mainForm.lblStatus.Text = "Patient Record Tabs active . . .";
            frmPatientRecordTabs.btnEditPerson.Click += new EventHandler(btnEditPerson_Click);
            frmPatientRecordTabs.btnCancel.Click += new EventHandler(btnCancel_Click);
            frmPatientRecordTabs.btnUpdate.Click += new EventHandler(btnUpdate_Click);

           
            // frmPatientRecordTabs.dgTestResults_TestResults.DataSource = eClinicalsController.GetTestResults(1);

        }
        // pateint comes from frmMain
        public void fillPatientInfo(Patient patient) {
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



    }

}

using eClinicals.Controllers;
using eClinicals.Utils;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace eClinicals.View
{
    public partial class frmRegistration : frmBaseView
    {     
        public frmMain mainForm { get; set; }
        eClinicalsController eClinicalsController;
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
        public int userType;

        public frmRegistration()
        {
            InitializeComponent();
            cbGender.SelectedIndex = 0;
        }
        private void frmRegistration_Load(object sender, EventArgs e)
        {
            cbGender.SelectedIndex = 0;
            cbState.SelectedIndex = 0;
            cbUserType.SelectedIndex = 0;
            eClinicalsController = new eClinicalsController();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {


            lastName = txtLastName.Text;
            firstName = txtFirstName.Text;
            dob = dtpDOB.Value;
            streetAddress = txtAddress.Text;
            city = txtCity.Text;
            state = cbState.Text;
            zip = txtZipcode.Text;
            phone = txtPhone.Text;
            gender = cbGender.Text;
            ssn = txtSSN.Text;
            userType = cbUserType.SelectedIndex + 1;

            try
            {
               
            if (ValidateFields.patientFields(this)){
                    int contactID = eClinicalsController.CreateContactInfo(lastName, firstName, dob, streetAddress, city, state, zip, phone, gender, ssn, userType);
                    this.createPersonByType(contactID);
                }
                else
                {
                    mainForm.Status("Form has an error please check that all fields are filled in : ", Color.Red);
                    return;
                }
            }
            catch (Exception)
            {

            }
            mainForm.lblStatus.BackColor = Color.Transparent;
            mainForm.lblStatus.Text = ("Open Patient Record : With Registered Patient");
            this.Close();
            mainForm.OpenStartMenuView();
            mainForm.Status(lastName + "," + firstName + " is now registered", Color.Yellow);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.OpenStartMenuView();
        }


        private void createPersonByType(int contactID)
        {

            if (contactID > 0)
            {
                switch (userType)
                {
                    case 1:
                        //eClinicalsController.createDoctor(contactID);
                        break;
                    case 2:
                        //eClinicalsController.createClinicAdministrator(contactID);
                        break;
                    case 3:
                        eClinicalsController.CreateNurse(contactID);
                        break;
                    case 4:
                        eClinicalsController.CreatePatient(contactID);
                        break;
                    default:
                        MessageBox.Show("There was a problem creating this person");
                        break;
                }
            }
        }




    }


}


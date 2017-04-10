using eClinicals.Controllers;
using eClinicals.Utils;
using System;
using System.Drawing;

namespace eClinicals.View
{
    public partial class frmRegistration : frmBaseView
    {     
        public frmMain mainForm { get; set; }
        eClinicalsController eClinicalsController;

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

            string lastName = txtLastName.Text;
            string firstName = txtFirstName.Text;
            DateTime dob = dtpDOB.Value;
            string streetAddress = txtAddress.Text;
            string city = txtCity.Text;
            string state = cbState.Text;
            string zip = txtZipcode.Text;
            string phone = txtPhone.Text;
            string gender = cbGender.Text;
            string ssn = txtSSN.Text;
            int userType = cbUserType.SelectedIndex + 1;
            string errorMessage = "";


            if (firstName == "")
            {
                errorMessage = "Name not valid";
                lblError_firstName.Text = errorMessage;
            }
            else {
                lblError_firstName.Text = "";
            }


            if (lastName == "")
            {
                errorMessage = "name not valid";
                lblError_lastName.Text = errorMessage;
            }
            else
            {
                lblError_lastName.Text = "";
            }

          

            if (city == "")
            {
                errorMessage = "City is not valid";
                lblError_city.Text = errorMessage;
            }
            else
            {
                lblError_city.Text = "";
            }

            if (streetAddress == "")
            {
                errorMessage = "Address is not valid";
                lblError_address.Text = errorMessage;
            }
            else
            {
                lblError_address.Text = "";
            }

            if (!RegExCheckUtil.IsPhoneNumber(phone) || phone == "")
            {
                errorMessage = "Phone is not valid";
                lblError_phone.Text = errorMessage;

            }
            else
            {
                lblError_phone.Text = "";
            }
            if (!RegExCheckUtil.IsSSN(ssn) || ssn == "")
            {
                errorMessage = "SSN is not valid";
                lblError_ssn.Text = errorMessage;
            }
            else
            {
                lblError_ssn.Text = "";
            }
            if (!RegExCheckUtil.IsUsorCanadianZipCode(zip) || zip == "")
            {
                errorMessage = "Zip is not valid";
                lblError_zip.Text = errorMessage;
            }
            else
            {
                lblError_zip.Text = "";
            }
            mainForm.Status("Form has an error please check that all fields are filled in : ", Color.Red);
            try
            {
                if (errorMessage == "" )
                {
                    eClinicalsController.CreateContactInfo(lastName, firstName, dob, streetAddress, city, state, zip, phone, gender, ssn, userType);
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

    }


}


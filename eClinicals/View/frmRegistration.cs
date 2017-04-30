﻿using eClinicals.Controllers;
using System;
using System.Drawing;
using System.Linq;
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
        public string password1;
        public string password2;
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
            cbUserType.SelectedIndex = 3;
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

            string justDigits = new string(txtPhone.Text.Where(char.IsDigit).ToArray());
            phone = justDigits;

            if (justDigits.Length > 6 & justDigits.Length < 11)
            {
                lblError_phone.Text = "";
            }
            else
            {
                errorMessage = "Phone is not valid : 9+ digits #######";
                mainForm.Status("Only numbers will be used inside for the phone. 9 digits or 10 digits", Color.Yellow);
                lblError_phone.Text = errorMessage;
                return;
            }
            gender = cbGender.Text;
            ssn = txtSSN.Text;
            userType = cbUserType.SelectedIndex + 1;

            try
            {
                if (ValidateFields.patientFields(this))
                {
                    int contactID = eClinicalsController.CreateContactInfo(lastName, firstName, dob, streetAddress, city, state, zip, phone, gender, ssn, userType);

                    this.createPersonByType(contactID);
                }
                else
                {
                    mainForm.Status("Form has an error please check that all fields are filled in : ", Color.Red);
                    return;
                }
            }
            catch (Exception ex)
            {
                mainForm.Status(ex.Message, Color.Red);
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
            try
            {

                if (contactID > 0)
                {
                    switch (userType)
                    {
                        case 1:
                            //eClinicalsController.createDoctor(contactID);
                            break;
                        case 2:
                            eClinicalsController.CreateAdmin(contactID);
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
            catch (Exception ex)
            {
                mainForm.Status(ex.Message, Color.Red);
            }


        }
        private void cbUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbUserType.SelectedIndex == 3)
            {


            }
        }
    }


}


using eClinicals.Utils;
using System;

namespace eClinicals.View
{
     class ValidateFields
    {
        static string errorMessage;

        public static bool patientFields(frmPatientRecordTabs frmPatient)
        {

            if (hasErrors(frmPatient)) {

                return true;
            }
            return false;

        }
        public static bool patientFields(frmRegistration frmPatient)
        {

            if (hasErrors(frmPatient))
            {

                return true;
            }
            return false;

        }
        private static bool hasErrors(frmPatientRecordTabs frmPatient)
        {
              if (frmPatient == null) {
                throw new System.ArgumentException("Parameter cannot be null", "frmPatient");
            }
            errorMessage = "";
            if (frmPatient.firstName == "")
            {
                errorMessage = "Name not valid";
                frmPatient.lblError_firstName.Text = errorMessage;
            }
            else
            {
                frmPatient.lblError_firstName.Text = "";
            }
            if (frmPatient.lastName == "")
            {
                errorMessage = "name not valid";
                frmPatient.lblError_lastName.Text = errorMessage;
            }
            else
            {
                frmPatient.lblError_lastName.Text = "";
            }

            if (frmPatient.city == "")
            {
                errorMessage = "City is not valid";
                frmPatient.lblError_city.Text = errorMessage;
            }
            else
            {
                frmPatient.lblError_city.Text = "";
            }

            if (frmPatient.streetAddress == "")
            {
                errorMessage = "Address is not valid";
                frmPatient.lblError_address.Text = errorMessage;
            }
            else
            {
                frmPatient.lblError_address.Text = "";
            }

            if (!RegExCheckUtil.IsPhoneNumber(frmPatient.phone) || frmPatient.phone == "")
            {
                errorMessage = "Phone is not valid";
                frmPatient.lblError_phone.Text = errorMessage;
            }
            else
            {
                frmPatient.lblError_phone.Text = "";
            }
            if (!RegExCheckUtil.IsSSN(frmPatient.ssn) || frmPatient.ssn == "")
            {
                errorMessage = "SSN is not valid";
                frmPatient.lblError_ssn.Text = errorMessage;
            }
            else
            {
                frmPatient.lblError_ssn.Text = "";
            }
            if (!RegExCheckUtil.IsUsorCanadianZipCode(frmPatient.zip) || frmPatient.zip == "")
            {
                errorMessage = "Zip is not valid";
                frmPatient.lblError_zip.Text = errorMessage;
            }
            else
            {
                frmPatient.lblError_zip.Text = "";
            }

            if (errorMessage == "") {
                return true;
            }

            return false;

        }

        private static bool hasErrors(frmRegistration frmPatient)
        {
            if (frmPatient == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", "frmPatient");
            }
            errorMessage = "";
            if (frmPatient.firstName == "")
            {
                errorMessage = "Name not valid";
                frmPatient.lblError_firstName.Text = errorMessage;
            }
            else
            {
                frmPatient.lblError_firstName.Text = "";
            }
            if (frmPatient.lastName == "")
            {
                errorMessage = "name not valid";
                frmPatient.lblError_lastName.Text = errorMessage;
            }
            else
            {
                frmPatient.lblError_lastName.Text = "";
            }

            if (frmPatient.city == "")
            {
                errorMessage = "City is not valid";
                frmPatient.lblError_city.Text = errorMessage;
            }
            else
            {
                frmPatient.lblError_city.Text = "";
            }

            if (frmPatient.streetAddress == "")
            {
                errorMessage = "Address is not valid";
                frmPatient.lblError_address.Text = errorMessage;
            }
            else
            {
                frmPatient.lblError_address.Text = "";
            }

            if ( frmPatient.txtPassword2.Text == "")
            {
                errorMessage = "Password must not be empty";
                frmPatient.lblError_password.Text = errorMessage;
            } else if (frmPatient.txtPassword1.Text != frmPatient.txtPassword2.Text )
            {
                errorMessage = "Password does not match";
                frmPatient.lblError_password.Text = errorMessage;
            }else if (frmPatient.txtPassword1.Text.Length < 5 || frmPatient.txtPassword1.Text.Length > 20)
            {
                errorMessage = "Password must be 6 characters minimum and 20 maximum.";
                frmPatient.lblError_password.Text = errorMessage;

            }
            else
            {
                frmPatient.lblError_password.Text = "";
            }
            
            if (!RegExCheckUtil.IsPhoneNumber(frmPatient.phone) || frmPatient.phone == "")
            {
                errorMessage = "Phone is not valid";
                frmPatient.lblError_phone.Text = errorMessage;
            }
            else
            {
                frmPatient.lblError_phone.Text = "";
            }
            if (!RegExCheckUtil.IsSSN(frmPatient.ssn) || frmPatient.ssn == "")
            {
                errorMessage = "SSN is not valid";
                frmPatient.lblError_ssn.Text = errorMessage;
            }
            else
            {
                frmPatient.lblError_ssn.Text = "";
            }
            if (!RegExCheckUtil.IsUsorCanadianZipCode(frmPatient.zip) || frmPatient.zip == "")
            {
                errorMessage = "Zip is not valid";
                frmPatient.lblError_zip.Text = errorMessage;
            }
            else
            {
                frmPatient.lblError_zip.Text = "";
            }
            if (errorMessage == "")
            {
                return true;
            }

            return false;

        }
    }
}
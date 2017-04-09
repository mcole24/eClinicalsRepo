using eClinicals.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eClinicals.View
{
    public partial class frmRegistration : frmBaseView
    {
        public frmRegistration()
        {
            InitializeComponent();
            cbGender.SelectedIndex = 0;
        }

        public frmMain mainForm { get; set; }
        eClinicalsController eClinicalsController;
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
            string ssn =txtSSN.Text;
            int userType = cbUserType.SelectedIndex + 1;

            try
            {
                if (lastName != "" & firstName != "" & dob != null & streetAddress != "" & city != "" & state != "" & zip != "" & phone != "" & gender != "" & ssn != "" & userType > -1)
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

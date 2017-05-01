using System;

namespace eClinicals.View
{
    public partial class frmPatientSearch : frmBaseView
    {

        private const int BY_DOB_NAME = 0;
        private const int BY_DOB = 1;
        private const int BY_NAME = 2;

        public frmPatientSearch()
        {
            InitializeComponent();
            cbSearch.SelectedIndexChanged += cbSearch_SelectedIndexChanged;
        }

        private void frmPatientSearch_Load(object sender, EventArgs e)
        {
            cbSearch.SelectedIndex = BY_DOB_NAME;
        }

        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cbSearch.SelectedItem.ToString();

            switch (selectedValue)
            {
                case "Name":
                    txtLastName.Visible = true;
                    txtFirstName.Visible = true;
                    lblDate_FirstName.Text = "First Name";
                    lblLastName.Text = "Last Name";
                    dtpDate.Visible = false;
                    break;

                case "Date of Birth":
                    lblDate_FirstName.Text = "";
                    lblLastName.Text = "";
                    lblDate_FirstName.Text = "";
                    txtLastName.Visible = false;
                    txtFirstName.Visible = false;
                    dtpDate.Visible = true;
                    break;
                case "DOB/NAME":
                    lblDate_FirstName.Text = "Select DOB";
                    lblLastName.Text = "Last Name";
                    txtLastName.Visible = true;
                    txtFirstName.Visible = false;
                    dtpDate.Visible = true;
                    break;
                default:
                    lblDate_FirstName.Text = "Select Appointment Date";
                    txtFirstName.Visible = false;
                    break;
            }

            if (cbSearch.SelectedIndex == -1)
            {
                lblDate_FirstName.Text = "Select Appointment Date";
            }

        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        public void NoPatientFound(bool visible, string title, string message)
        {
            picNoUserFound.Visible = visible;
            lblErrorMessage.Visible = visible;
            lblErrorTitle.Visible = visible;
            lblErrorMessage.Text = message;
            lblErrorTitle.Text = title;
        }
        public void NoPatientFound(bool visible)
        {
            picNoUserFound.Visible = visible;
            lblErrorMessage.Visible = visible;
            lblErrorTitle.Visible = visible;
        }

    }

}

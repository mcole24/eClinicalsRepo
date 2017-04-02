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
        string selectedValue =  cbSearch.SelectedItem.ToString();

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
      
    }
}

using eClinicals.Controllers;
using eClinicals.Model;
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
    public partial class frmPatientRecordTabs : frmBaseView
    {
        List<Doctor> listDocs;
        List<Appointment> listReasons;
        eClinicalsController eClinicalsController;
        public frmPatientRecordTabs()
        {
            InitializeComponent();
            eClinicalsController = new eClinicalsController();

            listDocs = eClinicalsController.GetAllDoctorNames();
          
            foreach (Doctor doc in listDocs)
            {
                cbDoctor_SetAppointment.Items.Add(doc);
                cbDoctor_SetAppointment.DisplayMember = doc.DoctorName;
            }

           listReasons =  eClinicalsController.GetAllAppointmentReasons();

            foreach (Appointment reason in listReasons)
            {
             cbReason_SetAppointment.Items.Add(reason);
            
            }
            cbReason_SetAppointment.DisplayMember = "AppointmentReason";
            cbDoctor_SetAppointment.DisplayMember = "DoctorName";

            cbReason_SetAppointment.SelectedIndex = 0;
        cbDoctor_SetAppointment.SelectedIndex = 0;      
        cbSelectDoctor_OrderTest.SelectedIndex = 0;        
        cbSelectTest_OrderTest.SelectedIndex = 0;
            

        }

        private void btnOrderTest_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_OrderTest_Click(object sender, EventArgs e)
        {

        }
    }
}

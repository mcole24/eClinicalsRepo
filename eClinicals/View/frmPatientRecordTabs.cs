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
        public frmPatientRecordTabs()
        {
            InitializeComponent();
            cbReason_SetAppointment.SelectedIndex = 0;
             cbDoctor_SetAppointment.SelectedIndex = 0;
            clbSymptoms_RoutineCheck.SelectedIndex = clbSymptoms_RoutineCheck.SelectedItems.Count;
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

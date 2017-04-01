using System;
using System.Collections.Generic;

namespace eClinicals.View
{
    public partial class frmNurseMenuSelectView : frmBaseView
    {
        public frmNurseMenuSelectView()
        {
            InitializeComponent();
        }

        private void frmNurseLoggedInView_Load(object sender, EventArgs e)
        {

        }

        private void btnFindPatientRecord_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

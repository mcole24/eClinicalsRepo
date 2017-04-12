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
    public partial class frmAdminReport : frmBaseView
    {
        eClinicalsController eClinicalsController;
        public frmAdminReport()
        {
            InitializeComponent();
        }

        private void frmAdminReport_Load(object sender, EventArgs e)
        {
           
        }

        private void btnGetReport_Click(object sender, EventArgs e)
        {
            try
            {
                Report report = new Report();
                //Error
                 report = eClinicalsController.MostPerformedTestsDuringDates(dtStart.Value,dtEnd.Value);
                dgReport.DataSource = report;
            }
            catch (Exception)
            {


            }
        }
    }
}

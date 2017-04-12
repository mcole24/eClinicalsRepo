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
       
      
        public frmAdminReport()
        {
            InitializeComponent();
           
        }  

        private void btnGetReport_Click(object sender, EventArgs e)
        {
            try
            {
                Report report = new Report();
                DateTime startDate = dtStart.Value.Date;
                DateTime endDate = dtEnd.Value.Date;
                //Error
                report = eController.MostPerformedTestsDuringDates(startDate, endDate);
                dgReport.DataSource = report;
            }
            catch (Exception ex)
            {
                controller.Status(ex.Message, Color.Red);

            }
        }
    }
}

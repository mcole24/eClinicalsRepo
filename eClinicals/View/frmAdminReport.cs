using eClinicals.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Threading;

namespace eClinicals.View
{


    public partial class frmAdminReport : frmBaseView
    {
        DispatcherTimer timer;
        TimeSpan time;

        public frmAdminReport()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            time = TimeSpan.FromSeconds(1);
            timer.Interval = time;
            timer.Tick += new EventHandler(timer_Tick);
        }

        private void btnGetReport_Click(object sender, EventArgs e)
        {
            try
            {
                List<Report> report;
                DateTime startDate = dtStart.Value.Date;
                DateTime endDate = dtEnd.Value.Date;
                report = eController.MostPerformedTestsDuringDates(startDate, endDate);
                ReportBindingSource.DataSource = report;
                this.reportViewer.RefreshReport();

                if (report.Count < 1)
                {
                    lblNoReportFound.Visible = true;
                    timer.Start();
                }
                else
                {
                    lblNoReportFound.Visible = false;
                }
            }
            catch (Exception ex)
            {
                controller.Status(ex.Message, Color.Red);
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            //Timer activates after time has ellapsed
            lblNoReportFound.Visible = false;
            timer.IsEnabled = false;
        }

        private void frmAdminReport_Load(object sender, EventArgs e)
        {

            this.reportViewer.RefreshReport();
        }
    }
}

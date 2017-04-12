using eClinicals.View;

namespace eClinicals.Controllers
{
    class AdminReportController : ControllerBase
    {

        public frmAdminReport frmAdminReport;
        public AdminReportController(frmMain mainForm, frmBaseView thisView) : base(mainForm, thisView)
        {

            frmAdminReport = (frmAdminReport)base.thisView; 

            mainForm.lblStatus.Text = "Select a menu option . . .";
        }
}
}

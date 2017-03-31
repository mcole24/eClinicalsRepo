using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eClinicals.View;

namespace eClinicals.Controllers
{
    class RibbonController : ControllerBase
    {
        frmRibbon ribbon;
        public RibbonController(frmMain mainForm, frmBaseView thisView) : base(mainForm, thisView)
        {
            ribbon = (frmRibbon)base.thisView;
            mainForm.lblStatus.Text = "Ribbon Active";
        }
        public void AddUserInfo(string name, string uid, string userType) {

            ribbon.lblUserName.Text = name;
            ribbon.lblId.Text = uid;
            ribbon.lblUserType.Text = userType;

        }

        public void AddContactInfo(string phone, string Address)
        {

            ribbon.lblPhone.Text = phone;
            ribbon.lblAddress.Text = Address;

        }
        public void AddStatusInfo(string status)
        {

            ribbon.lblStatus.Text = status;
          

        }
    }
}

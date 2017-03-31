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
        public void UserInfo(string name, string uid) {


            ribbon.lblUserName.Text = name;
            ribbon.lblId.Text = uid;

        }



    }
}

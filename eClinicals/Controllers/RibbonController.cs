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
        public RibbonController(frmMain mainForm, frmBaseView thisView) : base(mainForm, thisView)
        {
           frmRibbon frmRibbon = (frmRibbon)base.thisView;
            mainForm.lblStatus.Text = "Ribbon Active";
        }
    }
}

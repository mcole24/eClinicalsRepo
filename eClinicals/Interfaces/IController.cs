using eClinicals.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eClinicals
{
    interface IController
    {
        string status { get; set; }
        frmMain mainForm { get; set; }
    }
}

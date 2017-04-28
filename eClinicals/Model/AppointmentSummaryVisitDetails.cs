using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eClinicals.Model
{
    class AppointmentSummaryVisitDetails
    {
    public int VisitID { get; set; }
    
    public DateTime VisitDate { get; set; }

    public string Doctor { get; set; }

    public string ReasonForVisit { get; set; }

    }
}

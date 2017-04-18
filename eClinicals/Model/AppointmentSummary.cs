using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eClinicals.Model
{
    class AppointmentSummary
    {
    public int VisitID { get; set; }
    
    public DateTime VisitDate { get; set; }

    public string Doctor { get; set; }

    public string ReasonForVisit { get; set; }

    public string Symptoms { get; set; }

   
        public int SystolicBPReading { get; set; }
        public int DiastolicBPReading { get; set; }

        public decimal BodyTemperatureReading { get; set; }

        public int PulseReading { get; set; }

        public string InitialDiagnosis { get; set; }

        public string FinalDiagnosis { get; set; }

        public string TestResult { get; set; }

        public string TestName { get; set; }

        public bool ResultRecorded { get; set; }

    }
}

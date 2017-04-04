using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eClinicals.Model
{
    class LabTest
    {
        public int TestID { get; set; }

        public DateTime PerformedDate { get; set; }

        public string Test { get; set; }

        public int InitialDiagnosis { get; set; }

        public int FinalDiagnosis { get; set; }

        public string DiagnosisType { get; set; }

        public string Doctor { get; set; }
    }
}

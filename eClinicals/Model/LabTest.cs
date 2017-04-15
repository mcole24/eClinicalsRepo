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

        public int TestCode { get; set; }

        public string TestName { get; set; }

        public int TestResult { get; set; }

        public bool ResultRecorded { get; set; }
    }
}

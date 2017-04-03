using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eClinicals.Model
{
    class RoutineCheck
    {
        public DateTime VisitDate { get; set; }

        public int DiastolicBP { get; set; }

        public int SystolicBP { get; set; }

        public decimal BodyTemperature { get; set; }

        public int Pulse { get; set; }

        public string Symptom { get; set; }
    }
}

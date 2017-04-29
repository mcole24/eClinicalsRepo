using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eClinicals.Model
{
    class AppointmentSummaryCheckupResults
    {

        public int SystolicBPReading { get; set; }
        public int DiastolicBPReading { get; set; }

        public decimal BodyTemperatureReading { get; set; }

        public int PulseReading { get; set; }

    }
}

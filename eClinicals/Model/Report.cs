using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eClinicals.Model
{
    class Report
    {
        public int TestCode { get;  set; }
        public string TestName { get; set; }
        public int TimesPerformed { get; set; }
        public int TotalTests { get; set;  }
        public decimal PercentageOfTests { get; set; }
        public int NormalResults { get; set; }
        public int AbnormalResults { get; set; }
        public decimal PatientsUnder18 { get; set; }
        public decimal PatientsBetween18and30 { get; set; }
        public decimal PatientsOver30 { get; set; }
      
    
      
                    
}
}

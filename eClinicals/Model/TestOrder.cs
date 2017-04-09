using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eClinicals.Model
{
    class TestOrder
    {

        public int TestID { get; set; }
        public string TestCode { get; set; }
        public int VisitID { get; set; }
        public Boolean Result { get; set; }
        public DateTime DateCompleted { get; set; }

    }
}

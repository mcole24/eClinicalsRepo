using eClinicals.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eClinicals.Events
{
   public class UserLoggedInArgs : EventArgs
    {      
            public Person Person { get; set; }
      

    }
}

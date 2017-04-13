using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eClinicals.View
{
    partial class frmLogin : frmBaseView
    {
        public bool isLoggedIn { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public frmLogin()
        {
            InitializeComponent();
            
          

        }

   
    }
}

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
        public frmLogin()
        {
            InitializeComponent();
          

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            isLoggedIn = false;
        }
    }
}

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
    public partial class frmRegistration : frmBaseView
    {
        public frmRegistration()
        {
            InitializeComponent();
            cbGender.SelectedIndex = 0;
        }

      

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            cbGender.SelectedIndex = 0;
            cbState.SelectedIndex = 0;
            cbUserType.SelectedIndex = 0;
        }


    }
}

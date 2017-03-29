using eClinicals.Controllers;
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
    public partial class frmMain : Form
    {
        LoginController loginController;
        NurseLoggedInViewController nurseLoggedInViewController;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            loginController = new LoginController(this, new frmLogin());
            loginController.LoggedIn += this.OnLoggedIn;
            loginController.Show();

        }
        public void OnLoggedIn(object source, EventArgs e) {

            nurseLoggedInViewController = new NurseLoggedInViewController(this, new frmNurseMenuSelectView());
            nurseLoggedInViewController.Show();
        }


    }
}

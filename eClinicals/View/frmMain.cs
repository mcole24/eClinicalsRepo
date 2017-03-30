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
        private ucUserRibbon userRibbon;
        NurseLoggedInViewController nurseLoggedInViewController;
        public frmMain()
        {
            InitializeComponent();           
        }

        private void frmMain_Load(object sender, EventArgs e)
        {          
            userRibbon = new ucUserRibbon();
            userRibbon.Location = new Point(0, 0);
            this.Controls.Add(userRibbon);           
        
            loginController = new LoginController(this, new frmLogin());

            loginController.LoggedIn += this.OnLoggedIn;
            loginController.Show();
            loginController.thisView.BringToFront();
        }
        public void OnLoggedIn(object source, EventArgs e) {

            nurseLoggedInViewController = new NurseLoggedInViewController(this, new frmNurseMenuSelectView());
            nurseLoggedInViewController.Show();
           
            nurseLoggedInViewController.thisView.Location = new Point(0, 80);
            nurseLoggedInViewController.mainForm.Height = nurseLoggedInViewController.thisView.Height + 100;
            nurseLoggedInViewController.mainForm.Width = nurseLoggedInViewController.thisView.Width + 125;
        }


    }
}

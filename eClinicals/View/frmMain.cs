using eClinicals.Controllers;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace eClinicals.View
{
    public partial class frmMain : Form
    {

        const int MIDDLE =0;
        const int TOP = 1;
        const int BOTTOM = 2;
        LoginController loginController;
        RibbonController ribbonController;      
        NurseLoggedInViewController nurseLoggedInViewController;
        public frmMain()
        {
            InitializeComponent();           
        }

        private void frmMain_Load(object sender, EventArgs e)
        {


            loginController = new LoginController(this, new frmLogin());
            loginController.LoggedIn += this.OnLoggedIn;
            AddToContainer(loginController, MIDDLE);
        }


        public void OnLoggedIn(object source, EventArgs e) {
            nurseLoggedInViewController = new NurseLoggedInViewController(this, new frmNurseMenuSelectView());
            AddToContainer(nurseLoggedInViewController,MIDDLE);

            ribbonController = new RibbonController(this, new frmRibbon());
            AddToContainer(ribbonController, TOP);
            this.pTop.Visible = true;
            
            
            // This will Come from Database ////
            ribbonController.AddUserInfo("Stalbert, Malik", "12548");


        }

        private void  AddToContainer(ControllerBase thisController, int level) {
            switch (level)
            {
                case MIDDLE :
                    thisController.mainForm.pMiddle.Controls.Add(thisController.thisView);
                    thisController.Show();    
                    break;
                case TOP:
                    thisController.mainForm.pTop.Controls.Add(thisController.thisView);
                    thisController.Show();              
                    break;
            }

        }
    }
}

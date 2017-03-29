using eClinicals.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eClinicals.Controllers
{
    class ControllerBase : IController
    {
        public frmMain mainForm { get; set; }
        public Form thisView { get; set; }

        public string status { get; set; }     

        public ControllerBase(frmMain mainForm, Form thisView)
        {
            if (mainForm == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", "mainForm");
            }


            if (thisView == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", "thisView");
            }

            this.mainForm = mainForm;
            this.thisView = thisView;
            thisView.MdiParent = this.mainForm;
            thisView.FormClosed += ThisView_FormClosed;
            this.thisView.Show();
        }
        public void Show()
        {
            string message = "";
            // After Connection to database
            if (thisView == null) {               

                thisView.MdiParent = this.mainForm;
                thisView.FormClosed += ThisView_FormClosed;
              //  thisView.Height = thisView.MdiParent.Height;               
                thisView.Show();

                mainForm.lblStatus.Text = message;
            }
            else
            {
                thisView.Activate();
                message = "Message: Login form  is active. ";
            }
            mainForm.lblStatus.Text = message;
        }

        private void ThisView_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            Form frm = (Form)sender;
            thisView = null;         
            mainForm.lblStatus.Text = frm.Text + " has been closed. Use the menu above to reopen the form. ";
        }



    }

}

using System.Windows.Forms;

namespace eClinicals.Utils
{

    public static class ExtensionGridView
    {
        public static DataGridView RemoveEmptyColumns(DataGridView grdView)
        {


            grdView.Columns["Address"].Visible = false;
            grdView.Columns["City"].Visible = false;
            grdView.Columns["State"].Visible = false;
            grdView.Columns["Zip"].Visible = false;
            grdView.Columns["Gender"].Visible = false;
            grdView.Columns["Phone"].Visible = false;
            grdView.Columns["Ssn"].Visible = false;
            grdView.Columns["UserName"].Visible = false;
            grdView.Columns["UserType"].Visible = false;

            return grdView;
        }

        public static DataGridView RemoveAppointmentIdColumns(DataGridView grdView)
        {


            // grdView.Columns["appointmentID"].Visible = false;
            grdView.Columns["patientID"].Visible = false;
            grdView.Columns["doctorID"].Visible = false;
            grdView.Columns["appointmentReasonID"].Visible = false;
            //  grdView.Columns["Gender"].Visible = false;
            //  grdView.Columns["Phone"].Visible = false;
            //  grdView.Columns["Ssn"].Visible = false;
            //  grdView.Columns["UserName"].Visible = false;
            //  grdView.Columns["UserType"].Visible = false;

            return grdView;
        }
    }
}



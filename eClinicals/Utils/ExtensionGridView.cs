using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }
}



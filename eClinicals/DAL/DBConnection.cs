using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace eClinicals.DAL
{
    public static class DBConnection
    {

        public static SqlConnection GetConnection()
        {
            try
            {
<<<<<<< HEAD
               // string connectString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=[CS6232-g5];Integrated Security=True";
                string connectString = " Data Source = localhost;Initial Catalog=CS6232-g5;" +
               "Integrated Security=True";
=======
                //(localdb)\\MSSQLLocalDB
                string connectString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=[CS6232-g5];Integrated Security=True";
>>>>>>> 98086e77b17e0c5ead05f59a6cab8334ea9f5968
                SqlConnection connect = new SqlConnection(connectString);
                return connect;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}

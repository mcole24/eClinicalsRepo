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
               // string connectString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=[CS6232-g5];Integrated Security=True";
                string connectString = " Data Source = localhost;Initial Catalog=CS6232-g5;" +
               "Integrated Security=True";
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.IO;
using eClinicals.Model;


namespace eClinicals.DAL
{
    class NurseDAL
    {
        private SimpleAES encrypt = new SimpleAES();


        public static bool createNurse(int contactID)
        {

            try
            {
                using (SqlConnection connect = DBConnection.GetConnection())
                {
                    string insertStmt = "INSERT INTO nurse (contactID) VALUES (@contact);";
                    using (SqlCommand cmd = new SqlCommand(insertStmt, connect))
                    {
                        cmd.Parameters.AddWithValue("@contact", contactID);
                        connect.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }

        }


        public static bool createNurseLogin(int contactID, string username, string password)
        {

            try
            {
                using (SqlConnection connect = DBConnection.GetConnection())
                {
                    string insertStmt = "INSERT INTO logins (contactID, userName, password) VALUES (@contact, @user, @password);";
                    using (SqlCommand cmd = new SqlCommand(insertStmt, connect))
                    {
                        cmd.Parameters.AddWithValue("@contact", contactID);
                        cmd.Parameters.AddWithValue("@user", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        connect.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }

        }



    }
}

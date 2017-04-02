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


        public static bool CreateNurse(int contactID)
        {

            try
            {
                using (SqlConnection connect = DBConnection.GetConnection())
                {
                    connect.Open();
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


        public static bool DeleteNurse(int contactID)
        {
            try
            {
                using (SqlConnection connect = DBConnection.GetConnection())
                {
                    connect.Open();
                    string delStmt = "DELETE FROM nurse WHERE contactID = @id";
                    using (SqlCommand cmd = new SqlCommand(delStmt, connect))
                    {
                        cmd.Parameters.AddWithValue("@id", contactID);
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


        public static Nurse GetNurseByID(int contactID)
        {
            Nurse nurse = new Nurse();
            try
            {
                using (SqlConnection connect = DBConnection.GetConnection())
                {
                    connect.Open();
                    string selStmt = "SELECT * FROM contact INNER JOIN nurse ON contact.contactID = nurse.contactID WHERE nurse.contactID = @contactID";
                    using (SqlCommand cmd = new SqlCommand(selStmt, connect))
                    {
                        cmd.Parameters.AddWithValue("@contactID", contactID);
                        connect.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                nurse.ContactID = (int)reader["contactID"];
                                nurse.LastName = reader["lName"].ToString();
                                nurse.FirstName = reader["fName"].ToString();
                                nurse.Dob = reader["dob"].ToString();
                                nurse.Gender = reader["gender"].ToString();
                                nurse.Address = reader["mailingAddressStreet"].ToString();
                                nurse.City = reader["mailingAddressCity"].ToString();
                                nurse.State = reader["mailingAddressState"].ToString();
                                nurse.Zip = reader["mailingAddressZip"].ToString();
                                nurse.Phone = reader["phone"].ToString();
                                nurse.Ssn = reader["ssn"].ToString();
                                nurse.UserName = reader["username"].ToString();

                            }
                        }
                    }
                }
            }
            catch (SqlException sqlex)
            {
                throw sqlex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return nurse;
        }





    }
}

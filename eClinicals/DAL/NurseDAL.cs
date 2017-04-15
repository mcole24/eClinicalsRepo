using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using eClinicals.Model;


namespace eClinicals.DAL
{
    class NurseDAL
    {

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
                        cmd.ExecuteNonQuery();
                        connect.Close();
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
                        cmd.ExecuteNonQuery();
                        connect.Close();
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
                    string selStmt = "SELECT n.nurseID, c.lName, c.fName, c.dob, c.mailingAddressStreet, c.mailingAddressCity, c.mailingAddressState, c.mailingAddressZip, c.phoneNumber, c.gender, c.ssn " + 
                        "FROM contact c INNER JOIN nurse n ON c.contactID = n.contactID WHERE n.contactID = @contactID";
                    using (SqlCommand cmd = new SqlCommand(selStmt, connect))
                    {
                        cmd.Parameters.AddWithValue("@contactID", contactID);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                nurse.NurseID = (int)reader["n.nurseID"];
                                nurse.ContactID = contactID;
                                nurse.LastName = reader["c.lName"].ToString();
                                nurse.FirstName = reader["c.fName"].ToString();
                                nurse.Dob = (DateTime)reader["c.dob"];
                                nurse.Address = reader["c.mailingAddressStreet"].ToString();
                                nurse.City = reader["c.mailingAddressCity"].ToString();
                                nurse.State = reader["c.mailingAddressState"].ToString();
                                nurse.Zip = reader["c.mailingAddressZip"].ToString();
                                nurse.Phone = reader["c.phoneNumber"].ToString();
                                nurse.Gender = reader["c.gender"].ToString();
                                nurse.Ssn = reader["c.ssn"].ToString();
                            }
                            reader.Close();
                        }
                    }
                    connect.Close();
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

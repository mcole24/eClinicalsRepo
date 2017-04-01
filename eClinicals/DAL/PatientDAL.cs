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
    class PatientDAL
    {




        public static bool CreatePatient(int contactID)
        {

            try
            {
                using (SqlConnection connect = DBConnection.GetConnection())
                {
                    string insertStmt = "INSERT INTO patient (contactID) VALUES (@contact);";
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


        public static bool DeletePatient(int contactID)
        {
            try
            {
                using (SqlConnection connect = DBConnection.GetConnection())
                {
                    string delStmt = "DELETE FROM patient WHERE contactID = @id";
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


        public static Patient GetPatientByID(int contactID)
        {
            Patient patient = new Patient();
            try
            {
                using (SqlConnection connect = DBConnection.GetConnection())
                {
                    string selStmt = "SELECT * FROM contact INNER JOIN patient ON contact.contactID = patient.contactID WHERE patient.contactID = @contactID";
                    using (SqlCommand cmd = new SqlCommand(selStmt, connect))
                    {
                        cmd.Parameters.AddWithValue("@contactID", contactID);
                        connect.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                patient.ContactID = (int)reader["contactID"];
                                patient.LastName = reader["lName"].ToString();
                                patient.FirstName = reader["fName"].ToString();
                                patient.Dob = (DateTime)reader["dob"];
                                patient.Gender = reader["gender"].ToString();
                                patient.Address = reader["mailingAddressStreet"].ToString();
                                patient.City = reader["mailingAddressCity"].ToString();
                                patient.State = reader["mailingAddressState"].ToString();
                                patient.Zip = reader["mailingAddressZip"].ToString();
                                patient.Phone = reader["phone"].ToString();
                                patient.Ssn = reader["ssn"].ToString();
                                // Patients will not have user names
                            
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
            return patient;
        }





    }
}

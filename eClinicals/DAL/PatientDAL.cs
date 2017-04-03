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
                    connect.Open();
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
                    connect.Open();
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
                    connect.Open();
                    string selStmt = "SELECT * FROM contact INNER JOIN patient ON contact.contactID = patient.contactID WHERE patient.contactID = @contactID";
                    using (SqlCommand cmd = new SqlCommand(selStmt, connect))
                    {
                        cmd.Parameters.AddWithValue("@contactID", contactID);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                patient.ContactID = (int)reader["contactID"];
                                patient.LastName = reader["lName"].ToString();
                                patient.FirstName = reader["fName"].ToString();
                                patient.Dob = (DateTime)reader["dob"];
                                patient.Address = reader["mailingAddressStreet"].ToString();
                                patient.City = reader["mailingAddressCity"].ToString();
                                patient.State = reader["mailingAddressState"].ToString();
                                patient.Zip = reader["mailingAddressZip"].ToString();
                                patient.Phone = reader["phone"].ToString();
                                patient.Gender = reader["gender"].ToString();
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

        public static List<Patient> SearchPatientByFirstAndLastName(string fName, string lName)
        {
            List<Patient> patientList = new List<Patient>();
             string selectStatement = "SELECT * FROM contact INNER JOIN patient ON contact.contactID = patient.contactID " 
                + "WHERE contact.fName = @fName AND contact.lName = @lName";
            try
            {
                using (SqlConnection connection = DBConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@fName", fName);
                        selectCommand.Parameters.AddWithValue("@lName", lName);
                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                            Patient patient = new Patient();
                                patient.ContactID = (int)reader["contactID"];
                                patient.LastName = reader["lName"].ToString();
                                patient.FirstName = reader["fName"].ToString();
                                patient.Dob = (DateTime)reader["dob"];
                                patient.Address = reader["mailingAddressStreet"].ToString();
                                patient.City = reader["mailingAddressCity"].ToString();
                                patient.State = reader["mailingAddressState"].ToString();
                                patient.Zip = reader["mailingAddressZip"].ToString();
                                patient.Phone = reader["phoneNumber"].ToString();
                                patient.Gender = reader["gender"].ToString();
                                patient.Ssn = reader["ssn"].ToString();
                                patientList.Add(patient);
                            }
                        }
                    }
                }
            }

            catch (SqlException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
            return patientList;
        }

        public static List<Patient> SearchPatientByDOB(DateTime dob)
        {
            List<Patient> patientList = new List<Patient>();
            string selectStatement = "SELECT * FROM contact INNER JOIN patient ON contact.contactID = patient.contactID "
               + "WHERE contact.dob = @dob";
            try
            {
                using (SqlConnection connection = DBConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@dob", dob);
                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Patient patient = new Patient();
                                patient.ContactID = (int)reader["contactID"];
                                patient.LastName = reader["lName"].ToString();
                                patient.FirstName = reader["fName"].ToString();
                                patient.Dob = (DateTime)reader["dob"];
                                patient.Address = reader["mailingAddressStreet"].ToString();
                                patient.City = reader["mailingAddressCity"].ToString();
                                patient.State = reader["mailingAddressState"].ToString();
                                patient.Zip = reader["mailingAddressZip"].ToString();
                                patient.Phone = reader["phoneNumber"].ToString();
                                patient.Gender = reader["gender"].ToString();
                                patient.Ssn = reader["ssn"].ToString();
                                patientList.Add(patient);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
            return patientList;
        }

        public static List<Patient> SearchPatientByLastNameAndDOB(string lName, DateTime dob)
        {
            List<Patient> patientList = new List<Patient>();
            string selectStatement = "SELECT * FROM contact INNER JOIN patient ON contact.contactID = patient.contactID "
               + "WHERE contact.lName = @lName AND contact.dob = @dob";
            try
            {
                using (SqlConnection connection = DBConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@lName", lName);
                        selectCommand.Parameters.AddWithValue("@dob", dob);
                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Patient patient = new Patient();
                                patient.ContactID = (int)reader["contactID"];
                                patient.LastName = reader["lName"].ToString();
                                patient.FirstName = reader["fName"].ToString();
                                patient.Dob = (DateTime)reader["dob"];                             
                                patient.Address = reader["mailingAddressStreet"].ToString();
                                patient.City = reader["mailingAddressCity"].ToString();
                                patient.State = reader["mailingAddressState"].ToString();
                                patient.Zip = reader["mailingAddressZip"].ToString();
                                patient.Phone = reader["phoneNumber"].ToString();
                                patient.Gender = reader["gender"].ToString();
                                patient.Ssn = reader["ssn"].ToString();
                                patientList.Add(patient);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
            return patientList;
        }

    }
}

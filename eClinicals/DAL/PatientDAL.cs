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
                                patient.PatientID = (int)reader["patient.patientID"];
                                patient.ContactID = (int)reader["contact.contactID"];
                                patient.LastName = reader["contact.lName"].ToString();
                                patient.FirstName = reader["contact.fName"].ToString();
                                patient.Dob = (DateTime)reader["contact.dob"];
                                patient.Address = reader["contact.mailingAddressStreet"].ToString();
                                patient.City = reader["contact.mailingAddressCity"].ToString();
                                patient.State = reader["contact.mailingAddressState"].ToString();
                                patient.Zip = reader["contact.mailingAddressZip"].ToString();
                                patient.Phone = reader["contact.phoneNumber"].ToString();
                                patient.Gender = reader["contact.gender"].ToString();
                                patient.Ssn = reader["contact.ssn"].ToString();
                                // Patients will not have user names
                            
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
            return patient;
        }

        public static List<Patient> SearchPatientByFirstAndLastName(string fName, string lName)
        {
            List<Patient> patientList = new List<Patient>();
             string selectStatement = "SELECT * FROM contact INNER JOIN patient ON contact.contactID = patient.contactID " 
                + "WHERE contact.fName LIKE '%'+@fName+'%' AND contact.lName LIKE '%'+@lName+'%'";
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
                                patient.PatientID = (int)reader["patientID"];
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
                            reader.Close();
                        }
                        
                    }
                    connection.Close();
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
                                patient.PatientID = (int)reader["patientID"];
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
                            reader.Close();
                        }
                    }
                    connection.Close();
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
               + "WHERE contact.lName LIKE '%'+@lName+'%' AND contact.dob = @dob";
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
                                patient.PatientID = (int)reader["patientID"];
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
                            reader.Close();
                        }
                    }
                    connection.Close();
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


        public static bool UpdatePatient(int contactID, string lastName, string firstName, DateTime DOB, string street, string city, string state, 
            string ZIP, string phone, string gender, string SSN)
        {
            bool isUpdated = false;
            string updateStmt = "UPDATE contact SET lName = @lastName, fName = @firstName, dob = @DOB, mailingAddressStreet = @street, " +
                "mailingAddressCity = @city, mailingAddressState = @state, mailingAddressZip = @ZIP, phoneNumber = @phone, gender = @gender, ssn = @SSN " + 
                "WHERE patientID = (SELECT patientID FROM patient WHERE contactID = @contact)";
            try
            {
                using (SqlConnection connect = DBConnection.GetConnection())
                {
                    connect.Open();
                    using (SqlCommand cmd = new SqlCommand(updateStmt, connect))
                    {
                        cmd.Parameters.AddWithValue("@contact", contactID);
                        cmd.Parameters.AddWithValue("@lastName", lastName);
                        cmd.Parameters.AddWithValue("@firstName", firstName);
                        cmd.Parameters.AddWithValue("@DOB", DOB);
                        cmd.Parameters.AddWithValue("@street", street);
                        cmd.Parameters.AddWithValue("@city", city);
                        cmd.Parameters.AddWithValue("@state", state);
                        cmd.Parameters.AddWithValue("@ZIP", ZIP);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@SSN", SSN);
                        isUpdated = (cmd.ExecuteNonQuery() > 0);
                    }
                    connect.Close();
                }
                return isUpdated;
            }
            catch (SqlException sqlex)
            {
                throw sqlex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




    }
}

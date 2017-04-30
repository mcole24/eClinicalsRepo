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




        public static bool CreatePatient(string lName, string fName, DateTime dob, string streetAddress, string city, string state, string zip, string phone, string gender, string ssn)
        {

            bool isCreated = false;
            int newContactID = 0;

            string insertStmt1 = "INSERT INTO contact (lName, fName, dob, mailingAddressStreet, mailingAddressCity, mailingAddressState, mailingAddressZip, phoneNumber, gender, SSN, userType) " +
                        "VALUES (@last, @first, @dob, @street, @city, @state, @zip, @phone, @gender, @ssn, 4)";

            string selStmt = "SELECT MAX(contactID) AS MaxContactID FROM contact";

            string insertStmt2 = "INSERT INTO patient (contactID) VALUES (@contact);";


            using (SqlConnection connect = DBConnection.GetConnection())
            {
                connect.Open();
                SqlTransaction tran = connect.BeginTransaction();
                try
                {


                    using (SqlCommand cmd = new SqlCommand(insertStmt1, connect, tran))
                    {
                        cmd.Parameters.AddWithValue("@last", lName);
                        cmd.Parameters.AddWithValue("@first", fName);
                        cmd.Parameters.AddWithValue("@dob", dob);
                        cmd.Parameters.AddWithValue("@street", streetAddress);
                        cmd.Parameters.AddWithValue("@city", city);
                        cmd.Parameters.AddWithValue("@state", state);
                        cmd.Parameters.AddWithValue("@zip", zip);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@ssn", ssn);
                        cmd.ExecuteNonQuery();
                    }


                    using (SqlCommand cmd = new SqlCommand(selStmt, connect, tran))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                newContactID = (int)reader["MaxContactID"];
                            }
                        }
                    }




                    if (newContactID > 0)
                    {
                        using (SqlCommand cmd = new SqlCommand(insertStmt2, connect, tran))
                        {
                            cmd.Parameters.AddWithValue("@contact", newContactID);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    isCreated = true;
                    tran.Commit();
                    connect.Close();


                }
                catch
                {
                    tran.Rollback();
                    return false;
                }
            }
            return isCreated;
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
                "mailingAddressCity = @city, mailingAddressState = @state, mailingAddressZip = @ZIP, phoneNumber = @phone, gender = @gender, SSN = @SSN  " +
                "WHERE contactID = @contactID";
            try
            {
                using (SqlConnection connect = DBConnection.GetConnection())
                {
                    connect.Open();
                    using (SqlCommand cmd = new SqlCommand(updateStmt, connect))
                    {
                        cmd.Parameters.AddWithValue("@contactID", contactID);
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

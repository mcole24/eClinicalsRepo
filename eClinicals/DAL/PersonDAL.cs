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
    class PersonDAL
    {


        

        public static bool createLogin(int contactID, string username, string password)
        {

            try
            {
                using (SqlConnection connect = DBConnection.GetConnection())
                {
                    connect.Open();
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



        public static bool createContactInfo(string lName, string fName, DateTime dob, string streetAddress, string city, string state, string zip, string phone, string gender, string ssn, int userType)
        {

            try
            {
                using (SqlConnection connect = DBConnection.GetConnection())
                {
                    connect.Open();
                    string insertStmt = "INSERT INTO contact (lName, fName, dob, mailingAddressStreet, mailingAddressCity, mailingAddressState, mailingAddressZip, phoneNumber, gender, SSN, userType) " +
                        "VALUES (@last, @first, @dob, @street, @city, @state, @zip, @phone, @gender, @ssn, @userType)";
                    using (SqlCommand cmd = new SqlCommand(insertStmt, connect))
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
                        cmd.Parameters.AddWithValue("@userType", userType);
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
        public static bool checkPassword(string username, string enteredPassword)
        {
            bool isMatch = false;
            try
            {
                using (SqlConnection connect = DBConnection.GetConnection())
                {

                    string selectStmt = "SELECT password FROM logins WHERE userName = @username";
                    connect.Open();

                   // connect.Open();
                  //  string selectStmt = "SELECT password FROM logins WHERE userName = @user";

                    using (SqlCommand cmd = new SqlCommand(selectStmt, connect))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string storedPassword = reader["password"].ToString();
                                if (enteredPassword == storedPassword)
                                {
                                    isMatch = true;
                                }
                                else
                                {
                                    isMatch = false;
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                isMatch = false;
                return isMatch;
            }
            return isMatch;
        }

        public static Person GetLoggedInUserDetails (string username, string password)
        {
            Person user = new Person();
            string selectStatement = "SELECT logins.contactID, lName, fName, phoneNumber, mailingAddressStreet, "
                + "mailingAddressCity, mailingAddressState, mailingAddressZip, userType "
                + "FROM logins LEFT JOIN contact ON logins.contactID = contact.contactID "
                + "WHERE userName = @username AND password = @password";
            try
            {
                using (SqlConnection connection = DBConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@username", username);
                        selectCommand.Parameters.AddWithValue("@password", password);
                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                user.ContactID = (int)reader["contactID"];
                                user.LastName = reader["lName"].ToString();
                                user.FirstName = reader["fName"].ToString();
                                user.Phone = reader["phoneNumber"].ToString();
                                user.Address = reader["mailingAddressStreet"].ToString();
                                user.City = reader["mailingAddressCity"].ToString();
                                user.State = reader["mailingAddressState"].ToString();
                                user.Zip = reader["mailingAddressZip"].ToString();
                                user.UserType = (int)reader["userType"];
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
            return user;
        }



    }
}

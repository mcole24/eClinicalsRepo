using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eClinicals.Model;
using System.Data.SqlClient;

namespace eClinicals.DAL
{
    class AdminDAL
    {
        public static Admin GetAdminByID(int contactID)
        {
            Admin admin = new Admin();
            try
            {
                using (SqlConnection connect = DBConnection.GetConnection())
                {
                    connect.Open();
                    string selStmt = "SELECT * FROM contact INNER JOIN admin ON contact.contactID = admin.contactID WHERE admin.contactID = @contactID";
                    using (SqlCommand cmd = new SqlCommand(selStmt, connect))
                    {
                        cmd.Parameters.AddWithValue("@contactID", contactID);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                admin.AdminID = (int)reader["adminID"];
                                admin.ContactID = (int)reader["contactID"];
                                admin.LastName = reader["lName"].ToString();
                                admin.FirstName = reader["fName"].ToString();
                                admin.Dob = (DateTime)reader["dob"];
                                admin.Address = reader["mailingAddressStreet"].ToString();
                                admin.City = reader["mailingAddressCity"].ToString();
                                admin.State = reader["mailingAddressState"].ToString();
                                admin.Zip = reader["mailingAddressZip"].ToString();
                                admin.Phone = reader["phoneNumber"].ToString();
                                admin.Gender = reader["gender"].ToString();
                                admin.Ssn = reader["ssn"].ToString();
                                admin.UserName = reader["username"].ToString();
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
            return admin;
        }

        public static Report MostPerformedTestsDuringDates(DateTime startDate, DateTime endDate)
        {
            Report report = new Report();
            try
            {
                using (SqlConnection connect = DBConnection.GetConnection())
                {
                    connect.Open();
                    string selStmt = "SELECT lab.testCode AS test_code, test.testType AS test_name, COUNT(lab.testCode) AS times_performed, COUNT(lab.testID) AS total_tests, "
                    + "CAST(COUNT(lab.testCode / lab.testID) * 10 AS DECIMAL(10, 2)) percentage_of_tests, "
                    + "SUM(case when lab.result = 0 then 1 else 0 end) as 'normal_results', "
                    + "SUM(case when lab.result = 1 then 1 else 0 end) as 'abnormal_results', "
                    + "CAST(SUM(case when datediff(DAY, contact.dob, lab.testDateCompleted) / 365 BETWEEN 18 and 29 then 1 else 0 end) AS DECIMAL(10, 2)) AS 'patients_under_30', "
                    + "CAST(SUM(case when datediff(DAY, contact.dob, lab.testDateCompleted) / 365 BETWEEN 30 and 150 then 1 else 0 end) AS DECIMAL(10, 2)) AS 'patients_over_30' "
                    + "FROM Visit_Lab_Test lab "
                    + "JOIN Lab_Test test "
                    + "ON test.testCode = lab.testCode "
                    + "JOIN visit "
                    + "ON lab.visitID = visit.visitID "
                    + "JOIN appointment "
                    + "ON visit.appointmentID = appointment.appointmentID "
                    + "JOIN patient "
                    + "ON appointment.patientID = patient.patientID "
                    + "JOIN contact "
                    + "ON patient.contactID = contact.contactID "
                    + "WHERE lab.testDateCompleted BETWEEN @startDate AND '@endDate' "
                    + "GROUP BY lab.testCode, test.testType "
                    + "HAVING COUNT(lab.testCode) >= 2 "
                    + "ORDER BY times_performed DESC, lab.testCode DESC";
                    using (SqlCommand cmd = new SqlCommand(selStmt, connect))
                    {
                        cmd.Parameters.AddWithValue("@startDate", startDate);
                        cmd.Parameters.AddWithValue("@endDate", endDate);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                report.TestCode = (int)reader["test_code"];
                                report.TestName = reader["test_name"].ToString();
                                report.TimesPerformed = (int)reader["times_performed"];
                                report.TotalTests = (int)reader["total_tests"];
                                report.PercentageOfTests = (decimal)reader["percentage_of_tests"];
                                report.NormalResults = (int)reader["normal_results"];
                                report.AbnormalResults = (int)reader["abnormal_results"];
                                report.PatientsUnder30 = (decimal)reader["patients_under_30"];
                                report.PatientsOver30 = (decimal)reader["patients_over_30"];
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
            return report;
        }


    }
}

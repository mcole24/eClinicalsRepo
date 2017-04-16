using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eClinicals.Model;
using System.Data.SqlClient;

namespace eClinicals.DAL
{
    class LabTestDAL
    {

        public static List<LabTest> GetAllTests()
        {
            List<LabTest> testList = new List<LabTest>();
            string selectStmt = "SELECT testCode, testType FROM lab_test";
            try
            {
                using (SqlConnection connect = DBConnection.GetConnection())
                {
                    connect.Open();
                    using (SqlCommand cmd = new SqlCommand(selectStmt, connect))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                LabTest labTest = new LabTest();
                                labTest.TestID = (int)reader["testCode"];
                                labTest.TestName = reader["testType"].ToString();
                                testList.Add(labTest);
                            }
                            reader.Close();
                        }
                    }
                    connect.Close();
                }
                return testList;
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


        public static List<LabTest> GetTestResults(int patientID)
        {
            List<LabTest> testResultsList = new List<LabTest>();
            string selectStatement = "SELECT testID, lab_test.testCode, testType, result, testDateCompleted "
                + "FROM appointment "
                + "JOIN visit ON appointment.appointmentID = visit.appointmentID "
                + "JOIN visit_lab_test ON visit.visitID = visit_lab_test.visitID "
                + "JOIN lab_test ON visit_lab_test.testCode = lab_test.testCode "
                + "WHERE patientID = @patientID";
            try
            {
                using (SqlConnection connection = DBConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@patientID", patientID);
                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                LabTest testResult = new LabTest();
                                testResult.TestID = (int)reader["testID"];
                                testResult.TestCode = (int)reader["testCode"];
                                testResult.TestName = reader["testType"].ToString();
                                testResult.ResultRecorded = (bool)reader["result"];
                                if (testResult.ResultRecorded == true)
                                    testResult.TestResult = "positive";
                                else
                                    testResult.TestResult = "negative";
                                testResult.PerformedDate = (DateTime)reader["testDateCompleted"];
                                testResultsList.Add(testResult);
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
            return testResultsList;
        }

        public static bool UpdateResult(int testID, DateTime performedDate, int result)
        {
            bool isUpdated = false;
            string updateStmt = "UPDATE visit_lab_test "
                    + "SET testDateCompleted = @performedDate, result = @result "
                    + "WHERE testID = @testID";
            try
            {
                using (SqlConnection connect = DBConnection.GetConnection())
                {
                    connect.Open();
                    using (SqlCommand cmd = new SqlCommand(updateStmt, connect))
                    {
                        cmd.Parameters.AddWithValue("@testID", testID);
                        cmd.Parameters.AddWithValue("@performedDate", performedDate);
                        cmd.Parameters.AddWithValue("@result", result);
                        
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

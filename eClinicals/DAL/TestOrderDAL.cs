using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using eClinicals.DAL;
using eClinicals.Model;

namespace eClinicals.DAL
{
    class TestOrderDAL
    {

        public static int OrderTest(TestOrder testOrdered, int visitID)
        {
            string insertStmt = "INSERT INTO visit_lab_test (testCode, visitID, testDateCompleted) " + 
                "VALUES (@code, @vID, @dateCompleted)";
            try
            {
                using (SqlConnection connect = DBConnection.GetConnection())
                {
                    connect.Open();
                    using (SqlCommand cmd = new SqlCommand(insertStmt, connect))
                    {
                        cmd.Parameters.AddWithValue("@code", testOrdered.TestCode);
                        cmd.Parameters.AddWithValue("@vID", visitID);
                        cmd.Parameters.AddWithValue("@result", testOrdered.Result);
                        cmd.Parameters.AddWithValue("@dateCompleted", testOrdered.DateCompleted);
                        cmd.ExecuteNonQuery();
                        SqlCommand idCmd = new SqlCommand();
                        idCmd.Connection = connect;
                        idCmd.CommandText = "SELECT IDENT_CURRENT('testID') FROM visit_lab_test";
                        int testID = Convert.ToInt32(idCmd.ExecuteScalar());
                        connect.Close();
                        return testID;
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
        }



        public static TestOrder GetTestByID(int testID)
        {
            TestOrder orderedTest = new Model.TestOrder();
            string selectStmt = "SELECT testID, testCode, visitID, result, testDateCompleted FROM visit_lab_test WHERE testID = @testID";
            try
            {
                using (SqlConnection connect = DBConnection.GetConnection())
                {
                    connect.Open();
                    using (SqlCommand cmd = new SqlCommand(selectStmt, connect))
                    {
                        cmd.Parameters.AddWithValue("@testID", testID);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                orderedTest.TestID = (int)reader["testID"];
                                orderedTest.TestCode = reader["testCode"].ToString();
                                orderedTest.VisitID = (int)reader["visitID"];
                                orderedTest.Result = (Boolean)reader["result"];
                                orderedTest.DateCompleted = (DateTime)reader["testDateCompleted"];

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
            return orderedTest;
        }



        public static List<TestOrder> GetAllOrders(int visitID)
        {
            List<TestOrder> orderList = new List<TestOrder>();
            string selectStmt = "SELECT vlt.testID, vlt.testCode, vlt.visitID, lt.testType FROM visit_lab_test vlt " + 
                "INNER JOIN lab_test lt ON vlt.testCode = lt.testCode" +
                " WHERE vlt.visitID = @visitID ORDER BY vlt.testID ASC";
            try
            {
                using (SqlConnection connect = DBConnection.GetConnection())
                {
                    connect.Open();
                    using (SqlCommand cmd = new SqlCommand(selectStmt, connect))
                    {
                        cmd.Parameters.AddWithValue("@visitID", visitID);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                TestOrder newOrder = new TestOrder();
                                newOrder.TestID = (int)reader["vlt.testID"];
                                newOrder.TestCode = reader["vlt.testCode"].ToString();
                                newOrder.VisitID = (int)reader["vlt.visitID"];
                                newOrder.TestType = reader["lt.testType"].ToString();
                                orderList.Add(newOrder);
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
            return orderList;
        }



    }
}

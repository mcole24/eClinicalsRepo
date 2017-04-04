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
                                labTest.Test = reader["testType"].ToString();
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


    }
}

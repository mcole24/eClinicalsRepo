using eClinicals.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eClinicals.DAL
{
    class VisitDAL
    {
        public static List<RoutineCheck> GetPreviousReadings(int patientID)
        {
            List<RoutineCheck> checkResultList = new List<RoutineCheck>();
            string selectStatement = "SELECT visitTime, systolicBP, diastolicBP, bodyTemperature, pulse, symptomType "
            + "FROM visit LEFT JOIN Appointment ON visit.appointmentID = appointment.appointmentID "
            + "JOIN visit_symptom ON visit.visitID = visit_symptom.visitID "
            + "JOIN symptom ON visit_symptom.symptomID = symptom.symptomID "
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
                                RoutineCheck checkResults = new RoutineCheck();
                                checkResults.VisitDate = (DateTime)reader["visitTime"];
                                checkResults.DiastolicBP = (int)reader["diastolicBP"];
                                checkResults.SystolicBP = (int)reader["systolicBP"];
                                checkResults.BodyTemperature = (decimal)reader["bodyTemperature"];
                                checkResults.Pulse = (int)reader["pulse"];
                                checkResults.Symptom = reader["symptomType"].ToString();
                                checkResultList.Add(checkResults);
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
            return checkResultList;
        }

        public static List<LabTest> GetTestResults(int patientID)
        {
            List<LabTest> testResultsList = new List<LabTest>();
            string selectStatement = "SELECT testID, testDateCompleted, testType, initialDiagnosis, finalDiagnosis, diagnosisType, lName "
            + "FROM appointment JOIN visit ON appointment.appointmentID = visit.appointmentID "
            + "JOIN visit_lab_test ON visit.visitID = visit_lab_test.visitID "
            + "JOIN lab_test ON visit_lab_test.testCode = lab_test.testCode "
            + "JOIN visit_has_diagnosis ON visit_lab_test.visitID = visit_has_diagnosis.visitID "
            + "JOIN diagnosis ON visit_has_diagnosis.diagnosisID = diagnosis.diagnosisID "
            + "JOIN doctor ON appointment.doctorID = doctor.doctorID "
            + "JOIN contact ON doctor.contactID = contact.contactID "
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
                                testResult.PerformedDate = (DateTime)reader["testDateCompleted"];
                                testResult.Test = reader["testType"].ToString();
                                testResult.InitialDiagnosis = (int)reader["initialDiagnosis"];
                                testResult.FinalDiagnosis = (int)reader["finalDiagnosis"];
                                testResult.DiagnosisType = reader["diagnosisType"].ToString();
                                testResult.Doctor = reader["lName"].ToString();
                           
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


        public static bool CreateCheckup(int appointmentID, int nurseID, DateTime visitTime, int systolicBP, int diastolicBP, decimal bodyTemp, int pulse)
        {
            string insertStmt = "INSERT INTO visit (appointmentID, nurseID, visitTime, systolicBP, diastolicBP, bodyTemperature, pulse) VALUES " + 
                "(@appID, @nurseID, @time, @sBP, @dBP, @temp, @pulse)";

            try
            {
                using (SqlConnection connect = DBConnection.GetConnection())
                {
                    connect.Open();
                    using (SqlCommand cmd = new SqlCommand(insertStmt, connect))
                    {
                        cmd.Parameters.AddWithValue("@appID", appointmentID);
                        cmd.Parameters.AddWithValue("@nurseID", nurseID);
                        cmd.Parameters.AddWithValue("@time", visitTime);
                        cmd.Parameters.AddWithValue("@sBP", systolicBP);
                        cmd.Parameters.AddWithValue("@dBP", diastolicBP);
                        cmd.Parameters.AddWithValue("@temp", bodyTemp);
                        cmd.Parameters.AddWithValue("@pulse", pulse);
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


        public static List<Symptom> GetAllSymptoms()
        {
            List<Symptom> symptomList = new List<Symptom>();
            string selectStmt = "SELECT symptomID, symptomType FROM symptom";
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
                                Symptom symptom = new Symptom();
                                symptom.SymptomID = (int)reader["symptomID"];
                                symptom.SymptomType = reader["symptomType"].ToString();
                                symptomList.Add(symptom);
                            }
                            reader.Close();
                        }
                    }
                    connect.Close();
                }
                return symptomList;
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
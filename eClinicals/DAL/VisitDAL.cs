﻿using eClinicals.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

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
            + "WHERE patientID = @patientID AND visitTime < GETDATE()";
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
                                checkResults.SystolicBP = (int)reader["systolicBP"];
                                checkResults.DiastolicBP = (int)reader["diastolicBP"];
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

        public static bool CreateCheckup(int appointmentID, int nurseID, int systolicBP, int diastolicBP, decimal bodyTemp, int pulse, List<int> symptomList)
        {
            int visitID = 0;

            string insertStmt1 = "IF NOT EXISTS (SELECT appointmentID FROM visit WHERE appointmentID = @appID) " +
                "INSERT INTO visit (appointmentID, nurseID, visitTime, systolicBP, diastolicBP, bodyTemperature, pulse) VALUES " +
                "(@appID, @nurseID, @time, @sBP, @dBP, @temp, @pulse)";


            string selStmt = "SELECT MAX(visitID) AS MaxVisitID FROM visit";

            string insertStmt2 = "IF NOT EXISTS (SELECT visitID FROM visit_symptom WHERE visitID = @visit AND symptomID = @symptom) " +
                "INSERT INTO visit_symptom (visitID, symptomID) VALUES (@visit, @symptom)";


            using (SqlConnection connect = DBConnection.GetConnection())
            {
                connect.Open();
                SqlTransaction tran = connect.BeginTransaction();

                try
                {

                    using (SqlCommand cmd = new SqlCommand(insertStmt1, connect, tran))
                    {
                        cmd.Parameters.AddWithValue("@appID", appointmentID);
                        cmd.Parameters.AddWithValue("@nurseID", nurseID);
                        cmd.Parameters.AddWithValue("@time", DateTime.Now);
                        cmd.Parameters.AddWithValue("@sBP", systolicBP);
                        cmd.Parameters.AddWithValue("@dBP", diastolicBP);
                        cmd.Parameters.AddWithValue("@temp", bodyTemp);
                        cmd.Parameters.AddWithValue("@pulse", pulse);
                        cmd.ExecuteNonQuery();
                    }

                    using (SqlCommand cmd = new SqlCommand(selStmt, connect, tran))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                visitID = (int)reader["MaxVisitID"];
                            }
                        }
                    }

                    if (visitID > 0)
                    {
                        for (int i = 0; i < symptomList.Count; i++)
                        {
                            using (SqlCommand cmd = new SqlCommand(insertStmt2, connect, tran))
                            {
                                cmd.Parameters.AddWithValue("@visit", visitID);
                                cmd.Parameters.AddWithValue("@symptom", symptomList[i]);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    tran.Commit();
                    connect.Close();
                    return true;

                }
                catch
                {
                    tran.Rollback();
                    return false;
                }
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

        public static List<Diagnosis> GetAllDiagnosis()
        {
            List<Diagnosis> diagnosisList = new List<Diagnosis>();
            string selectStmt = "SELECT diagnosisID, diagnosisType FROM diagnosis";
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
                                Diagnosis diagnosis = new Diagnosis();
                                diagnosis.DiagnosisID = (int)reader["diagnosisID"];
                                diagnosis.DiagnosisName = reader["diagnosisType"].ToString();
                                diagnosisList.Add(diagnosis);
                            }
                            reader.Close();
                        }
                    }
                    connect.Close();
                }
                return diagnosisList;
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

        public static bool addInitialDiagnosis(int visitID, int diagnosisID, int initialDiagnosis)
        {
            try
            {
                using (SqlConnection connect = DBConnection.GetConnection())
                {
                    connect.Open();
                    string insertStmt = "INSERT INTO appointment (visitID, diagnosisID, initialDiagnosis, finalDiagnosis) "
                        + "VALUES (@visitID, @diagnosisID, @initialDiagnosis, 0)";

                    using (SqlCommand cmd = new SqlCommand(insertStmt, connect))
                    {
                        cmd.Parameters.AddWithValue("@visitID", visitID);
                        cmd.Parameters.AddWithValue("@diagnosisID", diagnosisID);
                        cmd.Parameters.AddWithValue("@initialDiagnosis", initialDiagnosis);
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


        public static bool addFinalDiagnosis(int visitID, int diagnosisID, int finalDiagnosis)
        {
            try
            {
                using (SqlConnection connect = DBConnection.GetConnection())
                {
                    connect.Open();
                    string insertStmt = "INSERT INTO appointment (visitID, diagnosisID, initialDiagnosis, finalDiagnosis) "
                        + "VALUES (@visitID, @diagnosisID, 0, @finalDiagnosis)";

                    using (SqlCommand cmd = new SqlCommand(insertStmt, connect))
                    {
                        cmd.Parameters.AddWithValue("@visitID", visitID);
                        cmd.Parameters.AddWithValue("@diagnosisID", diagnosisID);
                        cmd.Parameters.AddWithValue("@finalDiagnosis", finalDiagnosis);
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

    }
}
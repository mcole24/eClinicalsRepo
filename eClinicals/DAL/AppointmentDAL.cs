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
    class AppointmentDAL
    {

        public static bool CreateAppointment(DateTime appointmentDate, int patientID, int doctorID)
        {

            try
            {
                using (SqlConnection connect = DBConnection.GetConnection())
                {
                    connect.Open();
                    string insertStmt = "INSERT INTO appointment (appointmentDate, patientID, doctorID) " + 
                        "VALUES (@appDate, @pID, @dID);";
                    using (SqlCommand cmd = new SqlCommand(insertStmt, connect))
                    {
                        cmd.Parameters.AddWithValue("@appDate", appointmentDate);
                        cmd.Parameters.AddWithValue("@pID", patientID);
                        cmd.Parameters.AddWithValue("@dID", doctorID);
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



        public static bool DeleteAppointment(int appointmentID)
        {
            try
            {
                using (SqlConnection connect = DBConnection.GetConnection())
                {
                    connect.Open();
                    string delStmt = "DELETE FROM appointment WHERE appointmentID = @id";
                    using (SqlCommand cmd = new SqlCommand(delStmt, connect))
                    {
                        cmd.Parameters.AddWithValue("@id", appointmentID);
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


        public static Appointment GetAppointmentByID(int appointmentID)
        {
            Appointment appointment = new Appointment();
            try
            {
                using (SqlConnection connect = DBConnection.GetConnection())
                {
                    connect.Open();
                    string selStmt = "SELECT * FROM appointment WHERE appointmentID = @appointmentID";
                    using (SqlCommand cmd = new SqlCommand(selStmt, connect))
                    {
                        cmd.Parameters.AddWithValue("@appointmentID", appointmentID);
                        connect.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                appointment.AppointmentDate = (DateTime)reader["appointmentDate"];
                                appointment.PatientID = (int)reader["patientID"];
                                appointment.DoctorID = (int)reader["doctorID"];
                            }
                        }
                        connect.Close();
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
            return appointment;
        }

        public static List<Appointment> GetAppointmentsByPatientID(int patientID)
        {
            List<Appointment> appointmentList = new List<Appointment>();
            string selectStatement = "SELECT appointmentDate, appointment_reason.appointmentReason, contact.lName "
                + "FROM Patient LEFT JOIN Appointment ON Patient.patientID = Appointment.PatientID " 
                + "JOIN appointment_reason_for_visit ON Appointment.appointmentID = appointment_reason_for_visit.appointmentID "
                + "JOIN appointment_reason ON appointment_reason_for_visit.appointmentReasonID = appointment_reason.appointmentReasonID "
                + "JOIN doctor ON appointment.doctorID = doctor.doctorID "
                + "JOIN contact ON doctor.contactID = contact.contactID "
                + "WHERE Patient.patientID = @patientID";
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
                                
                                Appointment appointment = new Appointment();
                                appointment.AppointmentDate = (DateTime)reader["appointmentDate"];
                                appointment.AppointmentReason = reader["appointmentReason"].ToString();
                                appointment.AppointmentDoctor = reader["lName"].ToString();
                                appointmentList.Add(appointment);
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
            return appointmentList;
        }

    }
}

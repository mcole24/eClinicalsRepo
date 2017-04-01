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
                    string insertStmt = "INSERT INTO appointment (appointmentDate, patientID, doctorID) " + 
                        "VALUES (@appDate, @pID, @dID);";
                    using (SqlCommand cmd = new SqlCommand(insertStmt, connect))
                    {
                        cmd.Parameters.AddWithValue("@appDate", appointmentDate);
                        cmd.Parameters.AddWithValue("@pID", patientID);
                        cmd.Parameters.AddWithValue("@dID", doctorID);
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



        public static bool DeleteAppointment(int appointmentID)
        {
            try
            {
                using (SqlConnection connect = DBConnection.GetConnection())
                {
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








    }
}

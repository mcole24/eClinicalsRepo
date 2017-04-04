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
                                admin.Phone = reader["phone"].ToString();
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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VTourAPI.Models;
using System.Data;
using System.Data.SqlClient;

namespace VTourAPI.Repositories
{
    public class UserRepository
    {
        // Server=myServerAddress;Database=myDataBase;Trusted_Connection=True;

        string server = "THESPANISHINQUI";
        string database = "TourDB";

        string connectionString;

        public UserRepository ()
        {
            connectionString = "Server=" + server + "; Database=" + database + "; Trusted_Connection=True;";
        }

        public void CreateUser(User user)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;

                using (SqlCommand cmd = new SqlCommand("Createuser", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = user.Id;
                    cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = user.Email;
                    cmd.Parameters.Add("@Phonenumber", SqlDbType.VarChar).Value = user.PhoneNumber;
                    cmd.Parameters.Add("@UserPassword", SqlDbType.VarChar).Value = user.Password;
                    cmd.Parameters.Add("@Firstname", SqlDbType.VarChar).Value = user.FirstName;
                    cmd.Parameters.Add("@Surname", SqlDbType.VarChar).Value = user.Surname;
                    cmd.Parameters.Add("@PostalCode", SqlDbType.Int).Value = user.PostalCode;
                    cmd.Parameters.Add("@StreetAddress", SqlDbType.VarChar).Value = user.StreetAddress;

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }


            }
        }
    }
}

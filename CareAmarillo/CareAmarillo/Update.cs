using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data.Sql;

namespace CareAmarillo
{
    class Update
    {
        static SqlConnection connection = new SqlConnection();
        public Update()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.ConnectionString = "Server=cis1.actx.edu;Database=project1;User Id=db1;Password=db10;";
                connection.Open();
            }
        }

        public void UpdateAUser(string userID, string password, string fName, string lName, string email, string phone)
        {
            using (SqlCommand updateProf = connection.CreateCommand())
            {
                updateProf.CommandText = "update LogOn set Password = @password where ID = @userID ";
                updateProf.CommandText += "update Person set FirstName = @firstName where UserID = @userID ";
                updateProf.CommandText += "update Person set LastName = @lastName where UserID = @userID ";
                updateProf.CommandText += "update Person set Email = @email where UserID = @userID ";
                updateProf.CommandText += "update Person set Phone = @phone where UserID = @userID;";
                updateProf.Parameters.Add(new SqlParameter("Password", password));
                updateProf.Parameters.Add(new SqlParameter("firstName", fName));
                updateProf.Parameters.Add(new SqlParameter("lastName", lName));
                updateProf.Parameters.Add(new SqlParameter("email", email));
                updateProf.Parameters.Add(new SqlParameter("phone", phone));
                updateProf.Parameters.Add(new SqlParameter("userID", userID));
                updateProf.ExecuteNonQuery();
            }
        }

        public void DeleteAUser(string userID)
        {
            using (SqlCommand deleteUser = connection.CreateCommand())
            {
                deleteUser.CommandText = "delete from LogOn where ID = @ID;";
                deleteUser.Parameters.Add(new SqlParameter("ID", userID));
                deleteUser.ExecuteNonQuery();
            }
            using (SqlCommand deleteUser = connection.CreateCommand())
            {
                deleteUser.CommandText = "delete from Person where UserID = @userID;";
                deleteUser.Parameters.Add(new SqlParameter("userID", userID));
                deleteUser.ExecuteNonQuery();
            }
        }
    }
}

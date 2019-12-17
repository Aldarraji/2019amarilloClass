using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data.Sql;

namespace CareAmarillo
{
    class Add
    {
        static SqlConnection connection = new SqlConnection();
        public Add()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.ConnectionString = "Server=cis1.actx.edu;Database=project1;User Id=db1;Password=db10;";
                connection.Open();
            }
        }

        private void AddHumanService(string fName, string lName, string email, string userID, string password)
        {
            using (SqlCommand insertNewProvider = connection.CreateCommand())
            {
                insertNewProvider.CommandText = "insert into LogOn values (@ID, @Password);";
                insertNewProvider.Parameters.Add(new SqlParameter("ID", userID));
                insertNewProvider.Parameters.Add(new SqlParameter("Password", password));
                insertNewProvider.ExecuteNonQuery();
            }
            using (SqlCommand insertNewProvider = connection.CreateCommand())
            {
                insertNewProvider.CommandText = "insert into Person values (@UserID, @FirstName, @LastName, @Email, @TypeID, @UserID, @ShelterID, @Password);";
                insertNewProvider.Parameters.Add(new SqlParameter("FirstName", fName));
                insertNewProvider.Parameters.Add(new SqlParameter("LastName", lName));
                insertNewProvider.Parameters.Add(new SqlParameter("Email", email));
                insertNewProvider.Parameters.Add(new SqlParameter("TypeID", 3));
                insertNewProvider.Parameters.Add(new SqlParameter("UserID", userID));
                insertNewProvider.Parameters.Add(new SqlParameter("Password", password));
                insertNewProvider.ExecuteNonQuery();
            }
        }

        private void AddProvider(string name, string address, string zipCode, string city, string state, string phone, string email, string bedVacancy)
        {
            using (SqlCommand insertNewProvider = connection.CreateCommand())
            {
                insertNewProvider.CommandText = "insert into Shelter values (@Name, @Address, @ZipCode, @City, @State, @Phone, @Email, @BedVacancy);";
                insertNewProvider.Parameters.Add(new SqlParameter("Name", name));
                insertNewProvider.Parameters.Add(new SqlParameter("Address", address));
                insertNewProvider.Parameters.Add(new SqlParameter("ZipCode", zipCode));
                insertNewProvider.Parameters.Add(new SqlParameter("City", city));
                insertNewProvider.Parameters.Add(new SqlParameter("State", state));
                insertNewProvider.Parameters.Add(new SqlParameter("Phone", phone));
                insertNewProvider.Parameters.Add(new SqlParameter("Email", email));
                insertNewProvider.Parameters.Add(new SqlParameter("BedVacancy", bedVacancy));
                insertNewProvider.ExecuteNonQuery();
            }
        }
    }
}

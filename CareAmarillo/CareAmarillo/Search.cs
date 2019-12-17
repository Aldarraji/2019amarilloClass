using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data.Sql;

namespace CareAmarillo
{
    class Search
    {
        static SqlConnection connection = new SqlConnection();
        public Search()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.ConnectionString = "Server=cis1.actx.edu;Database=project1;User Id=db1;Password=db10;";
                connection.Open();
            }
        }

        public string FindFirstName(string firstName)
        {
            string rec = "";
            using (SqlCommand FindFirstNameRecord = connection.CreateCommand())
            {
                FindFirstNameRecord.CommandText = "select FirstName from Person where FirstName like @firstName;";


                FindFirstNameRecord.Parameters.Add(new SqlParameter("firstName", "%" + firstName + "%"));

                // The using block for handling the IO
                using (SqlDataReader reader = FindFirstNameRecord.ExecuteReader())
                {
                    // a dictionary to store the ordinal positions of each column in the table.
                    Dictionary<string, int> columnNames = new Dictionary<string, int>();

                    // Actually building the above dictionary. This should be done outside of any data-read loop for 
                    // performance reasons.
                    var columns = Enumerable.Range(0, reader.FieldCount).Select(reader.GetName).ToList();
                    foreach (var columnName in columns)
                    {
                        columnNames.Add(columnName, reader.GetOrdinal(columnName.ToString()));
                    }

                    // Get the data you want from the SQL Select and do whatever you want with it.
                    while (reader.Read())
                    {
                        rec += reader.GetFieldValue<string>(columnNames["FirstName"]);
                    }
                }
            }
            return rec;

        }

        public string FindAShelter(string shelterName)
        {
            string rec = "";
            using (SqlCommand FindAShelterRecord = connection.CreateCommand())
            {
                FindAShelterRecord.CommandText = "select * from Shelter where Name like @ShelterName;";

                FindAShelterRecord.Parameters.Add(new SqlParameter("ShelterName", "%" + shelterName + "%"));

                // The using block for handling the IO
                using (SqlDataReader reader = FindAShelterRecord.ExecuteReader())
                {
                    // a dictionary to store the ordinal positions of each column in the table.
                    Dictionary<string, int> columnNames = new Dictionary<string, int>();

                    // Actually building the above dictionary. This should be done outside of any data-read loop for 
                    // performance reasons.
                    var columns = Enumerable.Range(0, reader.FieldCount).Select(reader.GetName).ToList();
                    foreach (var columnName in columns)
                    {
                        columnNames.Add(columnName, reader.GetOrdinal(columnName.ToString()));
                    }

                    // Get the data you want from the SQL Select and do whatever you want with it.
                    while (reader.Read())
                    {
                        rec += "Name:       " + reader.GetFieldValue<string>(columnNames["Name"]) + " \n";
                        rec += "Phone:      " + reader.GetFieldValue<string>(columnNames["Phone"]) + " \n";
                        rec += "Email:        " + reader.GetFieldValue<string>(columnNames["Email"]) + " \n";
                        rec += "Vacancy:   " + reader.GetFieldValue<int>(columnNames["BedVacancy"]) + " \n";
                        rec += "Address:   " + reader.GetFieldValue<string>(columnNames["Address"]) + " \n";
                        rec += "City:          " + reader.GetFieldValue<string>(columnNames["City"]) + " \n";
                        rec += "Zipcode:   " + reader.GetFieldValue<int>(columnNames["ZipCode"]) + " \n";
                        rec += "State:        " + reader.GetFieldValue<string>(columnNames["State"]) + " \n";
                        rec += " \n";
                    }
                }
            }
            return rec;
        }

        public string FindAUser(string userID)
        {
            string rec = "";
            using (SqlCommand FindAUserRecord = connection.CreateCommand())
            {
                FindAUserRecord.CommandText = "select * from Person where UserID like @UserID;";

                FindAUserRecord.Parameters.Add(new SqlParameter("UserID", userID));

                // The using block for handling the IO
                using (SqlDataReader reader = FindAUserRecord.ExecuteReader())
                {
                    // a dictionary to store the ordinal positions of each column in the table.
                    Dictionary<string, int> columnNames = new Dictionary<string, int>();

                    // Actually building the above dictionary. This should be done outside of any data-read loop for 
                    // performance reasons.
                    var columns = Enumerable.Range(0, reader.FieldCount).Select(reader.GetName).ToList();
                    foreach (var columnName in columns)
                    {
                        columnNames.Add(columnName, reader.GetOrdinal(columnName.ToString()));
                    }

                    // Get the data you want from the SQL Select and do whatever you want with it.
                    while (reader.Read())
                    {
                        rec += reader.GetFieldValue<string>(columnNames["FirstName"]) + " \n";
                        rec += reader.GetFieldValue<string>(columnNames["MiddleName"]) + " \n";
                        rec += reader.GetFieldValue<string>(columnNames["LastName"]) + " \n";
                        rec += reader.GetFieldValue<int>(columnNames["Email"]) + " \n";
                        rec += reader.GetFieldValue<string>(columnNames["TypeID"]) + " \n";
                        rec += reader.GetFieldValue<string>(columnNames["UserID"]) + " \n";
                        rec += reader.GetFieldValue<int>(columnNames["ShelterID"]) + " \n";
                    }
                }
            }
            return rec;
        }

        public int FindUser(string id, string password)
        {
            int retunedPassNdID = 0;
            using (SqlCommand FindAIDRecord = connection.CreateCommand())
            {
                FindAIDRecord.CommandText = "select UserType.ID from LogOn inner join person on LogOn.ID = Person.UserID inner join UserType on Person.TypeID = UserType.ID where LogOn.ID = @ID and Password = @Password";
                FindAIDRecord.Parameters.Add(new SqlParameter("ID", id));
                FindAIDRecord.Parameters.Add(new SqlParameter("Password", password));

                // The using block for handling the IO
                using (SqlDataReader reader = FindAIDRecord.ExecuteReader())
                {
                    // a dictionary to store the ordinal positions of each column in the table.
                    Dictionary<string, int> columnNames = new Dictionary<string, int>();

                    // Actually building the above dictionary. This should be done outside of any data-read loop for 
                    // performance reasons.
                    var columns = Enumerable.Range(0, reader.FieldCount).Select(reader.GetName).ToList();
                    foreach (var columnName in columns)
                    {
                        columnNames.Add(columnName, reader.GetOrdinal(columnName.ToString()));
                    }

                    // Get the data you want from the SQL Select and do whatever you want with it.
                    while (reader.Read())
                    {
                        retunedPassNdID = reader.GetFieldValue<int>(columnNames["ID"]);
                    }
                }
            }
            return retunedPassNdID; //need to only return the ID, what type of user
        }
    }
}

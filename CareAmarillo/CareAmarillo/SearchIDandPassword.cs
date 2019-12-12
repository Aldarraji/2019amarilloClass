using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data.Sql;

namespace CareAmarillo
{
    class SearchIDandPassword
    {
        static SqlConnection connection = new SqlConnection();
        public SearchIDandPassword()
        {
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project1;User Id=db1;Password=db10;";
            connection.Open();
        }

        public int FindUser(String id, String password )
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

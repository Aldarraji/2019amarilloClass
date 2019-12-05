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
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project1;User Id=db1;Password=db10;";
            connection.Open();
            Console.WriteLine(connection.ServerVersion);
            Console.ReadKey();
        }

        public String FindAShelter(String shelterName)
        {
            string rec = "";
            using (SqlCommand FindAShelterRecord = connection.CreateCommand())
            {
                FindAShelterRecord.CommandText = "select * from db_owner.Shelter where Name like @ShelterName;";

                FindAShelterRecord.Parameters.Add(new SqlParameter("ShelterName", "%" + shelterName + "%"));

                // The using block for handling the IO
                using (SqlDataReader reader = FindAShelterRecord.ExecuteReader())
                {
                    // a dictionary to store the ordinal positions of each column in the table.
                    Dictionary<string, int> columnNames = new Dictionary<string, int>();

                    // Actually building the above dictionary. This should be done outside of any data-read loop for performance reasons.
                    foreach (string columnName in reader.GetSchemaTable().Columns)
                    {
                        columnNames.Add(columnName, reader.GetOrdinal(columnName));
                    }

                    // Get the data you want from the SQL Select and do whatever you want with it.
                    while (reader.Read())
                    {
                        rec = reader.GetFieldValue<string>(columnNames["Name"]) + " ";
                        rec += reader.GetFieldValue<string>(columnNames["Phone"]) + " ";
                        rec += reader.GetFieldValue<string>(columnNames["Email"]) + " \n";
                        rec += reader.GetFieldValue<string>(columnNames["BedVacancy"]) + " \n";
                        rec += reader.GetFieldValue<string>(columnNames["Address"]) + " ";
                        rec += reader.GetFieldValue<string>(columnNames["City"]) + " ";
                        rec += reader.GetFieldValue<string>(columnNames["ZipCode"]) + " ";
                        rec += reader.GetFieldValue<string>(columnNames["State"]) + " \n";
                        rec += "\n";
                    }
                }
            }
            return rec;
        }
    }
}

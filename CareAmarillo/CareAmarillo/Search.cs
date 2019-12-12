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
            //Console.WriteLine(connection.ServerVersion);
            //Console.ReadKey();
        }

        public String FindAShelter(String shelterName)
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
                        rec += "Name: " + reader.GetFieldValue<string>(columnNames["Name"]) + " \n";
                        rec += "Phone: " + reader.GetFieldValue<string>(columnNames["Phone"]) + " \n";
                        rec += "Email: " + reader.GetFieldValue<string>(columnNames["Email"]) + " \n";
                        rec += "Vacancy: " + reader.GetFieldValue<int>(columnNames["BedVacancy"]) + " \n";
                        rec += "Address: " + reader.GetFieldValue<string>(columnNames["Address"]) + " \n";
                        rec += "City: " + reader.GetFieldValue<string>(columnNames["City"]) + " \n";
                        rec += "Zipcode: " + reader.GetFieldValue<int>(columnNames["ZipCode"]) + " \n";
                        rec += "State: " + reader.GetFieldValue<string>(columnNames["State"]) + " \n";
                    }
                }
            }
            return rec;
        }
    }
}

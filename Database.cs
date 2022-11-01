using System;
using Npgsql;

namespace SWE
{
    public class Database
    {

        private const string CONNECTION_STRING = "User ID=admin;Password=test1;Host=host.docker.internal;Port=5432;Database=postgres;Pooling=true;";

        static void Main(string[] args)
        {
            // Connect to a PostgreSQL database
            NpgsqlConnection conn = new NpgsqlConnection(CONNECTION_STRING);
            conn.Open();

            // Define a query returning a single row result set
            NpgsqlCommand command = new NpgsqlCommand("SELECT COUNT(*) FROM weatherhistory", conn);

            // Execute the query and obtain the value of the first column of the first row
            Int64 count = (Int64)command.ExecuteScalar();

            Console.Write("{0}\n", count);
            conn.Close();
        }

        public static int ReturnTemp()
        {
            // Connect to a PostgreSQL database
            NpgsqlConnection conn = new NpgsqlConnection(CONNECTION_STRING);
            conn.Open();

            // Define a query returning a single row result set
            NpgsqlCommand command = new NpgsqlCommand("SELECT temp FROM weatherhistory limit 1", conn);

            // Execute the query and obtain the value of the first column of the first row
            Int32 temp = (Int32)command.ExecuteScalar();

            return (int)temp;
            conn.Close();
        }

        public static DateTime ReturnDate()
        {
            // Connect to a PostgreSQL database
            NpgsqlConnection conn = new NpgsqlConnection(CONNECTION_STRING);
            conn.Open();

            // Define a query returning a single row result set
            NpgsqlCommand command = new NpgsqlCommand("SELECT date FROM weatherhistory limit 1", conn);

            // Execute the query and obtain the value of the first column of the first row
            DateTime date = (DateTime)command.ExecuteScalar();

            return date;
            conn.Close();
        }
    }
}

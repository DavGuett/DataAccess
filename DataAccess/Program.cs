using Microsoft.Data.SqlClient;
const string connectionString = "Server=localhost,1433;Database=balta;User ID=sa;Password=PBRy6aMwXyN7tq";

using(var connection = new SqlConnection(connectionString))
{
    Console.WriteLine("Connected");
}
Console.WriteLine("Hello, World!");
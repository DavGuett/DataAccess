using Dapper;
using DataAccess.Models;
using Microsoft.Data.SqlClient;
const string connectionString = "Server=localhost,1433;Database=balta;User ID=sa;Password=PBRy6aMwXyN7tq;Trusted_Connection=False; TrustServerCertificate=True";

using (var connection = new SqlConnection(connectionString))
{
   
}

static void ListCategories(SqlConnection connection)
{
    var categories = connection.Query<Category>("SELECT [Id], [Title] FROM [Category]");
    foreach (var item in categories)
    {
        Console.WriteLine($"{item.Id} - {item.Title}");
    }
}
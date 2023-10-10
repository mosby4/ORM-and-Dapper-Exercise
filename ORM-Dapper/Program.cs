using System.Data;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;



namespace ORM_Dapper
{
    public class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string connString = config.GetConnectionString("DefaultConnection");

            IDbConnection connection = new MySqlConnection(connString);

            var myRepo = new DapperDepartmentRepository(connection);

            var departments = myRepo.GetAllDepartments();

            foreach (var item in departments)
            {
                Console.WriteLine( $"{item.DepartmentID } {item.Name}");
            }
            var repo = new DapperProductRepository(connection);

            var products = repo.GetAllProducts();

            repo.CreateProduct("newstuff", 20, 1);

            foreach (var item in products)
            {
                Console.WriteLine($"{item.productID} {item.name} {item.price} {item.catagoryID}" +
                    $"{item.onSale} {item.StockLevel}");
            }
        }
    }
}

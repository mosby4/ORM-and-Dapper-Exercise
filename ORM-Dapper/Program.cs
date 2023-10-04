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

            IDbConnection conn = new MySqlConnection(connString);

            var myRepo = new DapperDepartmentRepository(conn);

            var departments = myRepo.GetAllDepartments();

            foreach (var item in departments)
            {
                Console.WriteLine( $"{item.DepartmentID } {item.Name}");
            }
            var repo = new DapperProductRepository(Connection);
            var products = repo.GetAllProducts();

            foreach (var item in products)
            {
                Console.WriteLine($"{item.productID} {item.name} {item.price} {item.catagoryID}" +
                    $"{item.onSale} {item.StockLevel}");
            }
        }
    }
}

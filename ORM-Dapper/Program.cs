﻿using System.Data;
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

        }
    }
}

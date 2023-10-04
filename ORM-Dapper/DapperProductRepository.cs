﻿using System;
using System.Data;
using Dapper;

namespace ORM_Dapper
{
	public class DapperProductRepository : IProductRepository
	{
        private readonly IDbConnection _connection;

        public DapperProductRepository(IDbConnection Connection)
		{
            _connection = Connection;
		}

        public IDbConnection Connection { get; set; }

        public void CreateProduct(string name, double price, int categoryID)
        {
            _connection.Query<Products>("Insert into ");
        }

        public IEnumerable<Products> GetAllProducts()
        {
            return _connection.Query<Products>("SELECT * FROM Departments;");
        }
    }
}

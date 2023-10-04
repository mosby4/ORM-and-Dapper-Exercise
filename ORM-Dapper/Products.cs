using System;
namespace ORM_Dapper
{
	public class Products
	{
		public int productID { get; set; }
		public string? name { get; set; }
		public double price { get; set; }
		public int catagoryID { get; set; }
		public int onSale { get; set; }
		public string? StockLevel { get; set; }


	}
}


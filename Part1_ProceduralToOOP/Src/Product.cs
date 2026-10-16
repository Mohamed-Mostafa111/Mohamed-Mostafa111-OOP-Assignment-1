using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce
{
	internal class Product
	{
		public readonly int Id;
		public string Name {get; set;}
		public decimal Price {get; set;}
		public int Stock { get; set;}
		public List<OrderLine> orderLines { get; set; } = new List<OrderLine>();
		private static int CounterId = 0;
		public Product()
		{
			Id=CounterId++;
		}
		public void AddProduct(string name, decimal price, int stock)
		{
			E_CommerceData.products.Add(new Product()
			{
				Name = name,
				Price = price,
				Stock = stock
			});
		}

		public Product SearchAboutProduct(int id)
		{
			foreach (var Product in E_CommerceData.products)
			{
				if (Product.Id == id)
				{
					return Product;
				}
			}
			return new Product();
		}
		public void PrintProducts()
		{
			Console.WriteLine($"=== PRODUCTS ({CounterId-1}) ===");
			foreach (var pro in E_CommerceData.products)
			{
				Console.WriteLine(pro);
			}
		}

		public override string ToString()
		{
			return $"#{Id} " +
				   $"{Name} " +
				   $"{Price} " +
				   $"{Stock} ";
		}
	}
}

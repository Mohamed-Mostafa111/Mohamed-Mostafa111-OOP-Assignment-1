using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce
{
	internal static class E_CommerceData
	{

		public static List<Customer> customers = new List<Customer>
		{
			new Customer { FirstName = "Magdy", LastName = "Khaled", Email = "magdy.mm302002@gmail.com", City = "Aswan" },
			new Customer { FirstName = "Ahmed", LastName = "Ali", Email = "ahmed.ali@gmail.com", City = "Cairo" },
			new Customer { FirstName = "Mohamed", LastName = "Hassan", Email = "mohamed.hassan@gmail.com", City = "Giza" },
			new Customer { FirstName = "Omar", LastName = "Mahmoud", Email = "omar.mahmoud@gmail.com", City = "Alexandria" },
			new Customer { FirstName = "Youssef", LastName = "Ibrahim", Email = "youssef.ibrahim@gmail.com", City = "Fayoum" },
			new Customer { FirstName = "Mostafa", LastName = "Samir", Email = "mostafa.samir@gmail.com", City = "Luxor" },
			new Customer { FirstName = "Karim", LastName = "Tarek", Email = "karim.tarek@gmail.com", City = "Sohag" },
			new Customer { FirstName = "Hassan", LastName = "Adel", Email = "hassan.adel@gmail.com", City = "Minya" },
			new Customer { FirstName = "Mahmoud", LastName = "Nabil", Email = "mahmoud.nabil@gmail.com", City = "Qena" },
			new Customer { FirstName = "Amr", LastName = "Wael", Email = "amr.wael@gmail.com", City = "Port Said" }
		};

		public static List<Product> products = new List<Product>
		{
			new Product { Name = "USB Cable", Price = 50, Stock = 100 },
			new Product { Name = "Wireless Mouse", Price = 350, Stock = 50 },
			new Product { Name = "Keyboard", Price = 500, Stock = 40 },
			new Product { Name = "USB Flash Drive 64GB", Price = 450, Stock = 70 },
			new Product { Name = "Power Bank", Price = 900, Stock = 30 },
			new Product { Name = "Laptop Stand", Price = 650, Stock = 25 },
			new Product { Name = "HDMI Cable", Price = 250, Stock = 80 },
			new Product { Name = "Webcam", Price = 1200, Stock = 20 },
			new Product { Name = "Headphones", Price = 1500, Stock = 35 },
			new Product { Name = "Bluetooth Speaker", Price = 1800, Stock = 15 }
		};

		public static List<Order> orders = new List<Order>
		{
			new Order(customers[0] ),
			new Order(customers[1] ),
			new Order(customers[2] ),
			new Order(customers[3] ),
			new Order(customers[4] ),
			new Order(customers[5] ),
			new Order(customers[6] ),
			new Order(customers[7] ),
			new Order(customers[8] ),
			new Order( customers[9]),
		};

		public static List<OrderLine> orderLines = new List<OrderLine>
		{
			new OrderLine { OrderID = 1, ProductID= 1, Quantity = 5,totalPriceOfQuantity=250},
			new OrderLine { OrderID = 2, ProductID= 3, Quantity = 1,totalPriceOfQuantity=500 },
			new OrderLine { OrderID = 3, ProductID= 5, Quantity = 2,totalPriceOfQuantity=1800 },
			new OrderLine { OrderID = 4, ProductID= 6, Quantity = 1,totalPriceOfQuantity=650 },
			new OrderLine { OrderID = 5, ProductID= 9, Quantity = 1,totalPriceOfQuantity=1500 },
			new OrderLine { OrderID = 6, ProductID= 1, Quantity = 10,totalPriceOfQuantity=500 },
			new OrderLine { OrderID = 7, ProductID= 2, Quantity = 3,totalPriceOfQuantity=750 },
			new OrderLine { OrderID = 8, ProductID= 4, Quantity = 5,totalPriceOfQuantity=4800 },
			new OrderLine { OrderID = 9, ProductID= 8, Quantity = 1,totalPriceOfQuantity=1500 },
			new OrderLine { OrderID = 10,ProductID = 10, Quantity = 1,totalPriceOfQuantity=1800 }
		};


	}
}

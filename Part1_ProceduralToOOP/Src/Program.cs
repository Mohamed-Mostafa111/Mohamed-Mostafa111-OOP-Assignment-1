namespace E_Commerce
{
	internal class Program
	{
	    static void Main(string[] args)
		{
			RunInteractiveMenu();
		}
		static Customer customer =new Customer();
		static Product Product=new Product();
		static Order Order=new Order(new Customer());
		static OrderLine Line=new OrderLine();
		static void PrintMenu()
		{
			Console.WriteLine("\n---------- MENU ----------");
			Console.WriteLine("1) Print customers");
			Console.WriteLine("2) Print products");
			Console.WriteLine("3) Print all orders");
			Console.WriteLine("4) Print one order by id");
			Console.WriteLine("5) Create order");
			Console.WriteLine("6) Add line to order");
			Console.WriteLine("7) Mark order paid");
			Console.WriteLine("8) Show paid sales total");
			Console.WriteLine("0) Exit");
			Console.Write("Choice: ");
		}

		public static void RunInteractiveMenu()
		{
			int choice = -1;

			while (choice != 0)
			{
				PrintMenu();

				choice = int.Parse(Console.ReadLine());
				Console.Clear();
				if (choice == 1)
				{
					customer.PrintCustomers();
				}
				else if (choice == 2)
				{
					Product.PrintProducts();
				}
				else if (choice == 3)
				{
					Order.PrintOrder();
				}
				else if (choice == 4)
				{
					Console.Write("Order id: ");
					int orderId = int.Parse(Console.ReadLine());

					var ResultOrder= Order.PrintOrderById(orderId);
					Console.WriteLine(ResultOrder);
				}
				else if (choice == 5)
				{
					Console.Write("Customer id: ");
					int customerId = int.Parse(Console.ReadLine());
					Order.AddOrder(customer.SearchaboutCUstomerById(customerId) ?? new Customer());
				}
				else if (choice == 6)
				{
					Console.Write("Order id: ");
					int orderId = int.Parse(Console.ReadLine());

					Console.Write("Product id: ");
					int productId = int.Parse(Console.ReadLine());

					Console.Write("Quantity: ");
					int quantity = int.Parse(Console.ReadLine());

					Line.AddOrderLine(orderId, productId, quantity);
				}
				else if (choice == 7)
				{
					Console.Write("Order id: ");
					int orderId = int.Parse(Console.ReadLine());

					Order.MarkOrderIsPaid(orderId);
				}
				else if (choice == 8)
				{
					Console.WriteLine(
						$"Paid sales total: {Order.ShowPaidSalesTotal():F2}"
					);
				}
				else if (choice == 0)
				{
					Console.WriteLine("Bye.");
				}
				else
				{
					Console.WriteLine("Unknown choice.");
				}
				
			}
		}
	}
}

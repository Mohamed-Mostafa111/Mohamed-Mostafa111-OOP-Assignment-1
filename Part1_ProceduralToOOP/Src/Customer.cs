
using System.Security.Cryptography.X509Certificates;

namespace E_Commerce
{
	internal class Customer
	{
		public readonly int Id;
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string City { get; set; }
		public bool IsVIP { get; set; }
		private static int counter = 0;

		public List<Order> Orders { get; set; }
		
		public Customer()
		{
			Id=counter++;
		}
		public void AddCustomer(string FName,string LName,string Email,string Governorate,bool IsVip=false)
		{
			E_CommerceData.customers.Add(new Customer
			{
				FirstName = FName,
				LastName = LName,
				Email = Email,
				City = Governorate,
				IsVIP = IsVip
			});
		}
		public Customer? SearchaboutCUstomerById(int Id)
		{
			foreach (var customer in E_CommerceData.customers)
			{
				if (customer.Id==Id)
				{
					return customer;
				}
			}
			return null;
		}
		public void PrintCustomers()
		{

			Console.WriteLine($"=== CUSTOMERS({counter-1}) ===");
			foreach (var customer in E_CommerceData.customers)
			{
				Console.WriteLine(customer);
			}
		}
		public override string ToString()
		{
			return
				   $"#{Id} " +
			       $"{FirstName} {LastName} " +
				   $"<{Email}> " +
				   $"Governorate: {City} " +
				   $"ISVip:{(IsVIP?"YES":"NO")}";
		}
	}
}

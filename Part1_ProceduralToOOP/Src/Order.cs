using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce
{
	internal class Order
	{
		public readonly int Id;
		public DateTime DateTime = DateTime.Now;
		private int CustomerID;
		public bool IsPaid { get; set; }
		private static int IdCounter = 0;
		public decimal TotalPrice { get; set; }
		
		private readonly Customer customer;
		private  List<OrderLine> OrderLines=new List<OrderLine>();

		public Order(Customer customer)
		{
			Id = IdCounter++;
			this.customer = customer;
			
		}

		public void AddOrder(Customer customer,bool ispaid=false)
		{
			E_CommerceData.orders.Add(new Order(customer)
			{
				CustomerID = customer.Id,
				IsPaid = ispaid,
			});
		}
		public void PrintOrder()
		{
			foreach (var order in E_CommerceData.orders)
			{
				Console.WriteLine(order);
			}
		}
		public Order? PrintOrderById(int orderId)
		{
			foreach(var Order in  E_CommerceData.orders)
			{
				if (Order.Id==orderId)
				{

					return Order;
				}
			}
			Console.WriteLine("invalid Order Id");
			return null;
		}
		
		public void MarkOrderIsPaid(int id)
		{
			var order = PrintOrderById(id);
			if (order != null)
			{
				int index=E_CommerceData.orders.IndexOf(order);
				if (!E_CommerceData.orders[index].IsPaid)
				{
					E_CommerceData.orders[index].IsPaid = true;
				}
			}
		}

		public static decimal ShowPaidSalesTotal() 
		{
			decimal SalesTotal = 0;
			foreach(Order order in E_CommerceData.orders)
			{
				if (order.IsPaid)
				{
					SalesTotal += order.TotalPrice;
				}
			}
			return SalesTotal;
		}
		private decimal CalculateTotalPrice()
		{
			decimal Total = 0;
			foreach (OrderLine line in OrderLines)
			{
				Total += line.totalPriceOfQuantity;
			}
			TotalPrice = Total;
			return Total;
		}

		public override string ToString()
		{

			return
				$"=== Order #{Id} ===\n" +
				$"Date:{DateTime.UtcNow}\n" +
				$"Customer:{customer.FirstName} {customer.LastName} (#{customer.Id})\n" +
				$"Paid: {(IsPaid ? "YES" : "NO")}\n" +
				$"Is Paied: {IsPaid} \n\n" +
				$"Lines:\n" +
				string.Join("\n", OrderLines=new OrderLine().GitAllOrderLinesByOrderID(Id))+
				$"\n\n" +
				$"Total Price:{TotalPrice = CalculateTotalPrice()}\n";
			    
		}
	}
}
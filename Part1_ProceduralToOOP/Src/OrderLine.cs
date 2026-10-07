using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce
{
	internal class OrderLine
	{
		public int OrderID { get; init; }
		public int ProductID { get; init; }
		public int Quantity { get; set; }
		public decimal totalPriceOfQuantity { get; set; }
		public Product Product { get; init; }=new Product();

     	public void AddOrderLine(int orderid,int productid ,int Quantity)
		{
		    var product= Product.SearchAboutProduct(productid);
			E_CommerceData.orderLines.Add(new OrderLine
			{
				OrderID = orderid,
				ProductID = productid,
				Quantity = Quantity,
				totalPriceOfQuantity = Quantity * product.Price
			});
		}

		public List<OrderLine> GitAllOrderLinesByOrderID(int orderid)
		{
			List<OrderLine>orderLines = new List<OrderLine>();
			foreach (var order in E_CommerceData.orderLines)
			{
				if (order.OrderID==orderid)
				{
				   orderLines.Add(order);
				}
			}
			return orderLines;
		}
		public override string ToString()
		{
			var product = Product.SearchAboutProduct(ProductID);
			return $":{product.Name}" +
				   $"Quantity:{Quantity}" +
				   $"Total Price of Quantity:{totalPriceOfQuantity}";
		}
	}

}

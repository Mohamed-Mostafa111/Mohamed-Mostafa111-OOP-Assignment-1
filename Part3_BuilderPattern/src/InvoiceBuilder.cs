using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Reservation_System
{
	internal class InvoiceBuilder
	{
		private readonly int invoiceId;
		private string customerName;
		private string customerEmail;
		private string customerPhone;

		private string billingStreet;
		private string billingCity;
		private string billingState;
		private string billingZipCode;
		private string billingCountry;

		private string shippingStreet;
		private string shippingCity;
		private string shippingState;
		private string shippingZipCode;
		private string shippingCountry;

		private DateTime orderDate;
		private string? paymentMethod;
		private string? currency;

		private decimal subTotal;
		private decimal discountAmount;
		private decimal taxAmount;
		private decimal totalAmount;
		private int IDCounter = 0;
		
		public InvoiceBuilder()
		{
			invoiceId=IDCounter++;
		}

		public InvoiceBuilder SetCustomerData(string Name, string Email, string PhoneNumber)
		{
			customerName=Name;
			customerEmail=Email;
			customerPhone=PhoneNumber;
			return this;
		}

		public InvoiceBuilder SetBillingAddress(string BillingStreet,string city,string ShippingState,string ShippingZipCode,string ShippingCountry)
		{ 
			billingStreet=BillingStreet;
			billingCity = city;
			billingState=ShippingState;
			billingZipCode=ShippingZipCode;
			billingCountry=ShippingCountry;
			return this;
		}
		public InvoiceBuilder SetSheppingAddress(string shippingStreet,string shippingCity,string ShippingState,string ShippingZipCode,string ShippingCountry)
		{
			this.shippingStreet = shippingStreet; 
			this.shippingCity=shippingCity;
			shippingState = ShippingState;
			shippingZipCode=ShippingZipCode;
			shippingCountry=ShippingCountry;
			return this;
		}

		public InvoiceBuilder SetOrderDetails(DateTime orderDate,string PaymentMethod,string Currancy)
		{
			this.orderDate = orderDate;
			paymentMethod = PaymentMethod;
			currency = Currancy;
			return this;
		}
		
		public InvoiceBuilder SetPricingDetails(decimal subtotal,decimal DiscountAmount,decimal TaxAmount,decimal TotalAmount)
		{
			this.subTotal = subtotal;
			discountAmount = DiscountAmount;
			taxAmount = TaxAmount;
			totalAmount = TotalAmount;
			return this;
		}
	}
	
}

using System;
namespace Inheritance
{
	public class Order
	{
		public int orderId;
		public string orderDate;

        public Order(int orderId, string orderDate)
		{
			this.orderDate = orderDate;
			this.orderId = orderId;
        }
		public virtual void GetOrderStatus()
		{
			Console.WriteLine("Order status : Ordered");
		}

    }
	class ShippedOrder : Order
	{
		public int TrackingNumber;
		public ShippedOrder( int orderId, string orderDate, int TrackingNumber):base(orderId,orderDate)
		{
			this.TrackingNumber = TrackingNumber;
        }
        public override void GetOrderStatus()
        {
            Console.WriteLine("Order status : Shipped");
        }
    }
	class DeliveredOrder : ShippedOrder
    {
		public string DeliveryDate;
		public DeliveredOrder(int orderId, string orderDate, int TrackingNumber,string DeliveryDate) : base(orderId, orderDate, TrackingNumber)
        {
			this.DeliveryDate = DeliveryDate;

        }
        public override void GetOrderStatus()
        {
            Console.WriteLine("Order status : Delivered");
        }
    }
}


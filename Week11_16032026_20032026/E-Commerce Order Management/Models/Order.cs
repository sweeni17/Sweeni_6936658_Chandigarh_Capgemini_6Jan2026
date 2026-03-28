namespace E_Commerce_Order_Management.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.Now;

        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public ShippingDetail? ShippingDetail { get; set; }
    }
}

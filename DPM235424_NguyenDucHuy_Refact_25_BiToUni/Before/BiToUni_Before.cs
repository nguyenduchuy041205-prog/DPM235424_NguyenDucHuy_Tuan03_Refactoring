using System.Collections.Generic;

namespace DPM235424_NguyenDucHuy_Refact_25_BiToUni.Before
{
    public class Order
    {
        public string OrderCode { get; set; }
        public Customer Customer { get; set; }

        public Order(string code, Customer customer)
        {
            OrderCode = code;
            Customer = customer;
            customer.AddOrder(this);
        }
    }

    public class Customer
    {
        public string Name { get; set; }
        // Phụ thuộc ngược không cần thiết, làm phức tạp hóa vòng đời đối tượng
        private readonly List<Order> _orders = new List<Order>();

        public Customer(string name)
        {
            Name = name;
        }

        public void AddOrder(Order order)
        {
            _orders.Add(order);
        }

        public double GetDiscount()
        {
            return 0.1; // 10%
        }
    }

    public class BiToUni_Before
    {
        public double CalculateOrderPrice(Order order, double basePrice)
        {
            return basePrice * (1 - order.Customer.GetDiscount());
        }
    }
}
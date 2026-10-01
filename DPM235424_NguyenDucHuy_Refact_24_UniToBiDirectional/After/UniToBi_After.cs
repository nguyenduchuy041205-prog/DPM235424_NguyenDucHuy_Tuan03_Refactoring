using System.Collections.Generic;

namespace DPM235424_NguyenDucHuy_Refact_24_UniToBi.After
{
    public class Customer
    {
        public string Name { get; set; }
        private readonly HashSet<Order> _orders = new HashSet<Order>();

        public Customer(string name)
        {
            Name = name;
        }

        public IEnumerable<Order> Orders
        {
            get { return _orders; }
        }

        internal void AddOrder(Order order)
        {
            _orders.Add(order);
        }

        internal void RemoveOrder(Order order)
        {
            _orders.Remove(order);
        }
    }

    public class Order
    {
        public string OrderId { get; set; }
        private Customer _customer;

        public Order(string orderId)
        {
            OrderId = orderId;
        }

        public Customer Customer
        {
            get { return _customer; }
            set
            {
                if (_customer != null)
                {
                    _customer.RemoveOrder(this);
                }
                _customer = value;
                if (_customer != null)
                {
                    _customer.AddOrder(this);
                }
            }
        }
    }

    public class UniToBi_After
    {
        public IEnumerable<Order> GetCustomerOrders(Customer customer)
        {
            return customer.Orders;
        }
    }
}
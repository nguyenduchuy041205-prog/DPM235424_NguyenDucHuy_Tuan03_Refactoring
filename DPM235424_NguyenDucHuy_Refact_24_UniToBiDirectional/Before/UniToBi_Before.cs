using System.Collections.Generic;

namespace DPM235424_NguyenDucHuy_Refact_24_UniToBi.Before
{
    public class Customer
    {
        public string Name { get; set; }

        public Customer(string name)
        {
            Name = name;
        }
        // Customer hoàn toàn không quản lý danh sách Order của mình
    }

    public class Order
    {
        public string OrderId { get; set; }
        public Customer Customer { get; set; }

        public Order(string orderId, Customer customer)
        {
            OrderId = orderId;
            Customer = customer;
        }
    }

    public class UniToBi_Before
    {
        // Client phải duyệt danh sách Order thủ công
        public List<Order> GetOrdersForCustomer(List<Order> allOrders, Customer customer)
        {
            List<Order> result = new List<Order>();
            foreach (var order in allOrders)
            {
                if (order.Customer == customer)
                {
                    result.Add(order);
                }
            }
            return result;
        }
    }
}
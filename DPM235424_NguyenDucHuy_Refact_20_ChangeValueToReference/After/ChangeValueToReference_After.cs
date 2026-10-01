using System.Collections.Generic;

namespace DPM235424_NguyenDucHuy_Refact_20_ChangeValueToReference.After
{
    public class Customer
    {
        private static readonly Dictionary<string, Customer> _instances = new Dictionary<string, Customer>();

        public string Name { get; }

        private Customer(string name)
        {
            Name = name;
        }

        // Factory Method đảm bảo mỗi tên khách hàng chỉ có duy nhất 1 thể hiện tham chiếu
        public static Customer GetNamed(string name)
        {
            if (!_instances.ContainsKey(name))
            {
                _instances[name] = new Customer(name);
            }
            return _instances[name];
        }
    }

    public class Order
    {
        public Customer Customer { get; }
        public double Amount { get; }

        public Order(string customerName, double amount)
        {
            // Lấy cùng một tham chiếu khách hàng từ kho
            Customer = Customer.GetNamed(customerName);
            Amount = amount;
        }
    }

    public class ChangeValueToReference_After
    {
        public bool CheckSameCustomer(Order o1, Order o2)
        {
            // So sánh tham chiếu lúc này trả về true nếu cùng tên
            return ReferenceEquals(o1.Customer, o2.Customer);
        }
    }
}
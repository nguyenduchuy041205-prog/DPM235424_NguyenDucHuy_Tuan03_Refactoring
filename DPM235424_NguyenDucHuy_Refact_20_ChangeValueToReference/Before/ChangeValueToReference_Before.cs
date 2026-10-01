namespace DPM235424_NguyenDucHuy_Refact_20_ChangeValueToReference.Before
{
    public class Customer
    {
        public string Name { get; }
        public Customer(string name)
        {
            Name = name;
        }
    }

    public class Order
    {
        // Value Object pattern: Mỗi đơn hàng tạo ra một Customer riêng biệt
        public Customer Customer { get; }
        public double Amount { get; }

        public Order(string customerName, double amount)
        {
            Customer = new Customer(customerName);
            Amount = amount;
        }
    }

    public class ChangeValueToReference_Before
    {
        public bool CheckSameCustomer(Order o1, Order o2)
        {
            // So sánh tham chiếu sẽ trả về false dù cùng tên
            return ReferenceEquals(o1.Customer, o2.Customer);
        }
    }
}
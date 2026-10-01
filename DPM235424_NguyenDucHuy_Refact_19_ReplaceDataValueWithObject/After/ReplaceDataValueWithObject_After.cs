namespace DPM235424_NguyenDucHuy_Refact_19_ReplaceDataValueWithObject.After
{
    // Đối tượng hóa giá trị dữ liệu khách hàng
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
        // Dữ liệu khách hàng đã trở thành đối tượng độc lập
        public Customer Customer { get; set; }

        public Order(string customerName)
        {
            Customer = new Customer(customerName);
        }

        public string CustomerName => Customer.Name;
    }

    public class ReplaceDataValueWithObject_After
    {
        public int CountOrdersFor(Order[] orders, string customerName)
        {
            int count = 0;
            foreach (var order in orders)
            {
                if (order.CustomerName == customerName)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
namespace DPM235424_NguyenDucHuy_Refact_25_BiToUni.After
{
    // Customer hoàn toàn độc lập, không còn giữ danh sách Order
    public class Customer
    {
        public string Name { get; set; }

        public Customer(string name)
        {
            Name = name;
        }

        public double GetDiscount()
        {
            return 0.1;
        }
    }

    // Chỉ còn liên kết một chiều từ Order sang Customer
    public class Order
    {
        public string OrderCode { get; set; }
        public Customer Customer { get; set; }

        public Order(string code, Customer customer)
        {
            OrderCode = code;
            Customer = customer;
        }
    }

    public class BiToUni_After
    {
        public double CalculateOrderPrice(Order order, double basePrice)
        {
            return basePrice * (1 - order.Customer.GetDiscount());
        }
    }
}
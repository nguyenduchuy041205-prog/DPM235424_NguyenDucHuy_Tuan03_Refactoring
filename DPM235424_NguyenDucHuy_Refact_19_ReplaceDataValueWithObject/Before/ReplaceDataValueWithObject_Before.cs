namespace DPM235424_NguyenDucHuy_Refact_19_ReplaceDataValueWithObject.Before
{
    public class Order
    {
        // Primitive Obsession: Dùng chuỗi nguyên thủy để đại diện cho khách hàng
        public string Customer { get; set; }

        public Order(string customer)
        {
            Customer = customer;
        }
    }

    public class ReplaceDataValueWithObject_Before
    {
        public int CountOrdersFor(Order[] orders, string customerName)
        {
            int count = 0;
            foreach (var order in orders)
            {
                if (order.Customer == customerName)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
namespace DPM235424_NguyenDucHuy_Refact_04_InlineTemp.Before
{
    public class Order
    {
        public double BasePrice() => 1200.0;
    }

    public class InlineTemp_Before
    {
        public bool IsExpensive(Order anOrder)
        {
            // Biến tạm basePrice chỉ được gán và dùng 1 lần duy nhất để return so sánh
            double basePrice = anOrder.BasePrice();
            return basePrice > 1000;
        }
    }
}
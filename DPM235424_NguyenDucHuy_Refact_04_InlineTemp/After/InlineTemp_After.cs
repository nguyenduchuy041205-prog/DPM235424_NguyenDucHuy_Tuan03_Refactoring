namespace DPM235424_NguyenDucHuy_Refact_04_InlineTemp.After
{
    public class Order
    {
        public double BasePrice() => 1200.0;
    }

    public class InlineTemp_After
    {
        public bool IsExpensive(Order anOrder)
        {
            // Nội suy trực tiếp biểu thức, xóa biến tạm thừa
            return anOrder.BasePrice() > 1000;
        }
    }
}
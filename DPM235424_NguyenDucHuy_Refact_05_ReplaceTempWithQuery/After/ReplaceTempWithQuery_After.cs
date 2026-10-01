namespace DPM235424_NguyenDucHuy_Refact_05_ReplaceTempWithQuery.After
{
    public class ReplaceTempWithQuery_After
    {
        private int _quantity = 120;
        private double _itemPrice = 50.0;

        public double CalculateTotal()
        {
            // Thay thế biến tạm bằng việc gọi trực tiếp các phương thức truy vấn
            return BasePrice() * DiscountFactor();
        }

        public double BasePrice()
        {
            return _quantity * _itemPrice;
        }

        public double DiscountFactor()
        {
            if (BasePrice() > 1000)
            {
                return 0.95;
            }
            return 0.98;
        }
    }
}
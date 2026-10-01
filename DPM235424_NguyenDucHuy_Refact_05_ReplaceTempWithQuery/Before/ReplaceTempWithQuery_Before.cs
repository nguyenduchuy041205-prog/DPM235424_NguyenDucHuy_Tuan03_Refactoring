namespace DPM235424_NguyenDucHuy_Refact_05_ReplaceTempWithQuery.Before
{
    public class ReplaceTempWithQuery_Before
    {
        private int _quantity = 120;
        private double _itemPrice = 50.0;

        public double CalculateTotal()
        {
            // Biến tạm tính toán cục bộ
            double basePrice = _quantity * _itemPrice;
            double discountFactor;

            if (basePrice > 1000)
            {
                discountFactor = 0.95;
            }
            else
            {
                discountFactor = 0.98;
            }

            return basePrice * discountFactor;
        }
    }
}
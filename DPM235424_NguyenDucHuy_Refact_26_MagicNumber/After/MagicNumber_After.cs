namespace DPM235424_NguyenDucHuy_Refact_26_MagicNumber.After
{
    public class MagicNumber_After
    {
        // Đặt tên hằng số ký hiệu rõ ràng
        public const double GRAVITATIONAL_CONSTANT = 9.81;
        public const double VAT_TAX_RATE = 0.05;

        public double PotentialEnergy(double mass, double height)
        {
            return mass * GRAVITATIONAL_CONSTANT * height;
        }

        public double CalculateGrossTotal(double subtotal)
        {
            return subtotal + (subtotal * VAT_TAX_RATE);
        }
    }
}
namespace DPM235424_NguyenDucHuy_Refact_26_MagicNumber.Before
{
    public class MagicNumber_Before
    {
        // 9.81 là hằng số trọng lực Trái Đất nhưng bị hardcode dưới dạng Magic Number
        public double PotentialEnergy(double mass, double height)
        {
            return mass * 9.81 * height;
        }

        // 0.05 là thuế suất VAT nhưng bị viết thô trong công thức
        public double CalculateGrossTotal(double subtotal)
        {
            return subtotal + (subtotal * 0.05);
        }
    }
}
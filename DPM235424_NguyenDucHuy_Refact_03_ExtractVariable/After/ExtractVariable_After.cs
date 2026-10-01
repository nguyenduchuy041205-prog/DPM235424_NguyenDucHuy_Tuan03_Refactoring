using System;

namespace DPM235424_NguyenDucHuy_Refact_03_ExtractVariable.After
{
    public class ExtractVariable_After
    {
        public double Price(int quantity, double itemPrice)
        {
            double basePrice = quantity * itemPrice;
            double quantityDiscount = Math.Max(0, quantity - 500) * itemPrice * 0.05;
            double shipping = Math.Min(basePrice * 0.1, 100.0);

            return basePrice - quantityDiscount + shipping;
        }
    }
}
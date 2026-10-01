using System;

namespace DPM235424_NguyenDucHuy_Refact_03_ExtractVariable.Before
{
    public class ExtractVariable_Before
    {
        public double Price(int quantity, double itemPrice)
        {
            // Biểu thức tính giá bao gồm giá gốc, chiết khấu số lượng và phí vận chuyển dồn hết trên 1 dòng
            return quantity * itemPrice -
                   Math.Max(0, quantity - 500) * itemPrice * 0.05 +
                   Math.Min(quantity * itemPrice * 0.1, 100.0);
        }
    }
}
using System;

namespace DPM235424_NguyenDucHuy_Refact_06_SplitTemporaryVariable.Before
{
    public class SplitTemporaryVariable_Before
    {
        private double _height = 10.0;
        private double _width = 5.0;

        public void CalculateGeometry()
        {
            // 'temp' được dùng lần 1 để tính chu vi
            double temp = 2 * (_height + _width);
            Console.WriteLine($"Perimeter: {temp}");

            // 'temp' bị gán đè lần 2 để tính diện tích
            temp = _height * _width;
            Console.WriteLine($"Area: {temp}");
        }
    }
}
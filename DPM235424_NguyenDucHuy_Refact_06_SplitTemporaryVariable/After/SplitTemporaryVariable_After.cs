using System;

namespace DPM235424_NguyenDucHuy_Refact_06_SplitTemporaryVariable.After
{
    public class SplitTemporaryVariable_After
    {
        private double _height = 10.0;
        private double _width = 5.0;

        public void CalculateGeometry()
        {
            // Tách thành biến 'perimeter' riêng biệt
            double perimeter = 2 * (_height + _width);
            Console.WriteLine($"Perimeter: {perimeter}");

            // Tách thành biến 'area' riêng biệt
            double area = _height * _width;
            Console.WriteLine($"Area: {area}");
        }
    }
}
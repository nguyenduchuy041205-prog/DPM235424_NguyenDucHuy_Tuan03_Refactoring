using System;

namespace DPM235424_NguyenDucHuy_Refact_01_ExtractMethod.After
{
    public class ExtractMethod_After
    {
        private string _customerName = "Đại lý VTNN Ba Tri";
        private double[] _orders = { 150000.0, 320000.0, 480000.0 };

        public void PrintOwing()
        {
            PrintBanner();
            double outstanding = CalculateOutstanding();
            PrintDetails(outstanding);
        }

        private void PrintBanner()
        {
            Console.WriteLine("***********************");
            Console.WriteLine("**** Customer Owes ****");
            Console.WriteLine("***********************");
        }

        private double CalculateOutstanding()
        {
            double result = 0.0;
            foreach (var order in _orders)
            {
                result += order;
            }
            return result;
        }

        private void PrintDetails(double outstanding)
        {
            Console.WriteLine($"Name: {_customerName}");
            Console.WriteLine($"Amount: {outstanding:N0} VNĐ");
        }
    }
}
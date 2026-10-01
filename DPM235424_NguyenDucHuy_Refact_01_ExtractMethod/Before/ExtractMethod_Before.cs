using System;

namespace DPM235424_NguyenDucHuy_Refact_01_ExtractMethod.Before
{
    public class ExtractMethod_Before
    {
        private string _customerName = "Đại lý VTNN Ba Tri";
        private double[] _orders = { 150000.0, 320000.0, 480000.0 };

        public void PrintOwing()
        {
            // 1. In banner tiêu đề
            Console.WriteLine("***********************");
            Console.WriteLine("**** Customer Owes ****");
            Console.WriteLine("***********************");

            // 2. Tính tổng tiền nợ
            double outstanding = 0.0;
            foreach (var order in _orders)
            {
                outstanding += order;
            }

            // 3. In thông tin chi tiết
            Console.WriteLine($"Name: {_customerName}");
            Console.WriteLine($"Amount: {outstanding:N0} VNĐ");
        }
    }
}
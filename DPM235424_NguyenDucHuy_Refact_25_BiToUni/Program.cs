using System;
using DPM235424_NguyenDucHuy_Refact_25_BiToUni.Before;
using DPM235424_NguyenDucHuy_Refact_25_BiToUni.After;
using DPM235424_NguyenDucHuy_Refact_25_BiToUni.Real;

namespace DPM235424_NguyenDucHuy_Refact_25_BiToUni
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine(">>> 1. DEMO CLASS: BiToUni_Before <<<");
            var before = new BiToUni_Before();
            var cusBefore = new Before.Customer("Đại lý A");
            var ordBefore = new Before.Order("ORD-01", cusBefore);
            Console.WriteLine(string.Format("Giá sau chiết khấu (Before): {0:N0} VNĐ", before.CalculateOrderPrice(ordBefore, 1000000)));

            Console.WriteLine("\n>>> 2. DEMO CLASS: BiToUni_After <<<");
            var after = new BiToUni_After();
            var cusAfter = new After.Customer("Đại lý A");
            var ordAfter = new After.Order("ORD-01", cusAfter);
            Console.WriteLine(string.Format("Giá sau chiết khấu (After):  {0:N0} VNĐ", after.CalculateOrderPrice(ordAfter, 1000000)));

            Console.WriteLine("\n>>> 3. DEMO CLASS: BiToUni_Real (NÔNG DƯỢC AN GIANG) <<<");
            var real = new BiToUni_Real();
            real.QuanLyNguonGocThuoc();
        }
    }
}
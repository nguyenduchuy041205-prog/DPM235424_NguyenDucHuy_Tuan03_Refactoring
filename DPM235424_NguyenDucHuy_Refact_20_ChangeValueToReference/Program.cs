using System;
using DPM235424_NguyenDucHuy_Refact_20_ChangeValueToReference.Before;
using DPM235424_NguyenDucHuy_Refact_20_ChangeValueToReference.After;
using DPM235424_NguyenDucHuy_Refact_20_ChangeValueToReference.Real;

namespace DPM235424_NguyenDucHuy_Refact_20_ChangeValueToReference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine(">>> 1. DEMO CLASS: ChangeValueToReference_Before <<<");
            var before = new ChangeValueToReference_Before();
            var o1 = new Before.Order("Đại lý Ba Tri", 5000);
            var o2 = new Before.Order("Đại lý Ba Tri", 8000);
            Console.WriteLine($"Cùng tham chiếu khách hàng? {before.CheckSameCustomer(o1, o2)} (False vì new riêng)");

            Console.WriteLine("\n>>> 2. DEMO CLASS: ChangeValueToReference_After <<<");
            var after = new ChangeValueToReference_After();
            var o3 = new After.Order("Đại lý Ba Tri", 5000);
            var o4 = new After.Order("Đại lý Ba Tri", 8000);
            Console.WriteLine($"Cùng tham chiếu khách hàng? {after.CheckSameCustomer(o3, o4)} (True vì lấy từ Registry)");

            Console.WriteLine("\n>>> 3. DEMO CLASS: ChangeValueToReference_Real (NÔNG DƯỢC AN GIANG) <<<");
            var real = new ChangeValueToReference_Real();
            real.ThucThiQuanLyDonHang();
        }
    }
}
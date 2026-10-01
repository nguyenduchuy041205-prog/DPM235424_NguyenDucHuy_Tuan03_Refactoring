using System;
using DPM235424_NguyenDucHuy_Refact_07_RemoveAssignmentsToParameters.Before;
using DPM235424_NguyenDucHuy_Refact_07_RemoveAssignmentsToParameters.After;
using DPM235424_NguyenDucHuy_Refact_07_RemoveAssignmentsToParameters.Real;

namespace DPM235424_NguyenDucHuy_Refact_07_RemoveAssignmentsToParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine(">>> 1. DEMO CLASS: RemoveAssignmentsToParameters_Before <<<");
            var before = new RemoveAssignmentsToParameters_Before();
            Console.WriteLine($"Kết quả (Before): {before.Discount(110, 60)}");

            Console.WriteLine("\n>>> 2. DEMO CLASS: RemoveAssignmentsToParameters_After <<<");
            var after = new RemoveAssignmentsToParameters_After();
            Console.WriteLine($"Kết quả (After):  {after.Discount(110, 60)}");

            Console.WriteLine("\n>>> 3. DEMO CLASS: RemoveAssignmentsToParameters_Real (NÔNG DƯỢC AN GIANG) <<<");
            var real = new RemoveAssignmentsToParameters_Real();
            // Thuốc trừ bệnh Tilt Super 300EC giá niêm yết 240.000đ, đại lý mua 150 chai, thanh toán ngay
            real.TinhDonGiaBanThucTe(
                donGiaGoc: 240000,
                soLuongMua: 150,
                khachHangThanThiet: true,
                thanhToanTienMat: true
            );
        }
    }
}
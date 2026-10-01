using System;
using DPM235424_NguyenDucHuy_Refact_13_InlineClass.Before;
using DPM235424_NguyenDucHuy_Refact_13_InlineClass.After;
using DPM235424_NguyenDucHuy_Refact_13_InlineClass.Real;

namespace DPM235424_NguyenDucHuy_Refact_13_InlineClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine(">>> 1. DEMO CLASS: InlineClass_Before <<<");
            var before = new InlineClass_Before();
            Console.WriteLine($"Thông tin liên hệ (Before): {before.GetContactInfo()}");

            Console.WriteLine("\n>>> 2. DEMO CLASS: InlineClass_After <<<");
            var after = new InlineClass_After();
            Console.WriteLine($"Thông tin liên hệ (After):  {after.GetContactInfo()}");

            Console.WriteLine("\n>>> 3. DEMO CLASS: InlineClass_Real (NÔNG DƯỢC AN GIANG) <<<");
            var real = new InlineClass_Real
            {
                MaPhieuXuat = "PXK-AG-2026-09",
                TenKhachHang = "Đại lý VTNN Tri Tôn",
                TenThuoc = "Ridomil Gold 68WG",
                SoLuongXuat = 50,
                DonGia = 110000,
                MaKhoXuat = "KHO-TONG-LX",
                TenDayKho = "Dãy A2 - Kệ bảo quản thuốc diệt nấm"
            };

            real.InPhieuXuatKho();
        }
    }
}
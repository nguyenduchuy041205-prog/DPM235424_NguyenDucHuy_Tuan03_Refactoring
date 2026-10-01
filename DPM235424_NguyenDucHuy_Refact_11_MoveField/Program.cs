using System;
using DPM235424_NguyenDucHuy_Refact_11_MoveField.Before;
using DPM235424_NguyenDucHuy_Refact_11_MoveField.After;
using DPM235424_NguyenDucHuy_Refact_11_MoveField.Real;

namespace DPM235424_NguyenDucHuy_Refact_11_MoveField
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine(">>> 1. DEMO CLASS: MoveField_Before <<<");
            var before = new MoveField_Before();
            Console.WriteLine($"Lãi suất tính được (Before): {before.CalculateInterest(10000000, 30):N0} VNĐ");

            Console.WriteLine("\n>>> 2. DEMO CLASS: MoveField_After <<<");
            var after = new MoveField_After();
            Console.WriteLine($"Lãi suất tính được (After):  {after.CalculateInterest(10000000, 30):N0} VNĐ");

            Console.WriteLine("\n>>> 3. DEMO CLASS: MoveField_Real (NÔNG DƯỢC AN GIANG) <<<");
            var nhomCap1 = new NhomDaiLy
            {
                MaNhom = "DL-C1",
                TenNhom = "Đại lý Cấp 1 (Phân phối vùng Chợ Mới)",
                TyLeChietKhau = 7.5 // 7.5%
            };

            var real = new MoveField_Real
            {
                MaHoaDon = "HD-NDAG-2026-11",
                TenKhachHang = "Đại lý Vật tư Nông nghiệp Phú Hòa",
                HangDaiLy = nhomCap1,
                TongTienHang = 120000000 // 120 triệu tiền thuốc BVTV
            };

            real.InThongTinHoaDon();
        }
    }
}
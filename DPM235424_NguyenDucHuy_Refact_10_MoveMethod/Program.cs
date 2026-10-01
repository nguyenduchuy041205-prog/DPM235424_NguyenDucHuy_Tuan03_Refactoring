using System;
using DPM235424_NguyenDucHuy_Refact_10_MoveMethod.Before;
using DPM235424_NguyenDucHuy_Refact_10_MoveMethod.After;
using DPM235424_NguyenDucHuy_Refact_10_MoveMethod.Real;

namespace DPM235424_NguyenDucHuy_Refact_10_MoveMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine(">>> 1. DEMO CLASS: MoveMethod_Before <<<");
            var before = new MoveMethod_Before();
            Console.WriteLine($"Phí ngân hàng (Before): {before.BankCharge():N2}");

            Console.WriteLine("\n>>> 2. DEMO CLASS: MoveMethod_After <<<");
            var after = new MoveMethod_After();
            Console.WriteLine($"Phí ngân hàng (After):  {after.BankCharge():N2}");

            Console.WriteLine("\n>>> 3. DEMO CLASS: MoveMethod_Real (NÔNG DƯỢC AN GIANG) <<<");
            var real = new MoveMethod_Real
            {
                MaDonHang = "DH-2026-XUATKHO",
                ThuocBVTV = new DanhMucThuocBVTV
                {
                    MaThuoc = "ND-REGENT-01",
                    TenThuoc = "Regent 800WG (Đặc trị rầy nâu)",
                    NhomDoc = 1,
                    YeuCauKhoLanh = true
                },
                SoLuongChai = 100,
                DonGia = 195000,
                SoNgayLuuKho = 5
            };

            real.XuatThongTinDonHang();
        }
    }
}
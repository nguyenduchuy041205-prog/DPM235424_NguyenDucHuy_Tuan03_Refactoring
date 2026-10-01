using System;
using DPM235424_NguyenDucHuy_Refact_04_InlineTemp.Before;
using DPM235424_NguyenDucHuy_Refact_04_InlineTemp.After;
using DPM235424_NguyenDucHuy_Refact_04_InlineTemp.Real;

namespace DPM235424_NguyenDucHuy_Refact_04_InlineTemp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine(">>> 1. DEMO CLASS: InlineTemp_Before <<<");
            var before = new InlineTemp_Before();
            Console.WriteLine($"Đơn hàng đắt tiền (>1000)? {before.IsExpensive(new Before.Order())}");

            Console.WriteLine("\n>>> 2. DEMO CLASS: InlineTemp_After <<<");
            var after = new InlineTemp_After();
            Console.WriteLine($"Đơn hàng đắt tiền (>1000)? {after.IsExpensive(new After.Order())}");

            Console.WriteLine("\n>>> 3. DEMO CLASS: InlineTemp_Real (NÔNG DƯỢC AN GIANG) <<<");
            var real = new InlineTemp_Real();

            var phieu1 = new PhieuXuatKho
            {
                MaPhieu = "PXK-01",
                TenDaiLy = "Đại lý VTNN Tri Tôn",
                SoThungThuocBVTV = 12,
                DonGiaMoiThung = 1500000 // 18 triệu > 15 triệu
            };

            var phieu2 = new PhieuXuatKho
            {
                MaPhieu = "PXK-02",
                TenDaiLy = "Cửa hàng Nông sản Tịnh Biên",
                SoThungThuocBVTV = 5,
                DonGiaMoiThung = 1200000 // 6 triệu < 15 triệu
            };

            real.DuDieuKienChietKhauVIP(phieu1);
            real.DuDieuKienChietKhauVIP(phieu2);
        }
    }
}
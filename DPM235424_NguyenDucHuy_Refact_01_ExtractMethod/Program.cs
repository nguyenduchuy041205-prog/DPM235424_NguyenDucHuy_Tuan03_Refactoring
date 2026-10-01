using System;
using System.Collections.Generic;
using DPM235424_NguyenDucHuy_Refact_01_ExtractMethod.Before;
using DPM235424_NguyenDucHuy_Refact_01_ExtractMethod.After;
using DPM235424_NguyenDucHuy_Refact_01_ExtractMethod.Real;

namespace DPM235424_NguyenDucHuy_Refact_01_ExtractMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine(">>> 1. DEMO CLASS: ExtractMethod_Before (Chưa tối ưu) <<<");
            var before = new ExtractMethod_Before();
            before.PrintOwing();

            Console.WriteLine("\n>>> 2. DEMO CLASS: ExtractMethod_After (Đã tối ưu) <<<");
            var after = new ExtractMethod_After();
            after.PrintOwing();

            Console.WriteLine("\n>>> 3. DEMO CLASS: ExtractMethod_Real (Ứng dụng Nông dược An Giang) <<<");
            var real = new ExtractMethod_Real();
            var dsThuoc = new List<ChiTietLoThuoc>
            {
                new ChiTietLoThuoc { TenThuoc = "Anvil 5SC", MaLo = "LO-2026A", SoLuong = 10, DonGia = 120000 },
                new ChiTietLoThuoc { TenThuoc = "Filia 525SE", MaLo = "LO-2026B", SoLuong = 5, DonGia = 210000 }
            };

            real.LapHoaDonBanHang(
                maHD: "HD-NDAG-001",
                tenDaiLy: "Đại lý Vật tư Nông nghiệp Thoại Sơn",
                danhSachThuoc: dsThuoc,
                phiVanChuyen: 50000,
                phiBocVac: 20000,
                phanTramChietKhau: 5.0
            );
        }
    }
}
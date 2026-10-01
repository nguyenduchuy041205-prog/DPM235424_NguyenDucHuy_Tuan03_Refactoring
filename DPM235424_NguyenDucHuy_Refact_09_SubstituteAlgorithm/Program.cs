using System;
using System.Collections.Generic;
using DPM235424_NguyenDucHuy_Refact_09_SubstituteAlgorithm.Before;
using DPM235424_NguyenDucHuy_Refact_09_SubstituteAlgorithm.After;
using DPM235424_NguyenDucHuy_Refact_09_SubstituteAlgorithm.Real;

namespace DPM235424_NguyenDucHuy_Refact_09_SubstituteAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine(">>> 1. DEMO CLASS: SubstituteAlgorithm_Before <<<");
            var before = new SubstituteAlgorithm_Before();
            string[] dsNguoi = { "Bob", "Alice", "John", "Kent" };
            Console.WriteLine($"Tìm thấy (Before): {before.FoundPerson(dsNguoi)}");

            Console.WriteLine("\n>>> 2. DEMO CLASS: SubstituteAlgorithm_After <<<");
            var after = new SubstituteAlgorithm_After();
            Console.WriteLine($"Tìm thấy (After):  {after.FoundPerson(dsNguoi)}");

            Console.WriteLine("\n>>> 3. DEMO CLASS: SubstituteAlgorithm_Real (NÔNG DƯỢC AN GIANG) <<<");
            var real = new SubstituteAlgorithm_Real();

            var khoNongDuoc = new List<LoThuocKho>
            {
                new LoThuocKho { MaLo = "LO-2025-A1", TenThuoc = "Anvil 5SC", SoLuongTon = 150, HanSuDung = DateTime.Now.AddDays(25) },
                new LoThuocKho { MaLo = "LO-2026-B2", TenThuoc = "Filia 525SE", SoLuongTon = 300, HanSuDung = DateTime.Now.AddDays(180) },
                new LoThuocKho { MaLo = "LO-2025-C3", TenThuoc = "Tilt Super 300EC", SoLuongTon = 80, HanSuDung = DateTime.Now.AddDays(40) },
                new LoThuocKho { MaLo = "LO-2026-D4", TenThuoc = "Ridomil Gold 68WG", SoLuongTon = 500, HanSuDung = DateTime.Now.AddDays(300) }
            };

            // Lọc các lô thuốc có hạn sử dụng dưới 60 ngày để ưu tiên xuất trước
            var danhSachCanhBao = real.LocLoThuocCanhBaoUuTienXuat(khoNongDuoc, 60);
            real.InBaoCaoCanhBaoKho(danhSachCanhBao);
        }
    }
}
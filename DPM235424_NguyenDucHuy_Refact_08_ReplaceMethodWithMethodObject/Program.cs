using System;
using DPM235424_NguyenDucHuy_Refact_08_ReplaceMethodWithMethodObject.Before;
using DPM235424_NguyenDucHuy_Refact_08_ReplaceMethodWithMethodObject.After;
using DPM235424_NguyenDucHuy_Refact_08_ReplaceMethodWithMethodObject.Real;

namespace DPM235424_NguyenDucHuy_Refact_08_ReplaceMethodWithMethodObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine(">>> 1. DEMO CLASS: ReplaceMethodWithMethodObject_Before <<<");
            var before = new ReplaceMethodWithMethodObject_Before();
            Console.WriteLine($"Kết quả (Before): {before.Gamma(5, 10, 150)}");

            Console.WriteLine("\n>>> 2. DEMO CLASS: ReplaceMethodWithMethodObject_After <<<");
            var after = new ReplaceMethodWithMethodObject_After();
            Console.WriteLine($"Kết quả (After):  {after.Gamma(5, 10, 150)}");

            Console.WriteLine("\n>>> 3. DEMO CLASS: ReplaceMethodWithMethodObject_Real (NÔNG DƯỢC AN GIANG) <<<");
            var real = new ReplaceMethodWithMethodObject_Real();
            // Thuốc trừ bệnh TilSuper: Tồn cũ 100 chai @ 220.000, Nhập mới 200 chai @ 250.000, Xuất 120 chai, Hao hụt 1.5%
            real.TinhToanGiaXuatKho(
                maLo: "LO-TIL-2026-BQ",
                soLuongTonDau: 100,
                giaTonDau: 220000,
                soLuongNhapMoi: 200,
                giaNhapMoi: 250000,
                soLuongXuat: 120,
                tiLeHaoHut: 1.5
            );
        }
    }
}
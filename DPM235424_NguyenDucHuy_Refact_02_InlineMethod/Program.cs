using System;
using DPM235424_NguyenDucHuy_Refact_02_InlineMethod.Before;
using DPM235424_NguyenDucHuy_Refact_02_InlineMethod.After;
using DPM235424_NguyenDucHuy_Refact_02_InlineMethod.Real;

namespace DPM235424_NguyenDucHuy_Refact_02_InlineMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine(">>> 1. DEMO CLASS: InlineMethod_Before (Chưa tối ưu) <<<");
            var before = new InlineMethod_Before();
            Console.WriteLine($"Đánh giá giao hàng: {before.GetRating()} điểm");

            Console.WriteLine("\n>>> 2. DEMO CLASS: InlineMethod_After (Đã tối ưu) <<<");
            var after = new InlineMethod_After();
            Console.WriteLine($"Đánh giá giao hàng: {after.GetRating()} điểm");

            Console.WriteLine("\n>>> 3. DEMO CLASS: InlineMethod_Real (Nông dược An Giang) <<<");
            var real = new InlineMethod_Real();
            var loThuoc = new LoThuocNongDuoc
            {
                MaLo = "LO-TIL-2026",
                TenThuoc = "Tilt Super 300EC",
                SoLuongTon = 100,
                HanSuDung = new DateTime(2027, 12, 31)
            };

            real.KiemTraXuatKhoHopLe(loThuoc, 30);
        }
    }
}
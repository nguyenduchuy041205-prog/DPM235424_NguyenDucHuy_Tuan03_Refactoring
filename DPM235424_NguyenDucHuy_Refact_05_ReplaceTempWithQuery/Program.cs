using System;
using DPM235424_NguyenDucHuy_Refact_05_ReplaceTempWithQuery.Before;
using DPM235424_NguyenDucHuy_Refact_05_ReplaceTempWithQuery.After;
using DPM235424_NguyenDucHuy_Refact_05_ReplaceTempWithQuery.Real;

namespace DPM235424_NguyenDucHuy_Refact_05_ReplaceTempWithQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine(">>> 1. DEMO CLASS: ReplaceTempWithQuery_Before <<<");
            var before = new ReplaceTempWithQuery_Before();
            Console.WriteLine($"Tổng tiền (Before): {before.CalculateTotal():N2}");

            Console.WriteLine("\n>>> 2. DEMO CLASS: ReplaceTempWithQuery_After <<<");
            var after = new ReplaceTempWithQuery_After();
            Console.WriteLine($"Tổng tiền (After):  {after.CalculateTotal():N2}");

            Console.WriteLine("\n>>> 3. DEMO CLASS: ReplaceTempWithQuery_Real (NÔNG DƯỢC AN GIANG) <<<");
            var real = new ReplaceTempWithQuery_Real
            {
                MaLoThuoc = "LO-AMISTAR-2026",
                TenThuoc = "Amistar Top 325SC",
                SoLuongChai = 200,
                DonGiaChai = 275000,
                SoNgayLuuKho = 10
            };

            real.InThongTinPhieu();
        }
    }
}
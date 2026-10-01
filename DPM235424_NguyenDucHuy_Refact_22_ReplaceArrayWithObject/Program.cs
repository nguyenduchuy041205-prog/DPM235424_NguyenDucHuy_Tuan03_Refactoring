using System;
using System.Collections.Generic;
using DPM235424_NguyenDucHuy_Refact_22_ReplaceArrayWithObject.Before;
using DPM235424_NguyenDucHuy_Refact_22_ReplaceArrayWithObject.After;
using DPM235424_NguyenDucHuy_Refact_22_ReplaceArrayWithObject.Real;

namespace DPM235424_NguyenDucHuy_Refact_22_ReplaceArrayWithObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine(">>> 1. DEMO CLASS: ReplaceArrayWithObject_Before <<<");
            var before = new ReplaceArrayWithObject_Before();
            before.DisplayTeamPerformance();

            Console.WriteLine("\n>>> 2. DEMO CLASS: ReplaceArrayWithObject_After <<<");
            var after = new ReplaceArrayWithObject_After();
            after.DisplayTeamPerformance();

            Console.WriteLine("\n>>> 3. DEMO CLASS: ReplaceArrayWithObject_Real (NÔNG DƯỢC AN GIANG) <<<");
            var real = new ReplaceArrayWithObject_Real();

            var dsXuatKho = new List<ChiTietXuatNongDuoc>
            {
                new ChiTietXuatNongDuoc
                {
                    MaThuoc = "ND-TILT-01",
                    TenThuoc = "Tilt Super 300EC",
                    SoThung = 15,
                    DonGiaMoiThung = 4800000,
                    NgayXuat = DateTime.Now
                },
                new ChiTietXuatNongDuoc
                {
                    MaThuoc = "ND-ANVIL-02",
                    TenThuoc = "Anvil 5SC (Chai 1L)",
                    SoThung = 20,
                    DonGiaMoiThung = 3600000,
                    NgayXuat = DateTime.Now
                },
                new ChiTietXuatNongDuoc
                {
                    MaThuoc = "ND-CHESS-03",
                    TenThuoc = "Chess 50WG (Gói trị rầy)",
                    SoThung = 8,
                    DonGiaMoiThung = 5200000,
                    NgayXuat = DateTime.Now
                }
            };

            real.InBangKeXuatKho(dsXuatKho);
        }
    }
}
using System;
using DPM235424_NguyenDucHuy_Refact_16_IntroduceForeignMethod.Before;
using DPM235424_NguyenDucHuy_Refact_16_IntroduceForeignMethod.After;
using DPM235424_NguyenDucHuy_Refact_16_IntroduceForeignMethod.Real;

namespace DPM235424_NguyenDucHuy_Refact_16_IntroduceForeignMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine(">>> 1. DEMO CLASS: IntroduceForeignMethod_Before <<<");
            var before = new IntroduceForeignMethod_Before();
            before.SchedulePayment();

            Console.WriteLine("\n>>> 2. DEMO CLASS: IntroduceForeignMethod_After <<<");
            var after = new IntroduceForeignMethod_After();
            after.SchedulePayment();

            Console.WriteLine("\n>>> 3. DEMO CLASS: IntroduceForeignMethod_Real (NÔNG DƯỢC AN GIANG) <<<");
            var real = new IntroduceForeignMethod_Real
            {
                MaLoThuoc = "LO-FILIA-2026-A",
                TenThuoc = "Filia 525SE (Đặc trị đạo ôn lúa)",
                NgayXuatBan = new DateTime(2026, 10, 1),
                ThoiGianCachLyNgay = 14,
                HanNoNgay = 30
            };

            real.InThongTinTheoDoi();
        }
    }
}
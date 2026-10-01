using System;
using DPM235424_NguyenDucHuy_Refact_17_IntroduceLocalExtension.Before;
using DPM235424_NguyenDucHuy_Refact_17_IntroduceLocalExtension.After;
using DPM235424_NguyenDucHuy_Refact_17_IntroduceLocalExtension.Real;

namespace DPM235424_NguyenDucHuy_Refact_17_IntroduceLocalExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine(">>> 1. DEMO CLASS: IntroduceLocalExtension_Before <<<");
            var before = new IntroduceLocalExtension_Before();
            before.ProcessSchedule();

            Console.WriteLine("\n>>> 2. DEMO CLASS: IntroduceLocalExtension_After <<<");
            var after = new IntroduceLocalExtension_After();
            after.ProcessSchedule();

            Console.WriteLine("\n>>> 3. DEMO CLASS: IntroduceLocalExtension_Real (NÔNG DƯỢC AN GIANG) <<<");
            var real = new IntroduceLocalExtension_Real(
                maLo: "LO-AMISTARTOP-2026",
                tenThuoc: "Amistar Top 325SC (Trừ bệnh lem lép hạt)",
                ngaySX: new DateTime(2026, 9, 20)
            );

            real.InLichTrinhKiemDinhVaLuuKho();
        }
    }
}
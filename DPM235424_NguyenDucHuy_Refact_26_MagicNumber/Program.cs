using System;
using DPM235424_NguyenDucHuy_Refact_26_MagicNumber.Before;
using DPM235424_NguyenDucHuy_Refact_26_MagicNumber.After;
using DPM235424_NguyenDucHuy_Refact_26_MagicNumber.Real;

namespace DPM235424_NguyenDucHuy_Refact_26_MagicNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine(">>> 1. DEMO CLASS: MagicNumber_Before <<<");
            var before = new MagicNumber_Before();
            Console.WriteLine(string.Format("Thế năng (Before): {0:F2} J", before.PotentialEnergy(10, 5)));
            Console.WriteLine(string.Format("Tổng thanh toán có VAT (Before): {0:N0} VNĐ", before.CalculateGrossTotal(1000000)));

            Console.WriteLine("\n>>> 2. DEMO CLASS: MagicNumber_After <<<");
            var after = new MagicNumber_After();
            Console.WriteLine(string.Format("Thế năng (After):  {0:F2} J", after.PotentialEnergy(10, 5)));
            Console.WriteLine(string.Format("Tổng thanh toán có VAT (After):  {0:N0} VNĐ", after.CalculateGrossTotal(1000000)));

            Console.WriteLine("\n>>> 3. DEMO CLASS: MagicNumber_Real (NÔNG DƯỢC AN GIANG) <<<");
            var real = new MagicNumber_Real();
            // Ruộng lúa 3 hecta (30.000 m²) tại Huyện Thoại Sơn, đơn hàng 25.000.000đ thuốc trừ sâu
            real.InHuongDanPhaCheVaThanhToan("Filia 525SE & Tilt Super", 30000, 25000000);
        }
    }
}
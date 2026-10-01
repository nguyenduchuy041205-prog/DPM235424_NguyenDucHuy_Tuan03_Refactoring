using System;
using DPM235424_NguyenDucHuy_Refact_06_SplitTemporaryVariable.Before;
using DPM235424_NguyenDucHuy_Refact_06_SplitTemporaryVariable.After;
using DPM235424_NguyenDucHuy_Refact_06_SplitTemporaryVariable.Real;

namespace DPM235424_NguyenDucHuy_Refact_06_SplitTemporaryVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine(">>> 1. DEMO CLASS: SplitTemporaryVariable_Before <<<");
            var before = new SplitTemporaryVariable_Before();
            before.CalculateGeometry();

            Console.WriteLine("\n>>> 2. DEMO CLASS: SplitTemporaryVariable_After <<<");
            var after = new SplitTemporaryVariable_After();
            after.CalculateGeometry();

            Console.WriteLine("\n>>> 3. DEMO CLASS: SplitTemporaryVariable_Real (NÔNG DƯỢC AN GIANG) <<<");
            var real = new SplitTemporaryVariable_Real();
            // Giao 500kg phân bón và thuốc sâu: 30km đường bộ và 10km đường sông rạch
            real.TinhChiPhiGiaoHangNongDuoc(
                maDonHang: "DH-NDAG-889",
                tongKhoiLuongKg: 500,
                kmDuongBo: 30,
                kmDuongThuy: 10
            );
        }
    }
}
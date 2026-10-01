using System;
using DPM235424_NguyenDucHuy_Refact_03_ExtractVariable.Before;
using DPM235424_NguyenDucHuy_Refact_03_ExtractVariable.After;
using DPM235424_NguyenDucHuy_Refact_03_ExtractVariable.Real;

namespace DPM235424_NguyenDucHuy_Refact_03_ExtractVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine(">>> 1. DEMO CLASS: ExtractVariable_Before <<<");
            var before = new ExtractVariable_Before();
            Console.WriteLine($"Giá tính được (Before): {before.Price(600, 10):N2}");

            Console.WriteLine("\n>>> 2. DEMO CLASS: ExtractVariable_After <<<");
            var after = new ExtractVariable_After();
            Console.WriteLine($"Giá tính được (After):  {after.Price(600, 10):N2}");

            Console.WriteLine("\n>>> 3. DEMO CLASS: ExtractVariable_Real (NÔNG DƯỢC AN GIANG) <<<");
            var real = new ExtractVariable_Real();
            // Đơn hàng mua sỉ 250 chai thuốc rầy Regent 800WG, giao xa 25km, bốc xếp nhanh
            real.TinhTongChiPhiDonHang(
                soChaiThuoc: 250,
                giaMoiChai: 180000,
                khoangCachKm: 25,
                yeuCauBocVacNhanh: true
            );
        }
    }
}
using System;
using DPM235424_NguyenDucHuy_Refact_18_SelfEncapsulateField.Before;
using DPM235424_NguyenDucHuy_Refact_18_SelfEncapsulateField.After;
using DPM235424_NguyenDucHuy_Refact_18_SelfEncapsulateField.Real;

namespace DPM235424_NguyenDucHuy_Refact_18_SelfEncapsulateField
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine(">>> 1. DEMO CLASS: SelfEncapsulateField_Before <<<");
            var before = new SelfEncapsulateField_Before(10, 50);
            Console.WriteLine($"Thuộc khoảng [10, 50]? (Val=30): {before.Includes(30)}");

            Console.WriteLine("\n>>> 2. DEMO CLASS: SelfEncapsulateField_After <<<");
            var afterCapped = new CappedRange(10, 100, 40); // High bị khống chế tối đa 40
            Console.WriteLine($"Thuộc khoảng capped [10, 40]? (Val=50): {afterCapped.Includes(50)}");

            Console.WriteLine("\n>>> 3. DEMO CLASS: SelfEncapsulateField_Real (NÔNG DƯỢC AN GIANG) <<<");
            var real = new SelfEncapsulateField_Real();
            real.ChayNghiepVuKiemKho();
        }
    }
}
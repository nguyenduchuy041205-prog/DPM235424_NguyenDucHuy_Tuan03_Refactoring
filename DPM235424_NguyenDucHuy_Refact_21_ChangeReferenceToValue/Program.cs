using System;
using DPM235424_NguyenDucHuy_Refact_21_ChangeReferenceToValue.Before;
using DPM235424_NguyenDucHuy_Refact_21_ChangeReferenceToValue.After;
using DPM235424_NguyenDucHuy_Refact_21_ChangeReferenceToValue.Real;

namespace DPM235424_NguyenDucHuy_Refact_21_ChangeReferenceToValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine(">>> 1. DEMO CLASS: ChangeReferenceToValue_Before <<<");
            var before = new ChangeReferenceToValue_Before();
            Console.WriteLine($"Hai đối tượng tiền tệ có bằng nhau không? {before.CompareCurrencies()} (False vì so sánh tham chiếu)");

            Console.WriteLine("\n>>> 2. DEMO CLASS: ChangeReferenceToValue_After <<<");
            var after = new ChangeReferenceToValue_After();
            Console.WriteLine($"Hai đối tượng tiền tệ có bằng nhau không? {after.CompareCurrencies()} (True vì đã chuyển thành Value Object)");

            Console.WriteLine("\n>>> 3. DEMO CLASS: ChangeReferenceToValue_Real (NÔNG DƯỢC AN GIANG) <<<");
            var real = new ChangeReferenceToValue_Real();
            real.KiemTraQuyChuanLieuLuong();
        }
    }
}
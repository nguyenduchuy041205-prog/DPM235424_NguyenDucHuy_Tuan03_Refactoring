using System;
using System.Collections.Generic;
using DPM235424_NguyenDucHuy_Refact_29_ReplaceRecord.Before;
using DPM235424_NguyenDucHuy_Refact_29_ReplaceRecord.After;
using DPM235424_NguyenDucHuy_Refact_29_ReplaceRecord.Real;

namespace DPM235424_NguyenDucHuy_Refact_29_ReplaceRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine(">>> 1. DEMO CLASS: ReplaceRecord_Before (Dùng Dictionary thô) <<<");
            var before = new ReplaceRecord_Before();
            var record = before.CreatePersonRecord();
            before.PrintRecord(record);

            Console.WriteLine("\n>>> 2. DEMO CLASS: ReplaceRecord_After (Dùng Data Class tường minh) <<<");
            var after = new ReplaceRecord_After();
            var person = after.CreatePerson();
            after.PrintPerson(person);

            Console.WriteLine("\n>>> 3. DEMO CLASS: ReplaceRecord_Real (NÔNG DƯỢC AN GIANG) <<<");
            var real = new ReplaceRecord_Real();
            real.ChayChuongTrinhKiemNghiem();
        }
    }
}
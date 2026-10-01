using System;
using DPM235424_NguyenDucHuy_Refact_23_DuplicateObservedData.Before;
using DPM235424_NguyenDucHuy_Refact_23_DuplicateObservedData.After;
using DPM235424_NguyenDucHuy_Refact_23_DuplicateObservedData.Real;

namespace DPM235424_NguyenDucHuy_Refact_23_DuplicateObservedData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine(">>> 1. DEMO CLASS: DuplicateObservedData_Before <<<");
            var before = new DuplicateObservedData_Before();
            before.TxtEnd = "220";
            before.OnEndLostFocus();

            Console.WriteLine("\n>>> 2. DEMO CLASS: DuplicateObservedData_After <<<");
            var after = new DuplicateObservedData_After();
            after.UserChangesEnd("300"); // Model tính lại, event tự bắn sang UI

            Console.WriteLine("\n>>> 3. DEMO CLASS: DuplicateObservedData_Real (NÔNG DƯỢC AN GIANG) <<<");
            var real = new DuplicateObservedData_Real("LO-TILTSUPER-2026", "Tilt Super 300EC");

            // Lần 1: Nhập đợt đầu 50 thùng @ 4.200.000 VNĐ
            real.NhanVienNhapKho(50, 4200000);

            // Lần 2: Điều chỉnh số thùng lên 80 khi xe tải thứ hai bốc thêm
            real.NhanVienNhapKho(80, 4200000);
        }
    }
}
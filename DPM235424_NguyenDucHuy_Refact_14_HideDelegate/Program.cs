using System;
using DPM235424_NguyenDucHuy_Refact_14_HideDelegate.Before;
using DPM235424_NguyenDucHuy_Refact_14_HideDelegate.After;
using DPM235424_NguyenDucHuy_Refact_14_HideDelegate.Real;

namespace DPM235424_NguyenDucHuy_Refact_14_HideDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine(">>> 1. DEMO CLASS: HideDelegate_Before (Lộ chuỗi liên kết) <<<");
            var before = new HideDelegate_Before();
            // Client phải tự tìm hiểu cấu trúc Department
            Console.WriteLine($"Quản lý của {before.Name}: {before.Department.Manager}");

            Console.WriteLine("\n>>> 2. DEMO CLASS: HideDelegate_After (Đã ẩn ủy quyền) <<<");
            var after = new HideDelegate_After();
            // Client gọi trực tiếp hàm bọc
            Console.WriteLine($"Quản lý của {after.Name}: {after.GetManager()}");

            Console.WriteLine("\n>>> 3. DEMO CLASS: HideDelegate_Real (NÔNG DƯỢC AN GIANG) <<<");
            var real = new HideDelegate_Real();
            real.InThongTinDuyetHoaDon();
        }
    }
}
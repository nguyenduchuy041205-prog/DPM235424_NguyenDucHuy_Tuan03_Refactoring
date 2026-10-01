using System;
using DPM235424_NguyenDucHuy_Refact_30_TypeCodeWithClass.Before;
using DPM235424_NguyenDucHuy_Refact_30_TypeCodeWithClass.After;
using DPM235424_NguyenDucHuy_Refact_30_TypeCodeWithClass.Real;

namespace DPM235424_NguyenDucHuy_Refact_30_TypeCodeWithClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine(">>> 1. DEMO CLASS: TypeCodeWithClass_Before (Dùng Type Code int) <<<");
            var before = new TypeCodeWithClass_Before(TypeCodeWithClass_Before.A);
            Console.WriteLine(string.Format("Mã nhóm máu dạng số: {0}", before.BloodGroup));
            // Nhược điểm: có thể vô tình gán số không tồn tại
            before.BloodGroup = 999;
            Console.WriteLine(string.Format("Bị gán sai giá trị ngoài danh mục: {0}", before.BloodGroup));

            Console.WriteLine("\n>>> 2. DEMO CLASS: TypeCodeWithClass_After (Dùng Class an toàn kiểu) <<<");
            var after = new TypeCodeWithClass_After(BloodGroup.A);
            Console.WriteLine(string.Format("Nhóm máu: {0} (Mã chuẩn: {1})", after.BloodGroup.Name, after.BloodGroup.Code));

            Console.WriteLine("\n>>> 3. DEMO CLASS: TypeCodeWithClass_Real (NÔNG DƯỢC AN GIANG) <<<");
            var real = new TypeCodeWithClass_Real();
            real.QuanLyNhanThuocBVTV();
        }
    }
}
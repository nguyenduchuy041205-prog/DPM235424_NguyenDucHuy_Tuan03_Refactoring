using System;
using System.Collections.Generic;
using DPM235424_NguyenDucHuy_Refact_28_EncapsulateColl.Before;
using DPM235424_NguyenDucHuy_Refact_28_EncapsulateColl.After;
using DPM235424_NguyenDucHuy_Refact_28_EncapsulateColl.Real;

namespace DPM235424_NguyenDucHuy_Refact_28_EncapsulateColl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine(">>> 1. DEMO CLASS: EncapsulateColl_Before <<<");
            var before = new EncapsulateColl_Before();
            before.Courses.Add(new Before.Course("C# Căn bản", false));
            before.Courses = new List<Before.Course>(); // Bị gán đè mất dữ liệu trực tiếp từ bên ngoài
            Console.WriteLine(string.Format("Số khóa học sau khi bị gán đè: {0}", before.Courses.Count));

            Console.WriteLine("\n>>> 2. DEMO CLASS: EncapsulateColl_After <<<");
            var after = new EncapsulateColl_After();
            after.AddCourse(new After.Course("Kiến trúc phần mềm", true));
            after.AddCourse(new After.Course("Refactoring Martin Fowler", true));
            after.AddCourse(new After.Course("Nhập môn lập trình", false));
            Console.WriteLine(string.Format("Tổng số khóa: {0} | Khóa nâng cao: {1}",
                after.Courses.Count, after.NumberOfAdvancedCourses()));

            Console.WriteLine("\n>>> 3. DEMO CLASS: EncapsulateColl_Real (NÔNG DƯỢC AN GIANG) <<<");
            var real = new EncapsulateColl_Real();

            // Thử thêm 3 mặt hàng
            var sp1 = new MatHangXuatKho("LO-FILIA-01", "Filia 525SE (Đạo ôn)", 50, 15.0, 5200000, true);
            var sp2 = new MatHangXuatKho("LO-CHESS-02", "Chess 50WG (Trừ rầy)", 80, 10.0, 4800000, true);
            var spHetHan = new MatHangXuatKho("LO-CU-03", "Thuốc cũ tồn kho", 20, 12.0, 2000000, false);
            var spQuaTai = new MatHangXuatKho("LO-URE-04", "Phân đạm Urê hạt vàng", 100, 25.0, 800000, true); // 2.500 kg -> Quá tải

            real.ThemMatHang(sp1);
            real.ThemMatHang(sp2);
            real.ThemMatHang(spHetHan); // Sẽ bị từ chối do hết hạn
            real.ThemMatHang(spQuaTai); // Sẽ bị từ chối do vượt tải trọng 3 tấn

            Console.WriteLine();
            real.InLenhDieuXeXuatKho();
        }
    }
}
using System;
using DPM235424_NguyenDucHuy_Refact_15_RemoveMiddleMan.Before;
using DPM235424_NguyenDucHuy_Refact_15_RemoveMiddleMan.After;
using DPM235424_NguyenDucHuy_Refact_15_RemoveMiddleMan.Real;

namespace DPM235424_NguyenDucHuy_Refact_15_RemoveMiddleMan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine(">>> 1. DEMO CLASS: RemoveMiddleMan_Before (Qua hàm trung gian) <<<");
            var before = new RemoveMiddleMan_Before();
            Console.WriteLine($"Người quản lý: {before.GetManager()}");
            Console.WriteLine($"Mã bộ phận:    {before.GetDepartmentCode()}");

            Console.WriteLine("\n>>> 2. DEMO CLASS: RemoveMiddleMan_After (Bỏ trung gian, gọi trực tiếp) <<<");
            var after = new RemoveMiddleMan_After();
            Console.WriteLine($"Người quản lý: {after.Department.Manager}");
            Console.WriteLine($"Mã bộ phận:    {after.Department.DepartmentCode}");

            Console.WriteLine("\n>>> 3. DEMO CLASS: RemoveMiddleMan_Real (NÔNG DƯỢC AN GIANG) <<<");
            var real = new RemoveMiddleMan_Real
            {
                MaPhieuXuat = "PXK-AG-2026-15",
                DaiLyNhanHang = "Đại lý Vật tư Nông nghiệp Tân Châu",
                SoLuongXuat = 150,
                DonGia = 185000,
                LoThuoc = new ThongTinLoThuoc
                {
                    MaLo = "LO-SYNGENTA-2026",
                    TenThuoc = "Chess 50WG (Đặc trị rầy nâu kháng thuốc)",
                    NgaySanXuat = new DateTime(2026, 1, 15),
                    HanSuDung = new DateTime(2028, 1, 15),
                    NhaSanXuat = "Syngenta Crop Protection",
                    DieuKienBaoQuan = "Nhiệt độ phòng < 30°C, nơi khô ráo, tránh ánh sáng trực tiếp"
                }
            };

            real.InThongTinPhieuXuat();
        }
    }
}
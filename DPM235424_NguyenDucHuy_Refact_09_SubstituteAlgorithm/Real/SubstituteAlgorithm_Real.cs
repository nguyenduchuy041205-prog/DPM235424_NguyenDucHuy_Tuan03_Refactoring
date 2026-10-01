using System;
using System.Collections.Generic;
using System.Linq;

namespace DPM235424_NguyenDucHuy_Refact_09_SubstituteAlgorithm.Real
{
    public class LoThuocKho
    {
        public string MaLo { get; set; } = string.Empty;
        public string TenThuoc { get; set; } = string.Empty;
        public int SoLuongTon { get; set; }
        public DateTime HanSuDung { get; set; }
        public string TinhTrang { get; set; } = "Bình thường";
    }

    public class SubstituteAlgorithm_Real
    {
        // Thuật toán cũ: duyệt for lồng nhau kiểm tra từng ngày
        // Thuật toán mới (Substitute Algorithm): Dùng LINQ lọc nhanh các lô cận date (dưới 60 ngày) và tồn kho lớn
        public List<LoThuocKho> LocLoThuocCanhBaoUuTienXuat(List<LoThuocKho> danhSachKho, int soNgayCanhBao)
        {
            DateTime ngayMoc = DateTime.Now.AddDays(soNgayCanhBao);

            // Thay thế bằng cú pháp LINQ khai báo rõ ràng, dễ bảo trì
            return danhSachKho
                .Where(lo => lo.HanSuDung <= ngayMoc && lo.SoLuongTon > 0)
                .OrderBy(lo => lo.HanSuDung) // Ưu tiên hết hạn trước xuất trước (FIFO)
                .ToList();
        }

        public void InBaoCaoCanhBaoKho(List<LoThuocKho> danhSachCanhBao)
        {
            Console.WriteLine("========================================================================");
            Console.WriteLine("  CÔNG TY NÔNG DƯỢC AN GIANG - DANH SÁCH LÔ THUỐC CẦN XUẤT GẤP (CẬN DATE) ");
            Console.WriteLine("========================================================================");
            Console.WriteLine(string.Format("{0,-12} | {1,-22} | {2,8} | {3,-12}", "Mã Lô", "Tên Thuốc", "Tồn Kho", "Hạn Sử Dụng"));
            Console.WriteLine("------------------------------------------------------------------------");

            foreach (var lo in danhSachCanhBao)
            {
                Console.WriteLine(string.Format("{0,-12} | {1,-22} | {2,8} | {3,-12:dd/MM/yyyy}",
                    lo.MaLo, lo.TenThuoc, lo.SoLuongTon, lo.HanSuDung));
            }
            Console.WriteLine("========================================================================");
        }
    }
}
using System;

namespace DPM235424_NguyenDucHuy_Refact_02_InlineMethod.Real
{
    public class LoThuocNongDuoc
    {
        public string MaLo { get; set; } = string.Empty;
        public string TenThuoc { get; set; } = string.Empty;
        public int SoLuongTon { get; set; }
        public DateTime HanSuDung { get; set; }
    }

    public class InlineMethod_Real
    {
        // Áp dụng Inline Method: đưa điều kiện kiểm tra tồn và hạn dùng trực tiếp vào quy trình xuất kho
        public bool KiemTraXuatKhoHopLe(LoThuocNongDuoc loThuoc, int soLuongCanXuat)
        {
            // Inline trực tiếp điều kiện kiểm tra
            bool duSoLuongTon = loThuoc.SoLuongTon >= soLuongCanXuat;
            bool conHanSuDung = loThuoc.HanSuDung > DateTime.Now;

            if (!duSoLuongTon)
            {
                Console.WriteLine($"[CẢNH BÁO KHO] Lô {loThuoc.MaLo} không đủ số lượng xuất! (Tồn: {loThuoc.SoLuongTon}, Cần: {soLuongCanXuat})");
                return false;
            }

            if (!conHanSuDung)
            {
                Console.WriteLine($"[CẢNH BÁO KHO] Thuốc {loThuoc.TenThuoc} (Lô {loThuoc.MaLo}) đã hết hạn sử dụng ({loThuoc.HanSuDung:dd/MM/yyyy})!");
                return false;
            }

            Console.WriteLine($"[HỢP LỆ] Đủ điều kiện xuất kho {soLuongCanXuat} đơn vị từ lô {loThuoc.MaLo} ({loThuoc.TenThuoc}).");
            return true;
        }
    }
}
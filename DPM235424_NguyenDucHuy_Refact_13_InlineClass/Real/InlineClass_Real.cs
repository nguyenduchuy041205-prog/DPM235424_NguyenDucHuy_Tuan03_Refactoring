using System;

namespace DPM235424_NguyenDucHuy_Refact_13_InlineClass.Real
{
    public class InlineClass_Real
    {
        public string MaPhieuXuat { get; set; } = string.Empty;
        public string TenKhachHang { get; set; } = string.Empty;
        public string TenThuoc { get; set; } = string.Empty;
        public int SoLuongXuat { get; set; }
        public double DonGia { get; set; }

        // Đã inline thông tin kho trực tiếp vào phiếu xuất, loại bỏ class DiaDiemKho dư thừa
        public string MaKhoXuat { get; set; } = string.Empty;
        public string TenDayKho { get; set; } = string.Empty;

        public double TinhTongTien() => SoLuongXuat * DonGia;

        public void InPhieuXuatKho()
        {
            Console.WriteLine("==================================================================");
            Console.WriteLine($" CÔNG TY NÔNG DƯỢC AN GIANG - PHIẾU XUẤT KHO NỘI BỘ");
            Console.WriteLine("==================================================================");
            Console.WriteLine($" Mã phiếu:     {MaPhieuXuat} | Khách hàng: {TenKhachHang}");
            Console.WriteLine($" Vị trí xuất:  Kho [{MaKhoXuat}] - {TenDayKho}");
            Console.WriteLine($" Mặt hàng:     {TenThuoc} | SL: {SoLuongXuat,4} | Đơn giá: {DonGia,10:N0} VNĐ");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine($" TỔNG GIÁ TRỊ: {TinhTongTien(),15:N0} VNĐ");
            Console.WriteLine("==================================================================");
        }
    }
}
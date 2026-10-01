using System;

namespace DPM235424_NguyenDucHuy_Refact_04_InlineTemp.Real
{
    public class PhieuXuatKho
    {
        public string MaPhieu { get; set; } = string.Empty;
        public string TenDaiLy { get; set; } = string.Empty;
        public int SoThungThuocBVTV { get; set; }
        public double DonGiaMoiThung { get; set; }

        public double TinhTienHang()
        {
            return SoThungThuocBVTV * DonGiaMoiThung;
        }
    }

    public class InlineTemp_Real
    {
        // Áp dụng Inline Temp: Kiểm tra trực tiếp giá trị tính được từ phiếu xuất
        // mà không cần tạo biến tạm double tongTien = phieu.TinhTienHang()
        public bool DuDieuKienChietKhauVIP(PhieuXuatKho phieu)
        {
            const double NGUONG_VIP = 15000000.0;

            // Inline biểu thức TinhTienHang() trực tiếp vào điều kiện
            if (phieu.TinhTienHang() >= NGUONG_VIP)
            {
                Console.WriteLine($"[ĐẠI LÝ VIP] Đại lý {phieu.TenDaiLy} đạt giá trị đơn {phieu.TinhTienHang():N0} VNĐ -> Đủ điều kiện nhận chiết khấu sỉ 7%!");
                return true;
            }

            Console.WriteLine($"[BÁN THƯỜNG] Đại lý {phieu.TenDaiLy} có giá trị đơn {phieu.TinhTienHang():N0} VNĐ -> Chưa đạt ngưỡng VIP ({NGUONG_VIP:N0} VNĐ).");
            return false;
        }
    }
}
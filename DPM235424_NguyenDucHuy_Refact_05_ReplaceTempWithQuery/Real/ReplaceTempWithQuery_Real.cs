using System;

namespace DPM235424_NguyenDucHuy_Refact_05_ReplaceTempWithQuery.Real
{
    public class ReplaceTempWithQuery_Real
    {
        public string MaLoThuoc { get; set; } = string.Empty;
        public string TenThuoc { get; set; } = string.Empty;
        public int SoLuongChai { get; set; }
        public double DonGiaChai { get; set; }
        public int SoNgayLuuKho { get; set; }

        // Thay biến tạm bằng Query: Tính tiền gốc lô hàng
        public double TinhTienGoc()
        {
            return SoLuongChai * DonGiaChai;
        }

        // Thay biến tạm bằng Query: Tỷ lệ chiết khấu dựa trên hạn mức giá trị lô
        public double LayTyLeChietKhau()
        {
            if (TinhTienGoc() >= 50000000) // Đơn hàng nông dược lớn trên 50 triệu
            {
                return 0.08; // Giảm 8%
            }
            else if (TinhTienGoc() >= 20000000)
            {
                return 0.05; // Giảm 5%
            }
            return 0.0;
        }

        // Thay biến tạm bằng Query: Tính phụ phí bảo quản thuốc BVTV độc hại theo ngày lưu kho
        public double TinhPhiLuuKhoBaoQuan()
        {
            const double PHI_MOI_NGAY = 15000.0;
            return SoNgayLuuKho * PHI_MOI_NGAY;
        }

        // Phương thức tính tổng thanh toán cuối cùng không còn chứa biến tạm rối rắm
        public double TinhTongThanhToan()
        {
            double tienGoc = TinhTienGoc();
            double tienGiamGia = tienGoc * LayTyLeChietKhau();
            double phiLuuKho = TinhPhiLuuKhoBaoQuan();

            return tienGoc - tienGiamGia + phiLuuKho;
        }

        public void InThongTinPhieu()
        {
            Console.WriteLine("----- CHI TIẾT TÍNH PHÍ XUẤT LÔ THUỐC BVTV -----");
            Console.WriteLine($"Thuốc: {TenThuoc} (Lô: {MaLoThuoc})");
            Console.WriteLine($"Số lượng: {SoLuongChai} chai | Đơn giá: {DonGiaChai:N0} VNĐ");
            Console.WriteLine($"Tiền gốc:                {TinhTienGoc(),15:N0} VNĐ");
            Console.WriteLine($"Chiết khấu ({LayTyLeChietKhau() * 100}%):        -{TinhTienGoc() * LayTyLeChietKhau(),15:N0} VNĐ");
            Console.WriteLine($"Phí kho ({SoNgayLuuKho} ngày):          {TinhPhiLuuKhoBaoQuan(),15:N0} VNĐ");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine($"TỔNG THANH TOÁN:         {TinhTongThanhToan(),15:N0} VNĐ");
        }
    }
}
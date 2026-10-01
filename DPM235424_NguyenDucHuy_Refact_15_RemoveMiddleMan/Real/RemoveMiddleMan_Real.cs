using System;

namespace DPM235424_NguyenDucHuy_Refact_15_RemoveMiddleMan.Real
{
    // Chi tiết kỹ thuật và xuất xứ của lô thuốc BVTV
    public class ThongTinLoThuoc
    {
        public string MaLo { get; set; } = string.Empty;
        public string TenThuoc { get; set; } = string.Empty;
        public DateTime NgaySanXuat { get; set; }
        public DateTime HanSuDung { get; set; }
        public string NhaSanXuat { get; set; } = string.Empty;
        public string DieuKienBaoQuan { get; set; } = string.Empty;

        public bool KiemTraConHan() => HanSuDung > DateTime.Now;
    }

    public class RemoveMiddleMan_Real
    {
        public string MaPhieuXuat { get; set; } = string.Empty;
        public string DaiLyNhanHang { get; set; } = string.Empty;
        public int SoLuongXuat { get; set; }
        public double DonGia { get; set; }

        // Bỏ các hàm trung gian: Cho phép truy cập trực tiếp đối tượng ThongTinLoThuoc
        public ThongTinLoThuoc LoThuoc { get; set; } = new ThongTinLoThuoc();

        public double TinhThanhTien() => SoLuongXuat * DonGia;

        public void InThongTinPhieuXuat()
        {
            Console.WriteLine("==========================================================================");
            Console.WriteLine($" CÔNG TY NÔNG DƯỢC AN GIANG - PHIẾU XUẤT LÔ THUỐC BẢO VỆ THỰC VẬT");
            Console.WriteLine("==========================================================================");
            Console.WriteLine($" Mã phiếu:          {MaPhieuXuat} | Đại lý tiếp nhận: {DaiLyNhanHang}");
            Console.WriteLine($" Tên sản phẩm:      {LoThuoc.TenThuoc} (Lô: {LoThuoc.MaLo})");
            Console.WriteLine($" Hãng sản xuất:     {LoThuoc.NhaSanXuat}");
            Console.WriteLine($" Hạn sử dụng:       {LoThuoc.HanSuDung:dd/MM/yyyy} - Trạng thái: {(LoThuoc.KiemTraConHan() ? "Đạt chuẩn xuất" : "HẾT HẠN")}");
            Console.WriteLine($" Điều kiện bảo lưu: {LoThuoc.DieuKienBaoQuan}");
            Console.WriteLine($" Số lượng xuất:     {SoLuongXuat,6} chai/gói | Đơn giá: {DonGia,12:N0} VNĐ");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine($" TỔNG GIÁ TRỊ XUẤT: {TinhThanhTien(),15:N0} VNĐ");
            Console.WriteLine("==========================================================================");
        }
    }
}
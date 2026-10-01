using System;

namespace DPM235424_NguyenDucHuy_Refact_11_MoveField.Real
{
    // Lớp đại diện cho phân cấp đối tác phân phối nông dược
    public class NhomDaiLy
    {
        public string MaNhom { get; set; } = string.Empty;
        public string TenNhom { get; set; } = string.Empty;
        // Di chuyển trường tỷ lệ chiết khấu về đúng đối tượng quản lý chính sách đại lý
        public double TyLeChietKhau { get; set; }
    }

    public class MoveField_Real
    {
        public string MaHoaDon { get; set; } = string.Empty;
        public string TenKhachHang { get; set; } = string.Empty;
        public NhomDaiLy HangDaiLy { get; set; } = new NhomDaiLy();
        public double TongTienHang { get; set; }

        public double TinhTienChietKhau()
        {
            // Truy xuất tỷ lệ chiết khấu trực tiếp từ lớp NhomDaiLy
            return TongTienHang * (HangDaiLy.TyLeChietKhau / 100.0);
        }

        public double TinhTongThanhToan()
        {
            return TongTienHang - TinhTienChietKhau();
        }

        public void InThongTinHoaDon()
        {
            Console.WriteLine("==================================================================");
            Console.WriteLine($" CÔNG TY NÔNG DƯỢC AN GIANG - HÓA ĐƠN {MaHoaDon}");
            Console.WriteLine("==================================================================");
            Console.WriteLine($" Đại lý:           {TenKhachHang}");
            Console.WriteLine($" Phân cấp:         {HangDaiLy.TenNhom} (Chiết khấu {HangDaiLy.TyLeChietKhau}%)");
            Console.WriteLine($" Tiền hàng gốc:    {TongTienHang,15:N0} VNĐ");
            Console.WriteLine($" Tiền chiết khấu: -{TinhTienChietKhau(),15:N0} VNĐ");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine($" TỔNG THANH TOÁN:  {TinhTongThanhToan(),15:N0} VNĐ");
            Console.WriteLine("==================================================================");
        }
    }
}
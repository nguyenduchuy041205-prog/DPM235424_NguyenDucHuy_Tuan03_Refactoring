using System;
using System.Collections.Generic;

namespace DPM235424_NguyenDucHuy_Refact_19_ReplaceDataValueWithObject.Real
{
    // Lớp đối tượng thay thế cho chuỗi tên đại lý đơn thuần
    public class DaiLyNongNghiep
    {
        public string MaSoThue { get; set; } = string.Empty;
        public string TenDaiLy { get; set; } = string.Empty;
        public string DiaChiHuyen { get; set; } = string.Empty;
        public string SoDienThoai { get; set; } = string.Empty;
        public double HanMucNoToiDa { get; set; }

        public DaiLyNongNghiep(string mst, string ten, string diaChi, string sdt, double hanMucNo)
        {
            MaSoThue = mst;
            TenDaiLy = ten;
            DiaChiHuyen = diaChi;
            SoDienThoai = sdt;
            HanMucNoToiDa = hanMucNo;
        }

        public string LayThongTinXuatHoaDon()
        {
            return $"{TenDaiLy} (MST: {MaSoThue}) - Đ/c: {DiaChiHuyen} - ĐT: {SoDienThoai}";
        }
    }

    public class DonHangNongDuoc
    {
        public string MaDonHang { get; set; } = string.Empty;
        public DateTime NgayLap { get; set; } = DateTime.Now;
        public double TongGiaTri { get; set; }

        // Thay vì dùng string, sử dụng đối tượng DaiLyNongNghiep
        public DaiLyNongNghiep DaiLy { get; set; }

        public DonHangNongDuoc(string maDH, DaiLyNongNghiep daiLy, double tongGiaTri)
        {
            MaDonHang = maDH;
            DaiLy = daiLy;
            TongGiaTri = tongGiaTri;
        }
    }

    public class ReplaceDataValueWithObject_Real
    {
        public void KiemTraVaInDonHang(List<DonHangNongDuoc> danhSachDon)
        {
            Console.WriteLine("==========================================================================");
            Console.WriteLine("  CÔNG TY NÔNG DƯỢC AN GIANG - QUẢN LÝ ĐƠN HÀNG XUẤT CHO ĐẠI LÝ NÔNG NGHIỆP ");
            Console.WriteLine("==========================================================================");

            foreach (var don in danhSachDon)
            {
                Console.WriteLine($"Mã đơn: {don.MaDonHang} | Ngày: {don.NgayLap:dd/MM/yyyy}");
                Console.WriteLine($"Đại lý: {don.DaiLy.LayThongTinXuatHoaDon()}");
                Console.WriteLine($"Giá trị đơn: {don.TongGiaTri,15:N0} VNĐ | Hạn mức nợ: {don.DaiLy.HanMucNoToiDa,15:N0} VNĐ");

                if (don.TongGiaTri > don.DaiLy.HanMucNoToiDa)
                {
                    Console.WriteLine("  -> [CẢNH BÁO] Đơn hàng vượt hạn mức nợ cho phép của đại lý!");
                }
                else
                {
                    Console.WriteLine("  -> [HỢP LỆ] Đủ điều kiện xuất hàng gối đầu.");
                }
                Console.WriteLine("--------------------------------------------------------------------------");
            }
        }
    }
}
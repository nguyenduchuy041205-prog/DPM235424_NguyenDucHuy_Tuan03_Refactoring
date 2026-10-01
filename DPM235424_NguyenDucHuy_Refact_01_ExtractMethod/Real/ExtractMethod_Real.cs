using System;
using System.Collections.Generic;

namespace DPM235424_NguyenDucHuy_Refact_01_ExtractMethod.Real
{
    public class ChiTietLoThuoc
    {
        public string TenThuoc { get; set; } = string.Empty;
        public string MaLo { get; set; } = string.Empty;
        public int SoLuong { get; set; }
        public double DonGia { get; set; }
        public double ThanhTien => SoLuong * DonGia;
    }

    public class ExtractMethod_Real
    {
        public void LapHoaDonBanHang(
            string maHD,
            string tenDaiLy,
            List<ChiTietLoThuoc> danhSachThuoc,
            double phiVanChuyen,
            double phiBocVac,
            double phanTramChietKhau)
        {
            InTieuDeHoaDon(maHD, tenDaiLy);
            InDanhSachSanPham(danhSachThuoc);

            double tienHang = TinhTongTienHang(danhSachThuoc);
            double tienDichVu = TinhTongPhiDichVu(phiVanChuyen, phiBocVac);
            double tienChietKhau = TinhTienChietKhau(tienHang, phanTramChietKhau);
            double tongThanhToan = TinhTongThanhToan(tienHang, tienDichVu, tienChietKhau);

            InTongKetThanhToan(tienHang, tienDichVu, tienChietKhau, tongThanhToan);
        }

        private void InTieuDeHoaDon(string maHD, string tenDaiLy)
        {
            Console.WriteLine("==================================================================");
            Console.WriteLine("          CÔNG TY NÔNG DƯỢC AN GIANG - PHIẾU XUẤT BÁN HÀNG         ");
            Console.WriteLine($" Mã hóa đơn: {maHD} | Đại lý: {tenDaiLy}");
            Console.WriteLine("------------------------------------------------------------------");
        }

        private void InDanhSachSanPham(List<ChiTietLoThuoc> danhSach)
        {
            Console.WriteLine(string.Format("{0,-20} | {1,-10} | {2,6} | {3,12} | {4,14}", "Tên Thuốc", "Số Lô", "SL", "Đơn Giá", "Thành Tiền"));
            Console.WriteLine("------------------------------------------------------------------");
            foreach (var item in danhSach)
            {
                Console.WriteLine(string.Format("{0,-20} | {1,-10} | {2,6} | {3,12:N0} | {4,14:N0}",
                    item.TenThuoc, item.MaLo, item.SoLuong, item.DonGia, item.ThanhTien));
            }
            Console.WriteLine("------------------------------------------------------------------");
        }

        private double TinhTongTienHang(List<ChiTietLoThuoc> danhSach)
        {
            double tong = 0;
            foreach (var item in danhSach)
            {
                tong += item.ThanhTien;
            }
            return tong;
        }

        private double TinhTongPhiDichVu(double phiVanChuyen, double phiBocVac)
        {
            return phiVanChuyen + phiBocVac;
        }

        private double TinhTienChietKhau(double tienHang, double phanTram)
        {
            return tienHang * (phanTram / 100.0);
        }

        private double TinhTongThanhToan(double tienHang, double phiDichVu, double chietKhau)
        {
            return tienHang + phiDichVu - chietKhau;
        }

        private void InTongKetThanhToan(double tienHang, double tienDichVu, double chietKhau, double tongThanhToan)
        {
            Console.WriteLine($" Tiền hàng:                 {tienHang,15:N0} VNĐ");
            Console.WriteLine($" Chi phí vận chuyển & DV:   {tienDichVu,15:N0} VNĐ");
            Console.WriteLine($" Giảm giá / Chiết khấu:    -{chietKhau,15:N0} VNĐ");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine($" TỔNG THANH TOÁN:           {tongThanhToan,15:N0} VNĐ");
            Console.WriteLine("==================================================================");
        }
    }
}
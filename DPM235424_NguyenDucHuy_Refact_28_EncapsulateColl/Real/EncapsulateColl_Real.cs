using System;
using System.Collections.Generic;

namespace DPM235424_NguyenDucHuy_Refact_28_EncapsulateColl.Real
{
    public class MatHangXuatKho
    {
        public string MaLo { get; set; }
        public string TenThuoc { get; set; }
        public int SoThung { get; set; }
        public double TrongLuongMoiThungKg { get; set; }
        public double DonGiaMoiThung { get; set; }
        public bool ConHanSuDung { get; set; }

        public MatHangXuatKho(string maLo, string tenThuoc, int soThung, double trongLuongKg, double donGia, bool conHan)
        {
            MaLo = maLo;
            TenThuoc = tenThuoc;
            SoThung = soThung;
            TrongLuongMoiThungKg = trongLuongKg;
            DonGiaMoiThung = donGia;
            ConHanSuDung = conHan;
        }

        public double TinhTongTrongLuong() => SoThung * TrongLuongMoiThungKg;
        public double TinhThanhTien() => SoThung * DonGiaMoiThung;
    }

    public class EncapsulateColl_Real
    {
        public string MaLenhXuat { get; set; } = "LXK-DAPDICH-2026";
        public string DaiLyTiepNhan { get; set; } = "Đại lý VTNN Tri Tôn";
        public const double TAI_TRONG_XE_TOI_DA_KG = 3000.0; // Xe tải giao nhận 3 tấn

        private readonly List<MatHangXuatKho> _danhSachMatHang = new List<MatHangXuatKho>();

        // Đóng gói tập hợp: Bên ngoài chỉ được duyệt xem, không thể tự ý Add/Remove trực tiếp
        public IReadOnlyCollection<MatHangXuatKho> DanhSachMatHang
        {
            get { return _danhSachMatHang.AsReadOnly(); }
        }

        // Nghiệp vụ thêm mặt hàng có kiểm soát điều kiện an toàn & tải trọng xe
        public bool ThemMatHang(MatHangXuatKho matHang)
        {
            if (matHang == null) return false;

            if (!matHang.ConHanSuDung)
            {
                Console.WriteLine(string.Format("[TỪ CHỐI XUẤT] Lô thuốc {0} ({1}) ĐÃ HẾT HẠN SỬ DỤNG!", matHang.MaLo, matHang.TenThuoc));
                return false;
            }

            double tongTrongLuongSauKhiThem = TinhTongTrongLuongDonHang() + matHang.TinhTongTrongLuong();
            if (tongTrongLuongSauKhiThem > TAI_TRONG_XE_TOI_DA_KG)
            {
                Console.WriteLine(string.Format("[TỪ CHỐI XUẤT] Thêm {0} sẽ vượt tải trọng xe ({1:N0} kg > {2:N0} kg)!",
                    matHang.TenThuoc, tongTrongLuongSauKhiThem, TAI_TRONG_XE_TOI_DA_KG));
                return false;
            }

            _danhSachMatHang.Add(matHang);
            Console.WriteLine(string.Format("[ĐÃ TIẾP NHẬN] Thêm thành công {0} ({1} thùng) vào xe chuyển hàng.", matHang.TenThuoc, matHang.SoThung));
            return true;
        }

        public void XoaMatHangTheoMaLo(string maLo)
        {
            _danhSachMatHang.RemoveAll(x => x.MaLo == maLo);
        }

        public double TinhTongTrongLuongDonHang()
        {
            double tong = 0;
            foreach (var item in _danhSachMatHang)
            {
                tong += item.TinhTongTrongLuong();
            }
            return tong;
        }

        public double TinhTongGiaTriDonHang()
        {
            double tong = 0;
            foreach (var item in _danhSachMatHang)
            {
                tong += item.TinhThanhTien();
            }
            return tong;
        }

        public void InLenhDieuXeXuatKho()
        {
            Console.WriteLine("==========================================================================");
            Console.WriteLine(string.Format("  CÔNG TY NÔNG DƯỢC AN GIANG - LỆNH ĐIỀU ĐỘ XE GIAO HÀNG ({0})", MaLenhXuat));
            Console.WriteLine("==========================================================================");
            Console.WriteLine(string.Format("Đại lý thụ hưởng:   {0}", DaiLyTiepNhan));
            Console.WriteLine(string.Format("Tải trọng xe cấp:   {0:N0} kg", TAI_TRONG_XE_TOI_DA_KG));
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine(string.Format("{0,-12} | {1,-24} | {2,8} | {3,14}", "Mã Lô", "Tên Thuốc", "Số Thùng", "Thành Tiền"));
            Console.WriteLine("--------------------------------------------------------------------------");

            foreach (var sp in _danhSachMatHang)
            {
                Console.WriteLine(string.Format("{0,-12} | {1,-24} | {2,8} | {3,14:N0} VNĐ",
                    sp.MaLo, sp.TenThuoc, sp.SoThung, sp.TinhThanhTien()));
            }

            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine(string.Format("TỔNG TẢI TRỌNG HÀNG TRÊN XE: {0,10:N0} kg", TinhTongTrongLuongDonHang()));
            Console.WriteLine(string.Format("TỔNG GIÁ TRỊ LÔ XUẤT CẤP TỐC: {0,10:N0} VNĐ", TinhTongGiaTriDonHang()));
            Console.WriteLine("==========================================================================");
        }
    }
}
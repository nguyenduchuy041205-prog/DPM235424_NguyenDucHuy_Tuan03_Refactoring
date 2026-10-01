using System;
using System.Collections.Generic;

namespace DPM235424_NguyenDucHuy_Refact_20_ChangeValueToReference.Real
{
    // Đối tượng tham chiếu duy nhất của Đại lý nông nghiệp
    public class DaiLyThamChieu
    {
        private static readonly Dictionary<string, DaiLyThamChieu> _danhSachDaiLy = new Dictionary<string, DaiLyThamChieu>();

        public string MaDaiLy { get; }
        public string TenDaiLy { get; }
        public double TongCongNoHienTai { get; set; }

        private DaiLyThamChieu(string maDaiLy, string tenDaiLy)
        {
            MaDaiLy = maDaiLy;
            TenDaiLy = tenDaiLy;
            TongCongNoHienTai = 0;
        }

        // Registry / Factory Method lấy đại lý theo mã duy nhất
        public static DaiLyThamChieu LayDaiLy(string maDaiLy, string tenDaiLy = "")
        {
            if (!_danhSachDaiLy.ContainsKey(maDaiLy))
            {
                _danhSachDaiLy[maDaiLy] = new DaiLyThamChieu(maDaiLy, tenDaiLy);
            }
            return _danhSachDaiLy[maDaiLy];
        }

        public void GhiNhanNoMoi(double soTienNo)
        {
            TongCongNoHienTai += soTienNo;
        }
    }

    // Phiếu xuất kho nông dược liên kết tham chiếu tới Đại lý
    public class PhieuXuatKhoRef
    {
        public string MaPhieu { get; set; }
        public DaiLyThamChieu DaiLy { get; }
        public double TriGiaDon { get; set; }

        public PhieuXuatKhoRef(string maPhieu, string maDaiLy, string tenDaiLy, double triGia)
        {
            MaPhieu = maPhieu;
            // Trỏ đến cùng đối tượng tham chiếu đại lý
            DaiLy = DaiLyThamChieu.LayDaiLy(maDaiLy, tenDaiLy);
            TriGiaDon = triGia;
            DaiLy.GhiNhanNoMoi(triGia);
        }
    }

    public class ChangeValueToReference_Real
    {
        public void ThucThiQuanLyDonHang()
        {
            Console.WriteLine("==========================================================================");
            Console.WriteLine("  CÔNG TY NÔNG DƯỢC AN GIANG - QUẢN LÝ CÔNG NỢ ĐỒNG BỘ THEO ĐẠI LÝ        ");
            Console.WriteLine("==========================================================================");

            // Phiếu 1: Đại lý Chợ Mới lấy 20.000.000đ thuốc trừ sâu Regent
            var p1 = new PhieuXuatKhoRef("PXK-001", "DL-CHOMOI", "Đại lý VTNN Chợ Mới", 20000000);

            // Phiếu 2: Cùng là Đại lý Chợ Mới lấy thêm 15.000.000đ thuốc trừ bệnh Tilt Super
            var p2 = new PhieuXuatKhoRef("PXK-002", "DL-CHOMOI", "Đại lý VTNN Chợ Mới", 15000000);

            // Kiểm tra xem hai phiếu có cùng trỏ về một vùng nhớ của đại lý không
            bool cungThamChieu = ReferenceEquals(p1.DaiLy, p2.DaiLy);
            Console.WriteLine($"Phiếu 1 và Phiếu 2 cùng trỏ về 1 vùng nhớ đại lý? {cungThamChieu}");
            Console.WriteLine($"Mã đại lý:      {p1.DaiLy.MaDaiLy} - {p1.DaiLy.TenDaiLy}");
            Console.WriteLine($"Tổng công nợ tích lũy sau 2 đơn: {p1.DaiLy.TongCongNoHienTai:N0} VNĐ");
            Console.WriteLine("==========================================================================");
        }
    }
}
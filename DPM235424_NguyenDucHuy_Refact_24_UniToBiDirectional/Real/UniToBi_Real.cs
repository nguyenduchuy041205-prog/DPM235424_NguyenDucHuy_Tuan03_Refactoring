using System;
using System.Collections.Generic;

namespace DPM235424_NguyenDucHuy_Refact_24_UniToBi.Real
{
    public class HoaDonNongDuoc
    {
        public string MaHoaDon { get; set; }
        public string TenThuoc { get; set; }
        public double TongTien { get; set; }

        private DaiLyVatTu _daiLy;

        public HoaDonNongDuoc(string maHD, string tenThuoc, double tongTien)
        {
            MaHoaDon = maHD;
            TenThuoc = tenThuoc;
            TongTien = tongTien;
        }

        public DaiLyVatTu DaiLy
        {
            get { return _daiLy; }
            set
            {
                if (_daiLy != null)
                {
                    _daiLy.HuyHoaDonNoiBo(this);
                }

                _daiLy = value;

                if (_daiLy != null)
                {
                    _daiLy.ThemHoaDonNoiBo(this);
                }
            }
        }
    }

    public class DaiLyVatTu
    {
        public string MaDaiLy { get; set; }
        public string TenDaiLy { get; set; }
        public string DiaBan { get; set; }

        private readonly List<HoaDonNongDuoc> _danhSachHoaDon = new List<HoaDonNongDuoc>();

        public DaiLyVatTu(string maDL, string tenDL, string diaBan)
        {
            MaDaiLy = maDL;
            TenDaiLy = tenDL;
            DiaBan = diaBan;
        }

        public IEnumerable<HoaDonNongDuoc> DanhSachHoaDon
        {
            get { return _danhSachHoaDon; }
        }

        internal void ThemHoaDonNoiBo(HoaDonNongDuoc hd)
        {
            if (!_danhSachHoaDon.Contains(hd))
            {
                _danhSachHoaDon.Add(hd);
            }
        }

        internal void HuyHoaDonNoiBo(HoaDonNongDuoc hd)
        {
            _danhSachHoaDon.Remove(hd);
        }

        public double TinhTongCongNo()
        {
            double tong = 0;
            foreach (var hd in _danhSachHoaDon)
            {
                tong += hd.TongTien;
            }
            return tong;
        }
    }

    public class UniToBi_Real
    {
        public void ChayQuanLyCongNoHaiChieu()
        {
            Console.WriteLine("==========================================================================");
            Console.WriteLine(" CÔNG TY NÔNG DƯỢC AN GIANG - ĐỒNG BỘ LIÊN KẾT ĐẠI LÝ & HÓA ĐƠN XUẤT KHO  ");
            Console.WriteLine("==========================================================================");

            var daiLyTriTon = new DaiLyVatTu("DL-TRITON", "Đại lý VTNN Tri Tôn", "Huyện Tri Tôn");
            var daiLyChoMoi = new DaiLyVatTu("DL-CHOMOI", "Đại lý VTNN Chợ Mới", "Huyện Chợ Mới");

            var hd1 = new HoaDonNongDuoc("HD-01", "Tilt Super 300EC (40 thùng)", 18000000);
            var hd2 = new HoaDonNongDuoc("HD-02", "Anvil 5SC (25 thùng)", 12500000);

            // Gán đại lý cho hóa đơn (tự động cập nhật 2 chiều)
            hd1.DaiLy = daiLyTriTon;
            hd2.DaiLy = daiLyTriTon;

            Console.WriteLine(string.Format("Đại lý: {0} ({1})", daiLyTriTon.TenDaiLy, daiLyTriTon.DiaBan));
            foreach (var hd in daiLyTriTon.DanhSachHoaDon)
            {
                Console.WriteLine(string.Format(" - Hóa đơn: {0} | Sản phẩm: {1} | Trị giá: {2,12:N0} VNĐ",
                    hd.MaHoaDon, hd.TenThuoc, hd.TongTien));
            }
            Console.WriteLine(string.Format("-> Tổng công nợ ban đầu: {0,15:N0} VNĐ\n", daiLyTriTon.TinhTongCongNo()));

            // Điều chuyển hóa đơn HD-02 từ Tri Tôn sang Chợ Mới
            Console.WriteLine(">>> Điều phối chuyển Hóa đơn HD-02 sang Đại lý Chợ Mới <<<");
            hd2.DaiLy = daiLyChoMoi;

            Console.WriteLine(string.Format("Công nợ Tri Tôn sau khi điều chuyển: {0,15:N0} VNĐ", daiLyTriTon.TinhTongCongNo()));
            Console.WriteLine(string.Format("Công nợ Chợ Mới sau khi nhận đơn:    {0,15:N0} VNĐ", daiLyChoMoi.TinhTongCongNo()));
            Console.WriteLine("==========================================================================");
        }
    }
}
using System;

namespace DPM235424_NguyenDucHuy_Refact_23_DuplicateObservedData.Real
{
    // Domain Model: Chứa toàn bộ quy tắc nghiệp vụ hóa đơn nông dược
    public class DonHangXuatKhoModel
    {
        public string MaLoThuoc { get; set; }
        public string TenThuoc { get; set; }

        private int _soThung;
        private double _donGiaMoiThung;
        private double _thanhTien;
        private double _thueVAT;
        private double _tongThanhToan;

        // Sự kiện thông báo khi dữ liệu tài chính thay đổi
        public event Action<DonHangXuatKhoModel> DuLieuDonHangThayDoi;

        public int SoThung
        {
            get { return _soThung; }
            set
            {
                _soThung = value;
                TinhToanGiaTri();
            }
        }

        public double DonGiaMoiThung
        {
            get { return _donGiaMoiThung; }
            set
            {
                _donGiaMoiThung = value;
                TinhToanGiaTri();
            }
        }

        public double ThanhTien { get { return _thanhTien; } }
        public double ThueVAT { get { return _thueVAT; } }
        public double TongThanhToan { get { return _tongThanhToan; } }

        private void TinhToanGiaTri()
        {
            _thanhTien = _soThung * _donGiaMoiThung;
            _thueVAT = _thanhTien * 0.05; // Thuế suất 5% cho vật tư bảo vệ thực vật
            _tongThanhToan = _thanhTien + _thueVAT;

            if (DuLieuDonHangThayDoi != null)
            {
                DuLieuDonHangThayDoi.Invoke(this);
            }
        }
    }

    // View: Màn hình giám sát xuất kho tại cửa khẩu kho tổng An Giang
    public class DuplicateObservedData_Real
    {
        private DonHangXuatKhoModel _donHang;

        public DuplicateObservedData_Real(string maLo, string tenThuoc)
        {
            _donHang = new DonHangXuatKhoModel
            {
                MaLoThuoc = maLo,
                TenThuoc = tenThuoc
            };

            // Đăng ký nhận thông báo để render lại giao diện màn hình
            _donHang.DuLieuDonHangThayDoi += CapNhatManHinhGiamSatKho;
        }

        public void NhanVienNhapKho(int soThung, double donGia)
        {
            Console.WriteLine(string.Format("\n>>> Nhân viên cập nhật: {0} thùng, Đơn giá: {1:N0} VNĐ <<<", soThung, donGia));
            _donHang.DonGiaMoiThung = donGia;
            _donHang.SoThung = soThung;
        }

        private void CapNhatManHinhGiamSatKho(DonHangXuatKhoModel model)
        {
            Console.WriteLine("==========================================================================");
            Console.WriteLine("  BẢNG ĐIỆN TỬ CÂN XE XUẤT KHO - CÔNG TY NÔNG DƯỢC AN GIANG (ĐÃ ĐỒNG BỘ)");
            Console.WriteLine("==========================================================================");
            Console.WriteLine(string.Format("Sản phẩm:       {0} (Lô: {1})", model.TenThuoc, model.MaLoThuoc));
            Console.WriteLine(string.Format("Số lượng xuất:  {0,8} thùng", model.SoThung));
            Console.WriteLine(string.Format("Tiền hàng:      {0,15:N0} VNĐ", model.ThanhTien));
            Console.WriteLine(string.Format("Thuế VAT (5%):  {0,15:N0} VNĐ", model.ThueVAT));
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine(string.Format("TỔNG THANH TOÁN:{0,15:N0} VNĐ", model.TongThanhToan));
            Console.WriteLine("==========================================================================");
        }
    }
}
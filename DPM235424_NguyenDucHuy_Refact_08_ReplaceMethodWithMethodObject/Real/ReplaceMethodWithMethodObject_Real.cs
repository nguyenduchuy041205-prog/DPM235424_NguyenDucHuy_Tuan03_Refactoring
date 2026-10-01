using System;

namespace DPM235424_NguyenDucHuy_Refact_08_ReplaceMethodWithMethodObject.Real
{
    public class ReplaceMethodWithMethodObject_Real
    {
        public double LayChiPhiLuuKhoCoBan() => 250000.0;

        public double TinhToanGiaXuatKho(
            string maLo,
            int soLuongTonDau,
            double giaTonDau,
            int soLuongNhapMoi,
            double giaNhapMoi,
            int soLuongXuat,
            double tiLeHaoHut)
        {
            return new TinhGiaBinhQuanCalculator(
                this, maLo, soLuongTonDau, giaTonDau, soLuongNhapMoi, giaNhapMoi, soLuongXuat, tiLeHaoHut
            ).ThucHienTinhToan();
        }
    }

    // Method Object: Đóng gói thuật toán tính giá xuất bình quân gia quyền phức tạp
    public class TinhGiaBinhQuanCalculator
    {
        private readonly ReplaceMethodWithMethodObject_Real _dichVuKho;
        private string _maLo;
        private int _soLuongTonDau;
        private double _giaTonDau;
        private int _soLuongNhapMoi;
        private double _giaNhapMoi;
        private int _soLuongXuat;
        private double _tiLeHaoHut;

        private double _tongGiaTriDauVao;
        private int _tongSoLuongKhaDung;
        private double _donGiaBinhQuan;
        private double _giaVonXuatKho;
        private double _chiPhiBaoQuan;

        public TinhGiaBinhQuanCalculator(
            ReplaceMethodWithMethodObject_Real dichVuKho,
            string maLo,
            int soLuongTonDau,
            double giaTonDau,
            int soLuongNhapMoi,
            double giaNhapMoi,
            int soLuongXuat,
            double tiLeHaoHut)
        {
            _dichVuKho = dichVuKho;
            _maLo = maLo;
            _soLuongTonDau = soLuongTonDau;
            _giaTonDau = giaTonDau;
            _soLuongNhapMoi = soLuongNhapMoi;
            _giaNhapMoi = giaNhapMoi;
            _soLuongXuat = soLuongXuat;
            _tiLeHaoHut = tiLeHaoHut;
        }

        public double ThucHienTinhToan()
        {
            TinhTongGiaTriVaSoLuong();
            TinhDonGiaBinhQuanGiaQuyen();
            TinhChiPhiPhatSinhVaHaoHut();

            double tongChiPhiXuat = _giaVonXuatKho + _chiPhiBaoQuan;
            InKetQua(tongChiPhiXuat);
            return tongChiPhiXuat;
        }

        private void TinhTongGiaTriVaSoLuong()
        {
            _tongGiaTriDauVao = (_soLuongTonDau * _giaTonDau) + (_soLuongNhapMoi * _giaNhapMoi);
            _tongSoLuongKhaDung = _soLuongTonDau + _soLuongNhapMoi;
        }

        private void TinhDonGiaBinhQuanGiaQuyen()
        {
            _donGiaBinhQuan = _tongSoLuongKhaDung > 0 ? _tongGiaTriDauVao / _tongSoLuongKhaDung : 0;
            _giaVonXuatKho = _soLuongXuat * _donGiaBinhQuan;
        }

        private void TinhChiPhiPhatSinhVaHaoHut()
        {
            double tienHaoHut = _giaVonXuatKho * (_tiLeHaoHut / 100.0);
            _chiPhiBaoQuan = _dichVuKho.LayChiPhiLuuKhoCoBan() + tienHaoHut;
        }

        private void InKetQua(double tongChiPhiXuat)
        {
            Console.WriteLine($"----- TÍNH GIÁ XUẤT KHO LÔ THUỐC {_maLo} (BÌNH QUÂN GIA QUYỀN) -----");
            Console.WriteLine($"Tổng số lượng khả dụng:  {_tongSoLuongKhaDung,10} đơn vị");
            Console.WriteLine($"Đơn giá bình quân:       {_donGiaBinhQuan,10:N0} VNĐ/đơn vị");
            Console.WriteLine($"Giá vốn xuất kho ({_soLuongXuat} đv): {_giaVonXuatKho,10:N0} VNĐ");
            Console.WriteLine($"Phí kho & hao hụt ({_tiLeHaoHut}%): {_chiPhiBaoQuan,10:N0} VNĐ");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"TỔNG GIÁ TRỊ XUẤT:       {tongChiPhiXuat,10:N0} VNĐ");
        }
    }
}
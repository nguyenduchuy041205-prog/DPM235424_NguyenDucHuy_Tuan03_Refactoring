using System;

namespace DPM235424_NguyenDucHuy_Refact_10_MoveMethod.Real
{
    // Lớp chứa thông tin và logic bảo quản của sản phẩm thuốc bảo vệ thực vật
    public class DanhMucThuocBVTV
    {
        public string MaThuoc { get; set; } = string.Empty;
        public string TenThuoc { get; set; } = string.Empty;
        public int NhomDoc { get; set; } // Nhóm 1: Rất độc (cần kho riêng), Nhóm 2: Độc trung bình
        public bool YeuCauKhoLanh { get; set; }

        // Di chuyển phương thức tính phí bảo quản thuốc sang đúng lớp DanhMucThuocBVTV
        public double TinhPhiBaoQuan(int soLuongChai, int soNgayLuuKho)
        {
            double phiMoiChaiMoiNgay = 1000.0;

            if (NhomDoc == 1)
            {
                phiMoiChaiMoiNgay += 2000.0; // Phụ phí quản lý hóa chất độc hại nhóm 1
            }

            if (YeuCauKhoLanh)
            {
                phiMoiChaiMoiNgay += 1500.0; // Tiền điện điều hòa, làm mát kho bảo quản
            }

            return soLuongChai * soNgayLuuKho * phiMoiChaiMoiNgay;
        }
    }

    public class MoveMethod_Real
    {
        public string MaDonHang { get; set; } = "DH-NDAG-1010";
        public DanhMucThuocBVTV ThuocBVTV { get; set; } = new DanhMucThuocBVTV();
        public int SoLuongChai { get; set; }
        public int SoNgayLuuKho { get; set; }
        public double DonGia { get; set; }

        public void XuatThongTinDonHang()
        {
            double tienHang = SoLuongChai * DonGia;
            // Gọi phương thức đã được chuyển sang đúng lớp DanhMucThuocBVTV
            double phiBaoQuan = ThuocBVTV.TinhPhiBaoQuan(SoLuongChai, SoNgayLuuKho);
            double tongThanhToan = tienHang + phiBaoQuan;

            Console.WriteLine("==================================================================");
            Console.WriteLine($" CÔNG TY NÔNG DƯỢC AN GIANG - ĐƠN HÀNG {MaDonHang}");
            Console.WriteLine("==================================================================");
            Console.WriteLine($" Tên sản phẩm:      {ThuocBVTV.TenThuoc} (Mã: {ThuocBVTV.MaThuoc})");
            Console.WriteLine($" Nhóm độc hại:      Nhóm {ThuocBVTV.NhomDoc} | Yêu cầu kho mát: {(ThuocBVTV.YeuCauKhoLanh ? "Có" : "Không")}");
            Console.WriteLine($" Tiền hàng gốc:     {tienHang,15:N0} VNĐ");
            Console.WriteLine($" Phí bảo quản kho:  {phiBaoQuan,15:N0} VNĐ ({SoNgayLuuKho} ngày lưu bãi)");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine($" TỔNG CỘNG:         {tongThanhToan,15:N0} VNĐ");
            Console.WriteLine("==================================================================");
        }
    }
}
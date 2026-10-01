using System;

namespace DPM235424_NguyenDucHuy_Refact_26_MagicNumber.Real
{
    public class MagicNumber_Real
    {
        // Các hằng số quy chuẩn kỹ thuật nông học và chính sách thương mại
        public const double DIEN_TICH_HECTA_M2 = 10000.0;
        public const double DUNG_TICH_BINH_PHUN_TRUYEN_THONG_LIT = 25.0;
        public const double DINH_MUC_NUOC_PHUN_MOI_HECTA_LIT = 400.0; // Phun bằng máy đeo vai cần 400L nước/ha
        public const double TY_LE_CHIET_KHAU_MUA_VU = 0.08; // 8% chiết khấu cho đơn hàng đầu mùa vụ
        public const double THUE_SUAT_VAT_NONG_DUOC = 0.05; // 5% VAT đối với hóa chất BVTV danh mục ưu đãi

        public double TinhSoBinhPhunTrenDienTich(double dienTichMetVuong)
        {
            // Thay thế phép chia cho các con số vô danh bằng công thức hằng số chuẩn
            double soHecta = dienTichMetVuong / DIEN_TICH_HECTA_M2;
            double tongLuongNuocCan = soHecta * DINH_MUC_NUOC_PHUN_MOI_HECTA_LIT;
            return tongLuongNuocCan / DUNG_TICH_BINH_PHUN_TRUYEN_THONG_LIT;
        }

        public double TinhGiaTriHoaDonThanhToan(double tongTienHangChuaGiam)
        {
            double tienChietKhau = tongTienHangChuaGiam * TY_LE_CHIET_KHAU_MUA_VU;
            double tienSauChietKhau = tongTienHangChuaGiam - tienChietKhau;
            double tienThue = tienSauChietKhau * THUE_SUAT_VAT_NONG_DUOC;
            return tienSauChietKhau + tienThue;
        }

        public void InHuongDanPhaCheVaThanhToan(string tenThuoc, double dienTichRuongM2, double giaGocDonHang)
        {
            double soBinh = TinhSoBinhPhunTrenDienTich(dienTichRuongM2);
            double tongThanhToan = TinhGiaTriHoaDonThanhToan(giaGocDonHang);

            Console.WriteLine("==========================================================================");
            Console.WriteLine("  CÔNG TY NÔNG DƯỢC AN GIANG - BẢNG ĐỊNH MỨC PHUN THUỐC VÀ THANH TOÁN      ");
            Console.WriteLine("==========================================================================");
            Console.WriteLine(string.Format("Thuốc BVTV chỉ định:      {0}", tenThuoc));
            Console.WriteLine(string.Format("Diện tích canh tác:       {0:N0} m² ({1:F2} Hecta)", dienTichRuongM2, dienTichRuongM2 / DIEN_TICH_HECTA_M2));
            Console.WriteLine(string.Format("Định mức bình 25L cần:    {0:F1} bình phun chuẩn", soBinh));
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine(string.Format("Giá trị hàng gốc:         {0,15:N0} VNĐ", giaGocDonHang));
            Console.WriteLine(string.Format("Chiết khấu mùa vụ ({0:P0}):  -{1,15:N0} VNĐ", TY_LE_CHIET_KHAU_MUA_VU, giaGocDonHang * TY_LE_CHIET_KHAU_MUA_VU));
            Console.WriteLine(string.Format("Thuế VAT nông dược ({0:P0}): +{1,15:N0} VNĐ", THUE_SUAT_VAT_NONG_DUOC, (giaGocDonHang * (1 - TY_LE_CHIET_KHAU_MUA_VU)) * THUE_SUAT_VAT_NONG_DUOC));
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine(string.Format("TỔNG THANH TOÁN:          {0,15:N0} VNĐ", tongThanhToan));
            Console.WriteLine("==========================================================================");
        }
    }
}
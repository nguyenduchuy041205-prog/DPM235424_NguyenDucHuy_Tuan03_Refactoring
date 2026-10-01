using System;
using System.Collections.Generic;

namespace DPM235424_NguyenDucHuy_Refact_22_ReplaceArrayWithObject.Real
{
    // Lớp đối tượng thay thế cho mảng chuỗi chi tiết xuất kho
    public class ChiTietXuatNongDuoc
    {
        public string MaThuoc { get; set; }
        public string TenThuoc { get; set; }
        public int SoThung { get; set; }
        public double DonGiaMoiThung { get; set; }
        public DateTime NgayXuat { get; set; }

        public double TinhThanhTien()
        {
            return SoThung * DonGiaMoiThung;
        }
    }

    public class ReplaceArrayWithObject_Real
    {
        public void InBangKeXuatKho(List<ChiTietXuatNongDuoc> danhSach)
        {
            Console.WriteLine("=========================================================================================");
            Console.WriteLine("      CÔNG TY NÔNG DƯỢC AN GIANG - BẢNG KÊ CHI TIẾT LÔ THUỐC BVTV XUẤT KHO             ");
            Console.WriteLine("=========================================================================================");
            Console.WriteLine(string.Format("{0,-12} | {1,-26} | {2,8} | {3,14} | {4,16}",
                "Mã Thuốc", "Tên Sản Phẩm", "Số Thùng", "Đơn Giá/Thùng", "Thành Tiền"));
            Console.WriteLine("-----------------------------------------------------------------------------------------");

            double tongGiaTriXuat = 0;
            foreach (var item in danhSach)
            {
                double thanhTien = item.TinhThanhTien();
                tongGiaTriXuat += thanhTien;

                Console.WriteLine(string.Format("{0,-12} | {1,-26} | {2,8} | {3,14:N0} | {4,16:N0}",
                    item.MaThuoc, item.TenThuoc, item.SoThung, item.DonGiaMoiThung, thanhTien));
            }

            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.WriteLine(string.Format("TỔNG GIÁ TRỊ TOÀN PHIẾU XUẤT: {0,57:N0} VNĐ", tongGiaTriXuat));
            Console.WriteLine("=========================================================================================");
        }
    }
}
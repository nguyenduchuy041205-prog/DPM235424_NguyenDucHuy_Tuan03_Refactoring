using System;

namespace DPM235424_NguyenDucHuy_Refact_07_RemoveAssignmentsToParameters.Real
{
    public class RemoveAssignmentsToParameters_Real
    {
        // Tính đơn giá sau khi áp dụng các chương trình ưu đãi mùa vụ
        public double TinhDonGiaBanThucTe(
            double donGiaGoc,
            int soLuongMua,
            bool khachHangThanThiet,
            bool thanhToanTienMat)
        {
            // Tránh gán đè vào tham số donGiaGoc, dùng biến cục bộ donGiaSauGiam
            double donGiaSauGiam = donGiaGoc;

            // Mua sỉ trên 100 chai/gói: giảm 10.000đ/đơn vị
            if (soLuongMua >= 100)
            {
                donGiaSauGiam -= 10000;
            }

            // Đại lý thân thiết lâu năm của Nông dược An Giang: giảm thêm 5.000đ
            if (khachHangThanThiet)
            {
                donGiaSauGiam -= 5000;
            }

            // Thanh toán ngay tiền mặt (không công nợ): chiết khấu trực tiếp 2% trên đơn giá
            if (thanhToanTienMat)
            {
                donGiaSauGiam -= donGiaSauGiam * 0.02;
            }

            Console.WriteLine($"Đơn giá niêm yết ban đầu: {donGiaGoc,12:N0} VNĐ");
            Console.WriteLine($"Đơn giá thực tế áp dụng:  {donGiaSauGiam,12:N0} VNĐ");
            Console.WriteLine($"Số tiền tiết kiệm/chai:   {donGiaGoc - donGiaSauGiam,12:N0} VNĐ");

            return donGiaSauGiam;
        }
    }
}
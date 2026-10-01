using System;

namespace DPM235424_NguyenDucHuy_Refact_06_SplitTemporaryVariable.Real
{
    public class SplitTemporaryVariable_Real
    {
        public void TinhChiPhiGiaoHangNongDuoc(
            string maDonHang,
            int tongKhoiLuongKg,
            double kmDuongBo,
            double kmDuongThuy)
        {
            Console.WriteLine($"=== CHI PHÍ VẬN CHUYỂN ĐƠN HÀNG {maDonHang} ===");

            // Tách biến 1: Chi phí vận chuyển chặng đường bộ (Xe tải từ kho Long Xuyên đến huyện)
            const double DON_GIA_DUONG_BO = 12000.0; // 12.000 VNĐ/km
            double cuocPhiDuongBo = kmDuongBo * DON_GIA_DUONG_BO + (tongKhoiLuongKg * 50);
            Console.WriteLine($"Chặng 1 (Đường bộ {kmDuongBo}km):  {cuocPhiDuongBo,12:N0} VNĐ");

            // Tách biến 2: Chi phí vận chuyển chặng đường thủy (Ghe/vỏ lãi giao tới đại lý ven kênh/ruộng)
            const double DON_GIA_DUONG_THUY = 18000.0; // 18.000 VNĐ/km
            double cuocPhiDuongThuy = kmDuongThuy * DON_GIA_DUONG_THUY + (tongKhoiLuongKg * 80);
            Console.WriteLine($"Chặng 2 (Đường thủy {kmDuongThuy}km): {cuocPhiDuongThuy,12:N0} VNĐ");

            // Tổng chi phí vận chuyển phụ của đơn hàng
            double tongCuocPhi = cuocPhiDuongBo + cuocPhiDuongThuy;
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"TỔNG CƯỚC VẬN CHUYỂN:       {tongCuocPhi,12:N0} VNĐ");
        }
    }
}
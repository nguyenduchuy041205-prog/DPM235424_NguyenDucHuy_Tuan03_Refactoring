using System;

namespace DPM235424_NguyenDucHuy_Refact_03_ExtractVariable.Real
{
    public class ExtractVariable_Real
    {
        public double TinhTongChiPhiDonHang(
            int soChaiThuoc,
            double giaMoiChai,
            double khoangCachKm,
            bool yeuCauBocVacNhanh)
        {
            // Trích xuất biến giải thích rõ từng khoản tiền theo nghiệp vụ nông dược:
            // 1. Tiền gốc theo số lượng chai
            double tienHangGoc = soChaiThuoc * giaMoiChai;

            // 2. Chiết khấu đại lý (nếu mua trên 200 chai thì giảm 8% trên số chai vượt ngưỡng)
            double tienChietKhauDaiLy = Math.Max(0, soChaiThuoc - 200) * giaMoiChai * 0.08;

            // 3. Phí vận chuyển bằng xe chuyên dụng giao đến đại lý nông nghiệp (15.000đ/km)
            double phiVanChuyenXe = khoangCachKm * 15000;

            // 4. Phụ phí dịch vụ bốc xếp nông dược độc hại (bốc dỡ nhanh tính thêm 150.000đ, thông thường 50.000đ)
            double phiBocVac = yeuCauBocVacNhanh ? 150000 : 50000;

            // Tổng thanh toán cuối cùng sau khi cộng trừ các khoản rõ ràng
            double tongThanhToan = tienHangGoc - tienChietKhauDaiLy + phiVanChuyenXe + phiBocVac;

            Console.WriteLine("----- CHI TIẾT TÍNH PHÍ ĐƠN HÀNG NÔNG DƯỢC -----");
            Console.WriteLine($"Tiền hàng gốc:         {tienHangGoc,15:N0} VNĐ");
            Console.WriteLine($"Chiết khấu mua sỉ:    -{tienChietKhauDaiLy,15:N0} VNĐ");
            Console.WriteLine($"Cước vận chuyển ({khoangCachKm}km): {phiVanChuyenXe,15:N0} VNĐ");
            Console.WriteLine($"Phí bốc dỡ kho bãi:    {phiBocVac,15:N0} VNĐ");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine($"TỔNG CỘNG:             {tongThanhToan,15:N0} VNĐ");

            return tongThanhToan;
        }
    }
}
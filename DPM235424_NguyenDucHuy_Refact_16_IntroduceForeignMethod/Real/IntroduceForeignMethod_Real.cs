using System;

namespace DPM235424_NguyenDucHuy_Refact_16_IntroduceForeignMethod.Real
{
    public class IntroduceForeignMethod_Real
    {
        public string MaLoThuoc { get; set; } = "LO-ANVIL-2026";
        public string TenThuoc { get; set; } = "Anvil 5SC";
        public DateTime NgayXuatBan { get; set; } = DateTime.Now;
        public int ThoiGianCachLyNgay { get; set; } = 14; // Cách ly 14 ngày trước khi thu hoạch lúa
        public int HanNoNgay { get; set; } = 45; // Đại lý được nợ gối đầu 45 ngày

        public void InThongTinTheoDoi()
        {
            DateTime ngayAnToanThuHoach = TinhNgayHetCachLy(NgayXuatBan, ThoiGianCachLyNgay);
            DateTime hanChotThanhToan = TinhNgayDaoHanCongNo(NgayXuatBan, HanNoNgay);

            Console.WriteLine("==========================================================================");
            Console.WriteLine(" CÔNG TY NÔNG DƯỢC AN GIANG - THEO DÕI AN TOÀN NÔNG DƯỢC & CÔNG NỢ ĐẠI LÝ");
            Console.WriteLine("==========================================================================");
            Console.WriteLine($" Sản phẩm:            {TenThuoc} (Lô: {MaLoThuoc})");
            Console.WriteLine($" Ngày xuất kho:       {NgayXuatBan:dd/MM/yyyy}");
            Console.WriteLine($" Thời gian cách ly:   {ThoiGianCachLyNgay} ngày (Theo quy chuẩn BVTV)");
            Console.WriteLine($" An toàn thu hoạch từ: {ngayAnToanThuHoach:dd/MM/yyyy}");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine($" Thời hạn công nợ:    {HanNoNgay} ngày");
            Console.WriteLine($" Hạn chót thanh toán: {hanChotThanhToan:dd/MM/yyyy}");
            Console.WriteLine("==========================================================================");
        }

        // Foreign Method 1: Tính toán mốc ngày an toàn thu hoạch nông sản
        private static DateTime TinhNgayHetCachLy(DateTime ngayPhunThuoc, int soNgayCachLy)
        {
            return ngayPhunThuoc.AddDays(soNgayCachLy);
        }

        // Foreign Method 2: Tính hạn chốt thanh toán công nợ theo thỏa thuận hợp đồng
        private static DateTime TinhNgayDaoHanCongNo(DateTime ngayLapHoaDon, int soNgayChoPhep)
        {
            return ngayLapHoaDon.AddDays(soNgayChoPhep);
        }
    }
}
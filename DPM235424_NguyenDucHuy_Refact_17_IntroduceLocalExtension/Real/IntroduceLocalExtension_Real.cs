using System;

namespace DPM235424_NguyenDucHuy_Refact_17_IntroduceLocalExtension.Real
{
    // Lớp mở rộng cục bộ (Local Extension) chuyên xử lý nghiệp vụ thời gian cho Công ty Nông dược An Giang
    public class NgayNongDuocExtension
    {
        private readonly DateTime _ngaySanXuat;

        public NgayNongDuocExtension(DateTime ngaySanXuat)
        {
            _ngaySanXuat = ngaySanXuat;
        }

        public DateTime NgaySanXuat => _ngaySanXuat;

        // Tính mốc tái kiểm định chất lượng định kỳ (mỗi 6 tháng một lần)
        public DateTime TinhNgayTaiKiemDinh()
        {
            return _ngaySanXuat.AddMonths(6);
        }

        // Tính hạn sử dụng chuẩn của thuốc BVTV (thông thường 2 năm kể từ ngày sản xuất)
        public DateTime TinhHanSuDungChuan()
        {
            return _ngaySanXuat.AddYears(2);
        }

        // Thời gian ổn định hóa học trong kho trước khi được phép xuất xưởng (tối thiểu 7 ngày)
        public DateTime TinhNgayDuocXuatXuong()
        {
            return _ngaySanXuat.AddDays(7);
        }
    }

    public class IntroduceLocalExtension_Real
    {
        public string MaLoThuoc { get; set; } = string.Empty;
        public string TenThuoc { get; set; } = string.Empty;
        public NgayNongDuocExtension NgaySanXuatMoRong { get; set; }

        public IntroduceLocalExtension_Real(string maLo, string tenThuoc, DateTime ngaySX)
        {
            MaLoThuoc = maLo;
            TenThuoc = tenThuoc;
            NgaySanXuatMoRong = new NgayNongDuocExtension(ngaySX);
        }

        public void InLichTrinhKiemDinhVaLuuKho()
        {
            Console.WriteLine("==========================================================================");
            Console.WriteLine("   CÔNG TY NÔNG DƯỢC AN GIANG - BẢNG THEO DÕI CHẤT LƯỢNG LÔ SẢN XUẤT     ");
            Console.WriteLine("==========================================================================");
            Console.WriteLine($" Sản phẩm:            {TenThuoc} (Lô: {MaLoThuoc})");
            Console.WriteLine($" Ngày sản xuất:       {NgaySanXuatMoRong.NgaySanXuat:dd/MM/yyyy}");
            Console.WriteLine($" Ngày đủ điều kiện xuất: {NgaySanXuatMoRong.TinhNgayDuocXuatXuong():dd/MM/yyyy} (Sau thời gian ổn định)");
            Console.WriteLine($" Ngày kiểm định lại:  {NgaySanXuatMoRong.TinhNgayTaiKiemDinh():dd/MM/yyyy} (Định kỳ 6 tháng)");
            Console.WriteLine($" Hạn sử dụng tối đa:  {NgaySanXuatMoRong.TinhHanSuDungChuan():dd/MM/yyyy}");
            Console.WriteLine("==========================================================================");
        }
    }
}
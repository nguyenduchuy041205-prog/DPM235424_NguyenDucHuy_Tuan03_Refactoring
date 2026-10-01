using System;

namespace DPM235424_NguyenDucHuy_Refact_12_ExtractClass.Real
{
    // Lớp được trích xuất: Quản lý thông số hoạt chất hóa học độc lập
    public class HoatChatNongDuoc
    {
        public string TenHoatChat { get; set; } = string.Empty;
        public string HamLuong { get; set; } = string.Empty; // Ví dụ: 300g/l hoặc 50%
        public string NhomDocTinhWHO { get; set; } = string.Empty; // Nhóm II, Nhóm III
        public string CongDungChinh { get; set; } = string.Empty;

        public string LayThongTinChiTiet()
        {
            return $"{TenHoatChat} ({HamLuong}) - Độc tố: {NhomDocTinhWHO} - Tác dụng: {CongDungChinh}";
        }
    }

    public class ExtractClass_Real
    {
        public string MaThuoc { get; set; } = string.Empty;
        public string TenThuongMai { get; set; } = string.Empty;
        public string QuyCachDongGoi { get; set; } = string.Empty;
        public double DonGiaNiemYet { get; set; }

        // Sử dụng đối tượng lớp đã trích xuất
        public HoatChatNongDuoc HoatChat { get; set; } = new HoatChatNongDuoc();

        public void InNhanBaoBiThuoc()
        {
            Console.WriteLine("==========================================================================");
            Console.WriteLine($" CÔNG TY NÔNG DƯỢC AN GIANG - NHÃN SẢN PHẨM THUỐC BVTV");
            Console.WriteLine("==========================================================================");
            Console.WriteLine($" Tên thương phẩm:   {TenThuongMai} (Mã: {MaThuoc})");
            Console.WriteLine($" Quy cách đóng gói: {QuyCachDongGoi}");
            Console.WriteLine($" Đơn giá niêm yết:  {DonGiaNiemYet:N0} VNĐ");
            Console.WriteLine($" Thành phần kỹ thuật:");
            Console.WriteLine($"  -> {HoatChat.LayThongTinChiTiet()}");
            Console.WriteLine("==========================================================================");
        }
    }
}
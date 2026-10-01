using System;

namespace DPM235424_NguyenDucHuy_Refact_14_HideDelegate.Real
{
    // Cấp chi nhánh / trạm vật tư nông nghiệp tại các huyện An Giang
    public class ChiNhanhNongDuoc
    {
        public string MaChiNhanh { get; set; } = "CN-THOAISON";
        public string TenChiNhanh { get; set; } = "Chi nhánh Nông dược Thoại Sơn";
        public string TruongChiNhanh { get; set; } = "KS. Lê Văn Trưởng";
    }

    // Nhân viên bán hàng trực thuộc chi nhánh
    public class NhanVienKinhDoanh
    {
        public string MaNV { get; set; } = "NV-089";
        public string HoTen { get; set; } = "Nguyễn Văn Bán Hàng";
        public ChiNhanhNongDuoc ChiNhanh { get; set; } = new ChiNhanhNongDuoc();

        // Ẩn chi nhánh với cấp cao hơn
        public string LayNguoiPheDuyet() => ChiNhanh.TruongChiNhanh;
        public string LayTenChiNhanh() => ChiNhanh.TenChiNhanh;
    }

    public class HideDelegate_Real
    {
        public string MaHoaDon { get; set; } = "HD-NDAG-2026-14";
        public string TenDaiLy { get; set; } = "Đại lý Nông sản Ba Thê";
        public double TongTien { get; set; } = 38500000;

        // Đối tượng nhân viên bán hàng
        private NhanVienKinhDoanh _nhanVienLap = new NhanVienKinhDoanh();

        // Áp dụng Hide Delegate: Client chỉ cần gọi qua Hóa Đơn, không cần biết cấu trúc ChiNhanh bên trong
        public string LayTenNhanVienLap() => _nhanVienLap.HoTen;
        public string LayNguoiPheDuyetXuat() => _nhanVienLap.LayNguoiPheDuyet();
        public string LayChiNhanhXuat() => _nhanVienLap.LayTenChiNhanh();

        public void InThongTinDuyetHoaDon()
        {
            Console.WriteLine("==================================================================");
            Console.WriteLine($" CÔNG TY NÔNG DƯỢC AN GIANG - BIÊN BẢN PHÊ DUYỆT XUẤT HÓA ĐƠN");
            Console.WriteLine("==================================================================");
            Console.WriteLine($" Mã đơn hàng:       {MaHoaDon}");
            Console.WriteLine($" Đại lý thụ hưởng:  {TenDaiLy}");
            Console.WriteLine($" Giá trị hóa đơn:   {TongTien,15:N0} VNĐ");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine($" Đơn vị xuất:       {LayChiNhanhXuat()}");
            Console.WriteLine($" Nhân viên lập đơn: {LayTenNhanVienLap()}");
            Console.WriteLine($" Người duyệt xuất:  {LayNguoiPheDuyetXuat()} (Trưởng chi nhánh)");
            Console.WriteLine("==================================================================");
        }
    }
}
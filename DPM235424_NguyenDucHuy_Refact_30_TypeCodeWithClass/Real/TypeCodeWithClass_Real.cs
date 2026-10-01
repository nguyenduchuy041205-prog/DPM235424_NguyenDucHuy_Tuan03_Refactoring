using System;

namespace DPM235424_NguyenDucHuy_Refact_30_TypeCodeWithClass.Real
{
    // Lớp hóa Type Code nhóm độc BVTV theo quy chuẩn Bộ Nông Nghiệp & PTNT
    public class NhomDocBVTV
    {
        public static readonly NhomDocBVTV Nhom1A = new NhomDocBVTV("IA", "Cực độc", "Vạch Đỏ", "Đầu lâu xương chéo", 21);
        public static readonly NhomDocBVTV Nhom1B = new NhomDocBVTV("IB", "Rất độc", "Vạch Đỏ", "Đầu lâu xương chéo", 14);
        public static readonly NhomDocBVTV Nhom2 = new NhomDocBVTV("II", "Nguy hại trung bình", "Vạch Vàng", "Chữ thập chéo", 7);
        public static readonly NhomDocBVTV Nhom3 = new NhomDocBVTV("III", "Cẩn thận / Nguy hại nhẹ", "Vạch Xanh Dương", "Không biểu tượng độc", 3);
        public static readonly NhomDocBVTV Nhom4 = new NhomDocBVTV("IV", "Độ độc rất thấp", "Vạch Xanh Lá Cây", "Kèm khuyến cáo chung", 1);

        public string MaNhom { get; }
        public string MucDoDoc { get; }
        public string MauVachNhan { get; }
        public string BieuTuongCanhBao { get; }
        public int ThoiGianCachLyToiThieuNgay { get; }

        private NhomDocBVTV(string maNhom, string mucDo, string mauVach, string bieuTuong, int ngayCachLy)
        {
            MaNhom = maNhom;
            MucDoDoc = mucDo;
            MauVachNhan = mauVach;
            BieuTuongCanhBao = bieuTuong;
            ThoiGianCachLyToiThieuNgay = ngayCachLy;
        }
    }

    public class SanPhamNongDuoc
    {
        public string MaThuoc { get; set; }
        public string TenThuongMai { get; set; }
        public string HoatChatChinh { get; set; }

        // Sử dụng lớp NhomDocBVTV thay vì mã số int hay string thô
        public NhomDocBVTV NhomDoc { get; set; }

        public SanPhamNongDuoc(string maThuoc, string ten, string hoatChat, NhomDocBVTV nhomDoc)
        {
            MaThuoc = maThuoc;
            TenThuongMai = ten;
            HoatChatChinh = hoatChat;
            NhomDoc = nhomDoc;
        }

        public void InNhanBaoVeThucVat()
        {
            Console.WriteLine(string.Format("Sản phẩm: {0,-20} | Hoạt chất: {1}", TenThuongMai, HoatChatChinh));
            Console.WriteLine(string.Format(" -> Nhóm độc:         WHO {0} ({1})", NhomDoc.MaNhom, NhomDoc.MucDoDoc));
            Console.WriteLine(string.Format(" -> Quy chuẩn tem mác: {0} | Cảnh báo: {1}", NhomDoc.MauVachNhan, NhomDoc.BieuTuongCanhBao));
            Console.WriteLine(string.Format(" -> Cách ly tối thiểu: {0} ngày trước khi thu hoạch nông sản", NhomDoc.ThoiGianCachLyToiThieuNgay));
        }
    }

    public class TypeCodeWithClass_Real
    {
        public void QuanLyNhanThuocBVTV()
        {
            Console.WriteLine("==========================================================================");
            Console.WriteLine(" CÔNG TY NÔNG DƯỢC AN GIANG - PHÂN ĐỊNH MỨC ĐỘ ĐỘC VÀ QUY CÁCH NHÃN THUỐC ");
            Console.WriteLine("==========================================================================");

            var sp1 = new SanPhamNongDuoc(
                "ND-TILT",
                "Tilt Super 300EC",
                "Difenoconazole + Propiconazole",
                NhomDocBVTV.Nhom3
            );

            var sp2 = new SanPhamNongDuoc(
                "ND-REGENT",
                "Regent 800WG",
                "Fipronil",
                NhomDocBVTV.Nhom2
            );

            sp1.InNhanBaoVeThucVat();
            Console.WriteLine("--------------------------------------------------------------------------");
            sp2.InNhanBaoVeThucVat();
            Console.WriteLine("==========================================================================");
        }
    }
}
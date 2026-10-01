using System;

namespace DPM235424_NguyenDucHuy_Refact_25_BiToUni.Real
{
    // Đối tác cung ứng nguyên liệu / thuốc thành phẩm độc lập
    public class NhaCungCapHoaChat
    {
        public string MaNCC { get; set; }
        public string TenNhaCungCap { get; set; }
        public string QuocGia { get; set; }
        public string ChungNhanISO { get; set; }

        public NhaCungCapHoaChat(string maNCC, string ten, string quocGia, string iso)
        {
            MaNCC = maNCC;
            TenNhaCungCap = ten;
            QuocGia = quocGia;
            ChungNhanISO = iso;
        }

        public string LayThongTinNguonGoc()
        {
            return string.Format("{0} ({1}) - Chuẩn kiểm định: {2}", TenNhaCungCap, QuocGia, ChungNhanISO);
        }
    }

    // Liên kết 1 chiều: Lô thuốc chỉ trỏ tới Nhà cung cấp để truy xuất nguồn gốc
    public class LoThuocNhapKho
    {
        public string MaLo { get; set; }
        public string TenThuoc { get; set; }
        public int SoLuongChai { get; set; }
        public double GiaNhapMoiChai { get; set; }
        public NhaCungCapHoaChat NhaCungCap { get; set; }

        public LoThuocNhapKho(string maLo, string tenThuoc, int soLuong, double giaNhap, NhaCungCapHoaChat ncc)
        {
            MaLo = maLo;
            TenThuoc = tenThuoc;
            SoLuongChai = soLuong;
            GiaNhapMoiChai = giaNhap;
            NhaCungCap = ncc;
        }

        public double TinhTongTienNhap()
        {
            return SoLuongChai * GiaNhapMoiChai;
        }

        public void InThongTinLoHang()
        {
            Console.WriteLine(string.Format("Lô: {0,-14} | Thuốc: {1,-20} | SL: {2,5} | Đơn giá: {3,10:N0} VNĐ",
                MaLo, TenThuoc, SoLuongChai, GiaNhapMoiChai));
            Console.WriteLine(string.Format(" -> Nguồn gốc xuất xứ: {0}", NhaCungCap.LayThongTinNguonGoc()));
        }
    }

    public class BiToUni_Real
    {
        public void QuanLyNguonGocThuoc()
        {
            Console.WriteLine("==========================================================================");
            Console.WriteLine(" CÔNG TY NÔNG DƯỢC AN GIANG - KIỂM SOÁT NGUỒN GỐC LÔ THUỐC (LIÊN KẾT 1 CHIỀU) ");
            Console.WriteLine("==========================================================================");

            var syngenta = new NhaCungCapHoaChat("NCC-SYN", "Syngenta Crop Protection AG", "Thụy Sĩ", "ISO 9001:2015");
            var bayer = new NhaCungCapHoaChat("NCC-BAY", "Bayer CropScience", "CHLB Đức", "ISO 14001:2015");

            var lo1 = new LoThuocNhapKho("LO-AMISTAR-01", "Amistar Top 325SC", 500, 240000, syngenta);
            var lo2 = new LoThuocNhapKho("LO-NATIVO-02", "Nativo 750WG", 300, 195000, bayer);

            lo1.InThongTinLoHang();
            Console.WriteLine("--------------------------------------------------------------------------");
            lo2.InThongTinLoHang();
            Console.WriteLine("==========================================================================");
        }
    }
}
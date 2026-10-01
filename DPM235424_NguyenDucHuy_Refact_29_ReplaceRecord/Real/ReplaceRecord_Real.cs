using System;

namespace DPM235424_NguyenDucHuy_Refact_29_ReplaceRecord.Real
{
    // Data Class thay thế cho bản ghi dictionary/chuỗi khóa thô
    public class KetQuaKiemNghiemThuoc
    {
        public string MaMauThuoc { get; set; }
        public string TenThuoc { get; set; }
        public string TenHoatChat { get; set; }
        public double HamLuongThucTeGamLit { get; set; }
        public double HamLuongCongBoGamLit { get; set; }
        public DateTime NgayKiemNghiem { get; set; }

        public KetQuaKiemNghiemThuoc(string maMau, string tenThuoc, string hoatChat,
                                     double hamLuongThucTe, double hamLuongCongBo, DateTime ngayKN)
        {
            MaMauThuoc = maMau;
            TenThuoc = tenThuoc;
            TenHoatChat = hoatChat;
            HamLuongThucTeGamLit = hamLuongThucTe;
            HamLuongCongBoGamLit = hamLuongCongBo;
            NgayKiemNghiem = ngayKN;
        }

        // Tính tỷ lệ phần trăm sai lệch nồng độ hoạt chất
        public double TinhTyLeSaiLech()
        {
            return Math.Abs(HamLuongThucTeGamLit - HamLuongCongBoGamLit) / HamLuongCongBoGamLit * 100.0;
        }

        // Tiêu chuẩn quốc gia: sai số cho phép không vượt quá 5%
        public bool KiemTraDatChuan()
        {
            return TinhTyLeSaiLech() <= 5.0;
        }

        public void InBienBanKiemNghiem()
        {
            double saiLech = TinhTyLeSaiLech();
            bool datChuan = KiemTraDatChuan();

            Console.WriteLine(string.Format("Mã mẫu: {0,-12} | Sản phẩm: {1,-20} | Hoạt chất: {2}",
                MaMauThuoc, TenThuoc, TenHoatChat));
            Console.WriteLine(string.Format(" -> Công bố: {0,5:F1} g/L | Thực nghiệm: {1,5:F1} g/L (Lệch: {2:F2}%)",
                HamLuongCongBoGamLit, HamLuongThucTeGamLit, saiLech));
            Console.WriteLine(string.Format(" -> Đánh giá: {0} (Ngày kiểm nghiệm: {1:dd/MM/yyyy})",
                datChuan ? "[ĐẠT CHUẨN XUẤT XƯỞNG]" : "[CẢNH BÁO: KHÔNG ĐẠT TIÊU CHUẨN]", NgayKiemNghiem));
        }
    }

    public class ReplaceRecord_Real
    {
        public void ChayChuongTrinhKiemNghiem()
        {
            Console.WriteLine("==========================================================================");
            Console.WriteLine(" CÔNG TY NÔNG DƯỢC AN GIANG - BIÊN BẢN ĐÁNH GIÁ CHẤT LƯỢNG MẪU THUỐC BVTV ");
            Console.WriteLine("==========================================================================");

            // Mẫu 1: Đạt chuẩn (sai lệch thấp)
            var mau1 = new KetQuaKiemNghiemThuoc(
                maMau: "MAU-2026-01",
                tenThuoc: "Anvil 5SC",
                hoatChat: "Hexaconazole",
                hamLuongThucTe: 49.2,
                hamLuongCongBo: 50.0,
                ngayKN: DateTime.Now
            );

            // Mẫu 2: Không đạt chuẩn (hoạt chất bị hao hụt quá mức)
            var mau2 = new KetQuaKiemNghiemThuoc(
                maMau: "MAU-2026-02",
                tenThuoc: "Filia 525SE",
                hoatChat: "Propiconazole + Tricyclazole",
                hamLuongThucTe: 480.0,
                hamLuongCongBo: 525.0,
                ngayKN: DateTime.Now
            );

            mau1.InBienBanKiemNghiem();
            Console.WriteLine("--------------------------------------------------------------------------");
            mau2.InBienBanKiemNghiem();
            Console.WriteLine("==========================================================================");
        }
    }
}
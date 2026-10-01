using System;

namespace DPM235424_NguyenDucHuy_Refact_21_ChangeReferenceToValue.Real
{
    // Value Object đại diện cho dung tích / khối lượng liều dùng thuốc BVTV
    public struct LieuLuongThuoc : IEquatable<LieuLuongThuoc>
    {
        public double GiaTri { get; }
        public string DonViTinh { get; } // "ml", "gram", "lít", "kg"

        public LieuLuongThuoc(double giaTri, string donViTinh)
        {
            GiaTri = giaTri;
            DonViTinh = donViTinh != null ? donViTinh.Trim().ToLower() : string.Empty;
        }

        public bool Equals(LieuLuongThuoc other)
        {
            return GiaTri.Equals(other.GiaTri) && DonViTinh == other.DonViTinh;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is LieuLuongThuoc)) return false;
            return Equals((LieuLuongThuoc)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + GiaTri.GetHashCode();
                hash = hash * 23 + (DonViTinh != null ? DonViTinh.GetHashCode() : 0);
                return hash;
            }
        }

        public static bool operator ==(LieuLuongThuoc left, LieuLuongThuoc right) => left.Equals(right);
        public static bool operator !=(LieuLuongThuoc left, LieuLuongThuoc right) => !left.Equals(right);

        public override string ToString() => string.Format("{0} {1}", GiaTri, DonViTinh);
    }

    public class ChangeReferenceToValue_Real
    {
        public void KiemTraQuyChuanLieuLuong()
        {
            Console.WriteLine("==========================================================================");
            Console.WriteLine(" CÔNG TY NÔNG DƯỢC AN GIANG - QUẢN LÝ QUY CHUẨN LIỀU DÙNG THUỐC BVTV   ");
            Console.WriteLine("==========================================================================");

            var lieuDungKhuyenCao = new LieuLuongThuoc(25.0, "ml");
            var lieuDungNongDanPha = new LieuLuongThuoc(25.0, "ml");
            var lieuDungVuotDinhMuc = new LieuLuongThuoc(40.0, "ml");

            Console.WriteLine(string.Format("Liều khuyến cáo phòng trừ rầy:  {0}", lieuDungKhuyenCao));
            Console.WriteLine(string.Format("Liều thực tế pha bình 25L:      {0}", lieuDungNongDanPha));

            if (lieuDungKhuyenCao == lieuDungNongDanPha)
            {
                Console.WriteLine("-> [ĐẠT CHUẨN] Liều lượng pha chuẩn xác 100% theo hướng dẫn kỹ thuật viên!");
            }

            Console.WriteLine(string.Format("\nLiều pha thử nghiệm diện rộng:   {0}", lieuDungVuotDinhMuc));
            if (lieuDungKhuyenCao != lieuDungVuotDinhMuc)
            {
                Console.WriteLine("-> [CẢNH BÁO] Liều lượng bị lệch chuẩn, nguy cơ gây cháy lá lúa non!");
            }
            Console.WriteLine("==========================================================================");
        }
    }
}
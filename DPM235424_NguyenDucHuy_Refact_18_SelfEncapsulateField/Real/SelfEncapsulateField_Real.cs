using System;

namespace DPM235424_NguyenDucHuy_Refact_18_SelfEncapsulateField.Real
{
    // Lớp cơ sở quản lý kho lưu trữ thuốc BVTV
    public class KhoNongDuocCoSo
    {
        private int _soLuongTon;
        private int _dinhMucToiDaChai;

        public KhoNongDuocCoSo(int soLuongTon, int dinhMucToiDa)
        {
            _soLuongTon = soLuongTon;
            _dinhMucToiDaChai = dinhMucToiDa;
        }

        // Tự đóng gói trường dữ liệu thông qua Getter/Setter ảo
        public virtual int SoLuongTon
        {
            get => _soLuongTon;
            set => _soLuongTon = value;
        }

        public virtual int DinhMucToiDaChai
        {
            get => _dinhMucToiDaChai;
            set => _dinhMucToiDaChai = value;
        }

        // Logic nghiệp vụ kiểm tra khả năng nhập kho chỉ truy xuất qua getter
        public bool KiemTraNhapKhoDuoc(int soLuongNhapThem)
        {
            int tongDuKien = SoLuongTon + soLuongNhapThem;
            if (tongDuKien > DinhMucToiDaChai)
            {
                Console.WriteLine($"[CẢNH BÁO VƯỢT TRẦN] Tổng số lượng ({tongDuKien}) vượt định mức cho phép ({DinhMucToiDaChai})!");
                return false;
            }

            Console.WriteLine($"[CHẤP THUẬN NHẬP] Đủ điều kiện nhập thêm {soLuongNhapThem} đơn vị vào kho.");
            return true;
        }
    }

    // Lớp kho hóa chất độc hại ghi đè định mức tối đa để tuân thủ an toàn PCCC & môi trường
    public class KhoHoaChatDocHaiNhom1 : KhoNongDuocCoSo
    {
        private const int GIOI_HAN_NGHIEM_NGAT = 500; // Kho hóa chất độc chỉ chứa tối đa 500 chai

        public KhoHoaChatDocHaiNhom1(int soLuongTon, int dinhMucToiDa)
            : base(soLuongTon, dinhMucToiDa)
        {
        }

        // Ghi đè thuộc tính để áp dụng quy chuẩn an toàn đặc thù ngành nông dược
        public override int DinhMucToiDaChai
        {
            get => Math.Min(base.DinhMucToiDaChai, GIOI_HAN_NGHIEM_NGAT);
        }
    }

    public class SelfEncapsulateField_Real
    {
        public void ChayNghiepVuKiemKho()
        {
            Console.WriteLine("==========================================================================");
            Console.WriteLine(" CÔNG TY NÔNG DƯỢC AN GIANG - KIỂM SOÁT ĐỊNH MỨC KHO LƯU TRỮ THUỐC BVTV  ");
            Console.WriteLine("==========================================================================");

            // 1. Kho hàng thông thường (định mức thiết kế 1.200 chai)
            Console.WriteLine("--- 1. Kiểm tra Kho vật tư tiêu hao thông thường ---");
            var khoChung = new KhoNongDuocCoSo(soLuongTon: 600, dinhMucToiDa: 1200);
            khoChung.KiemTraNhapKhoDuoc(400);

            // 2. Kho hóa chất nhóm 1 (định mức mong muốn 800 chai, nhưng bị giới hạn ngặt nghèo ở 500 chai)
            Console.WriteLine("\n--- 2. Kiểm tra Kho hóa chất cực độc nhóm 1 (Chi nhánh Tri Tôn) ---");
            var khoDocHai = new KhoHoaChatDocHaiNhom1(soLuongTon: 350, dinhMucToiDa: 800);
            khoDocHai.KiemTraNhapKhoDuoc(200); // 350 + 200 = 550 > 500 -> Sẽ cảnh báo vượt trần
            Console.WriteLine("==========================================================================");
        }
    }
}
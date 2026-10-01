using System;

namespace DPM235424_NguyenDucHuy_Refact_27_EncapsulateField.Real
{
    public class EncapsulateField_Real
    {
        private string _maThuoc = string.Empty;
        private string _tenThuongMai = string.Empty;
        private double _dungTichMl;
        private double _nongDoHoatChat; // Phần trăm (%)

        public string MaThuoc
        {
            get { return _maThuoc; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Mã thuốc BVTV không được rỗng!");
                }
                _maThuoc = value.ToUpper().Trim();
            }
        }

        public string TenThuongMai
        {
            get { return _tenThuongMai; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Tên thương phẩm không được để trống!");
                }
                _tenThuongMai = value.Trim();
            }
        }

        public double DungTichMl
        {
            get { return _dungTichMl; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("[CẢNH BÁO DỮ LIỆU] Dung tích đóng chai phải lớn hơn 0ml!");
                    return;
                }
                _dungTichMl = value;
            }
        }

        public double NongDoHoatChat
        {
            get { return _nongDoHoatChat; }
            set
            {
                // Quy chuẩn kiểm định nồng độ hoạt chất từ 0.1% đến 95%
                if (value < 0.1 || value > 95.0)
                {
                    Console.WriteLine(string.Format("[CẢNH BÁO KIỂM ĐỊNH] Nồng độ {0}% nằm ngoài tiêu chuẩn cho phép (0.1% - 95%)!", value));
                    return;
                }
                _nongDoHoatChat = value;
            }
        }

        public void InThongSoKiemDinh()
        {
            Console.WriteLine("==========================================================================");
            Console.WriteLine(" CÔNG TY NÔNG DƯỢC AN GIANG - PHIẾU KIỂM SOÁT THÔNG SỐ ĐÓNG GÓI THUỐC BVTV ");
            Console.WriteLine("==========================================================================");
            Console.WriteLine(string.Format("Mã đăng ký:          {0}", MaThuoc));
            Console.WriteLine(string.Format("Tên hoạt chất/thuốc: {0}", TenThuongMai));
            Console.WriteLine(string.Format("Quy cách đóng chai:  {0:N0} ml", DungTichMl));
            Console.WriteLine(string.Format("Nồng độ kiểm định:   {0:F1} %", NongDoHoatChat));
            Console.WriteLine("==========================================================================");
        }
    }
}
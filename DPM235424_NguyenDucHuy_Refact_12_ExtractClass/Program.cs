using System;
using DPM235424_NguyenDucHuy_Refact_12_ExtractClass.Before;
using DPM235424_NguyenDucHuy_Refact_12_ExtractClass.After;
using DPM235424_NguyenDucHuy_Refact_12_ExtractClass.Real;

namespace DPM235424_NguyenDucHuy_Refact_12_ExtractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine(">>> 1. DEMO CLASS: ExtractClass_Before <<<");
            var before = new ExtractClass_Before();
            Console.WriteLine($"Số điện thoại (Before): {before.GetTelephoneNumber()}");

            Console.WriteLine("\n>>> 2. DEMO CLASS: ExtractClass_After <<<");
            var after = new ExtractClass_After();
            after.OfficeTelephone.AreaCode = "0296";
            after.OfficeTelephone.Number = "3856789";
            Console.WriteLine($"Số điện thoại (After):  {after.GetTelephoneNumber()}");

            Console.WriteLine("\n>>> 3. DEMO CLASS: ExtractClass_Real (NÔNG DƯỢC AN GIANG) <<<");
            var real = new ExtractClass_Real
            {
                MaThuoc = "NDAG-FILIA-01",
                TenThuongMai = "Filia 525SE",
                QuyCachDongGoi = "Chai 250ml (Thùng 40 chai)",
                DonGiaNiemYet = 215000,
                HoatChat = new HoatChatNongDuoc
                {
                    TenHoatChat = "Propiconazole + Tricyclazole",
                    HamLuong = "125g/l + 400g/l",
                    NhomDocTinhWHO = "Nhóm III (Độc trung bình)",
                    CongDungChinh = "Đặc trị đạo ôn lá, đạo ôn cổ bông và lem lép hạt lúa"
                }
            };

            real.InNhanBaoBiThuoc();
        }
    }
}
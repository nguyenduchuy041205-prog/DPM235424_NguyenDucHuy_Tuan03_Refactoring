using System;
using DPM235424_NguyenDucHuy_Refact_27_EncapsulateField.Before;
using DPM235424_NguyenDucHuy_Refact_27_EncapsulateField.After;
using DPM235424_NguyenDucHuy_Refact_27_EncapsulateField.Real;

namespace DPM235424_NguyenDucHuy_Refact_27_EncapsulateField
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine(">>> 1. DEMO CLASS: EncapsulateField_Before <<<");
            var before = new EncapsulateField_Before();
            before._name = "Dữ liệu gán trực tiếp không qua bảo vệ";
            Console.WriteLine(string.Format("Giá trị trường public: {0}", before._name));

            Console.WriteLine("\n>>> 2. DEMO CLASS: EncapsulateField_After <<<");
            var after = new EncapsulateField_After();
            after.Name = "   Nguyễn Đức Huy   "; // Tự động trim khoảng trắng thừa
            Console.WriteLine(string.Format("Tên sau khi đóng gói: '{0}'", after.Name));

            Console.WriteLine("\n>>> 3. DEMO CLASS: EncapsulateField_Real (NÔNG DƯỢC AN GIANG) <<<");
            var real = new EncapsulateField_Real();
            real.MaThuoc = "ndag-anvil-5sc";
            real.TenThuongMai = "Anvil 5SC (Hexaconazole)";

            // Thử nghiệm gán giá trị hợp lệ
            real.DungTichMl = 1000; // Chai 1 lít
            real.NongDoHoatChat = 5.0; // 5% nồng độ
            real.InThongSoKiemDinh();

            // Thử nghiệm gán giá trị sai quy chuẩn để kiểm tra tính năng bảo vệ
            Console.WriteLine("\n--- Thử nghiệm gán giá trị không hợp lệ ---");
            real.DungTichMl = -250; // Sẽ kích hoạt cảnh báo
            real.NongDoHoatChat = 99.5; // Sẽ kích hoạt cảnh báo vượt ngưỡng
        }
    }
}
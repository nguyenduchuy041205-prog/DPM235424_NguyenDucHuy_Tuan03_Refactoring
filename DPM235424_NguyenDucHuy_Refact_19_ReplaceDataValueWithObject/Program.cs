using System;
using System.Collections.Generic;
using DPM235424_NguyenDucHuy_Refact_19_ReplaceDataValueWithObject.Before;
using DPM235424_NguyenDucHuy_Refact_19_ReplaceDataValueWithObject.After;
using DPM235424_NguyenDucHuy_Refact_19_ReplaceDataValueWithObject.Real;

namespace DPM235424_NguyenDucHuy_Refact_19_ReplaceDataValueWithObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine(">>> 1. DEMO CLASS: ReplaceDataValueWithObject_Before <<<");
            var before = new ReplaceDataValueWithObject_Before();
            var ordersBefore = new Before.Order[]
            {
                new Before.Order("Đại lý Ba Tri"),
                new Before.Order("Đại lý Chợ Mới"),
                new Before.Order("Đại lý Ba Tri")
            };
            Console.WriteLine($"Số đơn của 'Đại lý Ba Tri': {before.CountOrdersFor(ordersBefore, "Đại lý Ba Tri")}");

            Console.WriteLine("\n>>> 2. DEMO CLASS: ReplaceDataValueWithObject_After <<<");
            var after = new ReplaceDataValueWithObject_After();
            var ordersAfter = new After.Order[]
            {
                new After.Order("Đại lý Ba Tri"),
                new After.Order("Đại lý Chợ Mới"),
                new After.Order("Đại lý Ba Tri")
            };
            Console.WriteLine($"Số đơn của 'Đại lý Ba Tri': {after.CountOrdersFor(ordersAfter, "Đại lý Ba Tri")}");

            Console.WriteLine("\n>>> 3. DEMO CLASS: ReplaceDataValueWithObject_Real (NÔNG DƯỢC AN GIANG) <<<");
            var real = new ReplaceDataValueWithObject_Real();

            var daiLy1 = new DaiLyNongNghiep(
                mst: "1600123456",
                ten: "Đại lý Vật tư Nông nghiệp Phú Tân",
                diaChi: "TT. Phú Mỹ, H. Phú Tân, An Giang",
                sdt: "0296.3827111",
                hanMucNo: 50000000
            );

            var daiLy2 = new DaiLyNongNghiep(
                mst: "1600987654",
                ten: "Cửa hàng Phân bón & Thuốc BVTV Tri Tôn",
                diaChi: "TT. Tri Tôn, H. Tri Tôn, An Giang",
                sdt: "0296.3772888",
                hanMucNo: 20000000
            );

            var danhSachDonHang = new List<DonHangNongDuoc>
            {
                new DonHangNongDuoc("DH-NDAG-1901", daiLy1, 35000000),
                new DonHangNongDuoc("DH-NDAG-1902", daiLy2, 28000000)
            };

            real.KiemTraVaInDonHang(danhSachDonHang);
        }
    }
}
using System;

namespace DPM235424_NguyenDucHuy_Refact_16_IntroduceForeignMethod.After
{
    public class IntroduceForeignMethod_After
    {
        private DateTime _previousEnd = new DateTime(2026, 10, 1);

        public void SchedulePayment()
        {
            DateTime paymentDate = NextDay(_previousEnd);
            Console.WriteLine($"Ngày thanh toán (After): {paymentDate:dd/MM/yyyy}");
        }

        // Foreign Method: Đóng gói logic cho đối tượng DateTime mà ta không thể sửa class gốc
        private static DateTime NextDay(DateTime arg)
        {
            return new DateTime(arg.Year, arg.Month, arg.Day).AddDays(1);
        }
    }
}